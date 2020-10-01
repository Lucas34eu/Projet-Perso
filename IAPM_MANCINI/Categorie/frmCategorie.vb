Imports IAPM_MANCINI.GestionBDD
Public Class frmCategorie



#Region "Champs"
    Dim position As Integer
    Dim ajouter As Boolean = False
    Dim nbCat As Integer
#End Region


#Region "Methodes"


#Region "Methode RafraichirTextBox"
    Public Sub RafraichirTextBox()


        tbID.Text = dgListeCat.CurrentRow.Cells(0).Value
        tbLibCat.Text = RemplaceApostrophesSlash(dgListeCat.CurrentRow.Cells(1).Value)


    End Sub
#End Region


#Region "RafraichirDataSet"

    Public Sub rafraichirDataSet()
        Dim MesProduits As DataTable = CategorieClass.GetlesCat()
        dgListeCat.DataSource = MesProduits
        nbCat = CategorieClass.GetNBCat()

    End Sub
#End Region


#Region "Load"

    Private Sub frmCategorie_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idProfil = 2 Then
            btnModif.Visible = False
            btnAdd.Visible = False
            btnDel.Visible = False
        End If
        tbID.Enabled = False


        rafraichirDataSet()
        RafraichirTextBox()

    End Sub
#End Region


#Region "Gestion du datagrid"
    Private Sub dgListeCat_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListeCat.CellClick
        RafraichirTextBox()
    End Sub
#End Region


#Region "BTN Debut"
    Private Sub btnDebut_Click(sender As Object, e As EventArgs) Handles btnDebut.Click
        dgListeCat.CurrentCell = dgListeCat.Rows(0).Cells(0)
        RafraichirTextBox()
    End Sub
#End Region


#Region "BTN Precedent"
    Private Sub btnPrec_Click(sender As Object, e As EventArgs) Handles btnPrec.Click
        If dgListeCat.CurrentRow.Index > 0 Then
            dgListeCat.CurrentCell = dgListeCat.Rows(dgListeCat.CurrentRow.Index - 1).Cells(0)
        End If
        RafraichirTextBox()
    End Sub
#End Region


#Region "BTN Suivant"
    Private Sub btnSuiv_Click(sender As Object, e As EventArgs) Handles btnSuiv.Click

        If dgListeCat.CurrentRow.Index < nbCat - 1 Then
            dgListeCat.CurrentCell = dgListeCat.Rows(dgListeCat.CurrentRow.Index + 1).Cells(0)

            RafraichirTextBox()
        End If
    End Sub
#End Region


#Region "BTN FIN"
    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click
        dgListeCat.CurrentCell = dgListeCat.Rows(nbCat - 1).Cells(0)
        RafraichirTextBox()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
#End Region


#Region "BTN Ajouter"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim c As Integer
        Dim n As String
        c = GenererClePrimaire("idCategorie", "categorie")
        n = RemplaceApostrophesSlash(tbLibCat.Text)


        If ajouter Then
            CategorieClass.InsererCat(c, n)
            MessageBox.Show("Produit Ajouté...!", "Insertion")

            position = 0


            ajouter = False
            rafraichirDataSet()
            RafraichirTextBox()

        Else
            tbID.Text = c
            tbLibCat.Text = ""

            ajouter = True




        End If



    End Sub
#End Region


#Region "BTN Supprimer"
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        Dim c As Integer

        c = CInt(tbID.Text)


        If (MessageBox.Show("Vous êtes sur le point de supprimer la CATEGORIE , CONTINUER ? ", " question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            CategorieClass.SetProduitCategorieNull(c)
            CategorieClass.SupprimerCat(c)

            MessageBox.Show("Categorie Supprimé...!", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information)
            position = 0


            rafraichirDataSet()
            RafraichirTextBox()

        Else


        End If
    End Sub
#End Region


#Region "BTN Modifier"

    Private Sub btnModif_Click(sender As Object, e As EventArgs) Handles btnModif.Click
        tbID.Enabled = False
        If tbID.Text <> "" Then


            Dim c As Integer
            Dim n As String

            c = CInt(tbID.Text)
            n = tbLibCat.Text


            tbID.Enabled = False




            If (MessageBox.Show("Vous êtes sur le point de modifier la CATEGORIE , CONTINUEZ ? ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

                CategorieClass.Modifiercat(c, n)
                MessageBox.Show("Categorie Modifier...!", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                position = 0


                rafraichirDataSet()
                RafraichirTextBox()

            Else




            End If
        End If
    End Sub
#End Region

#Region "Controle de saisies"

#Region "NOM"
    Private Sub tbNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbLibCat.LostFocus
        If ValidNom(tbLibCat.Text) = False Then
            Me.ErrorProvider2.SetError(Me.tbLibCat, "Veuiller ne rentrer que des lettre SVP !!!")
            btnAdd.Enabled = False
        Else
            Me.ErrorProvider2.SetError(Me.tbLibCat, "")
            btnAdd.Enabled = True
        End If
    End Sub
#End Region


#End Region

#End Region

End Class