Imports IAPM_MANCINI.ClientClass
Public Class frmRechercheClient


#Region "Load"
    Private Sub frmRechercheClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        DataGridrech.DataSource = GetlesClients()



        cbPatronime.DataSource = getLePatronime()
        cbPatronime.DisplayMember = "patronime"



        ComboBoxRue.DataSource = GetlesClients()
        ComboBoxRue.DisplayMember = "adRueClient"


        RemoveHandler ComboBoxCDP.SelectedIndexChanged, AddressOf ComboBoxCDP_SelectedIndexChanged
        ComboBoxCDP.DataSource = GetlesClients()
        ComboBoxCDP.DisplayMember = "adCpClient"
        AddHandler ComboBoxCDP.SelectedIndexChanged, AddressOf ComboBoxCDP_SelectedIndexChanged


        ComboBoxVille.DataSource = GetlesClients()
        ComboBoxVille.DisplayMember = "adVilleClient"

    End Sub
#End Region


#Region "BTN Fermer"
    Private Sub BTNFermer_Click(sender As Object, e As EventArgs) Handles BTNFermer.Click
        Me.Close()

    End Sub
#End Region


#Region "SYNC CB"

#Region "CB RUE"
    Private Sub ComboBoxRue_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxRue.SelectedIndexChanged


        Dim r As String
        Try

            r = ComboBoxRue.Text

        Catch ex As InvalidCastException



        End Try


        DataGridrech.DataSource = ClientClass.ActualizeCliRue(r)

    End Sub
#End Region


#Region "CB CDP"

    Private Sub ComboBoxCDP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCDP.SelectedIndexChanged

        Dim cp As Integer
        Try

            cp = CInt(ComboBoxCDP.Text)


        Catch ex As InvalidCastException

            Exit Sub

        End Try


        DataGridrech.DataSource = ClientClass.ActualizeCp(cp)

    End Sub
#End Region


#Region "CB Ville"
    Private Sub ComboBoxVille_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVille.SelectedIndexChanged

        Dim v As String
        Try

            v = ComboBoxVille.Text

        Catch ex As InvalidCastException

            Exit Sub

        End Try


        DataGridrech.DataSource = ClientClass.ActualizeVille(v)

    End Sub

    Private Sub cbPatronime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbPatronime.SelectedIndexChanged

    End Sub
#End Region

#End Region


End Class