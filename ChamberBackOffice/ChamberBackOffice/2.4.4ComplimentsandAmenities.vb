Imports MySql.Data.MySqlClient
Public Class ComplimentsandAmenities
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtAmenities As New DataTable

    Private Sub kosongin()
        dtAmenities.Clear()
        tboHKListCode.Text = ""
        tboHKListName.Text = ""
    End Sub

    Private Sub ComplimentsandAmenities_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()
        Try
            cmd1 = New MySqlCommand("SELECT hk_list_id as 'NUM', hk_list_name as 'COMPLIMENTS AND AMENITIES' FROM hk_list h where aktif = 1;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtAmenities)
            dgvAmenities.DataSource = dtAmenities
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub dgvSalutation_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvAmenities.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            tboHKListCode.Text = dgvAmenities.Rows(e.RowIndex).Cells(0).Value
            tboHKListName.Text = dgvAmenities.Rows(e.RowIndex).Cells(1).Value
        End If

        tboHKListName.Select()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        Dim sql As String = "INSERT INTO `chamberdb`.`hk_list` (`hk_list_id`, `hk_list_name`, `aktif`, `facility_id`) VALUES (NULL, '" & tboHKListName.Text & "', '1', NULL);;"
        Dim command As New MySqlCommand(sql, connection)
        Try
            OpenCloseConnection()
            command.ExecuteNonQuery()
            OpenCloseConnection()
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            OpenCloseConnection()
        End Try

        ComplimentsandAmenities_Load(sender, e)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim sqlUpdate As String
        Dim cmd1 As New MySqlCommand
        sqlUpdate = "UPDATE `chamberdb`.`hk_list` SET `hk_list_name` = '" & tboHKListName.Text & "' WHERE `hk_list`.`hk_list_id` = " & tboHKListCode.Text & ";"

        Try
            OpenCloseConnection()
            cmd1 = New MySqlCommand(sqlUpdate, connection)
            cmd1.ExecuteNonQuery()
            OpenCloseConnection()
            MessageBox.Show("Compliment or Amenity has been updated")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            OpenCloseConnection()
        End Try

        ComplimentsandAmenities_Load(sender, e)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim sqlUpdate As String
        Dim cmd1 As New MySqlCommand
        sqlUpdate = "UPDATE `chamberdb`.`hk_list` SET `aktif` = '0' WHERE `hk_list`.`hk_list_id` = " & tboHKListCode.Text & ";"

        Try
            OpenCloseConnection()
            cmd1 = New MySqlCommand(sqlUpdate, connection)
            cmd1.ExecuteNonQuery()
            OpenCloseConnection()
            MessageBox.Show("Compliment or Amenity has been updated")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            OpenCloseConnection()
        End Try

        ComplimentsandAmenities_Load(sender, e)
    End Sub
End Class