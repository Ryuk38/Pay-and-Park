<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        DateTimePicker1 = New DateTimePicker()
        Label2 = New Label()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button3 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(437, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(156, 41)
        Label1.TabIndex = 0
        Label1.Text = "REPORT"
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(311, 186)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(179, 27)
        DateTimePicker1.TabIndex = 1
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(101, 184)
        Label2.Name = "Label2"
        Label2.Size = New Size(146, 28)
        Label2.TabIndex = 2
        Label2.Text = "Select Date"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(43, 273)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(990, 448)
        DataGridView1.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(565, 183)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 4
        Button1.Text = "Fetch"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(956, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 41)
        Button3.TabIndex = 16
        Button3.Text = "HOME"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Form6
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 751)
        Controls.Add(Button3)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(Label2)
        Controls.Add(DateTimePicker1)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form6"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form6"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button3 As Button
End Class
