#Region "namespace"
Imports IAPM_MANCINI.GestionBDD
#End Region
Public Class frmListeFournisseur

#Region "Champs"
    Dim nbFourn As Integer
    Dim position As Integer
    Dim ajouter As Boolean = False
#End Region


#Region "Methodes"
#Region "Methode RafraichirTextBox"
    Public Sub RafraichirTextBox()


        tbIDFourn.Text = dgListeFourn.CurrentRow.Cells(0).Value
        tbNomFourn.Text = RemplaceApostrophesSlash(dgListeFourn.CurrentRow.Cells(1).Value)
        tbVilleFourn.Text = dgListeFourn.CurrentRow.Cells(2).Value
        tbCDPFourn.Text = dgListeFourn.CurrentRow.Cells(3).Value

    End Sub
#End Region

#Region "RafraichirDataSet"

    Public Sub rafraichirDataSet()
        Dim MesFournisseur As DataTable = FournisseurClass.GetlesFournisseur()
        dgListeFourn.DataSource = MesFournisseur
        nbFourn = FournisseurClass.GetNBFournisseur()

    End Sub
#End Region

#End Region


#Region "Evenement"


#Region "Load"
    Private Sub frmListeFournisseur_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If idProfil = 2 Then
            btnModif.Visible = False
            BTN_Ajouter.Visible = False
            btnDel.Visible = False
        End If


        Panel1.Visible = False
        tbIDFourn.Enabled = False

        rafraichirDataSet()
        RafraichirTextBox()

        Panel1.Visible = False


    End Sub
#End Region

#Region "BTN SUIVANT"
    Private Sub btnSuiv_Click(sender As Object, e As EventArgs) Handles btnSuiv.Click

        If dgListeFourn.CurrentRow.Index < nbFourn - 1 Then
            dgListeFourn.CurrentCell = dgListeFourn.Rows(dgListeFourn.CurrentRow.Index + 1).Cells(0)

            RafraichirTextBox()
        End If
    End Sub
#End Region

#Region "BTN PRECEDENT"
    Private Sub btnPrec_Click(sender As Object, e As EventArgs) Handles btnPrec.Click
        If dgListeFourn.CurrentRow.Index > 0 Then
            dgListeFourn.CurrentCell = dgListeFourn.Rows(dgListeFourn.CurrentRow.Index - 1).Cells(0)
        End If
        RafraichirTextBox()
    End Sub
#End Region


#Region "BTN FIN"
    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        dgListeFourn.CurrentCell = dgListeFourn.Rows(nbFourn - 1).Cells(0)
        RafraichirTextBox()
    End Sub
#End Region


#Region " BTN DEBUT"
    Private Sub btnDebut_Click(sender As Object, e As EventArgs) Handles btnDebut.Click
        dgListeFourn.CurrentCell = dgListeFourn.Rows(0).Cells(0)
        RafraichirTextBox()
    End Sub
#End Region


#Region "BTN FERMER"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
#End Region

#Region "BTN MASQUER panel "

    Private Sub btnHIDE_Click(sender As Object, e As EventArgs) Handles btnHIDE.Click
        Panel1.Visible = False
    End Sub
#End Region

#Region "BTN TELECHARGER LE PDF"
    Private Sub btnDL_PDF_Click(sender As Object, e As EventArgs) Handles btnDL_PDF.Click
        GestionPDF_Fourn.genererpdfdepuisdatatable("Liste des Produits", ProduitClass.GetlesProduits())
    End Sub
#End Region

#Region "Apparition du panel"
    Private Sub dgListeFourn_MouseHover(sender As Object, e As EventArgs) Handles dgListeFourn.MouseHover
        Panel1.Visible = True
    End Sub
#End Region

