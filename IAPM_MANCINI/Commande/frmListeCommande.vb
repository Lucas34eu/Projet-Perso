Imports IAPM_MANCINI.GestionBDD
Public Class frmListeCommande


#Region "Champs"
    Dim position As Integer
    Dim ajouter As Boolean = False
    Dim nbCommande As Integer
    Dim i As Integer
#End Region

#Region "Methodes"

#Region "Methode Rafraichir TextBox"
    Public Sub RafraichirTextBox()


        tbID.Text = dgListeCommande.CurrentRow.Cells(0).Value

        tbNom.Text = dgListeCommande.CurrentRow.Cells(1).Value
        tbPrenom.Text = dgListeCommande.CurrentRow.Cells(2).Value
        tbAdresse.Text = dgListeCommande.CurrentRow.Cells(3).Value







    End Sub
#End Region

#Region "Methode Rafraichir DATASET"


    Public Sub rafraichirDataSet()
        Dim MesCommandes As DataTable = CommandeClass.GetlesCommandes()
        dgListeCommande.DataSource = MesCommandes
        nbCommande = CommandeClass.GetNBCommandes()




    End Sub

#End Region


#End Region


    Private Sub frmListeCommande_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idProfil = 2 Then
            btnModif.Visible = False
            btnAdd.Visible = False
            btnDel.Visible = False
        End If
        tbID.Enabled = False



        rafraichirDataSet()
        RafraichirTextBox()

    End Sub

#Region "BTN Debut"
    Private Sub btnDebut_Click(sender As Object, e As EventArgs) Handles btnDebut.Click


        dgListeCommande.CurrentCell = dgListeCommande.Rows(0).Cells(0)
        RafraichirTextBox()

    End Sub
#End Region


#Region "BTN Precedent"
    Private Sub btnPrec_Click(sender As Object, e As EventArgs) Handles btnPrec.Click

        If dgListeCommande.CurrentRow.Index > 0 Then
            dgListeCommande.CurrentCell = dgListeCommande.Rows(dgListeCommande.CurrentRow.Index - 1).Cells(0)
        End If
        RafraichirTextBox()
    End Sub
#End Region


#Region "BTN Suivant"
    Private Sub btnSuiv_Click(sender As Object, e As EventArgs) Handles btnSuiv.Click

        If dgListeCommande.CurrentRow.Index < nbCommande Then
            dgListeCommande.CurrentCell = dgListeCommande.Rows(dgListeCommande.CurrentRow.Index + 1).Cells(0)

            RafraichirTextBox()
        Else
        End If


    End Sub
#End Region


#Region "BTN FIN"
    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click

        dgListeCommande.CurrentCell = dgListeCommande.Rows(nbCommande - 1).Cells(0)
        RafraichirTextBox()
    End Sub
#End Region


#Region "Clique sur le Data Grid"
    Private Sub dgListeCommande_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListeCommande.CellClick
        RafraichirTextBox()
    End Sub
#End Region


#Region "BTN Fermer"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
#End Region


#Region "Appartition du detail de la commande"
    Private Sub dgListeCommande_CellContentClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgListeCommande.DoubleClick
        commande = dgListeCommande.CurrentRow.Cells(0).Value
        Dim LS As New CommandeDetail

        LS.Show()



    End Sub

    Private Sub dgListeCommande_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
#End Region


#Region "BTN Ajouter"

    Private Sub btnAddku(sender As Object, e As EventArgs) Handles btnAdd.Click





        Dim LS As New frmAjoutCommande

        LS.Show()



        rafraichirDataSet()
        RafraichirTextBox()




    End Sub

#End Region


#Region "BTN Supprimer"
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        Dim c As Integer

        c = CInt(tbID.Text)


        If (MessageBox.Show("Vous êtes sur le point de supprimer la COMMANDE, CONTINUER ? ", " question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            CommandeClass.SupprimerCommande(c)
            MessageBox.Show("Commande Supprimé...!", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            position = 0


            rafraichirDataSet()
            RafraichirTextBox()
        Else


        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        rafraichirDataSet()
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        ToolTip3.SetToolTip(Button3, "Double-Cliquez sur une commande pour afficher son detail !")
    End Sub
#End Region


End Class