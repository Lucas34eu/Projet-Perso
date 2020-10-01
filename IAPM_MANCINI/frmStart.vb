Imports IAPM_MANCINI.ClientClass

Public Class frmStart
    Private Sub QuitterToolStripMenuItem_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub CommandeToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim LS As New frmListeCommande

        LS.Show()
    End Sub



    Private Sub CatégorieToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim LS As New frmCategorie

        LS.Show()
    End Sub

    Private Sub StatistiquesToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim LS As New frmStatistique

        LS.Show()
    End Sub

    Private Sub AProposToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim LS As New frmAPropos

        LS.Show()
    End Sub

    Private Sub frmStart_Load(sender As Object, e As EventArgs) Handles MyBase.Load




        BTNGererLesClients.Visible = False
        BTNRechercheClient.Visible = False


        BTNGererProduit.Visible = False
        BTNRechercheProduit.Visible = False

        btnGererCommande.Visible = False
        btnRechercheCommande.Visible = False

        btnRechercheFourn.Visible = False
        btnGererFourn.Visible = False


        Button8.Visible = False

        Button4.Visible = False

        Button1.Visible = False

        Button6.Visible = False
        Button2.Visible = False



    End Sub

    Private Sub GererLesClientsToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim LS As New frmListeClient


        LS.Show()
    End Sub

    Private Sub RechercherUnClientToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim LS As New frmRechercheClient


        LS.Show()
    End Sub

    Private Sub AjoutSuppresionModificationDunProduitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim LS As New frmListeProduit

        LS.Show()
        LS.BringToFront()

    End Sub

    Private Sub RechercherUnProduitToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim LS As New RechercheProduit


        LS.Show()
    End Sub

    Private Sub GererLesFournisseursToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim LS As New frmListeFournisseur


        LS.Show()
    End Sub

    Private Sub RechercheToolStripMenuItem_Click(sender As Object, e As EventArgs)
        Dim LS As New Recherche_Fournisseur


        LS.Show()
    End Sub

    Private Sub Panel1_MouseHover(sender As Object, e As EventArgs) Handles Panel1.MouseHover
        BTNGererLesClients.Visible = True

        BTNRechercheClient.Visible = True
    End Sub

    Private Sub Panel1_MouseLeave(sender As Object, e As EventArgs) Handles Panel1.MouseLeave

    End Sub

    Private Sub Panel2_MouseLeave(sender As Object, e As EventArgs) Handles Panel2.MouseLeave
        BTNGererLesClients.Visible = False

        BTNRechercheClient.Visible = False
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel4_MouseHover(sender As Object, e As EventArgs) Handles Panel4.MouseHover
        BTNGererProduit.Visible = True
        BTNRechercheProduit.Visible = True
    End Sub

    Private Sub Panel3_MouseLeave(sender As Object, e As EventArgs) Handles Panel3.MouseLeave
        BTNGererProduit.Visible = False
        BTNRechercheProduit.Visible = False
    End Sub

    Private Sub GererLesCommandesToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel5_MouseLeave(sender As Object, e As EventArgs) Handles Panel5.MouseLeave
        btnGererCommande.Visible = False
        btnRechercheCommande.Visible = False
    End Sub

    Private Sub Panel6_MouseHover(sender As Object, e As EventArgs) Handles Panel6.MouseHover
        btnGererCommande.Visible = True
        btnRechercheCommande.Visible = True
    End Sub

    Private Sub Panel8_MouseHover(sender As Object, e As EventArgs) Handles Panel8.MouseHover
        btnGererFourn.Visible = True
        btnRechercheFourn.Visible = True
    End Sub

    Private Sub Panel7_MouseLeave(sender As Object, e As EventArgs) Handles Panel7.MouseLeave
        btnRechercheFourn.Visible = False
        btnGererFourn.Visible = False
    End Sub

    Private Sub BTNGererProduit_Click(sender As Object, e As EventArgs) Handles BTNGererProduit.Click
        Dim LS As New frmListeProduit

        LS.Show()
        LS.BringToFront()
    End Sub

    Private Sub BTNGererLesClients_Click(sender As Object, e As EventArgs) Handles BTNGererLesClients.Click
        Dim LS As New frmListeClient


        LS.Show()
        LS.BringToFront()
    End Sub

    Private Sub BTNRechercheClient_Click(sender As Object, e As EventArgs) Handles BTNRechercheClient.Click
        Dim LS As New frmRechercheClient



        LS.Show()
        LS.BringToFront()
    End Sub

    Private Sub ClientToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub BTNRechercheProduit_Click(sender As Object, e As EventArgs) Handles BTNRechercheProduit.Click
        Dim LS As New RechercheProduit


        LS.Show()
        LS.BringToFront()
    End Sub

    Private Sub btnGererCommande_Click(sender As Object, e As EventArgs) Handles btnGererCommande.Click
        Dim LS As New frmListeCommande


        LS.Show()
        LS.BringToFront()
    End Sub

    Private Sub btnRechercheCommande_Click(sender As Object, e As EventArgs) Handles btnRechercheCommande.Click
        Dim LS As New Recherche_Commande


        LS.Show()
        LS.BringToFront()
    End Sub

    Private Sub btnGererFourn_Click(sender As Object, e As EventArgs) Handles btnGererFourn.Click
        Dim LS As New frmListeFournisseur


        LS.Show()
        LS.BringToFront()
    End Sub

    Private Sub btnRechercheFourn_Click(sender As Object, e As EventArgs) Handles btnRechercheFourn.Click
        Dim LS As New Recherche_Fournisseur


        LS.Show()
        LS.BringToFront()
    End Sub

    Private Sub Panel9_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        Dim LS As New Connection

        Me.Close()
        LS.Show()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Dim LS As New frmCategorie


        LS.Show()
        LS.BringToFront()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim LS As New frmStatistique


        LS.Show()
        LS.BringToFront()
    End Sub

    Private Sub Panel18_MouseHover(sender As Object, e As EventArgs) Handles Panel18.MouseHover
        Button8.Visible = True

    End Sub

    Private Sub Panel17_MouseLeave(sender As Object, e As EventArgs) Handles Panel17.MouseLeave

        Button8.Visible = False
    End Sub

    Private Sub Panel14_MouseHover(sender As Object, e As EventArgs) Handles Panel14.MouseHover
        Button4.Visible = True
    End Sub

    Private Sub Panel13_MouseLeave(sender As Object, e As EventArgs) Handles Panel13.MouseLeave
        Button4.Visible = False
    End Sub

    Private Sub Panel9_Paint_1(sender As Object, e As PaintEventArgs) Handles Panel9.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim LS As New frmAPropos


        LS.Show()
        LS.BringToFront()
    End Sub

    Private Sub Panel11_MouseLeave(sender As Object, e As EventArgs) Handles Panel11.MouseLeave
        Button1.Visible = False
    End Sub

    Private Sub Panel12_MouseHover(sender As Object, e As EventArgs) Handles Panel12.MouseHover
        Button1.Visible = True
    End Sub

    Private Sub Panel15_MouseLeave(sender As Object, e As EventArgs) Handles Panel15.MouseLeave
        Button6.Visible = False
        Button2.Visible = False
    End Sub

    Private Sub Panel16_MouseHover(sender As Object, e As EventArgs) Handles Panel16.MouseHover
        Button6.Visible = True
        Button2.Visible = True
    End Sub
End Class