Imports MySql.Data.MySqlClient

Public Class BankAccount
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtBank As New DataTable
    Private Sub BankAccount_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()
        Try
            cmd1 = New MySqlCommand("SELECT bank_account_id as 'BA CODE', account_number as 'ACCOUNT NUMBER', bank_name as 'BANK NAME' FROM bank_account b;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtBank)
            dgvBank.DataSource = dtBank
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub
    Private Sub kosongin()
        dtBank.Clear()
        tboBACode.Text = ""
        tboAccountNumber.Text = ""
        tboBankName.Text = ""
    End Sub


    Private Sub dgvBank_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvBank.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then

            tboBACode.Text = dgvBank.Rows(e.RowIndex).Cells(0).Value
            tboAccountNumber.Text = dgvBank.Rows(e.RowIndex).Cells(1).Value
            tboBankName.Text = dgvBank.Rows(e.RowIndex).Cells(2).Value
        End If

        tboAccountNumber.Select()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim sql As String = "INSERT INTO `chamberdb`.`bank_account` (`bank_account_id`, `account_number`, `bank_name`) VALUES (NULL, '" & tboAccountNumber.Text & "', '" & tboBankName.Text & "');"
        Dim command As New MySqlCommand(sql, connection)
        Try
            OpenCloseConnection()
            command.ExecuteNonQuery()
            OpenCloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            OpenCloseConnection()
        End Try

        BankAccount_Load(sender, e)


    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        Dim sql As String = "UPDATE `chamberdb`.`bank_account` SET `account_number` = '" & tboAccountNumber.Text & "', `bank_name` = '" & tboBankName.Text & "' WHERE `bank_account`.`bank_account_id` = " & tboBACode.Text & ";"
        Dim command As New MySqlCommand(sql, connection)
        Try
            OpenCloseConnection()
            command.ExecuteNonQuery()
            OpenCloseConnection()
            MessageBox.Show("Bank account has been updated")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            OpenCloseConnection()
        End Try

        BankAccount_Load(sender, e)
    End Sub

    Private Sub tboAccountNumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboAccountNumber.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class