Imports IAPM_MANCINI.ProduitClass
Public Class RechercheProduit

#Region "Evenement"

#Region "Load"
    Private Sub RechercheProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        DataGridrech.DataSource = GetlesProduits()


        RemoveHandler ComboBoxID.SelectedIndexChanged, AddressOf ComboBoxID_SelectedIndexChanged
        ComboBoxID.DataSource = GetlesProduits()
        ComboBoxID.DisplayMember = "idProduit"
        AddHandler ComboBoxID.SelectedIndexChanged, AddressOf ComboBoxID_SelectedIndexChanged


        ComboBoxNom.DataSource = GetlesProduits()
        ComboBoxNom.DisplayMember = "libelleProduit"

        RemoveHandler ComboBoxFour.SelectedIndexChanged, AddressOf ComboBoxFour_SelectedIndexChanged
        ComboBoxFour.DataSource = GetlesProduits()
        ComboBoxFour.DisplayMember = "nomFournisseur"
        AddHandler ComboBoxFour.SelectedIndexChanged, AddressOf ComboBoxFour_SelectedIndexChanged

        RemoveHandler ComboBoxCat.SelectedIndexChanged, AddressOf ComboBoxCat_SelectedIndexChanged
        ComboBoxCat.DataSource = GetlesProduits()
        ComboBoxCat.DisplayMember = "libelleCategorie"
        AddHandler ComboBoxCat.SelectedIndexChanged, AddressOf ComboBoxCat_SelectedIndexChanged

        RemoveHandler CBPRIX.SelectedIndexChanged, AddressOf ComboBox1_SelectedIndexChanged
        CBPRIX.DataSource = GetlesProduits()
        CBPRIX.DisplayMember = "prixHTProduit"
        AddHandler CBPRIX.SelectedIndexChanged, AddressOf ComboBox1_SelectedIndexChanged

        RemoveHandler CBQTE.SelectedIndexChanged, AddressOf ComboBox2_SelectedIndexChanged
        CBQTE.DataSource = GetlesProduits()
        CBQTE.DisplayMember = "qteStockProduit"
        AddHandler CBQTE.SelectedIndexChanged, AddressOf ComboBox2_SelectedIndexChanged

    End Sub
#End Region


#Region "BTN Fermer"
    Private Sub BTNFermer_Click(sender As Object, e As EventArgs) Handles BTNFermer.Click
        Me.Close()
    End Sub
#End Region


#Region "CB ID"

    Private Sub ComboBoxID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxID.SelectedIndexChanged


        Dim c As Integer
        Try
            c = CInt(ComboBoxID.Text)
        Catch ex As InvalidCastException
            Exit Sub
        End Try

        DataGridrech.DataSource = ActualizeProID(c)

    End Sub
#End Region



#Region "CB NOM"
    Private Sub ComboBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNom.SelectedIndexChanged

        Dim t As String
        Try

            t = ComboBoxNom.Text

        Catch ex As InvalidCastException

            Exit Sub

        End Try


        DataGridrech.DataSource = ActualizeProNom(t)

    End Sub
#End Region


#Region "CB FOURN"
    Private Sub ComboBoxFour_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxFour.SelectedIndexChanged

        Dim cp As Integer
        Try

            cp = CInt(ComboBoxFour.Text)


        Catch ex As InvalidCastException

            Exit Sub

        End Try


        DataGridrech.DataSource = ActualizeFourn(cp)

    End Sub
#End Region


#Region "CB CAT"
    Private Sub ComboBoxCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCat.SelectedIndexChanged

        Dim v As Integer
        Try

            v = CInt(ComboBoxCat.Text)

        Catch ex As InvalidCastException

            Exit Sub

        End Try


        DataGridrech.DataSource = ActualizeCat(v)

    End Sub
#End Region

#Region "CB PRIX"
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBPRIX.SelectedIndexChanged
        Dim pm As Integer
        Try

            pm = CInt(CBPRIX.Text)


        Catch ex As InvalidCastException

            Exit Sub

        End Try


        DataGridrech.DataSource = ActualizePrix(pm)
    End Sub
#End Region

#Region "CB QTE"
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBQTE.SelectedIndexChanged
        Dim mp As Integer
        Try

            mp = CInt(CBQTE.Text)


        Catch ex As InvalidCastException

            Exit Sub

        End Try


        DataGridrech.DataSource = ActualizeQTE(mp)
    End Sub
#End Region

#End Region


End Class