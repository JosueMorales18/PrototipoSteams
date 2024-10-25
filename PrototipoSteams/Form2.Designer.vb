<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        PictureBox1 = New PictureBox()
        AxWindowsMediaPlayer1 = New AxWMPLib.AxWindowsMediaPlayer()
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        CatalogoToolStripMenuItem = New ToolStripMenuItem()
        Button2 = New Button()
        pictureBox = New PictureBox()
        Label1 = New Label()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        Panel1 = New Panel()
        PerfilToolStripMenuItem = New ToolStripMenuItem()
        SoporteToolStripMenuItem = New ToolStripMenuItem()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).BeginInit()
        MenuStrip1.SuspendLayout()
        CType(pictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_Dyadia
        PictureBox1.Location = New Point(43, 31)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1127, 196)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' AxWindowsMediaPlayer1
        ' 
        AxWindowsMediaPlayer1.Enabled = True
        AxWindowsMediaPlayer1.Location = New Point(43, 251)
        AxWindowsMediaPlayer1.Name = "AxWindowsMediaPlayer1"
        AxWindowsMediaPlayer1.OcxState = CType(resources.GetObject("AxWindowsMediaPlayer1.OcxState"), AxHost.State)
        AxWindowsMediaPlayer1.Size = New Size(299, 542)
        AxWindowsMediaPlayer1.TabIndex = 3
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, CatalogoToolStripMenuItem, PerfilToolStripMenuItem, SoporteToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1204, 28)
        MenuStrip1.TabIndex = 4
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InicioToolStripMenuItem
        ' 
        InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        InicioToolStripMenuItem.Size = New Size(59, 24)
        InicioToolStripMenuItem.Text = "Inicio"
        ' 
        ' CatalogoToolStripMenuItem
        ' 
        CatalogoToolStripMenuItem.Name = "CatalogoToolStripMenuItem"
        CatalogoToolStripMenuItem.Size = New Size(84, 24)
        CatalogoToolStripMenuItem.Text = "Catalogo"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(662, 92)
        Button2.Name = "Button2"
        Button2.Size = New Size(86, 27)
        Button2.TabIndex = 0
        Button2.Text = "Button2"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' pictureBox
        ' 
        pictureBox.Image = My.Resources.Resources.FVII
        pictureBox.Location = New Point(19, 29)
        pictureBox.Name = "pictureBox"
        pictureBox.Size = New Size(266, 231)
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox.TabIndex = 3
        pictureBox.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(341, 45)
        Label1.Name = "Label1"
        Label1.Size = New Size(430, 215)
        Label1.TabIndex = 4
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = My.Resources.Resources.FVII
        PictureBox3.Location = New Point(19, 573)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(266, 231)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = My.Resources.Resources.FVII
        PictureBox2.Location = New Point(19, 311)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(266, 231)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 5
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(341, 327)
        Label2.Name = "Label2"
        Label2.Size = New Size(430, 215)
        Label2.TabIndex = 6
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(341, 589)
        Label3.Name = "Label3"
        Label3.Size = New Size(430, 215)
        Label3.TabIndex = 8
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' Panel1
        ' 
        Panel1.AutoScroll = True
        Panel1.BackgroundImageLayout = ImageLayout.Stretch
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(PictureBox2)
        Panel1.Controls.Add(PictureBox3)
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(pictureBox)
        Panel1.Controls.Add(Button2)
        Panel1.Location = New Point(370, 251)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(800, 500)
        Panel1.TabIndex = 1
        ' 
        ' PerfilToolStripMenuItem
        ' 
        PerfilToolStripMenuItem.Name = "PerfilToolStripMenuItem"
        PerfilToolStripMenuItem.Size = New Size(56, 24)
        PerfilToolStripMenuItem.Text = "Perfil"
        ' 
        ' SoporteToolStripMenuItem
        ' 
        SoporteToolStripMenuItem.Name = "SoporteToolStripMenuItem"
        SoporteToolStripMenuItem.Size = New Size(76, 24)
        SoporteToolStripMenuItem.Text = "Soporte"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1204, 777)
        Controls.Add(AxWindowsMediaPlayer1)
        Controls.Add(PictureBox1)
        Controls.Add(Panel1)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form2"
        Text = "Form2"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(AxWindowsMediaPlayer1, ComponentModel.ISupportInitialize).EndInit()
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(pictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AxWindowsMediaPlayer1 As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Button2 As Button
    Friend WithEvents pictureBox As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Private WithEvents Panel1 As Panel
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoporteToolStripMenuItem As ToolStripMenuItem




End Class
