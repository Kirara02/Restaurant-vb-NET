<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.o = New System.Windows.Forms.ComboBox()
        Me.p = New System.Windows.Forms.ComboBox()
        Me.b = New System.Windows.Forms.ComboBox()
        Me.n = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.t = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(138, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(547, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'o
        '
        Me.o.FormattingEnabled = True
        Me.o.Location = New System.Drawing.Point(403, 42)
        Me.o.Name = "o"
        Me.o.Size = New System.Drawing.Size(121, 21)
        Me.o.TabIndex = 1
        '
        'p
        '
        Me.p.FormattingEnabled = True
        Me.p.Items.AddRange(New Object() {"Cash", "Credit Card"})
        Me.p.Location = New System.Drawing.Point(403, 255)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(121, 21)
        Me.p.TabIndex = 2
        '
        'b
        '
        Me.b.Enabled = False
        Me.b.FormattingEnabled = True
        Me.b.Items.AddRange(New Object() {"BRI", "BNI", "BCA"})
        Me.b.Location = New System.Drawing.Point(403, 308)
        Me.b.Name = "b"
        Me.b.Size = New System.Drawing.Size(121, 21)
        Me.b.TabIndex = 3
        '
        'n
        '
        Me.n.Enabled = False
        Me.n.Location = New System.Drawing.Point(403, 282)
        Me.n.Name = "n"
        Me.n.Size = New System.Drawing.Size(121, 20)
        Me.n.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(403, 345)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(403, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Payment"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(304, 285)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Card Number:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(304, 258)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Payment Type:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(586, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Total:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 311)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Bank:"
        '
        't
        '
        Me.t.AutoSize = True
        Me.t.Location = New System.Drawing.Point(621, 227)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(13, 13)
        Me.t.TabIndex = 11
        Me.t.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(304, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "OrderId:"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.t)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.n)
        Me.Controls.Add(Me.b)
        Me.Controls.Add(Me.p)
        Me.Controls.Add(Me.o)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form7"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Payment"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents o As ComboBox
    Friend WithEvents p As ComboBox
    Friend WithEvents b As ComboBox
    Friend WithEvents n As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents t As Label
    Friend WithEvents Label7 As Label
End Class
