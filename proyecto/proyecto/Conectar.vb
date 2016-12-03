Imports System.Data.SqlClient
Public Class Conectar
    Private conexion As SqlConnection
    Public idUsuario As String
    Public err As Boolean = False
    Dim Cnt As New DataSet("Conexion")

    Private Sub Conectar_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Cnt.ReadXml("Conexion.xml")
        TextBox1.DataBindings.Add("Text", Cnt, "Conexion.Cadena")
        Dim intento As String
        intento = TextBox1.Text

        Try
            conexion = New SqlConnection(intento)
            conexion.Open()

        Catch ex As Exception
            err = True
            MessageBox.Show("Error de conexion")
        End Try



    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intento As String
        intento = TextBox1.Text
        Try
            conexion = New SqlConnection(intento)
            conexion.Open()
            Cnt.WriteXml("Conexion.xml")

            Me.Finalize()
            Inicio.Show()
        Catch ex As Exception
            err = True
            MessageBox.Show("la cadena de conexion no es valida")
        End Try


    End Sub


End Class