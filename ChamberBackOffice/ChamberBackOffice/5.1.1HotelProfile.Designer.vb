<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HotelProfile
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tboWebsite = New System.Windows.Forms.TextBox()
        Me.tboEmail = New System.Windows.Forms.TextBox()
        Me.tboFax = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tboPhone = New System.Windows.Forms.TextBox()
        Me.tboPhone2 = New System.Windows.Forms.TextBox()
        Me.tboHotelAddress = New System.Windows.Forms.TextBox()
        Me.tboHotelName = New System.Windows.Forms.TextBox()
        Me.tboNPWP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(673, 51)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 88
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox2.Controls.Add(Me.tboWebsite)
        Me.GroupBox2.Controls.Add(Me.tboEmail)
        Me.GroupBox2.Controls.Add(Me.tboFax)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.tboPhone)
        Me.GroupBox2.Controls.Add(Me.tboPhone2)
        Me.GroupBox2.Controls.Add(Me.tboHotelAddress)
        Me.GroupBox2.Controls.Add(Me.tboHotelName)
        Me.GroupBox2.Controls.Add(Me.tboNPWP)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(631, 436)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Hotel Profile Information"
        '
        'tboWebsite
        '
        Me.tboWebsite.Location = New System.Drawing.Point(139, 325)
        Me.tboWebsite.MaxLength = 45
        Me.tboWebsite.Name = "tboWebsite"
        Me.tboWebsite.Size = New System.Drawing.Size(308, 22)
        Me.tboWebsite.TabIndex = 92
        '
        'tboEmail
        '
        Me.tboEmail.Location = New System.Drawing.Point(139, 364)
        Me.tboEmail.MaxLength = 45
        Me.tboEmail.Name = "tboEmail"
        Me.tboEmail.Size = New System.Drawing.Size(308, 22)
        Me.tboEmail.TabIndex = 93
        '
        'tboFax
        '
        Me.tboFax.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboFax.Location = New System.Drawing.Point(139, 288)
        Me.tboFax.MaxLength = 20
        Me.tboFax.Name = "tboFax"
        Me.tboFax.Size = New System.Drawing.Size(308, 22)
        Me.tboFax.TabIndex = 91
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 372)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 16)
        Me.Label6.TabIndex = 90
        Me.Label6.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 212)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 16)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Phone Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 328)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(58, 16)
        Me.Label4.TabIndex = 87
        Me.Label4.Text = "Website"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 251)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 16)
        Me.Label2.TabIndex = 83
        Me.Label2.Text = "Phone Number 2"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 291)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 16)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "Fax"
        '
        'tboPhone
        '
        Me.tboPhone.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboPhone.Location = New System.Drawing.Point(139, 209)
        Me.tboPhone.MaxLength = 20
        Me.tboPhone.Name = "tboPhone"
        Me.tboPhone.Size = New System.Drawing.Size(308, 22)
        Me.tboPhone.TabIndex = 84
        '
        'tboPhone2
        '
        Me.tboPhone2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboPhone2.Location = New System.Drawing.Point(139, 248)
        Me.tboPhone2.MaxLength = 20
        Me.tboPhone2.Name = "tboPhone2"
        Me.tboPhone2.Size = New System.Drawing.Size(308, 22)
        Me.tboPhone2.TabIndex = 85
        '
        'tboHotelAddress
        '
        Me.tboHotelAddress.Location = New System.Drawing.Point(139, 73)
        Me.tboHotelAddress.MaxLength = 60
        Me.tboHotelAddress.Multiline = True
        Me.tboHotelAddress.Name = "tboHotelAddress"
        Me.tboHotelAddress.Size = New System.Drawing.Size(468, 82)
        Me.tboHotelAddress.TabIndex = 69
        '
        'tboHotelName
        '
        Me.tboHotelName.Location = New System.Drawing.Point(139, 36)
        Me.tboHotelName.MaxLength = 45
        Me.tboHotelName.Name = "tboHotelName"
        Me.tboHotelName.Size = New System.Drawing.Size(468, 22)
        Me.tboHotelName.TabIndex = 68
        '
        'tboNPWP
        '
        Me.tboNPWP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboNPWP.Location = New System.Drawing.Point(139, 172)
        Me.tboNPWP.MaxLength = 45
        Me.tboNPWP.Name = "tboNPWP"
        Me.tboNPWP.Size = New System.Drawing.Size(308, 22)
        Me.tboNPWP.TabIndex = 80
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Hotel Address"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 39)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(80, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Hotel Name"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 178)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 16)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "NPWP"
        '
        'HotelProfile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "HotelProfile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HotelProfile"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tboHotelAddress As System.Windows.Forms.TextBox
    Friend WithEvents tboHotelName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents tboNPWP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tboWebsite As System.Windows.Forms.TextBox
    Friend WithEvents tboEmail As System.Windows.Forms.TextBox
    Friend WithEvents tboFax As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tboPhone As System.Windows.Forms.TextBox
    Friend WithEvents tboPhone2 As System.Windows.Forms.TextBox
End Class
