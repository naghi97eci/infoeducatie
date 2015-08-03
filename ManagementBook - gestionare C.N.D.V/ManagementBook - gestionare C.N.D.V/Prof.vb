Imports System.Data.SqlClient
Imports System.Data
Public Class Prof
    Dim con As New SqlConnection
    Dim com As New SqlCommand
    Private Sub Prof_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Profesori._Profesori' table. You can move, or remove it, as needed.
        Me.ProfesoriTableAdapter.Fill(Me.Profesori._Profesori)
        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Gestionare C.N.D.V. ( Mbook )\Resurse\Managementbook.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        con.Open()
        con.Close()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If Me.DataGridView1.Rows.Count > 0 Then
            If Me.DataGridView1.SelectedRows.Count > 0 Then
                Dim intID As Integer = Me.DataGridView1.SelectedRows(0).Cells("IDDataGridViewTextBoxColumn1").Value
                If Not con.State = ConnectionState.Open Then
                    con.Open()
                End If
                com.Connection = con
                com.CommandText = "DELETE FROM Profesori WHERE ID=" & intID
                com.ExecuteNonQuery()
                Me.resetare()
            End If
        End If
    End Sub
    Private Sub resetare()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim adapt As New SqlDataAdapter("SELECT ID, Nume, Prenume, Materie, Diriginte, Adresa, [Numar tel :] FROM Profesori ORDER BY id", con)
        Dim dt As New DataTable
        adapt.Fill(dt)
        Me.DataGridView1.DataSource = dt
        con.Close()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Adauga_Profesor.TopLevel = False
        Form1.Panel2.Controls.Add(Adauga_Profesor)
        Adauga_Profesor.BringToFront()
        Adauga_Profesor.Show()
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Modifica_profesor.TopLevel = False
        Form1.Panel2.Controls.Add(Modifica_profesor)
        Modifica_profesor.BringToFront()
        Modifica_profesor.Show()
    End Sub
    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class