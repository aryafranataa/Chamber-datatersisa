<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InRoomFacilitySearch
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
        Me.btnMultiAdd = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.tboInRoomFacility = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tboINFCode = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tboFloor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tboRoomType = New System.Windows.Forms.TextBox()
        Me.tboRoomNumber = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.dgvInRoomFacilitySearch = New System.Windows.Forms.DataGridView()
        Me.btnInRoomFacility = New System.Windows.Forms.Button()
        Me.btnRoomAdj = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvInRoomFacilitySearch, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnMultiAdd
        '
        Me.btnMultiAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiAdd.Location = New System.Drawing.Point(682, 196)
        Me.btnMultiAdd.Name = "btnMultiAdd"
        Me.btnMultiAdd.Size = New System.Drawing.Size(95, 35)
        Me.btnMultiAdd.TabIndex = 7
        Me.btnMultiAdd.Text = "Multi Add"
        Me.btnMultiAdd.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(682, 49)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(95, 35)
        Me.btnSearch.TabIndex = 6
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tboInRoomFacility)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tboINFCode)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tboFloor)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tboRoomType)
        Me.GroupBox2.Controls.Add(Me.tboRoomNumber)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 14)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(649, 135)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "In Room Facility"
        '
        'tboInRoomFacility
        '
        Me.tboInRoomFacility.Location = New System.Drawing.Point(444, 59)
        Me.tboInRoomFacility.Name = "tboInRoomFacility"
        Me.tboInRoomFacility.Size = New System.Drawing.Size(183, 22)
        Me.tboInRoomFacility.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(344, 62)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(97, 16)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "In Room Facily"
        '
        'tboINFCode
        '
        Me.tboINFCode.Location = New System.Drawing.Point(444, 31)
        Me.tboINFCode.Name = "tboINFCode"
        Me.tboINFCode.Size = New System.Drawing.Size(183, 22)
        Me.tboINFCode.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(344, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 16)
        Me.Label3.TabIndex = 72
        Me.Label3.Text = "INF Code"
        '
        'tboFloor
        '
        Me.tboFloor.Location = New System.Drawing.Point(142, 87)
        Me.tboFloor.Name = "tboFloor"
        Me.tboFloor.Size = New System.Drawing.Size(183, 22)
        Me.tboFloor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 16)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Floor"
        '
        'tboRoomType
        '
        Me.tboRoomType.Location = New System.Drawing.Point(142, 59)
        Me.tboRoomType.Name = "tboRoomType"
        Me.tboRoomType.Size = New System.Drawing.Size(183, 22)
        Me.tboRoomType.TabIndex = 2
        '
        'tboRoomNumber
        '
        Me.tboRoomNumber.Location = New System.Drawing.Point(142, 31)
        Me.tboRoomNumber.Name = "tboRoomNumber"
        Me.tboRoomNumber.Size = New System.Drawing.Size(183, 22)
        Me.tboRoomNumber.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 16)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Room Type"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 34)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(96, 16)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Room Number"
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(682, 448)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(95, 35)
        Me.btnRefresh.TabIndex = 9
        Me.btnRefresh.Text = "Refresh"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'dgvInRoomFacilitySearch
        '
        Me.dgvInRoomFacilitySearch.AllowUserToAddRows = False
        Me.dgvInRoomFacilitySearch.AllowUserToDeleteRows = False
        Me.dgvInRoomFacilitySearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvInRoomFacilitySearch.Location = New System.Drawing.Point(17, 155)
        Me.dgvInRoomFacilitySearch.Name = "dgvInRoomFacilitySearch"
        Me.dgvInRoomFacilitySearch.ReadOnly = True
        Me.dgvInRoomFacilitySearch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvInRoomFacilitySearch.Size = New System.Drawing.Size(649, 403)
        Me.dgvInRoomFacilitySearch.TabIndex = 85
        '
        'btnInRoomFacility
        '
        Me.btnInRoomFacility.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInRoomFacility.Location = New System.Drawing.Point(682, 355)
        Me.btnInRoomFacility.Name = "btnInRoomFacility"
        Me.btnInRoomFacility.Size = New System.Drawing.Size(95, 35)
        Me.btnInRoomFacility.TabIndex = 87
        Me.btnInRoomFacility.Text = "InRoom Fac"
        Me.btnInRoomFacility.UseVisualStyleBackColor = True
        '
        'btnRoomAdj
        '
        Me.btnRoomAdj.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRoomAdj.Location = New System.Drawing.Point(682, 249)
        Me.btnRoomAdj.Name = "btnRoomAdj"
        Me.btnRoomAdj.Size = New System.Drawing.Size(95, 35)
        Me.btnRoomAdj.TabIndex = 88
        Me.btnRoomAdj.Text = "Room Adj"
        Me.btnRoomAdj.UseVisualStyleBackColor = True
        '
        'InRoomFacilitySearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(794, 572)
        Me.Controls.Add(Me.btnRoomAdj)
        Me.Controls.Add(Me.btnInRoomFacility)
        Me.Controls.Add(Me.btnMultiAdd)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnRefresh)
        Me.Controls.Add(Me.dgvInRoomFacilitySearch)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "InRoomFacilitySearch"
        Me.Text = "InRoomFacilitySearch"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgvInRoomFacilitySearch, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnMultiAdd As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents tboRoomType As System.Windows.Forms.TextBox
    Friend WithEvents tboRoomNumber As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents dgvInRoomFacilitySearch As System.Windows.Forms.DataGridView
    Friend WithEvents tboFloor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tboINFCode As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tboInRoomFacility As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnInRoomFacility As System.Windows.Forms.Button
    Friend WithEvents btnRoomAdj As System.Windows.Forms.Button
End Class
