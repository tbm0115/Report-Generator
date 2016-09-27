Imports NCalc, NCalcParser, NCalc.Expression
Imports System.Text.RegularExpressions

Public Class Program
  Private Shared _KILL As Boolean = False
  Private Shared _col As ColumnHeaders
  Private Shared _nvar(0 To 99) As NumericVariable
  Private Shared _svar(0 To 100) As AlphanumericVariable '' S(100) is used for INPUT variables
  Private Shared _cvar(0 To 99) As ConnectionVariable
  Private Shared _xvar(0 To 99) As XMLVariable
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

    'Debug.WriteLine(New String("*", 20))
    'Debug.WriteLine("Numeric")
    'For i = 0 To _nvar.Length - 1 Step 1
    '  If _nvar(i) IsNot Nothing Then
    '    Debug.WriteLine(vbTab & "V" & i.ToString & " = " & _nvar(i).Value)
    '  End If
    'Next
    'Debug.WriteLine("Alphanumeric")
    'For i = 0 To _svar.Length - 1 Step 1
    '  If _svar(i) IsNot Nothing Then
    '    Debug.WriteLine(vbTab & "S" & i.ToString & " = " & _svar(i).Value)
    '  End If
    'Next
    'Debug.WriteLine("Connection")
    'For i = 0 To _cvar.Length - 1 Step 1
    '  If _cvar(i) IsNot Nothing Then
    '    Debug.WriteLine(vbTab & "C" & i.ToString & " = " & _cvar(i).CommandString)
    '  End If
    'Next
    'Debug.WriteLine("XML")
    'For i = 0 To _xvar.Length - 1 Step 1
    '  If _xvar(i) IsNot Nothing Then
    '    Debug.WriteLine(vbTab & "X" & i.ToString & " = " & _xvar(i).CommandString)
    '  End If
    'Next
    'Debug.WriteLine(New String("*", 20))

    Return True
  End Function

  Public Sub Kill()
    _KILL = True '' Allow the process to kill itself
  End Sub

  Public Shared Function RunInner(ByVal Lines As List(Of String)) As Boolean 'ByVal Lines As String()) As Boolean
    Dim valIndex, curLine As Integer
    Dim line As String
    For i = 0 To Lines.Count - 1 Step 1 'For i = 0 To Lines.Length - 1 Step 1
      If _KILL Then Return False '' Start Killing process
      line = Lines.Item(i) '' Set current line
      splsh.SetProgress(line, curLine, Lines.Count) '' Update Splash screen


      'If line.Contains("//") Then line = line.Remove(line.IndexOf("//")) '' Remove comments

      Dim strTemp, strIFCond As String
      If Parser.Check.IfStatement(line, strTemp, strIFCond) Then
        'Dim mat As Match = New Regex("IF\((.*)\)\{(.*)}").Match(line)
        strTemp = ReplaceValues(strTemp)
        If New Expression(strTemp).Evaluate = True Then '' Use Ncalc to determine if true
          line = strIFCond
        Else
          Debug.WriteLine(New String(vbTab, 3) & "Evaluation failed '" & strTemp & "'...")
          line = "//Not true expression"
        End If
      End If

      If Parser.Check.HeaderStatement(line) Then '' Create report headers
        _col = New ColumnHeaders(line)
      ElseIf Parser.Check.NumericStatement(line) Then '' Create numeric variable
        '' Parse for variable index
        valIndex = GetIndex(line)
        '' Create reference
        '_nvar(valIndex) = New NumericVariable(line)
        If _nvar(valIndex) Is Nothing Then
          _nvar(valIndex) = New NumericVariable(line)
        Else
          _nvar(valIndex).Run(line)
        End If
      ElseIf Parser.Check.AlphanumericStatement(line) Then '' Create alphanumeric variable
        '' Parse for variable index
        valIndex = GetIndex(line)
        '' Create reference
        _svar(valIndex) = New AlphanumericVariable(line)
      ElseIf Parser.Check.ConnectionOpenStatement(line) Then '' Create connection variable
        '' Parse for variable index
        valIndex = GetIndex(line)
        Dim sendLines As New List(Of String) '' Contains inner commands
        Do Until Lines.Item(i).IndexOf("}C(" & valIndex.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 '' Parse until closing bracket
          i += 1
          If Not Lines.Item(i).IndexOf("}C(" & valIndex.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
            sendLines.Add(Lines.Item(i))
          Else
            Exit Do
          End If
        Loop
        '' Create reference
        _cvar(valIndex) = New ConnectionVariable(line) '' Use line instead of _lines because i is overwritten
        '' Run inner code in object
        _cvar(valIndex).Run(sendLines)
      ElseIf Parser.ConnectionCloseStatement(line) Then '' Connection closed
        '' Deprecated due to error...
      ElseIf Parser.XMLOpenStatement(line) Then
        '' Parse for variable index
        valIndex = GetIndex(line)
        Dim sendLines As New List(Of String) '' Contains inner commands
        Do Until Lines.Item(i).IndexOf("}X(" & valIndex.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 '' Parse until closing bracket
          i += 1
          If Not Lines.Item(i).IndexOf("}X(" & valIndex.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
            sendLines.Add(Lines.Item(i))
          Else
            Exit Do
          End If
        Loop
        '' Create reference
        _xvar(valIndex) = New XMLVariable(line) '' Use line instead of _lines because i is overwritten
        '' Run inner code in object
        _xvar(valIndex).Run(sendLines)
      ElseIf Parser.XMLCloseStatement(line) Then
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
            Dim xidx As Integer = GetIndex(strVal)
            If strVal.IndexOf("C(" & xidx & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then '' Is connection value
              dr.Item(idx) = _cvar(xidx).Value(GetIndex(strVal, True))
            ElseIf strVal.IndexOf("V(" & xidx & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then '' Is numeric value
              dr.Item(idx) = _nvar(xidx).Value
            ElseIf strVal.IndexOf("S(" & xidx & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then '' Is alphanumeric value
              If strVal.Contains(Chr(34)) Then strVal = strVal.Replace(Chr(34), "") '' Remove double quotes
              dr.Item(idx) = _svar(xidx).Value
            ElseIf strVal.IndexOf("X(" & xidx & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then '' Is Xml value
              If strVal.IndexOf("X(" & xidx & ")(" & Chr(34), System.StringComparison.OrdinalIgnoreCase) >= 0 Then
                dr.Item(idx) = _xvar(xidx).Value(_xvar(xidx).Index, XMLVariable.XmlNodeValueType.NodeAttribute, GetString(strVal, True))
              Else
                dr.Item(idx) = _xvar(xidx).Value(_xvar(xidx).Index, XMLVariable.XmlNodeValueType.NodeInnerText)
              End If
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
        input.Run(sendLines)
      ElseIf Parser.Check.AutoSort(line) Then
        If Not IsNothing(_src) Then
          _asort = Parser.Parse.AutoSort(line)
        Else
          Debug.WriteLine("DataSet doesn't exist for AutoSort command")
        End If
      ElseIf String.IsNullOrEmpty(line) Then

      Else
        splsh.SetProgress("DID NOT RECOGNIZE COMMAND!", i, Lines.Count) 'Lines.Length)
        Debug.WriteLine("Didn't recognize command:" & vbLf & vbTab & line)
      End If
    Next
    Return True
  End Function

  Public Shared Function ReplaceValues(ByVal Input As String) As String
    '' Check for each xml variables
    For i = 0 To _xvar.Length - 1 Step 1
      If _xvar(i) IsNot Nothing Then
        If Input.IndexOf("X(" & i.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
          '' Input string contains xml variable at index 'i'
          For j = 0 To _xvar(i).ValueLength - 1 Step 1 '' For each value in query...
            If Input.IndexOf("X(" & i.ToString & ")(" & Chr(34), System.StringComparison.OrdinalIgnoreCase) >= 0 Then '' If Input string contains reference to current xml variable and the current value index...
              Dim searchIndex As String = "X(" & i.ToString & ")(" & Chr(34)
              Dim strTemp As String = Input.Remove(0, Input.IndexOf(searchIndex, System.StringComparison.OrdinalIgnoreCase) + searchIndex.Length)
              strTemp = strTemp.Remove(strTemp.IndexOf(Chr(34) & ")"))
              '' Treat it as string
              Input = Input.Replace(searchIndex & strTemp & Chr(34) & ")", _xvar(i).Value(j, XMLVariable.XmlNodeValueType.NodeAttribute, strTemp).ToString)
            Else
              '' Treat it as string
              Input = Input.Replace("X(" & i.ToString & ")", _xvar(i).Value(j, XMLVariable.XmlNodeValueType.NodeInnerText).ToString)
            End If
          Next
        End If
      End If
    Next
    '' Check for each connection variables
    For i = 0 To _cvar.Length - 1 Step 1
      If _cvar(i) IsNot Nothing Then
        If Input.IndexOf("C(" & i.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
          '' Input string contains connection variable at index 'i'
          For j = 0 To _cvar(i).ValueLength - 1 Step 1 '' For each value in query...
            If Input.IndexOf("C(" & i.ToString & ")(" & j.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then '' If Input string contains reference to current connection variable and the current value index...
              If (Input.IndexOf("+") >= 0 Or Input.IndexOf("*") >= 0 Or Input.IndexOf("-") >= 0 Or Input.IndexOf("/") >= 0 Or Input.IndexOf("\") >= 0) And String.IsNullOrEmpty(_cvar(i).Value(j).ToString) Then
                '' Input string appears to be part of a numeric expression. So if the value is empty, set it to zero.
                Input = Input.Replace("C(" & i.ToString & ")(" & j.ToString & ")", "0")
              Else
                '' Treat it as string
                Input = Input.Replace("C(" & i.ToString & ")(" & j.ToString & ")", _cvar(i).Value(j).ToString)
              End If
            End If
          Next
        End If
      End If
    Next
    '' Check for numeric variables
    For i = 0 To _nvar.Length - 1 Step 1
      If Input.IndexOf("V(" & i.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
        ''Input string contains numeric variable at index 'i'
        Input = Input.Replace("V(" & i.ToString & ")", _nvar(i).Value.ToString)
      End If
    Next
    '' Check for alphanumeric variables
    For i = 0 To _svar.Length - 1 Step 1
      If Input.IndexOf("S(" & i.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
        ''Input string contains alphanumeric variable at index 'i'
        Input = Input.Replace("S(" & i.ToString & ")", _svar(i).Value.ToString)
      End If
    Next
    Return Input
  End Function
  Public Shared Function GetVariables(ByVal Input As String) As SortedList(Of String, String)
    Dim sl As New SortedList(Of String, String)
    '' Check for each xml variables
    For i = 0 To _xvar.Length - 1 Step 1
      If _xvar(i) IsNot Nothing Then
        If Input.IndexOf("X(" & i.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
          '' Input string contains xml variable at index 'i'
          For j = 0 To _xvar(i).ValueLength - 1 Step 1 '' For each value in query...
            If Input.IndexOf("X(" & i.ToString & ")(" & Chr(34), System.StringComparison.OrdinalIgnoreCase) >= 0 Then '' If Input string contains reference to current xml variable and the current value index...
              Dim searchIndex As String = "X(" & i.ToString & ")(" & Chr(34)
              Dim strTemp As String = Input.Remove(0, Input.IndexOf(searchIndex, System.StringComparison.OrdinalIgnoreCase) + searchIndex.Length)
              strTemp = strTemp.Remove(strTemp.IndexOf(Chr(34) & ")"))
              '' Treat it as string
              'Input = Input.Replace(searchIndex & strTemp & Chr(34) & ")", _xvar(i).Value(j, XMLVariable.XmlNodeValueType.NodeAttribute, strTemp).ToString)
              sl.Add(searchIndex & strTemp & Chr(34) & ")", _xvar(i).Value(j, XMLVariable.XmlNodeValueType.NodeAttribute, strTemp))
            ElseIf Input.IndexOf("X(" & i.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
              '' Treat it as string
              'Input = Input.Replace("X(" & i.ToString & ")", _xvar(i).Value(j, XMLVariable.XmlNodeValueType.NodeInnerText).ToString)
              sl.Add("X(" & i.ToString & ")", _xvar(i).Value(j, XMLVariable.XmlNodeValueType.NodeInnerText).ToString)
            End If
          Next
        End If
      End If
    Next
    '' Check for each connection variables
    For i = 0 To _cvar.Length - 1 Step 1
      If _cvar(i) IsNot Nothing Then
        If Input.IndexOf("C(" & i.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
          '' Input string contains connection variable at index 'i'
          For j = 0 To _cvar(i).ValueLength - 1 Step 1 '' For each value in query...
            If Input.IndexOf("C(" & i.ToString & ")(" & j.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then '' If Input string contains reference to current connection variable and the current value index...
              If (Input.IndexOf("+") >= 0 Or Input.IndexOf("*") >= 0 Or Input.IndexOf("-") >= 0 Or Input.IndexOf("/") >= 0 Or Input.IndexOf("\") >= 0) And String.IsNullOrEmpty(_cvar(i).Value(j).ToString) Then
                '' Input string appears to be part of a numeric expression. So if the value is empty, set it to zero.
                sl.Add("C(" & i.ToString & ")(" & j.ToString & ")", "0")
              Else
                '' Treat it as string
                sl.Add("C(" & i.ToString & ")(" & j.ToString & ")", _cvar(i).Value(j).ToString)
              End If
            End If
          Next
        End If
      End If
    Next
    '' Check for numeric variables
    For i = 0 To _nvar.Length - 1 Step 1
      If Input.IndexOf("V(" & i.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
        sl.Add("V(" & i.ToString & ")", _nvar(i).Value.ToString)
      End If
    Next
    '' Check for alphanumeric variables
    For i = 0 To _svar.Length - 1 Step 1
      If Input.IndexOf("S(" & i.ToString & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
        sl.Add("S(" & i.ToString & ")", _svar(i).Value.ToString)
      End If
    Next
    Return sl
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
  Public Shared Function GetString(ByVal Input As String, Optional ByVal LastIndex As Boolean = False) As String
    If Not LastIndex Then '' Get first index value
      Return Input.Remove(Input.IndexOf(Chr(34) & ")")).Remove(0, Input.IndexOf("(" & Chr(34)) + 2)
    ElseIf LastIndex Then '' Get last index value
      Return Input.Remove(Input.LastIndexOf(Chr(34) & ")")).Remove(0, Input.LastIndexOf("(" & Chr(34)) + 2)
    Else
      Return "" '' Don't know what the heck happened...
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
    Private _raw As String
    Private _exp As Expression

    Public Property Value As Double
      Get
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
    Public ReadOnly Property RawCommand As String
      Get
        Return _raw
      End Get
    End Property

    Public Sub New(ByVal RawCode As String)
      _idx = GetIndex(RawCode) '' Get index from code
      '_nvar(_idx) = Me
      _raw = RawCode
      Run(_raw)
    End Sub
    Public Sub New(ByVal Index As Integer)
      _idx = Index
      '_nvar(_idx) = Me
    End Sub

    Public Sub Run(ByVal Input As String)
      '' Create reference
      If Input.IndexOf("=") >= 0 Then
        Input = Input.Remove(0, Input.IndexOf("=") + 1)
      End If
      _exp = New Expression(Input.Replace("(", "").Replace(")", ""), EvaluateOptions.NoCache)
      Dim sl As SortedList(Of String, String) = GetVariables(Input)
      _exp.Parameters.Clear()
      For i = 0 To sl.Count - 1 Step 1
        _exp.Parameters(sl.Keys(i).Replace("(", "").Replace(")", "")) = sl.Values(i)
      Next
      'Input = ReplaceValues(Input)
      If Not _exp.HasErrors Then
        Dim obj As Object = _exp.Evaluate()
        Double.TryParse(obj, _val)
      Else
        Dim msg As String = Input & " Failed" & vbCrLf
        For i = 0 To _exp.Parameters.Count - 1 Step 1
          msg += vbTab & _exp.Parameters.Keys(i) & "=" & _exp.Parameters.Values(i) & vbCrLf
        Next
        'MessageBox.Show(msg)
      End If
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
    Implements IDisposable

    Private _strcnn, _strcmd As String
    Private _olecnn As OleDb.OleDbConnection
    Private _olecmd As OleDb.OleDbCommand
    Private _idx, _cur As Integer
    Private _val As DataTable

    Public Property ConnectionString As String
      Get
        Return _strcnn
      End Get
      Set(value As String)
        _strcnn = value
      End Set
    End Property
    Public Property CommandString As String
      Get
        Return _strcmd
      End Get
      Set(value As String)
        _strcmd = value
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
      _strcnn = Parser.Parse.ConnectionString(RawCode) 'mat.Groups(1).Value.ToString '' Gets connection string
      _strcmd = Parser.Parse.CommandString(RawCode) 'mat.Groups(2).Value.ToString '' Gets command
      _strcmd = ReplaceValues(_strcmd) '' Replace any values as necessary
      Dim callback As String = FillDataSet()
      If Not String.IsNullOrEmpty(callback) Then Throw New ArgumentException(callback)
      _cvar(_idx) = Me
    End Sub
    Public Sub New(ByVal Index As Integer, ByVal Connection As String, ByVal Command As String)
      _idx = Index
      _strcnn = Connection
      _strcmd = Command
      _cvar(_idx) = Me
    End Sub

    Private Function FillDataSet() As String
      If String.IsNullOrEmpty(_strcnn) Or String.IsNullOrEmpty(_strcmd) Then Return "Connection||Command are empty..."
      Try
        If _olecnn Is Nothing Then _olecnn = New OleDb.OleDbConnection(_strcnn)
        If Not _olecnn.State = ConnectionState.Open Then _olecnn.Open()

        If _olecmd Is Nothing Then _olecmd = New OleDb.OleDbCommand(_strcmd, _olecnn)
        _olecmd.CommandText = ReplaceValues(_olecmd.CommandText)
        Using Ada As New OleDb.OleDbDataAdapter(_olecmd)
          _val = New DataTable
          Ada.Fill(_val)
        End Using
        Return ""
      Catch ex As Exception
        Return ex.Message
      End Try
    End Function

    Public Function Run(ByVal Lines As List(Of String)) As Boolean
      If _val.Rows.Count <= 0 Then Debug.WriteLine("NO DATA IN QUERY! '" & _strcmd & "'")
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

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
      If Not Me.disposedValue Then
        If disposing Then
          ' TODO: dispose managed state (managed objects).
          _strcnn = Nothing
          _strcmd = Nothing
          If _olecnn IsNot Nothing Then _olecnn.Dispose()
          If _olecmd IsNot Nothing Then _olecmd.Dispose()
          _idx = Nothing
          _cur = Nothing
          If _val IsNot Nothing Then _val.Dispose()
        End If

        ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
        ' TODO: set large fields to null.
      End If
      Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    Protected Overrides Sub Finalize()
      ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
      Dispose(False)
      MyBase.Finalize()
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
      ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
      Dispose(True)
      GC.SuppressFinalize(Me)
    End Sub
#End Region

  End Class
  Public Class XMLVariable
    Implements IDisposable

    Private _strcnn As String
    Private _xmlcnn As Xml.XmlDocument
    Private _xmlcmd As String
    Private _idx, _cur As Integer
    Private _val As Xml.XmlNodeList

    Public Property ConnectionString As String
      Get
        Return _strcnn
      End Get
      Set(value As String)
        _strcnn = value
      End Set
    End Property
    Public Property CommandString As String
      Get
        Return _xmlcmd
      End Get
      Set(value As String)
        _xmlcmd = value
      End Set
    End Property
    Public ReadOnly Property Index As Integer
      Get
        Return _idx
      End Get
    End Property
    Public ReadOnly Property Nodes As Xml.XmlNodeList
      Get
        Return _val
      End Get
    End Property
    Public ReadOnly Property ValueLength As Integer
      Get
        If _cur < 0 Then Throw New ArgumentException("No current instance within the selected datatable!")
        If IsNothing(_val) Then FillDataSet()
        Return _val.Count
      End Get
    End Property

    Public Sub New(ByVal RawCode As String)
      _idx = GetIndex(RawCode) '' Get index from code
      _strcnn = Parser.Parse.XmlDocumentString(RawCode) 'mat.Groups(1).Value.ToString '' Gets connection string
      _xmlcmd = Parser.Parse.XmlXPathString(RawCode) 'mat.Groups(2).Value.ToString '' Gets command
      _xmlcmd = ReplaceValues(_xmlcmd) '' Replace any values as necessary
      Dim callback As String = FillDataSet()
      If Not String.IsNullOrEmpty(callback) Then Throw New ArgumentException(callback)
      _xvar(_idx) = Me
    End Sub
    Public Sub New(ByVal Index As Integer, ByVal Connection As String, ByVal Command As String)
      _idx = Index
      _strcnn = Connection
      _xmlcmd = Command
      _xvar(_idx) = Me
    End Sub

    Private Function FillDataSet() As String
      If String.IsNullOrEmpty(_strcnn) Or String.IsNullOrEmpty(_xmlcmd) Then Return "Connection||Command are empty..."
      Try
        If _xmlcnn Is Nothing Then
          _xmlcnn = New Xml.XmlDocument
          _xmlcnn.Load(_strcnn)
        End If

        _val = _xmlcnn.SelectNodes(_xmlcmd)
        Return ""
      Catch ex As Exception
        Return ex.Message
      End Try
    End Function

    Public Function Run(ByVal Lines As List(Of String)) As Boolean
      If _val.Count <= 0 Then Debug.WriteLine("NO DATA IN QUERY! '" & _xmlcmd & "'")
      For j = 0 To _val.Count - 1 Step 1
        If _KILL Then Return False '' Start Killing process
        _cur = j
        RunInner(Lines)
      Next
      Return True
    End Function

    Public Enum XmlNodeValueType
      NodeAttribute
      NodeInnerText
    End Enum
    Public Function Value(ByVal Index As Integer, ByVal NodeType As XmlNodeValueType, Optional ByVal AttributeName As String = "") As String
      If _cur < 0 Or _cur >= _val.Count Then Throw New IndexOutOfRangeException
      If NodeType = XmlNodeValueType.NodeAttribute And String.IsNullOrEmpty(AttributeName) Then Throw New ArgumentException("An attribute name must be provided when using XmlNodeType.NodeAttribute!")
      If IsNothing(_val) Then FillDataSet()

      If NodeType = XmlNodeValueType.NodeInnerText Then
        If _val(_cur).NodeType = Xml.XmlNodeType.Element Then
          Return _val(_cur).InnerText
        Else
          Throw New ArgumentException("Cannot return InnerText from anything other than an XmlElement!")
        End If
      ElseIf NodeType = XmlNodeValueType.NodeAttribute Then
        If _val(_cur).NodeType = Xml.XmlNodeType.Element Then
          If _val(_cur).Attributes(AttributeName) IsNot Nothing Then
            Return _val(_cur).Attributes(AttributeName).Value
          Else
            Throw New ArgumentException("Could not find XmlAttribute '" & AttributeName & "' in XmlElement '" & _val(_cur).Name & "'!")
          End If
        ElseIf _val(_cur).NodeType = Xml.XmlNodeType.Attribute And _val(_cur).Name = AttributeName Then
          Return _val(_cur).Value
        Else
          Throw New ArgumentException("Invalid reference to an Xml Object! Either the node type did not equal an XmlElement or the attribute name did not match the one provided in the routine.")
        End If
      Else
        Throw New ArgumentException("Invalid NodeValueType!")
      End If
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
      If Not Me.disposedValue Then
        If disposing Then
          ' TODO: dispose managed state (managed objects).
        End If

        ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
        ' TODO: set large fields to null.
      End If
      Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    Protected Overrides Sub Finalize()
      ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
      Dispose(False)
      MyBase.Finalize()
    End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
      ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
      Dispose(True)
      GC.SuppressFinalize(Me)
    End Sub
#End Region

  End Class
End Class
