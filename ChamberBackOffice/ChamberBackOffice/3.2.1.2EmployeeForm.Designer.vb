<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.tboAddress = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tboEmployeeName = New System.Windows.Forms.TextBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.lblOldPassword = New System.Windows.Forms.Label()
        Me.tboOldPassword = New System.Windows.Forms.TextBox()
        Me.cboUserGroup = New System.Windows.Forms.ComboBox()
        Me.lblUserGroup = New System.Windows.Forms.Label()
        Me.chkActive = New System.Windows.Forms.CheckBox()
        Me.lblVerifyPassword = New System.Windows.Forms.Label()
        Me.tboVerifyPassword = New System.Windows.Forms.TextBox()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.tboPassword = New System.Windows.Forms.TextBox()
        Me.lblUsername = New System.Windows.Forms.Label()
        Me.btnAddJobPosition = New System.Windows.Forms.Button()
        Me.cboJobPosition = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.tboUsername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tboEmail = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.tboPhone1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tboPhone2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSavenNew = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblValidOrNot = New System.Windows.Forms.Label()
        Me.cboSex = New System.Windows.Forms.ComboBox()
        Me.tboEmployeeCode = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tboAddress
        '
        Me.tboAddress.Location = New System.Drawing.Point(116, 129)
        Me.tboAddress.MaxLength = 45
        Me.tboAddress.Multiline = True
        Me.tboAddress.Name = "tboAddress"
        Me.tboAddress.Size = New System.Drawing.Size(234, 143)
        Me.tboAddress.TabIndex = 4
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(6, 132)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 16)
        Me.Label13.TabIndex = 189
        Me.Label13.Text = "Address"
        '
        'tboEmployeeName
        '
        Me.tboEmployeeName.Location = New System.Drawing.Point(116, 71)
        Me.tboEmployeeName.MaxLength = 45
        Me.tboEmployeeName.Name = "tboEmployeeName"
        Me.tboEmployeeName.Size = New System.Drawing.Size(234, 22)
        Me.tboEmployeeName.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblOldPassword)
        Me.GroupBox4.Controls.Add(Me.tboOldPassword)
        Me.GroupBox4.Controls.Add(Me.cboUserGroup)
        Me.GroupBox4.Controls.Add(Me.lblUserGroup)
        Me.GroupBox4.Controls.Add(Me.chkActive)
        Me.GroupBox4.Controls.Add(Me.lblVerifyPassword)
        Me.GroupBox4.Controls.Add(Me.tboVerifyPassword)
        Me.GroupBox4.Controls.Add(Me.lblPassword)
        Me.GroupBox4.Controls.Add(Me.tboPassword)
        Me.GroupBox4.Controls.Add(Me.lblUsername)
        Me.GroupBox4.Controls.Add(Me.btnAddJobPosition)
        Me.GroupBox4.Controls.Add(Me.cboJobPosition)
        Me.GroupBox4.Controls.Add(Me.Label20)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Controls.Add(Me.tboUsername)
        Me.GroupBox4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(12, 305)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(656, 170)
        Me.GroupBox4.TabIndex = 224
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Job Information"
        '
        'lblOldPassword
        '
        Me.lblOldPassword.AutoSize = True
        Me.lblOldPassword.Location = New System.Drawing.Point(358, 30)
        Me.lblOldPassword.Name = "lblOldPassword"
        Me.lblOldPassword.Size = New System.Drawing.Size(92, 16)
        Me.lblOldPassword.TabIndex = 233
        Me.lblOldPassword.Text = "Old Password"
        '
        'tboOldPassword
        '
        Me.tboOldPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tboOldPassword.Location = New System.Drawing.Point(477, 27)
        Me.tboOldPassword.MaxLength = 15
        Me.tboOldPassword.Name = "tboOldPassword"
        Me.tboOldPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tboOldPassword.Size = New System.Drawing.Size(152, 22)
        Me.tboOldPassword.TabIndex = 11
        '
        'cboUserGroup
        '
        Me.cboUserGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserGroup.FormattingEnabled = True
        Me.cboUserGroup.Location = New System.Drawing.Point(117, 96)
        Me.cboUserGroup.Name = "cboUserGroup"
        Me.cboUserGroup.Size = New System.Drawing.Size(197, 24)
        Me.cboUserGroup.TabIndex = 10
        '
        'lblUserGroup
        '
        Me.lblUserGroup.AutoSize = True
        Me.lblUserGroup.Location = New System.Drawing.Point(6, 99)
        Me.lblUserGroup.Name = "lblUserGroup"
        Me.lblUserGroup.Size = New System.Drawing.Size(77, 16)
        Me.lblUserGroup.TabIndex = 231
        Me.lblUserGroup.Text = "User Group"
        '
        'chkActive
        '
        Me.chkActive.AutoSize = True
        Me.chkActive.Location = New System.Drawing.Point(320, 58)
        Me.chkActive.Name = "chkActive"
        Me.chkActive.Size = New System.Drawing.Size(15, 14)
        Me.chkActive.TabIndex = 222
        Me.chkActive.UseVisualStyleBackColor = True
        '
        'lblVerifyPassword
        '
        Me.lblVerifyPassword.AutoSize = True
        Me.lblVerifyPassword.Location = New System.Drawing.Point(357, 102)
        Me.lblVerifyPassword.Name = "lblVerifyPassword"
        Me.lblVerifyPassword.Size = New System.Drawing.Size(105, 16)
        Me.lblVerifyPassword.TabIndex = 229
        Me.lblVerifyPassword.Text = "Verify Password"
        '
        'tboVerifyPassword
        '
        Me.tboVerifyPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tboVerifyPassword.Location = New System.Drawing.Point(477, 99)
        Me.tboVerifyPassword.MaxLength = 15
        Me.tboVerifyPassword.Name = "tboVerifyPassword"
        Me.tboVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tboVerifyPassword.Size = New System.Drawing.Size(152, 22)
        Me.tboVerifyPassword.TabIndex = 13
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(358, 77)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(68, 16)
        Me.lblPassword.TabIndex = 227
        Me.lblPassword.Text = "Password"
        '
        'tboPassword
        '
        Me.tboPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tboPassword.Location = New System.Drawing.Point(477, 74)
        Me.tboPassword.MaxLength = 15
        Me.tboPassword.Name = "tboPassword"
        Me.tboPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tboPassword.Size = New System.Drawing.Size(152, 22)
        Me.tboPassword.TabIndex = 12
        '
        'lblUsername
        '
        Me.lblUsername.AutoSize = True
        Me.lblUsername.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUsername.ForeColor = System.Drawing.Color.Red
        Me.lblUsername.Location = New System.Drawing.Point(114, 80)
        Me.lblUsername.Name = "lblUsername"
        Me.lblUsername.Size = New System.Drawing.Size(55, 13)
        Me.lblUsername.TabIndex = 226
        Me.lblUsername.Text = "Username"
        '
        'btnAddJobPosition
        '
        Me.btnAddJobPosition.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddJobPosition.Location = New System.Drawing.Point(320, 27)
        Me.btnAddJobPosition.Name = "btnAddJobPosition"
        Me.btnAddJobPosition.Size = New System.Drawing.Size(30, 21)
        Me.btnAddJobPosition.TabIndex = 216
        Me.btnAddJobPosition.Text = "+"
        Me.btnAddJobPosition.UseVisualStyleBackColor = True
        '
        'cboJobPosition
        '
        Me.cboJobPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboJobPosition.FormattingEnabled = True
        Me.cboJobPosition.Location = New System.Drawing.Point(117, 27)
        Me.cboJobPosition.Name = "cboJobPosition"
        Me.cboJobPosition.Size = New System.Drawing.Size(197, 24)
        Me.cboJobPosition.TabIndex = 8
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(6, 30)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 16)
        Me.Label20.TabIndex = 193
        Me.Label20.Text = "Job Position"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(6, 58)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(71, 16)
        Me.Label21.TabIndex = 194
        Me.Label21.Text = "Username"
        '
        'tboUsername
        '
        Me.tboUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tboUsername.Location = New System.Drawing.Point(117, 55)
        Me.tboUsername.MaxLength = 15
        Me.tboUsername.Name = "tboUsername"
        Me.tboUsername.Size = New System.Drawing.Size(197, 22)
        Me.tboUsername.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 141
        Me.Label1.Text = "Employee Code"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tboEmail)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.tboPhone1)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.tboPhone2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(361, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(295, 287)
        Me.GroupBox3.TabIndex = 223
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Contact Information"
        '
        'tboEmail
        '
        Me.tboEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tboEmail.Location = New System.Drawing.Point(69, 83)
        Me.tboEmail.MaxLength = 45
        Me.tboEmail.Name = "tboEmail"
        Me.tboEmail.Size = New System.Drawing.Size(208, 22)
        Me.tboEmail.TabIndex = 7
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 86)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 16)
        Me.Label17.TabIndex = 201
        Me.Label17.Text = "Email"
        '
        'tboPhone1
        '
        Me.tboPhone1.Location = New System.Drawing.Point(69, 27)
        Me.tboPhone1.MaxLength = 15
        Me.tboPhone1.Name = "tboPhone1"
        Me.tboPhone1.Size = New System.Drawing.Size(208, 22)
        Me.tboPhone1.TabIndex = 5
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(6, 30)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(57, 16)
        Me.Label15.TabIndex = 193
        Me.Label15.Text = "Phone 1"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(57, 16)
        Me.Label14.TabIndex = 194
        Me.Label14.Text = "Phone 2"
        '
        'tboPhone2
        '
        Me.tboPhone2.Location = New System.Drawing.Point(69, 55)
        Me.tboPhone2.MaxLength = 15
        Me.tboPhone2.Name = "tboPhone2"
        Me.tboPhone2.Size = New System.Drawing.Size(208, 22)
        Me.tboPhone2.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 16)
        Me.Label3.TabIndex = 142
        Me.Label3.Text = "Employee Name  "
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
        Me.GroupBox2.Controls.Add(Me.lblValidOrNot)
        Me.GroupBox2.Controls.Add(Me.tboAddress)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cboSex)
        Me.GroupBox2.Controls.Add(Me.tboEmployeeCode)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.tboEmployeeName)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(656, 287)
        Me.GroupBox2.TabIndex = 221
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Employee Profile Information"
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
        'cboSex
        '
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Location = New System.Drawing.Point(116, 99)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(234, 24)
        Me.cboSex.TabIndex = 3
        '
        'tboEmployeeCode
        '
        Me.tboEmployeeCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboEmployeeCode.Enabled = False
        Me.tboEmployeeCode.Location = New System.Drawing.Point(116, 27)
        Me.tboEmployeeCode.MaxLength = 8
        Me.tboEmployeeCode.Name = "tboEmployeeCode"
        Me.tboEmployeeCode.Size = New System.Drawing.Size(234, 22)
        Me.tboEmployeeCode.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 16)
        Me.Label8.TabIndex = 188
        Me.Label8.Text = "Sex "
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(687, 205)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
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
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.btnSavenNew)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "EmployeeForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "EmployeeForm"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tboAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tboEmployeeName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddJobPosition As System.Windows.Forms.Button
    Friend WithEvents cboJobPosition As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tboUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents tboEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents tboPhone1 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents tboPhone2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSavenNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tboEmployeeCode As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents lblValidOrNot As System.Windows.Forms.Label
    Friend WithEvents lblUsername As System.Windows.Forms.Label
    Friend WithEvents lblVerifyPassword As System.Windows.Forms.Label
    Friend WithEvents tboVerifyPassword As System.Windows.Forms.TextBox
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents tboPassword As System.Windows.Forms.TextBox
    Friend WithEvents chkActive As System.Windows.Forms.CheckBox
    Friend WithEvents cboUserGroup As System.Windows.Forms.ComboBox
    Friend WithEvents lblUserGroup As System.Windows.Forms.Label
    Friend WithEvents lblOldPassword As System.Windows.Forms.Label
    Friend WithEvents tboOldPassword As System.Windows.Forms.TextBox
End Class
