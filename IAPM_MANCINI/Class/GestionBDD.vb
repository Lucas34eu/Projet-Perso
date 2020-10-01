#Region "namespace"
Imports MySql.Data
Imports System.Text.RegularExpressions
#End Region

Public Class GestionBDD

#Region "Champs"

    Public Shared commande As Integer

    Public Shared user As String

    Public Shared pwd As String

    Public Shared MaConnexion As New MySqlClient.MySqlConnection

    Public Shared MaCommandeSpecialRequete As New MySqlClient.MySqlCommand

    Public Shared MonRemplisseur As New MySqlClient.MySqlDataAdapter

    Public Shared MonJeuDeDonnees As New Data.DataSet

    Public Shared MaRequete As String

    Public Shared machaine As String = "Server=localhost;Database=mancini_boutique;Uid=root;Pwd="

    Public Shared CptVue As Integer = 0

    Public Shared idProfil As Integer

#End Region


#Region "RemplaceApostrophesSlash"
    Public Shared Function RemplaceApostrophesSlash(ByRef unechaine As String) As String
        Dim ch As String
        ch = unechaine.Replace("'", "/")
        Return ch
    End Function
#End Region


#Region "RemplaceSlashApostrophes"
    Public Shared Function RemplaceSlashApostrophes(ByRef unechaine As String) As String
        Dim ch As String
        ch = unechaine.Replace("/", "'")
        Return ch
    End Function
#End Region


#Region "GenererClePrimaire"
    Public Shared Function GenererClePrimaire(ByVal nomcle As String, ByVal nomtable As String) As Integer
        Dim Cle As Integer
        MaRequete = "SELECT Max(" & nomcle & ") FROM " & nomtable
        MaCommandeSpecialRequete.CommandText = MaRequete
        Cle = MaCommandeSpecialRequete.ExecuteScalar()
        Return (Cle + 1)
    End Function
#End Region


#Region "Executer_Requete_Select"
    Public Shared Function Executer_Requete_Select(ByVal marequeteselect As String) As Data.DataTable
        Dim result As New Data.DataTable
        'on crée une vue à chaque appel : penser à vider le dataset régulièrement pour ne pas
        'encombrer la mémoire - cptvue est un attribut statique à rajouter aux attributs de
        'votre classe GestionBoutique
        Dim MaVue As String = "MaVue" & CptVue
        Try
            MaCommandeSpecialRequete.CommandText = marequeteselect
            MonRemplisseur.SelectCommand = MaCommandeSpecialRequete
            MonRemplisseur.Fill(MonJeuDeDonnees, MaVue)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        result = MonJeuDeDonnees.Tables(MaVue)
        CptVue = CptVue + 1
        Return result
    End Function
#End Region


#Region "Executer requete scalaire"
    Public Shared Function Executer_Requete_Scalaire(ByVal marequetescalaire As String) As Integer
        MaCommandeSpecialRequete.CommandText = marequetescalaire
        MonRemplisseur.SelectCommand = MaCommandeSpecialRequete
        Return CInt(MaCommandeSpecialRequete.ExecuteScalar)
        'ExecuteScalar : Cas des requêtes renvoyant un résultat unique Max Min Avg Sum
    End Function
#End Region


#Region "REQUETE ACTION"
    Public Shared Sub Executer_Requete_Action(ByVal marequeteaction As String)
        Try
            MaCommandeSpecialRequete.CommandText = marequeteaction
            MaCommandeSpecialRequete.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Erreur dans la tentative d'insertion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region



#Region "SeConnecter"


    Public Shared Sub SeConnecter()

        If MaConnexion.State = ConnectionState.Closed Then

            MaConnexion.ConnectionString = machaine
            MaConnexion.Open()
            MonJeuDeDonnees = New Data.DataSet("IAPM")
            MonJeuDeDonnees.Clear()
            MaCommandeSpecialRequete.CommandType = CommandType.Text
            MaCommandeSpecialRequete.Connection = MaConnexion
        End If

    End Sub
#End Region

#Region "Error provider"


#Region "ValidMail"
    Public Shared Function ValidMail(ByVal adresse As String) As Boolean
        Dim myRegex As System.Text.RegularExpressions.Regex
        myRegex = New Regex("^([\w]+)@([\w]+)\.([\w]+)$")
        '([\w]+) ==> caractère alphanumérique apparaissant une fois ou plus
        Return myRegex.IsMatch(adresse) 'retourne true ou false selon la vérification
    End Function
#End Region

#Region "ValidNom"
    Public Shared Function ValidNom(ByVal nom As String) As Boolean
        Dim myRegex As System.Text.RegularExpressions.Regex
        myRegex = New Regex("[^\d.]+")
        '([\w]+) ==> caractère alphanumérique apparaissant une fois ou plus
        Return myRegex.IsMatch(nom) 'retourne true ou false selon la vérification
    End Function
#End Region

#Region "ValidNombre"
    Public Shared Function ValidNombre(ByVal tel As String) As Boolean
        Dim myRegex As System.Text.RegularExpressions.Regex
        myRegex = New Regex("[0-9]")
        '([\w]+) ==> caractère alphanumérique apparaissant une fois ou plus
        Return myRegex.IsMatch(tel) 'retourne true ou false selon la vérification
    End Function
#End Region

#Region "ValidDate"
    Public Shared Function ValidDate(ByVal tel As String) As Boolean
        Dim myRegex As System.Text.RegularExpressions.Regex
        myRegex = New Regex("([0-2]\d|3[0-1])\/(0\d|1[0-2])\/(19|20)\d{2}")
        '([\w]+) ==> caractère alphanumérique apparaissant une fois ou plus
        Return myRegex.IsMatch(tel) 'retourne true ou false selon la vérification
    End Function
#End Region



#End Region

#Region "GetlesUsers"
    Public Shared Function GetlesUsers(ByVal login As String, password As String) As DataTable

        Return Executer_Requete_Select("SELECT * FROM utilisateurs where login ='" + login + "' and mdp='" + password + "'")

    End Function
#End Region


#Region "GetlesclientbyID"
    Public Shared Function GetClientById(id As Integer) As DataTable

        Return Executer_Requete_Select("SELECT * FROM client where idClient= " & id & "")

    End Function

#End Region


#Region "GetPatronimeClient"
    Public Shared Function GetPatronymeClient() As DataTable

        Return Executer_Requete_Select("select concat(Nomclient,'  ,  ',Prenomclient) as patronime ,idClient from Client")


    End Function

#End Region


#Region "AlimenterComboBox"
    Public Shared Sub AlimenterComboBox(ByRef macombo As ComboBox, matable As DataTable, mondisplay As String, mavaleur As String)
        macombo.DataSource = matable
        macombo.DisplayMember = mondisplay
        If mavaleur <> "" Then
            macombo.ValueMember = mavaleur

        End If
    End Sub
#End Region

End Class
