Public Class frmlap2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Vistra, Frista, Sell As Integer
        Dim VistraCom, FristaCom, TotalCommition As Long

        Vistra = Val(txtvistra.Text)
        Frista = Val(txtfrista.Text)

        Sell = Vistra + Frista

        VistraCom = Vistra * 5 / 100
        FristaCom = Frista * 10 / 100

        TotalCommition = VistraCom + FristaCom

        lblsell.Text = Sell
        lbltotalcom5.Text = VistraCom
        lbltotalcom10.Text = FristaCom
        lbltotal.Text = TotalCommition



    End Sub

    Private Sub Label6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub frmlap2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblsell.Click, lbltotalcom10.Click, lbltotalcom5.Click, lbltotal.Click

    End Sub
End Class
