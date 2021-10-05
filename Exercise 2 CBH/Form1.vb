Public Class Form1
    Private Sub btnButton1_Click(sender As Object, e As EventArgs) Handles btnButton1.Click
        MessageBox.Show("Your names are " & txtTextBox1.Text.Length.ToString & " characters long (including space)", "Length of Full Name", MessageBoxButtons.OK)

        Dim aryText() As String = txtTextBox1.Text.Split(" "c)

        MessageBox.Show("Your first name is: " & aryText(0), "First Name", MessageBoxButtons.OK)

        MessageBox.Show("Your last name is: " & aryText(1), "Last Name", MessageBoxButtons.OK)
    End Sub
End Class
