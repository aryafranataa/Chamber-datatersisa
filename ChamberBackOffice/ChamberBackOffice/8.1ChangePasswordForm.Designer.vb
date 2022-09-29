<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePasswordForm
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
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tboOldPassword = New System.Windows.Forms.TextBox()
        Me.tboVerifyPassword = New System.Windows.Forms.TextBox()
        Me.tboUserName = New System.Windows.Forms.TextBox()
        Me.tboNewPassword = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblOldPassword = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(222, 219)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
        Me.btnCancel.TabIndex = 94
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tboOldPassword)
        Me.GroupBox2.Controls.Add(Me.tboVerifyPassword)
        Me.GroupBox2.Controls.Add(Me.tboUserName)
        Me.GroupBox2.Controls.Add(Me.tboNewPassword)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.lblOldPassword)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 19)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(300, 183)
        Me.GroupBox2.TabIndex = 93
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Change Password"
        '
        'tboOldPassword
        '
        Me.tboOldPassword.Location = New System.Drawing.Point(116, 57)
        Me.tboOldPassword.Name = "tboOldPassword"
        Me.tboOldPassword.Size = New System.Drawing.Size(170, 22)
        Me.tboOldPassword.TabIndex = 69
        '
        'tboVerifyPassword
        '
        Me.tboVerifyPassword.Location = New System.Drawing.Point(116, 137)
        Me.tboVerifyPassword.Name = "tboVerifyPassword"
        Me.tboVerifyPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tboVerifyPassword.Size = New System.Drawing.Size(170, 22)
        Me.tboVerifyPassword.TabIndex = 69
        '
        'tboUserName
        '
        Me.tboUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboUserName.Location = New System.Drawing.Point(116, 29)
        Me.tboUserName.Name = "tboUserName"
        Me.tboUserName.Size = New System.Drawing.Size(170, 22)
        Me.tboUserName.TabIndex = 68
        '
        'tboNewPassword
        '
        Me.tboNewPassword.Location = New System.Drawing.Point(116, 107)
        Me.tboNewPassword.Name = "tboNewPassword"
        Me.tboNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tboNewPassword.Size = New System.Drawing.Size(170, 22)
        Me.tboNewPassword.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 137)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Verify Password"
        '
        'lblOldPassword
        '
        Me.lblOldPassword.AutoSize = True
        Me.lblOldPassword.Location = New System.Drawing.Point(6, 60)
        Me.lblOldPassword.Name = "lblOldPassword"
        Me.lblOldPassword.Size = New System.Drawing.Size(92, 16)
        Me.lblOldPassword.TabIndex = 65
        Me.lblOldPassword.Text = "Old Password"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 113)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(98, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "New Password"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 16)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Username"
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(20, 219)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 92
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ChangePasswordForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(334, 272)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnSave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "ChangePasswordForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChangePasswordForm"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tboOldPassword As System.Windows.Forms.TextBox
    Friend WithEvents tboVerifyPassword As System.Windows.Forms.TextBox
    Friend WithEvents tboUserName As System.Windows.Forms.TextBox
    Friend WithEvents tboNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblOldPassword As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
