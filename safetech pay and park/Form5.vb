Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class Form5

    Dim connectionString As String = "datasource=localhost;Database=safetech;Uid=root;Pwd=12345;"
    Dim selectedAllocationID As Integer = 0 ' Variable to store the selected allocation ID

    Private Sub PaymentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadAllocationIDs() ' Load allocation IDs into ComboBox1
        LoadPaymentData() ' Load Payment data into DataGridView
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem IsNot Nothing Then
            Dim allocationID As Integer = Integer.Parse(ComboBox1.SelectedItem.ToString())
            selectedAllocationID = allocationID ' Store the selected allocation ID
            FillFieldsBasedOnAllocation(allocationID) ' Fill other fields based on the selected allocation ID
        End If
    End Sub


    Private Sub FillFieldsBasedOnAllocation(allocationID As Integer)
        Dim query As String = "SELECT * FROM Allocation WHERE aid = @aid"
        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@aid", allocationID)
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        If reader.Read() Then
                            TextBox1.Text = reader("aid").ToString() ' Populate PID field
                            TextBox2.Text = reader("vehicle_no").ToString() ' Populate Vehicle No field
                            TextBox3.Text = reader("sid").ToString() ' Populate SID field
                            Dim fromTime As DateTime = Convert.ToDateTime(reader("from_time"))
                            Dim toTime As DateTime = Convert.ToDateTime(reader("to_time"))
                            Dim duration As TimeSpan = toTime - fromTime
                            Dim amount As Decimal = CalculateAmount(duration)
                            TextBox4.Text = amount.ToString() ' Populate Amount field
                        End If
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while fetching allocation data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function CalculateAmount(duration As TimeSpan) As Decimal
        ' Assuming a fixed rate per hour
        Dim ratePerHour As Decimal = 10 ' Change this rate according to your system
        Dim hours As Integer = duration.Hours
        Dim minutes As Integer = duration.Minutes
        If minutes > 0 Then
            hours += 1 ' Round up if there are any minutes
        End If
        Dim amount As Decimal = ratePerHour * hours
        Return amount
    End Function

    Private Sub LoadAllocationIDs()
        ComboBox1.Items.Clear() ' Clear existing items in ComboBox
        Dim query As String = "SELECT aid FROM Allocation"
        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        While reader.Read()
                            ComboBox1.Items.Add(reader("aid").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading allocation IDs.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Private Sub LoadPaymentData()
        Dim query As String = "SELECT * FROM Payment"
        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        Dim dt As New DataTable()
                        dt.Load(reader)
                        DataGridView1.DataSource = dt ' Bind data to DataGridView
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading payment data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Save data to Payment table
        Dim allocationID = selectedAllocationID
        Dim vehicleSlot = TextBox3.Text
        Dim vehicleNumber = TextBox2.Text
        Dim amount As Decimal

        If Decimal.TryParse(TextBox4.Text, amount) Then
            Dim pid = Integer.Parse(TextBox1.Text)
            ' Check if a payment entry already exists for the selected allocation ID
            If Not PaymentExistsForAllocation(allocationID) Then
                ' If no existing payment entry found, proceed to add new entry
                Dim query = "INSERT INTO Payment (pid, aid, sid, vehicle_number, amount) VALUES (@pid, @aid, @vehicleSlot, @vehicleNumber, @amount)"

                Try
                    Using connection As New MySqlConnection(connectionString)
                        Using command As New MySqlCommand(query, connection)
                            command.Parameters.AddWithValue("@pid", pid)
                            command.Parameters.AddWithValue("@aid", allocationID)
                            command.Parameters.AddWithValue("@vehicleSlot", vehicleSlot)
                            command.Parameters.AddWithValue("@vehicleNumber", vehicleNumber)
                            command.Parameters.AddWithValue("@amount", amount)
                            connection.Open()
                            command.ExecuteNonQuery()
                            MessageBox.Show("Payment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            ' Reset fields
                            ComboBox1.SelectedIndex = -1
                            TextBox1.Clear()
                            TextBox2.Clear()
                            TextBox3.Clear()
                            TextBox4.Clear()

                            LoadPaymentData() ' Reload Payment data into DataGridView
                        End Using
                    End Using
                Catch ex As Exception
                    MessageBox.Show("Error: " & ex.Message, "Error Adding Payment", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("Payment entry already exists for the selected allocation ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Invalid amount format. Please enter a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function PaymentExistsForAllocation(allocationID As Integer) As Boolean
        ' Check if a payment entry exists for the given allocation ID
        Dim query As String = "SELECT COUNT(*) FROM Payment WHERE aid = @aid"
        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@aid", allocationID)
                    connection.Open()
                    Dim count As Integer = Convert.ToInt32(command.ExecuteScalar())
                    Return count > 0 ' Return True if payment entry exists, False otherwise
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while checking for existing payment entry.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False ' Return False in case of an error
        End Try
    End Function


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Reset fields
        ComboBox1.SelectedIndex = -1
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Delete data from Payment table
        Dim allocationID As Integer = selectedAllocationID

        Dim query As String = "DELETE FROM Payment WHERE aid = @aid"

        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@aid", allocationID)
                    connection.Open()
                    command.ExecuteNonQuery()
                    MessageBox.Show("Payment deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ComboBox1.SelectedIndex = -1
                    TextBox1.Clear()
                    TextBox2.Clear()
                    TextBox3.Clear()
                    TextBox4.Clear()
                    LoadPaymentData() ' Reload Payment data into DataGridView
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Failed to delete payment. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub Form5_Activated(sender As Object, e As EventArgs) Handles MyBase.Activated
        LoadAllocationIDs()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ' Check if a valid row is clicked
        If e.RowIndex >= 0 AndAlso e.RowIndex < DataGridView1.Rows.Count Then
            ' Retrieve data from the selected row
            Dim selectedRow As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            If selectedRow.Cells("aid").Value IsNot Nothing Then
                Dim allocationID As Integer = Convert.ToInt32(selectedRow.Cells("aid").Value)
                ComboBox1.SelectedItem = allocationID.ToString() ' Select the allocation ID in ComboBox1
                FillFieldsBasedOnAllocation(allocationID) ' Fill other fields based on the selected allocation ID
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
