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
        Me.s = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.g = New System.Windows.Forms.Button()
        Me.d = New System.Windows.Forms.Button()
        Me.u = New System.Windows.Forms.Button()
        Me.i = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.img = New System.Windows.Forms.PictureBox()
        Me.cr = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.nm = New System.Windows.Forms.TextBox()
        Me.pr = New System.Windows.Forms.TextBox()
        Me.ph = New System.Windows.Forms.TextBox()
        Me.cb = New System.Windows.Forms.TextBox()
        Me.pt = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        's
        '
        Me.s.Location = New System.Drawing.Point(664, 53)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(75, 23)
        Me.s.TabIndex = 0
        Me.s.Text = "Search"
        Me.s.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(71, 82)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(668, 150)
        Me.dgv.TabIndex = 1
        '
        'g
        '
        Me.g.Location = New System.Drawing.Point(278, 323)
        Me.g.Name = "g"
        Me.g.Size = New System.Drawing.Size(28, 23)
        Me.g.TabIndex = 2
        Me.g.Text = "...."
        Me.g.UseVisualStyleBackColor = True
        '
        'd
        '
        Me.d.Location = New System.Drawing.Point(585, 403)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(75, 23)
        Me.d.TabIndex = 3
        Me.d.Text = "Delete"
        Me.d.UseVisualStyleBackColor = True
        '
        'u
        '
        Me.u.Location = New System.Drawing.Point(504, 403)
        Me.u.Name = "u"
        Me.u.Size = New System.Drawing.Size(75, 23)
        Me.u.TabIndex = 4
        Me.u.Text = "Update"
        Me.u.UseVisualStyleBackColor = True
        '
        'i
        '
        Me.i.Location = New System.Drawing.Point(423, 403)
        Me.i.Name = "i"
        Me.i.Size = New System.Drawing.Size(75, 23)
        Me.i.TabIndex = 5
        Me.i.Text = "Insert"
        Me.i.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'img
        '
        Me.img.Location = New System.Drawing.Point(460, 252)
        Me.img.Name = "img"
        Me.img.Size = New System.Drawing.Size(156, 136)
        Me.img.TabIndex = 6
        Me.img.TabStop = False
        '
        'cr
        '
        Me.cr.Location = New System.Drawing.Point(546, 55)
        Me.cr.Name = "cr"
        Me.cr.Size = New System.Drawing.Size(112, 20)
        Me.cr.TabIndex = 7
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(160, 247)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(112, 20)
        Me.id.TabIndex = 8
        '
        'nm
        '
        Me.nm.Location = New System.Drawing.Point(160, 273)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(112, 20)
        Me.nm.TabIndex = 9
        '
        'pr
        '
        Me.pr.Location = New System.Drawing.Point(160, 299)
        Me.pr.Name = "pr"
        Me.pr.Size = New System.Drawing.Size(112, 20)
        Me.pr.TabIndex = 10
        '
        'ph
        '
        Me.ph.Location = New System.Drawing.Point(160, 325)
        Me.ph.Name = "ph"
        Me.ph.Size = New System.Drawing.Size(112, 20)
        Me.ph.TabIndex = 11
        '
        'cb
        '
        Me.cb.Location = New System.Drawing.Point(160, 351)
        Me.cb.Name = "cb"
        Me.cb.Size = New System.Drawing.Size(112, 20)
        Me.cb.TabIndex = 12
        '
        'pt
        '
        Me.pt.Location = New System.Drawing.Point(160, 377)
        Me.pt.Name = "pt"
        Me.pt.Size = New System.Drawing.Size(112, 20)
        Me.pt.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(372, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Manage Menu"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(91, 380)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Protein:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(91, 354)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Carbo:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(91, 302)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Price:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Name:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(91, 328)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "Photo:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(91, 252)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "MenuId:"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.pt)
        Me.Controls.Add(Me.cb)
        Me.Controls.Add(Me.ph)
        Me.Controls.Add(Me.pr)
        Me.Controls.Add(Me.nm)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.cr)
        Me.Controls.Add(Me.img)
        Me.Controls.Add(Me.i)
        Me.Controls.Add(Me.u)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.g)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.s)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Manage Menu"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents s As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents g As Button
    Friend WithEvents d As Button
    Friend WithEvents u As Button
    Friend WithEvents i As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents img As PictureBox
    Friend WithEvents cr As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents nm As TextBox
    Friend WithEvents pr As TextBox
    Friend WithEvents ph As TextBox
    Friend WithEvents cb As TextBox
    Friend WithEvents pt As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
End Class
