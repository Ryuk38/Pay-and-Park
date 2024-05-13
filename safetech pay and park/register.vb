Imports MySql.Data.MySqlClient

Public Class Register
    Dim connectionString As String = "datasource=localhost;Database=safetech;Uid=root;Pwd=12345;"

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username = TextBox1.Text.Trim
        Dim password = TextBox2.Text.Trim

        If username = "" Or password = "" Then
            MessageBox.Show("Please enter both username and password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If IsUsernameTaken(username) Then
            MessageBox.Show("Username is already taken. Please choose another one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If RegisterAdmin(username, password) Then
            MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Optionally, close the registration form after successful registration
            TextBox1.Text = ""
            TextBox2.Text = ""
        Else
            MessageBox.Show("Registration failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function IsUsernameTaken(username As String) As Boolean
        Dim query As String = "SELECT COUNT(*) FROM Admin WHERE username = @username"
        Dim count As Integer

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                connection.Open()
                count = Convert.ToInt32(command.ExecuteScalar())
            End Using
        End Using

        Return count > 0
    End Function

    Private Function RegisterAdmin(username As String, password As String) As Boolean
        Dim query As String = "INSERT INTO Admin (username, password) VALUES (@username, @password)"

        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@username", username)
                    command.Parameters.AddWithValue("@password", password)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            ' Handle any exceptions that may occur during registration
            MessageBox.Show("An error occurred while registering. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        form1.Show()
        Me.Hide()
    End Sub
End Class