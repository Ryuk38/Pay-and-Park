<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        TextBox1 = New TextBox()
        Label6 = New Label()
        ComboBox1 = New ComboBox()
        Button1 = New Button()
        Button2 = New Button()
        ComboBox2 = New ComboBox()
        DataGridView1 = New DataGridView()
        Button3 = New Button()
        Button4 = New Button()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(35, 166)
        Label1.Name = "Label1"
        Label1.Size = New Size(107, 34)
        Label1.TabIndex = 0
        Label1.Text = "Slot id"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(35, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(0, 34)
        Label2.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(35, 252)
        Label3.Name = "Label3"
        Label3.Size = New Size(146, 34)
        Label3.TabIndex = 2
        Label3.Text = "Slot Type"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label4.Location = New Point(35, 342)
        Label4.Name = "Label4"
        Label4.Size = New Size(86, 34)
        Label4.TabIndex = 3
        Label4.Text = "Floor"
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(215, 166)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(191, 43)
        TextBox1.TabIndex = 4
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point)
        Label6.Location = New Point(435, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(107, 54)
        Label6.TabIndex = 9
        Label6.Text = "Slot "
        ' 
        ' ComboBox1
        ' 
        ComboBox1.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(215, 260)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(191, 28)
        ComboBox1.TabIndex = 10
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(35, 485)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 29)
        Button1.TabIndex = 11
        Button1.Text = "Add"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(173, 485)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 29)
        Button2.TabIndex = 12
        Button2.Text = "Delete"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox2
        ' 
        ComboBox2.Font = New Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point)
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(215, 342)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(191, 28)
        ComboBox2.TabIndex = 13
        ' 
        ' DataGridView1
        ' 
        DataGridView1.AllowUserToAddRows = False
        DataGridView1.AllowUserToDeleteRows = False
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(469, 166)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.ReadOnly = True
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.RowTemplate.Height = 29
        DataGridView1.Size = New Size(581, 357)
        DataGridView1.TabIndex = 14
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(323, 485)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 29)
        Button3.TabIndex = 15
        Button3.Text = "Reset"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(956, 12)
        Button4.Name = "Button4"
        Button4.Size = New Size(94, 29)
        Button4.TabIndex = 16
        Button4.Text = "Home"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Form3
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 653)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(DataGridView1)
        Controls.Add(ComboBox2)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(ComboBox1)
        Controls.Add(Label6)
        Controls.Add(TextBox1)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form3"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form3"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
End Class
