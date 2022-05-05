Public Class DisplayCamion
    Private Sub DisplayCamion_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged
        For i As Integer = 0 To Car.taille
            With ListView1.Items.Add(Car.Car(i).Chauffeur)
                .SubItems.Add(Car.Car(i).Marque)
                .SubItems.Add(Car.Car(i).Nbrplaces)
                .SubItems.Add(Car.Car(i).DateEntree)
            End With
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        CamionMenu.Show()
    End Sub
End Class