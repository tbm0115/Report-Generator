Namespace Parser
  Module Check
    Public Function IfStatement(ByVal Input As String, Optional ByRef Condition As String = "", Optional ByRef Command As String = "") As Boolean
      Dim bln As Boolean = False
      Input = Input.Trim()
      If Input.IndexOf("IF", System.StringComparison.OrdinalIgnoreCase) = 0 Then
        Input = Input.Remove(0, Input.IndexOf("IF", System.StringComparison.OrdinalIgnoreCase) + 2)
        If Input.IndexOf("(") >= 0 And Input.IndexOf("){") >= 0 Then
          Condition = Input.Remove(Input.IndexOf("){")).Remove(0, Input.IndexOf("(") + 1) '' Set condition
          Input = Input.Remove(0, Input.IndexOf("){") + 1)
          If Input.IndexOf("{") = 0 And Input.LastIndexOf("}") >= 0 Then
            Command = Input.Remove(Input.LastIndexOf("}")).Remove(0, Input.IndexOf("{") + 1)
            bln = True
          End If
        End If
      End If
      Return bln
    End Function
    Public Function HeaderStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      Input = Input.Trim()
      If Input.IndexOf("COL", System.StringComparison.OrdinalIgnoreCase) = 0 Then
        Input = Input.Remove(0, Input.IndexOf("COL", System.StringComparison.OrdinalIgnoreCase) + 3)
        If Input.IndexOf("=") >= 0 Then
          Input = Input.Remove(0, Input.IndexOf("=") + 1)
          If Input.IndexOf("{") >= 0 And Input.IndexOf("}", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
            bln = True
          End If
        End If
      End If
      Return bln
    End Function
    Public Function NumericStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      Input = Input.Trim()
      If Input.IndexOf("V", System.StringComparison.OrdinalIgnoreCase) = 0 Then
        Input = Input.Remove(0, Input.IndexOf("V", System.StringComparison.OrdinalIgnoreCase) + 1)
        If Input.IndexOf("(") >= 0 And Input.IndexOf(")") >= 0 Then
          Input = Input.Remove(0, Input.IndexOf(")") + 1)
          If Input.IndexOf("=") >= 0 Then
            bln = True
          End If
        End If
      End If
      Return bln
    End Function
    Public Function AlphanumericStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      Input = Input.Trim()
      If Input.IndexOf("S", System.StringComparison.OrdinalIgnoreCase) = 0 Then
        Input = Input.Remove(0, Input.IndexOf("S", System.StringComparison.OrdinalIgnoreCase) + 1)
        If Input.IndexOf("(") >= 0 And Input.IndexOf(")") >= 0 Then
          Input = Input.Remove(0, Input.IndexOf(")") + 1)
          If Input.IndexOf("=") >= 0 Then
            bln = True
          End If
        End If
      End If
      Return bln
    End Function
    Public Function ConnectionOpenStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      Input = Input.Trim()
      If Input.IndexOf("C", System.StringComparison.OrdinalIgnoreCase) = 0 Then
        Input = Input.Remove(0, Input.IndexOf("C", System.StringComparison.OrdinalIgnoreCase) + 1)
        If Input.IndexOf("(") >= 0 And Input.IndexOf(")(") >= 0 Then
          Input = Input.Remove(0, Input.IndexOf(")(") + 1)
          If Input.IndexOf("(") >= 0 And Input.IndexOf("){") >= 0 Then
            bln = True
          End If
        End If
      End If
      Return bln
    End Function
    Public Function ConnectionCloseStatement(ByVal Input As String) As Boolean
      Input = Input.Trim()
      Return Input.IndexOf("}C(", System.StringComparison.OrdinalIgnoreCase) = 0
    End Function
    Public Function XMLOpenStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      Input = Input.Trim()
      If Input.IndexOf("X", System.StringComparison.OrdinalIgnoreCase) = 0 Then
        Input = Input.Remove(0, Input.IndexOf("X", System.StringComparison.OrdinalIgnoreCase) + 1)
        If Input.IndexOf("(") >= 0 And Input.IndexOf(")(") >= 0 Then
          Input = Input.Remove(0, Input.IndexOf(")(") + 1)
          If Input.IndexOf("(") >= 0 And Input.IndexOf("){") >= 0 Then
            bln = True
          End If
        End If
      End If
      Return bln
    End Function
    Public Function XMLCloseStatement(ByVal Input As String) As Boolean
      Input = Input.Trim()
      Return Input.IndexOf("}X(", System.StringComparison.OrdinalIgnoreCase) = 0
    End Function
    Public Function OutputStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      Input = Input.Trim()
      If Input.IndexOf("OUT({", System.StringComparison.OrdinalIgnoreCase) = 0 Then
        Input = Input.Remove(0, Input.IndexOf("OUT({", System.StringComparison.OrdinalIgnoreCase) + 5)
        If Input.IndexOf("})") >= 0 Then
          bln = True
        End If
      End If
      Return bln
    End Function
    Public Function InputOpenStatement(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      Input = Input.Trim()
      If Input.IndexOf("INPUT", System.StringComparison.OrdinalIgnoreCase) = 0 Then
        Input = Input.Remove(0, Input.IndexOf("INPUT", System.StringComparison.OrdinalIgnoreCase) + 5)
        If Input.IndexOf("(") >= 0 And Input.IndexOf("){") >= 0 Then
          bln = True
        End If
      End If
      Return bln
    End Function
    Public Function InputCloseStatement(ByVal Input As String) As Boolean
      Input = Input.Trim()
      Return Input.IndexOf("}INPUT", System.StringComparison.OrdinalIgnoreCase) = 0
    End Function
    Public Function AutoSort(ByVal Input As String) As Boolean
      Dim bln As Boolean = False
      Input = Input.Trim()
      If Input.IndexOf("SORT(" & Chr(34), System.StringComparison.OrdinalIgnoreCase) = 0 Then
        Input = Input.Remove(0, Input.IndexOf("SORT(" & Chr(34), System.StringComparison.OrdinalIgnoreCase) + 5)
        If Input.IndexOf(Chr(34) & ")", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
          bln = True
        End If
      End If
      Return bln
    End Function
  End Module
  Module Parse
    Public Function ConnectionString(ByVal Input As String) As String
      If Input.IndexOf("C(") >= 0 Then
        Input = Input.Remove(0, Input.IndexOf("C(", System.StringComparison.OrdinalIgnoreCase) + 1)
        If Input.IndexOf(")(") >= 0 Then
          Input = Input.Remove(0, Input.IndexOf(")") + 1)
          If Input.IndexOf(Chr(34) & "," & Chr(34)) >= 0 Then
            Return Input.Remove(Input.IndexOf(Chr(34) & "," & Chr(34))).Remove(0, Input.IndexOf(Chr(34)) + 1)
          End If
        End If
      End If
      Return ""
    End Function
    Public Function CommandString(ByVal Input As String) As String
      If Input.IndexOf("C(", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
        Input = Input.Remove(0, Input.IndexOf("C(", System.StringComparison.OrdinalIgnoreCase) + 1)
        If Input.IndexOf(")(") >= 0 Then
          Input = Input.Remove(0, Input.IndexOf(")") + 1)
          If Input.IndexOf(Chr(34) & "," & Chr(34)) >= 0 And Input.IndexOf(Chr(34) & "){") >= 0 Then
            Return Input.Remove(Input.IndexOf(Chr(34) & "){")).Remove(0, Input.IndexOf(Chr(34) & "," & Chr(34)) + 3)
          End If
        End If
      End If
      Return ""
    End Function
    Public Function InputType(ByVal Input As String) As String
      If Input.IndexOf("INPUT(", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
        Input = Input.Remove(0, Input.IndexOf("INPUT(", System.StringComparison.OrdinalIgnoreCase) + 6)
        If Input.IndexOf(Chr(34) & "," & Chr(34)) >= 0 Then
          Return Input.Remove(Input.IndexOf(Chr(34) & "," & Chr(34))).Remove(0, Input.IndexOf(Chr(34)) + 1)
        End If
      End If
      Return ""
    End Function
    Public Function InputLabel(ByVal Input As String) As String
      If Input.IndexOf("INPUT(", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
        Input = Input.Remove(0, Input.IndexOf("INPUT(", System.StringComparison.OrdinalIgnoreCase) + 6)
        If Input.IndexOf(Chr(34) & "," & Chr(34)) >= 0 And Input.IndexOf(Chr(34) & "){") >= 0 Then
          Return Input.Remove(Input.IndexOf(Chr(34) & "){")).Remove(0, Input.IndexOf(Chr(34) & "," & Chr(34)) + 3)
        End If
      End If
      Return ""
    End Function
    Public Function AutoSort(ByVal Input As String) As String
      Dim out As String = ""
      If Input.IndexOf("SORT(" & Chr(34), System.StringComparison.OrdinalIgnoreCase) >= 0 Then
        Input = Input.Remove(0, Input.IndexOf("SORT(" & Chr(34), System.StringComparison.OrdinalIgnoreCase) + 6)
        If Input.IndexOf(Chr(34) & ")") >= 0 Then
          out = Input.Remove(Input.IndexOf(Chr(34) & ")"))
        End If
      End If
      Return out
    End Function
    Public Function XmlDocumentString(ByVal Input As String) As String
      If Input.IndexOf("X(") >= 0 Then
        Input = Input.Remove(0, Input.IndexOf("X(", System.StringComparison.OrdinalIgnoreCase) + 1)
        If Input.IndexOf(")(") >= 0 Then
          Input = Input.Remove(0, Input.IndexOf(")") + 1)
          If Input.IndexOf(Chr(34) & "," & Chr(34)) >= 0 Then
            Return Input.Remove(Input.IndexOf(Chr(34) & "," & Chr(34))).Remove(0, Input.IndexOf(Chr(34)) + 1)
          End If
        End If
      End If
      Return ""
    End Function
    Public Function XmlXPathString(ByVal Input As String) As String
      If Input.IndexOf("X(", System.StringComparison.OrdinalIgnoreCase) >= 0 Then
        Input = Input.Remove(0, Input.IndexOf("X(", System.StringComparison.OrdinalIgnoreCase) + 1)
        If Input.IndexOf(")(") >= 0 Then
          Input = Input.Remove(0, Input.IndexOf(")") + 1)
          If Input.IndexOf(Chr(34) & "," & Chr(34)) >= 0 And Input.IndexOf(Chr(34) & "){") >= 0 Then
            Return Input.Remove(Input.IndexOf(Chr(34) & "){")).Remove(0, Input.IndexOf(Chr(34) & "," & Chr(34)) + 3)
          End If
        End If
      End If
      Return ""
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