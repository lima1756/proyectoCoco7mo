Imports System.Data.SqlClient
Public Class controlDeAcceso
    'en el combobox se debe elegir la zona y esta se enviara a un procedimiento almacenado para compararlo con el folio ingresado. si la zonas corresponden debe aparecer una afirmacion 
    Private conexion As SqlConnection
    Private idConciertoG As String


    Public Sub New()
        Dim cad As String = Conectar.TextBox1.Text
        ' This call is required by the designer.
        InitializeComponent()

        conexion = New SqlConnection(cad)


        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub controlDeAcceso_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnRevisar_Click(sender As Object, e As EventArgs) Handles btnRevisar.Click
        Dim zona As String
        Dim revisarFolio As SqlCommand
        Dim datos As SqlDataReader
        zona = cbxZona.Text
        Dim folioR As String
        folioR = txtFolio.Text
        conexion.Open()
        MessageBox.Show(zona)
        revisarFolio = New SqlCommand("EXEC Confirmacion  @id_zona = '" + zona + "', @folio= '" + folioR + "'", conexion)


        datos = revisarFolio.ExecuteReader
        While datos.Read

            If datos("retorno") = "true" Then
                MessageBox.Show("Puede acceder")
            ElseIf datos("retorno") = "false" Then
                MessageBox.Show("No Puede acceder")

            End If
        End While

        conexion.Close()





    End Sub
End Class