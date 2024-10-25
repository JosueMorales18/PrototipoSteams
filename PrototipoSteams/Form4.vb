Imports System.Data.Common
Imports System.Data.Odbc

Public Class Form4
    ' Configuración de la cadena de conexión ODBC
    Dim connectionString As String = "DSN=MySQL.VB;" ' Asegúrate de que el DSN sea correcto
    Dim connection As OdbcConnection

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim texto As String = TextBox1.Text

        ' Verificar si el texto tiene al menos 6 caracteres
        If texto.Length < 6 Then
            TextBox1.BackColor = Color.LightCoral ' Color de advertencia
        Else
            TextBox1.BackColor = Color.LightGreen ' Color de éxito
        End If
    End Sub

    Private Function ContieneLetrasYNumeros(texto As String) As Boolean
        Dim tieneLetra As Boolean = False
        Dim tieneNumero As Boolean = False

        For Each c As Char In texto
            If Char.IsLetter(c) Then
                tieneLetra = True
            ElseIf Char.IsDigit(c) Then
                tieneNumero = True
            End If

            ' Si ya tenemos ambos, no es necesario seguir revisando
            If tieneLetra AndAlso tieneNumero Then
                Return True
            End If
        Next

        Return False
    End Function

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim texto As String = TextBox2.Text

        ' Verificar si el texto tiene al menos 8 caracteres y contiene letras y números
        If texto.Length < 8 OrElse Not ContieneLetrasYNumeros(texto) Then
            TextBox2.BackColor = Color.LightCoral ' Color de advertencia
        Else
            TextBox2.BackColor = Color.LightGreen ' Color de éxito
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Verificar si los campos son válidos antes de guardar en la base de datos
        If TextBox1.BackColor = Color.LightGreen AndAlso TextBox2.BackColor = Color.LightGreen Then
            ' Llamar a la función para guardar los datos
            GuardarDatosEnBD(TextBox1.Text, TextBox2.Text)
        Else
            MessageBox.Show("Por favor, corrige los errores en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Función para guardar el nombre y la contraseña en la base de datos
    Private Sub GuardarDatosEnBD(nombre As String, contraseña As String)
        connection = New OdbcConnection(connectionString)

        Try
            connection.Open()
            ' Comando para insertar los datos en la tabla
            Dim query As String = "INSERT INTO registro_usuarios (nombre, contraseña) VALUES (?, ?)"
            Dim command As New OdbcCommand(query, connection)

            ' Agregar los parámetros
            command.Parameters.Add(New OdbcParameter("@nombre", nombre))
            command.Parameters.Add(New OdbcParameter("@contraseña", contraseña))

            ' Ejecutar el comando
            Dim result As Integer = command.ExecuteNonQuery()

            If result > 0 Then
                MessageBox.Show("Datos guardados exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al guardar los datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Error en la conexión: " & ex.Message)
        Finally
            ' Cerrar la conexión
            If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
                connection.Close()
            End If
        End Try
    End Sub
End Class
