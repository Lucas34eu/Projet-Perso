<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeProduit
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
        Me.components = New System.ComponentModel.Container()
        Me.tbIDProduit = New System.Windows.Forms.TextBox()
        Me.tbQte = New System.Windows.Forms.TextBox()
        Me.tbPrix = New System.Windows.Forms.TextBox()
        Me.tbProduitNom = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dgListeProduit = New System.Windows.Forms.DataGridView()
        Me.la = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDebut = New System.Windows.Forms.Button()
        Me.btnPrec = New System.Windows.Forms.Button()
        Me.btnSuiv = New System.Windows.Forms.Button()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.ComboBoxIDFournisseur = New System.Windows.Forms.ComboBox()
        Me.ComboBoxIDCategorie = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        CType(Me.dgListeProduit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.la.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbIDProduit
        '
        Me.tbIDProduit.Location = New System.Drawing.Point(255, 63)
        Me.tbIDProduit.Name = "tbIDProduit"
        Me.tbIDProduit.Size = New System.Drawing.Size(194, 20)
        Me.tbIDProduit.TabIndex = 0
        '
        'tbQte
        '
        Me.tbQte.Location = New System.Drawing.Point(255, 184)
        Me.tbQte.Name = "tbQte"
        Me.tbQte.Size = New System.Drawing.Size(194, 20)
        Me.tbQte.TabIndex = 3
        '
        'tbPrix
        '
        Me.tbPrix.Location = New System.Drawing.Point(255, 146)
        Me.tbPrix.Name = "tbPrix"
        Me.tbPrix.Size = New System.Drawing.Size(194, 20)
        Me.tbPrix.TabIndex = 4
        '
        'tbProduitNom
        '
        Me.tbProduitNom.Location = New System.Drawing.Point(255, 103)
        Me.tbProduitNom.Name = "tbProduitNom"
        Me.tbProduitNom.Size = New System.Drawing.Size(194, 20)
        Me.tbProduitNom.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(83, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Produit N°:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(83, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(129, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Libelle du Produit :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(83, 150)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 20)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Prix HT :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(83, 184)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 20)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Quantite Restante :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(83, 222)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(145, 20)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nom du Fournisseur :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(83, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Nom de la Categorie :"
        '
        'dgListeProduit
        '
        Me.dgListeProduit.BackgroundColor = System.Drawing.Color.SlateGray
        Me.dgListeProduit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListeProduit.Location = New System.Drawing.Point(524, 12)
        Me.dgListeProduit.Name = "dgListeProduit"
        Me.dgListeProduit.Size = New System.Drawing.Size(717, 320)
        Me.dgListeProduit.TabIndex = 12
        '
        'la
        '
        Me.la.BackColor = System.Drawing.Color.Transparent
        Me.la.Controls.Add(Me.btnAdd)
        Me.la.Controls.Add(Me.btnModif)
        Me.la.Controls.Add(Me.btnDel)
        Me.la.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.la.ForeColor = System.Drawing.Color.White
        Me.la.Location = New System.Drawing.Point(639, 374)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(582, 145)
        Me.la.TabIndex = 22
        Me.la.TabStop = False
        Me.la.Text = "Ajout / Suppression / Modification"
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.Color.White
        Me.btnAdd.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.ForeColor = System.Drawing.Color.Black
        Me.btnAdd.Location = New System.Drawing.Point(11, 41)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(170, 55)
        Me.btnAdd.TabIndex = 14
        Me.btnAdd.Text = "Ajouter"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnModif
        '
        Me.btnModif.BackColor = System.Drawing.Color.White
        Me.btnModif.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModif.ForeColor = System.Drawing.Color.Black
        Me.btnModif.Location = New System.Drawing.Point(363, 41)
        Me.btnModif.Name = "btnModif"
        Me.btnModif.Size = New System.Drawing.Size(170, 55)
        Me.btnModif.TabIndex = 18
        Me.btnModif.Text = "Modifier"
        Me.btnModif.UseVisualStyleBackColor = False
        '
        'btnDel
        '
        Me.btnDel.BackColor = System.Drawing.Color.White
        Me.btnDel.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDel.ForeColor = System.Drawing.Color.Black
        Me.btnDel.Location = New System.Drawing.Point(187, 41)
        Me.btnDel.Name = "btnDel"
        Me.btnDel.Size = New System.Drawing.Size(170, 55)
        Me.btnDel.TabIndex = 13
        Me.btnDel.Text = "Supprimer"
        Me.btnDel.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.btnDebut)
        Me.GroupBox1.Controls.Add(Me.btnPrec)
        Me.GroupBox1.Controls.Add(Me.btnSuiv)
        Me.GroupBox1.Controls.Add(Me.btnFin)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(47, 374)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 145)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Naviguation dans la BDD"
        '
        'btnDebut
        '
        Me.btnDebut.BackColor = System.Drawing.Color.White
        Me.btnDebut.ForeColor = System.Drawing.Color.Black
        Me.btnDebut.Location = New System.Drawing.Point(6, 46)
        Me.btnDebut.Name = "btnDebut"
        Me.btnDebut.Size = New System.Drawing.Size(82, 77)
        Me.btnDebut.TabIndex = 12
        Me.btnDebut.Text = "<<"
        Me.btnDebut.UseVisualStyleBackColor = False
        '
        'btnPrec
        '
        Me.btnPrec.BackColor = System.Drawing.Color.White
        Me.btnPrec.ForeColor = System.Drawing.Color.Black
        Me.btnPrec.Location = New System.Drawing.Point(129, 59)
        Me.btnPrec.Name = "btnPrec"
        Me.btnPrec.Size = New System.Drawing.Size(46, 51)
        Me.btnPrec.TabIndex = 17
        Me.btnPrec.Text = "<"
        Me.btnPrec.UseVisualStyleBackColor = False
        '
        'btnSuiv
        '
        Me.btnSuiv.BackColor = System.Drawing.Color.White
        Me.btnSuiv.ForeColor = System.Drawing.Color.Black
        Me.btnSuiv.Location = New System.Drawing.Point(197, 59)
        Me.btnSuiv.Name = "btnSuiv"
        Me.btnSuiv.Size = New System.Drawing.Size(46, 51)
        Me.btnSuiv.TabIndex = 16
        Me.btnSuiv.Text = ">"
        Me.btnSuiv.UseVisualStyleBackColor = False
        '
        'btnFin
        '
        Me.btnFin.BackColor = System.Drawing.Color.White
        Me.btnFin.ForeColor = System.Drawing.Color.Black
        Me.btnFin.Location = New System.Drawing.Point(272, 46)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(81, 77)
        Me.btnFin.TabIndex = 15
        Me.btnFin.Text = ">>"
        Me.btnFin.UseVisualStyleBackColor = False
        '
        'ComboBoxIDFournisseur
        '
        Me.ComboBoxIDFournisseur.FormattingEnabled = True
        Me.ComboBoxIDFournisseur.Location = New System.Drawing.Point(255, 221)
        Me.ComboBoxIDFournisseur.Name = "ComboBoxIDFournisseur"
        Me.ComboBoxIDFournisseur.Size = New System.Drawing.Size(194, 21)
        Me.ComboBoxIDFournisseur.TabIndex = 24
        '
        'ComboBoxIDCategorie
        '
        Me.ComboBoxIDCategorie.FormattingEnabled = True
        Me.ComboBoxIDCategorie.Location = New System.Drawing.Point(255, 263)
        Me.ComboBoxIDCategorie.Name = "ComboBoxIDCategorie"
        Me.ComboBoxIDCategorie.Size = New System.Drawing.Size(194, 21)
        Me.ComboBoxIDCategorie.TabIndex = 25
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(500, 420)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 54)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(26, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 27)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Telecharger le PDF"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'ErrorProvider3
        '
        Me.ErrorProvider3.ContainerControl = Me
        '
        'ErrorProvider4
        '
        Me.ErrorProvider4.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(755, 303)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 58)
        Me.Panel1.TabIndex = 28
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(174, 17)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 28
        Me.Button3.Text = "Masquer"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmListeProduit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1253, 601)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ComboBoxIDCategorie)
        Me.Controls.Add(Me.ComboBoxIDFournisseur)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.dgListeProduit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbProduitNom)
        Me.Controls.Add(Me.tbPrix)
        Me.Controls.Add(Me.tbQte)
        Me.Controls.Add(Me.tbIDProduit)
        Me.ForeColor = System.Drawing.Color.Black
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Name = "frmListeProduit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = ">"
        CType(Me.dgListeProduit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.la.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbIDProduit As TextBox
    Friend WithEvents tbQte As TextBox
    Friend WithEvents tbPrix As TextBox
    Friend WithEvents tbProduitNom As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dgListeProduit As DataGridView
    Friend WithEvents la As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnModif As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDebut As Button
    Friend WithEvents btnPrec As Button
    Friend WithEvents btnSuiv As Button
    Friend WithEvents btnFin As Button
    Friend WithEvents ComboBoxIDFournisseur As ComboBox
    Friend WithEvents ComboBoxIDCategorie As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
End Class
