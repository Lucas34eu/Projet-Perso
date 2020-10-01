<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeClient
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbAdresse = New System.Windows.Forms.TextBox()
        Me.tbCodePostal = New System.Windows.Forms.TextBox()
        Me.tbVille = New System.Windows.Forms.TextBox()
        Me.btnDebut = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.btnSuiv = New System.Windows.Forms.Button()
        Me.btnPrec = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.dgListeClient = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.la = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider5 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbNom = New System.Windows.Forms.TextBox()
        Me.tbPrenom = New System.Windows.Forms.TextBox()
        CType(Me.dgListeClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.la.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(125, 196)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Adresse :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(125, 234)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Code Postal :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(125, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Ville :"
        '
        'tbAdresse
        '
        Me.tbAdresse.Location = New System.Drawing.Point(246, 198)
        Me.tbAdresse.Name = "tbAdresse"
        Me.tbAdresse.Size = New System.Drawing.Size(192, 20)
        Me.tbAdresse.TabIndex = 9
        '
        'tbCodePostal
        '
        Me.tbCodePostal.Location = New System.Drawing.Point(246, 236)
        Me.tbCodePostal.Name = "tbCodePostal"
        Me.tbCodePostal.Size = New System.Drawing.Size(192, 20)
        Me.tbCodePostal.TabIndex = 10
        '
        'tbVille
        '
        Me.tbVille.Location = New System.Drawing.Point(246, 276)
        Me.tbVille.Name = "tbVille"
        Me.tbVille.Size = New System.Drawing.Size(192, 20)
        Me.tbVille.TabIndex = 11
        '
        'btnDebut
        '
        Me.btnDebut.ForeColor = System.Drawing.Color.Black
        Me.btnDebut.Location = New System.Drawing.Point(20, 51)
        Me.btnDebut.Name = "btnDebut"
        Me.btnDebut.Size = New System.Drawing.Size(82, 77)
        Me.btnDebut.TabIndex = 12
        Me.btnDebut.Text = "<<"
        Me.btnDebut.UseVisualStyleBackColor = True
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
        'btnFin
        '
        Me.btnFin.ForeColor = System.Drawing.Color.Black
        Me.btnFin.Location = New System.Drawing.Point(269, 51)
        Me.btnFin.Name = "btnFin"
        Me.btnFin.Size = New System.Drawing.Size(81, 77)
        Me.btnFin.TabIndex = 15
        Me.btnFin.Text = ">>"
        Me.btnFin.UseVisualStyleBackColor = True
        '
        'btnSuiv
        '
        Me.btnSuiv.ForeColor = System.Drawing.Color.Black
        Me.btnSuiv.Location = New System.Drawing.Point(197, 72)
        Me.btnSuiv.Name = "btnSuiv"
        Me.btnSuiv.Size = New System.Drawing.Size(53, 51)
        Me.btnSuiv.TabIndex = 16
        Me.btnSuiv.Text = ">"
        Me.btnSuiv.UseVisualStyleBackColor = True
        '
        'btnPrec
        '
        Me.btnPrec.ForeColor = System.Drawing.Color.Black
        Me.btnPrec.Location = New System.Drawing.Point(108, 72)
        Me.btnPrec.Name = "btnPrec"
        Me.btnPrec.Size = New System.Drawing.Size(53, 51)
        Me.btnPrec.TabIndex = 17
        Me.btnPrec.Text = "<"
        Me.btnPrec.UseVisualStyleBackColor = True
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
        'dgListeClient
        '
        Me.dgListeClient.BackgroundColor = System.Drawing.Color.SlateGray
        Me.dgListeClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListeClient.Location = New System.Drawing.Point(538, 27)
        Me.dgListeClient.Name = "dgListeClient"
        Me.dgListeClient.Size = New System.Drawing.Size(681, 336)
        Me.dgListeClient.TabIndex = 19
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnDebut)
        Me.GroupBox1.Controls.Add(Me.btnPrec)
        Me.GroupBox1.Controls.Add(Me.btnSuiv)
        Me.GroupBox1.Controls.Add(Me.btnFin)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(68, 400)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 145)
        Me.GroupBox1.TabIndex = 20
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Naviguation dans la BDD"
        '
        'la
        '
        Me.la.Controls.Add(Me.btnAdd)
        Me.la.Controls.Add(Me.btnModif)
        Me.la.Controls.Add(Me.btnDel)
        Me.la.ForeColor = System.Drawing.Color.White
        Me.la.Location = New System.Drawing.Point(628, 400)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(582, 145)
        Me.la.TabIndex = 21
        Me.la.TabStop = False
        Me.la.Text = "Ajout / Suppression / Modification"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(490, 451)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 45)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
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
        'ErrorProvider5
        '
        Me.ErrorProvider5.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Location = New System.Drawing.Point(762, 336)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 58)
        Me.Panel1.TabIndex = 29
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
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(26, 15)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(122, 27)
        Me.Button2.TabIndex = 27
        Me.Button2.Text = "Telecharger le PDF"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(125, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Client :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(125, 112)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nom :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(125, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Prénom :"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(246, 79)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(192, 20)
        Me.tbID.TabIndex = 6
        '
        'tbNom
        '
        Me.tbNom.Location = New System.Drawing.Point(246, 114)
        Me.tbNom.Name = "tbNom"
        Me.tbNom.Size = New System.Drawing.Size(192, 20)
        Me.tbNom.TabIndex = 7
        '
        'tbPrenom
        '
        Me.tbPrenom.Location = New System.Drawing.Point(246, 151)
        Me.tbPrenom.Name = "tbPrenom"
        Me.tbPrenom.Size = New System.Drawing.Size(192, 20)
        Me.tbPrenom.TabIndex = 8
        '
        'frmListeClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1257, 605)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgListeClient)
        Me.Controls.Add(Me.tbVille)
        Me.Controls.Add(Me.tbCodePostal)
        Me.Controls.Add(Me.tbAdresse)
        Me.Controls.Add(Me.tbPrenom)
        Me.Controls.Add(Me.tbNom)
        Me.Controls.Add(Me.tbID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmListeClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgListeClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.la.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbAdresse As TextBox
    Friend WithEvents tbCodePostal As TextBox
    Friend WithEvents tbVille As TextBox
    Friend WithEvents btnDebut As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnFin As Button
    Friend WithEvents btnSuiv As Button
    Friend WithEvents btnPrec As Button
    Friend WithEvents btnModif As Button
    Friend WithEvents dgListeClient As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents la As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
    Friend WithEvents ErrorProvider5 As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents tbPrenom As TextBox
    Friend WithEvents tbNom As TextBox
    Friend WithEvents tbID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
End Class
