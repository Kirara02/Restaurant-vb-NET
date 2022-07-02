<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.hp = New System.Windows.Forms.TextBox()
        Me.ml = New System.Windows.Forms.TextBox()
        Me.nm = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.i = New System.Windows.Forms.Button()
        Me.u = New System.Windows.Forms.Button()
        Me.d = New System.Windows.Forms.Button()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.cr = New System.Windows.Forms.TextBox()
        Me.s = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(553, 236)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "MemberId:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(553, 312)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "Handphone:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(553, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(553, 286)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 38
        Me.Label4.Text = "Email:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(352, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 16)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Manage Member"
        '
        'hp
        '
        Me.hp.Location = New System.Drawing.Point(622, 309)
        Me.hp.Name = "hp"
        Me.hp.Size = New System.Drawing.Size(112, 20)
        Me.hp.TabIndex = 32
        '
        'ml
        '
        Me.ml.Location = New System.Drawing.Point(622, 283)
        Me.ml.Name = "ml"
        Me.ml.Size = New System.Drawing.Size(112, 20)
        Me.ml.TabIndex = 31
        '
        'nm
        '
        Me.nm.Location = New System.Drawing.Point(622, 257)
        Me.nm.Name = "nm"
        Me.nm.Size = New System.Drawing.Size(112, 20)
        Me.nm.TabIndex = 30
        '
        'id
        '
        Me.id.Enabled = False
        Me.id.Location = New System.Drawing.Point(622, 231)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(112, 20)
        Me.id.TabIndex = 29
        '
        'i
        '
        Me.i.Location = New System.Drawing.Point(274, 360)
        Me.i.Name = "i"
        Me.i.Size = New System.Drawing.Size(75, 23)
        Me.i.TabIndex = 26
        Me.i.Text = "Insert"
        Me.i.UseVisualStyleBackColor = True
        '
        'u
        '
        Me.u.Location = New System.Drawing.Point(355, 360)
        Me.u.Name = "u"
        Me.u.Size = New System.Drawing.Size(75, 23)
        Me.u.TabIndex = 25
        Me.u.Text = "Update"
        Me.u.UseVisualStyleBackColor = True
        '
        'd
        '
        Me.d.Location = New System.Drawing.Point(436, 360)
        Me.d.Name = "d"
        Me.d.Size = New System.Drawing.Size(75, 23)
        Me.d.TabIndex = 24
        Me.d.Text = "Delete"
        Me.d.UseVisualStyleBackColor = True
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(66, 49)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(668, 150)
        Me.dgv.TabIndex = 22
        '
        'cr
        '
        Me.cr.Location = New System.Drawing.Point(66, 207)
        Me.cr.Name = "cr"
        Me.cr.Size = New System.Drawing.Size(112, 20)
        Me.cr.TabIndex = 43
        '
        's
        '
        Me.s.Location = New System.Drawing.Point(184, 205)
        Me.s.Name = "s"
        Me.s.Size = New System.Drawing.Size(75, 23)
        Me.s.TabIndex = 42
        Me.s.Text = "Search"
        Me.s.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.cr)
        Me.Controls.Add(Me.s)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.hp)
        Me.Controls.Add(Me.ml)
        Me.Controls.Add(Me.nm)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.i)
        Me.Controls.Add(Me.u)
        Me.Controls.Add(Me.d)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Manage Member"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents hp As TextBox
    Friend WithEvents ml As TextBox
    Friend WithEvents nm As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents i As Button
    Friend WithEvents u As Button
    Friend WithEvents d As Button
    Friend WithEvents dgv As DataGridView
    Friend WithEvents cr As TextBox
    Friend WithEvents s As Button
End Class
