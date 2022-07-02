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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbn = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(420, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Admin Navigation"
        '
        'lbn
        '
        Me.lbn.AutoSize = True
        Me.lbn.Location = New System.Drawing.Point(69, 45)
        Me.lbn.Name = "lbn"
        Me.lbn.Size = New System.Drawing.Size(73, 13)
        Me.lbn.TabIndex = 1
        Me.lbn.Text = "[Admin Name]"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Welcome,"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 84)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Order"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 113)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 23)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "Manage Menu"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(12, 142)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(153, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Manage Menu"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(12, 171)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(153, 23)
        Me.Button4.TabIndex = 6
        Me.Button4.Text = "Logout"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Location = New System.Drawing.Point(192, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(800, 430)
        Me.Panel1.TabIndex = 7
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 485)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Admin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbn As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Panel1 As Panel
End Class
