#Region "namespace"
Imports IAPM_MANCINI.ClientClass
Imports IAPM_MANCINI.GestionBDD
#End Region
Public Class frmListeClient

#Region "Champs"
    Dim position As Integer
    Dim ajouter As Boolean = False
    Dim nbClients As Integer
#End Region


#Region "Methodes"

#Region "Methode Rafraichir TextBox"
    Public Sub RafraichirTextBox()


        tbID.Text = dgListeClient.CurrentRow.Cells(0).Value
        tbNom.Text = RemplaceSlashApostrophes(dgListeClient.CurrentRow.Cells(1).Value)
        tbPrenom.Text = dgListeClient.CurrentRow.Cells(2).Value
        tbAdresse.Text = dgListeClient.CurrentRow.Cells(3).Value
        tbCodePostal.Text = dgListeClient.CurrentRow.Cells(4).Value
        tbVille.Text = dgListeClient.CurrentRow.Cells(5).Value





    End Sub
#End Region

#Region "Methode Rafraichir DATASET"


    Public Sub rafraichirDataSet()
        Dim MesClients As DataTable = ClientClass.GetlesClients()
        dgListeClient.DataSource = MesClients
        nbClients = ClientClass.GetNBClients()




    End Sub

#End Region


#End Region


#Region "Evenements"

#Region "Chargement de la page"
    Private Sub frmListeClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If idProfil = 2 Then
            btnModif.Visible = False
            btnAdd.Visible = False
            btnDel.Visible = False
        End If
        tbID.Enabled = False
        Panel1.Visible = False
        rafraichirDataSet()
        RafraichirTextBox()



    End Sub
#End Region


#Region "BTN Debut"
    Private Sub btnDebut_Click(sender As Object, e As EventArgs) Handles btnDebut.Click


        dgListeClient.CurrentCell = dgListeClient.Rows(0).Cells(0)
        RafraichirTextBox()

    End Sub
#End Region


#Region "BTN Precedent"
    Private Sub btnPrec_Click(sender As Object, e As EventArgs) Handles btnPrec.Click
        'If position > 0 Then
        '    position = position - 1
        '    Rafraichir()
        'End If
        If dgListeClient.CurrentRow.Index > 0 Then
            dgListeClient.CurrentCell = dgListeClient.Rows(dgListeClient.CurrentRow.Index - 1).Cells(0)
        End If
        RafraichirTextBox()
    End Sub
#End Region


#Region "BTN Suivant"
    Private Sub btnSuiv_Click(sender As Object, e As EventArgs) Handles btnSuiv.Click

        If dgListeClient.CurrentRow.Index < nbClients - 1 Then
            dgListeClient.CurrentCell = dgListeClient.Rows(dgListeClient.CurrentRow.Index + 1).Cells(0)

            RafraichirTextBox()
        End If

        'Rafraichir()
        'If position < nbClients - 1 Then
        '    position = position + 1

        'End If
    End Sub
#End Region


#Region "BTN FIN"
    Private Sub btnFin_Click(sender As Object, e As EventArgs) Handles btnFin.Click

        dgListeClient.CurrentCell = dgListeClient.Rows(nbClients - 1).Cells(0)
        RafraichirTextBox()
    End Sub
#End Region


#Region "Clique sur le Data Grid"
    Private Sub dgListeClient_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgListeClient.CellClick
        RafraichirTextBox()
    End Sub
#End Region


#Region "BTN Ajouter"

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        Dim c, t As Integer
        Dim n, p, em, s As String
        c = GenererClePrimaire("idClient", "Client")
        n = RemplaceApostrophesSlash(tbNom.Text)

        p = tbPrenom.Text
        em = tbAdresse.Text
        t = CInt(tbCodePostal.Text)
        s = tbVille.Text

        If ajouter Then
            ClientClass.InsererClient(c, n, p, em, t, s)
            MessageBox.Show("Etudiant Ajouté...!", "Insertion")

            position = 0



            ajouter = False
            rafraichirDataSet()
            RafraichirTextBox()
        Else
            tbID.Text = c
            tbAdresse.Text = ""
            tbCodePostal.Text = ""
            tbNom.Text = ""
            tbPrenom.Text = ""
            tbVille.Text = ""
            ajouter = True




        End If



    End Sub
