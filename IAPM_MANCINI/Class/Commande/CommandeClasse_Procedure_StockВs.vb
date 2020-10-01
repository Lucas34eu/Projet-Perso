Public Class CommandeClasse_Procedure_Stockés

    Inherits IAPM_MANCINI.GestionBDD


#Region "Get les Commandes"
    Public Shared Function GetlesCommandes() As DataTable
        MaRequete = "call GetLesCommandes"
        Return Executer_Requete_Select(MaRequete)

    End Function

#End Region


#Region "Get les Commandes 2"
    Public Shared Function GetlesCommandes2() As DataTable
        MaRequete = "call GetLesCommandes_PatronimeInclu"
        Return Executer_Requete_Select(MaRequete)

    End Function
#End Region


#Region "Get COMMANDE by id"
    Public Shared Function GetCommandebyID(ByVal id As Integer) As DataTable
        MaRequete = "call GetCommandebyID (" & id & ")"
        Return Executer_Requete_Select(MaRequete)

    End Function
#End Region


#Region " Get NB Commandes"
    Public Shared Function GetNBCommandes() As Integer

        MaRequete = "call GetNBCommande"
        GestionBDD.Executer_Requete_Select(MaRequete)
    End Function
#End Region


#Region "Get les Commandes Details"
    Public Shared Function GetlesCommandesDetailbyID(ByVal id As Integer) As DataTable
        MaRequete = " call  GetCommandeDetailById (" & id & ")  "
        Return Executer_Requete_Select(MaRequete)

    End Function
#End Region


#Region "Methode Inserer Commande"

    Public Shared Sub InsererCommande(idCommande As Integer, [date] As String, idClient As Integer)
        MaRequete = "call Inserer_Commande( " & idCommande & ",'" & [date] & "'," & idClient & ")"
        Executer_Requete_Action(MaRequete)
    End Sub
#End Region


#Region "Inserer produit dans commande"

    Public Shared Sub InsererProduitdansCommande(idCommande As Integer, idproduit As Integer, quantite As Integer)
        MaRequete = "call Inserer_Produitdanscommande( " & idCommande & "," & idproduit & "," & quantite & ")"
        Executer_Requete_Action(MaRequete)

    End Sub
#End Region


#Region "Delete produit dans commande"

    Public Shared Sub InsererProduitdansCommande2(idCommande As Integer, idproduit As Integer)
        MaRequete = "call DELETE_Produitdanscommande ( " & idCommande & "," & idproduit & ")"
        Executer_Requete_Action(MaRequete)

    End Sub
#End Region


#Region "Methode Supprimer Commande"

    Public Shared Sub SupprimerCommande(c As Integer)


        MaRequete = "Delete from lignedecommande where idCommande = ( " & c & ")"
        MaCommandeSpecialRequete.CommandText = MaRequete

        MaCommandeSpecialRequete.ExecuteNonQuery()

        MaRequete = "Delete from commande where idCommande = ( " & c & ")"
        MaCommandeSpecialRequete.CommandText = MaRequete

        MaCommandeSpecialRequete.ExecuteNonQuery()



    End Sub


#End Region


#Region "get la commande en cours"
    Public Shared Function GetlaCommandeEnCour(idCommande As Integer) As DataTable
        MaRequete = "call GetCommandeEnCours( " & idCommande & ")"
        Executer_Requete_Select(MaRequete)

    End Function
#End Region


#Region "get total by commande"
    Public Shared Function GetTotalbyCommande(idCommande As Integer) As Integer

        MaRequete = "call getTotalByCommande ( " & idCommande & ")"
        Executer_Requete_Scalaire(MaRequete)
    End Function
#End Region


