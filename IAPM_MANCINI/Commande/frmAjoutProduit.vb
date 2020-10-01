Public Class frmAjoutProduit
    Private Sub FrmAjoutProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.DataSource = CommandeClass.GetlesCommandes()
        ComboBox1.ValueMember = "idCommande"
        ComboBox1.DisplayMember = "idCommande"

        cb_produit_commande.DataSource = ProduitClass.GetlesProduitsID()
        cb_produit_commande.DisplayMember = "entierproduit"
        cb_produit_commande.ValueMember = "idProduit"

        DataGridView1.Visible = False




    End Sub

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        CommandeClass.InsererProduitdansCommande(ComboBox1.SelectedValue, cb_produit_commande.SelectedValue, tb_quantite_commande.Text)
        DataGridView1.DataSource = CommandeClass.GetlaCommandeEnCour(ComboBox1.Text)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Try
            DataGridView1.DataSource = CommandeClass.GetlaCommandeEnCour(ComboBox1.Text)
            DataGridView1.Visible = True
        Catch ex As invalidcastException
            Exit Sub
        End Try

    End Sub


End Class