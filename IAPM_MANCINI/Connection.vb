Imports IAPM_MANCINI.GestionBDD
Public Class Connection



    Private Sub Connection_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GestionBDD.SeConnecter()
    End Sub

    Private Sub btnConnexion_Click(sender As Object, e As EventArgs) Handles btnConnexion.Click



        Dim lesUtilisateurs As DataTable = GestionBDD.GetlesUsers(utilisateur.Text, mdp.Text)
        If lesUtilisateurs.Rows.Count > 0 Then

            GestionBDD.idProfil = lesUtilisateurs.Rows(0).Item("idProfil")

            Dim LS As New frmStart

            LS.Show()
            Me.Hide()
        Else
            MessageBox.Show("Utilisateur ou mot de passe INVALIDE !", "Utilisateur Inconnu", MessageBoxButtons.OK, MessageBoxIcon.Error)


        End If




    End Sub


    'Bouton entrer pour se connecter
    Private Sub utilisateur_KeyDown(sender As Object, e As KeyEventArgs) Handles utilisateur.KeyDown, mdp.KeyDown
        If e.KeyCode = Keys.Enter Then
            GestionBDD.SeConnecter()

            Dim lesUtilisateurs As DataTable = GestionBDD.GetlesUsers(utilisateur.Text, mdp.Text)
            If lesUtilisateurs.Rows.Count > 0 Then

                GestionBDD.idProfil = lesUtilisateurs.Rows(0).Item("idProfil")

                Dim LS As New frmStart

                LS.Show()
                Me.Hide()
            Else
                MessageBox.Show("Utilisateur ou mot de passe INVALIDE !", "Utilisateur Inconnu", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If
        End If
    End Sub


End Class