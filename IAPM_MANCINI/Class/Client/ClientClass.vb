
Imports MySql.Data.MySqlClient
Class ClientClass
    Inherits IAPM_MANCINI.GestionBDD






#Region "Get le patronime faire la procedure "
    Public Shared Function getLePatronime() As DataTable
        Dim deuxpoint As String = " : "
        Dim espace As String = " "
        MaRequete = "SELECT concat(client.idClient,'" & deuxpoint & "',client.nomClient,'" & espace & "',client.prenomClient)as patronime FROM Client"
        Return Executer_Requete_Select(MaRequete)

    End Function
#End Region


#Region "Get les Clients"
    Public Shared Function GetlesClients() As DataTable
        MaRequete = "Call GetLesClients"
        Return Executer_Requete_Select(MaRequete)

    End Function
#End Region

#Region "Get le Patronime Client"
    Public Shared Function GetlesClientNom() As DataTable
        MaRequete = "Call GetLePatronimeClient "
        Return Executer_Requete_Select(MaRequete)

    End Function
#End Region

#Region " Get NB Client"
    Public Shared Function GetNBClients() As Integer

        MaRequete = " call GetNBClient "
        GestionBDD.Executer_Requete_Select(MaRequete)
    End Function
#End Region

#Region "Actualiser faire la procedure"

#Region "Actualiser les ClientID"
    Public Shared Function ActualizeCliID(ByVal idClient As Int16) As DataTable

        GetlesClients().Clear()
        MaRequete = "SELECT * FROM Client Where IdClient = " & idClient & " "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region


#Region "Actualiser les Client Nom"
    Public Shared Function ActualizeClinom(ByVal NomClient As String) As DataTable

        GetlesClients().Clear()
        MaRequete = "SELECT * FROM Client Where NomClient = '" & NomClient & "' "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region


#Region "Actualiser les Client Prenom"

    Public Shared Function ActualizeCliPrenom(ByVal prenomClient As String) As DataTable

        GetlesClients().Clear()
        MaRequete = "SELECT * FROM Client Where prenomClient = '" & prenomClient & "' "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region


#Region "Actualiser les Client Rue"

    Public Shared Function ActualizeCliRue(ByVal adRueClient As String) As DataTable

        GetlesClients().Clear()
        MaRequete = "SELECT * FROM Client Where adRueClient = '" & adRueClient & "' "

        Return Executer_Requete_Select(MaRequete)

    End Function
#End Region

#Region "Actualiser les Client Code Postal"

    Public Shared Function ActualizeCp(ByVal adCpClient As String) As DataTable

        GetlesClients().Clear()
        MaRequete = "SELECT * FROM Client Where adCpClient = '" & adCpClient & "' "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region

#Region "Actualiser Client Ville"
    Public Shared Function ActualizeVille(ByVal adVilleClient As String) As DataTable

        GetlesClients().Clear()
        MaRequete = "SELECT * FROM Client Where adVilleClient = '" & adVilleClient & "' "

        Return Executer_Requete_Select(MaRequete)
    End Function
#End Region

#End Region

#Region "Methode Inserer Client"

    Public Shared Sub InsererClient(c As Integer, n As String, p As String, em As String, t As Integer, s As String)
        MaRequete = "Call Inserer_Client( " & c & ", '" & n & "','" & p & "','" & em & "','" & t & "','" & s & "')"

        GestionBDD.Executer_Requete_Action(MaRequete)

    End Sub


#End Region

#Region "Methode Supprimer Client"

    Public Shared Sub SupprimerClient(c As Integer)


        MaRequete = " call Delete_Client ( " & c & ")"
        GestionBDD.Executer_Requete_Action(MaRequete)

    End Sub


#End Region

#Region "Methode Modifier Client"

    Public Shared Sub ModifierClient(n As String, p As String, em As String, t As Integer, s As String, c As Integer)

        'MaRequete = "Call  	Update_Client ('" & c & "' ,'" & n & "','" & p & "' ," & em & ",'" & t & "' ," & s & ")"
        'Executer_Requete_Action(MaRequete)

        Dim Mycommand As MySqlCommand = MaConnexion.CreateCommand()


        ''La commande pointe sur la procédure stockée
        Mycommand.CommandType = CommandType.StoredProcedure
        Mycommand.CommandText = "Update_Client"



        ''Initialisation des paramètres de la procédure stockée
        Dim param1 As MySqlParameter = Mycommand.Parameters.AddWithValue("id", c)
        Dim param2 As MySqlParameter = Mycommand.Parameters.AddWithValue("nom", n)
        Dim param3 As MySqlParameter = Mycommand.Parameters.AddWithValue("prenom", p)
        Dim param4 As MySqlParameter = Mycommand.Parameters.AddWithValue("rue", em)
        Dim param5 As MySqlParameter = Mycommand.Parameters.AddWithValue("cp", t)
        Dim param6 As MySqlParameter = Mycommand.Parameters.AddWithValue("ville", s)




        'Exécution de la procédure après ouverture de la connexion

        Mycommand.ExecuteNonQuery()


    End Sub


#End Region




End Class
