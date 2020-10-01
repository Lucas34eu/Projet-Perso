<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recherche_Fournisseur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBoxCDP = New System.Windows.Forms.ComboBox()
        Me.ComboBoxVille = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTNFermer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBoxNom = New System.Windows.Forms.ComboBox()
        Me.ComboBoxID = New System.Windows.Forms.ComboBox()
        Me.DataGridrech = New System.Windows.Forms.DataGridView()
        CType(Me.DataGridrech, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(935, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 54
        Me.Label3.Text = "Par Code Postal :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(767, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 20)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Par Ville :"
        '
        'ComboBoxCDP
        '
        Me.ComboBoxCDP.FormattingEnabled = True
        Me.ComboBoxCDP.Location = New System.Drawing.Point(938, 55)
        Me.ComboBoxCDP.Name = "ComboBoxCDP"
        Me.ComboBoxCDP.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCDP.TabIndex = 52
        '
        'ComboBoxVille
        '
        Me.ComboBoxVille.FormattingEnabled = True
        Me.ComboBoxVille.Location = New System.Drawing.Point(770, 55)
        Me.ComboBoxVille.Name = "ComboBoxVille"
        Me.ComboBoxVille.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxVille.TabIndex = 51
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(611, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(0, 13)
        Me.Label5.TabIndex = 50
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(104, 127)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 13)
        Me.Label4.TabIndex = 49
        Me.Label4.Text = "Resultat de la Recherche :"
        '
        'BTNFermer
        '
        Me.BTNFermer.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.BTNFermer.Location = New System.Drawing.Point(518, 508)
        Me.BTNFermer.Name = "BTNFermer"
        Me.BTNFermer.Size = New System.Drawing.Size(217, 65)
        Me.BTNFermer.TabIndex = 48
        Me.BTNFermer.Text = "Fermer"
        Me.BTNFermer.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(261, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 20)
        Me.Label2.TabIndex = 47
        Me.Label2.Text = "Par Nom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(93, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Par ID :"
        '
        'ComboBoxNom
        '
        Me.ComboBoxNom.FormattingEnabled = True
        Me.ComboBoxNom.Location = New System.Drawing.Point(264, 55)
        Me.ComboBoxNom.Name = "ComboBoxNom"
        Me.ComboBoxNom.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxNom.TabIndex = 45
        '
        'ComboBoxID
        '
        Me.ComboBoxID.FormattingEnabled = True
        Me.ComboBoxID.Location = New System.Drawing.Point(96, 55)
        Me.ComboBoxID.Name = "ComboBoxID"
        Me.ComboBoxID.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxID.TabIndex = 44
        '
        'DataGridrech
        '
        Me.DataGridrech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridrech.Location = New System.Drawing.Point(96, 143)
        Me.DataGridrech.Name = "DataGridrech"
        Me.DataGridrech.Size = New System.Drawing.Size(1067, 334)
        Me.DataGridrech.TabIndex = 43
        '
        'Recherche_Fournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1257, 605)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBoxCDP)
        Me.Controls.Add(Me.ComboBoxVille)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTNFermer)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBoxNom)
        Me.Controls.Add(Me.ComboBoxID)
        Me.Controls.Add(Me.DataGridrech)
        Me.Name = "Recherche_Fournisseur"
        Me.Text = "Recherche_Fournisseur"
        CType(Me.DataGridrech, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBoxCDP As ComboBox
    Friend WithEvents ComboBoxVille As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BTNFermer As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboBoxNom As ComboBox
    Friend WithEvents ComboBoxID As ComboBox
    Friend WithEvents DataGridrech As DataGridView
End Class
