Imports MySql.Data.MySqlClient

Public Class RoomSearch

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtRoom As New DataTable
    Dim dtRoomID As New DataTable
    Private Sub RoomSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tboCapacity.Text = ""
        tboFloor.Text = ""
        tboRoomNumber.Text = ""
        tboRoomStatusCode.Text = ""
        tboRoomTypeCode.Text = ""

        cboAddOnePerson.SelectedItem = "----"

        tboRoomNumber.Select()

        btnSearch_Click(sender, e)

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dtRoom.Clear()
        dtRoomID.Clear()
        Try

            cmd1 = New MySqlCommand("SELECT type_id as 'TYPE CODE', room_num as 'ROOM NUMBER', floor as 'FLOOR', if(one_person = '1', 'Yes',if (one_person = '0','No', if (one_person is null or one_person = '', '','Not Set'))) as 'ADD ONE PRSN', standart_capacity as 'CAPACITY', status_room_id as 'ROOM STATUS' FROM room r where aktif = '1' having type_id like """ & "%" & tboRoomTypeCode.Text & "%" & """ and room_num like """ & "%" & tboRoomNumber.Text & "%" & """ and floor like """ & "%" & tboFloor.Text & "%" & """ and `ADD ONE PRSN` like """ & "%" & If(cboAddOnePerson.SelectedItem = "----", "", cboAddOnePerson.SelectedItem) & "%" & """ and standart_capacity like """ & "%" & tboCapacity.Text & "%" & """ and status_room_id like """ & "%" & tboRoomStatusCode.Text & "%" & """ order by `ROOM NUMBER` asc ;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtRoom)

            dgvRoom.DataSource = dtRoom

            Dim column As DataGridViewColumn = dgvRoom.Columns(0)
            column.Width = 50

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        insertorupdateRoom = 1

        RoomCode = ""
        RoomForm.ShowDialog()
        btnSearch_Click(sender, e)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        insertorupdateRoom = 0
        dtRoomID.Clear()
        Try
            cmd1 = New MySqlCommand("SELECT * FROM room r where room_num = '" & dgvRoom.Item(1, dgvRoom.CurrentRow.Index).Value & "' and floor = '" & dgvRoom.Item(2, dgvRoom.CurrentRow.Index).Value & "' and aktif = '1';", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtRoomID)

            If dtRoom.Rows.Count > 0 Then
                RoomCode = dtRoomID.Rows(0).Item(0)
            End If
            RoomNumber = dgvRoom.Item(1, dgvRoom.CurrentRow.Index).Value
            RoomForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Please select the room which will be edited")
        End Try

        RoomSearch_Load(sender, e)

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RoomSearch_Load(sender, e)
    End Sub

    Private Sub tboRoomNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomNumber.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboRoomTypeCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomTypeCode.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboFloor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboFloor.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboRoomStatusCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomStatusCode.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboCapacity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboCapacity.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboRoomNumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboRoomNumber.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tboFloor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboFloor.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tboCapacity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboCapacity.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub cboAddOnePerson_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAddOnePerson.SelectedIndexChanged
        btnSearch_Click(sender, e)
    End Sub
End Class