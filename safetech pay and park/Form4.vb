Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class Form4



    Dim connectionString As String = "datasource=localhost;Database=safetech;Uid=root;Pwd=12345;"

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Populate ComboBox1 with vehicle types
        ComboBox1.Items.Add("Car")
        ComboBox1.Items.Add("Motorcycle")
        ComboBox1.Items.Add("Electric Scooter")

        ' Load available slots into ComboBox2 based on selected vehicle type
        ComboBox1.SelectedIndex = 0 ' Select Car by default
        LoadSlotsIntoComboBox()

        ' Populate ComboBox3 and ComboBox4 with time options
        ' Add time options for ComboBox3 and ComboBox4
        For hour As Integer = 8 To 20 ' From 8 AM to 8 PM
            For Each Minute As String In New String() {"00", "30"} ' Minutes 00 and 30
                Dim time As String = hour.ToString("00") & ":" & Minute
                ComboBox3.Items.Add(time)
                ComboBox4.Items.Add(time)
            Next
        Next

        ' Load allocation data into DataGridView
        LoadAllocationData()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        ' Load available slots into ComboBox2 based on selected vehicle type
        LoadSlotsIntoComboBox()
    End Sub

    Private Sub LoadSlotsIntoComboBox()
        Dim selectedSlotType As String = ComboBox1.SelectedItem.ToString()

        Dim query As String = "SELECT sid FROM Slot WHERE slottype = @slotType AND status = 'available'"
        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@slotType", selectedSlotType)
                    connection.Open()
                    Using reader As MySqlDataReader = command.ExecuteReader()
                        ComboBox2.Items.Clear()
                        While reader.Read()
                            ComboBox2.Items.Add(reader("sid").ToString())
                        End While
                    End Using
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while loading slots from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Validate input fields
        If Not ValidateInput() Then
            Return
        End If

        ' Insert allocation record into database
        Dim allocationID As Integer = Integer.Parse(TextBox1.Text.Trim())
        Dim slotID As Integer = Integer.Parse(ComboBox2.SelectedItem.ToString())
        Dim vehicleType As String = ComboBox1.SelectedItem.ToString()
        Dim vehicleNo As String = TextBox2.Text.Trim()

        Dim selectedFromTime As String = ComboBox3.SelectedItem.ToString()
        Dim selectedToTime As String = ComboBox4.SelectedItem.ToString()

        Dim fromTime As DateTime = DateTime.ParseExact(selectedFromTime, "HH:mm", CultureInfo.InvariantCulture)
        Dim toTime As DateTime = DateTime.ParseExact(selectedToTime, "HH:mm", CultureInfo.InvariantCulture)

        Dim allocationDate As Date = Date.Today ' Get today's date

        If AddAllocation(allocationID, slotID, vehicleType, vehicleNo, fromTime, toTime, allocationDate) Then
            MessageBox.Show("Allocation added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Clear input fields
            TextBox1.Clear()
            ComboBox1.SelectedIndex = 0 ' Select Car by default
            TextBox2.Clear()
            ComboBox2.Items.Clear()
            ComboBox3.SelectedIndex = -1 ' Clear ComboBox3 selection
            ComboBox4.SelectedIndex = -1 ' Clear ComboBox4 selection
            ' Load available slots into ComboBox2
            LoadSlotsIntoComboBox()
            ' Refresh DataGridView
            LoadAllocationData()
            Form3.LoadSlotsIntoDataGridView()
        Else
            MessageBox.Show("Failed to add allocation. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Function ValidateInput() As Boolean
        If String.IsNullOrWhiteSpace(TextBox1.Text.Trim()) OrElse
           String.IsNullOrWhiteSpace(TextBox2.Text.Trim()) OrElse
           ComboBox1.SelectedItem Is Nothing OrElse
           ComboBox2.SelectedItem Is Nothing Then
            MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
        Return True
    End Function

    Private Function AddAllocation(allocationID As Integer, slotID As Integer, vehicleType As String, vehicleNo As String, fromTime As DateTime, toTime As DateTime, allocationDate As Date) As Boolean
        Dim query As String = "INSERT INTO Allocation (aid, sid, vehicle_type, vehicle_no, from_time, to_time, date) VALUES (@aid, @sid, @vehicleType, @vehicleNo, @fromTime, @toTime, @allocationDate)"

        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@aid", allocationID)
                    command.Parameters.AddWithValue("@sid", slotID)
                    command.Parameters.AddWithValue("@vehicleType", vehicleType)
                    command.Parameters.AddWithValue("@vehicleNo", vehicleNo)
                    command.Parameters.AddWithValue("@fromTime", fromTime)
                    command.Parameters.AddWithValue("@toTime", toTime)
                    command.Parameters.AddWithValue("@allocationDate", allocationDate)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            ' Update Slot status to 'allocated'
            UpdateSlotStatus(slotID, "allocated")
            Return True
        Catch ex As Exception
            ' Handle any exceptions that may occur during allocation addition
            MessageBox.Show("An error occurred while adding the allocation. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub UpdateSlotStatus(slotID As Integer, status As String)
        Dim query As String = "UPDATE Slot SET status = @status WHERE sid = @sid"

        Try
            Using connection As New MySqlConnection(connectionString)
                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@status", status)
                    command.Parameters.AddWithValue("@sid", slotID)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while updating slot status.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub LoadAllocationData()
        Dim query As String = "SELECT aid, sid, vehicle_type, vehicle_no, TIME_FORMAT(from_time, '%H:%i') AS from_time, TIME_FORMAT(to_time, '%H:%i') AS to_time, date FROM Allocation"

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
            MessageBox.Show("An error occurred while loading allocation data from the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Clear input fields
        TextBox1.Clear()
        ComboBox1.SelectedIndex = 0 ' Select Car by default
        TextBox2.Clear()
        ComboBox2.Items.Clear()
        ComboBox3.SelectedIndex = -1 ' Clear ComboBox3 selection
        ComboBox4.SelectedIndex = -1 ' Clear ComboBox4 selection
    End Sub

    Private Function DeleteAllocation(allocationID As Integer, slotID As Integer) As Boolean
        Dim queryDeleteAllocation As String = "DELETE FROM Allocation WHERE aid = @allocationID"
        Dim queryUpdateSlotStatus As String = "UPDATE Slot SET status = 'available' WHERE sid = @slotID"

        Try
            Using connection As New MySqlConnection(connectionString)
                ' Start a transaction to ensure both deletion and slot status update are executed atomically
                connection.Open()
                Using transaction As MySqlTransaction = connection.BeginTransaction()
                    Try
                        ' Delete the allocation record
                        Using commandDeleteAllocation As New MySqlCommand(queryDeleteAllocation, connection, transaction)
                            commandDeleteAllocation.Parameters.AddWithValue("@allocationID", allocationID)
                            commandDeleteAllocation.ExecuteNonQuery()
                        End Using

                        ' Update the status of the slot to 'available'
                        Using commandUpdateSlotStatus As New MySqlCommand(queryUpdateSlotStatus, connection, transaction)
                            commandUpdateSlotStatus.Parameters.AddWithValue("@slotID", slotID)
                            commandUpdateSlotStatus.ExecuteNonQuery()
                        End Using

                        ' Commit the transaction if both operations succeed
                        transaction.Commit()
                        Return True
                    Catch ex As Exception
                        ' Rollback the transaction if an error occurs
                        transaction.Rollback()
                        MessageBox.Show("An error occurred while deleting the allocation and updating slot status. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Return False
                    End Try
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("An error occurred while deleting the allocation and updating slot status. Please try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ' Check if any allocation is selected in the DataGridView
        If DataGridView1.SelectedRows.Count > 0 Then
            ' Retrieve the selected allocation ID and slot ID
            Dim selectedAllocationID As Integer = CInt(DataGridView1.SelectedRows(0).Cells("aid").Value)
            Dim selectedSlotID As Integer = CInt(DataGridView1.SelectedRows(0).Cells("sid").Value)

            ' Confirm with the user before deletion
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this allocation?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                ' Delete the allocation and update slot status
                If DeleteAllocation(selectedAllocationID, selectedSlotID) Then
                    MessageBox.Show("Allocation deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    ' Refresh DataGridView
                    LoadAllocationData()
                    Form3.LoadSlotsIntoDataGridView()
                Else
                    MessageBox.Show("Failed to delete allocation. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Please select an allocation to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
        Me.Hide()
    End Sub
End Class