#Region "BTN AJOUTER"
    Private Sub BTN_Ajout_Click(sender As Object, e As EventArgs) Handles BTN_Ajouter.Click
        Dim c, em As Integer
        Dim n, p As String
        c = GenererClePrimaire("idFournisseur", "fournisseur")
        n = RemplaceApostrophesSlash(tbNomFourn.Text)
        p = tbVilleFourn.Text
        em = CInt(tbCDPFourn.Text)


        If ajouter Then
            FournisseurClass.InsererFournisseur(c, n, p, em)
            MessageBox.Show("Fournisseur Ajouté...!", "Insertion")

            position = 0


            ajouter = False
            rafraichirDataSet()
            RafraichirTextBox()

        Else
            tbIDFourn.Text = c
            tbNomFourn.Text = ""
            tbVilleFourn.Text = ""
            tbCDPFourn.Text = ""
            ajouter = True




        End If



    End Sub
#End Region

#Region "BTN DELETE"
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click
        Dim c As Integer

        c = CInt(tbIDFourn.Text)


        If (MessageBox.Show("Vous êtes sur le point de supprimer le FOURNISSEUR , CONTINUER ? ", " question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            FournisseurClass.SupprimerFournisseur(c)

            MessageBox.Show("Fournisseur Supprimé...!", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            position = 0


            rafraichirDataSet()
            RafraichirTextBox()

        Else


        End If
    End Sub

#End Region

#Region "BTN MODIFIER"
    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        tbIDFourn.Enabled = False
        If tbIDFourn.Text <> "" Then


            Dim c, em As Integer
            Dim n, p As String

            c = CInt(tbIDFourn.Text)
            n = tbNomFourn.Text
            p = tbVilleFourn.Text
            em = tbCDPFourn.Text

            tbIDFourn.Enabled = False




            If (MessageBox.Show("Vous êtes sur le point de modifier le FOURNISSEUR, CONTINUEZ ? ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                FournisseurClass.ModifierFournisseur(n, p, em, c)
                MessageBox.Show("Fournisseur Modifier...!", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                position = 0


                rafraichirDataSet()
                RafraichirTextBox()

            Else




            End If
        End If
    End Sub

#End Region

#Region "Changement des TB en fonction du clique sur la cellule du DG"

    Private Sub dgListeFourn_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListeFourn.CellClick
        RafraichirTextBox()
    End Sub

#End Region

#Region "Nom"
    Private Sub tbNomFourn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNomFourn.LostFocus
        If ValidNom(tbNomFourn.Text) = False Then
            Me.ErrorProvider2.SetError(Me.tbNomFourn, "Veuiller ne rentrer que des lettre SVP !!!")
            BTN_Ajouter.Enabled = False
        Else
            Me.ErrorProvider2.SetError(Me.tbNomFourn, "")
            BTN_Ajouter.Enabled = True
        End If
    End Sub
#End Region


#Region "ID "
    Private Sub tbIDFourn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbIDFourn.LostFocus
        If ValidNombre(tbIDFourn.Text) = False Then
            Me.ErrorProvider4.SetError(Me.tbIDFourn, "Veuiller ne rentrer que des chiffres SVP !!!")
            BTN_Ajouter.Enabled = False
        Else
            Me.ErrorProvider4.SetError(Me.tbIDFourn, "")
            BTN_Ajouter.Enabled = True
        End If
    End Sub
#End Region

#Region "Ville"
    Private Sub tbVilleFourn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbVilleFourn.LostFocus
        If ValidNom(tbVilleFourn.Text) = False Then
            Me.ErrorProvider2.SetError(Me.tbVilleFourn, "Veuiller ne rentrer que des lettre SVP !!!")
            BTN_Ajouter.Enabled = False
        Else
            Me.ErrorProvider2.SetError(Me.tbVilleFourn, "")
            BTN_Ajouter.Enabled = True
        End If
    End Sub
#End Region


#Region "Code Postal"
    Private Sub tbCDPFourn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCDPFourn.LostFocus
        If ValidNombre(tbCDPFourn.Text) = False Then
            Me.ErrorProvider4.SetError(Me.tbCDPFourn, "Veuiller ne rentrer que des chiffres SVP !!!")
            BTN_Ajouter.Enabled = False
        Else
            Me.ErrorProvider4.SetError(Me.tbCDPFourn, "")
            BTN_Ajouter.Enabled = True
        End If
    End Sub
#End Region


#End Region


End Class