<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAjoutCommande
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tb_ID_Commande = New System.Windows.Forms.TextBox()
        Me.tb_date_commande = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_Creer_Commande = New System.Windows.Forms.Button()
        Me.cb_id_client = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_Add_Produit = New System.Windows.Forms.Button()
        Me.cb_produit_commande = New System.Windows.Forms.ComboBox()
        Me.tb_quantite_commande = New System.Windows.Forms.TextBox()
        Me.tb_afficher_id = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.btn_quitter = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ErrorProvider2 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dg_commande_en_cours = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_commande_en_cours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(57, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Commande :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(57, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Date :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(57, 131)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID Client :"
        '
        'tb_ID_Commande
        '
        Me.tb_ID_Commande.Location = New System.Drawing.Point(197, 56)
        Me.tb_ID_Commande.Name = "tb_ID_Commande"
        Me.tb_ID_Commande.Size = New System.Drawing.Size(218, 20)
        Me.tb_ID_Commande.TabIndex = 3
        '
        'tb_date_commande
        '
        Me.tb_date_commande.Location = New System.Drawing.Point(197, 92)
        Me.tb_date_commande.Name = "tb_date_commande"
        Me.tb_date_commande.Size = New System.Drawing.Size(218, 20)
        Me.tb_date_commande.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_Creer_Commande)
        Me.GroupBox1.Controls.Add(Me.cb_id_client)
        Me.GroupBox1.Controls.Add(Me.tb_ID_Commande)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.tb_date_commande)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(40, 315)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(476, 278)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Creation de la commande"
        '
        'btn_Creer_Commande
        '
        Me.btn_Creer_Commande.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btn_Creer_Commande.ForeColor = System.Drawing.Color.Black
        Me.btn_Creer_Commande.Location = New System.Drawing.Point(147, 191)
        Me.btn_Creer_Commande.Name = "btn_Creer_Commande"
        Me.btn_Creer_Commande.Size = New System.Drawing.Size(150, 41)
        Me.btn_Creer_Commande.TabIndex = 6
        Me.btn_Creer_Commande.Text = "Creer Commande "
        Me.btn_Creer_Commande.UseVisualStyleBackColor = True
        '
        'cb_id_client
        '
        Me.cb_id_client.FormattingEnabled = True
        Me.cb_id_client.Location = New System.Drawing.Point(197, 131)
        Me.cb_id_client.Name = "cb_id_client"
        Me.cb_id_client.Size = New System.Drawing.Size(218, 21)
        Me.cb_id_client.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(94, 35)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "ID Commande :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(94, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 20)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Libelle Produit :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(94, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(69, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Quantité :"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.btn_Add_Produit)
        Me.GroupBox2.Controls.Add(Me.cb_produit_commande)
        Me.GroupBox2.Controls.Add(Me.tb_quantite_commande)
        Me.GroupBox2.Controls.Add(Me.tb_afficher_id)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(699, 315)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(522, 279)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        '
        'btn_Add_Produit
        '
        Me.btn_Add_Produit.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btn_Add_Produit.ForeColor = System.Drawing.Color.Black
        Me.btn_Add_Produit.Location = New System.Drawing.Point(188, 191)
        Me.btn_Add_Produit.Name = "btn_Add_Produit"
        Me.btn_Add_Produit.Size = New System.Drawing.Size(193, 52)
        Me.btn_Add_Produit.TabIndex = 13
        Me.btn_Add_Produit.Text = "Ajouter Produit dans la commande"
        Me.btn_Add_Produit.UseVisualStyleBackColor = True
        '
        'cb_produit_commande
        '
        Me.cb_produit_commande.FormattingEnabled = True
        Me.cb_produit_commande.Location = New System.Drawing.Point(214, 95)
        Me.cb_produit_commande.Name = "cb_produit_commande"
        Me.cb_produit_commande.Size = New System.Drawing.Size(264, 21)
        Me.cb_produit_commande.TabIndex = 12
        '
        'tb_quantite_commande
        '
        Me.tb_quantite_commande.Location = New System.Drawing.Point(214, 148)
        Me.tb_quantite_commande.Name = "tb_quantite_commande"
        Me.tb_quantite_commande.Size = New System.Drawing.Size(264, 20)
        Me.tb_quantite_commande.TabIndex = 11
        '
        'tb_afficher_id
        '
        Me.tb_afficher_id.Location = New System.Drawing.Point(214, 37)
        Me.tb_afficher_id.Name = "tb_afficher_id"
        Me.tb_afficher_id.Size = New System.Drawing.Size(264, 20)
        Me.tb_afficher_id.TabIndex = 9
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(364, 267)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 20)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Total de la commande "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(573, 267)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 20)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(628, 267)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(0, 20)
        Me.Label10.TabIndex = 13
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.White
        Me.Label11.Location = New System.Drawing.Point(539, 267)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(0, 20)
        Me.Label11.TabIndex = 14
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(754, 267)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(18, 20)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "€"
        '
        'btn_quitter
        '
        Me.btn_quitter.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.btn_quitter.ForeColor = System.Drawing.Color.Black
        Me.btn_quitter.Location = New System.Drawing.Point(568, 499)
        Me.btn_quitter.Name = "btn_quitter"
        Me.btn_quitter.Size = New System.Drawing.Size(81, 55)
        Me.btn_quitter.TabIndex = 16
        Me.btn_quitter.Text = "Quitter"
        Me.btn_quitter.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(37, 29)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(198, 13)
        Me.Label13.TabIndex = 17
        Me.Label13.Text = "Récapitulatif de la Commande en cours :"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'ErrorProvider2
        '
        Me.ErrorProvider2.ContainerControl = Me
        '
        'dg_commande_en_cours
        '
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.White
        Me.dg_commande_en_cours.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_commande_en_cours.BackgroundColor = System.Drawing.Color.SlateGray
        Me.dg_commande_en_cours.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_commande_en_cours.Location = New System.Drawing.Point(40, 58)
        Me.dg_commande_en_cours.Name = "dg_commande_en_cours"
        Me.dg_commande_en_cours.Size = New System.Drawing.Size(1179, 206)
        Me.dg_commande_en_cours.TabIndex = 18
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(534, 350)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(159, 77)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Ajouter un produit dans une commande existante"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmAjoutCommande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1257, 605)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dg_commande_en_cours)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.btn_quitter)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "frmAjoutCommande"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAjoutCommande"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorProvider2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_commande_en_cours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tb_ID_Commande As TextBox
    Friend WithEvents tb_date_commande As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents tb_quantite_commande As TextBox
    Friend WithEvents tb_afficher_id As TextBox
    Friend WithEvents cb_id_client As ComboBox
    Friend WithEvents cb_produit_commande As ComboBox
    Friend WithEvents btn_Creer_Commande As Button
    Friend WithEvents btn_Add_Produit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents btn_quitter As Button
    Friend WithEvents Label13 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents ErrorProvider2 As ErrorProvider
    Friend WithEvents dg_commande_en_cours As DataGridView
    Friend WithEvents Button1 As Button
End Class
