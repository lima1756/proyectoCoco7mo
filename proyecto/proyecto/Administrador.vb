Imports System.Data.SqlClient
Public Class Administrador
    Private conexion As SqlConnection
    Private idConciertoG As String


    Public Sub New()
        Dim cad As String = Conectar.TextBox1.Text
        ' This call is required by the designer.
        InitializeComponent()

        conexion = New SqlConnection(cad)


        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub Administrador_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim miPeticion As SqlCommand
        Dim data As SqlDataReader


        DateTimePickerInicio.CustomFormat = "yyyy/MM/dd hh:mm:ss tt"
        DateTimePicker5Fin.CustomFormat = "yyyy/MM/dd hh:mm:ss tt"
        DateTimePicker4Fi.CustomFormat = "yyyy/MM/dd hh:mm:ss tt"
        DateTimePickerIni.CustomFormat = "yyyy/MM/dd hh:mm:ss tt"
        DateTimePicker5Fin.Format = DateTimePickerFormat.Custom
        DateTimePickerInicio.Format = DateTimePickerFormat.Custom
        DateTimePicker4Fi.Format = DateTimePickerFormat.Custom
        DateTimePickerIni.Format = DateTimePickerFormat.Custom
        conexion.Open()
        miPeticion = New SqlCommand("SELECT Nombre FROM Concierto", conexion)
        data = miPeticion.ExecuteReader
        While data.Read
            cbxConcierto.Items.Add(RTrim(data("Nombre")))
            cbxEliminarC.Items.Add(RTrim(data("Nombre")))
        End While
        conexion.Close()




    End Sub

    Private Sub cbxConcierto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxConcierto.SelectedIndexChanged
        'falta que si no ha seleccionado nada los textbox no aparezcan, cuando seleccionen algo apareceran y debe limitarse de acuerdo a la cantidad que se permite en la  bdd que es un nchar(40)'

        Dim conciertoMod As String
        conciertoMod = cbxConcierto.SelectedItem
        tbxNombre.Text = ""
        Dim DatosConcierto As SqlCommand
        Dim datos As SqlDataReader

        conexion.Open()


        DatosConcierto = New SqlCommand("select * from Concierto inner join Agenda on Agenda.ID_Concierto=Concierto.ID_Concierto where Nombre='" + conciertoMod + "'", conexion)
        datos = DatosConcierto.ExecuteReader
        While datos.Read
            idConciertoG = datos("ID_Concierto")
            tbxNombre.Text = datos("Nombre")
            tbxGenero.Text = datos("Género")
            tbxArtista.Text = datos("Artista")
            tbxDescripcion.Text = datos("Descripción")
            DateTimePickerInicio.Value = datos("Dia_Hora_Inicio")
            DateTimePicker5Fin.Value = datos("Dia_Hora_Fin")
        End While
        conexion.Close()









    End Sub



    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim nombre As String
        Dim artista As String
        Dim genero As String
        Dim descripcion As String
        Dim fechaI As String
        Dim fechaF As String
        nombre = tbxNombre.Text
        artista = tbxArtista.Text
        genero = tbxGenero.Text
        fechaI = DateTimePickerInicio.Value.ToString("yyyy-MM-dd hh:mm:ss tt")
        fechaF = DateTimePicker5Fin.Value.ToString("yyyy-MM-dd hh:mm:ss tt")
        MessageBox.Show(fechaI)
        descripcion = tbxDescripcion.Text
        DateTimePicker5Fin.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        DateTimePicker5Fin.Format = DateTimePickerFormat.Custom
        Dim x As String() = fechaF.Split(".")
        fechaF = ""
        For Each y As String In x
            fechaF = fechaF + y

        Next

        Dim xx As String() = fechaI.Split(".")
        fechaI = ""
        For Each yy As String In xx
            fechaI = fechaI + yy

        Next


        Dim modificar As SqlCommand
        conexion.Open()
        modificar = New SqlCommand("EXEC Modificar  @Nombre = '" + nombre + "',@Artista = '" + artista + "' ,@Género = '" + genero + "' ,@Descripción = '" + descripcion + "',@ID_Concierto = '" + idConciertoG + "',@Dia_Hora_Inicio='" + fechaI + "',@Dia_Hora_Fin='" + fechaI + "'", conexion)
        modificar.ExecuteNonQuery()

        conexion.Close()
    End Sub



    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Nombre As String
        Dim Artista As String
        Dim Genero As String
        Dim Descripcion As String
        Dim fechaIA As String
        Dim fechaFA As String
        Nombre = tbxN.Text
        Artista = tbxAr.Text
        Genero = tbxGe.Text
        Descripcion = tbxDes.Text
        fechaIA = DateTimePickerIni.Value.ToString("yyyy-MM-dd hh:mm:ss tt")
        fechaFA = DateTimePicker4Fi.Value.ToString("yyyy-MM-dd hh:mm:ss tt")
        Dim x As String() = fechaFA.Split(".")
        fechaFA = ""
        For Each y As String In x
            If y = " m" Then
                y = "m"
            End If
            fechaFA = fechaFA + y

        Next

        Dim xx As String() = fechaIA.Split(".")
        fechaIA = ""
        For Each yy As String In xx
            If yy = " m" Then
                yy = "m"
            End If
            fechaIA = fechaIA + yy

        Next


        MessageBox.Show("holi")
        Dim agregar As SqlCommand
        conexion.Open()
        agregar = New SqlCommand("EXEC Agregar  @Nombre = '" + Nombre + "',@Artista = '" + Artista + "' ,@Género = '" + Genero + "' ,@Descripción = '" + Descripcion + "',@Dia_Hora_Inicio='" + fechaIA + "',@Dia_Hora_Fin='" + fechaFA + "'", conexion)
        agregar.ExecuteNonQuery()

        MessageBox.Show("agregado")
        conexion.Close()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

    End Sub
End Class