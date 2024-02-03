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
        Label1 = New Label()
        Label2 = New Label()
        txtUsername = New TextBox()
        txtpassword = New TextBox()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 9.75F, FontStyle.Bold)
        Label1.Location = New Point(61, 107)
        Label1.Name = "Label1"
        Label1.Size = New Size(89, 17)
        Label1.TabIndex = 0
        Label1.Text = "USERNAME:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 9.75F, FontStyle.Bold)
        Label2.Location = New Point(61, 180)
        Label2.Name = "Label2"
        Label2.Size = New Size(95, 17)
        Label2.TabIndex = 1
        Label2.Text = "PASSWORD:"
        ' 
        ' txtUsername
        ' 
        txtUsername.Location = New Point(162, 107)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(238, 23)
        txtUsername.TabIndex = 2
        ' 
        ' txtpassword
        ' 
        txtpassword.Location = New Point(162, 179)
        txtpassword.Name = "txtpassword"
        txtpassword.Size = New Size(238, 23)
        txtpassword.TabIndex = 3
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightPink
        Button1.Font = New Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(163, 275)
        Button1.Name = "Button1"
        Button1.Size = New Size(104, 34)
        Button1.TabIndex = 4
        Button1.Text = "LOGIN"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(444, 350)
        Controls.Add(Button1)
        Controls.Add(txtpassword)
        Controls.Add(txtUsername)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Button1 As Button

End Class
