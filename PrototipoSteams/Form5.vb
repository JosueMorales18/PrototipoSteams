Imports System.Data.Common
Imports System.Data.Odbc
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form5
    ' Configuración de la cadena de conexión ODBC
    Dim connectionString As String = "DSN=MySQL.VB;" ' Asegúrate de que el DSN sea correcto
    Dim connection As OdbcConnection

    Private Sub InicioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InicioToolStripMenuItem.Click
        Dim Form2 As New Form2()
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub CatalogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatalogoToolStripMenuItem.Click
        Dim formCatalogo As New Form1()
        formCatalogo.Show()
        Me.Hide()
    End Sub

    Private Sub PerfilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PerfilToolStripMenuItem.Click
        Dim formPerfil As New Form5()
        formPerfil.Show()
        Me.Hide()
    End Sub

    Private Sub SoporteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoporteToolStripMenuItem.Click
        Dim formPerfil As New Form5()
        formPerfil.Show()
        Me.Hide()
    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged
        Dim numero As Integer

        ' Intenta convertir el texto a un número
        If Integer.TryParse(TextBox3.Text, numero) Then
            If numero > 200 Then
                TextBox3.BackColor = Color.LightCoral ' Color de advertencia
                Label1.Text = "El número debe ser 200 o menor."
                Label1.ForeColor = Color.Red
                Label1.Visible = True
            Else
                TextBox3.BackColor = Color.LightGreen ' Color de éxito
                Label1.Visible = False
            End If
        Else
            ' Si no es un número válido
            TextBox3.BackColor = Color.LightCoral
            Label1.Text = "Ingrese un número válido."
            Label1.ForeColor = Color.Red
            Label1.Visible = True
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Verificar si los campos son válidos antes de guardar en la base de datos
        If TextBox3.BackColor = Color.LightGreen Then
            ' Llamar a la función para guardar los datos
            GuardarDatosEnBD(TextBox3.Text)
        Else
            MessageBox.Show("Por favor, corrige los errores en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub GuardarDatosEnBD(monto As String)
        connection = New OdbcConnection(connectionString)

        Try
            connection.Open()
            ' Comando para insertar los datos en la tabla
            Dim query As String = "INSERT INTO registro_usuarios (monto) VALUES (?)"
            Dim command As New OdbcCommand(query, connection)

            ' Agregar los parámetros
            command.Parameters.Add(New OdbcParameter("@monto", monto))


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