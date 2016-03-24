Namespace Parser
  Module Check
    Public Function IfStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      If Input.Trim().ToUpper.StartsWith("IF") Then
        Input = Input.Remove(0, Input.ToUpper.IndexOf("IF") + 2)
        If Input.Trim().StartsWith("(") And Input.Contains("){") Then
          Input = Input.Remove(0, Input.IndexOf("){") + 1)
          If Input.StartsWith("{") And Input.Contains("}") Then
            bln = True
          End If
        End If
      End If
      Return bln
    End Function
    Public Function HeaderStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      If Input.Trim().ToUpper.StartsWith("COL") Then
        Input = Input.Remove(0, Input.ToUpper.IndexOf("COL") + 3)
        If Input.Trim().StartsWith("=") Then
          Input = Input.Remove(0, Input.IndexOf("=") + 1)
          If Input.Trim().StartsWith("{") And Input.Contains("}") Then
            bln = True
          End If
        End If
      End If
      Return bln
    End Function
    Public Function NumericStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      If Input.Trim().ToUpper.StartsWith("V") Then
        Input = Input.Remove(0, Input.ToUpper.IndexOf("V") + 1)
        If Input.StartsWith("(") And Input.Contains(")") Then
          Input = Input.Remove(0, Input.IndexOf(")") + 1)
          If Input.Trim().StartsWith("=") Then
            bln = True
          End If
        End If
      End If
      Return bln
    End Function
    Public Function AlphanumericStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      If Input.Trim().ToUpper.StartsWith("S") Then
        Input = Input.Remove(0, Input.ToUpper.IndexOf("S") + 1)
        If Input.StartsWith("(") And Input.Contains(")") Then
          Input = Input.Remove(0, Input.IndexOf(")") + 1)
          If Input.Trim().StartsWith("=") Then
            bln = True
          End If
        End If
      End If
      Return bln
    End Function
    Public Function ConnectionOpenStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      If Input.Trim().ToUpper.StartsWith("C") Then
        Input = Input.Remove(0, Input.ToUpper.IndexOf("C") + 1)
        If Input.Trim().StartsWith("(") And Input.Contains(")(") Then
          Input = Input.Remove(0, Input.IndexOf(")(") + 1)
          If Input.StartsWith("(") And Input.Contains("){") Then
            bln = True
          End If
        End If
      End If
      Return bln
    End Function
    Public Function ConnectionCloseStatement(ByVal Input As String) As Boolean
      Return Input.Trim().ToUpper.StartsWith("}C(")
    End Function
    Public Function OutputStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      If Input.Trim().ToUpper.StartsWith("OUT({") Then
        Input = Input.Remove(0, Input.ToUpper.IndexOf("OUT({") + 5)
        If Input.Contains("})") Then
          bln = True
        End If
      End If
      Return bln
    End Function
    Public Function InputOpenStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      If Input.Trim().ToUpper.StartsWith("INPUT") Then
        Input = Input.Remove(0, Input.ToUpper.IndexOf("INPUT") + 5)
        If Input.Trim().StartsWith("(") And Input.Contains("){") Then
          bln = True
        End If
      End If
      Return bln
    End Function
    Public Function InputCloseStatement(ByVal Input As String) As Boolean
      Return Input.Trim().ToUpper.StartsWith("}INPUT")
    End Function
    Public Function AutoSort(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      If Input.Trim().ToUpper.StartsWith("SORT(" & Chr(34)) Then
        Input = Input.Remove(0, Input.ToUpper.IndexOf("SORT(" & Chr(34)) + 5)
        If Input.Contains(Chr(34) & ")") Then
          bln = True
        End If
      End If
      Return bln
    End Function
  End Module
  Module Parse
    Public Function ConnectionString(ByVal Input As String) As String
      If Input.Contains("C(") Then
        Input = Input.Remove(0, Input.IndexOf("C(") + 1)
        If Input.Contains(")(") Then
          Input = Input.Remove(0, Input.IndexOf(")") + 1)
          If Input.Contains(Chr(34) & "," & Chr(34)) Then
            Return Input.Remove(Input.IndexOf(Chr(34) & "," & Chr(34))).Remove(0, Input.IndexOf(Chr(34)) + 1)
          End If
        End If
      End If
      Return ""
    End Function
    Public Function CommandString(ByVal Input As String) As String
      If Input.Contains("C(") Then
        Input = Input.Remove(0, Input.IndexOf("C(") + 1)
        If Input.Contains(")(") Then
          Input = Input.Remove(0, Input.IndexOf(")") + 1)
          If Input.Contains(Chr(34) & "," & Chr(34)) And Input.Contains(Chr(34) & "){") Then
            Return Input.Remove(Input.IndexOf(Chr(34) & "){")).Remove(0, Input.IndexOf(Chr(34) & "," & Chr(34)) + 3)
          End If
        End If
      End If
      Return ""
    End Function
    Public Function InputType(ByVal Input As String) As String
      If Input.Contains("INPUT(") Then
        Input = Input.Remove(0, Input.IndexOf("INPUT(") + 6)
        If Input.Contains(Chr(34) & "," & Chr(34)) Then
          Return Input.Remove(Input.IndexOf(Chr(34) & "," & Chr(34))).Remove(0, Input.IndexOf(Chr(34)) + 1)
        End If
      End If
      Return ""
    End Function
    Public Function InputLabel(ByVal Input As String) As String
      If Input.Contains("INPUT(") Then
        Input = Input.Remove(0, Input.IndexOf("INPUT(") + 6)
        If Input.Contains(Chr(34) & "," & Chr(34)) And Input.Contains(Chr(34) & "){") Then
          Return Input.Remove(Input.IndexOf(Chr(34) & "){")).Remove(0, Input.IndexOf(Chr(34) & "," & Chr(34)) + 3)
        End If
      End If
      Return ""
    End Function
    Public Function AutoSort(ByVal Input As String) As String
      Dim out As String = ""
      If Input.Trim().ToUpper.StartsWith("SORT(" & Chr(34)) Then
        Input = Input.Remove(0, Input.ToUpper.IndexOf("SORT(" & Chr(34)) + 6)
        If Input.Contains(Chr(34) & ")") Then
          out = Input.Remove(Input.IndexOf(Chr(34) & ")"))
        End If
      End If
      Return out
    End Function
  End Module
End Namespace
Module HelperClass
  Public Sub AppendArray(ByRef ReferenceArray As Object(), ByVal NewObject As Object)
    If Not IsNothing(ReferenceArray) Then
      ReDim Preserve ReferenceArray(ReferenceArray.length)
    Else
      ReDim ReferenceArray(0)
    End If
    ReferenceArray(ReferenceArray.length - 1) = NewObject
  End Sub
End Module