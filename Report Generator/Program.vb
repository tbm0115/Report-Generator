Imports NCalc, NCalcParser, NCalc.Expression
Imports System.Text.RegularExpressions

Public Class Program
  Private Shared _KILL As Boolean = False
  Private Shared _col As ColumnHeaders
  Private Shared _nvar(0 To 99) As NumericVariable
  Private Shared _svar(0 To 100) As AlphanumericVariable '' S(100) is used for INPUT variables
  Private Shared _cvar(0 To 99) As ConnectionVariable
  Private _lines As New List(Of String)
  Private Shared _src As DataSet
  Private _file As String
  Private Shared splsh As Decompiling_Splash
  Private Shared _asort As String = ""
  Public ReadOnly Property FilePath As String
    Get
      Return _file
    End Get
  End Property
  Public ReadOnly Property Data As DataTable
    Get
      Return _src.Tables("Data")
    End Get
  End Property
  Public ReadOnly Property Source As DataSet
    Get
      Return _src
    End Get
  End Property
  Public ReadOnly Property AutoSortColumn As String
    Get
      Return _asort
    End Get
  End Property
  Public Sub New(Optional ByVal FilePath As String = "")
    _file = FilePath
    If Not String.IsNullOrEmpty(_file) Then
      If IO.File.Exists(_file) Then
        _lines = IO.File.ReadAllLines(_file).Select(Function(line) line).ToList()
      Else
        Throw New ArgumentException("Provided program file does not exist! '" & _file & "'.")
      End If
    End If
    If Not IsNothing(_src) Then _src.Dispose()
    _src = Nothing
    _KILL = False
  End Sub

  Public Function Run() As Boolean
    If _lines.Count <= 0 Then Return False 'If _lines.Length <= 0 Then Return False

    '' Show decompiling splash
    splsh = New Decompiling_Splash(Me)
    splsh.Show() '' Show user splash
    RunInner(_lines) '' Run inner lines of commands
    splsh.Close() '' Close user splash
    Return True
  End Function

  Public Sub Kill()
    _KILL = True '' Allow the process to kill itself
  End Sub

  Public Shared Function RunInner(ByVal Lines As List(Of String)) As Boolean 'ByVal Lines As String()) As Boolean
    Dim valIndex As Integer
    Dim line As String
    For i = 0 To Lines.Count - 1 Step 1 'For i = 0 To Lines.Length - 1 Step 1
      If _KILL Then Return False '' Start Killing process
      line = Lines.Item(i) '' Set current line
      splsh.SetProgress(line, i, Lines.Count) '' Update Splash screen

      If line.Contains("//") Then line = line.Remove(line.IndexOf("//")) '' Remove comments

      If Parser.Check.IfStatement(line) Then
        Dim mat As Match = New Regex("IF\((.*)\)\{(.*)}").Match(line)
        If New Expression(ReplaceValues(mat.Groups(1).Value)).Evaluate = True Then '' Use Ncalc to determine if true
          line = mat.Groups(2).Value
        Else
          Debug.WriteLine(New String(vbTab, 3) & "Evaluation failed '" & mat.Groups(1).Value & "'...")
          line = "//Not true expression"
        End If
      End If

      If Parser.Check.HeaderStatement(line) Then '' Create report headers
        _col = New ColumnHeaders(line)
      ElseIf Parser.Check.NumericStatement(line) Then '' Create numeric variable
        '' Parse for variable index
        valIndex = GetIndex(line)
        '' Create reference
        _nvar(valIndex) = New NumericVariable(line)
      ElseIf Parser.Check.AlphanumericStatement(line) Then '' Create alphanumeric variable
        '' Parse for variable index
        valIndex = GetIndex(line)
        '' Create reference
        _svar(valIndex) = New AlphanumericVariable(line)
      ElseIf Parser.Check.ConnectionOpenStatement(line) Then '' Create connection variable
        '' Parse for variable index
        valIndex = GetIndex(line)
        Dim sendLines As New List(Of String) '' Contains inner commands
        Do Until Lines.Item(i).Contains("}C(" & valIndex.ToString & ")") '' Parse until closing bracket
          i += 1
          If Not Lines.Item(i).Contains("}C(" & valIndex.ToString & ")") Then
            sendLines.Add(Lines.Item(i))
          Else
            Exit Do
          End If
        Loop
        '' Create reference
        _cvar(valIndex) = New ConnectionVariable(line) '' Use line instead of _lines because i is overwritten
        '' Run inner code in object
        Debug.WriteLine("Run: " & _cvar(valIndex).Run(sendLines).ToString)
      ElseIf Parser.ConnectionCloseStatement(line) Then '' Connection closed
        '' Deprecated due to error...
      ElseIf Parser.OutputStatement(line) Then '' Output collected data
        '' Verify existance of column headers
        If IsNothing(_src) Then
          _src = New DataSet
          _src.Tables.Add("Data")
        End If
        If _src.Tables("Data").Columns.Count <= 0 Then
          If Not IsNothing(_col) Then
            _col.SetDataHeaders()
          Else
            Throw New ArgumentException("Cannot add data before setting column headers!")
          End If
        End If
        '' Create new report row

        Dim dr As DataRow = _src.Tables("Data").NewRow()
        '' Verify that more than one data value is being added
        If line.Contains(",") Then
          line = line.Remove(line.LastIndexOf("}")).Remove(0, line.IndexOf("{") + 1)
          Dim idx As Integer = 0 ''Column index
          For Each strVal As String In line.Split(",") ''Parse array
            If strVal.Contains(Chr(34)) Then strVal = strVal.Replace(Chr(34), "") '' Remove double quotes
            If strVal.Trim().StartsWith("C(") Then '' Is connection value
              dr.Item(idx) = _cvar(GetIndex(strVal)).Value(GetIndex(strVal, True))
            ElseIf strVal.Trim().StartsWith("V(") Then '' Is numeric value
              dr.Item(idx) = _nvar(GetIndex(strVal)).Value
            ElseIf strVal.Trim().StartsWith("S(") Then '' Is alphanumeric value
              dr.Item(idx) = _svar(GetIndex(strVal)).Value
            Else
              Throw New ArgumentException("Couldn't determine the correct output type. '" & line & "'")
            End If
            idx += 1 '' Increment
          Next
        Else
          Throw New ArgumentException("Cannot add single data point data at this time...")
        End If
        If Not IsNothing(dr) Then
          _src.Tables("Data").Rows.Add(dr)
        End If
      ElseIf Parser.Check.InputOpenStatement(line) Then
        '' Parse for variable index
        Dim sendLines As New List(Of String) '' Contains inner commands
        Do Until Parser.Check.InputCloseStatement(line) '' Parse until closing bracket
          i += 1
          If Not Parser.Check.InputCloseStatement(Lines.Item(i)) Then
            sendLines.Add(Lines.Item(i))
          Else
            Exit Do
          End If
        Loop
        '' Create reference
        Dim input As New InputVariable(line)
        '' Run inner code in object
        Debug.WriteLine("Run: " & input.Run(sendLines).ToString)
      ElseIf Parser.Check.AutoSort(line) Then
        If Not IsNothing(_src) Then
          _asort = Parser.Parse.AutoSort(line)
        Else
          Debug.WriteLine("DataSet doesn't exist for AutoSort command")
        End If
      ElseIf String.IsNullOrEmpty(line) Then
        splsh.SetProgress("Empty line...", i, Lines.Count)
      Else
        splsh.SetProgress("DID NOT RECOGNIZE COMMAND!", i, Lines.Count) 'Lines.Length)
        Debug.WriteLine("Didn't recognize command:" & vbLf & vbTab & line)
      End If
    Next
    Return True
  End Function

  Public Shared Function ReplaceValues(ByVal Input As String) As String
    '' Check for each connection variables
    For i = 0 To _cvar.Length - 1 Step 1
      If Input.Contains("C(" & i.ToString & ")") Then
        '' Input string contains connection variable at index 'i'
        For j = 0 To _cvar(i).ValueLength - 1 Step 1 '' For each value in query...
          If Input.Contains("C(" & i.ToString & ")(" & j.ToString & ")") Then '' If Input string contains reference to current connection variable and the current value index...
            If (Input.Contains("+") Or Input.Contains("*") Or Input.Contains("-") Or Input.Contains("/") Or Input.Contains("\")) And String.IsNullOrEmpty(_cvar(i).Value(j).ToString) Then
              '' Input string appears to be part of a numeric expression. So if the value is empty, set it to zero.
              Input = Input.Replace("C(" & i.ToString & ")(" & j.ToString & ")", "0")
            Else
              '' Treat it as string
              Input = Input.Replace("C(" & i.ToString & ")(" & j.ToString & ")", _cvar(i).Value(j).ToString)
            End If
          End If
        Next
      End If
    Next
    '' Check for numeric variables
    For i = 0 To _nvar.Length - 1 Step 1
      If Input.Contains("V(" & i.ToString & ")") Then
        ''Input string contains numeric variable at index 'i'
        Input = Input.Replace("V(" & i.ToString & ")", _nvar(i).Value.ToString)
      End If
    Next
    '' Check for alphanumeric variables
    For i = 0 To _svar.Length - 1 Step 1
      If Input.Contains("S(" & i.ToString & ")") Then
        ''Input string contains alphanumeric variable at index 'i'
        Input = Input.Replace("S(" & i.ToString & ")", _svar(i).Value.ToString)
      End If
    Next
    Return Input
  End Function
  Public Shared Function GetIndex(ByVal Input As String, Optional ByVal LastIndex As Boolean = False) As Integer
    If Not LastIndex Then '' Get first index value
      Return Convert.ToInt32(Input.Remove(Input.IndexOf(")")).Remove(0, Input.IndexOf("(") + 1))
    ElseIf LastIndex Then '' Get last index value
      Return Convert.ToInt32(Input.Remove(Input.LastIndexOf(")")).Remove(0, Input.LastIndexOf("(") + 1))
    Else
      Return -1 '' Don't know what the heck happened...
    End If
  End Function

  Public Class ColumnHeaders
    Private _hds, _hdt As New List(Of String)
    Public Property Headers As List(Of String)
      Get
        Return _hds
      End Get
      Set(value As List(Of String))
        _hds = value
      End Set
    End Property
    Public ReadOnly Property Count As Integer
      Get
        Return _hds.Count '_hds.Length
      End Get
    End Property

    Public Sub New(Optional ByVal RawCode As String = "COL={}")
      If RawCode.Contains(Chr(34)) Then
        If RawCode.Contains(",") Then
          Dim reg As New Regex("(" & Chr(34) & "[A-Za-z0-9# \$]*" & Chr(34) & ")([#DS]?)[,|}]+")
          For Each mat As Match In reg.Matches(RawCode)
            If mat.Success Then
              For Each grp As Group In mat.Groups
                Debug.WriteLine("Matched: " & grp.Value)
              Next
              _hds.Add(mat.Groups(1).Value.Replace(Chr(34), ""))
              If Not IsNothing(mat.Groups(2)) Then
                _hdt.Add(mat.Groups(2).Value)
              Else
                _hdt.Add("S")
              End If
              'HelperClass.AppendArray(_hds, mat.Groups(1).Value.Replace(Chr(34), ""))
              'If Not IsNothing(mat.Groups(2)) Then
              '  HelperClass.AppendArray(_hdt, mat.Groups(2).Value)
              'Else
              '  HelperClass.AppendArray(_hdt, "S")
              'End If
              'If Not IsNothing(_hds) Then
              '  ReDim Preserve _hds(_hds.Length)
              '  ReDim Preserve _hdt(_hdt.Length)
              'Else
              '  ReDim _hds(0)
              '  ReDim _hdt(0)
              'End If
              '_hds(_hds.Length - 1) = mat.Groups(1).Value.Replace(Chr(34), "")
              'If Not IsNothing(mat.Groups(2)) Then
              '  _hdt(_hdt.Length - 1) = mat.Groups(2).Value
              'Else
              '  _hdt(_hdt.Length - 1) = "S"
              'End If

            Else
              Debug.WriteLine("'" & RawCode & "' couldn't match...")
            End If
          Next

        Else
          _hds.Add(RawCode)
          _hdt.Add("S")
          'HelperClass.AppendArray(_hds, RawCode)
          'HelperClass.AppendArray(_hdt, "S")
          'ReDim _hds(0)
          '_hds(0) = RawCode
          'ReDim _hdt(0)
          '_hdt(0) = "S"
        End If
      End If
    End Sub

    Public Sub Run(ByVal Input As String)
      '' Create report headers
      _col = New ColumnHeaders(Input)
    End Sub

    Public Function Code() As String
      Dim strOut As String = "COL={"
      If Not IsNothing(_hds) Then
        For Each item As String In _hds.ToArray
          strOut += Chr(34) & item & Chr(34) & ","
        Next
        If strOut.EndsWith(",") Then strOut = strOut.Remove(strOut.Length - 1)
      End If
      strOut += "}"
      Return strOut
    End Function
    Public Sub SetDataHeaders()
      If IsNothing(_src) Then
        _src = New DataSet
        _src.Tables.Add("Data")
      End If
      If _src.Tables("Data").Columns.Count <= 0 Then
        For i = 0 To _hds.Count - 1 Step 1 'For i = 0 To _hds.Length - 1 Step 1
          Select Case _hdt(i)
            Case "#"
              _src.Tables("Data").Columns.Add(_hds(i), Type.GetType("System.Double"))
            Case "D"
              _src.Tables("Data").Columns.Add(_hds(i), Type.GetType("System.DateTime"))
            Case Else
              _src.Tables("Data").Columns.Add(_hds(i), Type.GetType("System.String"))
          End Select
        Next
      End If
    End Sub
  End Class
  Public Class NumericVariable
    Private _val As Double
    Private _idx As Integer
    Private _tmp As String
    Public Property Value As Double
      Get
        If Not String.IsNullOrEmpty(_tmp) Then
          _val = New Expression(ReplaceValues(_tmp)).Evaluate
          _tmp = ""
        End If
        Return _val
      End Get
      Set(value As Double)
        _val = value
      End Set
    End Property
    Public ReadOnly Property Index As Integer
      Get
        Return _idx
      End Get
    End Property

    Public Sub New(ByVal RawCode As String)
      _idx = GetIndex(RawCode) '' Get index from code
      Dim value As String = RawCode.Remove(0, RawCode.IndexOf("=") + 1)
      If IsNumeric(value) And Not value.Contains("+") And Not value.Contains("-") And Not value.Contains("*") And Not value.Contains("/") Then
        _val = Convert.ToDouble(value) '' Get value from code
      Else
        _tmp = ReplaceValues(value)
        If Not New Expression(_tmp).HasErrors Then
          _val = Convert.ToDouble(New Expression(_tmp).Evaluate())
        End If
      End If
      _nvar(_idx) = Me
    End Sub
    Public Sub New(ByVal Index As Integer)
      _idx = Index
      _nvar(_idx) = Me
    End Sub

    Public Sub Run(ByVal Input As String)
      '' Create reference
      _nvar(GetIndex(Input)) = New NumericVariable(Input)
    End Sub

    Public Function Code_Set(Optional ByVal ComplexValue As String = "") As String
      Dim strOut As String = "V(" & _idx.ToString & ")="
      If String.IsNullOrEmpty(ComplexValue) Then
        strOut += _val.ToString
      Else
        strOut += ComplexValue
      End If
      Return strOut
    End Function
    Public Function Code_Get() As String
      Return "V(" & _idx.ToString & ")"
    End Function
  End Class
  Public Class AlphanumericVariable
    Private _val As String
    Private _idx As Integer
    Private _tmp As String

    Public Property Value As String
      Get
        If Not String.IsNullOrEmpty(_tmp) Then
          _val = ReplaceValues(_tmp)
          _tmp = ""
        End If
        Return _val
      End Get
      Set(value As String)
        _val = value
      End Set
    End Property
    Public ReadOnly Property Index As Integer
      Get
        Return _idx
      End Get
    End Property

    Public Sub New(ByVal RawCode As String)
      _idx = GetIndex(RawCode) '' Get index from code
      _val = RawCode.Remove(0, RawCode.IndexOf("=") + 1) '' Get value from code
      If _val.Contains(Chr(34)) Then
        _val = _val.Remove(_val.LastIndexOf(Chr(34))).Remove(0, _val.IndexOf(Chr(34)) + 1)
      End If
      _val = ReplaceValues(_val)
      _svar(_idx) = Me
    End Sub
    Public Sub New(ByVal Index As Integer)
      _idx = Index
      _svar(_idx) = Me
    End Sub

    Public Sub Run(ByVal Input As String)
      '' Create reference
      _svar(GetIndex(Input)) = New AlphanumericVariable(Input)
    End Sub

    Public Function Code_Set(Optional ByVal ComplexValue As String = "") As String
      Dim strOut As String = "S(" & _idx.ToString & ")="
      If String.IsNullOrEmpty(ComplexValue) Then
        strOut += _val.ToString
      Else
        strOut += ComplexValue
      End If
      Return strOut
    End Function
    Public Function Code_Get() As String
      Return "S(" & _idx.ToString & ")"
    End Function
  End Class
  Public Class InputVariable
    Private _lbl As String
    Private _vals As List(Of String)
    Private _ityp As InputType
    Public Enum InputType
      SingleInput
      MultipleInput
      DateRangeInput
    End Enum
    Public Sub New(ByVal RawCode As String)
      Dim inputType As String = Parser.Parse.InputType(RawCode)
      If Not String.IsNullOrEmpty(inputType) Then
        Select Case inputType.ToUpper()
          Case "SINGLE"
            _ityp = InputVariable.InputType.SingleInput
          Case "MULTIPLE"
            _ityp = InputVariable.InputType.MultipleInput
          Case "DATE"
            _ityp = InputVariable.InputType.DateRangeInput
          Case Else
            Throw New ArgumentException("Invalid INPUT type!'" & inputType & "'")
        End Select
      Else
        Throw New ArgumentException("Invalid INPUT type!'" & inputType & "'")
      End If
      _lbl = Parser.Parse.InputLabel(RawCode)
    End Sub

    Public Function Run(ByVal Lines As List(Of String)) As Boolean
      If IsNothing(_ityp) Then Throw New ArgumentException("Unknown INPUT type!")
      If IsNothing(_vals) Then
        Select Case _ityp
          Case InputType.SingleInput
            Dim si As New Single_String(_lbl)
            si.ShowDialog()
            If si.DialogResult = DialogResult.OK Then
              _vals = New List(Of String) '' Initialize array
              _vals.Add(si.Input)
            Else
              MessageBox.Show("Chose to discontinue report", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
              _KILL = True
            End If
          Case InputType.MultipleInput
            Dim mi As New Multiple_String(_lbl)
            mi.ShowDialog()
            If mi.DialogResult = DialogResult.OK Then
              _vals = New List(Of String) '' Initialize array
              _vals.AddRange(mi.Inputs)
            Else
              MessageBox.Show("Chose to discontinue report", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
              _KILL = True
            End If
          Case InputType.DateRangeInput
            Dim di As New Date_Range(_lbl)
            di.ShowDialog()
            If di.DialogResult = DialogResult.OK Then
              _vals = New List(Of String) '' Initialize array
              _vals.AddRange(di.Inputs)
            Else
              MessageBox.Show("Chose to discontinue report", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
              _KILL = True
            End If
          Case Else
            Throw New ArgumentException("Unknown INPUT type!")
        End Select
      End If
      If Not IsNothing(_vals) Then
        For Each v As String In _vals
          If _KILL Then Return False '' Start Killing process
          _svar(100) = New AlphanumericVariable("S(100) = " & Chr(34) & v & Chr(34))
          RunInner(Lines)
        Next
      Else
        If _KILL Then Return False '' Start Killing process
        Throw New ArgumentException("No valid data was input!")
      End If
      Return True
    End Function
  End Class
  Public Class ConnectionVariable
    Private _cnn, _cmd As String
    Private _idx, _cur As Integer
    Private _val As DataTable
    Public Property ConnectionString As String
      Get
        Return _cnn
      End Get
      Set(value As String)
        _cnn = value
      End Set
    End Property
    Public Property CommandString As String
      Get
        Return _cmd
      End Get
      Set(value As String)
        _cmd = value
      End Set
    End Property
    Public ReadOnly Property Index As Integer
      Get
        Return _idx
      End Get
    End Property
    Public ReadOnly Property Data As DataTable
      Get
        If FillDataSet() Then
          Return _val
        Else
          Return Nothing
        End If
      End Get
    End Property
    Public ReadOnly Property ValueLength As Integer
      Get
        If _cur < 0 Then Throw New ArgumentException("No current instance within the selected datatable!")
        If IsNothing(_val) Then FillDataSet()
        Return _val.Rows(_cur).ItemArray.Length
      End Get
    End Property

    Public Sub New(ByVal RawCode As String)
      _idx = GetIndex(RawCode) '' Get index from code
      _cnn = Parser.Parse.ConnectionString(RawCode) 'mat.Groups(1).Value.ToString '' Gets connection string
      _cmd = Parser.Parse.CommandString(RawCode) 'mat.Groups(2).Value.ToString '' Gets command
      _cmd = ReplaceValues(_cmd) '' Replace any values as necessary
      Dim callback As String = FillDataSet()
      If Not String.IsNullOrEmpty(callback) Then Throw New ArgumentException(callback)
      _cvar(_idx) = Me
    End Sub
    Public Sub New(ByVal Index As Integer, ByVal Connection As String, ByVal Command As String)
      _idx = Index
      _cnn = Connection
      _cmd = Command
      _cvar(_idx) = Me
    End Sub
    Public Sub Dispose()
      _cnn = ""
      _cmd = ""
      _val = Nothing
    End Sub

    Private Function FillDataSet() As String
      If String.IsNullOrEmpty(_cnn) Or String.IsNullOrEmpty(_cmd) Then Return "Connection||Command are empty..."
      Try
        Using Cnn As New OleDb.OleDbConnection(_cnn)
          Cnn.Open()
          Using Cmd As New OleDb.OleDbCommand(ReplaceValues(_cmd), Cnn)
            Using Ada As New OleDb.OleDbDataAdapter(Cmd)
              _val = New DataTable
              Ada.Fill(_val)
            End Using
          End Using
          Cnn.Close()
        End Using
        Return ""
      Catch ex As Exception
        Return ex.Message
      End Try
    End Function

    Public Function Run(ByVal Lines As List(Of String)) As Boolean
      If _val.Rows.Count <= 0 Then Debug.WriteLine("NO DATA IN QUERY! '" & _cmd & "'")
      For j = 0 To _val.Rows.Count - 1 Step 1
        If _KILL Then Return False '' Start Killing process
        _cur = j
        RunInner(Lines)
      Next
      Return True
    End Function
    Public Function Value(ByVal Index As Integer)
      If _cur < 0 Then Throw New ArgumentException("No current instance within the selected datatable!")
      If IsNothing(_val) Then FillDataSet()
      Return _val.Rows(_cur).Item(Index)
    End Function
  End Class
End Class
