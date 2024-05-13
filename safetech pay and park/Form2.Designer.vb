<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Button4 = New Button()
        Button5 = New Button()
        Label1 = New Label()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(126, 184)
        Button1.Name = "Button1"
        Button1.Size = New Size(194, 98)
        Button1.TabIndex = 0
        Button1.Text = "Slot"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(712, 184)
        Button2.Name = "Button2"
        Button2.Size = New Size(193, 98)
        Button2.TabIndex = 1
        Button2.Text = "Allocation"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(126, 413)
        Button3.Name = "Button3"
        Button3.Size = New Size(194, 102)
        Button3.TabIndex = 2
        Button3.Text = "Payment"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button4.Location = New Point(712, 413)
        Button4.Name = "Button4"
        Button4.Size = New Size(193, 102)
        Button4.TabIndex = 3
        Button4.Text = "Report"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button5
        ' 
        Button5.Font = New Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point)
        Button5.Location = New Point(956, 26)
        Button5.Name = "Button5"
        Button5.Size = New Size(94, 38)
        Button5.TabIndex = 4
        Button5.Text = "Logout"
        Button5.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(409, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(237, 50)
        Label1.TabIndex = 5
        Label1.Text = "DASHBOARD"
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1062, 653)
        Controls.Add(Label1)
        Controls.Add(Button5)
        Controls.Add(Button4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "Form2"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form2"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Label1 As Label
End Class
