<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class register
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
        Button2 = New Button()
        Button1 = New Button()
        TextBox2 = New TextBox()
        TextBox1 = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        Button3 = New Button()
        SuspendLayout()
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(575, 456)
        Button2.Name = "Button2"
        Button2.Size = New Size(136, 61)
        Button2.TabIndex = 14
        Button2.Text = "cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(346, 456)
        Button1.Name = "Button1"
        Button1.Size = New Size(136, 61)
        Button1.TabIndex = 13
        Button1.Text = "login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox2.Location = New Point(527, 309)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(283, 48)
        TextBox2.TabIndex = 12
        ' 
        ' TextBox1
        ' 
        TextBox1.Font = New Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        TextBox1.Location = New Point(527, 202)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(283, 48)
        TextBox1.TabIndex = 11
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(264, 316)
        Label3.Name = "Label3"
        Label3.Size = New Size(180, 41)
        Label3.TabIndex = 10
        Label3.Text = "password"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Verdana", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(256, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(188, 41)
        Label2.TabIndex = 9
        Label2.Text = "username"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(405, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(178, 50)
        Label1.TabIndex = 8
        Label1.Text = "REGISTER"
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button3.Location = New Point(956, 12)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 41)
        Button3.TabIndex = 15
        Button3.Text = "login"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' register
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1062, 653)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "register"
        StartPosition = FormStartPosition.CenterScreen
        Text = "register"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button3 As Button
End Class
