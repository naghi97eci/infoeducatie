﻿Imports System.Data.SqlClient
Imports System.Data
Public Class Modifica_student
    Dim con As New SqlConnection
    Dim com As New SqlCommand
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
    Private Sub Modifica_student_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CenterToScreen()

        con.ConnectionString = ("Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Gestionare C.N.D.V. ( Mbook )\Resurse\Managementbook.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True")
        con.Open()
        If Studenti.DataGridView1.Rows.Count > 0 Then
            If Studenti.DataGridView1.SelectedRows.Count > 0 Then
                Dim intID As Integer = Studenti.DataGridView1.SelectedRows(0).Cells("IDDataGridViewTextBoxColumn").Value
                Dim adapt As New SqlDataAdapter("SELECT * FROM Studenti WHERE ID=" & intID, con)
                Dim dt As New DataTable
                adapt.Fill(dt)
                Me.Label1.Text = intID
                Me.TextBox2.Text = dt.Rows(0).Item("Nume")
                Me.TextBox3.Text = dt.Rows(0).Item("Prenume")
                Me.TextBox4.Text = dt.Rows(0).Item("Clasa")
                Me.TextBox5.Text = dt.Rows(0).Item("Data nasterii")
                Me.TextBox6.Text = dt.Rows(0).Item("Adresa")
                Me.TextBox7.Text = dt.Rows(0).Item("Numar tel :")
            End If
        End If
        Me.resetare()
    End Sub
    Private Sub resetare()
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        Dim adapt As New SqlDataAdapter("SELECT ID, Nume, Prenume, Clasa, [Data nasterii], Adresa, [Numar tel :] FROM Studenti ORDER BY id", con)
        Dim dt As New DataTable
        adapt.Fill(dt)
        Studenti.DataGridView1.DataSource = dt
        con.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Not con.State = ConnectionState.Open Then
            con.Open()
        End If
        com.Connection = con
        If Me.Label1.Tag & "" = "" Then
            com.CommandText = "UPDATE Studenti " & _
        "SET ID=" & Me.Label1.Text & _
        ", Nume='" & Me.TextBox2.Text & "'" & _
         ", Prenume='" & Me.TextBox3.Text & "'" & _
         ", Clasa='" & Me.TextBox4.Text & "'" & _
         ", [Data nasterii]='" & Me.TextBox5.Text & "'" & _
         ", Adresa='" & Me.TextBox6.Text & "'" & _
         ", [Numar tel :]='" & Me.TextBox7.Text & "'" & _
         "WHERE ID=" & Me.Label1.Text
            com.ExecuteNonQuery()
            Me.resetare()
        End If
    End Sub
    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class