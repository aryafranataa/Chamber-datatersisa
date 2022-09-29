Imports MySql.Data.MySqlClient
Imports System.Collections.Generic.List(Of String)
Imports System.Drawing
Public Class RoomPlanSearch
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter

    Dim dtDitampilin As New DataTable
    Dim sqlSection1 As String

    Dim SqlSection2 As New List(Of String)()

    Dim tt As ToolTip = New ToolTip


    Private Sub rdbOneWeek_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbOneWeek.CheckedChanged
        SqlSection2 = New List(Of String)()
        If rdbOneWeek.Checked = True Then
            For i = 0 To 6
                If i < 6 Then
                    SqlSection2.Add("SUM(CASE WHEN (arrival_Date <= " & dtpNow.Value.AddDays(i).ToString("yyyyMMdd") & " and depart_date >= " & dtpNow.Value.AddDays(i).ToString("yyyyMMdd") & " ) THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS '" & dtpNow.Value.AddDays(i).ToString("MMM-dd") & "',")
                ElseIf i = 6 Then
                    SqlSection2.Add("SUM(CASE WHEN (arrival_Date <= " & dtpNow.Value.AddDays(i).ToString("yyyyMMdd") & " and depart_date >= " & dtpNow.Value.AddDays(i).ToString("yyyyMMdd") & " ) THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS '" & dtpNow.Value.AddDays(i).ToString("MMM-dd") & "', rv.room_num ")
                End If
            Next
        End If
    End Sub

    Private Sub rdbTwoWeeks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbTwoWeeks.CheckedChanged
        SqlSection2 = New List(Of String)()
        If rdbTwoWeeks.Checked = True Then
            For i = 0 To 13
                If i < 13 Then
                    SqlSection2.Add("SUM(CASE WHEN (arrival_Date <= " & dtpNow.Value.AddDays(i).ToString("yyyyMMdd") & " and depart_date >= " & dtpNow.Value.AddDays(i).ToString("yyyyMMdd") & " ) THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS '" & dtpNow.Value.AddDays(i).ToString("MMM-dd") & "',")
                ElseIf i = 13 Then
                    SqlSection2.Add("SUM(CASE WHEN (arrival_Date <= " & dtpNow.Value.AddDays(i).ToString("yyyyMMdd") & " and depart_date >= " & dtpNow.Value.AddDays(i).ToString("yyyyMMdd") & " ) THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS '" & dtpNow.Value.AddDays(i).ToString("MMM-dd") & "', rv.room_num ")
                End If
            Next
        End If
    End Sub

    Public Sub kosongin()
        dtDitampilin.Clear()

        tboFloor.Text = ""
        tboRoomNumber.Text = ""
        tboRoomType.Text = ""

        rdbOneWeek.Checked = False
        rdbTwoWeeks.Checked = False
        rdbThreeWeeks.Checked = False

        Dim SqlSection2 As New List(Of String)()
    End Sub

    Public Sub Refreshing()
        kosongin()
        dtpNow.Value = "2014-12-14"
        rdbThreeWeeks.Checked = True
        dtDitampilin.Clear()
        sqlSection1 = "select r.room_num as 'ROOM NUMBER',r.floor as 'FLOOR', r.type_id as 'TYPE CODE',  `ROOM STATUS`, pi.* from (select rm.room_num, rm.floor, rm.type_id, if(CHAR_LENGTH(rm.status_room_id)=3,right(rm.status_room_id, 2),right(rm.status_room_id, 1)) AS 'ROOM STATUS' from room rm where aktif = 1) r left join (SELECT "
        ttiGuest.SetToolTip(Me.btnModule, "Button Add")
        dgvRoomPlan.Rows.Clear()
        dgvRoomPlan.Columns.Clear()
        dtDitampilin.Clear()

    End Sub

    Private Sub RoomPlanSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Refreshing()
        btnSearch_Click(sender, e)
    End Sub

    Private Sub rdbThreeWeeks_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbThreeWeeks.CheckedChanged

        SqlSection2 = New List(Of String)()
        If rdbThreeWeeks.Checked = True Then
            For i = 0 To 31
                If i < 29 Then
                    SqlSection2.Add("SUM(CASE WHEN (arrival_Date <= " & dtpNow.Value.AddDays(i).ToString("yyyyMMdd") & " and depart_date >= " & dtpNow.Value.AddDays(i).ToString("yyyyMMdd") & " ) THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS '" & dtpNow.Value.AddDays(i).ToString("MMM-dd") & "',")
                ElseIf i = 31 Then
                    SqlSection2.Add("SUM(CASE WHEN (arrival_Date <= " & dtpNow.Value.AddDays(i).ToString("yyyyMMdd") & " and depart_date >= " & dtpNow.Value.AddDays(i).ToString("yyyyMMdd") & " ) THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS '" & dtpNow.Value.AddDays(i).ToString("MMM-dd") & "', rv.room_num ")
                End If
            Next
        End If

    End Sub

  

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dtDitampilin.Clear()
        dgvRoomPlan.DataSource = Nothing
        DataGridView1.DataSource = Nothing
        dgvRoomPlan.Columns.Clear()
        dgvRoomPlan.Rows.Clear()


        Dim GabunganSQLSeciton2 As String = ""
        dtDitampilin.Clear()

        For i = 0 To SqlSection2.Count - 1
            GabunganSQLSeciton2 = GabunganSQLSeciton2 & SqlSection2(i)
        Next

        Dim SQLSection3 As String = ""
        SQLSection3 = "FROM reservation_checkin_out rv, room rm where rv.aktif = 1 and rv.room_num = rm.room_num group by rv.room_num asc order by rv.room_num) pi on r.room_num = pi.room_num having r.room_num like """ & "%" & tboRoomNumber.Text & "%" & """ and r.floor like """ & "%" & tboFloor.Text & "%" & """and r.`type_id` like """ & "%" & tboRoomType.Text & "%" & """;"

        Dim allSQL As String = ""
        allSQL = sqlSection1 & GabunganSQLSeciton2 & SQLSection3
        Try
            ' allSQL = "select r.room_num as 'ROOM NUMBER',r.floor as 'FLOOR', r.type_id as 'TYPE CODE',  `ROOM STATUS`, pi.* from (select rm.room_num, rm.floor, rm.type_id, if(CHAR_LENGTH(rm.status_room_id)=3,right(rm.status_room_id, 2),right(rm.status_room_id, 1)) AS 'ROOM STATUS' from room rm where aktif = 1) r left join (SELECT rv.room_num, SUM(CASE WHEN (arrival_Date <= '2014-12-14' and depart_date >= '2014-12-14') THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS 'Dec-14', SUM(CASE WHEN (arrival_Date <= '2014-12-15' and depart_date >= '2014-12-15')  THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS 'Dec-15', SUM(CASE WHEN arrival_Date <= '2014-12-16' and depart_date >= '2014-12-16'  THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS 'Dec-16', SUM(CASE WHEN (arrival_Date <= '2014-12-17' and depart_date >= '2014-12-17')  THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS 'Dec-17', SUM(CASE WHEN arrival_Date <= '2014-12-18' and depart_date >= '2014-12-18'  THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS 'Dec-18', SUM(CASE WHEN (arrival_Date <= '2014-12-19' and depart_date >= '2014-12-19')  THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS 'Dec-19', SUM(CASE WHEN arrival_Date <= '2014-12-20' and depart_date >= '2014-12-20'  THEN if(checkout_by is not null,3,if(checkin_by is not null and checkout_by is null,2,if(checkin_by is null,1,0))) ELSE 0 END) AS 'Dec-20' FROM reservation_checkin_out rv, room rm where rv.aktif = 1 and rv.room_num = rm.room_num group by rv.room_num asc order by rv.room_num) pi on r.room_num = pi.room_num ;"
            cmd1 = New MySqlCommand(allSQL, connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtDitampilin)

            ' dtDitampilin.Columns.RemoveAt(dtDitampilin.Columns.Count - 1)

            'menggambar data grid view

            dgvRoomPlan.ColumnCount = dtDitampilin.Columns.Count - 1
            dgvRoomPlan.Columns(0).Name = dtDitampilin.Columns(0).ColumnName()
            Dim column As DataGridViewColumn = dgvRoomPlan.Columns(0)
            column.Width = 60

            dgvRoomPlan.Columns(1).Name = dtDitampilin.Columns(1).ColumnName()
            column = New DataGridViewColumn
            column = dgvRoomPlan.Columns(1)
            column.Width = 50


            dgvRoomPlan.Columns(2).Name = dtDitampilin.Columns(2).ColumnName()
            column = New DataGridViewColumn
            column = dgvRoomPlan.Columns(2)
            column.Width = 60

            dgvRoomPlan.Columns(3).Name = dtDitampilin.Columns(3).ColumnName()
            column = New DataGridViewColumn
            column = dgvRoomPlan.Columns(3)
            column.Width = 60

            For i = 4 To dtDitampilin.Columns.Count - 2
                dgvRoomPlan.Columns(i).Name = dtDitampilin.Columns(i).ColumnName()
                column = New DataGridViewColumn
                column = dgvRoomPlan.Columns(i)
                column.Width = 50
            Next


            'tambah row
            For i = 0 To dtDitampilin.Rows.Count - 1
                dgvRoomPlan.Rows.Add()
            Next

            'masukin 3 column depan
            For i = 0 To dtDitampilin.Rows.Count - 1
                For j = 0 To 2
                    dgvRoomPlan.Rows(i).Cells(j).Value = dtDitampilin.Rows(i).Item(j)
                Next
            Next

            'masukin buat yang warna clean atau nggak

            For i = 0 To dtDitampilin.Rows.Count - 1
                For j = 3 To 3
                    If dtDitampilin.Rows(i).Item(j) = "C" Then
                        dgvRoomPlan.Rows(i).Cells(j).Value = "Cl/Ch"
                        Me.dgvRoomPlan.Rows(i).Cells(j).Style.BackColor = Color.OrangeRed
                    ElseIf dtDitampilin.Rows(i).Item(j) = "CN" Then
                        dgvRoomPlan.Rows(i).Cells(j).Value = "Cl/NC"
                        Me.dgvRoomPlan.Rows(i).Cells(j).Style.BackColor = Color.LightBlue
                    ElseIf dtDitampilin.Rows(i).Item(j) = "D" Then
                        dgvRoomPlan.Rows(i).Cells(j).Value = "Di/Ch"
                        Me.dgvRoomPlan.Rows(i).Cells(j).Style.BackColor = Color.Brown
                    ElseIf dtDitampilin.Rows(i).Item(j) = "DN" Then
                        dgvRoomPlan.Rows(i).Cells(j).Value = "Di/NC"
                        Me.dgvRoomPlan.Rows(i).Cells(j).Style.BackColor = Color.RosyBrown
                    End If
                Next
            Next


            'masukin date yang berlaku

            For i = 0 To dtDitampilin.Rows.Count - 1
                For j = 4 To dtDitampilin.Columns.Count - 2
                    If dtDitampilin.Rows(i).Item(j).ToString = "0" Or IsDBNull(dtDitampilin.Rows(i)(j)) Then
                        dgvRoomPlan.Rows(i).Cells(j).Value = "VA"
                        Me.dgvRoomPlan.Rows(i).Cells(j).Style.BackColor = Color.Lavender
                    ElseIf dtDitampilin.Rows(i).Item(j).ToString = "1" Then
                        dgvRoomPlan.Rows(i).Cells(j).Value = "VA"
                        Me.dgvRoomPlan.Rows(i).Cells(j).Style.BackColor = Color.Yellow
                    ElseIf dtDitampilin.Rows(i).Item(j).ToString = "2" Then
                        dgvRoomPlan.Rows(i).Cells(j).Value = "OC"
                        Me.dgvRoomPlan.Rows(i).Cells(j).Style.BackColor = Color.LightPink
                    ElseIf dtDitampilin.Rows(i).Item(j).ToString = "3" Then
                        dgvRoomPlan.Rows(i).Cells(j).Value = "OC"
                        Me.dgvRoomPlan.Rows(i).Cells(j).Style.BackColor = Color.LightGreen
                    End If

                Next
            Next


            DataGridView1.DataSource = dtDitampilin




        Catch ex As Exception
            MessageBox.Show(ex.ToString)

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

    Private Sub dgvRoomPlan_CellMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles dgvRoomPlan.CellMouseDoubleClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 4 Then

            If dgvRoomPlan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value <> "VA" Then
                Dim dtRCode As New DataTable
                dtRCode.Clear()

                Try

                    cmd1 = New MySqlCommand("SELECT * FROM reservation_checkin_out r where aktif = 1 and room_num = '" & dgvRoomPlan.Item(0, dgvRoomPlan.CurrentRow.Index).Value & "' and (arrival_date <= " & dtpNow.Value.AddDays(e.ColumnIndex - 4).ToString("yyyyMMdd") & " and depart_date >= " & dtpNow.Value.AddDays(e.ColumnIndex - 4).ToString("yyyyMMdd") & ");", connection)
                    adapter = New MySqlDataAdapter(cmd1)
                    adapter.Fill(dtRCode)

                    If dtRCode.Rows.Count <> 0 Then
                        MessageBox.Show("Reservation Code = " & dtRCode.Rows(0).Item(0) & vbNewLine &
                                        "Booked by = " & dtRCode.Rows(0).Item(1) & vbNewLine &
                                        "Guest Name = ")
                    End If

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)

                End Try

            ElseIf dgvRoomPlan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "VA" Then
                MessageBox.Show("masuk ke modul new reservation")

            End If

        End If


    End Sub

    Private Sub dgvRoomPlan_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRoomPlan.CellClick
        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 4 Then
            If dgvRoomPlan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "VA" Then
                btnModule.Text = "Reservation"
            ElseIf dgvRoomPlan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "RV" Then
                btnModule.Text = "CheckIn"
            ElseIf dgvRoomPlan.Rows(e.RowIndex).Cells(e.ColumnIndex).Value = "CI" Then
                btnModule.Text = "Checkout"
            End If
        End If
    End Sub
End Class