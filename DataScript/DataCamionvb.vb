Public Class DataCamion
    Public Chauffeur As String
    Public Mat As String
    Public tonnage As Double
    Public Marque As String
    Public DateEntree As String
    Public DateSortie As String
    Public Sub New(chauffeur As String, Matricule As String, tonnage As Double, Marque As String, DateEntree As String, DateSortie As String)
        Me.Chauffeur = chauffeur
        Me.Mat = Matricule
        Me.tonnage = tonnage
        Me.Marque = Marque
        Me.DateEntree = DateEntree
        Me.DateSortie = DateSortie
    End Sub
    Public Shared Function Find(ByVal Car() As DataCamion, ByVal Matricule As String) As Integer
        If (Login.taille = 0) Then
            Return -1
        End If

        For i As Integer = 0 To Login.taille
            If Car(i).Mat = Matricule Then
                Return i
            End If
        Next
        Return -1

    End Function

End Class
