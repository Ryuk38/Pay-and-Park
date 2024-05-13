Imports MySql.Data.MySqlClient

Public Class Form6
    Dim connStr As String = "datasource=localhost;Database=safetech;Uid=root;Pwd=12345;"
    Dim conn As New MySqlConnection(connStr)

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim selectedDate As Date = DateTimePicker1.Value

        Dim allocationData As DataTable = GetAllocationData(selectedDate)
        Dim paymentData As DataTable = GetPaymentData(allocationData)

        ' Calculate total number of vehicles
        Dim totalVehicles As Integer = allocationData.Rows.Count

        ' Calculate total revenue
        Dim totalRevenue As Double = 0
        For Each row As DataRow In paymentData.Rows
            totalRevenue += CDbl(row("amount"))
        Next

        ' Create a new DataTable to hold the report data
        Dim reportData As New DataTable()
        reportData.Columns.Add("Item", GetType(String))
        reportData.Columns.Add("Value", GetType(String))

        ' Add total number of vehicles to the report data
        reportData.Rows.Add("Total Number of Vehicles", totalVehicles)


        ' Add total revenue to the report data
        reportData.Rows.Add("Total Revenue", totalRevenue.ToString("C"))
        ' Add vehicle numbers to the report data
        For Each row As DataRow In allocationData.Rows
            reportData.Rows.Add("Vehicle Number", row("vehicle_no"))
        Next


        ' Bind the report data to the DataGridView
        DataGridView1.DataSource = reportData
    End Sub

    Private Function GetAllocationData(selectedDate As Date) As DataTable
        Dim query As String = $"SELECT * FROM allocation WHERE date = '{selectedDate.ToString("yyyy-MM-dd")}'"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim allocationData As New DataTable()
        adapter.Fill(allocationData)
        Return allocationData
    End Function

    Private Function GetPaymentData(allocationData As DataTable) As DataTable
        Dim allocationIds As String = String.Join(",", allocationData.AsEnumerable().Select(Function(row) row.Field(Of Integer)("aid")))

        ' Check if there are any allocation IDs
        If String.IsNullOrEmpty(allocationIds) Then
            ' If no allocation IDs are found, return an empty DataTable
            Return New DataTable()
        End If

        Dim query As String = $"SELECT * FROM payment WHERE aid IN ({allocationIds})"
        Dim adapter As New MySqlDataAdapter(query, conn)
        Dim paymentData As New DataTable()
        adapter.Fill(paymentData)
        Return paymentData
    End Function


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Open connection when form loads
        Try
            conn.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        ' Close connection when form closes
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form2.Show()
        Me.Hide()
        form1.TextBox1.Text = ""
        form1.TextBox2.Text = ""
    End Sub
End Class
