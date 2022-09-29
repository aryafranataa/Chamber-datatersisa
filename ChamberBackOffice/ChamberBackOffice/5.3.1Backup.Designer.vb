<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Backup
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
        Me.components = New System.ComponentModel.Container()
        Me.btnBrowser = New System.Windows.Forms.Button()
        Me.lbFilePath = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sfdBrowse = New System.Windows.Forms.SaveFileDialog()
        Me.TimerProcess = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnBrowser
        '
        Me.btnBrowser.Location = New System.Drawing.Point(401, 138)
        Me.btnBrowser.Name = "btnBrowser"
        Me.btnBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowser.TabIndex = 127
        Me.btnBrowser.Text = "Browse"
        Me.btnBrowser.UseVisualStyleBackColor = True
        '
        'lbFilePath
        '
        Me.lbFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFilePath.Location = New System.Drawing.Point(76, 138)
        Me.lbFilePath.Name = "lbFilePath"
        Me.lbFilePath.Size = New System.Drawing.Size(319, 23)
        Me.lbFilePath.TabIndex = 126
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(274, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 35)
        Me.Button1.TabIndex = 125
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.Location = New System.Drawing.Point(134, 210)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(95, 35)
        Me.btnBackup.TabIndex = 124
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(418, 32)
        Me.Label2.TabIndex = 123
        Me.Label2.Text = "Backup your database. It is important if the system would be crashed. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Make sure" & _
            " that the backup file stores in safety harddrive. "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(31, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 25)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Backup"
        '
        'sfdBrowse
        '
        Me.sfdBrowse.DefaultExt = "sql"
        '
        'TimerProcess
        '
        '
        'Backup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(552, 326)
        Me.Controls.Add(Me.btnBrowser)
        Me.Controls.Add(Me.lbFilePath)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Backup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Backup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowser As System.Windows.Forms.Button
    Friend WithEvents lbFilePath As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents sfdBrowse As System.Windows.Forms.SaveFileDialog
    Friend WithEvents TimerProcess As System.Windows.Forms.Timer
End Class
