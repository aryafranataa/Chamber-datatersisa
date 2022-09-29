<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NightAudit
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
        Me.btnCancel2 = New System.Windows.Forms.Button()
        Me.btnNext2 = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvGuestCheckIn = New System.Windows.Forms.DataGridView()
        Me.PanelPage2 = New System.Windows.Forms.Panel()
        Me.btnPrevious2 = New System.Windows.Forms.Button()
        Me.PanelPage1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvCloseCounter = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewCheckBoxColumn2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnCancel1 = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        CType(Me.dgvGuestCheckIn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelPage2.SuspendLayout()
        Me.PanelPage1.SuspendLayout()
        CType(Me.dgvCloseCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel2
        '
        Me.btnCancel2.Location = New System.Drawing.Point(21, 550)
        Me.btnCancel2.Name = "btnCancel2"
        Me.btnCancel2.Size = New System.Drawing.Size(131, 35)
        Me.btnCancel2.TabIndex = 120
        Me.btnCancel2.Text = "Cancel"
        Me.btnCancel2.UseVisualStyleBackColor = True
        '
        'btnNext2
        '
        Me.btnNext2.Location = New System.Drawing.Point(626, 550)
        Me.btnNext2.Name = "btnNext2"
        Me.btnNext2.Size = New System.Drawing.Size(131, 35)
        Me.btnNext2.TabIndex = 118
        Me.btnNext2.Text = "Next"
        Me.btnNext2.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.HeaderText = "CheckIn-CheckOut"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "Room Num"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "Room Type"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Guest Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "ResvID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(3, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(198, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "2. List of Guest Check Ins due on"
        '
        'dgvGuestCheckIn
        '
        Me.dgvGuestCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGuestCheckIn.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.dgvGuestCheckIn.Location = New System.Drawing.Point(6, 41)
        Me.dgvGuestCheckIn.Name = "dgvGuestCheckIn"
        Me.dgvGuestCheckIn.Size = New System.Drawing.Size(786, 482)
        Me.dgvGuestCheckIn.TabIndex = 3
        '
        'PanelPage2
        '
        Me.PanelPage2.Controls.Add(Me.Label2)
        Me.PanelPage2.Controls.Add(Me.dgvGuestCheckIn)
        Me.PanelPage2.Controls.Add(Me.btnCancel2)
        Me.PanelPage2.Controls.Add(Me.btnPrevious2)
        Me.PanelPage2.Controls.Add(Me.btnNext2)
        Me.PanelPage2.Location = New System.Drawing.Point(707, 12)
        Me.PanelPage2.Name = "PanelPage2"
        Me.PanelPage2.Size = New System.Drawing.Size(795, 598)
        Me.PanelPage2.TabIndex = 126
        Me.PanelPage2.Visible = False
        '
        'btnPrevious2
        '
        Me.btnPrevious2.Location = New System.Drawing.Point(444, 550)
        Me.btnPrevious2.Name = "btnPrevious2"
        Me.btnPrevious2.Size = New System.Drawing.Size(131, 35)
        Me.btnPrevious2.TabIndex = 121
        Me.btnPrevious2.Text = "Previous"
        Me.btnPrevious2.UseVisualStyleBackColor = True
        '
        'PanelPage1
        '
        Me.PanelPage1.Controls.Add(Me.Label1)
        Me.PanelPage1.Controls.Add(Me.dgvCloseCounter)
        Me.PanelPage1.Controls.Add(Me.btnCancel1)
        Me.PanelPage1.Controls.Add(Me.btnPrevious)
        Me.PanelPage1.Controls.Add(Me.btnNext)
        Me.PanelPage1.Location = New System.Drawing.Point(-14, 12)
        Me.PanelPage1.Name = "PanelPage1"
        Me.PanelPage1.Size = New System.Drawing.Size(671, 598)
        Me.PanelPage1.TabIndex = 125
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "1. Close Counter(s)"
        '
        'dgvCloseCounter
        '
        Me.dgvCloseCounter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCloseCounter.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.DataGridViewCheckBoxColumn2})
        Me.dgvCloseCounter.Location = New System.Drawing.Point(6, 41)
        Me.dgvCloseCounter.Name = "dgvCloseCounter"
        Me.dgvCloseCounter.Size = New System.Drawing.Size(786, 482)
        Me.dgvCloseCounter.TabIndex = 4
        '
        'Column1
        '
        Me.Column1.HeaderText = "Counter"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "User Name"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "Employee ID"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "Pending Withdrawals Cash"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "Select Action"
        Me.Column5.Name = "Column5"
        Me.Column5.Text = "Close and Withdrawal"
        Me.Column5.UseColumnTextForLinkValue = True
        '
        'DataGridViewCheckBoxColumn2
        '
        Me.DataGridViewCheckBoxColumn2.HeaderText = "Ignore"
        Me.DataGridViewCheckBoxColumn2.Name = "DataGridViewCheckBoxColumn2"
        '
        'btnCancel1
        '
        Me.btnCancel1.Location = New System.Drawing.Point(21, 550)
        Me.btnCancel1.Name = "btnCancel1"
        Me.btnCancel1.Size = New System.Drawing.Size(131, 35)
        Me.btnCancel1.TabIndex = 120
        Me.btnCancel1.Text = "Cancel"
        Me.btnCancel1.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Enabled = False
        Me.btnPrevious.Location = New System.Drawing.Point(444, 550)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(131, 35)
        Me.btnPrevious.TabIndex = 121
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(626, 550)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(131, 35)
        Me.btnNext.TabIndex = 118
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'NightAudit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(1350, 622)
        Me.Controls.Add(Me.PanelPage2)
        Me.Controls.Add(Me.PanelPage1)
        Me.Name = "NightAudit"
        Me.Text = "NightAudit"
        CType(Me.dgvGuestCheckIn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelPage2.ResumeLayout(False)
        Me.PanelPage2.PerformLayout()
        Me.PanelPage1.ResumeLayout(False)
        Me.PanelPage1.PerformLayout()
        CType(Me.dgvCloseCounter, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel2 As System.Windows.Forms.Button
    Friend WithEvents btnNext2 As System.Windows.Forms.Button
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvGuestCheckIn As System.Windows.Forms.DataGridView
    Friend WithEvents PanelPage2 As System.Windows.Forms.Panel
    Friend WithEvents btnPrevious2 As System.Windows.Forms.Button
    Friend WithEvents PanelPage1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvCloseCounter As System.Windows.Forms.DataGridView
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents DataGridViewCheckBoxColumn2 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents btnCancel1 As System.Windows.Forms.Button
    Friend WithEvents btnPrevious As System.Windows.Forms.Button
    Friend WithEvents btnNext As System.Windows.Forms.Button
End Class
