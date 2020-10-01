Imports IAPM_MANCINI.FournisseurClass
Public Class Recherche_Fournisseur
    Private Sub BTNFermer_Click(sender As Object, e As EventArgs) Handles BTNFermer.Click
        Me.Close()
    End Sub

    Private Sub Recherche_Fournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DataGridrech.DataSource = FournisseurClass.GetlesFournisseur()


        RemoveHandler ComboBoxID.SelectedIndexChanged, AddressOf ComboBoxID_SelectedIndexChanged
        ComboBoxID.DataSource = FournisseurClass.GetlesFournisseur()
        ComboBoxID.DisplayMember = "idFournisseur"
        AddHandler ComboBoxID.SelectedIndexChanged, AddressOf ComboBoxID_SelectedIndexChanged


        ComboBoxNom.DataSource = FournisseurClass.GetlesFournisseur()
        ComboBoxNom.DisplayMember = "nomFournisseur"

        RemoveHandler ComboBoxVille.SelectedIndexChanged, AddressOf ComboBoxVille_SelectedIndexChanged
        ComboBoxVille.DataSource = FournisseurClass.GetlesFournisseur()
        ComboBoxVille.DisplayMember = "villeFournisseur"
        AddHandler ComboBoxVille.SelectedIndexChanged, AddressOf ComboBoxVille_SelectedIndexChanged

        RemoveHandler ComboBoxCDP.SelectedIndexChanged, AddressOf ComboBoxCDP_SelectedIndexChanged
        ComboBoxCDP.DataSource = FournisseurClass.GetlesFournisseur()
        ComboBoxCDP.DisplayMember = "cpFournisseur"
        AddHandler ComboBoxCDP.SelectedIndexChanged, AddressOf ComboBoxCDP_SelectedIndexChanged

    End Sub

    Private Sub ComboBoxID_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxID.SelectedIndexChanged

        Dim c As Integer
        Try
            c = CInt(ComboBoxID.Text)
        Catch ex As InvalidCastException
            Exit Sub
        End Try

        DataGridrech.DataSource = ActualizeID(c)
    End Sub

    Private Sub ComboBoxNom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNom.SelectedIndexChanged

        Dim t As String
        Try

            t = ComboBoxNom.Text

        Catch ex As InvalidCastException

            Exit Sub

        End Try


        DataGridrech.DataSource = ActualizeNom(t)

    End Sub

    Private Sub ComboBoxVille_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxVille.SelectedIndexChanged

        Dim cp As Integer
        Try

            cp = CInt(ComboBoxVille.Text)


        Catch ex As InvalidCastException

            Exit Sub

        End Try


        DataGridrech.DataSource = ActualizeVille(cp)

    End Sub

    Private Sub ComboBoxCDP_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxCDP.SelectedIndexChanged
        Dim v As Integer
        Try

            v = CInt(ComboBoxCDP.Text)

        Catch ex As InvalidCastException

            Exit Sub

        End Try


        DataGridrech.DataSource = ActualizeCDP(v)
    End Sub
End Class