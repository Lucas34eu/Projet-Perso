#Region "namespace"
Imports IAPM_MANCINI.ProduitClass
#End Region
Public Class frmListeProduit


#Region "Champs"
    Dim position As Integer
    Dim ajouter As Boolean = False
    Dim nbProduit As Integer
#End Region


#Region "Methodes"
#Region "Methode RafraichirTextBox"
    Public Sub RafraichirTextBox()


        tbIDProduit.Text = dgListeProduit.CurrentRow.Cells(0).Value
        tbProduitNom.Text = RemplaceApostrophesSlash(dgListeProduit.CurrentRow.Cells(1).Value)
        tbPrix.Text = dgListeProduit.CurrentRow.Cells(2).Value
        tbQte.Text = dgListeProduit.CurrentRow.Cells(3).Value

    End Sub
#End Region

#Region "RafraichirDataSet"

    Public Sub rafraichirDataSet()
        Dim MesProduits As DataTable = ProduitClass.GetlesProduits()
        dgListeProduit.DataSource = MesProduits
        nbProduit = ProduitClass.GetNBProduits()

    End Sub
#End Region

#End Region


#Region "Evenement"

#Region "Chargement de la page "
    Private Sub frmListeProduit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idProfil = 2 Then
            btnModif.Visible = False
            btnAdd.Visible = False
            btnDel.Visible = False
        End If


        Panel1.Visible = False
        tbIDProduit.Enabled = False


        'Me.Left = 500
        'Me.Top = 500



        rafraichirDataSet()
        RafraichirTextBox()







        ComboBoxIDFournisseur.DataSource = GetlesFournisseurs()
        ComboBoxIDFournisseur.DisplayMember = "NomFournisseur"
        ComboBoxIDFournisseur.ValueMember = "idFournisseur"

        ComboBoxIDCategorie.DataSource = GetlesCategories()
        ComboBoxIDCategorie.DisplayMember = "LibelleCategorie"
        ComboBoxIDCategorie.ValueMember = "idCategorie"



    End Sub
#End Region


#Region "Clique sur le DG"
    Private Sub dgListeProduit_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListeProduit.CellClick
        RafraichirTextBox()

    End Sub
#End Region


#Region "BTN Debut"
    Private Sub btnDebut_Click(sender As Object, e As EventArgs) Handles btnDebut.Click
        dgListeProduit.CurrentCell = dgListeProduit.Rows(0).Cells(0)
        RafraichirTextBox()
    End Sub
#End Region


#Region "BTN Precedent"
    Private Sub btnPrec_Click(sender As Object, e As EventArgs) Handles btnPrec.Click
        If dgListeProduit.CurrentRow.Index > 0 Then
            dgListeProduit.CurrentCell = dgListeProduit.Rows(dgListeProduit.CurrentRow.Index - 1).Cells(0)
        End If
        RafraichirTextBox()
    End Sub
#End Region


#Region "BTN Suivant"
    Private Sub btnSuiv_Click(sender As Object, e As EventArgs) Handles btnSuiv.Click

        If dgListeProduit.CurrentRow.Index < nbProduit - 1 Then
            dgListeProduit.CurrentCell = dgListeProduit.Rows(dgListeProduit.CurrentRow.Index + 1).Cells(0)

            RafraichirTextBox()
        End If
    End Sub
#End Region

#Region "BTN FIN"
    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        dgListeProduit.CurrentCell = dgListeProduit.Rows(nbProduit - 1).Cells(0)
        RafraichirTextBox()
    End Sub
#End Region


#Region "BTN Ajouter"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim c, p, em As Integer
        Dim n, s, t As String
        c = GenererClePrimaire("idProduit", "produit")
        n = RemplaceApostrophesSlash(tbProduitNom.Text)
        p = CInt(tbPrix.Text)
        em = CInt(tbQte.Text)
        t = ComboBoxIDFournisseur.SelectedValue
        s = ComboBoxIDCategorie.SelectedValue

        If ajouter Then
            ProduitClass.InsererProduit(c, n, p, em, t, s)
            MessageBox.Show("Produit Ajouté...!", "Insertion")

            position = 0


            ajouter = False
            rafraichirDataSet()
            RafraichirTextBox()

        Else
            tbIDProduit.Text = c
            tbProduitNom.Text = ""
            tbPrix.Text = ""
            tbQte.Text = ""
            ComboBoxIDFournisseur.Text = ""
            ComboBoxIDCategorie.Text = ""
            ajouter = True




        End If



    End Sub
#End Region

#Region "BTN Supprimer"
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        Dim c As Integer

        c = CInt(tbIDProduit.Text)


        If (MessageBox.Show("Vous êtes sur le point de supprimer le PRODUIT , CONTINUER ? ", " question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            ProduitClass.SupprimerProduit(c)

            MessageBox.Show("Produit Supprimé...!", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            position = 0


            rafraichirDataSet()
            RafraichirTextBox()

        Else


        End If
    End Sub
#End Region

#Region "BTN Modifier"

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        tbIDProduit.Enabled = False
        If tbIDProduit.Text <> "" Then


            Dim c, em, p As Integer
            Dim n As String

            c = CInt(tbIDProduit.Text)
            n = tbProduitNom.Text
            p = tbPrix.Text
            em = tbQte.Text

            tbIDProduit.Enabled = False




            If (MessageBox.Show("Vous êtes sur le point de modifier le PRODUIT , CONTINUEZ ? ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                ModifierProduit(n, p, em, c)
                MessageBox.Show("Produit Modifier...!", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                position = 0


                rafraichirDataSet()
                RafraichirTextBox()

            Else




            End If
        End If
    End Sub
#End Region

#Region "Button Fermer"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
#End Region

#Region "Generer PDF"

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GestionPDFProduit.genererpdfdepuisdatatable("Liste des Produits", ProduitClass.GetlesProduits())
    End Sub
#End Region

#Region "Controle de Saisie"


#Region "Produit"
    Private Sub tbIDProduit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIDProduit.LostFocus
        If ValidNombre(tbIDProduit.Text) = False Then
            Me.ErrorProvider1.SetError(Me.tbIDProduit, "Veuiller ne rentrer que des chiffre !!!")
            btnAdd.Enabled = False
        Else
            Me.ErrorProvider1.SetError(Me.tbIDProduit, "")
            btnAdd.Enabled = True
        End If
    End Sub
#End Region


#Region "Prix"
    Private Sub tbPrix_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPrix.LostFocus
        If ValidNombre(tbPrix.Text) = False Then
            Me.ErrorProvider3.SetError(Me.tbPrix, "Veuiller ne rentrer que des chiffre !!!")
            btnAdd.Enabled = False
        Else
            Me.ErrorProvider3.SetError(Me.tbPrix, "")
            btnAdd.Enabled = True
        End If
    End Sub
#End Region


#Region "Quantité"
    Private Sub tbQte_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbQte.LostFocus
        If ValidNombre(tbQte.Text) = False Then
            Me.ErrorProvider4.SetError(Me.tbQte, "Veuiller ne rentrer que des chiffre !!!")
            btnAdd.Enabled = False
        Else
            Me.ErrorProvider4.SetError(Me.tbQte, "")
            btnAdd.Enabled = True
        End If
    End Sub
#End Region

#End Region

#Region "Gestion du Panel"

#Region "Apparition"
    Private Sub dgListeProduit_MouseHover(sender As Object, e As EventArgs) Handles dgListeProduit.MouseHover
        Panel1.Visible = True
    End Sub
#End Region

#Region "Disparition"
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub dgListeProduit_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListeProduit.CellContentClick

    End Sub



#End Region

#End Region

#End Region

End Class