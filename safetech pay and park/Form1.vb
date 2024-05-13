Imports System.Threading
Imports MySql.Data.MySqlClient

Public Class form1
    Dim connectionString As String = "datasource=localhost;Database=safetech;Uid=root;Pwd=12345;"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text.Trim()
        Dim password As String = TextBox2.Text.Trim()

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim query As String = "SELECT COUNT(*) FROM Admin WHERE username = @username AND password = @password"
        Dim count As Integer

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)
                connection.Open()
                count = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        If count > 0 Then
            MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form2.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Reset textboxes
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Register.Show()
        Me.Hide()
    End Sub

    Private Sub form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
