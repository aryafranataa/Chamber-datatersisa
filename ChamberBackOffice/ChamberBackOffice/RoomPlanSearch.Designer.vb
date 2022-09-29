<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomPlanSearch
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
        Me.components = New System.ComponentModel.Container()
        Me.tboRoomNumber = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rdbThreeWeeks = New System.Windows.Forms.RadioButton()
        Me.rdbTwoWeeks = New System.Windows.Forms.RadioButton()
        Me.rdbOneWeek = New System.Windows.Forms.RadioButton()
        Me.tboFloor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tboRoomType = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnModule = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvRoomPlan = New System.Windows.Forms.DataGridView()
        Me.ttiGuest = New System.Windows.Forms.ToolTip(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.dtpNow = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvRoomPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tboRoomNumber
        '
        Me.tboRoomNumber.Location = New System.Drawing.Point(132, 64)
        Me.tboRoomNumber.Name = "tboRoomNumber"
        Me.tboRoomNumber.Size = New System.Drawing.Size(139, 22)
        Me.tboRoomNumber.TabIndex = 2
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dtpNow)
        Me.GroupBox2.Controls.Add(Me.rdbThreeWeeks)
        Me.GroupBox2.Controls.Add(Me.rdbTwoWeeks)
        Me.GroupBox2.Controls.Add(Me.rdbOneWeek)
        Me.GroupBox2.Controls.Add(Me.tboFloor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tboRoomNumber)
        Me.GroupBox2.Controls.Add(Me.tboRoomType)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 106)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Room by"
        '
        'rdbThreeWeeks
        '
        Me.rdbThreeWeeks.AutoSize = True
        Me.rdbThreeWeeks.Location = New System.Drawing.Point(509, 65)
        Me.rdbThreeWeeks.Name = "rdbThreeWeeks"
        Me.rdbThreeWeeks.Size = New System.Drawing.Size(79, 20)
        Me.rdbThreeWeeks.TabIndex = 78
        Me.rdbThreeWeeks.Text = "3 Weeks"
        Me.rdbThreeWeeks.UseVisualStyleBackColor = True
        Me.rdbThreeWeeks.Visible = False
        '
        'rdbTwoWeeks
        '
        Me.rdbTwoWeeks.AutoSize = True
        Me.rdbTwoWeeks.Location = New System.Drawing.Point(419, 65)
        Me.rdbTwoWeeks.Name = "rdbTwoWeeks"
        Me.rdbTwoWeeks.Size = New System.Drawing.Size(79, 20)
        Me.rdbTwoWeeks.TabIndex = 77
        Me.rdbTwoWeeks.Text = "2 Weeks"
        Me.rdbTwoWeeks.UseVisualStyleBackColor = True
        Me.rdbTwoWeeks.Visible = False
        '
        'rdbOneWeek
        '
        Me.rdbOneWeek.AutoSize = True
        Me.rdbOneWeek.Location = New System.Drawing.Point(337, 65)
        Me.rdbOneWeek.Name = "rdbOneWeek"
        Me.rdbOneWeek.Size = New System.Drawing.Size(72, 20)
        Me.rdbOneWeek.TabIndex = 76
        Me.rdbOneWeek.Text = "1 Week"
        Me.rdbOneWeek.UseVisualStyleBackColor = True
        Me.rdbOneWeek.Visible = False
        '
        'tboFloor
        '
        Me.tboFloor.Location = New System.Drawing.Point(408, 33)
        Me.tboFloor.Name = "tboFloor"
        Me.tboFloor.Size = New System.Drawing.Size(183, 22)
        Me.tboFloor.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(337, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Floor"
        '
        'tboRoomType
        '
        Me.tboRoomType.Location = New System.Drawing.Point(132, 33)
        Me.tboRoomType.Name = "tboRoomType"
        Me.tboRoomType.Size = New System.Drawing.Size(139, 22)
        Me.tboRoomType.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Room Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Room Type Code"
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(677, 47)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(95, 35)
        Me.btnSearch.TabIndex = 87
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(677, 285)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(95, 35)
        Me.btnEdit.TabIndex = 89
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnModule
        '
        Me.btnModule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModule.Location = New System.Drawing.Point(677, 229)
        Me.btnModule.Name = "btnModule"
        Me.btnModule.Size = New System.Drawing.Size(95, 35)
        Me.btnModule.TabIndex = 88
        Me.btnModule.Text = "Module"
        Me.btnModule.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(677, 399)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(95, 35)
        Me.btnRefresh.TabIndex = 90
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvRoomPlan
        '
        Me.dgvRoomPlan.AllowUserToAddRows = False
        Me.dgvRoomPlan.AllowUserToDeleteRows = False
        Me.dgvRoomPlan.AllowUserToResizeColumns = False
        Me.dgvRoomPlan.AllowUserToResizeRows = False
        Me.dgvRoomPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomPlan.Location = New System.Drawing.Point(12, 124)
        Me.dgvRoomPlan.Name = "dgvRoomPlan"
        Me.dgvRoomPlan.ReadOnly = True
        Me.dgvRoomPlan.Size = New System.Drawing.Size(649, 436)
        Me.dgvRoomPlan.TabIndex = 91
        '
        'ttiGuest
        '
        Me.ttiGuest.AutoPopDelay = 5000
        Me.ttiGuest.InitialDelay = 500
        Me.ttiGuest.ReshowDelay = 500
        Me.ttiGuest.ShowAlways = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(369, 124)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(286, 436)
        Me.DataGridView1.TabIndex = 92
        Me.DataGridView1.Visible = False
        '
        'dtpNow
        '
        Me.dtpNow.Location = New System.Drawing.Point(132, 0)
        Me.dtpNow.Name = "dtpNow"
        Me.dtpNow.Size = New System.Drawing.Size(200, 22)
        Me.dtpNow.TabIndex = 92
        '
        'RoomPlanSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.dgvRoomPlan)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnModule)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RoomPlanSearch"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RoomPlanSearch"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvRoomPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tboRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnModule As System.Windows.Forms.Button
    Friend WithEvents tboRoomType As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tboFloor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents rdbThreeWeeks As System.Windows.Forms.RadioButton
    Friend WithEvents rdbTwoWeeks As System.Windows.Forms.RadioButton
    Friend WithEvents rdbOneWeek As System.Windows.Forms.RadioButton
    Friend WithEvents dgvRoomPlan As System.Windows.Forms.DataGridView
    Friend WithEvents ttiGuest As System.Windows.Forms.ToolTip
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents dtpNow As System.Windows.Forms.DateTimePicker
End Class
