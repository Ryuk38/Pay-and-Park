<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.Location = New Point(403, 65)
        Label1.Name = "Label1"
        Label1.Size = New Size(129, 50)
        Label1.TabIndex = 0
        Label1.Text = "LOGIN"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.Location = New Point(189, 181)
        Label2.Name = "Label2"
        Label2.Size = New Size(139, 38)
        Label2.TabIndex = 1
        Label2.Text = "username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point)
        Label3.Location = New Point(624, 181)
        Label3.Name = "Label3"
        Label3.Size = New Size(133, 38)
        Label3.TabIndex = 2
        Label3.Text = "password"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(189, 257)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(126, 27)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(624, 267)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(133, 27)
        TextBox2.TabIndex = 4
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button1.Location = New Point(303, 372)
        Button1.Name = "Button1"
        Button1.Size = New Size(94, 41)
        Button1.TabIndex = 5
        Button1.Text = "login"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point)
        Button2.Location = New Point(541, 372)
        Button2.Name = "Button2"
        Button2.Size = New Size(94, 39)
        Button2.TabIndex = 6
        Button2.Text = "cancel"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Verdana", 10.2F, FontStyle.Underline, GraphicsUnit.Point)
        Label4.Location = New Point(337, 483)
        Label4.Name = "Label4"
        Label4.Size = New Size(272, 20)
        Label4.TabIndex = 7
        Label4.Text = "New user click here to register"
        ' 
        ' form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), Image)
        BackgroundImageLayout = ImageLayout.Stretch
        ClientSize = New Size(1062, 653)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Name = "form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
End Class
