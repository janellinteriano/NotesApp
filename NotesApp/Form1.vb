Imports System.Data.SqlClient
Imports System.Runtime.CompilerServices

Public Class Form1

    Dim connectionString As String = "Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Enabled = True
        ' populate combo box with category names
        Try
            Using connection As New SqlConnection(connectionString)

                connection.Open()

                Dim query As String = "SELECT Category_ID, Category_Name FROM NotesApp.dbo.Categories"

                Using command As New SqlCommand(query, connection)
                    Using reader As SqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            Dim categoryName As String = reader.GetString(1)
                            ComboBox1.Items.Add(categoryName)
                        End While
                    End Using
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show($"Error saving note: {ex.Message}", CStr(MessageBoxButtons.OK))
        End Try
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        Try

            If txtboxTitle.Text = String.Empty OrElse txtBox.Text = String.Empty Then
                MessageBox.Show($"Error saving note: Please Fill In Both Title And Description")
            Else
                btnSave.Enabled = True
                Using connection As New SqlConnection(connectionString)

                    connection.Open()
                    Dim query As String = "INSERT INTO NotesApp.dbo.Notes (Note_Description, Category_ID, Note_Title) VALUES (@Note_Description, @Category_ID, @Note_Title)"

                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@Note_Description", txtBox.Text)
                        command.Parameters.AddWithValue("@Category_ID", ComboBox1.SelectedIndex + 1)
                        command.Parameters.AddWithValue("@Note_Title", txtboxTitle.Text)
                        command.ExecuteNonQuery()
                    End Using
                End Using

                txtBox.Clear()
                txtboxTitle.Clear()
                ComboBox1.Text = "Assign Category"
            End If
        Catch ex As Exception
            MessageBox.Show($"Error saving note: {ex.Message}", CStr(MessageBoxButtons.OK))
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Dim form2 As New Form2()
        form2.Show()
    End Sub

End Class
