Imports MySql.Data.MySqlClient

Public Class InRoomFacilitySearch

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtInRoomFacility As New DataTable

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dtInRoomFacility.Clear()

        Try

            cmd1 = New MySqlCommand("select b.room_id as 'ROOM CODE',b.type_id as 'TYPE', b.floor as 'FLOOR', b.room_num as 'ROOM NUMBER',if(a.room_specification_id is null, '',a.room_specification_id) as 'INF CODE',if(a.room_specification_name is null, '',a.room_specification_name) as 'INROOM FACILITY' from (SELECT rs.room_id, r.room_num, rs.room_specification_id, s.room_specification_name FROM room_specification rs, room r, specification s where rs.room_id = r.room_id and rs.room_specification_id = s.room_specification_id order by r.room_id and r.aktif = 1 and rs.aktif = 1 and s.aktif=1) a right join room b on b.room_num = a.room_num having b.type_id like """ & "%" & tboRoomType.Text & "%" & """ and b.floor like """ & "%" & tboFloor.Text & "%" & """ and b.room_num like """ & "%" & tboRoomNumber.Text & "%" & """ and `INF CODE` like """ & "%" & tboINFCode.Text & "%" & """ and `INROOM FACILITY` like """ & "%" & tboInRoomFacility.Text & "%" & """ order by b.room_num;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtInRoomFacility)

            dgvInRoomFacilitySearch.DataSource = dtInRoomFacility

            Dim column As DataGridViewColumn = dgvInRoomFacilitySearch.Columns(0)
            column.Width = 50

            column = New DataGridViewColumn
            column = dgvInRoomFacilitySearch.Columns(1)
            column.Width = 60

            column = New DataGridViewColumn
            column = dgvInRoomFacilitySearch.Columns(2)
            column.Width = 60

            column = New DataGridViewColumn
            column = dgvInRoomFacilitySearch.Columns(3)
            column.Width = 60

            column = New DataGridViewColumn
            column = dgvInRoomFacilitySearch.Columns(4)
            column.Width = 60

            column = New DataGridViewColumn
            column = dgvInRoomFacilitySearch.Columns(5)
            column.Width = 200




        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub InRoomFacilitySearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tboFloor.Text = ""
        tboINFCode.Text = ""
        tboInRoomFacility.Text = ""
        tboRoomNumber.Text = ""
        tboRoomType.Text = ""

        btnSearch_Click(sender, e)

    End Sub

    Private Sub tboRoomNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomNumber.TextChanged
        btnSearch_Click(sender, e)

    End Sub

    Private Sub tboRoomType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomType.TextChanged
        btnSearch_Click(sender, e)

    End Sub

    Private Sub tboFloor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboFloor.TextChanged
        btnSearch_Click(sender, e)

    End Sub

    Private Sub tboINFCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboINFCode.TextChanged
        btnSearch_Click(sender, e)

    End Sub

    Private Sub tboInRoomFacility_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboInRoomFacility.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub btnInRoomFacility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnInRoomFacility.Click
        InRoomFacility.ShowDialog()
        btnRefresh_Click(sender, e)
    End Sub

    Private Sub btnMultiAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMultiAdd.Click
        Multi_Add.ShowDialog()
        btnRefresh_Click(sender, e)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        InRoomFacilitySearch_Load(sender, e)
    End Sub

    Private Sub btnRoomAdj_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRoomAdj.Click
        insertorupdateRoom = 0
        Try
            RoomCode = dgvInRoomFacilitySearch.Item(0, dgvInRoomFacilitySearch.CurrentRow.Index).Value
            RoomNumber = dgvInRoomFacilitySearch.Item(3, dgvInRoomFacilitySearch.CurrentRow.Index).Value
            RoomForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Please select the room which will be edited")
        End Try
    End Sub
End Class