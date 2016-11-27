Imports System.Data.SqlClient
Public Class Vendedor
    Private conexion As SqlConnection
    Private idConciertoG As String


    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        conexion = New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=prograAplicada;Data Source=SAMANTHA")


        ' Add any initialization after the InitializeComponent() call.

    End Sub



    Private Sub Vendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ComboBoxConcierto.Items.Clear()

        CbxFila.Text = ""
        CbxFila.Items.Clear()
        CbxNumero.Text = ""
        CbxNumero.Items.Clear()
        CbxZona.Text = ""
        CbxZona.Items.Clear()

        CbxZona.DropDownStyle = ComboBoxStyle.DropDownList
        CbxNumero.DropDownStyle = ComboBoxStyle.DropDownList
        ComboBoxConcierto.DropDownStyle = ComboBoxStyle.DropDownList
        CbxFila.DropDownStyle = ComboBoxStyle.DropDownList
        Dim miPeticion As SqlCommand
        Dim data As SqlDataReader

        ComprarBoleto.Enabled = False


        conexion.Open()
        miPeticion = New SqlCommand("SELECT Nombre FROM Concierto", conexion)
        data = miPeticion.ExecuteReader
        While data.Read
            ComboBoxConcierto.Items.Add(RTrim(data("Nombre")))

        End While
        conexion.Close()





    End Sub

    Private Sub ComboBoxConcierto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxConcierto.SelectedIndexChanged

        ComprarBoleto.Enabled = False
        CbxZona.Items.Clear()
        CbxFila.Items.Clear()
        CbxNumero.Items.Clear()

        CbxNumero.Text = ""
        CbxFila.Text = ""
        CbxZona.Text = ""
        Dim Zonas As SqlCommand
        Dim peticionConcierto As SqlCommand

        Dim id As SqlDataReader
        Dim datos As SqlDataReader

        conexion.Open()


        Zonas = New SqlCommand("select DISTINCT zona.ID_Zona from zona", conexion)
        datos = Zonas.ExecuteReader
        While datos.Read
            CbxZona.Items.Add(RTrim(datos("ID_Zona")))

        End While
        conexion.Close()




    End Sub

    Private Sub CbxZona_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxZona.SelectedIndexChanged
        ComprarBoleto.Enabled = False
        CbxNumero.Items.Clear()
        CbxFila.Items.Clear()
        CbxNumero.Text = ""
        CbxFila.Text = ""

        Dim conciertoSel As String
        Dim idConcierto As SqlCommand
        Dim idConcert As String
        conciertoSel = ComboBoxConcierto.SelectedItem
        Dim zonaSel As String
        Dim FilaYNumero As SqlCommand
        Dim IDc As SqlDataReader
        Dim DATOS As SqlDataReader
        zonaSel = CbxZona.SelectedItem



        idConcert = 0


        conexion.Open()
        idConcierto = New SqlCommand("select concierto.ID_Concierto from Concierto where concierto.Nombre='" + conciertoSel + "'", conexion)
        IDc = idConcierto.ExecuteReader
        While IDc.Read
            idConcert = RTrim(IDc("ID_Concierto")).ToString

        End While
        IDc.Close()


        Dim cmd As String = "SELECT  asiento.Fila, asiento.Numero, asiento.id_Asiento FROM asiento WHERE asiento.id_Asiento NOT IN (Select  asiento.id_Asiento FROM asiento, boleto  WHERE boleto.id_Asiento = asiento.id_Asiento And boleto.id_Concierto='" + idConcert + "') And id_Zona = '" + zonaSel + "'"
        FilaYNumero = New SqlCommand(cmd, conexion)


        DATOS = FilaYNumero.ExecuteReader
        While DATOS.Read
            CbxFila.Items.Add(RTrim(DATOS("Fila")))
            CbxNumero.Items.Add(RTrim(DATOS("Numero")))
        End While
        DATOS.Close()
        conexion.Close()


    End Sub

    Private Sub CbxFila_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxFila.SelectedIndexChanged



        ComprarBoleto.Enabled = False
        Dim conciertoSel As String
        Dim idConcierto As SqlCommand
        Dim idConcert As String
        conciertoSel = ComboBoxConcierto.SelectedItem
        Dim zonaSel As String
        Dim FilaYNumero As SqlCommand
        Dim IDc As SqlDataReader
        Dim DATOS As SqlDataReader
        zonaSel = CbxZona.SelectedItem



        CbxNumero.Items.Clear()
        conexion.Open()
        idConcierto = New SqlCommand("select concierto.ID_Concierto from Concierto where concierto.Nombre='" + conciertoSel + "'", conexion)
        IDc = idConcierto.ExecuteReader
        While IDc.Read
            idConcert = RTrim(IDc("ID_Concierto")).ToString
            idConciertoG = idConcert
        End While
        IDc.Close()


        Dim cmd As String = "SELECT asiento.Fila, asiento.Numero, asiento.id_Asiento FROM asiento WHERE asiento.id_Asiento NOT IN (Select  asiento.id_Asiento FROM asiento, boleto  WHERE boleto.id_Asiento = asiento.id_Asiento And boleto.id_Concierto='" + idConcert + "') And id_Zona = '" + zonaSel + "'"
        FilaYNumero = New SqlCommand(cmd, conexion)





        DATOS = FilaYNumero.ExecuteReader
        While DATOS.Read
            CbxNumero.Items.Add(RTrim(DATOS("Numero")))
        End While
        DATOS.Close()

        conexion.Close()

    End Sub

    Private Sub ComprarBoleto_Click(sender As Object, e As EventArgs) Handles ComprarBoleto.Click
        'idConciertoG
        Dim PrecioSql As SqlCommand
        Dim InsertarRecibo As SqlCommand
        Dim Precio As String
        Dim data2 As SqlDataReader
        Dim zonaSel As String
        Dim numerosel As String
        Dim FilaSel As String
        Dim FolioCompraSQL As SqlCommand
        Dim FolioCompra As String
        Dim InsertarBoleto As SqlCommand
        Dim IDAsientosql As SqlCommand
        Dim IDASIENTO As String
        Dim IDTRABAJA As String

        IDTRABAJA = Inicio.idUsuario
        numerosel = CbxNumero.SelectedItem
        FilaSel = CbxFila.SelectedItem
        zonaSel = CbxZona.SelectedItem
        conexion.Open()
        PrecioSql = New SqlCommand("select zona.precio from zona where zona.ID_Zona='" + zonaSel + "'", conexion)
        data2 = PrecioSql.ExecuteReader
        Precio = 0
        While data2.Read
            Precio = data2(RTrim("precio"))
        End While
        data2.Close()


        InsertarRecibo = New SqlCommand("Insert into Recibo(monto) values (" + Precio + ")", conexion)
        InsertarRecibo.ExecuteNonQuery()


        FolioCompraSQL = New SqlCommand("select max(recibo.Folio_compra) as UltFolio from Recibo", conexion)
        data2 = FolioCompraSQL.ExecuteReader
        While data2.Read
            FolioCompra = data2(RTrim("UltFolio"))
        End While

        data2.Close()


        IDAsientosql = New SqlCommand(" Select asiento.ID_Asiento from Asiento where asiento.ID_Zona='" + zonaSel + "' and asiento.Numero='" + numerosel + "' and asiento.Fila='" + FilaSel + "'", conexion)
        data2 = IDAsientosql.ExecuteReader
        While data2.Read
            IDASIENTO = data2(RTrim("ID_Asiento"))
        End While
        data2.Close()


        InsertarBoleto = New SqlCommand("Insert into Boleto (ID_Asiento,Folio_Compra,ID_Concierto,ID_Trabajador) values (" + IDASIENTO + "," + FolioCompra + "," + idConciertoG + "," + IDTRABAJA + ")", conexion)

        InsertarBoleto.ExecuteNonQuery()

        MessageBox.Show(FolioCompra, "Vendido")



        conexion.Close()

        ComboBoxConcierto.Text = " "
        CbxFila.Text = ""
        CbxFila.Items.Clear()
        CbxNumero.Text = ""
        CbxNumero.Items.Clear()
        CbxZona.Text = ""
        CbxZona.Items.Clear()
        Vendedor_Load(sender, e)
    End Sub

    Private Sub CbxNumero_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxNumero.SelectedIndexChanged
        If CbxZona.Text.Length >= 1 And CbxFila.Text.Length >= 1 And ComboBoxConcierto.Text.Length >= 1 And CbxNumero.Text.Length Then
            ComprarBoleto.Enabled = True
        Else
            ComprarBoleto.Enabled = False
        End If
    End Sub

    Private Sub BtnRegresar_Click(sender As Object, e As EventArgs) Handles BtnRegresar.Click

        Dim FolioIngresado As String
        FolioIngresado = TbxFolioRegresar.Text
        Dim validar As Boolean
        Dim RevisarFolio As SqlCommand
        Dim TodosFolios As SqlDataReader
        validar = False
        Dim EliminarBoleto As SqlCommand
        Dim EliminarRecibo As SqlCommand
        Dim eliminar As SqlCommand
        conexion.Open()
        RevisarFolio = New SqlCommand("Select boleto.Folio_Compra FROM BOLETO inner join Recibo on recibo.Folio_compra=boleto.Folio_Compra", conexion)
        TodosFolios = RevisarFolio.ExecuteReader
        While TodosFolios.Read

            If String.Equals(RTrim(FolioIngresado), RTrim(TodosFolios("Folio_Compra"))) Then
                validar = True


            End If

        End While
        TodosFolios.Close()

        If validar = True Then

            eliminar = New SqlCommand("EXEC ProcedimientoEliminarBoleto  @foliocomprasel = '" + FolioIngresado + "'", conexion)



            eliminar.ExecuteNonQuery()



            MessageBox.Show(FolioIngresado, "Eliminado")
            TbxFolioRegresar.Text = ""
        Else
            MessageBox.Show("Folio Incorrecto")
        End If


        conexion.Close()

    End Sub
End Class