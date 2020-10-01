<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRechercheClient
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
        Me.BTNFermer = New System.Windows.Forms.Button()
        Me.dsds = New System.Windows.Forms.Label()
        Me.DataGridrech = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBoxVille = New System.Windows.Forms.ComboBox()
        Me.ComboBoxCDP = New System.Windows.Forms.ComboBox()
        Me.ComboBoxRue = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbPatronime = New System.Windows.Forms.ComboBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridrech, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTNFermer
        '
        Me.BTNFermer.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTNFermer.Location = New System.Drawing.Point(486, 502)
        Me.BTNFermer.Name = "BTNFermer"
        Me.BTNFermer.Size = New System.Drawing.Size(217, 65)
        Me.BTNFermer.TabIndex = 17
        Me.BTNFermer.Text = "Fermer"
        Me.BTNFermer.UseVisualStyleBackColor = True
        '
        'dsds
        '
        Me.dsds.AutoSize = True
        Me.dsds.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dsds.Location = New System.Drawing.Point(246, -24)
        Me.dsds.Name = "dsds"
        Me.dsds.Size = New System.Drawing.Size(160, 13)
        Me.dsds.TabIndex = 16
        Me.dsds.Text = "Resultat de la Recherche :"
        '
        'DataGridrech
        '
        Me.DataGridrech.BackgroundColor = System.Drawing.Color.SlateGray
        Me.DataGridrech.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridrech.Location = New System.Drawing.Point(58, 162)
        Me.DataGridrech.Name = "DataGridrech"
        Me.DataGridrech.Size = New System.Drawing.Size(1067, 334)
        Me.DataGridrech.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(55, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(117, 15)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Resultat de la Recherche :"
        '
        'ComboBoxVille
        '
        Me.ComboBoxVille.FormattingEnabled = True
        Me.ComboBoxVille.Location = New System.Drawing.Point(934, 73)
        Me.ComboBoxVille.Name = "ComboBoxVille"
        Me.ComboBoxVille.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxVille.TabIndex = 20
        '
        'ComboBoxCDP
        '
        Me.ComboBoxCDP.FormattingEnabled = True
        Me.ComboBoxCDP.Location = New System.Drawing.Point(752, 73)
        Me.ComboBoxCDP.Name = "ComboBoxCDP"
        Me.ComboBoxCDP.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxCDP.TabIndex = 21
        '
        'ComboBoxRue
        '
        Me.ComboBoxRue.FormattingEnabled = True
        Me.ComboBoxRue.Location = New System.Drawing.Point(565, 73)
        Me.ComboBoxRue.Name = "ComboBoxRue"
        Me.ComboBoxRue.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxRue.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(562, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 20)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Par Rue :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(749, 51)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(119, 20)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Par Code Postal  :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(931, 51)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 20)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Par Ville  :"
        '
        'cbPatronime
        '
        Me.cbPatronime.FormattingEnabled = True
        Me.cbPatronime.Location = New System.Drawing.Point(76, 73)
        Me.cbPatronime.Name = "cbPatronime"
        Me.cbPatronime.Size = New System.Drawing.Size(318, 21)
        Me.cbPatronime.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(72, 51)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(101, 20)
        Me.Label8.TabIndex = 28
        Me.Label8.Text = "Par Patronime :"
        '
        'frmRechercheClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1257, 605)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbPatronime)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.ComboBoxRue)
        Me.Controls.Add(Me.ComboBoxCDP)
        Me.Controls.Add(Me.ComboBoxVille)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.BTNFermer)
        Me.Controls.Add(Me.dsds)
        Me.Controls.Add(Me.DataGridrech)
        Me.Name = "frmRechercheClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmRechercheClient"
        CType(Me.DataGridrech, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BTNFermer As Button
    Friend WithEvents dsds As Label
    Friend WithEvents DataGridrech As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBoxVille As ComboBox
    Friend WithEvents ComboBoxCDP As ComboBox
    Friend WithEvents ComboBoxRue As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbPatronime As ComboBox
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label8 As Label
End Class
