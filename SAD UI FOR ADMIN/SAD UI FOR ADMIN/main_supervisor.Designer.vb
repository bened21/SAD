<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_supervisor
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.audit = New System.Windows.Forms.Label()
        Me.logout = New System.Windows.Forms.Label()
        Me.view = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.tab4 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.tab3 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.RectangleShape2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.tab1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.account_mng = New System.Windows.Forms.Label()
        Me.data_tickets = New System.Windows.Forms.DataGridView()
        Me.btncreate = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.data_accounts = New System.Windows.Forms.DataGridView()
        Me.data_trail = New System.Windows.Forms.DataGridView()
        Me.btnselect = New System.Windows.Forms.Button()
        Me.cbsearch = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.data_tickets, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_accounts, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.data_trail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1096, 42)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Emoji", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(185, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(133, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TECHNICAL SUPPORT"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(3, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Arellano University"
        '
        'audit
        '
        Me.audit.AutoSize = True
        Me.audit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.audit.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.audit.ForeColor = System.Drawing.Color.DimGray
        Me.audit.Location = New System.Drawing.Point(14, 101)
        Me.audit.Name = "audit"
        Me.audit.Size = New System.Drawing.Size(107, 17)
        Me.audit.TabIndex = 25
        Me.audit.Text = "AUDIT TRAIL"
        '
        'logout
        '
        Me.logout.AutoSize = True
        Me.logout.Cursor = System.Windows.Forms.Cursors.Hand
        Me.logout.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.logout.ForeColor = System.Drawing.Color.DimGray
        Me.logout.Location = New System.Drawing.Point(30, 403)
        Me.logout.Name = "logout"
        Me.logout.Size = New System.Drawing.Size(71, 17)
        Me.logout.TabIndex = 24
        Me.logout.Text = "LOG OUT"
        '
        'view
        '
        Me.view.AutoSize = True
        Me.view.Cursor = System.Windows.Forms.Cursors.Hand
        Me.view.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.view.ForeColor = System.Drawing.Color.DimGray
        Me.view.Location = New System.Drawing.Point(13, 74)
        Me.view.Name = "view"
        Me.view.Size = New System.Drawing.Size(71, 17)
        Me.view.TabIndex = 21
        Me.view.Text = "TICKETS"
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 197
        Me.LineShape1.X2 = 198
        Me.LineShape1.Y1 = 68
        Me.LineShape1.Y2 = 398
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.tab4, Me.tab3, Me.RectangleShape2, Me.tab1, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1096, 448)
        Me.ShapeContainer1.TabIndex = 26
        Me.ShapeContainer1.TabStop = False
        '
        'tab4
        '
        Me.tab4.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tab4.Location = New System.Drawing.Point(12, 128)
        Me.tab4.Name = "tab4"
        Me.tab4.Size = New System.Drawing.Size(174, 23)
        Me.tab4.Visible = False
        '
        'tab3
        '
        Me.tab3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tab3.Location = New System.Drawing.Point(12, 100)
        Me.tab3.Name = "tab3"
        Me.tab3.Size = New System.Drawing.Size(167, 23)
        Me.tab3.Visible = False
        '
        'RectangleShape2
        '
        Me.RectangleShape2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RectangleShape2.Location = New System.Drawing.Point(264, 158)
        Me.RectangleShape2.Name = "RectangleShape2"
        Me.RectangleShape2.Size = New System.Drawing.Size(167, 23)
        Me.RectangleShape2.Visible = False
        '
        'tab1
        '
        Me.tab1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tab1.Location = New System.Drawing.Point(12, 73)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(167, 23)
        '
        'account_mng
        '
        Me.account_mng.AutoSize = True
        Me.account_mng.Cursor = System.Windows.Forms.Cursors.Hand
        Me.account_mng.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.account_mng.ForeColor = System.Drawing.Color.DimGray
        Me.account_mng.Location = New System.Drawing.Point(14, 130)
        Me.account_mng.Name = "account_mng"
        Me.account_mng.Size = New System.Drawing.Size(170, 17)
        Me.account_mng.TabIndex = 27
        Me.account_mng.Text = "ACCOUNT MANAGEMENT"
        '
        'data_tickets
        '
        Me.data_tickets.AllowUserToAddRows = False
        Me.data_tickets.AllowUserToDeleteRows = False
        Me.data_tickets.AllowUserToResizeColumns = False
        Me.data_tickets.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_tickets.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.data_tickets.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.data_tickets.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.data_tickets.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.data_tickets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_tickets.Location = New System.Drawing.Point(215, 80)
        Me.data_tickets.MultiSelect = False
        Me.data_tickets.Name = "data_tickets"
        Me.data_tickets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_tickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_tickets.Size = New System.Drawing.Size(858, 309)
        Me.data_tickets.TabIndex = 32
        '
        'btncreate
        '
        Me.btncreate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btncreate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncreate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncreate.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncreate.ForeColor = System.Drawing.SystemColors.Control
        Me.btncreate.Location = New System.Drawing.Point(469, 396)
        Me.btncreate.Name = "btncreate"
        Me.btncreate.Size = New System.Drawing.Size(78, 34)
        Me.btncreate.TabIndex = 34
        Me.btncreate.Text = "&CREATE"
        Me.btncreate.UseVisualStyleBackColor = False
        Me.btncreate.Visible = False
        '
        'btnupdate
        '
        Me.btnupdate.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnupdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.Control
        Me.btnupdate.Location = New System.Drawing.Point(650, 395)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(88, 34)
        Me.btnupdate.TabIndex = 35
        Me.btnupdate.Text = "&UPDATE"
        Me.btnupdate.UseVisualStyleBackColor = False
        Me.btnupdate.Visible = False
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.DodgerBlue
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.Control
        Me.btndelete.Location = New System.Drawing.Point(832, 396)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(78, 34)
        Me.btndelete.TabIndex = 36
        Me.btndelete.Text = "&DELETE"
        Me.btndelete.UseVisualStyleBackColor = False
        Me.btndelete.Visible = False
        '
        'data_accounts
        '
        Me.data_accounts.AllowUserToAddRows = False
        Me.data_accounts.AllowUserToDeleteRows = False
        Me.data_accounts.AllowUserToResizeColumns = False
        Me.data_accounts.AllowUserToResizeRows = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_accounts.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle2
        Me.data_accounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.data_accounts.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.data_accounts.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.data_accounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_accounts.Location = New System.Drawing.Point(215, 81)
        Me.data_accounts.MultiSelect = False
        Me.data_accounts.Name = "data_accounts"
        Me.data_accounts.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_accounts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_accounts.Size = New System.Drawing.Size(858, 309)
        Me.data_accounts.TabIndex = 38
        Me.data_accounts.Visible = False
        '
        'data_trail
        '
        Me.data_trail.AllowUserToAddRows = False
        Me.data_trail.AllowUserToDeleteRows = False
        Me.data_trail.AllowUserToResizeColumns = False
        Me.data_trail.AllowUserToResizeRows = False
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.data_trail.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.data_trail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.data_trail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.data_trail.BackgroundColor = System.Drawing.SystemColors.InactiveCaption
        Me.data_trail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.data_trail.Location = New System.Drawing.Point(215, 80)
        Me.data_trail.MultiSelect = False
        Me.data_trail.Name = "data_trail"
        Me.data_trail.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_trail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_trail.Size = New System.Drawing.Size(858, 309)
        Me.data_trail.TabIndex = 41
        Me.data_trail.Visible = False
        '
        'btnselect
        '
        Me.btnselect.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnselect.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnselect.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnselect.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.ForeColor = System.Drawing.SystemColors.Control
        Me.btnselect.Location = New System.Drawing.Point(650, 396)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(88, 34)
        Me.btnselect.TabIndex = 42
        Me.btnselect.Text = "&SELECT!"
        Me.btnselect.UseVisualStyleBackColor = False
        '
        'cbsearch
        '
        Me.cbsearch.FormattingEnabled = True
        Me.cbsearch.Items.AddRange(New Object() {"ONGOING", "FINISHED", "VERIFIED", "NOT VERIFIED"})
        Me.cbsearch.Location = New System.Drawing.Point(873, 47)
        Me.cbsearch.Name = "cbsearch"
        Me.cbsearch.Size = New System.Drawing.Size(200, 21)
        Me.cbsearch.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(809, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "SEARCH"
        '
        'main_supervisor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1096, 448)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbsearch)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btncreate)
        Me.Controls.Add(Me.account_mng)
        Me.Controls.Add(Me.audit)
        Me.Controls.Add(Me.logout)
        Me.Controls.Add(Me.view)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.data_accounts)
        Me.Controls.Add(Me.data_trail)
        Me.Controls.Add(Me.data_tickets)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main_supervisor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main_supervisor"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.data_tickets, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_accounts, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.data_trail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents audit As System.Windows.Forms.Label
    Friend WithEvents logout As System.Windows.Forms.Label
    Friend WithEvents view As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents account_mng As System.Windows.Forms.Label
    Friend WithEvents data_tickets As System.Windows.Forms.DataGridView
    Friend WithEvents tab4 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents tab3 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents RectangleShape2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents tab1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btncreate As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents data_accounts As System.Windows.Forms.DataGridView
    Friend WithEvents data_trail As System.Windows.Forms.DataGridView
    Friend WithEvents btnselect As System.Windows.Forms.Button
    Friend WithEvents cbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
