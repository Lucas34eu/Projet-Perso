
Public Class CategorieClass
    Inherits IAPM_MANCINI.GestionBDD

#Region " GET NB CATEGORIE"
    Public Shared Function GetNBCat() As Integer
        MaRequete = "Call GetNBCommande "
        GestionBDD.Executer_Requete_Select(MaRequete)


    End Function
#End Region

#Region "Get les Produits"
    Public Shared Function GetlesCat() As DataTable

        Return Executer_Requete_Select("Call GetLesProduits  ")

    End Function
#End Region

#Region "Insertion , Modification , Suppretion de tuple"
#Region "Methode Inserer Categorie"

    Public Shared Sub InsererCat(c As Object, n As Object)
        MaRequete = "Call Ajouter_Categorie( " & c & ", '" & n & "')"
        GestionBDD.Executer_Requete_Action(MaRequete)

    End Sub


#End Region

#Region "Methode Supprimer Categorie"

    Public Shared Sub SupprimerCat(c As Integer)

        SetProduitCategorieNull(c)
        MaRequete = "Call Delete_Categorie( " & c & ")"
        GestionBDD.Executer_Requete_Action(MaRequete)

    End Sub


#End Region

#Region "Methode Modifier Categorie"

    Public Shared Sub ModifierCat(c As Integer, n As Object)

        MaRequete = "Call Modifier_Categorie ( '" & n & "', " & c & ") "
        GestionBDD.Executer_Requete_Action(MaRequete)

    End Sub
#End Region




#End Region


#Region "Methode Modifier Categorie"

    Public Shared Sub SetProduitCategorieNull(c As Integer)

        MaRequete = "Call SetProduitCategorieNull(" & c & ")"
        GestionBDD.Executer_Requete_Action(MaRequete)

    End Sub
#End Region


End Class
