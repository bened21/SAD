<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class assign
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.request = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.data_accounts = New System.Windows.Forms.DataGridView()
        Me.ticketsid = New System.Windows.Forms.Label()
        Me.staff = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.data_accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Crimson
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(-6, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(424, 42)
        Me.Panel1.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(386, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "X"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(9, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Assign tickets"
        '
        'request
        '
        Me.request.AutoSize = True
        Me.request.Cursor = System.Windows.Forms.Cursors.Hand
        Me.request.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.request.ForeColor = System.Drawing.Color.DimGray
        Me.request.Location = New System.Drawing.Point(12, 54)
        Me.request.Name = "request"
        Me.request.Size = New System.Drawing.Size(143, 17)
        Me.request.TabIndex = 26
        Me.request.Text = "TECHNICAL STAFF"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Crimson
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(162, 243)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(78, 34)
        Me.Button1.TabIndex = 40
        Me.Button1.Text = "&ASSIGN"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'data_accounts
        '
        Me.data_accounts.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.data_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_accounts.Location = New System.Drawing.Point(34, 79)
        Me.data_accounts.Name = "data_accounts"
        Me.data_accounts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_accounts.Size = New System.Drawing.Size(342, 150)
        Me.data_accounts.TabIndex = 41
        '
        'ticketsid
        '
        Me.ticketsid.AutoSize = True
        Me.ticketsid.Location = New System.Drawing.Point(197, 57)
        Me.ticketsid.Name = "ticketsid"
        Me.ticketsid.Size = New System.Drawing.Size(0, 13)
        Me.ticketsid.TabIndex = 42
        Me.ticketsid.Visible = False
        '
        'staff
        '
        Me.staff.AutoSize = True
        Me.staff.Location = New System.Drawing.Point(240, 57)
        Me.staff.Name = "staff"
        Me.staff.Size = New System.Drawing.Size(0, 13)
        Me.staff.TabIndex = 43
        Me.staff.Visible = False
        '
        'assign
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(408, 289)
        Me.Controls.Add(Me.staff)
        Me.Controls.Add(Me.ticketsid)
        Me.Controls.Add(Me.data_accounts)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.request)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "assign"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.data_accounts, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents request As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents data_accounts As System.Windows.Forms.DataGridView
    Friend WithEvents ticketsid As System.Windows.Forms.Label
    Friend WithEvents staff As System.Windows.Forms.Label

End Class
