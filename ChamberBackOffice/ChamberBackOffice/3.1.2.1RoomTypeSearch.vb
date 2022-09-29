Imports MySql.Data.MySqlClient

Public Class RoomTypeSearch

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtRoomType As New DataTable
    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dtRoomType.Clear()

        Try

            cmd1 = New MySqlCommand("select t.type_id as `TYPE`, t.type_name as `TYPE NAME`, if(r.rate_room is not null, r.rate_room, if((select r.rate_room from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off <= " & Today.ToString("yyyyMMdd") & " order by r.date_off desc limit 1) is not null, (select r.rate_room from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off <= " & Today.ToString("yyyyMMdd") & " order by r.date_off desc limit 1), if( (select r.rate_room from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off >= " & Today.ToString("yyyyMMdd") & " order by r.date_off asc limit 1) is not null, (select r.rate_room from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off >= " & Today.ToString("yyyyMMdd") & " order by r.date_off asc limit 1), 'Not Set'))) as `RATE ROOM`, if(r.rate_room_breakfast is not null, r.rate_room_breakfast, if((select r.rate_room_breakfast from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off <= " & Today.ToString("yyyyMMdd") & " order by r.date_off desc limit 1) is not null, (select r.rate_room_breakfast from rate r  where r.aktif = '1' and r.type_id = t.type_id and r.date_off <= " & Today.ToString("yyyyMMdd") & " order by r.date_off desc limit 1), if( (select r.rate_room_breakfast from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off >= " & Today.ToString("yyyyMMdd") & " order by r.date_off asc limit 1) is not null, (select r.rate_room_breakfast from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off >= " & Today.ToString("yyyyMMdd") & " order by r.date_off asc limit 1), 'Not Set'))) as `WITH BREAKFAST` from `type` t left join rate r on (t.type_id=r.type_id and r.aktif='1' and t.aktif='1' and " & Today.ToString("yyyyMMdd") & " between r.date_on and r.date_off) group by t.type_id having `TYPE` like """ & "%" & tboRoomTypeID.Text & "%" & """ and `TYPE NAME` like """ & "%" & tboRoomTypeID.Text & "%" & """;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtRoomType)

            dgvRoomType.DataSource = dtRoomType
      


        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        insertorupdateRoomType = 1

        RoomTypeForm.ShowDialog()
        btnSearch_Click(sender, e)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        insertorupdateRoomType = 0

        Try
            RoomTypeID = dgvRoomType.Item(0, dgvRoomType.CurrentRow.Index).Value
            RoomTypeForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Please select the room type which will be edited")
        End Try

        RoomTypeSearch_Load(sender, e)

    End Sub

  
    Private Sub RoomTypeSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tboRoomTypeID.Text = ""
        tboRoomTypeName.Text = ""

        tboRoomTypeID.Select()

        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboRoomTypeID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomTypeID.TextChanged
        btnSearch_Click(sender, e)

    End Sub

    Private Sub tboRoomTypeName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomTypeName.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RoomTypeSearch_Load(sender, e)
    End Sub
End Class