#Region "Actualiser les commande id"
    Public Shared Function ActualizeCliID(ByVal idCommande As Int16) As DataTable

        GetlesCommandes().Clear()
        MaRequete = "call ActualizeCliID (" & idCommande & " )"

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region

    '#Region "Get les Commandes"
    '    Public Shared Function GetlesCommandes() As DataTable
    '        MaRequete = "SELECT commande.idCommande,nomclient,prenomclient,adrueclient,dateCommande, sum(quantiteCom*produit.prixHTProduit)as Total FROM client,commande,lignedecommande,produit where ( commande.idCli=client.idClient) and ( commande.idCommande=lignedecommande.idCommande ) and (produit.idProduit=lignedecommande.idProduit) GROUP by commande.idCommande"
    '        Return Executer_Requete_Select(MaRequete)

    '    End Function
    '#End Region

    '#Region "Get les Commandes 2"
    '    Public Shared Function GetlesCommandes2() As DataTable
    '        MaRequete = "SELECT idCommande,concat(nomclient,' , ',prenomclient) as Patronime FROM client,commande where ( commande.idCli=client.idClient)"
    '        Return Executer_Requete_Select(MaRequete)

    '    End Function
    '#End Region



    '#Region " Get NB Commandes"
    '    Public Shared Function GetNBCommandes() As Integer
    '        Dim result As Integer
    '        MaRequete = "Select Count(*) from lignedecommande"
    '        MaCommandeSpecialRequete.CommandText = MaRequete
    '        MonRemplisseur.SelectCommand = MaCommandeSpecialRequete
    '        MonRemplisseur.Fill(MonJeuDeDonnees, "NBCommandes")
    '        result = MonJeuDeDonnees.Tables("NBCommandes").Rows(0).Item(0)
    '        Return result
    '    End Function
    '#End Region


    '#Region "Get les Commandes Details"
    '    Public Shared Function GetlesCommandesDetail() As DataTable
    '        MaRequete = "call GetLesCommandes_Detail"
    '        Return Executer_Requete_Select(MaRequete)

    '    End Function
    '#End Region


    '#Region "Get le Total by commande"
    '    Public Shared Function GetTotalByCommande(idcom As Integer) As Integer

    '        MaRequete = "call getTotalByCommande (" & idcom & ")"
    '        GestionBDD.Executer_Requete_Select(MaRequete)


    '    End Function
    '#End Region


    '#Region "Methode Inserer Commande"

    '    Public Shared Sub InsererCommande(idCommande As Integer, [date] As String, idClient As Integer)
    '        MaRequete = "call Inserer_Commande( " & idCommande & ",'" & [date] & "'," & idClient & ")"
    '        Executer_Requete_Action(MaRequete)
    '    End Sub


    '    Public Shared Sub InsererProduitdansCommande(idCommande As Integer, idproduit As Integer, quantite As Integer)
    '        MaRequete = "Inserer_Produitdanscommande( " & idCommande & "," & idproduit & "," & quantite & ")"
    '        Executer_Requete_Action(MaRequete)

    '    End Sub


    '#End Region

    '#Region "Methode Supprimer Commande"

    '    Public Shared Sub SupprimerCommande(c As Integer)


    '        MaRequete = "Delete from lignedecommande where idCommande = ( " & c & ")"
    '        Executer_Requete_Action(MaRequete)

    '        MaRequete = "Delete from commande where idCommande = ( " & c & ")"
    '        Executer_Requete_Action(MaRequete)



    '    End Sub


    '#End Region


    '    Public Shared Function GetlaCommandeEnCour(idCommande As Integer) As DataTable
    '        MaRequete = "SELECT produit.idProduit,produit.libelleProduit,produit.prixHTProduit,lignedecommande.quantiteCom,SUM(produit.prixHTProduit*lignedecommande.quantiteCom) as Total from lignedeCommande,produit where ( lignedecommande.idProduit=produit.idProduit ) and idCommande =" & idCommande & " group by produit.idProduit "
    '        Return Executer_Requete_Select(MaRequete)

    '    End Function


    '    Public Shared Function GetTotal(idCommande As Integer) As Integer

    '        MaRequete = "SELECT sum(produit.prixHTProduit*lignedecommande.quantiteCom) as Total from produit,lignedecommande where produit.idProduit=lignedecommande.idProduit and idCommande=" & idCommande & ""
    '        Return Executer_Requete_Scalaire(MaRequete)
    '    End Function

    '#Region "Actualiser les commande id"
    '    Public Shared Function ActualizeCliID(ByVal idCommande As Int16) As DataTable

    '        GetlesCommandes().Clear()
    '        MaRequete = "SELECT * FROM Commande Where IdCommande = " & idCommande & " "

    '        Return Executer_Requete_Select(MaRequete)
    '    End Function
    '#End Region

End Class
