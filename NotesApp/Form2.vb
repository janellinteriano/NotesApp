Imports System.Data.Common
Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class Form2
    Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Using connection As New SqlConnection(connectionString)
                connection.Open()
                Dim query = "SELECT Category_Name, Note_Title FROM NotesApp.dbo.Notes INNER JOIN NotesApp.dbo.Categories ON NotesApp.dbo.Notes.Category_ID = NotesApp.dbo.Categories.Category_ID"
                Dim dataAdapter = New SqlDataAdapter(query, connection)
                Dim table = New DataTable()
                dataAdapter.Fill(table)

                If table.Rows.Count > 0 Then
                    notesGrid.DataSource = table
                End If
            End Using
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.ActiveForm.Hide()
        Dim form1 As New Form1()
        form1.Show()
    End Sub

End Class