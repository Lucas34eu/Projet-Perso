<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmListeCommande
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.la = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDebut = New System.Windows.Forms.Button()
        Me.btnPrec = New System.Windows.Forms.Button()
        Me.btnSuiv = New System.Windows.Forms.Button()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.dgListeCommande = New System.Windows.Forms.DataGridView()
        Me.tbAdresse = New System.Windows.Forms.TextBox()
        Me.tbPrenom = New System.Windows.Forms.TextBox()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ToolTip3 = New System.Windows.Forms.ToolTip(Me.components)
        Me.la.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgListeCommande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(485, 470)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 45)
        Me.Button1.TabIndex = 45
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'la
        '
        Me.la.Controls.Add(Me.btnAdd)
        Me.la.Controls.Add(Me.btnModif)
        Me.la.Controls.Add(Me.btnDel)
        Me.la.ForeColor = System.Drawing.Color.White
        Me.la.Location = New System.Drawing.Point(623, 419)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(582, 145)
        Me.la.TabIndex = 44
        Me.la.TabStop = False
        Me.la.Text = "Ajout / Suppression / Modification"
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(11, 51)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(170, 55)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Ajouter"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnModif
        '
        Me.btnModif.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnModif.ForeColor = System.Drawing.Color.Black
        Me.btnModif.Location = New System.Drawing.Point(376, 51)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(170, 55)
        Me.btnModif.TabIndex = 18
        Me.btnModif.Text = "Modifier"
        Me.btnModif.UseVisualStyleBackColor = True
        '
        'btnDel
        '
        Me.btnDel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnDel.ForeColor = System.Drawing.Color.Black
        Me.btnDel.Location = New System.Drawing.Point(200, 51)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(170, 55)
        Me.btnDel.TabIndex = 13
        Me.btnDel.Text = "Supprimer"
        Me.btnDel.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDebut)
        Me.GroupBox1.Controls.Add(Me.btnPrec)
        Me.GroupBox1.Controls.Add(Me.btnSuiv)
        Me.GroupBox1.Controls.Add(Me.btnFin)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(63, 419)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 145)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Naviguation dans la BDD"
        '
        'btnDebut
        '
        Me.btnDebut.ForeColor = System.Drawing.Color.Black
        Me.btnDebut.Location = New System.Drawing.Point(6, 59)
        Me.btnDebut.Name = "btnDebut"
        Me.btnDebut.Size = New System.Drawing.Size(82, 77)
        Me.btnDebut.TabIndex = 12
        Me.btnDebut.Text = "<<"
        Me.btnDebut.UseVisualStyleBackColor = True
        '
        'btnPrec
        '
        Me.btnPrec.ForeColor = System.Drawing.Color.Black
        Me.btnPrec.Location = New System.Drawing.Point(109, 72)
        Me.btnPrec.Name = "btnPrec"
        Me.btnPrec.Size = New System.Drawing.Size(53, 51)
        Me.btnPrec.TabIndex = 17
        Me.btnPrec.Text = "<"
        Me.btnPrec.UseVisualStyleBackColor = True
        '
        'btnSuiv
        '
        Me.btnSuiv.ForeColor = System.Drawing.Color.Black
        Me.btnSuiv.Location = New System.Drawing.Point(191, 72)
        Me.btnSuiv.Name = "btnSuiv"
        Me.btnSuiv.Size = New System.Drawing.Size(53, 51)
        Me.btnSuiv.TabIndex = 16
        Me.btnSuiv.Text = ">"
        Me.btnSuiv.UseVisualStyleBackColor = True
        '
        'btnFin
        '
        Me.btnFin.ForeColor = System.Drawing.Color.Black
        Me.btnFin.Location = New System.Drawing.Point(283, 59)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(81, 77)
        Me.btnFin.TabIndex = 15
        Me.btnFin.Text = ">>"
        Me.btnFin.UseVisualStyleBackColor = True
        '
        'dgListeCommande
        '
        Me.dgListeCommande.BackgroundColor = System.Drawing.Color.SlateGray
        Me.dgListeCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListeCommande.Location = New System.Drawing.Point(533, 46)
        Me.dgListeCommande.Name = "dgListeCommande"
        Me.dgListeCommande.Size = New System.Drawing.Size(681, 336)
        Me.dgListeCommande.TabIndex = 42
        '
        'tbAdresse
        '
        Me.tbAdresse.Location = New System.Drawing.Point(197, 273)
        Me.tbAdresse.Name = "tbAdresse"
        Me.tbAdresse.Size = New System.Drawing.Size(192, 20)
        Me.tbAdresse.TabIndex = 39
        '
        'tbPrenom
        '
        Me.tbPrenom.Location = New System.Drawing.Point(197, 232)
        Me.tbPrenom.Name = "tbPrenom"
        Me.tbPrenom.Size = New System.Drawing.Size(192, 20)
        Me.tbPrenom.TabIndex = 38
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(197, 177)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(192, 20)
        Me.tbNom.TabIndex = 37
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(197, 130)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(192, 20)
        Me.tbID.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(75, 271)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Adresse :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(76, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 32
        Me.Label3.Text = "Prénom :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(76, 175)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "Nom :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(76, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "ID Commande :"
        '
        'ToolTip1
        '
        Me.ToolTip1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.IAPM_MANCINI.My.Resources.Resources.icon__1_
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.Font = New System.Drawing.Font("MV Boli", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(533, 346)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(34, 36)
        Me.Button3.TabIndex = 47
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Button2.BackgroundImage = Global.IAPM_MANCINI.My.Resources.Resources.testing__2_
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.Location = New System.Drawing.Point(1181, 350)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(33, 32)
        Me.Button2.TabIndex = 46
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmListeCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1257, 605)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgListeCommande)
        Me.Controls.Add(Me.tbAdresse)
        Me.Controls.Add(Me.tbPrenom)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmListeCommande"
        Me.RightToLeftLayout = True
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCommande"
        Me.la.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgListeCommande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As Button
    Friend WithEvents la As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnModif As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDebut As Button
    Friend WithEvents btnPrec As Button
    Friend WithEvents btnSuiv As Button
    Friend WithEvents btnFin As Button
    Friend WithEvents dgListeCommande As DataGridView
    Friend WithEvents tbAdresse As TextBox
    Friend WithEvents tbPrenom As TextBox
    Friend WithEvents tbNom As TextBox
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents ToolTip2 As ToolTip
    Friend WithEvents Button3 As Button
    Friend WithEvents ToolTip3 As ToolTip
End Class
