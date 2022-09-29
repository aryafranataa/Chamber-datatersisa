<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sex
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
        Me.tboSexName = New System.Windows.Forms.TextBox()
        Me.tboSexCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgvSex = New System.Windows.Forms.DataGridView()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvSex, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tboSexName)
        Me.GroupBox2.Controls.Add(Me.tboSexCode)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(637, 98)
        Me.GroupBox2.TabIndex = 96
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sex"
        '
        'tboSexName
        '
        Me.tboSexName.Location = New System.Drawing.Point(139, 54)
        Me.tboSexName.MaxLength = 15
        Me.tboSexName.Name = "tboSexName"
        Me.tboSexName.Size = New System.Drawing.Size(321, 22)
        Me.tboSexName.TabIndex = 69
        '
        'tboSexCode
        '
        Me.tboSexCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tboSexCode.Enabled = False
        Me.tboSexCode.Location = New System.Drawing.Point(139, 26)
        Me.tboSexCode.MaxLength = 6
        Me.tboSexCode.Name = "tboSexCode"
        Me.tboSexCode.Size = New System.Drawing.Size(321, 22)
        Me.tboSexCode.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Sex Name"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 29)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(67, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Sex Code"
        '
        'dgvSex
        '
        Me.dgvSex.AllowUserToAddRows = False
        Me.dgvSex.AllowUserToDeleteRows = False
        Me.dgvSex.AllowUserToOrderColumns = True
        Me.dgvSex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSex.Location = New System.Drawing.Point(17, 138)
        Me.dgvSex.Name = "dgvSex"
        Me.dgvSex.ReadOnly = True
        Me.dgvSex.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSex.Size = New System.Drawing.Size(637, 417)
        Me.dgvSex.TabIndex = 95
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(676, 55)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(95, 35)
        Me.btnSave.TabIndex = 99
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'Sex
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.dgvSex)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Sex"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sex"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvSex, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tboSexName As System.Windows.Forms.TextBox
    Friend WithEvents tboSexCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents dgvSex As System.Windows.Forms.DataGridView
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
