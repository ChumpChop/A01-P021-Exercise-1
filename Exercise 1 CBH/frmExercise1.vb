Public Class frmExercise1
    Private Sub btnShowText_Click(sender As Object, e As EventArgs) Handles btnShowText.Click
        MessageBox.Show(txtEnterSomeText.Text, "This is the text you entered")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
