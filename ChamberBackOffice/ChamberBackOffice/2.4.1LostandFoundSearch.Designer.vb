<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LostandFound
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
        Me.dgvLostandFound = New System.Windows.Forms.DataGridView()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.tboRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tboLostby = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tboFoundby = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tboItem = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnLost = New System.Windows.Forms.Button()
        Me.Found = New System.Windows.Forms.Button()
        Me.btnRelease = New System.Windows.Forms.Button()
        CType(Me.dgvLostandFound, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(682, 437)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(95, 35)
        Me.btnRefresh.TabIndex = 96
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvLostandFound
        '
        Me.dgvLostandFound.AllowUserToAddRows = False
        Me.dgvLostandFound.AllowUserToDeleteRows = False
        Me.dgvLostandFound.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLostandFound.Location = New System.Drawing.Point(17, 155)
        Me.dgvLostandFound.Name = "dgvLostandFound"
        Me.dgvLostandFound.ReadOnly = True
        Me.dgvLostandFound.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLostandFound.Size = New System.Drawing.Size(649, 403)
        Me.dgvLostandFound.TabIndex = 91
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(682, 49)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(95, 35)
        Me.btnSearch.TabIndex = 93
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'tboRoomNumber
        '
        Me.tboRoomNumber.Location = New System.Drawing.Point(132, 25)
        Me.tboRoomNumber.MaxLength = 4
        Me.tboRoomNumber.Name = "tboRoomNumber"
        Me.tboRoomNumber.Size = New System.Drawing.Size(183, 22)
        Me.tboRoomNumber.TabIndex = 68
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(6, 28)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Room Number"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tboLostby)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.tboFoundby)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tboItem)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tboRoomNumber)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 135)
        Me.GroupBox2.TabIndex = 92
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Search Item by"
        '
        'tboLostby
        '
        Me.tboLostby.Location = New System.Drawing.Point(442, 56)
        Me.tboLostby.MaxLength = 300
        Me.tboLostby.Name = "tboLostby"
        Me.tboLostby.Size = New System.Drawing.Size(183, 22)
        Me.tboLostby.TabIndex = 82
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(337, 59)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 16)
        Me.Label7.TabIndex = 81
        Me.Label7.Text = "Lost by"
        '
        'tboFoundby
        '
        Me.tboFoundby.Location = New System.Drawing.Point(442, 25)
        Me.tboFoundby.MaxLength = 300
        Me.tboFoundby.Name = "tboFoundby"
        Me.tboFoundby.Size = New System.Drawing.Size(183, 22)
        Me.tboFoundby.TabIndex = 80
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(337, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 16)
        Me.Label6.TabIndex = 79
        Me.Label6.Text = "Found by"
        '
        'tboItem
        '
        Me.tboItem.Location = New System.Drawing.Point(132, 57)
        Me.tboItem.MaxLength = 300
        Me.tboItem.Name = "tboItem"
        Me.tboItem.Size = New System.Drawing.Size(183, 22)
        Me.tboItem.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 16)
        Me.Label2.TabIndex = 73
        Me.Label2.Text = "Item"
        '
        'btnLost
        '
        Me.btnLost.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLost.Location = New System.Drawing.Point(682, 224)
        Me.btnLost.Name = "btnLost"
        Me.btnLost.Size = New System.Drawing.Size(95, 35)
        Me.btnLost.TabIndex = 97
        Me.btnLost.Text = "Lost"
        Me.btnLost.UseVisualStyleBackColor = True
        '
        'Found
        '
        Me.Found.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Found.Location = New System.Drawing.Point(682, 169)
        Me.Found.Name = "Found"
        Me.Found.Size = New System.Drawing.Size(95, 35)
        Me.Found.TabIndex = 98
        Me.Found.Text = "Found"
        Me.Found.UseVisualStyleBackColor = True
        '
        'btnRelease
        '
        Me.btnRelease.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRelease.Location = New System.Drawing.Point(682, 291)
        Me.btnRelease.Name = "btnRelease"
        Me.btnRelease.Size = New System.Drawing.Size(95, 35)
        Me.btnRelease.TabIndex = 99
        Me.btnRelease.Text = "Release"
        Me.btnRelease.UseVisualStyleBackColor = True
        '
        'LostandFound
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.btnRelease)
        Me.Controls.Add(Me.Found)
        Me.Controls.Add(Me.btnLost)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvLostandFound)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "LostandFound"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LostandFound"
        CType(Me.dgvLostandFound, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvLostandFound As System.Windows.Forms.DataGridView
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents tboRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tboItem As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tboLostby As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tboFoundby As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btnLost As System.Windows.Forms.Button
    Friend WithEvents Found As System.Windows.Forms.Button
    Friend WithEvents btnRelease As System.Windows.Forms.Button
End Class
