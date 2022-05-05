Public Class Menu
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Car As New CarParking()
        Me.Hide()
        car.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Camion As New CamionMenu()
        Me.Hide()
        Camion.Show()
    End Sub
End Class