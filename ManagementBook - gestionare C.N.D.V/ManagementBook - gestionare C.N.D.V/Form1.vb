Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Utilizator.Utilizatori' table. You can move, or remove it, as needed.
        Me.UtilizatoriTableAdapter.Fill(Me.Utilizator.Utilizatori)
        Panel1.Visible = False
        MenuStrip1.Enabled = False
        ToolStripStatusLabel4.Visible = False

        Panel3.Visible = True

        Me.Button11.Location = New Point(Me.Width - 35, Me.MenuStrip1.Location.Y)
        Me.Button10.Location = New Point(Me.Width - 62, Me.MenuStrip1.Location.Y)
        Button9.Location = New Point(Panel1.Width - 110, Button1.Location.Y)
        Button8.Location = New Point(Panel1.Width - 205, Button1.Location.Y)
        Button7.Location = New Point(Panel1.Width - 300, Button1.Location.Y)
        Button6.Location = New Point(Panel1.Width - 395, Button1.Location.Y)

    End Sub
    Private Sub InchideToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InchideToolStripMenuItem.Click
        Me.Close()
    End Sub
    Private Sub btninchide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btninchide.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Studenti.TopLevel = False
        Me.Panel2.Controls.Add(Studenti)
        Studenti.Size = Me.Panel2.Size
        Studenti.Height = Me.Panel2.Height - "111"
        Studenti.Show()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Prof.TopLevel = False
        Me.Panel2.Controls.Add(Prof)
        Prof.BringToFront()
        Studenti.Height = Me.Panel2.Height
        Prof.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        SitScolara.Show()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Orar_Profesori.Show()
        Orar_Profesori.BringToFront()
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Orar_studenti.Show()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        
        Adauga_Student.BringToFront()
        Adauga_Student.Show()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
       
        Adauga_Profesor.BringToFront()
        Adauga_Profesor.Show()
    End Sub
    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        Modificare_orar_prof.Show()
    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Adauga_Ora_Prof.Show()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripStatusLabel4.Text = DateAndTime.DateString & "  " & DateAndTime.TimeOfDay
    End Sub
    Private Sub Button11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button11.Click
        Me.Close()
    End Sub
    Private Sub Button10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button10.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub ProfileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfileToolStripMenuItem.Click
        Administrare_Profile.Show()
    End Sub
    Private Sub ClaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClaseToolStripMenuItem.Click
        Administrare_clase.Show()
    End Sub
    Private Sub AdaugaStudentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdaugaStudentToolStripMenuItem.Click
        Adauga_Student.Show()
    End Sub
    Private Sub AdaugaProfesorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdaugaProfesorToolStripMenuItem.Click
        Adauga_Profesor.Show()
    End Sub
    Private Sub AdaugaOrarToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdaugaOrarToolStripMenuItem1.Click
        Modificare_orar_prof.Show()
    End Sub
    Private Sub AdaugaOrarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdaugaOrarToolStripMenuItem.Click
        Adauga_Ora_Prof.Show()

    End Sub
    Private Sub AdaugaSituatieScolaraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AdaugaSituatieScolaraToolStripMenuItem.Click
        Adauga_situatie_scolara.Show()
    End Sub
    Private Sub UtilizatoriToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UtilizatoriToolStripMenuItem1.Click
        Utilizatori.Show()
    End Sub
    Private Sub Button12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub StudentiToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentiToolStripMenuItem2.Click
        Studenti.TopLevel = False
        Me.Panel2.Controls.Add(Studenti)
        Studenti.BringToFront()
        Studenti.Height = Me.Panel2.Height - "111"
        Studenti.Show()
    End Sub
    Private Sub ProfesoriToolStripMenuItem2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfesoriToolStripMenuItem2.Click
        Prof.TopLevel = False
        Me.Panel2.Controls.Add(Prof)
        Prof.BringToFront()
        Prof.Size = Panel2.Size




        Prof.Show()
    End Sub
    Private Sub Button12_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
  
    Private Sub ProfesoriToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfesoriToolStripMenuItem3.Click
        Orar_Profesori.Show()
    End Sub
    Private Sub StudentiToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StudentiToolStripMenuItem3.Click
        Orar_studenti.Show()
    End Sub
    Private Sub SituatieScolaraToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SituatieScolaraToolStripMenuItem1.Click
        SitScolara.Show()
    End Sub

    Private Sub Button15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button15.Click
        
    End Sub

    Private Sub Panel3_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint


    End Sub

    Private Sub Button14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Normal

    End Sub

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Panel3_Paint_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub Button13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button13.Click
        Me.Close()

    End Sub

    Private Sub Button12_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button12.Click
        Dim add = Me.UtilizatoriTableAdapter.Login(TextBox1.Text, ComboBox1.Text)
        If add Then
            Panel1.Visible = True
            MenuStrip1.Enabled = True
            ToolStripStatusLabel4.Visible = True
            Panel3.Visible = False
        Else
            If TextBox1.Text = "" Then
                MsgBox("Nu ati completat campul pentru 'Parola",ms
            End If

        End If
    End Sub
End Class
