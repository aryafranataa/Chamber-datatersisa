<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Multi_Add
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
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvRoom = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvSelectedRoom = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvInRoomFacility = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.dgvSelectedInRoomFacility = New System.Windows.Forms.DataGridView()
        Me.btnAddInRoomFacility = New System.Windows.Forms.Button()
        Me.btnRemoveInRoomFacility = New System.Windows.Forms.Button()
        Me.btnAddRoom = New System.Windows.Forms.Button()
        Me.btnRemoveRoom = New System.Windows.Forms.Button()
        Me.tboQty = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvSelectedRoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvInRoomFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.dgvSelectedInRoomFacility, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvRoom)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(14, 11)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 272)
        Me.GroupBox1.TabIndex = 134
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room"
        '
        'dgvRoom
        '
        Me.dgvRoom.AllowUserToAddRows = False
        Me.dgvRoom.AllowUserToDeleteRows = False
        Me.dgvRoom.AllowUserToOrderColumns = True
        Me.dgvRoom.AllowUserToResizeRows = False
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvRoom.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoom.Location = New System.Drawing.Point(9, 21)
        Me.dgvRoom.Name = "dgvRoom"
        Me.dgvRoom.ReadOnly = True
        Me.dgvRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoom.Size = New System.Drawing.Size(320, 239)
        Me.dgvRoom.TabIndex = 99
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(686, 373)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(95, 35)
        Me.btnRefresh.TabIndex = 135
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(686, 117)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
        Me.btnCancel.TabIndex = 133
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(686, 54)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 132
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgvSelectedRoom
        '
        Me.dgvSelectedRoom.AllowUserToAddRows = False
        Me.dgvSelectedRoom.AllowUserToDeleteRows = False
        Me.dgvSelectedRoom.AllowUserToOrderColumns = True
        Me.dgvSelectedRoom.AllowUserToResizeRows = False
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelectedRoom.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvSelectedRoom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSelectedRoom.Location = New System.Drawing.Point(6, 21)
        Me.dgvSelectedRoom.Name = "dgvSelectedRoom"
        Me.dgvSelectedRoom.ReadOnly = True
        Me.dgvSelectedRoom.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSelectedRoom.Size = New System.Drawing.Size(236, 239)
        Me.dgvSelectedRoom.TabIndex = 99
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvInRoomFacility)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(14, 289)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(339, 272)
        Me.GroupBox3.TabIndex = 137
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "InRoom Facility"
        '
        'dgvInRoomFacility
        '
        Me.dgvInRoomFacility.AllowUserToAddRows = False
        Me.dgvInRoomFacility.AllowUserToDeleteRows = False
        Me.dgvInRoomFacility.AllowUserToOrderColumns = True
        Me.dgvInRoomFacility.AllowUserToResizeRows = False
        DataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvInRoomFacility.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        Me.dgvInRoomFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInRoomFacility.Location = New System.Drawing.Point(9, 21)
        Me.dgvInRoomFacility.Name = "dgvInRoomFacility"
        Me.dgvInRoomFacility.ReadOnly = True
        Me.dgvInRoomFacility.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInRoomFacility.Size = New System.Drawing.Size(320, 239)
        Me.dgvInRoomFacility.TabIndex = 99
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.dgvSelectedInRoomFacility)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(419, 289)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(252, 272)
        Me.GroupBox4.TabIndex = 138
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Selected InRoom Facility"
        '
        'dgvSelectedInRoomFacility
        '
        Me.dgvSelectedInRoomFacility.AllowUserToAddRows = False
        Me.dgvSelectedInRoomFacility.AllowUserToDeleteRows = False
        Me.dgvSelectedInRoomFacility.AllowUserToOrderColumns = True
        Me.dgvSelectedInRoomFacility.AllowUserToResizeRows = False
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvSelectedInRoomFacility.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle8
        Me.dgvSelectedInRoomFacility.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSelectedInRoomFacility.Location = New System.Drawing.Point(9, 21)
        Me.dgvSelectedInRoomFacility.Name = "dgvSelectedInRoomFacility"
        Me.dgvSelectedInRoomFacility.ReadOnly = True
        Me.dgvSelectedInRoomFacility.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSelectedInRoomFacility.Size = New System.Drawing.Size(236, 239)
        Me.dgvSelectedInRoomFacility.TabIndex = 99
        '
        'btnAddInRoomFacility
        '
        Me.btnAddInRoomFacility.Location = New System.Drawing.Point(361, 373)
        Me.btnAddInRoomFacility.Name = "btnAddInRoomFacility"
        Me.btnAddInRoomFacility.Size = New System.Drawing.Size(52, 36)
        Me.btnAddInRoomFacility.TabIndex = 141
        Me.btnAddInRoomFacility.Text = ">>"
        Me.btnAddInRoomFacility.UseVisualStyleBackColor = True
        '
        'btnRemoveInRoomFacility
        '
        Me.btnRemoveInRoomFacility.Location = New System.Drawing.Point(361, 483)
        Me.btnRemoveInRoomFacility.Name = "btnRemoveInRoomFacility"
        Me.btnRemoveInRoomFacility.Size = New System.Drawing.Size(52, 36)
        Me.btnRemoveInRoomFacility.TabIndex = 142
        Me.btnRemoveInRoomFacility.Text = "<<"
        Me.btnRemoveInRoomFacility.UseVisualStyleBackColor = True
        '
        'btnAddRoom
        '
        Me.btnAddRoom.Location = New System.Drawing.Point(361, 83)
        Me.btnAddRoom.Name = "btnAddRoom"
        Me.btnAddRoom.Size = New System.Drawing.Size(52, 36)
        Me.btnAddRoom.TabIndex = 139
        Me.btnAddRoom.Text = ">>"
        Me.btnAddRoom.UseVisualStyleBackColor = True
        '
        'btnRemoveRoom
        '
        Me.btnRemoveRoom.Location = New System.Drawing.Point(361, 177)
        Me.btnRemoveRoom.Name = "btnRemoveRoom"
        Me.btnRemoveRoom.Size = New System.Drawing.Size(52, 36)
        Me.btnRemoveRoom.TabIndex = 140
        Me.btnRemoveRoom.Text = "<<"
        Me.btnRemoveRoom.UseVisualStyleBackColor = True
        '
        'tboQty
        '
        Me.tboQty.Location = New System.Drawing.Point(361, 325)
        Me.tboQty.MaxLength = 3
        Me.tboQty.Name = "tboQty"
        Me.tboQty.Size = New System.Drawing.Size(52, 20)
        Me.tboQty.TabIndex = 143
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(372, 309)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 13)
        Me.Label1.TabIndex = 144
        Me.Label1.Text = "Qty"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvSelectedRoom)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(419, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 272)
        Me.GroupBox2.TabIndex = 139
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selected Room"
        '
        'Multi_Add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tboQty)
        Me.Controls.Add(Me.btnAddRoom)
        Me.Controls.Add(Me.btnRemoveRoom)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.btnAddInRoomFacility)
        Me.Controls.Add(Me.btnRemoveInRoomFacility)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Multi_Add"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MultiAdd"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvRoom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvSelectedRoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        CType(Me.dgvInRoomFacility, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        CType(Me.dgvSelectedInRoomFacility, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvRoom As System.Windows.Forms.DataGridView
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgvSelectedRoom As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvInRoomFacility As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvSelectedInRoomFacility As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddInRoomFacility As System.Windows.Forms.Button
    Friend WithEvents btnRemoveInRoomFacility As System.Windows.Forms.Button
    Friend WithEvents btnAddRoom As System.Windows.Forms.Button
    Friend WithEvents btnRemoveRoom As System.Windows.Forms.Button
    Friend WithEvents tboQty As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
