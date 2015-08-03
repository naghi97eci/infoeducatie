<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.ProgramToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.InchideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdministrareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ClaseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.StudentiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdaugaStudentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.ProfesoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdaugaProfesorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.OrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentiToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AdaugaOrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProfesoriToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.AdaugaOrarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.SituatieScolaraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AdaugaSituatieScolaraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.VizualizareToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentiToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProfesoriToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem
        Me.OrarToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.ProfesoriToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.StudentiToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem
        Me.SituatieScolaraToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.UtilizatoriToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.UtilizatoriToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem
        Me.Button9 = New System.Windows.Forms.Button
        Me.Button8 = New System.Windows.Forms.Button
        Me.Button7 = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.Button5 = New System.Windows.Forms.Button
        Me.Button4 = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btninchide = New System.Windows.Forms.Button
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Button10 = New System.Windows.Forms.Button
        Me.Button11 = New System.Windows.Forms.Button
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.UtilizatoriBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Utilizator = New ManagementBook___gestionare_C.N.D.V.Utilizator
        Me.UtilizatoriTableAdapter = New ManagementBook___gestionare_C.N.D.V.UtilizatorTableAdapters.UtilizatoriTableAdapter
        Me.Button15 = New System.Windows.Forms.Button
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.ComboBox1 = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.UtilizatoriBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button13 = New System.Windows.Forms.Button
        Me.Button12 = New System.Windows.Forms.Button
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.StatusStrip1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.UtilizatoriBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Utilizator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.UtilizatoriBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.Gray
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.ToolStripStatusLabel3, Me.ToolStripStatusLabel4})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 578)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(800, 22)
        Me.StatusStrip1.TabIndex = 0
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(116, 17)
        Me.ToolStripStatusLabel1.Text = "Gestionarea C.N.D.V."
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Margin = New System.Windows.Forms.Padding(30, 3, 0, 2)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(60, 17)
        Me.ToolStripStatusLabel2.Text = "Utilizator :"
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(34, 17)
        Me.ToolStripStatusLabel3.Text = "         "
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Margin = New System.Windows.Forms.Padding(30, 3, 0, 2)
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(121, 17)
        Me.ToolStripStatusLabel4.Text = "ToolStripStatusLabel4"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.LightSeaGreen
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProgramToolStripMenuItem, Me.AdministrareToolStripMenuItem, Me.VizualizareToolStripMenuItem, Me.UtilizatoriToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ProgramToolStripMenuItem
        '
        Me.ProgramToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ProgramToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.InchideToolStripMenuItem})
        Me.ProgramToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ProgramToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ProgramToolStripMenuItem.Name = "ProgramToolStripMenuItem"
        Me.ProgramToolStripMenuItem.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded
        Me.ProgramToolStripMenuItem.ShowShortcutKeys = False
        Me.ProgramToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.ProgramToolStripMenuItem.Text = "Program"
        Me.ProgramToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ProgramToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(103, 6)
        '
        'InchideToolStripMenuItem
        '
        Me.InchideToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.InchideToolStripMenuItem.MergeIndex = 0
        Me.InchideToolStripMenuItem.Name = "InchideToolStripMenuItem"
        Me.InchideToolStripMenuItem.ShowShortcutKeys = False
        Me.InchideToolStripMenuItem.Size = New System.Drawing.Size(106, 22)
        Me.InchideToolStripMenuItem.Text = "Inchide"
        Me.InchideToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay
        '
        'AdministrareToolStripMenuItem
        '
        Me.AdministrareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.ClaseToolStripMenuItem, Me.ToolStripSeparator2, Me.StudentiToolStripMenuItem, Me.ProfesoriToolStripMenuItem, Me.OrarToolStripMenuItem, Me.SituatieScolaraToolStripMenuItem})
        Me.AdministrareToolStripMenuItem.Name = "AdministrareToolStripMenuItem"
        Me.AdministrareToolStripMenuItem.Size = New System.Drawing.Size(87, 20)
        Me.AdministrareToolStripMenuItem.Text = "Administrare"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'ClaseToolStripMenuItem
        '
        Me.ClaseToolStripMenuItem.Name = "ClaseToolStripMenuItem"
        Me.ClaseToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ClaseToolStripMenuItem.Text = "Clase"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(150, 6)
        '
        'StudentiToolStripMenuItem
        '
        Me.StudentiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdaugaStudentToolStripMenuItem})
        Me.StudentiToolStripMenuItem.Name = "StudentiToolStripMenuItem"
        Me.StudentiToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.StudentiToolStripMenuItem.Text = "Studenti"
        '
        'AdaugaStudentToolStripMenuItem
        '
        Me.AdaugaStudentToolStripMenuItem.Name = "AdaugaStudentToolStripMenuItem"
        Me.AdaugaStudentToolStripMenuItem.Size = New System.Drawing.Size(158, 22)
        Me.AdaugaStudentToolStripMenuItem.Text = "Adauga student"
        '
        'ProfesoriToolStripMenuItem
        '
        Me.ProfesoriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdaugaProfesorToolStripMenuItem})
        Me.ProfesoriToolStripMenuItem.Name = "ProfesoriToolStripMenuItem"
        Me.ProfesoriToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.ProfesoriToolStripMenuItem.Text = "Profesori"
        '
        'AdaugaProfesorToolStripMenuItem
        '
        Me.AdaugaProfesorToolStripMenuItem.Name = "AdaugaProfesorToolStripMenuItem"
        Me.AdaugaProfesorToolStripMenuItem.Size = New System.Drawing.Size(162, 22)
        Me.AdaugaProfesorToolStripMenuItem.Text = "Adauga profesor"
        '
        'OrarToolStripMenuItem
        '
        Me.OrarToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentiToolStripMenuItem1, Me.ProfesoriToolStripMenuItem1})
        Me.OrarToolStripMenuItem.Name = "OrarToolStripMenuItem"
        Me.OrarToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.OrarToolStripMenuItem.Text = "Orar"
        '
        'StudentiToolStripMenuItem1
        '
        Me.StudentiToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdaugaOrarToolStripMenuItem1})
        Me.StudentiToolStripMenuItem1.Name = "StudentiToolStripMenuItem1"
        Me.StudentiToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.StudentiToolStripMenuItem1.Text = "Studenti"
        '
        'AdaugaOrarToolStripMenuItem1
        '
        Me.AdaugaOrarToolStripMenuItem1.Name = "AdaugaOrarToolStripMenuItem1"
        Me.AdaugaOrarToolStripMenuItem1.Size = New System.Drawing.Size(139, 22)
        Me.AdaugaOrarToolStripMenuItem1.Text = "Adauga orar"
        '
        'ProfesoriToolStripMenuItem1
        '
        Me.ProfesoriToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdaugaOrarToolStripMenuItem})
        Me.ProfesoriToolStripMenuItem1.Name = "ProfesoriToolStripMenuItem1"
        Me.ProfesoriToolStripMenuItem1.Size = New System.Drawing.Size(121, 22)
        Me.ProfesoriToolStripMenuItem1.Text = "Profesori"
        '
        'AdaugaOrarToolStripMenuItem
        '
        Me.AdaugaOrarToolStripMenuItem.Name = "AdaugaOrarToolStripMenuItem"
        Me.AdaugaOrarToolStripMenuItem.Size = New System.Drawing.Size(139, 22)
        Me.AdaugaOrarToolStripMenuItem.Text = "Adauga orar"
        '
        'SituatieScolaraToolStripMenuItem
        '
        Me.SituatieScolaraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AdaugaSituatieScolaraToolStripMenuItem})
        Me.SituatieScolaraToolStripMenuItem.Name = "SituatieScolaraToolStripMenuItem"
        Me.SituatieScolaraToolStripMenuItem.Size = New System.Drawing.Size(153, 22)
        Me.SituatieScolaraToolStripMenuItem.Text = "Situatie scolara"
        '
        'AdaugaSituatieScolaraToolStripMenuItem
        '
        Me.AdaugaSituatieScolaraToolStripMenuItem.Name = "AdaugaSituatieScolaraToolStripMenuItem"
        Me.AdaugaSituatieScolaraToolStripMenuItem.Size = New System.Drawing.Size(196, 22)
        Me.AdaugaSituatieScolaraToolStripMenuItem.Text = "Adauga situatie scolara"
        '
        'VizualizareToolStripMenuItem
        '
        Me.VizualizareToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentiToolStripMenuItem2, Me.ProfesoriToolStripMenuItem2, Me.OrarToolStripMenuItem1, Me.SituatieScolaraToolStripMenuItem1})
        Me.VizualizareToolStripMenuItem.Name = "VizualizareToolStripMenuItem"
        Me.VizualizareToolStripMenuItem.Size = New System.Drawing.Size(74, 20)
        Me.VizualizareToolStripMenuItem.Text = "Vizualizare"
        '
        'StudentiToolStripMenuItem2
        '
        Me.StudentiToolStripMenuItem2.Name = "StudentiToolStripMenuItem2"
        Me.StudentiToolStripMenuItem2.Size = New System.Drawing.Size(153, 22)
        Me.StudentiToolStripMenuItem2.Text = "Studenti"
        '
        'ProfesoriToolStripMenuItem2
        '
        Me.ProfesoriToolStripMenuItem2.Name = "ProfesoriToolStripMenuItem2"
        Me.ProfesoriToolStripMenuItem2.Size = New System.Drawing.Size(153, 22)
        Me.ProfesoriToolStripMenuItem2.Text = "Profesori"
        '
        'OrarToolStripMenuItem1
        '
        Me.OrarToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfesoriToolStripMenuItem3, Me.StudentiToolStripMenuItem3})
        Me.OrarToolStripMenuItem1.Name = "OrarToolStripMenuItem1"
        Me.OrarToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.OrarToolStripMenuItem1.Text = "Orar"
        '
        'ProfesoriToolStripMenuItem3
        '
        Me.ProfesoriToolStripMenuItem3.Name = "ProfesoriToolStripMenuItem3"
        Me.ProfesoriToolStripMenuItem3.Size = New System.Drawing.Size(121, 22)
        Me.ProfesoriToolStripMenuItem3.Text = "Profesori"
        '
        'StudentiToolStripMenuItem3
        '
        Me.StudentiToolStripMenuItem3.Name = "StudentiToolStripMenuItem3"
        Me.StudentiToolStripMenuItem3.Size = New System.Drawing.Size(121, 22)
        Me.StudentiToolStripMenuItem3.Text = "Studenti"
        '
        'SituatieScolaraToolStripMenuItem1
        '
        Me.SituatieScolaraToolStripMenuItem1.Name = "SituatieScolaraToolStripMenuItem1"
        Me.SituatieScolaraToolStripMenuItem1.Size = New System.Drawing.Size(153, 22)
        Me.SituatieScolaraToolStripMenuItem1.Text = "Situatie scolara"
        '
        'UtilizatoriToolStripMenuItem
        '
        Me.UtilizatoriToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UtilizatoriToolStripMenuItem1})
        Me.UtilizatoriToolStripMenuItem.Name = "UtilizatoriToolStripMenuItem"
        Me.UtilizatoriToolStripMenuItem.Size = New System.Drawing.Size(89, 20)
        Me.UtilizatoriToolStripMenuItem.Text = "Accesibilitate"
        '
        'UtilizatoriToolStripMenuItem1
        '
        Me.UtilizatoriToolStripMenuItem1.Name = "UtilizatoriToolStripMenuItem1"
        Me.UtilizatoriToolStripMenuItem1.Size = New System.Drawing.Size(124, 22)
        Me.UtilizatoriToolStripMenuItem1.Text = "Utilizatori"
        '
        'Button9
        '
        Me.Button9.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.adaugaorar
        Me.Button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button9.FlatAppearance.BorderSize = 0
        Me.Button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button9.Location = New System.Drawing.Point(937, -1)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(95, 85)
        Me.Button9.TabIndex = 4
        Me.Button9.Text = "Adauga orar profesor"
        Me.Button9.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button9.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.Adaugaorarstudenti
        Me.Button8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button8.FlatAppearance.BorderSize = 0
        Me.Button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button8.Location = New System.Drawing.Point(847, -1)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(95, 85)
        Me.Button8.TabIndex = 4
        Me.Button8.Text = "Adauga orar student"
        Me.Button8.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.Adaugaprofesor
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Location = New System.Drawing.Point(755, -1)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(95, 85)
        Me.Button7.TabIndex = 4
        Me.Button7.Text = "Adauga profesor"
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.adaugastudent
        Me.Button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Location = New System.Drawing.Point(664, -1)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(95, 85)
        Me.Button6.TabIndex = 4
        Me.Button6.Text = "Adauga student"
        Me.Button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.orarstudenti
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button5.FlatAppearance.BorderSize = 0
        Me.Button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(532, -1)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(95, 85)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Orar studenti"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.orar
        Me.Button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button4.FlatAppearance.BorderSize = 0
        Me.Button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.Location = New System.Drawing.Point(443, -1)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(95, 85)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Orar profesori"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.situatiescolara
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(352, -1)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(95, 85)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Situatie scolara"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.profesori
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(261, -1)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(95, 85)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Profesori"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.studenti
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.Button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(169, -1)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 85)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Studenti"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btninchide
        '
        Me.btninchide.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.Inchidere
        Me.btninchide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btninchide.FlatAppearance.BorderSize = 0
        Me.btninchide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSeaGreen
        Me.btninchide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke
        Me.btninchide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninchide.ForeColor = System.Drawing.Color.Black
        Me.btninchide.Location = New System.Drawing.Point(0, -1)
        Me.btninchide.Name = "btninchide"
        Me.btninchide.Size = New System.Drawing.Size(95, 85)
        Me.btninchide.TabIndex = 0
        Me.btninchide.Text = "Inchide"
        Me.btninchide.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btninchide.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.Gainsboro
        Me.Panel1.Controls.Add(Me.Button9)
        Me.Panel1.Controls.Add(Me.Button8)
        Me.Panel1.Controls.Add(Me.Button7)
        Me.Panel1.Controls.Add(Me.Button6)
        Me.Panel1.Controls.Add(Me.Button5)
        Me.Panel1.Controls.Add(Me.Button4)
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.btninchide)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 24)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 87)
        Me.Panel1.TabIndex = 2
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button10.FlatAppearance.BorderSize = 0
        Me.Button10.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button10.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.Button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(1266, 0)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(27, 24)
        Me.Button10.TabIndex = 32
        Me.Button10.Text = "__"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button11.FlatAppearance.BorderSize = 0
        Me.Button11.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button11.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.Button11.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button11.Location = New System.Drawing.Point(1290, 0)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(27, 24)
        Me.Button11.TabIndex = 31
        Me.Button11.Text = " X"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.Gray_plain_website_background
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Panel2.Location = New System.Drawing.Point(0, 111)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1378, 631)
        Me.Panel2.TabIndex = 34
        Me.Panel2.TabStop = True
        '
        'UtilizatoriBindingSource
        '
        Me.UtilizatoriBindingSource.DataMember = "Utilizatori"
        Me.UtilizatoriBindingSource.DataSource = Me.Utilizator
        '
        'Utilizator
        '
        Me.Utilizator.DataSetName = "Utilizator"
        Me.Utilizator.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UtilizatoriTableAdapter
        '
        Me.UtilizatoriTableAdapter.ClearBeforeFill = True
        '
        'Button15
        '
        Me.Button15.BackColor = System.Drawing.Color.LightSeaGreen
        Me.Button15.FlatAppearance.BorderSize = 0
        Me.Button15.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray
        Me.Button15.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumTurquoise
        Me.Button15.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button15.Location = New System.Drawing.Point(1210, 0)
        Me.Button15.Name = "Button15"
        Me.Button15.Size = New System.Drawing.Size(27, 24)
        Me.Button15.TabIndex = 32
        Me.Button15.Text = " X"
        Me.Button15.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.PictureBox1)
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Location = New System.Drawing.Point(388, 166)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(348, 183)
        Me.Panel3.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button12)
        Me.GroupBox1.Controls.Add(Me.Button13)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(116, 14)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 154)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Autentificare"
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(84, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBox1.Size = New System.Drawing.Size(127, 24)
        Me.TextBox1.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.DataSource = Me.UtilizatoriBindingSource1
        Me.ComboBox1.DisplayMember = "Utilizator"
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(84, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 26)
        Me.ComboBox1.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 18)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Utlizator :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 18)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Parola :"
        '
        'UtilizatoriBindingSource1
        '
        Me.UtilizatoriBindingSource1.DataMember = "Utilizatori"
        Me.UtilizatoriBindingSource1.DataSource = Me.Utilizator
        '
        'Button13
        '
        Me.Button13.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button13.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button13.Image = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.dT8xnAqAc_copy
        Me.Button13.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button13.Location = New System.Drawing.Point(118, 112)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(93, 42)
        Me.Button13.TabIndex = 1
        Me.Button13.Text = "    Renunt"
        Me.Button13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button13.UseVisualStyleBackColor = True
        '
        'Button12
        '
        Me.Button12.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.Button12.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White
        Me.Button12.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button12.Image = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.check_mark_3_512_copy
        Me.Button12.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button12.Location = New System.Drawing.Point(19, 112)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(93, 42)
        Me.Button12.TabIndex = 5
        Me.Button12.Text = "     Accept"
        Me.Button12.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.COMODO__v4_Icon_copy1
        Me.PictureBox1.Location = New System.Drawing.Point(10, 14)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 154)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImage = Global.ManagementBook___gestionare_C.N.D.V.My.Resources.Resources.Gray_plain_website_background
        Me.ClientSize = New System.Drawing.Size(800, 600)
        Me.Controls.Add(Me.Button15)
        Me.Controls.Add(Me.Button10)
        Me.Controls.Add(Me.Button11)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.UtilizatoriBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Utilizator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.UtilizatoriBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ProgramToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InchideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btninchide As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Button10 As System.Windows.Forms.Button
    Friend WithEvents Button11 As System.Windows.Forms.Button
    Friend WithEvents AdministrareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClaseToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentiToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SituatieScolaraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdaugaStudentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdaugaProfesorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentiToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdaugaOrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoriToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdaugaOrarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AdaugaSituatieScolaraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents VizualizareToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentiToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoriToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OrarToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProfesoriToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents StudentiToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SituatieScolaraToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilizatoriToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents UtilizatoriToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripStatusLabel1 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Utilizator As ManagementBook___gestionare_C.N.D.V.Utilizator
    Friend WithEvents UtilizatoriBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents UtilizatoriTableAdapter As ManagementBook___gestionare_C.N.D.V.UtilizatorTableAdapters.UtilizatoriTableAdapter
    Friend WithEvents Button15 As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button12 As System.Windows.Forms.Button
    Friend WithEvents Button13 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents UtilizatoriBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
