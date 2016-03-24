Imports System.Windows.Forms

Public Class Date_Range
  Private _strt, _end As Date
  Private _vals As String()
  Public ReadOnly Property Inputs As List(Of String)
    Get
      Return _vals.ToList
    End Get
  End Property

  Public Sub New(ByVal Label As String)
    InitializeComponent()

    grpLabel.Text = Label
    datStart.Focus()
  End Sub
  Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
    If datStart.Value = datEnd.Value Then
      '' Just a single date
      HelperClass.AppendArray(_vals, datStart.Value.ToShortDateString)
    Else
      '' Add dates between and including start and end dates
      Dim cur As Date = datStart.Value
      While (cur <= datEnd.Value)
        HelperClass.AppendArray(_vals, "#" & cur.ToShortDateString & "#")
        cur.AddDays(1)
      End While
    End If

    Me.DialogResult = System.Windows.Forms.DialogResult.OK
    Me.Close()
  End Sub

  Private Sub datStart_ValueChanged(sender As Object, e As EventArgs) Handles datStart.ValueChanged
    If datStart.Value > datEnd.Value Then
      datEnd.Value = datStart.Value
    End If
    datEnd.MinDate = datStart.Value
  End Sub

  Private Sub datEnd_ValueChanged(sender As Object, e As EventArgs) Handles datEnd.ValueChanged
    If datStart.Value > datEnd.Value Then
      datStart.Value = datEnd.Value
    End If
    datStart.MaxDate = datEnd.Value
  End Sub

  Private Sub Date_Range_Shown(sender As Object, e As EventArgs) Handles Me.Shown
    datStart.Focus()
  End Sub
End Class
