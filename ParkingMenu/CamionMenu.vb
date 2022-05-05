Public Class CamionMenu
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Camion1.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Menu.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CamionSup.Show()
        Me.Hide()
    End Sub
End Class