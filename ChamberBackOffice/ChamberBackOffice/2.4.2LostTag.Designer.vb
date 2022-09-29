<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LostandFoundTag
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tboNote = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblRoomNumber = New System.Windows.Forms.Label()
        Me.tboLnFCode = New System.Windows.Forms.TextBox()
        Me.lblLnF = New System.Windows.Forms.Label()
        Me.lblValidOrNot = New System.Windows.Forms.Label()
        Me.tboItem = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.tboRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSavenNew = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lueLostby = New DevExpress.XtraEditors.LookUpEdit()
        Me.dtpLostDate = New System.Windows.Forms.DateTimePicker()
        Me.tboIdentityCard = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tboCustomerCode = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnMinus1 = New System.Windows.Forms.Button()
        Me.btnPlus1 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.lueLostby.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnMinus1)
        Me.GroupBox2.Controls.Add(Me.lueLostby)
        Me.GroupBox2.Controls.Add(Me.btnPlus1)
        Me.GroupBox2.Controls.Add(Me.tboNote)
        Me.GroupBox2.Controls.Add(Me.dtpLostDate)
        Me.GroupBox2.Controls.Add(Me.tboIdentityCard)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.lblRoomNumber)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tboLnFCode)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.lblLnF)
        Me.GroupBox2.Controls.Add(Me.tboCustomerCode)
        Me.GroupBox2.Controls.Add(Me.lblValidOrNot)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.tboItem)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.tboRoomNumber)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(603, 528)
        Me.GroupBox2.TabIndex = 229
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Housekeeping Lost and Found Tag"
        '
        'tboNote
        '
        Me.tboNote.Location = New System.Drawing.Point(192, 363)
        Me.tboNote.MaxLength = 200
        Me.tboNote.Multiline = True
        Me.tboNote.Name = "tboNote"
        Me.tboNote.Size = New System.Drawing.Size(337, 143)
        Me.tboNote.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 366)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 16)
        Me.Label6.TabIndex = 246
        Me.Label6.Text = "Note"
        '
        'lblRoomNumber
        '
        Me.lblRoomNumber.AutoSize = True
        Me.lblRoomNumber.ForeColor = System.Drawing.Color.Red
        Me.lblRoomNumber.Location = New System.Drawing.Point(435, 105)
        Me.lblRoomNumber.Name = "lblRoomNumber"
        Me.lblRoomNumber.Size = New System.Drawing.Size(12, 16)
        Me.lblRoomNumber.TabIndex = 244
        Me.lblRoomNumber.Text = "-"
        '
        'tboLnFCode
        '
        Me.tboLnFCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboLnFCode.Enabled = False
        Me.tboLnFCode.Location = New System.Drawing.Point(192, 36)
        Me.tboLnFCode.MaxLength = 8
        Me.tboLnFCode.Name = "tboLnFCode"
        Me.tboLnFCode.Size = New System.Drawing.Size(234, 22)
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
        Me.tboItem.Location = New System.Drawing.Point(192, 228)
        Me.tboItem.MaxLength = 200
        Me.tboItem.Multiline = True
        Me.tboItem.Name = "tboItem"
        Me.tboItem.Size = New System.Drawing.Size(337, 121)
        Me.tboItem.TabIndex = 9
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
        Me.tboRoomNumber.Location = New System.Drawing.Point(192, 99)
        Me.tboRoomNumber.MaxLength = 4
        Me.tboRoomNumber.Name = "tboRoomNumber"
        Me.tboRoomNumber.Size = New System.Drawing.Size(234, 22)
        Me.tboRoomNumber.TabIndex = 5
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
        'btnSavenNew
        '
        Me.btnSavenNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSavenNew.Location = New System.Drawing.Point(665, 89)
        Me.btnSavenNew.Name = "btnSavenNew"
        Me.btnSavenNew.Size = New System.Drawing.Size(95, 35)
        Me.btnSavenNew.TabIndex = 12
        Me.btnSavenNew.Text = "Save + New"
        Me.btnSavenNew.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Location = New System.Drawing.Point(665, 183)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(95, 35)
        Me.btnCancel.TabIndex = 13
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(665, 42)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lueLostby
        '
        Me.lueLostby.Location = New System.Drawing.Point(192, 130)
        Me.lueLostby.Name = "lueLostby"
        Me.lueLostby.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lueLostby.Properties.Appearance.Options.UseFont = True
        Me.lueLostby.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.lueLostby.Size = New System.Drawing.Size(234, 22)
        Me.lueLostby.TabIndex = 6
        '
        'dtpLostDate
        '
        Me.dtpLostDate.Location = New System.Drawing.Point(192, 67)
        Me.dtpLostDate.Name = "dtpLostDate"
        Me.dtpLostDate.Size = New System.Drawing.Size(234, 22)
        Me.dtpLostDate.TabIndex = 2
        '
        'tboIdentityCard
        '
        Me.tboIdentityCard.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboIdentityCard.Enabled = False
        Me.tboIdentityCard.Location = New System.Drawing.Point(192, 193)
        Me.tboIdentityCard.MaxLength = 20
        Me.tboIdentityCard.Name = "tboIdentityCard"
        Me.tboIdentityCard.Size = New System.Drawing.Size(234, 22)
        Me.tboIdentityCard.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 16)
        Me.Label8.TabIndex = 247
        Me.Label8.Text = "Lost Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 196)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 16)
        Me.Label7.TabIndex = 250
        Me.Label7.Text = "Identity Card"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(6, 133)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 16)
        Me.Label10.TabIndex = 248
        Me.Label10.Text = "Lost by"
        '
        'tboCustomerCode
        '
        Me.tboCustomerCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboCustomerCode.Enabled = False
        Me.tboCustomerCode.Location = New System.Drawing.Point(192, 161)
        Me.tboCustomerCode.MaxLength = 8
        Me.tboCustomerCode.Name = "tboCustomerCode"
        Me.tboCustomerCode.Size = New System.Drawing.Size(234, 22)
        Me.tboCustomerCode.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 164)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(101, 16)
        Me.Label9.TabIndex = 249
        Me.Label9.Text = "Customer Code"
        '
        'btnMinus1
        '
        Me.btnMinus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMinus1.Location = New System.Drawing.Point(434, 70)
        Me.btnMinus1.Name = "btnMinus1"
        Me.btnMinus1.Size = New System.Drawing.Size(32, 21)
        Me.btnMinus1.TabIndex = 3
        Me.btnMinus1.Text = "-1"
        Me.btnMinus1.UseVisualStyleBackColor = True
        '
        'btnPlus1
        '
        Me.btnPlus1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus1.Location = New System.Drawing.Point(472, 70)
        Me.btnPlus1.Name = "btnPlus1"
        Me.btnPlus1.Size = New System.Drawing.Size(32, 21)
        Me.btnPlus1.TabIndex = 4
        Me.btnPlus1.Text = "+1"
        Me.btnPlus1.UseVisualStyleBackColor = True
        '
        'LostandFoundTag
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.btnSavenNew)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "LostandFoundTag"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Lost Tag"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.lueLostby.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblRoomNumber As System.Windows.Forms.Label
    Friend WithEvents tboLnFCode As System.Windows.Forms.TextBox
    Friend WithEvents lblLnF As System.Windows.Forms.Label
    Friend WithEvents lblValidOrNot As System.Windows.Forms.Label
    Friend WithEvents tboItem As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tboRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSavenNew As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents tboNote As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lueLostby As DevExpress.XtraEditors.LookUpEdit
    Friend WithEvents dtpLostDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents tboIdentityCard As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents tboCustomerCode As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnMinus1 As System.Windows.Forms.Button
    Friend WithEvents btnPlus1 As System.Windows.Forms.Button
End Class
