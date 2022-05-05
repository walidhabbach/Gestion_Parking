<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CarParking
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
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button6
        '
        Me.Button6.Image = Global.Parking.My.Resources.Resources.OIP_removebg_preview
        Me.Button6.Location = New System.Drawing.Point(205, 30)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(127, 124)
        Me.Button6.TabIndex = 10
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(302, 190)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(185, 56)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Ajouter"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(62, 288)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(185, 56)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Modifier"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(302, 288)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(185, 56)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Supprimer"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(62, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(185, 56)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Afficher "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CarParking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 427)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "CarParking"
        Me.Text = "CarParking"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button6 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
