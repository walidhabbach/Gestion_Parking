Public Class Data


    Public Nom As String
    Public Motdepasse As String
    Public Email As String
    Public Sexe As String
    Public ddn As String

    Public Sub New(Nom As String, Email As String, Sexe As String, ddn As String, mdp As String)
        Me.Nom = Nom
        Me.Email = Email
        Me.Sexe = Sexe
        Me.ddn = ddn
        Me.Motdepasse = mdp
    End Sub


    Public Shared Function Find(ByVal user() As Data, ByVal Nom As String, ByVal code As String) As Integer
        If (Login.taille = 0) Then
            Return -1
        Else
            For i As Integer = 0 To Login.taille
                If user(i).Nom = Nom And user(i).Motdepasse = code Then
                    Return i
                End If
            Next
        End If

        Return -1

    End Function




End Class
