Public Class Form1
    Dim vbIcon
    Dim vbButtons
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked = True Then
            vbIcon = vbCritical
        ElseIf RadioButton2.Checked = True Then
            vbIcon = vbInformation
        ElseIf RadioButton3.Checked = True Then
            vbIcon = vbQuestion
        ElseIf RadioButton4.Checked = True Then
            vbIcon = vbExclamation
        End If
        If RadioButton5.Checked = True Then
            vbButtons = vbOKOnly
        ElseIf RadioButton6.Checked = True Then
            vbButtons = vbOKCancel
        ElseIf RadioButton7.Checked = True Then
            vbButtons = vbAbortRetryIgnore
        ElseIf RadioButton8.Checked = True Then
            vbButtons = vbYesNo
        ElseIf RadioButton9.Checked = True Then
            vbButtons = vbYesNoCancel
        ElseIf RadioButton10.Checked = True Then
            vbButtons = vbRetryCancel
        End If
        If CheckBox1.Checked = True Then
            Me.Hide()
        End If
        MsgBox(TextBox2.Text, vbButtons + vbIcon, TextBox1.Text)
        If CheckBox1.Checked = True Then
            Me.Show()
        End If
    End Sub
End Class
