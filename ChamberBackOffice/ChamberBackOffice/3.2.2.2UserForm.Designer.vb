<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserForm
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
        Me.tboVerifyPassword = New System.Windows.Forms.TextBox()
        Me.tboPassword = New System.Windows.Forms.TextBox()
        Me.cboUserGroup = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.tboEmployeeCode = New System.Windows.Forms.TextBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblVerifyPassword = New System.Windows.Forms.Label()
        Me.tboUsername = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.btnSavenNew = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tboJobPosition = New System.Windows.Forms.TextBox()
        Me.lueName = New DevExpress.XtraEditors.LookUpEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblValidOrNot = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.lueName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tboVerifyPassword
        '
        Me.tboVerifyPassword.Location = New System.Drawing.Point(142, 230)
        Me.tboVerifyPassword.MaxLength = 35
        Me.tboVerifyPassword.Name = "tboVerifyPassword"
        Me.tboVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tboVerifyPassword.Size = New System.Drawing.Size(206, 22)
        Me.tboVerifyPassword.TabIndex = 94
        '
        'tboPassword
        '
        Me.tboPassword.Location = New System.Drawing.Point(142, 198)
        Me.tboPassword.MaxLength = 35
        Me.tboPassword.Name = "tboPassword"
        Me.tboPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tboPassword.Size = New System.Drawing.Size(206, 22)
        Me.tboPassword.TabIndex = 93
        '
        'cboUserGroup
        '
        Me.cboUserGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUserGroup.FormattingEnabled = True
        Me.cboUserGroup.Location = New System.Drawing.Point(142, 166)
        Me.cboUserGroup.Name = "cboUserGroup"
        Me.cboUserGroup.Size = New System.Drawing.Size(206, 24)
        Me.cboUserGroup.TabIndex = 92
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 16)
        Me.Label2.TabIndex = 75
        Me.Label2.Text = "Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(71, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Username"
        '
        'tboEmployeeCode
        '
        Me.tboEmployeeCode.Enabled = False
        Me.tboEmployeeCode.Location = New System.Drawing.Point(143, 106)
        Me.tboEmployeeCode.MaxLength = 45
        Me.tboEmployeeCode.Name = "tboEmployeeCode"
        Me.tboEmployeeCode.Size = New System.Drawing.Size(206, 22)
        Me.tboEmployeeCode.TabIndex = 3
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(445, 137)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
        Me.btnCancel.TabIndex = 127
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(445, 32)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 126
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblVerifyPassword
        '
        Me.lblVerifyPassword.AutoSize = True
        Me.lblVerifyPassword.Location = New System.Drawing.Point(5, 230)
        Me.lblVerifyPassword.Name = "lblVerifyPassword"
        Me.lblVerifyPassword.Size = New System.Drawing.Size(105, 16)
        Me.lblVerifyPassword.TabIndex = 72
        Me.lblVerifyPassword.Text = "Verify Password"
        '
        'tboUsername
        '
        Me.tboUsername.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.tboUsername.Location = New System.Drawing.Point(143, 37)
        Me.tboUsername.MaxLength = 15
        Me.tboUsername.Name = "tboUsername"
        Me.tboUsername.Size = New System.Drawing.Size(206, 22)
        Me.tboUsername.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 169)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 16)
        Me.Label4.TabIndex = 69
        Me.Label4.Text = "User Group"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(5, 201)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(68, 16)
        Me.lblPassword.TabIndex = 70
        Me.lblPassword.Text = "Password"
        '
        'btnSavenNew
        '
        Me.btnSavenNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavenNew.Location = New System.Drawing.Point(445, 83)
        Me.btnSavenNew.Name = "btnSavenNew"
        Me.btnSavenNew.Size = New System.Drawing.Size(95, 35)
        Me.btnSavenNew.TabIndex = 128
        Me.btnSavenNew.Text = "Save + New"
        Me.btnSavenNew.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tboJobPosition)
        Me.GroupBox2.Controls.Add(Me.lueName)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblValidOrNot)
        Me.GroupBox2.Controls.Add(Me.tboVerifyPassword)
        Me.GroupBox2.Controls.Add(Me.tboPassword)
        Me.GroupBox2.Controls.Add(Me.tboEmployeeCode)
        Me.GroupBox2.Controls.Add(Me.cboUserGroup)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.lblVerifyPassword)
        Me.GroupBox2.Controls.Add(Me.tboUsername)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblPassword)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(21, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(387, 283)
        Me.GroupBox2.TabIndex = 125
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "User Information"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 16)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Job Position"
        '
        'tboJobPosition
        '
        Me.tboJobPosition.Enabled = False
        Me.tboJobPosition.Location = New System.Drawing.Point(142, 135)
        Me.tboJobPosition.MaxLength = 45
        Me.tboJobPosition.Name = "tboJobPosition"
        Me.tboJobPosition.Size = New System.Drawing.Size(206, 22)
        Me.tboJobPosition.TabIndex = 131
        '
        'lueName
        '
        Me.lueName.Location = New System.Drawing.Point(143, 80)
        Me.lueName.Name = "lueName"
        Me.lueName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueName.Size = New System.Drawing.Size(206, 20)
        Me.lueName.TabIndex = 130
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 16)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Employee Code"
        '
        'lblValidOrNot
        '
        Me.lblValidOrNot.AutoSize = True
        Me.lblValidOrNot.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValidOrNot.ForeColor = System.Drawing.Color.Red
        Me.lblValidOrNot.Location = New System.Drawing.Point(142, 62)
        Me.lblValidOrNot.Name = "lblValidOrNot"
        Me.lblValidOrNot.Size = New System.Drawing.Size(55, 13)
        Me.lblValidOrNot.TabIndex = 95
        Me.lblValidOrNot.Text = "Username"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(445, 198)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(95, 52)
        Me.btnReset.TabIndex = 129
        Me.btnReset.Text = "Reset Password"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'UserForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(561, 382)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnSavenNew)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnReset)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "UserForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UserForm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.lueName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tboVerifyPassword As System.Windows.Forms.TextBox
    Friend WithEvents tboPassword As System.Windows.Forms.TextBox
    Friend WithEvents cboUserGroup As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tboEmployeeCode As System.Windows.Forms.TextBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents lblVerifyPassword As System.Windows.Forms.Label
    Friend WithEvents tboUsername As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents btnSavenNew As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblValidOrNot As System.Windows.Forms.Label
    Friend WithEvents btnReset As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lueName As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tboJobPosition As System.Windows.Forms.TextBox
End Class
