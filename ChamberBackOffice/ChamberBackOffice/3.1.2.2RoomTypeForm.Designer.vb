<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomTypeForm
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
        Me.dgvRoom = New System.Windows.Forms.DataGridView()
        Me.tboFloor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.chkAddMultiRoom = New System.Windows.Forms.CheckBox()
        Me.gboRoom = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tboRoomTo = New System.Windows.Forms.TextBox()
        Me.tboRoomFrom = New System.Windows.Forms.TextBox()
        Me.btnEditRoom = New System.Windows.Forms.Button()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tboRoomTypeName = New System.Windows.Forms.TextBox()
        Me.tboRoomTypeID = New System.Windows.Forms.TextBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSavenNew = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.dgvRate = New System.Windows.Forms.DataGridView()
        Me.dtpRateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtpRateFrom = New System.Windows.Forms.DateTimePicker()
        Me.tboRate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gboSpesification = New System.Windows.Forms.GroupBox()
        Me.tboWithBreakfast = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnMinEnd = New System.Windows.Forms.Button()
        Me.btnMinStart = New System.Windows.Forms.Button()
        Me.btnPlusEnd = New System.Windows.Forms.Button()
        Me.btnPlusStart = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAddRate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnRefresh = New System.Windows.Forms.Button()
        CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboRoom.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboSpesification.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvRoom
        '
        Me.dgvRoom.AllowUserToAddRows = False
        Me.dgvRoom.AllowUserToDeleteRows = False
        Me.dgvRoom.AllowUserToOrderColumns = True
        Me.dgvRoom.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRoom.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoom.Location = New System.Drawing.Point(18, 177)
        Me.dgvRoom.Name = "dgvRoom"
        Me.dgvRoom.ReadOnly = True
        Me.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoom.Size = New System.Drawing.Size(188, 310)
        Me.dgvRoom.TabIndex = 100
        '
        'tboFloor
        '
        Me.tboFloor.Location = New System.Drawing.Point(91, 18)
        Me.tboFloor.MaxLength = 2
        Me.tboFloor.Name = "tboFloor"
        Me.tboFloor.Size = New System.Drawing.Size(100, 22)
        Me.tboFloor.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 21)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(39, 16)
        Me.Label6.TabIndex = 92
        Me.Label6.Text = "Floor"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 102)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(25, 16)
        Me.Label13.TabIndex = 68
        Me.Label13.Text = "To"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 77)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 16)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "From"
        '
        'chkAddMultiRoom
        '
        Me.chkAddMultiRoom.AutoSize = True
        Me.chkAddMultiRoom.Location = New System.Drawing.Point(425, 12)
        Me.chkAddMultiRoom.Name = "chkAddMultiRoom"
        Me.chkAddMultiRoom.Size = New System.Drawing.Size(180, 17)
        Me.chkAddMultiRoom.TabIndex = 7
        Me.chkAddMultiRoom.Text = "Add Room Number (if sequence)"
        Me.chkAddMultiRoom.UseVisualStyleBackColor = True
        '
        'gboRoom
        '
        Me.gboRoom.Controls.Add(Me.Label3)
        Me.gboRoom.Controls.Add(Me.tboRoomTo)
        Me.gboRoom.Controls.Add(Me.tboRoomFrom)
        Me.gboRoom.Controls.Add(Me.btnEditRoom)
        Me.gboRoom.Controls.Add(Me.dgvRoom)
        Me.gboRoom.Controls.Add(Me.btnAddRoom)
        Me.gboRoom.Controls.Add(Me.tboFloor)
        Me.gboRoom.Controls.Add(Me.Label6)
        Me.gboRoom.Controls.Add(Me.Label13)
        Me.gboRoom.Controls.Add(Me.Label12)
        Me.gboRoom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboRoom.Location = New System.Drawing.Point(425, 41)
        Me.gboRoom.Name = "gboRoom"
        Me.gboRoom.Size = New System.Drawing.Size(230, 507)
        Me.gboRoom.TabIndex = 114
        Me.gboRoom.TabStop = False
        Me.gboRoom.Text = "Room"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 119
        Me.Label3.Text = "Room Number"
        '
        'tboRoomTo
        '
        Me.tboRoomTo.Location = New System.Drawing.Point(91, 99)
        Me.tboRoomTo.MaxLength = 3
        Me.tboRoomTo.Name = "tboRoomTo"
        Me.tboRoomTo.Size = New System.Drawing.Size(100, 22)
        Me.tboRoomTo.TabIndex = 10
        '
        'tboRoomFrom
        '
        Me.tboRoomFrom.Location = New System.Drawing.Point(91, 71)
        Me.tboRoomFrom.MaxLength = 3
        Me.tboRoomFrom.Name = "tboRoomFrom"
        Me.tboRoomFrom.Size = New System.Drawing.Size(100, 22)
        Me.tboRoomFrom.TabIndex = 9
        '
        'btnEditRoom
        '
        Me.btnEditRoom.Location = New System.Drawing.Point(124, 132)
        Me.btnEditRoom.Name = "btnEditRoom"
        Me.btnEditRoom.Size = New System.Drawing.Size(67, 35)
        Me.btnEditRoom.TabIndex = 118
        Me.btnEditRoom.Text = "Edit"
        Me.btnEditRoom.UseVisualStyleBackColor = True
        '
        'btnAddRoom
        '
        Me.btnAddRoom.Location = New System.Drawing.Point(29, 132)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(67, 35)
        Me.btnAddRoom.TabIndex = 11
        Me.btnAddRoom.Text = "Add"
        Me.btnAddRoom.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.tboRoomTypeName)
        Me.GroupBox2.Controls.Add(Me.tboRoomTypeID)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(20, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(399, 88)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Room Type Information"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Room Type Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 26)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Room Type Code"
        '
        'tboRoomTypeName
        '
        Me.tboRoomTypeName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboRoomTypeName.Location = New System.Drawing.Point(130, 55)
        Me.tboRoomTypeName.MaxLength = 30
        Me.tboRoomTypeName.Name = "tboRoomTypeName"
        Me.tboRoomTypeName.Size = New System.Drawing.Size(174, 22)
        Me.tboRoomTypeName.TabIndex = 2
        '
        'tboRoomTypeID
        '
        Me.tboRoomTypeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboRoomTypeID.Location = New System.Drawing.Point(130, 24)
        Me.tboRoomTypeID.MaxLength = 3
        Me.tboRoomTypeID.Name = "tboRoomTypeID"
        Me.tboRoomTypeID.Size = New System.Drawing.Size(174, 22)
        Me.tboRoomTypeID.TabIndex = 1
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(677, 128)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(95, 35)
        Me.btnClear.TabIndex = 110
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnSavenNew
        '
        Me.btnSavenNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavenNew.Location = New System.Drawing.Point(677, 83)
        Me.btnSavenNew.Name = "btnSavenNew"
        Me.btnSavenNew.Size = New System.Drawing.Size(95, 35)
        Me.btnSavenNew.TabIndex = 109
        Me.btnSavenNew.Text = "Save + New"
        Me.btnSavenNew.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(677, 177)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
        Me.btnCancel.TabIndex = 111
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'dgvRate
        '
        Me.dgvRate.AllowUserToAddRows = False
        Me.dgvRate.AllowUserToDeleteRows = False
        Me.dgvRate.AllowUserToOrderColumns = True
        Me.dgvRate.AllowUserToResizeRows = False
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRate.Location = New System.Drawing.Point(9, 197)
        Me.dgvRate.Name = "dgvRate"
        Me.dgvRate.ReadOnly = True
        Me.dgvRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRate.Size = New System.Drawing.Size(384, 239)
        Me.dgvRate.TabIndex = 99
        '
        'dtpRateTo
        '
        Me.dtpRateTo.Location = New System.Drawing.Point(130, 118)
        Me.dtpRateTo.Name = "dtpRateTo"
        Me.dtpRateTo.Size = New System.Drawing.Size(174, 22)
        Me.dtpRateTo.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 123)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 16)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "End Date"
        '
        'dtpRateFrom
        '
        Me.dtpRateFrom.Location = New System.Drawing.Point(130, 84)
        Me.dtpRateFrom.Name = "dtpRateFrom"
        Me.dtpRateFrom.Size = New System.Drawing.Size(174, 22)
        Me.dtpRateFrom.TabIndex = 5
        '
        'tboRate
        '
        Me.tboRate.Location = New System.Drawing.Point(130, 21)
        Me.tboRate.MaxLength = 20
        Me.tboRate.Name = "tboRate"
        Me.tboRate.Size = New System.Drawing.Size(174, 22)
        Me.tboRate.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 89)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(67, 16)
        Me.Label9.TabIndex = 89
        Me.Label9.Text = "Start Date"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 16)
        Me.Label5.TabIndex = 70
        Me.Label5.Text = "Rate"
        '
        'gboSpesification
        '
        Me.gboSpesification.Controls.Add(Me.tboWithBreakfast)
        Me.gboSpesification.Controls.Add(Me.Label4)
        Me.gboSpesification.Controls.Add(Me.btnMinEnd)
        Me.gboSpesification.Controls.Add(Me.btnMinStart)
        Me.gboSpesification.Controls.Add(Me.btnPlusEnd)
        Me.gboSpesification.Controls.Add(Me.btnPlusStart)
        Me.gboSpesification.Controls.Add(Me.btnEdit)
        Me.gboSpesification.Controls.Add(Me.btnAddRate)
        Me.gboSpesification.Controls.Add(Me.dgvRate)
        Me.gboSpesification.Controls.Add(Me.dtpRateTo)
        Me.gboSpesification.Controls.Add(Me.Label1)
        Me.gboSpesification.Controls.Add(Me.dtpRateFrom)
        Me.gboSpesification.Controls.Add(Me.tboRate)
        Me.gboSpesification.Controls.Add(Me.Label9)
        Me.gboSpesification.Controls.Add(Me.Label5)
        Me.gboSpesification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboSpesification.Location = New System.Drawing.Point(20, 106)
        Me.gboSpesification.Name = "gboSpesification"
        Me.gboSpesification.Size = New System.Drawing.Size(399, 442)
        Me.gboSpesification.TabIndex = 115
        Me.gboSpesification.TabStop = False
        Me.gboSpesification.Text = "Rate"
        '
        'tboWithBreakfast
        '
        Me.tboWithBreakfast.Location = New System.Drawing.Point(130, 52)
        Me.tboWithBreakfast.MaxLength = 20
        Me.tboWithBreakfast.Name = "tboWithBreakfast"
        Me.tboWithBreakfast.Size = New System.Drawing.Size(174, 22)
        Me.tboWithBreakfast.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 16)
        Me.Label4.TabIndex = 125
        Me.Label4.Text = "with Breakfast"
        '
        'btnMinEnd
        '
        Me.btnMinEnd.Location = New System.Drawing.Point(313, 116)
        Me.btnMinEnd.Name = "btnMinEnd"
        Me.btnMinEnd.Size = New System.Drawing.Size(22, 24)
        Me.btnMinEnd.TabIndex = 123
        Me.btnMinEnd.Text = "-"
        Me.btnMinEnd.UseVisualStyleBackColor = True
        '
        'btnMinStart
        '
        Me.btnMinStart.Location = New System.Drawing.Point(313, 86)
        Me.btnMinStart.Name = "btnMinStart"
        Me.btnMinStart.Size = New System.Drawing.Size(22, 24)
        Me.btnMinStart.TabIndex = 122
        Me.btnMinStart.Text = "-"
        Me.btnMinStart.UseVisualStyleBackColor = True
        '
        'btnPlusEnd
        '
        Me.btnPlusEnd.Location = New System.Drawing.Point(341, 116)
        Me.btnPlusEnd.Name = "btnPlusEnd"
        Me.btnPlusEnd.Size = New System.Drawing.Size(22, 24)
        Me.btnPlusEnd.TabIndex = 121
        Me.btnPlusEnd.Text = "+"
        Me.btnPlusEnd.UseVisualStyleBackColor = True
        '
        'btnPlusStart
        '
        Me.btnPlusStart.Location = New System.Drawing.Point(341, 86)
        Me.btnPlusStart.Name = "btnPlusStart"
        Me.btnPlusStart.Size = New System.Drawing.Size(22, 24)
        Me.btnPlusStart.TabIndex = 120
        Me.btnPlusStart.Text = "+"
        Me.btnPlusStart.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(237, 156)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(67, 35)
        Me.btnEdit.TabIndex = 8
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAddRate
        '
        Me.btnAddRate.Location = New System.Drawing.Point(130, 156)
        Me.btnAddRate.Name = "btnAddRate"
        Me.btnAddRate.Size = New System.Drawing.Size(67, 35)
        Me.btnAddRate.TabIndex = 7
        Me.btnAddRate.Text = "Add"
        Me.btnAddRate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(677, 36)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 108
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(677, 369)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(95, 35)
        Me.btnRefresh.TabIndex = 116
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'RoomTypeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.chkAddMultiRoom)
        Me.Controls.Add(Me.gboRoom)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnSavenNew)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gboSpesification)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RoomTypeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RoomTypeForm"
        CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboRoom.ResumeLayout(False)
        Me.gboRoom.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboSpesification.ResumeLayout(False)
        Me.gboSpesification.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvRoom As System.Windows.Forms.DataGridView
    Friend WithEvents tboFloor As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents chkAddMultiRoom As System.Windows.Forms.CheckBox
    Friend WithEvents gboRoom As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tboRoomTypeName As System.Windows.Forms.TextBox
    Friend WithEvents tboRoomTypeID As System.Windows.Forms.TextBox
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnSavenNew As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dgvRate As System.Windows.Forms.DataGridView
    Friend WithEvents dtpRateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtpRateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents tboRate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gboSpesification As System.Windows.Forms.GroupBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnAddRoom As System.Windows.Forms.Button
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAddRate As System.Windows.Forms.Button
    Friend WithEvents btnEditRoom As System.Windows.Forms.Button
    Friend WithEvents tboRoomTo As System.Windows.Forms.TextBox
    Friend WithEvents tboRoomFrom As System.Windows.Forms.TextBox
    Friend WithEvents btnMinEnd As System.Windows.Forms.Button
    Friend WithEvents btnMinStart As System.Windows.Forms.Button
    Friend WithEvents btnPlusEnd As System.Windows.Forms.Button
    Friend WithEvents btnPlusStart As System.Windows.Forms.Button
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tboWithBreakfast As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
