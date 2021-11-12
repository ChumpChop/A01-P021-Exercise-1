Public Class Form1

    Private Sub btnDisplay_Click(ByVal sender As System.Object, _
        ByVal e As System.EventArgs) Handles btnDisplay.Click
        'Display the contents of the text box
        MessageBox.Show(txtInput.Text, "Exercise 1")
    End Sub
End Class
