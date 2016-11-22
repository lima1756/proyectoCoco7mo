Imports System.Data.SqlClient

Public Class Inicio
    Private conexion As SqlConnection

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        conexion = New SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=prograAplicada;Data Source=SAMANTHA")


        ' Add any initialization after the InitializeComponent() call.

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
        Dim trabajador As Boolean
        Dim Administrador As New Administrador
        Dim vendedor As New Vendedor

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

                        trabajador = datos("admin")
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



                    If trabajador = True Then
                        Administrador.Show()
                        Me.Finalize()
                    End If
                    If trabajador = False Then
                        vendedor.Show()
                        Me.Finalize()
                    End If
                End If


                End If







        Else
                MessageBox.Show("Ingrese datos")

        End If
        conexion.Close()



    End Sub


End Class
