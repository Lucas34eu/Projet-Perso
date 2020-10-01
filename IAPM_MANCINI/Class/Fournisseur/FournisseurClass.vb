
Public Class FournisseurClass
    Inherits IAPM_MANCINI.GestionBDD

#Region "GetlesFournisseur()"
    Public Shared Function GetlesFournisseur() As DataTable

        Return Executer_Requete_Select("SELECT * FROM fournisseur ")

    End Function
#End Region

#Region "Get NB Fournisseur"
    Public Shared Function GetNBFournisseur() As Integer
        Dim result As Integer
        MaRequete = "Select count(*) from fournisseur"
        MaCommandeSpecialRequete.CommandText = MaRequete
        MonRemplisseur.SelectCommand = MaCommandeSpecialRequete
        MonRemplisseur.Fill(MonJeuDeDonnees, "nbFourn")
        result = MonJeuDeDonnees.Tables("nbFourn").Rows(0).Item(0)
        Return result
    End Function
#End Region

#Region "Methode Inserer Fournisseur"

    Public Shared Sub InsererFournisseur(c As Integer, n As String, p As String, em As Integer)
        MaRequete = "Insert into fournisseur Values ( " & c & ", '" & n & "','" & p & "'," & em & ")"
        MaCommandeSpecialRequete.CommandText = MaRequete
        MaCommandeSpecialRequete.ExecuteNonQuery()

    End Sub


#End Region

#Region "Methode Supprimer Produit"

    Public Shared Sub SupprimerFournisseur(c As Integer)


        MaRequete = "Delete from fournisseur where idFournisseur = ( " & c & ")"
        MaCommandeSpecialRequete.CommandText = MaRequete

        MaCommandeSpecialRequete.ExecuteNonQuery()

    End Sub


#End Region

#Region "Methode Modifier Produit"

    Public Shared Sub ModifierFournisseur(n As String, p As String, em As Integer, c As Integer)

        MaRequete = "update fournisseur set nomFournisseur= '" & n & "' , villeFournisseur= '" & p & "',cpFournisseur = '" & em & "' where idFournisseur = " & c
        MaCommandeSpecialRequete.CommandText = MaRequete
        MaCommandeSpecialRequete.ExecuteNonQuery()

    End Sub


#End Region

#Region "Actualiser"
#Region "Actualiser les ID"

    Public Shared Function ActualizeID(ByVal idFournisseur As Int16) As DataTable

        GetlesFournisseur().Clear()
        MaRequete = "SELECT * FROM fournisseur Where idFournisseur = " & idFournisseur & " "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region


#Region "Actualiser les Nom"
    Public Shared Function ActualizeNom(ByVal nomFournisseur As String) As DataTable

        GetlesFournisseur().Clear()
        MaRequete = "SELECT * FROM fournisseur Where nomFournisseur = '" & nomFournisseur & "' "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region


#Region "Actualiser les Ville"
    Public Shared Function ActualizeVille(ByVal villeFournisseur As Integer) As DataTable

        GetlesFournisseur().Clear()
        MaRequete = "SELECT * FROM fournisseur Where villeFournisseur = " & villeFournisseur & " "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region


#Region "Actualiser les CDP"
    Public Shared Function ActualizeCDP(ByVal cpFournisseur As Integer) As DataTable

        GetlesFournisseur().Clear()
        MaRequete = "SELECT * FROM fournisseur Where cpFournisseur = " & cpFournisseur & " "

        Return Executer_Requete_Select(MaRequete)

    End Function
#End Region

#End Region

End Class
