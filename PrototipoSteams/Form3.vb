Public Class Form3

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Dim texto As String = TextBox1.Text
        If texto.Length < 6 Then
            TextBox1.BackColor = Color.LightCoral ' Color de advertencia

        Else
            TextBox1.BackColor = Color.LightGreen ' Color de éxito
        End If
    End Sub



    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim texto As String = TextBox2.Text
        If texto.Length < 8 Then
            TextBox2.BackColor = Color.LightCoral ' Color de advertencia

        Else
            TextBox2.BackColor = Color.LightGreen ' Color de éxito
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Aquí puedes realizar acciones al presionar el botón
        If TextBox1.BackColor = Color.LightGreen AndAlso TextBox2.BackColor = Color.LightGreen Then
            MessageBox.Show("Ambos campos son válidos.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Por favor, corrige los errores en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Dim emergente As New Form4()
        emergente.ShowDialog()
    End Sub
End Class
'  Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
'     Dim texto As String = TextBox1.Text

' Verificar si el texto tiene al menos 6 caracteres
' If texto.Length < 6 Then
'        ' Puedes mostrar un mensaje o cambiar el color del TextBox
'       TextBox1.BackColor = Color.LightCoral ' Color de advertencia
'Else
'       TextBox1.BackColor = Color.LightGreen ' Color normal
'End If

'End Sub

''Private Function ContieneLetrasYNumeros(texto As String) As Boolean
'Dim tieneLetra As Boolean = False
'Dim tieneNumero As Boolean = False
'
'For Each c As Char In texto
'If Char.IsLetter(c) Then
'           tieneLetra = True
'ElseIf Char.IsDigit(c) Then
'           tieneNumero = True
'End If

' Si ya tenemos ambos, no es necesario seguir revisando
'If tieneLetra AndAlso tieneNumero Then
'Return True
'End If
'Next

'Return False
'End Function

'Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
'Dim texto As String = TextBox2.Text
'
' Verificar si el texto tiene al menos 6 caracteres
'If texto.Length < 8 Then
' Puedes mostrar un mensaje o cambiar el color del TextBox
'       TextBox2.BackColor = Color.LightCoral ' Color de advertencia
'Else
'      TextBox2.BackColor = Color.White ' Color normal
'   End If

' Verificar si contiene al menos una letra y un número
'If Not ContieneLetrasYNumeros(texto) Then
' Puedes mostrar un mensaje o cambiar el color del TextBox

'      TextBox2.BackColor = Color.LightCoral ' Color de advertencia
'   ElseIf texto.Length < 8 Then
'    TextBox2.BackColor = Color.LightGreen ' Color de éxito
' End If
'    End Sub
