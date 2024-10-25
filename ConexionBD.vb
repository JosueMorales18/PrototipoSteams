Imports Microsoft.VisualBasic

Imports System.Data.Odbc

Module ConexionBD
    ' Cadena de conexión global
    Public connectionString As String = "DSN=MySQL.VB;" ' Reemplaza "MySQLConnection" con el nombre de tu DSN
    Public connection As OdbcConnection

    ' Método para abrir la conexión
    Public Sub AbrirConexion()
        connection = New OdbcConnection(connectionString)

        Try
            connection.Open()
            MessageBox.Show("Conexión exitosa con MySQL")
        Catch ex As Exception
            MessageBox.Show("Error en la conexión: " & ex.Message)
        End Try
    End Sub

    ' Método para cerrar la conexión
    Public Sub CerrarConexion()
        If connection IsNot Nothing AndAlso connection.State = ConnectionState.Open Then
            connection.Close()
        End If
    End Sub
End Module
