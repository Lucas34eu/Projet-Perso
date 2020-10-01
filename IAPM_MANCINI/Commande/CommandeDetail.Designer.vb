<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CommandeDetail
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
        Me.dgListeCommande = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.dgListeCommande, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgListeCommande
        '
        Me.dgListeCommande.BackgroundColor = System.Drawing.Color.SlateGray
        Me.dgListeCommande.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgListeCommande.Location = New System.Drawing.Point(257, 68)
        Me.dgListeCommande.Name = "dgListeCommande"
        Me.dgListeCommande.Size = New System.Drawing.Size(768, 256)
        Me.dgListeCommande.TabIndex = 43
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(317, 513)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(224, 47)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "Quitter"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(564, 363)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.Size = New System.Drawing.Size(254, 20)
        Me.tbTotal.TabIndex = 49
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(363, 361)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "Total de la commande :"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(649, 513)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(250, 46)
        Me.Button2.TabIndex = 51
        Me.Button2.Text = "Imprimer PDF"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CommandeDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1257, 605)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbTotal)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgListeCommande)
        Me.Name = "CommandeDetail"
        Me.Text = "CommandeDetail"
        CType(Me.dgListeCommande, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgListeCommande As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
End Class
