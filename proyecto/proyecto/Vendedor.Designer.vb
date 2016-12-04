<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vendedor
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.CbxNumero = New System.Windows.Forms.ComboBox()
        Me.CbxFila = New System.Windows.Forms.ComboBox()
        Me.CbxZona = New System.Windows.Forms.ComboBox()
        Me.ComprarBoleto = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBoxConcierto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TbxFolioRegresar = New System.Windows.Forms.TextBox()
        Me.BtnRegresar = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(272, 245)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Turquoise
        Me.TabPage1.Controls.Add(Me.CbxNumero)
        Me.TabPage1.Controls.Add(Me.CbxFila)
        Me.TabPage1.Controls.Add(Me.CbxZona)
        Me.TabPage1.Controls.Add(Me.ComprarBoleto)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.ComboBoxConcierto)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(264, 219)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Venta"
        '
        'CbxNumero
        '
        Me.CbxNumero.FormattingEnabled = True
        Me.CbxNumero.Location = New System.Drawing.Point(84, 119)
        Me.CbxNumero.Name = "CbxNumero"
        Me.CbxNumero.Size = New System.Drawing.Size(54, 21)
        Me.CbxNumero.TabIndex = 14
        '
        'CbxFila
        '
        Me.CbxFila.FormattingEnabled = True
        Me.CbxFila.Location = New System.Drawing.Point(17, 118)
        Me.CbxFila.Name = "CbxFila"
        Me.CbxFila.Size = New System.Drawing.Size(47, 21)
        Me.CbxFila.TabIndex = 13
        '
        'CbxZona
        '
        Me.CbxZona.FormattingEnabled = True
        Me.CbxZona.Location = New System.Drawing.Point(17, 79)
        Me.CbxZona.Name = "CbxZona"
        Me.CbxZona.Size = New System.Drawing.Size(72, 21)
        Me.CbxZona.TabIndex = 12
        '
        'ComprarBoleto
        '
        Me.ComprarBoleto.BackColor = System.Drawing.Color.RoyalBlue
        Me.ComprarBoleto.Location = New System.Drawing.Point(180, 175)
        Me.ComprarBoleto.Name = "ComprarBoleto"
        Me.ComprarBoleto.Size = New System.Drawing.Size(75, 36)
        Me.ComprarBoleto.TabIndex = 11
        Me.ComprarBoleto.Text = "Comprar Boleto"
        Me.ComprarBoleto.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 18)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(58, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Concierto: "
        '
        'ComboBoxConcierto
        '
        Me.ComboBoxConcierto.FormattingEnabled = True
        Me.ComboBoxConcierto.Location = New System.Drawing.Point(17, 34)
        Me.ComboBoxConcierto.Name = "ComboBoxConcierto"
        Me.ComboBoxConcierto.Size = New System.Drawing.Size(121, 21)
        Me.ComboBoxConcierto.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Fila"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(81, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Numero"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Zona:"
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Location = New System.Drawing.Point(94, 47)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(8, 8)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(0, 0)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(0, 0)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Turquoise
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.TbxFolioRegresar)
        Me.TabPage2.Controls.Add(Me.BtnRegresar)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(264, 219)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Regreso"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(74, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Folio de venta"
        '
        'TbxFolioRegresar
        '
        Me.TbxFolioRegresar.Location = New System.Drawing.Point(78, 76)
        Me.TbxFolioRegresar.Name = "TbxFolioRegresar"
        Me.TbxFolioRegresar.Size = New System.Drawing.Size(100, 20)
        Me.TbxFolioRegresar.TabIndex = 1
        '
        'BtnRegresar
        '
        Me.BtnRegresar.Location = New System.Drawing.Point(93, 102)
        Me.BtnRegresar.Name = "BtnRegresar"
        Me.BtnRegresar.Size = New System.Drawing.Size(75, 23)
        Me.BtnRegresar.TabIndex = 0
        Me.BtnRegresar.Text = "Regresar"
        Me.BtnRegresar.UseVisualStyleBackColor = True
        '
        'Vendedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 248)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Vendedor"
        Me.Text = "Vendedor"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents ComprarBoleto As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBoxConcierto As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents TbxFolioRegresar As TextBox
    Friend WithEvents BtnRegresar As Button
    Friend WithEvents CbxZona As ComboBox
    Friend WithEvents CbxNumero As ComboBox
    Friend WithEvents CbxFila As ComboBox
End Class
