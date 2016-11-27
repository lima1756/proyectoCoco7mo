<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbxUsuario = New System.Windows.Forms.TextBox()
        Me.tbxContraseña = New System.Windows.Forms.TextBox()
        Me.btnIniciar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(35, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'tbxUsuario
        '
        Me.tbxUsuario.Location = New System.Drawing.Point(38, 45)
        Me.tbxUsuario.Name = "tbxUsuario"
        Me.tbxUsuario.Size = New System.Drawing.Size(135, 20)
        Me.tbxUsuario.TabIndex = 2
        '
        'tbxContraseña
        '
        Me.tbxContraseña.Location = New System.Drawing.Point(38, 86)
        Me.tbxContraseña.Name = "tbxContraseña"
        Me.tbxContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(87)
        Me.tbxContraseña.Size = New System.Drawing.Size(135, 20)
        Me.tbxContraseña.TabIndex = 3
        '
        'btnIniciar
        '
        Me.btnIniciar.Location = New System.Drawing.Point(65, 112)
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Size = New System.Drawing.Size(75, 23)
        Me.btnIniciar.TabIndex = 4
        Me.btnIniciar.Text = "Iniciar"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(216, 155)
        Me.Controls.Add(Me.btnIniciar)
        Me.Controls.Add(Me.tbxContraseña)
        Me.Controls.Add(Me.tbxUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents tbxUsuario As TextBox
    Friend WithEvents tbxContraseña As TextBox
    Friend WithEvents btnIniciar As Button
End Class
