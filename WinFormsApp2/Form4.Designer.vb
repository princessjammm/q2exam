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
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label2 = New Label()
        Label3 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(180, 54)
        Label1.Name = "Label1"
        Label1.Size = New Size(106, 20)
        Label1.TabIndex = 1
        Label1.Text = "Computer"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.LightPink
        Button1.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ControlText
        Button1.Location = New Point(46, 158)
        Button1.Name = "Button1"
        Button1.Size = New Size(75, 53)
        Button1.TabIndex = 2
        Button1.Text = "🗿"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = Color.LightPink
        Button2.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ControlText
        Button2.Location = New Point(197, 158)
        Button2.Name = "Button2"
        Button2.Size = New Size(75, 53)
        Button2.TabIndex = 3
        Button2.Text = "📄"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = Color.LightPink
        Button3.Font = New Font("Showcard Gothic", 12F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ControlText
        Button3.Location = New Point(327, 158)
        Button3.Name = "Button3"
        Button3.Size = New Size(76, 53)
        Button3.TabIndex = 4
        Button3.Text = "✂️"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Showcard Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(123, 264)
        Label2.Name = "Label2"
        Label2.Size = New Size(227, 18)
        Label2.TabIndex = 5
        Label2.Text = "Press one of the Button"
        Label2.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(420, 19)
        Label3.Name = "Label3"
        Label3.Size = New Size(0, 21)
        Label3.TabIndex = 6
        ' 
        ' Form4
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.LavenderBlush
        ClientSize = New Size(478, 340)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form4"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
