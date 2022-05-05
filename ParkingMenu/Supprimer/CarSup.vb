Public Class CarSup

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "") Then
            If DataCar.Find(Car.Car, TextBox1.Text) <> -1 Then
                Dim pos As Integer = DataCar.Find(Car.Car, TextBox1.Text)

                If (pos = Camion1.taille) Then
                    Car.taille -= 1
                ElseIf (pos < Camion1.taille) Then
                    For i = pos - 1 To Car.taille - 1
                        Car.Car(i) = Car.Car(i + 1)
                    Next
                    Car.taille -= 1
                End If
                MessageBox.Show("Supprimer!!!")
            Else
                MessageBox.Show("Matricule n'est pas correcte!!!")
            End If

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CarParking.Show()
        Me.Hide()
    End Sub
End Class