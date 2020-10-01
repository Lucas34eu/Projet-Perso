<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCategorie
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnDebut = New System.Windows.Forms.Button()
        Me.btnPrec = New System.Windows.Forms.Button()
        Me.btnSuiv = New System.Windows.Forms.Button()
        Me.btnFin = New System.Windows.Forms.Button()
        Me.la = New System.Windows.Forms.GroupBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnModif = New System.Windows.Forms.Button()
        Me.btnDel = New System.Windows.Forms.Button()
        Me.dgListeCat = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbID = New System.Windows.Forms.TextBox()
        Me.tbLibCat = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.la.SuspendLayout()
        CType(Me.dgListeCat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold)
        Me.Button1.Location = New System.Drawing.Point(477, 457)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 54)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Fermer"
        Me.Button1.UseVisualStyleBackColor = True
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
        Me.GroupBox1.Location = New System.Drawing.Point(31, 411)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 145)
        Me.GroupBox1.TabIndex = 41
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
        'la
        '
        Me.la.BackColor = System.Drawing.Color.Transparent
        Me.la.Controls.Add(Me.btnAdd)
        Me.la.Controls.Add(Me.btnModif)
        Me.la.Controls.Add(Me.btnDel)
        Me.la.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.la.ForeColor = System.Drawing.Color.White
        Me.la.Location = New System.Drawing.Point(623, 411)
        Me.la.Name = "la"
        Me.la.Size = New System.Drawing.Size(582, 145)
        Me.la.TabIndex = 40
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
        'dgListeCat
        '
        Me.dgListeCat.BackgroundColor = System.Drawing.Color.SlateGray
        Me.dgListeCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListeCat.Location = New System.Drawing.Point(508, 49)
        Me.dgListeCat.Name = "dgListeCat"
        Me.dgListeCat.Size = New System.Drawing.Size(717, 320)
        Me.dgListeCat.TabIndex = 39
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(43, 221)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 20)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Nom de la Categorie :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(54, 163)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 20)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "ID Catégorie:"
        '
        'tbID
        '
        Me.tbID.Location = New System.Drawing.Point(210, 163)
        Me.tbID.Name = "tbID"
        Me.tbID.Size = New System.Drawing.Size(248, 20)
        Me.tbID.TabIndex = 29
        '
        'tbLibCat
        '
        Me.tbLibCat.Location = New System.Drawing.Point(210, 223)
        Me.tbLibCat.Name = "tbLibCat"
        Me.tbLibCat.Size = New System.Drawing.Size(248, 20)
        Me.tbLibCat.TabIndex = 45
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'frmCategorie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1257, 605)
        Me.Controls.Add(Me.tbLibCat)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.la)
        Me.Controls.Add(Me.dgListeCat)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbID)
        Me.Name = "frmCategorie"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmCategorie"
        Me.GroupBox1.ResumeLayout(False)
        Me.la.ResumeLayout(False)
        CType(Me.dgListeCat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnDebut As Button
    Friend WithEvents btnPrec As Button
    Friend WithEvents btnSuiv As Button
    Friend WithEvents btnFin As Button
    Friend WithEvents la As GroupBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnModif As Button
    Friend WithEvents btnDel As Button
    Friend WithEvents dgListeCat As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbID As TextBox
    Friend WithEvents tbLibCat As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
End Class
