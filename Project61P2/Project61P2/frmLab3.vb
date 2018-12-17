Public Class frmLab3


    Dim NumberS As Integer
    Private Sub frmLab3_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        NumberS = Val(txtInput.Text)
        NumberS = NumberS + 5
        txtInput.Text = NumberS

    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        NumberS = Val(txtInput.Text)
        NumberS = NumberS - 5
        txtInput.Text = NumberS

    End Sub

    Private Sub txtInput_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtInput.TextChanged


    End Sub

    Private Sub lblFRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFRed.Click
        txtInput.ForeColor = Color.Red
    End Sub

    Private Sub lblFBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlue.Click
        txtInput.ForeColor = Color.Blue
    End Sub

    Private Sub cboSize_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSize.SelectedIndexChanged
        Dim Size As Integer = Val(cboSize.Text)
        txtInput.Font = New Font(cboSize.Font.Name, Size, FontStyle.Regular)
        txtInput.Text = FormatNumber(txtInput.Text, 2)

    End Sub

    Private Sub lblFGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFGreen.Click
        txtInput.ForeColor = Color.Green
    End Sub

    Private Sub lblGRed_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGRed.Click
        txtInput.BackColor = Color.Red
    End Sub

    Private Sub lblFViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFViolet.Click
        txtInput.ForeColor = Color.Violet
    End Sub

    Private Sub lblFBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBlack.Click
        txtInput.ForeColor = Color.Black
    End Sub

    Private Sub lblFOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFOrange.Click
        txtInput.ForeColor = Color.Orange
    End Sub

    Private Sub lblFYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFYellow.Click
        txtInput.ForeColor = Color.Yellow
    End Sub

    Private Sub lblFBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFBrown.Click
        txtInput.ForeColor = Color.Brown
    End Sub

    Private Sub lblFWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFWhite.Click
        txtInput.ForeColor = Color.White
    End Sub

    Private Sub lblFSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblFSky.Click
        txtInput.ForeColor = Color.SkyBlue
    End Sub

    Private Sub lblGBlue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGBlue.Click
        txtInput.BackColor = Color.Blue
    End Sub

    Private Sub lblGGreen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGGreen.Click
        txtInput.BackColor = Color.Green
    End Sub

    Private Sub lblGViolet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGViolet.Click
        txtInput.BackColor = Color.Violet
    End Sub

    Private Sub lblGBlack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGBlack.Click
        txtInput.BackColor = Color.Black
    End Sub

    Private Sub lblGOrange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGOrange.Click
        txtInput.BackColor = Color.Orange
    End Sub

    Private Sub lblGYellow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGYellow.Click
        txtInput.BackColor = Color.Yellow
    End Sub

    Private Sub lblGBrown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGBrown.Click
        txtInput.BackColor = Color.Brown
    End Sub

    Private Sub lblGWhite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGWhite.Click
        txtInput.BackColor = Color.White
    End Sub

    Private Sub lblGSky_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblGSky.Click
        txtInput.BackColor = Color.SkyBlue
    End Sub
End Class