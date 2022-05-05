Public Class DataCar

    Public Chauffeur As String
    Public Mat As String
    Public Nbrplaces As String
    Public Marque As Integer
    Public DateEntree As String
    Public DateSortie As String
    Public Sub New(chauffeur As String, Mat As String, Nbrplaces As Integer, Marque As String, DateEntree As String, DateSortie As String)
        Me.Chauffeur = chauffeur
        Me.Mat = Mat
        Me.Nbrplaces = Nbrplaces
        Me.Marque = Marque
        Me.DateEntree = DateEntree
        Me.DateSortie = DateSortie
    End Sub
    Public Shared Function Find(ByVal user() As DataCar, ByVal Matricule As String) As Integer
        If (Login.taille = 0) Then
            Return -1
        End If

        For i As Integer = 0 To Login.taille
            If user(i).Mat = Matricule Then
                Return i
            End If
        Next
        Return -1

    End Function

End Class