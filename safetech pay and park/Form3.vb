Imports MySql.Data.MySqlClient

Public Class Form3
    Dim connectionString As String = "datasource=localhost;Database=safetech;Uid=root;Pwd=12345;"

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim slotID As Integer
        If Not Integer.TryParse(TextBox1.Text.Trim(), slotID) Then
            MessageBox.Show("Please enter a valid slot ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim slotType As String = ComboBox1.Text.Trim()
        Dim floor As String = ComboBox2.Text.Trim()

        If slotType = "" Or floor = "" Then
            MessageBox.Show("Please select slot type and floor.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If AddSlot(slotID, slotType, floor) Then
            MessageBox.Show("Slot added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TextBox1.Clear()
            ComboBox1.SelectedIndex = -1
            ComboBox2.SelectedIndex = -1
            LoadSlotsIntoDataGridView()
        Else
            MessageBox.Show("Failed to add slot. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function AddSlot(slotID As Integer, slotType As String, floor As String) As Boolean
        Dim query As String = "INSERT INTO Slot (sid, slottype, floor, status) VALUES (@slotID, @slotType, @floor, 'available')"

        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@slotID", slotID)
                    command.Parameters.AddWithValue("@slotType", slotType)
                    command.Parameters.AddWithValue("@floor", floor)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            ' Handle any exceptions that may occur during slot addition
            MessageBox.Show("An error occurred while adding the slot. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox1 with slot types
        ComboBox1.Items.Add("Car")
        ComboBox1.Items.Add("Motorcycle")
        ComboBox1.Items.Add("Electric Scooter")
        For floor As Integer = 1 To 4
            ComboBox2.Items.Add(floor.ToString())
        Next
        LoadSlotsIntoDataGridView()
    End Sub

    Public Sub LoadSlotsIntoDataGridView()
        Dim query As String = "SELECT * FROM Slot"

        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        DataGridView1.DataSource = dt
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading slots from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Clear the text box and reset combo boxes
        TextBox1.Clear()
        ComboBox1.SelectedIndex = -1
        ComboBox2.SelectedIndex = -1
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim slotID As Integer
        If Not Integer.TryParse(TextBox1.Text.Trim(), slotID) Then
            MessageBox.Show("Please enter a valid slot ID to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If MessageBox.Show("Are you sure you want to delete this slot?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DeleteSlot(slotID) Then
                MessageBox.Show("Slot deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LoadSlotsIntoDataGridView() ' Refresh DataGridView after deleting slot
                ' Clear the text box and reset combo boxes
                TextBox1.Clear()
                ComboBox1.SelectedIndex = -1
                ComboBox2.SelectedIndex = -1
            Else
                MessageBox.Show("Failed to delete slot. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Function DeleteSlot(slotID As Integer) As Boolean
        Dim query As String = "DELETE FROM Slot WHERE sid = @slotID"

        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@slotID", slotID)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            ' Handle any exceptions that may occur during slot deletion
            MessageBox.Show("An error occurred while deleting the slot. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if the clicked cell is not a header and if there is at least one row
        If e.RowIndex >= 0 AndAlso DataGridView1.Rows.Count > 0 Then
            ' Get the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)

            ' Populate the TextBox and ComboBox controls with the values from the selected row
            TextBox1.Text = selectedRow.Cells("sid").Value.ToString()
            ComboBox1.SelectedItem = selectedRow.Cells("slottype").Value.ToString()
            ComboBox2.SelectedItem = selectedRow.Cells("floor").Value.ToString()
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then ' Check if an item is selected
            ComboBox2.Items.Clear() ' Clear the existing floor options

            ' Add floor options based on the selected slot type
            Select Case ComboBox1.SelectedItem.ToString()
                Case "Car"
                    ComboBox2.Items.Add("3")
                    ComboBox2.Items.Add("4")
                Case "Motorcycle"
                    ComboBox2.Items.Add("1")
                    ComboBox2.Items.Add("2")
                Case "Electric Scooter"
                    ComboBox2.Items.Add("2")
            End Select

            ComboBox2.SelectedIndex = 0 ' Select the first floor option by default
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()
    End Sub

End Class

