Imports IAPM_MANCINI.GestionBDD
Imports IAPM_MANCINI.frmAjoutCommande
Class CommandeDetail

    Dim commande_en_cours As Integer = commande
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub



    Private Sub CommandeDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim MesCommandes As DataTable = CommandeClass.GetlesCommandesDetail()
        dgListeCommande.DataSource = MesCommandes
        tbTotal.Text = CommandeClass.GetTotalByCommande(commande)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GestionPDFCommande.genererpdfdepuisdatatable("PDF_Recapitulatif_Commande", CommandeClass.GetlesCommandesDetail())
    End Sub
End Class