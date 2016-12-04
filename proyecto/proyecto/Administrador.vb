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

        descripcion = tbxDescripcion.Text
        DateTimePicker5Fin.CustomFormat = "yyyy-MM-dd hh:mm:ss tt"
        DateTimePicker5Fin.Format = DateTimePickerFormat.Custom
        Dim x As String() = fechaF.Split(".")
        fechaF = ""
        For Each y As String In x
            If y = " m" Then
                y = "m"
            End If
            fechaF = fechaF + y

        Next

        Dim xx As String() = fechaI.Split(".")
        fechaI = ""
        For Each yy As String In xx
            If yy = " m" Then
                yy = "m"
            End If
            fechaI = fechaI + yy

        Next

        If tbxNombre.Text = "" Or tbxArtista.Text = "" Or tbxGenero.Text = "" Or tbxDescripcion.Text = "" Then

            MessageBox.Show("Faltan uno o varios campos por llenar")

        Else

            Dim modificar As SqlCommand
            conexion.Open()
            modificar = New SqlCommand("EXEC Modificar  @Nombre = '" + nombre + "',@Artista = '" + artista + "' ,@Género = '" + genero + "' ,@Descripción = '" + descripcion + "',@ID_Concierto = '" + idConciertoG + "',@Dia_Hora_Inicio='" + fechaI + "',@Dia_Hora_Fin='" + fechaI + "'", conexion)
            modificar.ExecuteNonQuery()

            tbxNombre.Clear()
            tbxArtista.Clear()
            tbxGenero.Clear()
            tbxDescripcion.Clear()

            cbxEliminarC.Items.Clear()
            cbxConcierto.Items.Clear()
            Dim data As SqlDataReader
            Dim mipeticion As SqlCommand
            mipeticion = New SqlCommand("SELECT Nombre FROM Concierto", conexion)
            data = mipeticion.ExecuteReader
            While data.Read
                cbxConcierto.Items.Add(RTrim(data("Nombre")))
                cbxEliminarC.Items.Add(RTrim(data("Nombre")))
            End While

            conexion.Close()
        End If
    End Sub



    Private Sub btnAgregar_Click_1(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim Nombre As String
        Dim Artista As String
        Dim Genero As String
        Dim Descripcion As String
        Dim fechaIA As String
        Dim fechaFA As String
        Dim existe As Boolean = False
        Nombre = tbxN.Text
        For Each item As Object In cbxEliminarC.Items
            If item.ToString = Nombre Then
                existe = True
                MessageBox.Show("Ya existe un concierto llamado " + Nombre)
            End If
        Next
        If existe = False Then
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

            If tbxN.Text = "" Or tbxAr.Text = "" Or tbxGe.Text = "" Or tbxDes.Text = "" Then

                MessageBox.Show("Faltan uno o varios campos por llenar")

            Else

                MessageBox.Show("Agregado")
                Dim agregar As SqlCommand
                conexion.Open()
                agregar = New SqlCommand("EXEC Agregar  @Nombre = '" + Nombre + "',@Artista = '" + Artista + "' ,@Género = '" + Genero + "' ,@Descripción = '" + Descripcion + "',@Dia_Hora_Inicio='" + fechaIA + "',@Dia_Hora_Fin='" + fechaFA + "'", conexion)
                agregar.ExecuteNonQuery()

                MessageBox.Show("agregado")

                tbxN.Clear()
                tbxAr.Clear()
                tbxGe.Clear()
                tbxDes.Clear()

                cbxEliminarC.Items.Clear()
                cbxConcierto.Items.Clear()
                Dim data As SqlDataReader
                Dim mipeticion As SqlCommand
                mipeticion = New SqlCommand("SELECT Nombre FROM Concierto", conexion)
                data = mipeticion.ExecuteReader
                While data.Read
                    cbxConcierto.Items.Add(RTrim(data("Nombre")))
                    cbxEliminarC.Items.Add(RTrim(data("Nombre")))
                End While
                conexion.Close()



            End If
        End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conexion.Open()
        Dim data As SqlDataReader
        Dim mipeticion As SqlCommand
        Dim eliminar As SqlCommand
        Dim eliminar2 As SqlCommand
        Dim eliminar3 As SqlCommand

        eliminar = New SqlCommand("Delete from boleto where boleto.ID_Concierto =(Select Concierto.ID_Concierto  from concierto where Concierto.Nombre= '" + cbxEliminarC.SelectedItem + "')", conexion)
        eliminar2 = New SqlCommand("Delete from agenda where agenda.ID_Concierto =(Select Concierto.ID_Concierto  from concierto where Concierto.Nombre= '" + cbxEliminarC.SelectedItem + "')", conexion)
        eliminar3 = New SqlCommand("Delete from Concierto where Concierto.Nombre='" + cbxEliminarC.SelectedItem + "'", conexion)
        eliminar.ExecuteNonQuery()
        eliminar2.ExecuteNonQuery()
        eliminar3.ExecuteNonQuery()
        MessageBox.Show("Haz eliminado el concierto: " + cbxEliminarC.SelectedItem)
        cbxEliminarC.Items.Clear()
        cbxConcierto.Items.Clear()
        mipeticion = New SqlCommand("SELECT Nombre FROM Concierto", conexion)
        Data = mipeticion.ExecuteReader
        While data.Read
            cbxConcierto.Items.Add(RTrim(data("Nombre")))
            cbxEliminarC.Items.Add(RTrim(Data("Nombre")))
        End While
        conexion.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Vendedor.Show()
    End Sub

    Private Sub AgrUs_Click(sender As Object, e As EventArgs) Handles AgrUs.Click
        Dim us As String
        Dim contraseña As String
        Dim nombre As String
        Dim apellido As String
        Dim edad As String
        Dim email As String
        Dim tipo As String

        If Usuario.Text = "" Or Con.Text = "" Or NomU.Text = "" Or ApU.Text = "" Or EdU.Text = "" Or EmailU.Text = "" Then
            MessageBox.Show("Falta llenar uno o más campos")
        ElseIf IsNumeric(EdU.Text) = False Then
            MessageBox.Show("Edad debe ser un numero")
        Else
            us = Usuario.Text
            contraseña = Con.Text
            nombre = NomU.Text
            apellido = ApU.Text
            edad = EdU.Text
            email = EmailU.Text
            If Admin.Checked Then
                tipo = "1"
            ElseIf Vendedor.Checked Then
                tipo = "2"
            ElseIf Ctrl_Acceso.Checked Then
                tipo = "3"
            End If
            conexion.Open()
            Dim mipeticion As SqlCommand
            mipeticion = New SqlCommand("Insert Into Trabajador (Usuario, Contraseña, Nombre, Apellido, Edad, email, TipodeTrabajador) Values ('" + us + "','" + contraseña + "','" + nombre + "','" + apellido + "'," + edad + ",'" + email + "'," + tipo + ")", conexion)
            mipeticion.ExecuteNonQuery()
            MessageBox.Show("Usuario registrado")
            Usuario.Clear()
            Con.Clear()
            NomU.Clear()
            ApU.Clear()
            EdU.Clear()
            EmailU.Clear()
            conexion.Close()
        End If
    End Sub
End Class



