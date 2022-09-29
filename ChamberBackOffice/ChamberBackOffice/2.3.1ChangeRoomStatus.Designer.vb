<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeRoomStatus
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvChangeStatus = New System.Windows.Forms.DataGridView()
        Me.btnCancel = New System.Windows.Forms.Button()
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
        CType(Me.dgvChangeStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(682, 40)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 100
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'dgvChangeStatus
        '
        Me.dgvChangeStatus.AllowUserToAddRows = False
        Me.dgvChangeStatus.AllowUserToDeleteRows = False
        Me.dgvChangeStatus.AllowUserToOrderColumns = True
        Me.dgvChangeStatus.AllowUserToResizeRows = False
        Me.dgvChangeStatus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvChangeStatus.Location = New System.Drawing.Point(12, 12)
        Me.dgvChangeStatus.Name = "dgvChangeStatus"
        Me.dgvChangeStatus.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvChangeStatus.Size = New System.Drawing.Size(653, 417)
        Me.dgvChangeStatus.TabIndex = 99
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(682, 105)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
        Me.btnCancel.TabIndex = 101
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(406, 517)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(178, 16)
        Me.Label10.TabIndex = 162
        Me.Label10.Text = "ED       = Expected Departure"
        '
        'tboED
        '
        Me.tboED.BackColor = System.Drawing.Color.Tomato
        Me.tboED.Enabled = False
        Me.tboED.Location = New System.Drawing.Point(336, 515)
        Me.tboED.Name = "tboED"
        Me.tboED.Size = New System.Drawing.Size(64, 20)
        Me.tboED.TabIndex = 161
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(82, 541)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(160, 16)
        Me.Label9.TabIndex = 160
        Me.Label9.Text = "EA          = Expected Arival"
        '
        'tboEA
        '
        Me.tboEA.BackColor = System.Drawing.Color.Tomato
        Me.tboEA.Enabled = False
        Me.tboEA.Location = New System.Drawing.Point(12, 539)
        Me.tboEA.Name = "tboEA"
        Me.tboEA.Size = New System.Drawing.Size(64, 20)
        Me.tboEA.TabIndex = 159
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(406, 489)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(244, 16)
        Me.Label5.TabIndex = 158
        Me.Label5.Text = "OcDD = Occupied Clean Do Not Disturb"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(406, 463)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(145, 16)
        Me.Label6.TabIndex = 157
        Me.Label6.Text = "OcD    = Occupied Dirty"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(406, 437)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(152, 16)
        Me.Label8.TabIndex = 156
        Me.Label8.Text = "OcC    = Occupied Clean"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(82, 515)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(148, 16)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "OOS      = Out of Service"
        '
        'tboOOS
        '
        Me.tboOOS.BackColor = System.Drawing.Color.Tomato
        Me.tboOOS.Enabled = False
        Me.tboOOS.Location = New System.Drawing.Point(12, 513)
        Me.tboOOS.Name = "tboOOS"
        Me.tboOOS.Size = New System.Drawing.Size(64, 20)
        Me.tboOOS.TabIndex = 154
        '
        'tboOcDD
        '
        Me.tboOcDD.BackColor = System.Drawing.Color.Tomato
        Me.tboOcDD.Enabled = False
        Me.tboOcDD.Location = New System.Drawing.Point(336, 487)
        Me.tboOcDD.Name = "tboOcDD"
        Me.tboOcDD.Size = New System.Drawing.Size(64, 20)
        Me.tboOcDD.TabIndex = 153
        '
        'tboOcD
        '
        Me.tboOcD.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.tboOcD.Enabled = False
        Me.tboOcD.Location = New System.Drawing.Point(336, 461)
        Me.tboOcD.Name = "tboOcD"
        Me.tboOcD.Size = New System.Drawing.Size(64, 20)
        Me.tboOcD.TabIndex = 152
        '
        'tboOcC
        '
        Me.tboOcC.BackColor = System.Drawing.SystemColors.HotTrack
        Me.tboOcC.Enabled = False
        Me.tboOcC.Location = New System.Drawing.Point(336, 435)
        Me.tboOcC.Name = "tboOcC"
        Me.tboOcC.Size = New System.Drawing.Size(64, 20)
        Me.tboOcC.TabIndex = 151
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(82, 489)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(138, 16)
        Me.Label11.TabIndex = 150
        Me.Label11.Text = "VaD       = Vacant Dirty"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(82, 463)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(232, 16)
        Me.Label12.TabIndex = 149
        Me.Label12.Text = "VaCN    = Vacant Clean Not Inpsected"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(82, 437)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(201, 16)
        Me.Label13.TabIndex = 148
        Me.Label13.Text = "VaCI    = Vacant Clean Inspected"
        '
        'tboVaD
        '
        Me.tboVaD.BackColor = System.Drawing.Color.Tomato
        Me.tboVaD.Enabled = False
        Me.tboVaD.Location = New System.Drawing.Point(12, 487)
        Me.tboVaD.Name = "tboVaD"
        Me.tboVaD.Size = New System.Drawing.Size(64, 20)
        Me.tboVaD.TabIndex = 147
        '
        'tboVaCN
        '
        Me.tboVaCN.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.tboVaCN.Enabled = False
        Me.tboVaCN.Location = New System.Drawing.Point(12, 461)
        Me.tboVaCN.Name = "tboVaCN"
        Me.tboVaCN.Size = New System.Drawing.Size(64, 20)
        Me.tboVaCN.TabIndex = 146
        '
        'tboVaCI
        '
        Me.tboVaCI.BackColor = System.Drawing.SystemColors.HotTrack
        Me.tboVaCI.Enabled = False
        Me.tboVaCI.Location = New System.Drawing.Point(12, 435)
        Me.tboVaCI.Name = "tboVaCI"
        Me.tboVaCI.Size = New System.Drawing.Size(64, 20)
        Me.tboVaCI.TabIndex = 145
        '
        'ChangeRoomStatus
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
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.dgvChangeStatus)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ChangeRoomStatus"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangeRoomStatus"
        CType(Me.dgvChangeStatus, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents dgvChangeStatus As System.Windows.Forms.DataGridView
    Friend WithEvents btnCancel As System.Windows.Forms.Button
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
