Imports MySql.Data.MySqlClient

Public Class Backup
    Dim cmd1 As New MySqlCommand

    Private Sub btnBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser.Click
        sfdBrowse.FileName = ""
        sfdBrowse.Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*"
        sfdBrowse.ShowDialog()
        lbFilePath.Text = sfdBrowse.FileName
    End Sub

  

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        'Check if there's a selected excel file to be imported
        If Len(Trim(Me.lbFilePath.Text)) > 0 Then
            TimerProcess.Enabled = True
            Dim con As New MySqlConnection
            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = connection
            connection.Open()

            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ExportInfo.EnableEncryption = True
            'mb.ExportInfo.GetTotalRowsBeforeExport = True
            mb.ExportInfo.EncryptionPassword = "(Ch4m13Er)"
            mb.ExportToFile(lbFilePath.Text.ToString)
            connection.Close()
            MessageBox.Show("Succeed")
            Me.Close()
        Else
            'Inform the user if no selected excel file.
            MsgBox("Please select a file location.", MsgBoxStyle.OkOnly, "")
        End If
    End Sub

    Private Sub Backup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbFilePath.Text = ""
    End Sub

   

End Class