Public Class Login

    Public taille As Integer = 0
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Inscription.Show()
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click


        If (TextBox1.Text <> "" And TextBox3.Text <> "") Then
            Dim login As String = TextBox1.Text
            Dim password As String = TextBox3.Text

            If (Data.Find(Inscription.User, login, password) <> -1) Then
                Menu.Show()
                Me.Hide()
                MessageBox.Show("Vous êtes connecté avec succès ")
            Else
                MessageBox.Show(" mot de pass incorect!!!")
            End If

        Else
            TextBox1.BackColor = Color.LightCoral
            TextBox3.BackColor = Color.LightCoral
            TextBox1.Text = TextBox3.Text = ""
            MessageBox.Show("Veuiller saisir les champs obligatoires ")
        End If
        TextBox1.Clear()
        TextBox3.Clear()

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        TextBox1.BackColor = Color.LightCyan
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs)
        TextBox3.BackColor = Color.LightCyan
    End Sub
End Class
