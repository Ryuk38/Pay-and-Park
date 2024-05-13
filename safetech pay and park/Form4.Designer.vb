<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        TextBox1 = New TextBox()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        TextBox2 = New TextBox()
        ComboBox3 = New ComboBox()
        ComboBox4 = New ComboBox()
        DataGridView1 = New DataGridView()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(551, 25)
        Label1.Name = "Label1"
        Label1.Size = New Size(200, 54)
        Label1.TabIndex = 0
        Label1.Text = "Allocation"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(88, 191)
        Label2.Name = "Label2"
        Label2.Size = New Size(156, 28)
        Label2.TabIndex = 1
        Label2.Text = "Allocation Id"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(88, 345)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 28)
        Label3.TabIndex = 2
        Label3.Text = "Slot Id"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(88, 270)
        Label4.Name = "Label4"
        Label4.Size = New Size(156, 28)
        Label4.TabIndex = 3
        Label4.Text = "Vehicle Type"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label5.Location = New Point(88, 409)
        Label5.Name = "Label5"
        Label5.Size = New Size(194, 28)
        Label5.TabIndex = 4
        Label5.Text = "Vehicle Number"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label6.Location = New Point(88, 478)
        Label6.Name = "Label6"
        Label6.Size = New Size(135, 28)
        Label6.TabIndex = 5
        Label6.Text = "From Time"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Verdana", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label7.Location = New Point(88, 547)
        Label7.Name = "Label7"
        Label7.Size = New Size(102, 28)
        Label7.TabIndex = 6
        Label7.Text = "To Time"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(332, 191)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(178, 32)
        TextBox1.TabIndex = 8
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(332, 265)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(178, 33)
        ComboBox1.TabIndex = 9
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(332, 340)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(178, 33)
        ComboBox2.TabIndex = 10
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(332, 408)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(178, 32)
        TextBox2.TabIndex = 11
        ' 
        ' ComboBox3
        ' 
        ComboBox3.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox3.FormattingEnabled = True
        ComboBox3.Location = New Point(332, 478)
        ComboBox3.Name = "ComboBox3"
        ComboBox3.Size = New Size(178, 33)
        ComboBox3.TabIndex = 12
        ' 
        ' ComboBox4
        ' 
        ComboBox4.Font = New Font("Verdana", 12F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox4.FormattingEnabled = True
        ComboBox4.Location = New Point(332, 547)
        ComboBox4.Name = "ComboBox4"
        ComboBox4.Size = New Size(178, 33)
        ComboBox4.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(592, 149)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(746, 462)
        DataGridView1.TabIndex = 15
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(135, 703)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 16
        Button1.Text = "Pay"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(344, 703)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 17
        Button2.Text = "Reset"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(571, 703)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 18
        Button3.Text = "Delete"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(1255, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 19
        Button4.Text = "Home"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1361, 804)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox4)
        Controls.Add(ComboBox3)
        Controls.Add(TextBox2)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(TextBox1)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form4"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form4"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
