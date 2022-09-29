Imports MySql.Data.MySqlClient
Public Class Salutation
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtSalutation As New DataTable

    Private Sub kosongin()
        dtSalutation.Clear()
        tboSaltationCode.Text = ""
        tboSalutation.Text = ""
    End Sub

    Private Sub dgvSalutation_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSalutation.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            tboSaltationCode.Text = dgvSalutation.Rows(e.RowIndex).Cells(0).Value
            tboSalutation.Text = dgvSalutation.Rows(e.RowIndex).Cells(1).Value
        End If

        tboSalutation.Select()
    End Sub


    Private Sub Salutation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()
        Try
            cmd1 = New MySqlCommand("SELECT salutation_id as 'SALUTATION CODE', salutation as 'SALUTATION' FROM salutation s where salutation_id <> 1 and aktif = 1;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtSalutation)
            dgvSalutation.DataSource = dtSalutation
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim sql As String = "INSERT INTO `chamberdb`.`salutation` (`salutation_id`, `salutation`, `aktif`) VALUES (NULL, '" & tboSalutation.Text & "', '1');"
        Dim command As New MySqlCommand(sql, connection)
        Try
            OpenCloseConnection()
            command.ExecuteNonQuery()
            OpenCloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            OpenCloseConnection()
        End Try

        Salutation_Load(sender, e)

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim sqlUpdate As String
        Dim cmd1 As New MySqlCommand
        sqlUpdate = "UPDATE `chamberdb`.`salutation` SET `salutation` = '" & tboSalutation.Text & "' WHERE `salutation`.`salutation_id` = " & Convert.ToInt16(tboSaltationCode.Text) & ";"

        Try
            OpenCloseConnection()
            cmd1 = New MySqlCommand(sqlUpdate, connection)
            cmd1.ExecuteNonQuery()
            OpenCloseConnection()
            MessageBox.Show("Satutation has been updated")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            OpenCloseConnection()
        End Try

        Salutation_Load(sender, e)

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim sqlUpdate As String
        Dim cmd1 As New MySqlCommand
        sqlUpdate = "UPDATE `chamberdb`.`salutation` SET `aktif` = '0' WHERE `salutation`.`salutation_id` = " & Convert.ToInt16(tboSaltationCode.Text) & ";"

        Try
            OpenCloseConnection()
            cmd1 = New MySqlCommand(sqlUpdate, connection)
            cmd1.ExecuteNonQuery()
            OpenCloseConnection()
            MessageBox.Show("Satutation has been deleted")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            OpenCloseConnection()
        End Try

        Salutation_Load(sender, e)
    End Sub
End Class