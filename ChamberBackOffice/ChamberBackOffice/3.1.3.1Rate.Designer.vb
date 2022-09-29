<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Rate
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
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.gboSpesification = New System.Windows.Forms.GroupBox()
        Me.tboBreakfast = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvRoomType = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDisplayRate = New System.Windows.Forms.DataGridView()
        Me.btnMinEnd = New System.Windows.Forms.Button()
        Me.btnMinStart = New System.Windows.Forms.Button()
        Me.btnPlusEnd = New System.Windows.Forms.Button()
        Me.btnPlusStart = New System.Windows.Forms.Button()
        Me.dtpRateTo = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpRateFrom = New System.Windows.Forms.DateTimePicker()
        Me.tboRate = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.gboSpesification.SuspendLayout()
        CType(Me.dgvRoomType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDisplayRate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(177, 161)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(95, 35)
        Me.btnEdit.TabIndex = 10
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(34, 161)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(95, 35)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'gboSpesification
        '
        Me.gboSpesification.Controls.Add(Me.tboBreakfast)
        Me.gboSpesification.Controls.Add(Me.Label3)
        Me.gboSpesification.Controls.Add(Me.dgvRoomType)
        Me.gboSpesification.Controls.Add(Me.Label1)
        Me.gboSpesification.Controls.Add(Me.dgvDisplayRate)
        Me.gboSpesification.Controls.Add(Me.btnMinEnd)
        Me.gboSpesification.Controls.Add(Me.btnMinStart)
        Me.gboSpesification.Controls.Add(Me.btnEdit)
        Me.gboSpesification.Controls.Add(Me.btnPlusEnd)
        Me.gboSpesification.Controls.Add(Me.btnAdd)
        Me.gboSpesification.Controls.Add(Me.btnPlusStart)
        Me.gboSpesification.Controls.Add(Me.dtpRateTo)
        Me.gboSpesification.Controls.Add(Me.Label2)
        Me.gboSpesification.Controls.Add(Me.dtpRateFrom)
        Me.gboSpesification.Controls.Add(Me.tboRate)
        Me.gboSpesification.Controls.Add(Me.Label9)
        Me.gboSpesification.Controls.Add(Me.Label5)
        Me.gboSpesification.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboSpesification.Location = New System.Drawing.Point(12, 4)
        Me.gboSpesification.Name = "gboSpesification"
        Me.gboSpesification.Size = New System.Drawing.Size(651, 555)
        Me.gboSpesification.TabIndex = 116
        Me.gboSpesification.TabStop = False
        Me.gboSpesification.Text = "Rate"
        '
        'tboBreakfast
        '
        Me.tboBreakfast.Location = New System.Drawing.Point(89, 48)
        Me.tboBreakfast.MaxLength = 20
        Me.tboBreakfast.Name = "tboBreakfast"
        Me.tboBreakfast.Size = New System.Drawing.Size(174, 22)
        Me.tboBreakfast.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 54)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 16)
        Me.Label3.TabIndex = 130
        Me.Label3.Text = "w/ Breakfast"
        '
        'dgvRoomType
        '
        Me.dgvRoomType.AllowUserToAddRows = False
        Me.dgvRoomType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRoomType.Location = New System.Drawing.Point(328, 36)
        Me.dgvRoomType.Name = "dgvRoomType"
        Me.dgvRoomType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRoomType.Size = New System.Drawing.Size(311, 172)
        Me.dgvRoomType.TabIndex = 128
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(325, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 16)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Select  Room Type"
        '
        'dgvDisplayRate
        '
        Me.dgvDisplayRate.AllowUserToAddRows = False
        Me.dgvDisplayRate.AllowUserToDeleteRows = False
        Me.dgvDisplayRate.AllowUserToOrderColumns = True
        Me.dgvDisplayRate.AllowUserToResizeRows = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDisplayRate.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDisplayRate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDisplayRate.Location = New System.Drawing.Point(6, 214)
        Me.dgvDisplayRate.Name = "dgvDisplayRate"
        Me.dgvDisplayRate.ReadOnly = True
        Me.dgvDisplayRate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvDisplayRate.Size = New System.Drawing.Size(633, 335)
        Me.dgvDisplayRate.TabIndex = 126
        '
        'btnMinEnd
        '
        Me.btnMinEnd.Location = New System.Drawing.Point(272, 110)
        Me.btnMinEnd.Name = "btnMinEnd"
        Me.btnMinEnd.Size = New System.Drawing.Size(22, 24)
        Me.btnMinEnd.TabIndex = 7
        Me.btnMinEnd.Text = "-"
        Me.btnMinEnd.UseVisualStyleBackColor = True
        '
        'btnMinStart
        '
        Me.btnMinStart.Location = New System.Drawing.Point(272, 81)
        Me.btnMinStart.Name = "btnMinStart"
        Me.btnMinStart.Size = New System.Drawing.Size(22, 24)
        Me.btnMinStart.TabIndex = 4
        Me.btnMinStart.Text = "-"
        Me.btnMinStart.UseVisualStyleBackColor = True
        '
        'btnPlusEnd
        '
        Me.btnPlusEnd.Location = New System.Drawing.Point(300, 110)
        Me.btnPlusEnd.Name = "btnPlusEnd"
        Me.btnPlusEnd.Size = New System.Drawing.Size(22, 24)
        Me.btnPlusEnd.TabIndex = 8
        Me.btnPlusEnd.Text = "+"
        Me.btnPlusEnd.UseVisualStyleBackColor = True
        '
        'btnPlusStart
        '
        Me.btnPlusStart.Location = New System.Drawing.Point(300, 81)
        Me.btnPlusStart.Name = "btnPlusStart"
        Me.btnPlusStart.Size = New System.Drawing.Size(22, 24)
        Me.btnPlusStart.TabIndex = 5
        Me.btnPlusStart.Text = "+"
        Me.btnPlusStart.UseVisualStyleBackColor = True
        '
        'dtpRateTo
        '
        Me.dtpRateTo.Location = New System.Drawing.Point(89, 112)
        Me.dtpRateTo.Name = "dtpRateTo"
        Me.dtpRateTo.Size = New System.Drawing.Size(174, 22)
        Me.dtpRateTo.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 97
        Me.Label2.Text = "End Date"
        '
        'dtpRateFrom
        '
        Me.dtpRateFrom.Location = New System.Drawing.Point(89, 79)
        Me.dtpRateFrom.Name = "dtpRateFrom"
        Me.dtpRateFrom.Size = New System.Drawing.Size(174, 22)
        Me.dtpRateFrom.TabIndex = 3
        '
        'tboRate
        '
        Me.tboRate.Location = New System.Drawing.Point(89, 18)
        Me.tboRate.MaxLength = 20
        Me.tboRate.Name = "tboRate"
        Me.tboRate.Size = New System.Drawing.Size(174, 22)
        Me.tboRate.TabIndex = 1
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 81)
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
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(677, 174)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(677, 36)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDelete.Location = New System.Drawing.Point(677, 309)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(95, 35)
        Me.btnDelete.TabIndex = 15
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Rate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.gboSpesification)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Rate"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Room Rate"
        Me.gboSpesification.ResumeLayout(False)
        Me.gboSpesification.PerformLayout()
        CType(Me.dgvRoomType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDisplayRate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents gboSpesification As System.Windows.Forms.GroupBox
    Friend WithEvents btnMinEnd As System.Windows.Forms.Button
    Friend WithEvents btnMinStart As System.Windows.Forms.Button
    Friend WithEvents btnPlusEnd As System.Windows.Forms.Button
    Friend WithEvents btnPlusStart As System.Windows.Forms.Button
    Friend WithEvents dtpRateTo As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dtpRateFrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents tboRate As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgvRoomType As System.Windows.Forms.DataGridView
    Friend WithEvents dgvDisplayRate As System.Windows.Forms.DataGridView
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents tboBreakfast As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
