<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recherche_Commande
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
        Me.DataGridRecherche = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbID = New System.Windows.Forms.ComboBox()
        Me.CBClient = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridRecherche, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridRecherche
        '
        Me.DataGridRecherche.BackgroundColor = System.Drawing.Color.SlateGray
        Me.DataGridRecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridRecherche.Location = New System.Drawing.Point(71, 186)
        Me.DataGridRecherche.Name = "DataGridRecherche"
        Me.DataGridRecherche.Size = New System.Drawing.Size(1139, 339)
        Me.DataGridRecherche.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Underline)
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(71, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "par ID :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Underline)
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(723, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "par Client :"
        '
        'cbID
        '
        Me.cbID.FormattingEnabled = True
        Me.cbID.Location = New System.Drawing.Point(153, 53)
        Me.cbID.Name = "cbID"
        Me.cbID.Size = New System.Drawing.Size(51, 21)
        Me.cbID.TabIndex = 3
        '
        'CBClient
        '
        Me.CBClient.FormattingEnabled = True
        Me.CBClient.Location = New System.Drawing.Point(802, 68)
        Me.CBClient.Name = "CBClient"
        Me.CBClient.Size = New System.Drawing.Size(379, 21)
        Me.CBClient.TabIndex = 4
        '
        'Recherche_Commande
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(120, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1257, 605)
        Me.Controls.Add(Me.CBClient)
        Me.Controls.Add(Me.cbID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridRecherche)
        Me.Name = "Recherche_Commande"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recherche_Commande"
        CType(Me.DataGridRecherche, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridRecherche As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cbID As ComboBox
    Friend WithEvents CBClient As ComboBox
End Class
