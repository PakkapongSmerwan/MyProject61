Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim name As String
        Dim salary As Integer
        name = MaskedTextBox1.Text
        salary = MaskedTextBox2.Text
        Label7.Text = name
        Label8.Text = salary
        Label9.Text = salary * 12


    End Sub
End Class
