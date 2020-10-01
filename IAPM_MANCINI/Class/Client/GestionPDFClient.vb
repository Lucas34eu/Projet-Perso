#Region "Namespace"
Imports iTextSharp.text
Imports iTextSharp.text.pdf
#End Region

Public Class GestionPDFClient


#Region "generer pdf depuis table"
    Public Shared Sub genererpdfdepuisdatatable(ByVal titre As String, ByVal lesdonnees As DataTable)

        Dim Doc As Document = New Document
        Dim tableau_entete As PdfPTable
        Dim tableau_ligne As PdfPTable
        Dim cellule As PdfPCell = New PdfPCell
        Try
            PdfWriter.GetInstance(Doc, New System.IO.FileStream(“D:\TableauDesClients.pdf”, System.IO.FileMode.Create))
            'Pour créer le fichier pdf où vous voulez changez le chemin ici.
            Doc.Open()
            'entête de la page
            tableau_entete = New PdfPTable(6)
            'création d’un tableau de 2 colonnes
            cellule.Colspan = 0
            'création d’un tableau a 2 colonnes
            tableau_entete.AddCell("n° CLIENT")
            tableau_entete.AddCell("Nom")
            tableau_entete.AddCell("Prenom")
            tableau_entete.AddCell("Adresse")
            tableau_entete.AddCell("Code Postal")
            tableau_entete.AddCell("Ville")
            'ecriture dans les case du tableau
            tableau_entete.AddCell(titre)
            Doc.Add(New Paragraph("PDF Regroupant l'ensemble des clients :"))
            Doc.Add(New Paragraph(" "))
            Doc.Add(New Paragraph(" "))
            Doc.Add(tableau_entete)
            Doc.Add(New Paragraph(" "))

            'Ajoute le tableau au document. Vous pouvez ajouter un texte ou une variable qui ‘contient tout le texte que vous voulez inserer
            tableau_ligne = New PdfPTable(1)
            tableau_ligne.SpacingBefore = 0
            tableau_ligne = New PdfPTable(4)
            tableau_ligne.DefaultCell.BorderColor = BaseColor.WHITE

            Dim nblignes As Integer
            Dim nbcolonnes As Integer
            Dim uneligne As String = ""
            nblignes = lesdonnees.Rows.Count
            nbcolonnes = lesdonnees.Columns.Count
            cellule.Colspan = 5
            Dim I, j As Integer
            For I = 0 To nblignes - 1
                For j = 0 To nbcolonnes - 1
                    uneligne = uneligne & " " & lesdonnees.Rows(I).Item(j)
                Next

                tableau_ligne.AddCell(uneligne)
                tableau_ligne.AddCell("")
                uneligne = " "
            Next
            Doc.Add(tableau_ligne)
        Catch e As Exception
            MsgBox("Erreur sur le fichier Pdf" & e.Message)
        End Try
        Doc.Close()
        Process.Start("D:\TableauDesClients.pdf") 'Lance le fichier pdf
    End Sub
#End Region

End Class
