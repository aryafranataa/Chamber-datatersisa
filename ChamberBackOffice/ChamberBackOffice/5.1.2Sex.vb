Imports MySql.Data.MySqlClient

Public Class Sex
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtSex As New DataTable

    Private Sub kosongin()
        dtSex.Clear()
        tboSexCode.Text = ""
        tboSexName.Text = ""
    End Sub

    Private Sub dgvSex_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSex.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            tboSexCode.Text = dgvSex.Rows(e.RowIndex).Cells(0).Value
            tboSexName.Text = dgvSex.Rows(e.RowIndex).Cells(1).Value
        End If

        tboSexName.Select()
    End Sub

    Private Sub Sex_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()
        Try

            cmd1 = New MySqlCommand("SELECT sex_id as 'SEX CODE', sex_name as 'SEX NAME' FROM sex s where sex_id <> 1", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtSex)
            dgvSex.DataSource = dtSex
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String = ""
        sql = "UPDATE `chamberdb`.`sex` SET `sex_name` = '" & tboSexName.Text & "' WHERE `sex`.`sex_id` = '" & tboSexCode.Text & "';"
        Try
            Dim command As New MySqlCommand(sql, connection)
            OpenCloseConnection()
            command.ExecuteNonQuery()
            OpenCloseConnection()
            MessageBox.Show("Sex name has been saved")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            OpenCloseConnection()
        End Try

        Sex_Load(sender, e)
    End Sub
End Class