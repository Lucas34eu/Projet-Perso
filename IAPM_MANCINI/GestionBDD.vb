Imports MySql.Data

Public Class GestionBDD

    Public Shared MaConnexion As New MySqlClient.MySqlConnection

    Public Shared MaCommandeSpecialRequete As New MySqlClient.MySqlCommand

    Public Shared MonRemplisseur As New MySqlClient.MySqlDataAdapter

    Public Shared MonJeuDeDonnees As New Data.DataSet

    Public Shared MaRequete As String

    Public Shared machaine As String = "Server=localhost;Database=mancini_boutique;Uid=root;Pwd=;"

    Public Shared CptVue As Integer = 0

#Region "connexion a la base de donnees"
    Public Shared Sub SeConnecter()
        MaConnexion.ConnectionString = machaine
        MaConnexion.Open()
        MonJeuDeDonnees = New Data.DataSet("IAPM")
        MonJeuDeDonnees.Clear()
        MaCommandeSpecialRequete.CommandType = CommandType.Text
        MaCommandeSpecialRequete.Connection = MaConnexion


    End Sub
#End Region


    Public Shared Function RemplaceApostrophesSlash(ByRef unechaine As String) As String
        Dim ch As String
        ch = unechaine.Replace("'", "/")
        Return ch
    End Function

    Public Shared Function RemplaceSlashApostrophes(ByRef unechaine As String) As String
        Dim ch As String
        ch = unechaine.Replace("/", "'")
        Return ch
    End Function

    Public Shared Function GenererClePrimaire(ByVal nomcle As String, ByVal nomtable As String) As Integer
        Dim Cle As Integer
        MaRequete = "SELECT Max(" & nomcle & ") FROM " & nomtable
        MaCommandeSpecialRequete.CommandText = MaRequete
        Cle = MaCommandeSpecialRequete.ExecuteScalar()
        Return (Cle + 1)
    End Function

    Public Shared Function Executer_Requete_Select(ByVal marequeteselect As String) As Data.DataTable
        Dim result As New Data.DataTable

        'on crée une vue à chaque appel : penser à vider le dataset régulièrement pour ne pas
        'encombrer la mémoire - cptvue est un attribut statique à rajouter aux attributs de
        'votre classe GestionBoutique

        Dim MaVue As String = "MaVue" & cptvue
        Try
            MaCommandeSpecialRequete.CommandText = marequeteselect
            MonRemplisseur.SelectCommand = MaCommandeSpecialRequete
            MonRemplisseur.Fill(MonJeuDeDonnees, MaVue)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        result = MonJeuDeDonnees.Tables(MaVue)
        cptvue = cptvue + 1
        Return result
    End Function
End Class