#End Region


#Region "BTN Supprimer"
    Private Sub btnDel_Click(sender As Object, e As EventArgs) Handles btnDel.Click

        Dim c As Integer

        c = CInt(tbID.Text)


        If (MessageBox.Show("Vous êtes sur le point de supprimer le CLIENT , CONTINUER ? ", " question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            SupprimerClient(c)
            MessageBox.Show("Etudiant Supprimé...!", "Supprimer", MessageBoxButtons.OK, MessageBoxIcon.Information)
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


            Dim c, t As Integer
            Dim n, p, em, s As String

            c = CInt(tbID.Text)
            n = tbNom.Text
            p = tbPrenom.Text
            em = tbAdresse.Text
            t = CInt(tbCodePostal.Text)
            s = tbVille.Text
            tbID.Enabled = False




            If (MessageBox.Show("Vous êtes sur le point de modifier le CLIENT , CONTINUEZ ? ", "question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
                ModifierClient(n, p, em, t, s, c)
                MessageBox.Show("Section Modifier...!", "Insertion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                position = 0

                'Rechargerlesdonnees()
                rafraichirDataSet()
                RafraichirTextBox()

            Else




            End If
        End If
    End Sub
#End Region

#Region "BTN Fermer"

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
#End Region


#Region "Controle de saisies"

#Region "NOM"
    Private Sub tbNom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbNom.LostFocus
        If ValidNom(tbNom.Text) = False Then
            Me.ErrorProvider1.SetError(Me.tbNom, "Veuiller ne rentrer que des lettre SVP !!!")
            btnAdd.Enabled = False
        Else
            btnAdd.Enabled = True
            Me.ErrorProvider1.SetError(Me.tbNom, "")
        End If
    End Sub
#End Region


#Region "Prenom"
    Private Sub tbPrenom_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbPrenom.LostFocus
        If ValidNom(tbPrenom.Text) = False Then
            Me.ErrorProvider2.SetError(Me.tbPrenom, "Veuiller ne rentrer que des lettre SVP !!!")
            btnAdd.Enabled = False
        Else
            Me.ErrorProvider2.SetError(Me.tbPrenom, "")
            btnAdd.Enabled = True
        End If
    End Sub
#End Region


#Region "Code Postal"
    Private Sub tbCodePostal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbCodePostal.LostFocus
        If ValidNombre(tbCodePostal.Text) = False Then
            Me.ErrorProvider4.SetError(Me.tbCodePostal, "Veuiller ne rentrer que des Nombre SVP !!!")
            btnAdd.Enabled = False
        Else
            Me.ErrorProvider4.SetError(Me.tbCodePostal, "")
            btnAdd.Enabled = True
        End If
    End Sub
#End Region


#Region "Ville"
    Private Sub tbVille_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbVille.LostFocus
        If ValidNom(tbVille.Text) = False Then
            Me.ErrorProvider5.SetError(Me.tbVille, "Veuiller ne rentrer que des lettre SVP !!!")
            btnAdd.Enabled = False
        Else
            Me.ErrorProvider5.SetError(Me.tbVille, "")
            btnAdd.Enabled = True
        End If
    End Sub
#End Region


#End Region


#Region "Telechargement du PDF"
    Private Sub btnPDF_Click(sender As Object, e As EventArgs)
        GestionPDFClient.genererpdfdepuisdatatable("Liste des Clients", ClientClass.GetlesClients())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        GestionPDFClient.genererpdfdepuisdatatable("Liste des Clients", ClientClass.GetlesClients())
    End Sub

    Private Sub dgListeClient_MouseHover(sender As Object, e As EventArgs) Handles dgListeClient.MouseHover
        Panel1.Visible = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Panel1.Visible = False
    End Sub
#End Region

#End Region

End Class