<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomForm
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
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.btnSavenNew = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.tboRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tboFloor = New System.Windows.Forms.TextBox()
        Me.dgvFacilityChosen = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRemoveFacility = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tboRoomTypeName = New System.Windows.Forms.TextBox()
        Me.tboRoomTypeID = New System.Windows.Forms.TextBox()
        Me.lable = New System.Windows.Forms.Label()
        Me.dgvFacilityDatabase = New System.Windows.Forms.DataGridView()
        Me.BtnEditFacility = New System.Windows.Forms.Button()
        Me.gboFacility = New System.Windows.Forms.GroupBox()
        Me.tboQuantity = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnNewFacility = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRoomNumberAvailable = New System.Windows.Forms.Label()
        Me.lblRoomTypeAvailable = New System.Windows.Forms.Label()
        Me.tboStandadCapacity = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboAddOnePerson = New System.Windows.Forms.ComboBox()
        CType(Me.dgvFacilityChosen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvFacilityDatabase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gboFacility.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(685, 383)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(95, 35)
        Me.btnRefresh.TabIndex = 144
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'btnSavenNew
        '
        Me.btnSavenNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavenNew.Location = New System.Drawing.Point(683, 85)
        Me.btnSavenNew.Name = "btnSavenNew"
        Me.btnSavenNew.Size = New System.Drawing.Size(95, 35)
        Me.btnSavenNew.TabIndex = 141
        Me.btnSavenNew.Text = "Save + New"
        Me.btnSavenNew.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(683, 38)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 140
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(683, 179)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
        Me.btnCancel.TabIndex = 143
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'tboRoomNumber
        '
        Me.tboRoomNumber.Location = New System.Drawing.Point(141, 95)
        Me.tboRoomNumber.MaxLength = 4
        Me.tboRoomNumber.Name = "tboRoomNumber"
        Me.tboRoomNumber.Size = New System.Drawing.Size(206, 22)
        Me.tboRoomNumber.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 98)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 88
        Me.Label1.Text = "Room Number"
        '
        'tboFloor
        '
        Me.tboFloor.Location = New System.Drawing.Point(141, 126)
        Me.tboFloor.MaxLength = 2
        Me.tboFloor.Name = "tboFloor"
        Me.tboFloor.Size = New System.Drawing.Size(206, 22)
        Me.tboFloor.TabIndex = 4
        '
        'dgvFacilityChosen
        '
        Me.dgvFacilityChosen.AllowUserToAddRows = False
        Me.dgvFacilityChosen.AllowUserToDeleteRows = False
        Me.dgvFacilityChosen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvFacilityChosen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacilityChosen.Location = New System.Drawing.Point(366, 63)
        Me.dgvFacilityChosen.Name = "dgvFacilityChosen"
        Me.dgvFacilityChosen.ReadOnly = True
        Me.dgvFacilityChosen.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvFacilityChosen.Size = New System.Drawing.Size(268, 223)
        Me.dgvFacilityChosen.TabIndex = 17
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(295, 72)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(52, 36)
        Me.btnAdd.TabIndex = 22
        Me.btnAdd.Text = ">>"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRemoveFacility
        '
        Me.btnRemoveFacility.Location = New System.Drawing.Point(295, 240)
        Me.btnRemoveFacility.Name = "btnRemoveFacility"
        Me.btnRemoveFacility.Size = New System.Drawing.Size(52, 36)
        Me.btnRemoveFacility.TabIndex = 25
        Me.btnRemoveFacility.Text = "<<"
        Me.btnRemoveFacility.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 16)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Room Type Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 33)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(116, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Room Type Code"
        '
        'tboRoomTypeName
        '
        Me.tboRoomTypeName.Enabled = False
        Me.tboRoomTypeName.Location = New System.Drawing.Point(141, 62)
        Me.tboRoomTypeName.MaxLength = 45
        Me.tboRoomTypeName.Name = "tboRoomTypeName"
        Me.tboRoomTypeName.Size = New System.Drawing.Size(206, 22)
        Me.tboRoomTypeName.TabIndex = 2
        '
        'tboRoomTypeID
        '
        Me.tboRoomTypeID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboRoomTypeID.Location = New System.Drawing.Point(141, 30)
        Me.tboRoomTypeID.MaxLength = 3
        Me.tboRoomTypeID.Name = "tboRoomTypeID"
        Me.tboRoomTypeID.Size = New System.Drawing.Size(206, 22)
        Me.tboRoomTypeID.TabIndex = 1
        '
        'lable
        '
        Me.lable.AutoSize = True
        Me.lable.Location = New System.Drawing.Point(6, 126)
        Me.lable.Name = "lable"
        Me.lable.Size = New System.Drawing.Size(39, 16)
        Me.lable.TabIndex = 70
        Me.lable.Text = "Floor"
        '
        'dgvFacilityDatabase
        '
        Me.dgvFacilityDatabase.AllowUserToAddRows = False
        Me.dgvFacilityDatabase.AllowUserToDeleteRows = False
        Me.dgvFacilityDatabase.AllowUserToResizeColumns = False
        Me.dgvFacilityDatabase.AllowUserToResizeRows = False
        Me.dgvFacilityDatabase.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.dgvFacilityDatabase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFacilityDatabase.Location = New System.Drawing.Point(9, 66)
        Me.dgvFacilityDatabase.Name = "dgvFacilityDatabase"
        Me.dgvFacilityDatabase.ReadOnly = True
        Me.dgvFacilityDatabase.Size = New System.Drawing.Size(268, 220)
        Me.dgvFacilityDatabase.TabIndex = 16
        '
        'BtnEditFacility
        '
        Me.BtnEditFacility.Location = New System.Drawing.Point(295, 181)
        Me.BtnEditFacility.Name = "BtnEditFacility"
        Me.BtnEditFacility.Size = New System.Drawing.Size(52, 36)
        Me.BtnEditFacility.TabIndex = 24
        Me.BtnEditFacility.Text = "Edit"
        Me.BtnEditFacility.UseVisualStyleBackColor = True
        '
        'gboFacility
        '
        Me.gboFacility.Controls.Add(Me.tboQuantity)
        Me.gboFacility.Controls.Add(Me.dgvFacilityDatabase)
        Me.gboFacility.Controls.Add(Me.Label7)
        Me.gboFacility.Controls.Add(Me.BtnEditFacility)
        Me.gboFacility.Controls.Add(Me.dgvFacilityChosen)
        Me.gboFacility.Controls.Add(Me.btnAdd)
        Me.gboFacility.Controls.Add(Me.btnNewFacility)
        Me.gboFacility.Controls.Add(Me.btnRemoveFacility)
        Me.gboFacility.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gboFacility.Location = New System.Drawing.Point(14, 262)
        Me.gboFacility.Name = "gboFacility"
        Me.gboFacility.Size = New System.Drawing.Size(649, 298)
        Me.gboFacility.TabIndex = 139
        Me.gboFacility.TabStop = False
        Me.gboFacility.Text = "In Room Facility"
        '
        'tboQuantity
        '
        Me.tboQuantity.Location = New System.Drawing.Point(366, 23)
        Me.tboQuantity.Name = "tboQuantity"
        Me.tboQuantity.Size = New System.Drawing.Size(206, 22)
        Me.tboQuantity.TabIndex = 95
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(221, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 16)
        Me.Label7.TabIndex = 96
        Me.Label7.Text = "Quantity"
        '
        'btnNewFacility
        '
        Me.btnNewFacility.Location = New System.Drawing.Point(295, 124)
        Me.btnNewFacility.Name = "btnNewFacility"
        Me.btnNewFacility.Size = New System.Drawing.Size(52, 36)
        Me.btnNewFacility.TabIndex = 23
        Me.btnNewFacility.Text = "New"
        Me.btnNewFacility.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRoomNumberAvailable)
        Me.GroupBox2.Controls.Add(Me.lblRoomTypeAvailable)
        Me.GroupBox2.Controls.Add(Me.tboStandadCapacity)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cboAddOnePerson)
        Me.GroupBox2.Controls.Add(Me.tboRoomNumber)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tboFloor)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.tboRoomTypeName)
        Me.GroupBox2.Controls.Add(Me.tboRoomTypeID)
        Me.GroupBox2.Controls.Add(Me.lable)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(14, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 244)
        Me.GroupBox2.TabIndex = 138
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Room Information"
        '
        'lblRoomNumberAvailable
        '
        Me.lblRoomNumberAvailable.AutoSize = True
        Me.lblRoomNumberAvailable.Location = New System.Drawing.Point(353, 98)
        Me.lblRoomNumberAvailable.Name = "lblRoomNumberAvailable"
        Me.lblRoomNumberAvailable.Size = New System.Drawing.Size(12, 16)
        Me.lblRoomNumberAvailable.TabIndex = 94
        Me.lblRoomNumberAvailable.Text = "-"
        '
        'lblRoomTypeAvailable
        '
        Me.lblRoomTypeAvailable.AutoSize = True
        Me.lblRoomTypeAvailable.Location = New System.Drawing.Point(353, 33)
        Me.lblRoomTypeAvailable.Name = "lblRoomTypeAvailable"
        Me.lblRoomTypeAvailable.Size = New System.Drawing.Size(12, 16)
        Me.lblRoomTypeAvailable.TabIndex = 93
        Me.lblRoomTypeAvailable.Text = "-"
        '
        'tboStandadCapacity
        '
        Me.tboStandadCapacity.Location = New System.Drawing.Point(141, 157)
        Me.tboStandadCapacity.MaxLength = 1
        Me.tboStandadCapacity.Name = "tboStandadCapacity"
        Me.tboStandadCapacity.Size = New System.Drawing.Size(206, 22)
        Me.tboStandadCapacity.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 157)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 16)
        Me.Label3.TabIndex = 92
        Me.Label3.Text = "Standard Capacity"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 193)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 91
        Me.Label4.Text = "Can Add Person"
        '
        'cboAddOnePerson
        '
        Me.cboAddOnePerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAddOnePerson.FormattingEnabled = True
        Me.cboAddOnePerson.Items.AddRange(New Object() {"----", "Yes", "No"})
        Me.cboAddOnePerson.Location = New System.Drawing.Point(141, 190)
        Me.cboAddOnePerson.Name = "cboAddOnePerson"
        Me.cboAddOnePerson.Size = New System.Drawing.Size(206, 24)
        Me.cboAddOnePerson.TabIndex = 6
        '
        'RoomForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.btnSavenNew)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.gboFacility)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "RoomForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RoomForm"
        CType(Me.dgvFacilityChosen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvFacilityDatabase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gboFacility.ResumeLayout(False)
        Me.gboFacility.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents btnSavenNew As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents tboRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tboFloor As System.Windows.Forms.TextBox
    Friend WithEvents dgvFacilityChosen As System.Windows.Forms.DataGridView
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRemoveFacility As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tboRoomTypeName As System.Windows.Forms.TextBox
    Friend WithEvents tboRoomTypeID As System.Windows.Forms.TextBox
    Friend WithEvents lable As System.Windows.Forms.Label
    Friend WithEvents dgvFacilityDatabase As System.Windows.Forms.DataGridView
    Friend WithEvents BtnEditFacility As System.Windows.Forms.Button
    Friend WithEvents gboFacility As System.Windows.Forms.GroupBox
    Friend WithEvents btnNewFacility As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboAddOnePerson As System.Windows.Forms.ComboBox
    Friend WithEvents tboStandadCapacity As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblRoomNumberAvailable As System.Windows.Forms.Label
    Friend WithEvents lblRoomTypeAvailable As System.Windows.Forms.Label
    Friend WithEvents tboQuantity As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
