<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class controlDeAcceso
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cbxZona = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFolio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnRevisar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbxZona
        '
        Me.cbxZona.FormattingEnabled = True
        Me.cbxZona.Location = New System.Drawing.Point(12, 46)
        Me.cbxZona.Name = "cbxZona"
        Me.cbxZona.Size = New System.Drawing.Size(121, 21)
        Me.cbxZona.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Seleccione su zona:"
        '
        'txtFolio
        '
        Me.txtFolio.Location = New System.Drawing.Point(12, 161)
        Me.txtFolio.Name = "txtFolio"
        Me.txtFolio.Size = New System.Drawing.Size(121, 20)
        Me.txtFolio.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(32, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Folio:"
        '
        'btnRevisar
        '
        Me.btnRevisar.Location = New System.Drawing.Point(178, 226)
        Me.btnRevisar.Name = "btnRevisar"
        Me.btnRevisar.Size = New System.Drawing.Size(75, 23)
        Me.btnRevisar.TabIndex = 4
        Me.btnRevisar.Text = "Revisar"
        Me.btnRevisar.UseVisualStyleBackColor = True
        '
        'controlDeAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.btnRevisar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtFolio)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cbxZona)
        Me.Name = "controlDeAcceso"
        Me.Text = "controlDeAcceso"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbxZona As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtFolio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btnRevisar As Button
End Class
