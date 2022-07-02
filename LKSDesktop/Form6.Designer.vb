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
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.a = New System.Windows.Forms.Button()
        Me.o = New System.Windows.Forms.Button()
        Me.d = New System.Windows.Forms.Button()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.mn = New System.Windows.Forms.TextBox()
        Me.q = New System.Windows.Forms.TextBox()
        Me.ido = New System.Windows.Forms.TextBox()
        Me.idm = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.p = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.c = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.t = New System.Windows.Forms.Label()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv1
        '
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Location = New System.Drawing.Point(88, 36)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(616, 150)
        Me.dgv1.TabIndex = 0
        '
        'dgv2
        '
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Location = New System.Drawing.Point(88, 315)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(616, 150)
        Me.dgv2.TabIndex = 1
        '
        'a
        '
        Me.a.Location = New System.Drawing.Point(492, 286)
        Me.a.Name = "a"
        Me.a.Size = New System.Drawing.Size(75, 23)
        Me.a.TabIndex = 2
        Me.a.Text = "Add"
        Me.a.UseVisualStyleBackColor = True
        '
        'o
        '
        Me.o.Location = New System.Drawing.Point(363, 471)
        Me.o.Name = "o"
        Me.o.Size = New System.Drawing.Size(75, 23)
        Me.o.TabIndex = 3
        Me.o.Text = "Order"
        Me.o.UseVisualStyleBackColor = True
        '
        'd
        '
        Me.d.Location = New System.Drawing.Point(573, 286)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(75, 23)
        Me.d.TabIndex = 4
        Me.d.Text = "Delete"
        Me.d.UseVisualStyleBackColor = True
        '
        'img
        '
        Me.img.Location = New System.Drawing.Point(323, 199)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(115, 102)
        Me.img.TabIndex = 5
        Me.img.TabStop = False
        '
        'mn
        '
        Me.mn.Enabled = False
        Me.mn.Location = New System.Drawing.Point(604, 216)
        Me.mn.Name = "mn"
        Me.mn.Size = New System.Drawing.Size(100, 20)
        Me.mn.TabIndex = 6
        '
        'q
        '
        Me.q.Location = New System.Drawing.Point(604, 242)
        Me.q.Name = "q"
        Me.q.Size = New System.Drawing.Size(100, 20)
        Me.q.TabIndex = 7
        '
        'ido
        '
        Me.ido.Enabled = False
        Me.ido.Location = New System.Drawing.Point(688, 268)
        Me.ido.Name = "ido"
        Me.ido.Size = New System.Drawing.Size(100, 20)
        Me.ido.TabIndex = 8
        Me.ido.Visible = False
        '
        'idm
        '
        Me.idm.Enabled = False
        Me.idm.Location = New System.Drawing.Point(688, 192)
        Me.idm.Name = "idm"
        Me.idm.Size = New System.Drawing.Size(100, 20)
        Me.idm.TabIndex = 9
        Me.idm.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(360, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Order"
        '
        'p
        '
        Me.p.AutoSize = True
        Me.p.Location = New System.Drawing.Point(284, 476)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(13, 13)
        Me.p.TabIndex = 11
        Me.p.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 476)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Protein:"
        '
        'c
        '
        Me.c.AutoSize = True
        Me.c.Location = New System.Drawing.Point(142, 476)
        Me.c.Name = "c"
        Me.c.Size = New System.Drawing.Size(13, 13)
        Me.c.TabIndex = 13
        Me.c.Text = "0"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(544, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Menu:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(601, 476)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Total:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(544, 245)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(26, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Qty:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(97, 476)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Carbo:"
        '
        't
        '
        Me.t.AutoSize = True
        Me.t.Location = New System.Drawing.Point(646, 476)
        Me.t.Name = "t"
        Me.t.Size = New System.Drawing.Size(13, 13)
        Me.t.TabIndex = 18
        Me.t.Text = "0"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(800, 504)
        Me.Controls.Add(Me.t)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.c)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.p)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.idm)
        Me.Controls.Add(Me.ido)
        Me.Controls.Add(Me.q)
        Me.Controls.Add(Me.mn)
        Me.Controls.Add(Me.img)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.o)
        Me.Controls.Add(Me.a)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.dgv1)
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Order"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents a As Button
    Friend WithEvents o As Button
    Friend WithEvents d As Button
    Friend WithEvents img As PictureBox
    Friend WithEvents mn As TextBox
    Friend WithEvents q As TextBox
    Friend WithEvents ido As TextBox
    Friend WithEvents idm As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents p As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents c As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents t As Label
End Class
