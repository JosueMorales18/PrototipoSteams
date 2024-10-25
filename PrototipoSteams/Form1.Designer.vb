<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Limpiar los recursos que se están usando.
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        menuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        CatalogoToolStripMenuItem = New ToolStripMenuItem()
        panelHorizontal = New Panel()
        panel = New Panel()
        PictureBox3 = New PictureBox()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        Label2 = New Label()
        Label1 = New Label()
        pictureBox = New PictureBox()
        PictureBox1 = New PictureBox()
        PerfilToolStripMenuItem = New ToolStripMenuItem()
        SoporteToolStripMenuItem = New ToolStripMenuItem()
        menuStrip1.SuspendLayout()
        panel.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(pictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' menuStrip1
        ' 
        menuStrip1.ImageScalingSize = New Size(20, 20)
        menuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, CatalogoToolStripMenuItem, PerfilToolStripMenuItem, SoporteToolStripMenuItem})
        menuStrip1.Location = New Point(0, 0)
        menuStrip1.Name = "menuStrip1"
        menuStrip1.Padding = New Padding(8, 3, 0, 3)
        menuStrip1.Size = New Size(1204, 30)
        menuStrip1.TabIndex = 0
        menuStrip1.Text = "menuStrip1"
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
        ' panelHorizontal
        ' 
        panelHorizontal.Location = New Point(12, 235)
        panelHorizontal.Name = "panelHorizontal"
        panelHorizontal.Size = New Size(200, 100)
        panelHorizontal.TabIndex = 1
        ' 
        ' panel
        ' 
        panel.AutoScroll = True
        panel.BorderStyle = BorderStyle.FixedSingle
        panel.Controls.Add(PictureBox3)
        panel.Controls.Add(Label3)
        panel.Controls.Add(PictureBox2)
        panel.Controls.Add(Label2)
        panel.Controls.Add(Label1)
        panel.Controls.Add(pictureBox)
        panel.Location = New Point(110, 251)
        panel.Name = "panel"
        panel.Size = New Size(990, 500)
        panel.TabIndex = 0
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(18, 571)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(266, 231)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 6
        PictureBox3.TabStop = False
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(376, 574)
        Label3.Name = "Label3"
        Label3.Size = New Size(568, 158)
        Label3.TabIndex = 5
        Label3.Text = resources.GetString("Label3.Text")
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(18, 298)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(266, 231)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 4
        PictureBox2.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(376, 312)
        Label2.Name = "Label2"
        Label2.Size = New Size(560, 140)
        Label2.TabIndex = 3
        Label2.Text = resources.GetString("Label2.Text")
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(376, 43)
        Label1.Name = "Label1"
        Label1.Size = New Size(560, 215)
        Label1.TabIndex = 2
        Label1.Text = resources.GetString("Label1.Text")
        ' 
        ' pictureBox
        ' 
        pictureBox.Image = My.Resources.Resources.FVII
        pictureBox.Location = New Point(18, 27)
        pictureBox.Name = "pictureBox"
        pictureBox.Size = New Size(266, 231)
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox.TabIndex = 1
        pictureBox.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = My.Resources.Resources.logo_Dyadia
        PictureBox1.Location = New Point(39, 33)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(1127, 196)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 3
        PictureBox1.TabStop = False
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
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1204, 777)
        Controls.Add(PictureBox1)
        Controls.Add(panel)
        Controls.Add(panelHorizontal)
        Controls.Add(menuStrip1)
        MainMenuStrip = menuStrip1
        Margin = New Padding(4, 5, 4, 5)
        Name = "Form1"
        Text = "Form1"
        menuStrip1.ResumeLayout(False)
        menuStrip1.PerformLayout()
        panel.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(pictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()

    End Sub

    Friend WithEvents menuStrip1 As MenuStrip
    Friend WithEvents panelHorizontal As Panel
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents panel As Panel
    Friend WithEvents pictureBox As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoporteToolStripMenuItem As ToolStripMenuItem
End Class
