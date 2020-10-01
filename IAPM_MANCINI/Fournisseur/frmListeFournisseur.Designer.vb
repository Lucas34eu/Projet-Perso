<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListeFournisseur
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
        Me.dgListeFourn = New System.Windows.Forms.DataGridView()
        Me.tbIDFourn = New System.Windows.Forms.TextBox()
        Me.tbNomFourn = New System.Windows.Forms.TextBox()
        Me.tbVilleFourn = New System.Windows.Forms.TextBox()
        Me.tbCDPFourn = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.la = New System.Windows.Forms.GroupBox()
        Me.BTN_Ajouter = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDebut = New System.Windows.Forms.Button()
        Me.btnPrec = New System.Windows.Forms.Button()
        Me.btnSuiv = New System.Windows.Forms.Button()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnHIDE = New System.Windows.Forms.Button()
        Me.btnDL_PDF = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider3 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider4 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.dgListeFourn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.la.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgListeFourn
        '
        Me.dgListeFourn.BackgroundColor = System.Drawing.Color.SlateGray
        Me.dgListeFourn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListeFourn.Location = New System.Drawing.Point(556, 31)
        Me.dgListeFourn.Name = "dgListeFourn"
        Me.dgListeFourn.Size = New System.Drawing.Size(594, 257)
        Me.dgListeFourn.TabIndex = 0
        '
        'tbIDFourn
        '
        Me.tbIDFourn.Location = New System.Drawing.Point(266, 53)
        Me.tbIDFourn.Name = "tbIDFourn"
        Me.tbIDFourn.Size = New System.Drawing.Size(181, 20)
        Me.tbIDFourn.TabIndex = 1
        '
        'tbNomFourn
        '
        Me.tbNomFourn.Location = New System.Drawing.Point(266, 124)
        Me.tbNomFourn.Name = "tbNomFourn"
        Me.tbNomFourn.Size = New System.Drawing.Size(181, 20)
        Me.tbNomFourn.TabIndex = 2
        '
        'tbVilleFourn
        '
        Me.tbVilleFourn.Location = New System.Drawing.Point(266, 204)
        Me.tbVilleFourn.Name = "tbVilleFourn"
        Me.tbVilleFourn.Size = New System.Drawing.Size(181, 20)
        Me.tbVilleFourn.TabIndex = 3
        '
        'tbCDPFourn
        '
        Me.tbCDPFourn.Location = New System.Drawing.Point(266, 268)
        Me.tbCDPFourn.Name = "tbCDPFourn"
        Me.tbCDPFourn.Size = New System.Drawing.Size(181, 20)
        Me.tbCDPFourn.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(96, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(109, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "ID Fournisseur :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(96, 131)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Nom Fournisseur :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(96, 204)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(124, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Ville Fournisseur :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(96, 275)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 20)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Code Postal :"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Button1.Location = New System.Drawing.Point(484, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 45)
        Me.Button1.TabIndex = 25
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'la
        '
        Me.la.Controls.Add(Me.BTN_Ajouter)
        Me.la.Controls.Add(Me.btnModif)
        Me.la.Controls.Add(Me.btnDel)
        Me.la.ForeColor = System.Drawing.Color.White
        Me.la.Location = New System.Drawing.Point(629, 414)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(582, 145)
        Me.la.TabIndex = 24
        Me.la.TabStop = False
        Me.la.Text = "Ajout / Suppression / Modification"
        '
        'BTN_Ajouter
        '
        Me.BTN_Ajouter.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.BTN_Ajouter.ForeColor = System.Drawing.Color.Black
        Me.BTN_Ajouter.Location = New System.Drawing.Point(11, 41)
        Me.BTN_Ajouter.Name = "BTN_Ajouter"
        Me.BTN_Ajouter.Size = New System.Drawing.Size(170, 55)
        Me.BTN_Ajouter.TabIndex = 14
        Me.BTN_Ajouter.Text = "Ajouter"
        Me.BTN_Ajouter.UseVisualStyleBackColor = True
        '
        'btnModif
        '
        Me.btnModif.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btnModif.ForeColor = System.Drawing.Color.Black
        Me.btnModif.Location = New System.Drawing.Point(363, 41)
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
        Me.btnDel.Location = New System.Drawing.Point(187, 41)
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
        Me.GroupBox1.Location = New System.Drawing.Point(39, 414)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 145)
        Me.GroupBox1.TabIndex = 23
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
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnHIDE)
        Me.Panel1.Controls.Add(Me.btnDL_PDF)
        Me.Panel1.Location = New System.Drawing.Point(714, 268)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(272, 58)
        Me.Panel1.TabIndex = 29
        '
        'btnHIDE
        '
        Me.btnHIDE.Location = New System.Drawing.Point(174, 17)
        Me.btnHIDE.Name = "btnHIDE"
        Me.btnHIDE.Size = New System.Drawing.Size(75, 23)
        Me.btnHIDE.TabIndex = 28
        Me.btnHIDE.Text = "Masquer"
        Me.btnHIDE.UseVisualStyleBackColor = True
        '
        'btnDL_PDF
        '
        Me.btnDL_PDF.Location = New System.Drawing.Point(26, 15)
        Me.btnDL_PDF.Name = "btnDL_PDF"
        Me.btnDL_PDF.Size = New System.Drawing.Size(122, 27)
        Me.btnDL_PDF.TabIndex = 27
        Me.btnDL_PDF.Text = "Telecharger le PDF"
        Me.btnDL_PDF.UseVisualStyleBackColor = True
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
        'frmListeFournisseur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1257, 605)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbCDPFourn)
        Me.Controls.Add(Me.tbVilleFourn)
        Me.Controls.Add(Me.tbNomFourn)
        Me.Controls.Add(Me.tbIDFourn)
        Me.Controls.Add(Me.dgListeFourn)
        Me.Name = "frmListeFournisseur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmListeFournisseur"
        CType(Me.dgListeFourn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.la.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgListeFourn As DataGridView
    Friend WithEvents tbIDFourn As TextBox
    Friend WithEvents tbNomFourn As TextBox
    Friend WithEvents tbVilleFourn As TextBox
    Friend WithEvents tbCDPFourn As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents la As GroupBox
    Friend WithEvents BTN_Ajouter As Button
    Friend WithEvents btnModif As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDebut As Button
    Friend WithEvents btnPrec As Button
    Friend WithEvents btnSuiv As Button
    Friend WithEvents btnFin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnHIDE As Button
    Friend WithEvents btnDL_PDF As Button
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents ErrorProvider3 As ErrorProvider
    Friend WithEvents ErrorProvider4 As ErrorProvider
End Class
