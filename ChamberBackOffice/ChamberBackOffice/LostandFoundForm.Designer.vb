<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LostandFoundForm
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSavenNew = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblRoomNumber = New System.Windows.Forms.Label()
        Me.lueFoundby = New DevExpress.XtraEditors.LookUpEdit()
        Me.tboLnFCode = New System.Windows.Forms.TextBox()
        Me.lblLnF = New System.Windows.Forms.Label()
        Me.tboPosition = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tboEmployeeCode = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkNotFound = New System.Windows.Forms.CheckBox()
        Me.dtpFoundDate = New System.Windows.Forms.DateTimePicker()
        Me.lblValidOrNot = New System.Windows.Forms.Label()
        Me.tboItem = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lueLostby = New DevExpress.XtraEditors.LookUpEdit()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.chkNotLost = New System.Windows.Forms.CheckBox()
        Me.dtpLostDate = New System.Windows.Forms.DateTimePicker()
        Me.tboIdentityCard = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tboCustomerCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tboRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.lueFoundby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.lueLostby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 16)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Found Date"
        '
        'btnSavenNew
        '
        Me.btnSavenNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavenNew.Location = New System.Drawing.Point(687, 89)
        Me.btnSavenNew.Name = "btnSavenNew"
        Me.btnSavenNew.Size = New System.Drawing.Size(95, 35)
        Me.btnSavenNew.TabIndex = 15
        Me.btnSavenNew.Text = "Save + New"
        Me.btnSavenNew.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblRoomNumber)
        Me.GroupBox2.Controls.Add(Me.lueFoundby)
        Me.GroupBox2.Controls.Add(Me.tboLnFCode)
        Me.GroupBox2.Controls.Add(Me.lblLnF)
        Me.GroupBox2.Controls.Add(Me.tboPosition)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tboEmployeeCode)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.chkNotFound)
        Me.GroupBox2.Controls.Add(Me.dtpFoundDate)
        Me.GroupBox2.Controls.Add(Me.lblValidOrNot)
        Me.GroupBox2.Controls.Add(Me.tboItem)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.tboRoomNumber)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 401)
        Me.GroupBox2.TabIndex = 228
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Housekeeping Lost and Found Tag"
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.ForeColor = System.Drawing.Color.Red
        Me.lblRoomNumber.Location = New System.Drawing.Point(278, 102)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(12, 16)
        Me.lblRoomNumber.TabIndex = 244
        Me.lblRoomNumber.Text = "-"
        '
        'lueFoundby
        '
        Me.lueFoundby.Location = New System.Drawing.Point(116, 130)
        Me.lueFoundby.Name = "lueFoundby"
        Me.lueFoundby.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueFoundby.Properties.Appearance.Options.UseFont = True
        Me.lueFoundby.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueFoundby.Size = New System.Drawing.Size(159, 22)
        Me.lueFoundby.TabIndex = 244
        '
        'tboLnFCode
        '
        Me.tboLnFCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboLnFCode.Enabled = False
        Me.tboLnFCode.Location = New System.Drawing.Point(116, 36)
        Me.tboLnFCode.MaxLength = 8
        Me.tboLnFCode.Name = "tboLnFCode"
        Me.tboLnFCode.Size = New System.Drawing.Size(159, 22)
        Me.tboLnFCode.TabIndex = 1
        '
        'lblLnF
        '
        Me.lblLnF.AutoSize = True
        Me.lblLnF.Location = New System.Drawing.Point(6, 39)
        Me.lblLnF.Name = "lblLnF"
        Me.lblLnF.Size = New System.Drawing.Size(66, 16)
        Me.lblLnF.TabIndex = 235
        Me.lblLnF.Text = "LnF Code"
        '
        'tboPosition
        '
        Me.tboPosition.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboPosition.Enabled = False
        Me.tboPosition.Location = New System.Drawing.Point(116, 193)
        Me.tboPosition.MaxLength = 20
        Me.tboPosition.Name = "tboPosition"
        Me.tboPosition.Size = New System.Drawing.Size(159, 22)
        Me.tboPosition.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 196)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 233
        Me.Label5.Text = "Position"
        '
        'tboEmployeeCode
        '
        Me.tboEmployeeCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboEmployeeCode.Enabled = False
        Me.tboEmployeeCode.Location = New System.Drawing.Point(116, 162)
        Me.tboEmployeeCode.MaxLength = 20
        Me.tboEmployeeCode.Name = "tboEmployeeCode"
        Me.tboEmployeeCode.Size = New System.Drawing.Size(159, 22)
        Me.tboEmployeeCode.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 16)
        Me.Label4.TabIndex = 231
        Me.Label4.Text = "Employee Code"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 16)
        Me.Label2.TabIndex = 229
        Me.Label2.Text = "Found by"
        '
        'chkNotFound
        '
        Me.chkNotFound.AutoSize = True
        Me.chkNotFound.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotFound.Location = New System.Drawing.Point(281, 70)
        Me.chkNotFound.Name = "chkNotFound"
        Me.chkNotFound.Size = New System.Drawing.Size(56, 17)
        Me.chkNotFound.TabIndex = 2
        Me.chkNotFound.Text = "Found"
        Me.chkNotFound.UseVisualStyleBackColor = True
        '
        'dtpFoundDate
        '
        Me.dtpFoundDate.Location = New System.Drawing.Point(116, 68)
        Me.dtpFoundDate.Name = "dtpFoundDate"
        Me.dtpFoundDate.Size = New System.Drawing.Size(159, 22)
        Me.dtpFoundDate.TabIndex = 3
        '
        'lblValidOrNot
        '
        Me.lblValidOrNot.AutoSize = True
        Me.lblValidOrNot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidOrNot.ForeColor = System.Drawing.Color.Red
        Me.lblValidOrNot.Location = New System.Drawing.Point(113, 52)
        Me.lblValidOrNot.Name = "lblValidOrNot"
        Me.lblValidOrNot.Size = New System.Drawing.Size(0, 13)
        Me.lblValidOrNot.TabIndex = 225
        '
        'tboItem
        '
        Me.tboItem.Location = New System.Drawing.Point(116, 228)
        Me.tboItem.MaxLength = 200
        Me.tboItem.Multiline = True
        Me.tboItem.Name = "tboItem"
        Me.tboItem.Size = New System.Drawing.Size(234, 143)
        Me.tboItem.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.lueLostby)
        Me.GroupBox3.Controls.Add(Me.lblStatus)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.chkNotLost)
        Me.GroupBox3.Controls.Add(Me.dtpLostDate)
        Me.GroupBox3.Controls.Add(Me.tboIdentityCard)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.tboCustomerCode)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(361, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(295, 401)
        Me.GroupBox3.TabIndex = 223
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Customer Information"
        '
        'lueLostby
        '
        Me.lueLostby.Location = New System.Drawing.Point(119, 99)
        Me.lueLostby.Name = "lueLostby"
        Me.lueLostby.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueLostby.Properties.Appearance.Options.UseFont = True
        Me.lueLostby.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLostby.Size = New System.Drawing.Size(159, 22)
        Me.lueLostby.TabIndex = 243
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.ForeColor = System.Drawing.Color.Red
        Me.lblStatus.Location = New System.Drawing.Point(116, 199)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(78, 16)
        Me.lblStatus.TabIndex = 242
        Me.lblStatus.Text = "Suspended"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 199)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 16)
        Me.Label6.TabIndex = 241
        Me.Label6.Text = "Status Tag"
        '
        'chkNotLost
        '
        Me.chkNotLost.AutoSize = True
        Me.chkNotLost.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotLost.Location = New System.Drawing.Point(261, 72)
        Me.chkNotLost.Name = "chkNotLost"
        Me.chkNotLost.Size = New System.Drawing.Size(15, 14)
        Me.chkNotLost.TabIndex = 9
        Me.chkNotLost.UseVisualStyleBackColor = True
        '
        'dtpLostDate
        '
        Me.dtpLostDate.Location = New System.Drawing.Point(119, 68)
        Me.dtpLostDate.Name = "dtpLostDate"
        Me.dtpLostDate.Size = New System.Drawing.Size(136, 22)
        Me.dtpLostDate.TabIndex = 10
        '
        'tboIdentityCard
        '
        Me.tboIdentityCard.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboIdentityCard.Enabled = False
        Me.tboIdentityCard.Location = New System.Drawing.Point(119, 162)
        Me.tboIdentityCard.MaxLength = 20
        Me.tboIdentityCard.Name = "tboIdentityCard"
        Me.tboIdentityCard.Size = New System.Drawing.Size(159, 22)
        Me.tboIdentityCard.TabIndex = 13
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(9, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 188
        Me.Label8.Text = "Lost Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 165)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 239
        Me.Label7.Text = "Identity Card"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 102)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 235
        Me.Label10.Text = "Lost by"
        '
        'tboCustomerCode
        '
        Me.tboCustomerCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboCustomerCode.Enabled = False
        Me.tboCustomerCode.Location = New System.Drawing.Point(119, 130)
        Me.tboCustomerCode.MaxLength = 8
        Me.tboCustomerCode.Name = "tboCustomerCode"
        Me.tboCustomerCode.Size = New System.Drawing.Size(159, 22)
        Me.tboCustomerCode.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(9, 133)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 16)
        Me.Label9.TabIndex = 237
        Me.Label9.Text = "Customer Code"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 225)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(33, 16)
        Me.Label13.TabIndex = 189
        Me.Label13.Text = "Item"
        '
        'tboRoomNumber
        '
        Me.tboRoomNumber.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboRoomNumber.Location = New System.Drawing.Point(116, 99)
        Me.tboRoomNumber.MaxLength = 4
        Me.tboRoomNumber.Name = "tboRoomNumber"
        Me.tboRoomNumber.Size = New System.Drawing.Size(159, 22)
        Me.tboRoomNumber.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 16)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Room Number"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(687, 42)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 14
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(687, 205)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'LostandFoundForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.btnSavenNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LostandFoundForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lost and Found Tag"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.lueFoundby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.lueLostby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSavenNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblValidOrNot As System.Windows.Forms.Label
    Friend WithEvents tboItem As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents dtpFoundDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpLostDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents chkNotFound As System.Windows.Forms.CheckBox
    Friend WithEvents chkNotLost As System.Windows.Forms.CheckBox
    Friend WithEvents tboPosition As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tboEmployeeCode As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tboIdentityCard As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tboCustomerCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tboLnFCode As System.Windows.Forms.TextBox
    Friend WithEvents lblLnF As System.Windows.Forms.Label
    Friend WithEvents lueLostby As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents lueFoundby As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents tboRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblRoomNumber As System.Windows.Forms.Label
End Class
