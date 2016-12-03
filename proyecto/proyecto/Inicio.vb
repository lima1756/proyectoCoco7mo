Imports System.Data.SqlClient

Public Class Inicio
    Private conexion As SqlConnection
    Public idUsuario As String
    Public err As Boolean = False

    Public Sub New()
        Dim cad As String = Conectar.TextBox1.Text
        ' This call is required by the designer.
        InitializeComponent()
        Try
            conexion = New SqlConnection(cad)
        Catch ex As Exception
            err = True
            MessageBox.Show("Error")
        End Try

        ' Add any initialization after the InitializeComponent() call.
        If err = False Then
            Dim Vendedor As New Vendedor()
        End If


    End Sub
    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim peticion As SqlCommand
        Dim datos As SqlDataReader
        Dim usuarioIngresado As String
        Dim contraseñaIngresado As String
        Dim usuarios As String
        Dim contraCorr As String
        Dim validUs As Boolean
        Dim validC As Boolean
        Dim trabajador As Int16
        Dim Administrador As New Administrador
        Dim vendedor As New Vendedor
        Dim controlDeAcceso As New controlDeAcceso
        conexion.Open()
        peticion = New SqlCommand("select * from Trabajador", conexion)
        datos = peticion.ExecuteReader
        If tbxUsuario.Text.Length > 0 And tbxContraseña.Text.Length > 0 Then
            usuarioIngresado = tbxUsuario.Text
            contraseñaIngresado = tbxContraseña.Text
            While datos.Read


                usuarios = RTrim(datos("usuario"))
                contraCorr = RTrim(datos("contraseña"))

                If String.Equals(usuarioIngresado, usuarios) Then
                    validUs = True

                    If String.Compare(contraseñaIngresado, contraCorr, True) = 0 Then

                        validC = True

                        trabajador = datos("TipodeTrabajador")
                        idUsuario = datos("ID_Trabajador")
                    Else

                    End If
                Else



                End If


            End While

            If validUs = False Then
                MessageBox.Show("Ingrese un usuario valido")

            ElseIf validUs = True Then

                If validC = False Then
                    MessageBox.Show("contraseña Incorrecta")
                ElseIf validC = True Then



                    If trabajador = 1 Then
                        Administrador.Show()
                        Me.Finalize()
                    End If
                    If trabajador = 2 Then
                        vendedor.Show()
                        Me.Finalize()
                    End If
                    If trabajador = 3 Then
                        controlDeAcceso.Show()
                        Me.Finalize()
                    End If
                End If

            End If
        Else
            MessageBox.Show("Ingrese datos")

        End If
        conexion.Close()



    End Sub

    Private Sub Inicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If err = True Then
            Conectar.Show()

        Else

        End If

    End Sub


End Class
