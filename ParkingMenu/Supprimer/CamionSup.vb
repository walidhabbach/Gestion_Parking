Public Class CamionSup
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TextBox1.Text <> "") Then
            If DataCamion.Find(Camion1.Camion, TextBox1.Text) <> -1 Then
                Dim pos As Integer = DataCamion.Find(Camion1.Camion, TextBox1.Text)

                If (pos = Camion1.taille) Then
                    Camion1.taille -= 1
                ElseIf (pos < Camion1.Taille) Then
                    For i = pos - 1 To Camion1.taille - 1
                        Camion1.Camion(i) = Camion1.Camion(i + 1)
                    Next
                    Camion1.taille -= 1
                End If
                MessageBox.Show("Supprimer!!!")
            Else
                MessageBox.Show("Matricule n'est pas correcte!!!")
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CamionMenu.Show()
        Me.Hide()

    End Sub
End Class