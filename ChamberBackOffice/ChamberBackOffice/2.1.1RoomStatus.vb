Imports MySql.Data.MySqlClient

Public Class RoomStatus

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtRoomStatus As New DataTable

    Public Sub kosongin()
        dtRoomStatus.Clear()
        dgvRoomStatus.Rows.Clear()
        dgvRoomStatus.Columns.Clear()

        tboFloor.Text = ""
        tboRoomNumber.Text = ""
        tboRoomType.Text = ""

    End Sub

    Private Sub MewarnaiTexbox()
        'warnai textbox
        tboOcC.BackColor = Color.Cyan
        tboOcD.BackColor = Color.RosyBrown
        tboOcDD.BackColor = Color.Lavender
        tboOOS.BackColor = Color.OrangeRed
        tboVaCI.BackColor = Color.LightGreen
        tboVaCN.BackColor = Color.LightSeaGreen
        tboVaD.BackColor = Color.Goldenrod
        tboEA.BackColor = Color.Orange
        tboED.BackColor = Color.DimGray
    End Sub

    Private Sub RoomStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MewarnaiTexbox()
        kosongin()
        btnSearch_Click(sender, e)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dtRoomStatus.Clear()
        dgvRoomStatus.Rows.Clear()
        dgvRoomStatus.Columns.Clear()


        'Select Room Plan
        Dim RScmd As New MySqlCommand
        Dim RSAdapter As New MySqlDataAdapter
        Dim dtRS As New DataTable
        Dim RSComand As String
        RSComand = "select r.room_num as 'ROOM NUM',r.floor as 'FLOOR', r.type_id as 'TYPE',  if(pi.`CUST STATUS` = 6, concat(`ROOM STATUS`,' - ', 'ED'),if(pi.`CUST STATUS` = 7, concat(`ROOM STATUS`,' - ', 'EA'),`ROOM STATUS`)) as 'ROOM STATUS' from (select rm.room_num, rm.floor, rm.type_id, rm.status_room_id AS 'ROOM STATUS' from room rm where aktif = 1) r right join (SELECT SUM(CASE WHEN (arrival_Date <= 20150218 and depart_date >= 20150218 ) THEN if(checkout_by is not null,if(depart_date = 20150218,1,5),if(checkin_by is not null and checkout_by is null,IF(depart_date = 20150218,6,4),if(checkin_by is null and with_dp = '1',IF(arrival_Date = 20150218,7,IF(depart_date = 20150218,6,3)),if(checkin_by is null and with_dp = '0', IF(arrival_Date = 20150218,7,IF(depart_date = 20150218,6,2)), 1)))) ELSE 0 END) AS 'CUST STATUS', rv.room_num FROM reservation_checkin_out rv, room rm where rv.aktif = 1 and rv.room_num = rm.room_num group by rv.room_num asc order by rv.room_num) pi on r.room_num = pi.room_num having r.floor like '%" & tboFloor.Text & "%' and r.`type_id` like '%" & tboRoomType.Text & "%' and `ROOM NUM` like '%" & tboRoomNumber.Text & "%';"
        Try
            OpenCloseConnection()
            RScmd = New MySqlCommand(RSComand, connection)
            RSAdapter = New MySqlDataAdapter(RScmd)
            RSAdapter.Fill(dtRS)
            OpenCloseConnection()

            'Menggambar nama kolom di dgv
            dgvRoomStatus.ColumnCount = dtRS.Columns.Count
            Dim column As DataGridViewColumn = dgvRoomStatus.Columns(0)
            For i = 0 To (dtRS.Columns.Count - 1)
                dgvRoomStatus.Columns(i).Name = dtRS.Columns(i).ColumnName()
                column = New DataGridViewColumn
                column = dgvRoomStatus.Columns(i)
                column.Width = 100
            Next

            'Menggambar, mengisi dan mewarna row nya dgv
            For i = 0 To dtRS.Rows.Count - 1
                dgvRoomStatus.Rows.Add()
                For j = 0 To dtRS.Columns.Count - 1
                    If j < 3 Then
                        dgvRoomStatus.Rows(i).Cells(j).Value = dtRS.Rows(i).Item(j)
                    ElseIf j = 3 Then
                        dgvRoomStatus.Rows(i).Cells(j).Value = dtRS.Rows(i).Item(j)
                        If dgvRoomStatus.Rows(i).Cells(j).Value = "OcC" Then
                            dgvRoomStatus.Rows(i).Cells(j).Style.BackColor = Color.Cyan
                        ElseIf dgvRoomStatus.Rows(i).Cells(j).Value = "OcD" Then
                            dgvRoomStatus.Rows(i).Cells(j).Style.BackColor = Color.RosyBrown
                        ElseIf dgvRoomStatus.Rows(i).Cells(j).Value = "OcDD" Then
                            dgvRoomStatus.Rows(i).Cells(j).Style.BackColor = Color.Lavender
                   
                        ElseIf dgvRoomStatus.Rows(i).Cells(j).Value = "OOS" Then
                            dgvRoomStatus.Rows(i).Cells(j).Style.BackColor = Color.OrangeRed
                        ElseIf dgvRoomStatus.Rows(i).Cells(j).Value = "VaCI" Then
                            dgvRoomStatus.Rows(i).Cells(j).Style.BackColor = Color.LightGreen
                        ElseIf dgvRoomStatus.Rows(i).Cells(j).Value = "VaCN" Then
                            dgvRoomStatus.Rows(i).Cells(j).Style.BackColor = Color.LightSeaGreen
                        ElseIf dgvRoomStatus.Rows(i).Cells(j).Value = "VaD" Then
                            dgvRoomStatus.Rows(i).Cells(j).Style.BackColor = Color.Goldenrod
                        ElseIf dgvRoomStatus.Rows(i).Cells(j).Value = "VaCN - EA" Then
                            dgvRoomStatus.Rows(i).Cells(j).Style.BackColor = Color.Orange
                        ElseIf dgvRoomStatus.Rows(i).Cells(j).Value = "VaCI - EA" Then
                            dgvRoomStatus.Rows(i).Cells(j).Style.BackColor = Color.LightGreen
                        ElseIf dgvRoomStatus.Rows(i).Cells(j).Value = "OcD - ED" Then
                            dgvRoomStatus.Rows(i).Cells(j).Style.BackColor = Color.DimGray
                        ElseIf dgvRoomStatus.Rows(i).Cells(j).Value = "OcDD - ED" Then
                            dgvRoomStatus.Rows(i).Cells(j).Style.BackColor = Color.DimGray
                        End If
                    End If
                Next
            Next

        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub tboRoomType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomType.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboRoomNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomNumber.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboFloor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboFloor.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RoomStatus_Load(sender, e)
    End Sub
End Class