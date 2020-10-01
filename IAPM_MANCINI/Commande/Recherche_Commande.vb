Public Class Recherche_Commande
    Private Sub Recherche_Commande_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridRecherche.DataSource = CommandeClass.GetlesCommandes2()


        RemoveHandler cbID.SelectedIndexChanged, AddressOf cbID_SelectedIndexChanged
        cbID.DataSource = CommandeClass.GetlesCommandes2()
        cbID.DisplayMember = "idCommande"
        AddHandler cbID.SelectedIndexChanged, AddressOf CBID_SelectedIndexChanged

        'RemoveHandler CBClient.SelectedIndexChanged, AddressOf CBClient_SelectedIndexChanged
        'cbID.DataSource = CommandeClass.GetlesCommandes2()
        'cbID.DisplayMember = "Patronime"
        'AddHandler CBClient.SelectedIndexChanged, AddressOf CBClient_SelectedIndexChanged



    End Sub

#Region "CB ID"
    Private Sub CBID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbID.SelectedIndexChanged


        Dim c As Integer
        Try
            c = CInt(cbID.Text)
        Catch ex As InvalidCastException
            Exit Sub
        End Try

        DataGridRecherche.DataSource = CommandeClass.ActualizeCliID(c)

    End Sub
#End Region


    '#Region "CB ID"
    '    Private Sub CBClient_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBClient.SelectedIndexChanged


    '        Dim c As Integer
    '        Try
    '            c = CInt(CBClient.Text)
    '        Catch ex As InvalidCastException
    '            Exit Sub
    '        End Try

    '        DataGridRecherche.DataSource = CommandeClass.ActualizeCliID(c)

    '    End Sub
    '#End Region
End Class