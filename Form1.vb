Public Class frmMain
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtUserWeight.Text = ""
        lblConvertedWeightValue.Text = ""
        lblConvertedKgs.Text = ""
        radMars.Checked = False
        radVenus.Checked = True
        lblLbs.Visible = False
        lblKgs.Visible = False

    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        ' Check for empty or non-numeric value in weight
        If (String.IsNullOrEmpty(txtUserWeight.Text) Or Not IsNumeric(txtUserWeight.Text)) Then
            MsgBox("Weight entry is invalid. Try again.")
        Else
            Dim decEquiv = 0.0
            If (radVenus.Checked) Then
                decEquiv = 0.907
            ElseIf (radMars.Checked) Then
                decEquiv = 0.377
            End If
            Dim decConvertedWeight = txtUserWeight.Text * decEquiv
            lblConvertedWeightValue.Text = decConvertedWeight.ToString("F1")
            lblConvertedKgs.Text = (decConvertedWeight * 0.454).ToString("F1")
            lblLbs.Visible = True
            lblKgs.Visible = True
        End If
    End Sub
End Class
