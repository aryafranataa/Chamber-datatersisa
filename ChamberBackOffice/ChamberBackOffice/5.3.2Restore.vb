Imports MySql.Data.MySqlClient
Public Class Restore


    Private Sub Restore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lbFilePath.Text = ""
    End Sub

    Private Sub btnBrowser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowser.Click
        ofdBrowse.FileName = ""
        ofdBrowse.Filter = "SQL files (*.sql)|*.sql|All files (*.*)|*.*"
        ofdBrowse.ShowDialog()
        lbFilePath.Text = ofdBrowse.FileName
    End Sub

    Private Sub btnRestore_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestore.Click
        'Check if there's a selected excel file to be imported
        If Len(Trim(Me.lbFilePath.Text)) > 0 Then
            TimerProcess.Enabled = True

            Dim con As New MySqlConnection

            Dim cmd As MySqlCommand = New MySqlCommand
            cmd.Connection = connection
            connection.Open()
            Dim mb As MySqlBackup = New MySqlBackup(cmd)
            mb.ImportInfo.EnableEncryption = True
            mb.ImportInfo.EncryptionPassword = "(Ch4m13Er)"
            mb.ImportInfo.IgnoreSqlError = True
            mb.ImportInfo.TargetDatabase = "chamberdb"
            mb.ImportFromFile(lbFilePath.Text.ToString)

            connection.Close()


            MessageBox.Show("Succeed")
            Me.Close()
        Else
            'Inform the user if no selected excel file.
            MsgBox("Please select a file location.", MsgBoxStyle.OkOnly, "")
        End If
    End Sub
End Class