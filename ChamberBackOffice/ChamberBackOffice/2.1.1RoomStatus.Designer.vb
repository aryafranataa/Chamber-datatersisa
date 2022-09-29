<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomStatus
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
        Me.dgvRoomStatus = New System.Windows.Forms.DataGridView()
        Me.tboFloor = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.tboRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tboRoomType = New System.Windows.Forms.TextBox()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tboED = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tboEA = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tboOOS = New System.Windows.Forms.TextBox()
        Me.tboOcDD = New System.Windows.Forms.TextBox()
        Me.tboOcD = New System.Windows.Forms.TextBox()
        Me.tboOcC = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tboVaD = New System.Windows.Forms.TextBox()
        Me.tboVaCN = New System.Windows.Forms.TextBox()
        Me.tboVaCI = New System.Windows.Forms.TextBox()
        CType(Me.dgvRoomStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvRoomStatus
        '
        Me.dgvRoomStatus.AllowUserToAddRows = False
        Me.dgvRoomStatus.AllowUserToDeleteRows = False
        Me.dgvRoomStatus.AllowUserToResizeColumns = False
        Me.dgvRoomStatus.AllowUserToResizeRows = False
        Me.dgvRoomStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomStatus.Location = New System.Drawing.Point(17, 88)
        Me.dgvRoomStatus.Name = "dgvRoomStatus"
        Me.dgvRoomStatus.ReadOnly = True
        Me.dgvRoomStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoomStatus.Size = New System.Drawing.Size(649, 341)
        Me.dgvRoomStatus.TabIndex = 98
        '
        'tboFloor
        '
        Me.tboFloor.Location = New System.Drawing.Point(409, 15)
        Me.tboFloor.Name = "tboFloor"
        Me.tboFloor.Size = New System.Drawing.Size(183, 22)
        Me.tboFloor.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(336, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 16)
        Me.Label4.TabIndex = 75
        Me.Label4.Text = "Floor"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(682, 365)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(95, 35)
        Me.btnRefresh.TabIndex = 97
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'tboRoomNumber
        '
        Me.tboRoomNumber.Location = New System.Drawing.Point(136, 15)
        Me.tboRoomNumber.Name = "tboRoomNumber"
        Me.tboRoomNumber.Size = New System.Drawing.Size(139, 22)
        Me.tboRoomNumber.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Room Number"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 16)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Room Type Code"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tboFloor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tboRoomNumber)
        Me.GroupBox2.Controls.Add(Me.tboRoomType)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 70)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Room by"
        '
        'tboRoomType
        '
        Me.tboRoomType.Location = New System.Drawing.Point(136, 41)
        Me.tboRoomType.Name = "tboRoomType"
        Me.tboRoomType.Size = New System.Drawing.Size(139, 22)
        Me.tboRoomType.TabIndex = 3
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(682, 37)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(95, 35)
        Me.btnSearch.TabIndex = 94
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(414, 517)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 16)
        Me.Label10.TabIndex = 144
        Me.Label10.Text = "ED       = Expected Departure"
        '
        'tboED
        '
        Me.tboED.BackColor = System.Drawing.Color.Tomato
        Me.tboED.Enabled = False
        Me.tboED.Location = New System.Drawing.Point(344, 515)
        Me.tboED.Name = "tboED"
        Me.tboED.Size = New System.Drawing.Size(64, 20)
        Me.tboED.TabIndex = 143
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(90, 541)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 16)
        Me.Label9.TabIndex = 142
        Me.Label9.Text = "EA          = Expected Arival"
        '
        'tboEA
        '
        Me.tboEA.BackColor = System.Drawing.Color.Tomato
        Me.tboEA.Enabled = False
        Me.tboEA.Location = New System.Drawing.Point(20, 539)
        Me.tboEA.Name = "tboEA"
        Me.tboEA.Size = New System.Drawing.Size(64, 20)
        Me.tboEA.TabIndex = 141
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(414, 489)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 16)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "OcDD = Occupied Clean Do Not Disturb"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(414, 463)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 16)
        Me.Label6.TabIndex = 138
        Me.Label6.Text = "OcD    = Occupied Dirty"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(414, 437)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 16)
        Me.Label8.TabIndex = 137
        Me.Label8.Text = "OcC    = Occupied Clean"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(90, 515)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 16)
        Me.Label7.TabIndex = 135
        Me.Label7.Text = "OOS      = Out of Service"
        '
        'tboOOS
        '
        Me.tboOOS.BackColor = System.Drawing.Color.Tomato
        Me.tboOOS.Enabled = False
        Me.tboOOS.Location = New System.Drawing.Point(20, 513)
        Me.tboOOS.Name = "tboOOS"
        Me.tboOOS.Size = New System.Drawing.Size(64, 20)
        Me.tboOOS.TabIndex = 134
        '
        'tboOcDD
        '
        Me.tboOcDD.BackColor = System.Drawing.Color.Tomato
        Me.tboOcDD.Enabled = False
        Me.tboOcDD.Location = New System.Drawing.Point(344, 487)
        Me.tboOcDD.Name = "tboOcDD"
        Me.tboOcDD.Size = New System.Drawing.Size(64, 20)
        Me.tboOcDD.TabIndex = 133
        '
        'tboOcD
        '
        Me.tboOcD.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.tboOcD.Enabled = False
        Me.tboOcD.Location = New System.Drawing.Point(344, 461)
        Me.tboOcD.Name = "tboOcD"
        Me.tboOcD.Size = New System.Drawing.Size(64, 20)
        Me.tboOcD.TabIndex = 132
        '
        'tboOcC
        '
        Me.tboOcC.BackColor = System.Drawing.SystemColors.HotTrack
        Me.tboOcC.Enabled = False
        Me.tboOcC.Location = New System.Drawing.Point(344, 435)
        Me.tboOcC.Name = "tboOcC"
        Me.tboOcC.Size = New System.Drawing.Size(64, 20)
        Me.tboOcC.TabIndex = 131
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(90, 489)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 16)
        Me.Label11.TabIndex = 130
        Me.Label11.Text = "VaD       = Vacant Dirty"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(90, 463)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(232, 16)
        Me.Label12.TabIndex = 129
        Me.Label12.Text = "VaCN    = Vacant Clean Not Inpsected"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(90, 437)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(201, 16)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "VaCI    = Vacant Clean Inspected"
        '
        'tboVaD
        '
        Me.tboVaD.BackColor = System.Drawing.Color.Tomato
        Me.tboVaD.Enabled = False
        Me.tboVaD.Location = New System.Drawing.Point(20, 487)
        Me.tboVaD.Name = "tboVaD"
        Me.tboVaD.Size = New System.Drawing.Size(64, 20)
        Me.tboVaD.TabIndex = 127
        '
        'tboVaCN
        '
        Me.tboVaCN.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.tboVaCN.Enabled = False
        Me.tboVaCN.Location = New System.Drawing.Point(20, 461)
        Me.tboVaCN.Name = "tboVaCN"
        Me.tboVaCN.Size = New System.Drawing.Size(64, 20)
        Me.tboVaCN.TabIndex = 126
        '
        'tboVaCI
        '
        Me.tboVaCI.BackColor = System.Drawing.SystemColors.HotTrack
        Me.tboVaCI.Enabled = False
        Me.tboVaCI.Location = New System.Drawing.Point(20, 435)
        Me.tboVaCI.Name = "tboVaCI"
        Me.tboVaCI.Size = New System.Drawing.Size(64, 20)
        Me.tboVaCI.TabIndex = 125
        '
        'RoomStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.tboED)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tboEA)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tboOOS)
        Me.Controls.Add(Me.tboOcDD)
        Me.Controls.Add(Me.tboOcD)
        Me.Controls.Add(Me.tboOcC)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.tboVaD)
        Me.Controls.Add(Me.tboVaCN)
        Me.Controls.Add(Me.tboVaCI)
        Me.Controls.Add(Me.dgvRoomStatus)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RoomStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RoomStatus"
        CType(Me.dgvRoomStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRoomStatus As System.Windows.Forms.DataGridView
    Friend WithEvents tboFloor As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents tboRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tboRoomType As System.Windows.Forms.TextBox
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tboED As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents tboEA As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tboOOS As System.Windows.Forms.TextBox
    Friend WithEvents tboOcDD As System.Windows.Forms.TextBox
    Friend WithEvents tboOcD As System.Windows.Forms.TextBox
    Friend WithEvents tboOcC As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tboVaD As System.Windows.Forms.TextBox
    Friend WithEvents tboVaCN As System.Windows.Forms.TextBox
    Friend WithEvents tboVaCI As System.Windows.Forms.TextBox
End Class
