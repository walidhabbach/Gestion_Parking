Public Class Camion1
    Public Camion(50) As DataCamion
    Public taille As Integer = 0

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If (TextBox1.Text <> "" And TextBox3.Text <> "" And TextBox4.Text <> "" And DateTimePicker2.Text <> "" And DateTimePicker3.Text <> "") Then

            Camion(taille) = New DataCamion(TextBox1.Text, TextBox3.Text, TextBox4.Text, TextBox2.Text, DateTimePicker2.Text, DateTimePicker3.Text)
            taille += 1
        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Menu As New Menu()
        Me.Hide()
        Menu.Show()
    End Sub
End Class