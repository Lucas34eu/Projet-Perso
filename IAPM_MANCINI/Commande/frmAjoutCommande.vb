Imports IAPM_MANCINI.frmListeCommande
Imports IAPM_MANCINI.GestionBDD

Public Class frmAjoutCommande



    Private Sub frmAjoutCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dg_commande_en_cours.ForeColor = Color.Black
        tb_ID_Commande.Text = GestionBDD.GenererClePrimaire("IDCommande", "Commande")
        tb_ID_Commande.Enabled = False
        tb_date_commande.Text = DateTime.Now.Date


        cb_id_client.ValueMember = "idClient"
        cb_id_client.DisplayMember = "patronime"

        cb_id_client.DataSource = ClientClass.GetlesClientNom()


        tb_afficher_id.Text = tb_ID_Commande.Text

        cb_produit_commande.DataSource = ProduitClass.GetlesProduitsID
        cb_produit_commande.DisplayMember = "entierproduit"
        cb_produit_commande.ValueMember = "idProduit"




        tb_afficher_id.Enabled = False
        tb_ID_Commande.Enabled = False
        GroupBox2.Enabled = False



        Label11.Text = tb_afficher_id.Text

    End Sub


    Private Sub btn_Creer_Commande_Click(sender As Object, e As EventArgs) Handles btn_Creer_Commande.Click
        GroupBox2.Enabled = True
        GroupBox1.Enabled = False

        Console.WriteLine(cb_id_client.ValueMember)
        CommandeClass.InsererCommande(tb_ID_Commande.Text, tb_date_commande.Text, (cb_id_client.SelectedValue))

    End Sub

    Private Sub btn_Add_Produit_Click(sender As Object, e As EventArgs) Handles btn_Add_Produit.Click
        If tb_quantite_commande.Text = "" Then
            MessageBox.Show("Veuillez renseignez le champs : Quantité ; S'il vous plait !", "Erreur")
        Else
            CommandeClass.InsererProduitdansCommande(tb_ID_Commande.Text, cb_produit_commande.SelectedValue, tb_quantite_commande.Text)


        End If
        tb_quantite_commande.Text = ""
        Label10.Text = CommandeClass.GetTotalbyCommande(tb_afficher_id.Text)
        dg_commande_en_cours.DataSource = CommandeClass.GetlaCommandeEnCour(tb_afficher_id.Text)

    End Sub






#Region "Quantité"
    Private Sub tb_quantite_commande_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_quantite_commande.LostFocus
        If ValidNombre(tb_quantite_commande.Text) = False Then
            Me.ErrorProvider1.SetError(Me.tb_quantite_commande, "Veuiller ne rentrer que des Nombre SVP !!!")
            btn_Add_Produit.Enabled = False
        Else
            Me.ErrorProvider1.SetError(Me.tb_quantite_commande, "")
            btn_Add_Produit.Enabled = True
        End If
    End Sub
#End Region

#Region "Date"
    Private Sub tb_date_commande_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tb_date_commande.LostFocus
        If ValidDate(tb_date_commande.Text) = False Then
            Me.ErrorProvider1.SetError(Me.tb_date_commande, "Veuiller rentrer une date valide svp ( jj/mm/aaaa )  !!!")
            btn_Creer_Commande.Enabled = False
        Else
            Me.ErrorProvider1.SetError(Me.tb_date_commande, "")
            btn_Creer_Commande.Enabled = True
        End If
    End Sub

    Private Sub btn_quitter_Click(sender As Object, e As EventArgs) Handles btn_quitter.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LS As New frmAjoutProduit

        LS.Show()
    End Sub
#End Region


End Class