Public Class Inscription

    Public User(50) As Data

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If (TextBox1.Text <> "" And TextBox3.Text <> "" And TextBox5.Text <> "" And DateTimePicker1.Text <> "" And ComboBox1.Text <> "" And TextBox5.Text = TextBox6.Text) Then

            User(Login.taille) = New Data(TextBox1.Text, TextBox3.Text, TextBox5.Text, DateTimePicker1.Text, TextBox5.Text)
            MessageBox.Show(User(0).Nom)
            Login.taille += 1

            MessageBox.Show("Vous êtes connecté avec succès ")

        Else
            TextBox1.BackColor = Color.LightCoral
            TextBox3.BackColor = Color.LightCoral
            TextBox1.Text = TextBox3.Text = ""
            MessageBox.Show("Veuiller saisir les champs obligatoires ")
        End If
        TextBox1.Clear()
        TextBox3.Clear()

        Me.Hide()
        Login.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Clear()
        TextBox3.Clear()
        TextBox3.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
    End Sub

    Private Sub Inscription_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class