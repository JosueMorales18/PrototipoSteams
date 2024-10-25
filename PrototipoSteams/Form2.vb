Public Class Form2

    ' Declarar el botón como WithEvents
    Private WithEvents Button1 As Button

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Agregar apartados al panel
        AxWindowsMediaPlayer1.uiMode = "mini"
        AxWindowsMediaPlayer1.URL = "C:\Users\josue\source\repos\PrototipoSteams\publicidad.mp4"
        AxWindowsMediaPlayer1.Ctlcontrols.play()

    End Sub

    ' Manejar el evento Click del botón
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MessageBox.Show("Botón clicado")
    End Sub


    '  Private Sub AgregarApartadoVertical(titulo As String, descripcion As String)
    ' Etiqueta para el título
    'Dim lblTitulo As New Label()
    '   lblTitulo.Text = titulo
    '  lblTitulo.Font = New Font("Arial", 14, FontStyle.Bold)
    ' lblTitulo.Width = 250 ' Ajustar el ancho del título
    'lblTitulo.Height = 30

    '        lblTitulo.Left = 10 ' Ajustar la ubicación horizontal
    '
    ' Etiqueta para la descripción
    '   Dim lblDescripcion As New Label()
    '      lblDescripcion.Text = descripcion
    '     lblDescripcion.Font = New Font("Arial", 10, FontStyle.Regular)
    '    lblDescripcion.Width = 600 ' Ajustar el ancho de la descripción
    '   lblDescripcion.Height = 60 ' Ajustar la altura de la descripción según el contenido

    '  lblDescripcion.Left = 10 ' Ajustar la ubicación horizontal


    ' Calcular la posición vertical
    'Dim totalControls As Integer = Panel1.Controls.Count
    'Dim topPos As Integer = totalControls * 80 ' Espacio entre apartados

    ' Establecer posiciones
    '   lblTitulo.Top = topPos
    '  lblTitulo.Left = 10 ' Alinear a la izquierda

    'lblDescripcion.Top = topPos + 35 ' Espaciado con el título
    ' lblDescripcion.Left = 10 ' Alinear a la izquierda

    ' Agregar los controles al panel
    '  Panel1.Controls.Add(lblTitulo)
    '   Panel1.Controls.Add(lblDescripcion)
    'End Sub



    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        PictureBox1.Image = Image.FromFile("C:\Users\josue\source\repos\PrototipoSteams\logo-Dyadia.jpg")

    End Sub



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
End Class
