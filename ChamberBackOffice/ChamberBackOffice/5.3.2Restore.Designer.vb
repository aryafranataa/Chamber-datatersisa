<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Restore
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
        Me.btnRestore = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ofdBrowse = New System.Windows.Forms.OpenFileDialog()
        Me.TimerProcess = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnBrowser
        '
        Me.btnBrowser.Location = New System.Drawing.Point(403, 130)
        Me.btnBrowser.Name = "btnBrowser"
        Me.btnBrowser.Size = New System.Drawing.Size(75, 23)
        Me.btnBrowser.TabIndex = 132
        Me.btnBrowser.Text = "Browse"
        Me.btnBrowser.UseVisualStyleBackColor = True
        '
        'lbFilePath
        '
        Me.lbFilePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lbFilePath.Location = New System.Drawing.Point(78, 130)
        Me.lbFilePath.Name = "lbFilePath"
        Me.lbFilePath.Size = New System.Drawing.Size(319, 23)
        Me.lbFilePath.TabIndex = 131
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(302, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(95, 35)
        Me.Button1.TabIndex = 130
        Me.Button1.Text = "Cancel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnRestore
        '
        Me.btnRestore.Location = New System.Drawing.Point(142, 197)
        Me.btnRestore.Name = "btnRestore"
        Me.btnRestore.Size = New System.Drawing.Size(95, 35)
        Me.btnRestore.TabIndex = 129
        Me.btnRestore.Text = "Restore"
        Me.btnRestore.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(358, 48)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "Restore your database. It is important to recover database " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "if the system would " & _
            "be crashed.  Make sure that the backup " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "file stores in safety harddrive."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 25)
        Me.Label1.TabIndex = 127
        Me.Label1.Text = "Restore"
        '
        'ofdBrowse
        '
        Me.ofdBrowse.FileName = "OpenFileDialog1"
        '
        'Restore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(552, 326)
        Me.Controls.Add(Me.btnBrowser)
        Me.Controls.Add(Me.lbFilePath)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnRestore)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Restore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Restore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnBrowser As System.Windows.Forms.Button
    Friend WithEvents lbFilePath As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnRestore As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ofdBrowse As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TimerProcess As System.Windows.Forms.Timer
End Class
