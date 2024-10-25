Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        CatalogoToolStripMenuItem = New ToolStripMenuItem()
        PerfilToolStripMenuItem = New ToolStripMenuItem()
        SoporteToolStripMenuItem = New ToolStripMenuItem()
        pictureBox = New PictureBox()
        label = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        RichTextBox1 = New RichTextBox()
        TextBox1 = New System.Windows.Forms.TextBox()
        Button1 = New System.Windows.Forms.Button()
        Label2 = New System.Windows.Forms.Label()
        DataGridView1 = New DataGridView()
        Catalogo = New DataGridViewTextBoxColumn()
        RPG = New DataGridViewTextBoxColumn()
        SHOOTER = New DataGridViewTextBoxColumn()
        ESTRATEGIA = New DataGridViewTextBoxColumn()
        Label3 = New System.Windows.Forms.Label()
        Button2 = New System.Windows.Forms.Button()
        TextBox3 = New System.Windows.Forms.TextBox()
        Label4 = New System.Windows.Forms.Label()
        MenuStrip1.SuspendLayout()
        CType(pictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, CatalogoToolStripMenuItem, PerfilToolStripMenuItem, SoporteToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(1204, 28)
        MenuStrip1.TabIndex = 0
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
        ' pictureBox
        ' 
        pictureBox.Image = My.Resources.Resources.FVII
        pictureBox.Location = New Point(86, 155)
        pictureBox.Name = "pictureBox"
        pictureBox.Size = New Size(266, 231)
        pictureBox.SizeMode = PictureBoxSizeMode.StretchImage
        pictureBox.TabIndex = 4
        pictureBox.TabStop = False
        ' 
        ' label
        ' 
        label.Location = New Point(388, 155)
        label.Name = "label"
        label.Size = New Size(213, 27)
        label.TabIndex = 10
        label.Text = "Nombre de Usuario"
        ' 
        ' Label1
        ' 
        Label1.Location = New Point(388, 235)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 27)
        Label1.TabIndex = 11
        Label1.Text = "Descripcion"
        ' 
        ' RichTextBox1
        ' 
        RichTextBox1.Location = New Point(401, 276)
        RichTextBox1.Name = "RichTextBox1"
        RichTextBox1.Size = New Size(727, 175)
        RichTextBox1.TabIndex = 12
        RichTextBox1.Text = ""
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(559, 152)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(125, 27)
        TextBox1.TabIndex = 13
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(426, 185)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 14
        Button1.Text = "Editar"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.Location = New Point(603, 455)
        Label2.Name = "Label2"
        Label2.Size = New Size(150, 50)
        Label2.TabIndex = 15
        Label2.Text = "Catalogo"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Columns.AddRange(New DataGridViewColumn() {Catalogo, RPG, SHOOTER, ESTRATEGIA})
        DataGridView1.Location = New Point(426, 508)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(545, 93)
        DataGridView1.TabIndex = 16
        ' 
        ' Catalogo
        ' 
        Catalogo.HeaderText = "Catalogo"
        Catalogo.MinimumWidth = 6
        Catalogo.Name = "Catalogo"
        Catalogo.Width = 125
        ' 
        ' RPG
        ' 
        RPG.HeaderText = "RPG"
        RPG.MinimumWidth = 6
        RPG.Name = "RPG"
        RPG.Width = 125
        ' 
        ' SHOOTER
        ' 
        SHOOTER.HeaderText = "SHOOTER"
        SHOOTER.MinimumWidth = 6
        SHOOTER.Name = "SHOOTER"
        SHOOTER.Width = 125
        ' 
        ' ESTRATEGIA
        ' 
        ESTRATEGIA.HeaderText = "ESTRATEGIA"
        ESTRATEGIA.MinimumWidth = 6
        ESTRATEGIA.Name = "ESTRATEGIA"
        ESTRATEGIA.Width = 125
        ' 
        ' Label3
        ' 
        Label3.Location = New Point(86, 80)
        Label3.Name = "Label3"
        Label3.Size = New Size(213, 27)
        Label3.TabIndex = 17
        Label3.Text = "Perfil"
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(972, 218)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 20
        Button2.Text = "Insertar"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(956, 169)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(125, 27)
        TextBox3.TabIndex = 19
        ' 
        ' Label4
        ' 
        Label4.Location = New Point(883, 139)
        Label4.Name = "Label4"
        Label4.Size = New Size(289, 27)
        Label4.TabIndex = 18
        Label4.Text = "Ingrese su cantidad de dinero de Cartera" & vbCrLf & vbCrLf
        ' 
        ' Form5
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1204, 777)
        Controls.Add(Button2)
        Controls.Add(TextBox3)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(Button1)
        Controls.Add(TextBox1)
        Controls.Add(RichTextBox1)
        Controls.Add(Label1)
        Controls.Add(label)
        Controls.Add(pictureBox)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        Name = "Form5"
        Text = "Form5"
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        CType(pictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatalogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PerfilToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SoporteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pictureBox As PictureBox
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Catalogo As DataGridViewTextBoxColumn
    Friend WithEvents RPG As DataGridViewTextBoxColumn
    Friend WithEvents SHOOTER As DataGridViewTextBoxColumn
    Friend WithEvents ESTRATEGIA As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
