

Public Class ProduitClass
    Inherits IAPM_MANCINI.GestionBDD

#Region "Get les Produits"
    Public Shared Function GetlesProduitsID() As DataTable
        Dim deuxpoint As String = " : "
        Return Executer_Requete_Select("SELECT idProduit,libelleProduit,prixHTProduit,qteStockProduit,nomFournisseur,libelleCategorie,concat(produit.idProduit,'" & deuxpoint & "',produit.libelleProduit)as entierproduit FROM Produit,Fournisseur,Categorie WHERE produit.idFourn=fournisseur.idFournisseur and produit.idCat=categorie.idCategorie")

    End Function
#End Region

#Region "Get les Produits Info Complet"
    Public Shared Function GetlesProduits() As DataTable

        Return Executer_Requete_Select("SELECT idProduit,libelleProduit,prixHTProduit,qteStockProduit,nomFournisseur,libelleCategorie FROM Produit,Fournisseur,Categorie WHERE produit.idFourn=fournisseur.idFournisseur and produit.idCat=categorie.idCategorie")

    End Function
#End Region

#Region "Get NB Produit"
    Public Shared Function GetNBProduits() As Integer
        Dim result As Integer
        MaRequete = "Select count(*) from Produit"
        MaCommandeSpecialRequete.CommandText = MaRequete
        MonRemplisseur.SelectCommand = MaCommandeSpecialRequete
        MonRemplisseur.Fill(MonJeuDeDonnees, "nbPro")
        result = MonJeuDeDonnees.Tables("nbPro").Rows(0).Item(0)
        Return result
    End Function
#End Region

#Region "Get les Fournisseur"

    Public Shared Function GetlesFournisseurs() As DataTable

        Return Executer_Requete_Select("SELECT * from fournisseur")

    End Function
#End Region

#Region "Get les Categorie"
    Public Shared Function GetlesCategories() As DataTable

        Return Executer_Requete_Select("SELECT * from categorie")

    End Function
#End Region

#Region " ACTUALISER LES CB"
#Region "Actualiser les Produit"

    Public Shared Function ActualizeProID(ByVal idProduit As Int16) As DataTable

        GetlesProduits().Clear()
        MaRequete = "SELECT * FROM Produit Where idProduit = " & idProduit & " "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region


#Region "Actualiser les Nom"
    Public Shared Function ActualizeProNom(ByVal libelleProduit As String) As DataTable

        GetlesProduits().Clear()
        MaRequete = "SELECT * FROM Produit Where libelleProduit = '" & libelleProduit & "' "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region


#Region "Actualiser les Fournisseur"
    Public Shared Function ActualizeFourn(ByVal idFourn As Integer) As DataTable

        GetlesProduits().Clear()
        MaRequete = "SELECT * FROM Produit Where idFourn = " & idFourn & " "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region


#Region "Actualiser les Categories"
    Public Shared Function ActualizeCat(ByVal idCat As Integer) As DataTable

        GetlesProduits().Clear()
        MaRequete = "SELECT * FROM Produit Where idCat = " & idCat & " "

        Return Executer_Requete_Select(MaRequete)

    End Function
#End Region

#Region "Actualiser les Prix"

    Public Shared Function ActualizePrix(ByVal prixHTProduit As Int16) As DataTable

        GetlesProduits().Clear()
        MaRequete = "SELECT * FROM Produit Where prixHTProduit = " & prixHTProduit & " "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region

#Region "Actualiser les Quantité"

    Public Shared Function ActualizeQTE(ByVal qteStockProduit As Int16) As DataTable

        GetlesProduits().Clear()
        MaRequete = "SELECT * FROM Produit Where qteStockProduit = " & qteStockProduit & " "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region

#End Region

#Region "Insertion , Modification , Suppretion de tuple"
#Region "Methode Inserer Produit"

    Public Shared Sub InsererProduit(c As Object, n As Object, p As Object, em As Object, t As Object, s As Object)
        MaRequete = "Insert into Produit Values ( " & c & ", '" & n & "','" & p & "','" & em & "','" & t & "','" & s & "')"
        MaCommandeSpecialRequete.CommandText = MaRequete
        MaCommandeSpecialRequete.ExecuteNonQuery()

    End Sub


#End Region

#Region "Methode Supprimer Produit"

    Public Shared Sub SupprimerProduit(c As Integer)


        MaRequete = "Delete from produit where idProduit = ( " & c & ")"
        MaCommandeSpecialRequete.CommandText = MaRequete

        MaCommandeSpecialRequete.ExecuteNonQuery()

    End Sub


#End Region

#Region "Methode Modifier Produit"

    Public Shared Sub ModifierProduit(n As String, p As Integer, em As Integer, c As Integer)

        MaRequete = "update produit set libelleProduit= '" & n & "' , prixHTProduit= '" & p & "',qteStockProduit = '" & em & "'  where idProduit = " & c
        MaCommandeSpecialRequete.CommandText = MaRequete
        MaCommandeSpecialRequete.ExecuteNonQuery()

    End Sub


#End Region
#End Region

End Class