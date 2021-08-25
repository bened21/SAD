<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class main_user
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.request = New System.Windows.Forms.Label()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.tab2 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.tab1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape()
        Me.records = New System.Windows.Forms.Label()
        Me.request_lbl1 = New System.Windows.Forms.Label()
        Me.txt_desc = New System.Windows.Forms.TextBox()
        Me.request_lbl2 = New System.Windows.Forms.Label()
        Me.btnsend = New System.Windows.Forms.Label()
        Me.cb_category = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbsearch = New System.Windows.Forms.ComboBox()
        Me.data_tickets = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        CType(Me.data_tickets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DodgerBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1093, 42)
        Me.Panel1.TabIndex = 2
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label4.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(26, 412)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 17)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "LOG OUT"
        '
        'request
        '
        Me.request.AutoSize = True
        Me.request.Cursor = System.Windows.Forms.Cursors.Hand
        Me.request.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.request.ForeColor = System.Drawing.Color.DimGray
        Me.request.Location = New System.Drawing.Point(17, 73)
        Me.request.Name = "request"
        Me.request.Size = New System.Drawing.Size(143, 17)
        Me.request.TabIndex = 25
        Me.request.Text = "REQUEST SERVICE"
        '
        'LineShape1
        '
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 180
        Me.LineShape1.X2 = 180
        Me.LineShape1.Y1 = 60
        Me.LineShape1.Y2 = 360
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.tab2, Me.tab1, Me.LineShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(1096, 448)
        Me.ShapeContainer1.TabIndex = 28
        Me.ShapeContainer1.TabStop = False
        '
        'tab2
        '
        Me.tab2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tab2.Location = New System.Drawing.Point(16, 97)
        Me.tab2.Name = "tab2"
        Me.tab2.Size = New System.Drawing.Size(145, 23)
        Me.tab2.Visible = False
        '
        'tab1
        '
        Me.tab1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.tab1.Location = New System.Drawing.Point(16, 69)
        Me.tab1.Name = "tab1"
        Me.tab1.Size = New System.Drawing.Size(145, 23)
        Me.tab1.Visible = False
        '
        'records
        '
        Me.records.AutoSize = True
        Me.records.Cursor = System.Windows.Forms.Cursors.Hand
        Me.records.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.records.ForeColor = System.Drawing.Color.DimGray
        Me.records.Location = New System.Drawing.Point(17, 102)
        Me.records.Name = "records"
        Me.records.Size = New System.Drawing.Size(71, 17)
        Me.records.TabIndex = 29
        Me.records.Text = "RECORDS"
        '
        'request_lbl1
        '
        Me.request_lbl1.AutoSize = True
        Me.request_lbl1.BackColor = System.Drawing.Color.Transparent
        Me.request_lbl1.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.request_lbl1.ForeColor = System.Drawing.Color.DimGray
        Me.request_lbl1.Location = New System.Drawing.Point(222, 81)
        Me.request_lbl1.Name = "request_lbl1"
        Me.request_lbl1.Size = New System.Drawing.Size(89, 17)
        Me.request_lbl1.TabIndex = 35
        Me.request_lbl1.Text = "CATEGORY"
        '
        'txt_desc
        '
        Me.txt_desc.Location = New System.Drawing.Point(256, 161)
        Me.txt_desc.Multiline = True
        Me.txt_desc.Name = "txt_desc"
        Me.txt_desc.Size = New System.Drawing.Size(680, 200)
        Me.txt_desc.TabIndex = 32
        '
        'request_lbl2
        '
        Me.request_lbl2.AutoSize = True
        Me.request_lbl2.BackColor = System.Drawing.Color.Transparent
        Me.request_lbl2.Font = New System.Drawing.Font("Lucida Sans", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.request_lbl2.ForeColor = System.Drawing.Color.DimGray
        Me.request_lbl2.Location = New System.Drawing.Point(222, 141)
        Me.request_lbl2.Name = "request_lbl2"
        Me.request_lbl2.Size = New System.Drawing.Size(109, 17)
        Me.request_lbl2.TabIndex = 34
        Me.request_lbl2.Text = "DESCRIPTION"
        '
        'btnsend
        '
        Me.btnsend.AutoSize = True
        Me.btnsend.BackColor = System.Drawing.Color.DodgerBlue
        Me.btnsend.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsend.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsend.ForeColor = System.Drawing.Color.White
        Me.btnsend.Location = New System.Drawing.Point(526, 398)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Size = New System.Drawing.Size(96, 27)
        Me.btnsend.TabIndex = 37
        Me.btnsend.Text = "    SEND!  "
        '
        'cb_category
        '
        Me.cb_category.FormattingEnabled = True
        Me.cb_category.Items.AddRange(New Object() {"HARDWARE PROBLEMS", "SOFTWARE PROBLEMS", "INTERNET CONNECTION", "OTHERS"})
        Me.cb_category.Location = New System.Drawing.Point(256, 102)
        Me.cb_category.Name = "cb_category"
        Me.cb_category.Size = New System.Drawing.Size(252, 21)
        Me.cb_category.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label3.Font = New System.Drawing.Font("Lucida Sans Typewriter", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DimGray
        Me.Label3.Location = New System.Drawing.Point(805, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "SEARCH"
        Me.Label3.Visible = False
        '
        'cbsearch
        '
        Me.cbsearch.FormattingEnabled = True
        Me.cbsearch.Items.AddRange(New Object() {"ONGOING", "FINISHED", "VERIFIED", "NOT VERIFIED"})
        Me.cbsearch.Location = New System.Drawing.Point(869, 47)
        Me.cbsearch.Name = "cbsearch"
        Me.cbsearch.Size = New System.Drawing.Size(200, 21)
        Me.cbsearch.TabIndex = 46
        Me.cbsearch.Visible = False
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
        Me.data_tickets.Location = New System.Drawing.Point(201, 81)
        Me.data_tickets.MultiSelect = False
        Me.data_tickets.Name = "data_tickets"
        Me.data_tickets.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.data_tickets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.data_tickets.Size = New System.Drawing.Size(858, 309)
        Me.data_tickets.TabIndex = 48
        Me.data_tickets.Visible = False
        '
        'main_user
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(1096, 448)
        Me.Controls.Add(Me.data_tickets)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbsearch)
        Me.Controls.Add(Me.cb_category)
        Me.Controls.Add(Me.btnsend)
        Me.Controls.Add(Me.request_lbl1)
        Me.Controls.Add(Me.txt_desc)
        Me.Controls.Add(Me.request_lbl2)
        Me.Controls.Add(Me.records)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.request)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "main_user"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "main_user"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.data_tickets, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents request As System.Windows.Forms.Label
    Friend WithEvents LineShape1 As Microsoft.VisualBasic.PowerPacks.LineShape
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents records As System.Windows.Forms.Label
    Friend WithEvents request_lbl1 As System.Windows.Forms.Label
    Friend WithEvents txt_desc As System.Windows.Forms.TextBox
    Friend WithEvents request_lbl2 As System.Windows.Forms.Label
    Friend WithEvents btnsend As System.Windows.Forms.Label
    Friend WithEvents tab2 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents tab1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents cb_category As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbsearch As System.Windows.Forms.ComboBox
    Friend WithEvents data_tickets As System.Windows.Forms.DataGridView
End Class
