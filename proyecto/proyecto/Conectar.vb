Public Class Conectar

    Dim Cnt As New DataSet("Conexion")

    Private Sub Conectar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cnt.ReadXml("Conexion.xml")
        TextBox1.DataBindings.Add("Text", Cnt, "Conexion.Cadena")


        If Inicio.err = False Then
            Inicio.Show()
            Me.Finalize()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Cnt.WriteXml("Conexion.xml")
        Inicio.Show()
    End Sub


End Class