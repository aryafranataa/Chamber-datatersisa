Imports MySql.Data.MySqlClient

Public Class ChangeRoomStatus
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim isFirstClick As Integer = 0
    Dim dtRoomStatus As New DataTable

    Private Sub PreparingDatagidView()
        dgvChangeStatus.Columns.Clear()
        dgvChangeStatus.Rows.Clear()

        'Menggambar nama kolom di dgv
        dgvChangeStatus.ColumnCount = dtRoomStatus.Columns.Count
        Dim column As DataGridViewColumn = dgvChangeStatus.Columns(0)
        For i = 0 To (dtRoomStatus.Columns.Count)
            If i < dtRoomStatus.Columns.Count Then
                dgvChangeStatus.Columns(i).Name = dtRoomStatus.Columns(i).ColumnName()
                column = New DataGridViewColumn
                column = dgvChangeStatus.Columns(i)
                column.Width = 90
            Else

                dgvChangeStatus.Columns.Add(New DataGridViewComboBoxColumn)
                dgvChangeStatus.Columns(i).Name = "cboChangeto"
                dgvChangeStatus.Columns(i).HeaderText = "CHANGE TO"
                column.Width = 150

            End If

        Next



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

    Private Sub ChangeRoomStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MewarnaiTexbox()

        'Select Room Plan
        Dim RScmd As New MySqlCommand
        Dim RSAdapter As New MySqlDataAdapter

        Dim RSComand As String
        RSComand = "select r.room_num as 'ROOM NUM',r.floor as 'FLOOR', r.type_id as 'TYPE',  if(pi.`CUST STATUS` = 6, concat(`ROOM STATUS`,' - ', 'ED'),if(pi.`CUST STATUS` = 7, concat(`ROOM STATUS`,' - ', 'EA'),`ROOM STATUS`)) as 'ROOM STATUS' from (select rm.room_num, rm.floor, rm.type_id, rm.status_room_id AS 'ROOM STATUS' from room rm where aktif = 1) r right join (SELECT SUM(CASE WHEN (arrival_Date <= 20150218 and depart_date >= 20150218 ) THEN if(checkout_by is not null,if(depart_date = 20150218,1,5),if(checkin_by is not null and checkout_by is null,IF(depart_date = 20150218,6,4),if(checkin_by is null and with_dp = '1',IF(arrival_Date = 20150218,7,IF(depart_date = 20150218,6,3)),if(checkin_by is null and with_dp = '0', IF(arrival_Date = 20150218,7,IF(depart_date = 20150218,6,2)), 1)))) ELSE 0 END) AS 'CUST STATUS', rv.room_num FROM reservation_checkin_out rv, room rm where rv.aktif = 1 and rv.room_num = rm.room_num  group by rv.room_num asc order by rv.room_num) pi on r.room_num = pi.room_num;"
        Try
            OpenCloseConnection()
            RScmd = New MySqlCommand(RSComand, connection)
            RSAdapter = New MySqlDataAdapter(RScmd)
            RSAdapter.Fill(dtRoomStatus)
            OpenCloseConnection()

            'dgvChangeStatus.DataSource = dtRoomStatus

            'dgvChangeStatus.Columns.Add(New DataGridViewComboBoxColumn)
            'dgvChangeStatus.Columns(4).Name = "cboChangeto"
            'dgvChangeStatus.Columns(4).HeaderText = "CHANGE TO"


            'preparing
            PreparingDatagidView()


            'Menggambar, mengisi dan mewarna row nya dgv
            For i = 0 To dtRoomStatus.Rows.Count - 1
                dgvChangeStatus.Rows.Add()
                For j = 0 To dtRoomStatus.Columns.Count - 1
                    If j < 3 Then
                        dgvChangeStatus.Rows(i).Cells(j).Value = dtRoomStatus.Rows(i).Item(j)
                    ElseIf j = 3 Then
                        dgvChangeStatus.Rows(i).Cells(j).Value = dtRoomStatus.Rows(i).Item(j)

                        If dgvChangeStatus.Rows(i).Cells(j).Value = "OcC" Then
                            dgvChangeStatus.Rows(i).Cells(j).Style.BackColor = Color.Cyan
                        ElseIf dgvChangeStatus.Rows(i).Cells(j).Value = "OcD" Then
                            dgvChangeStatus.Rows(i).Cells(j).Style.BackColor = Color.RosyBrown
                        ElseIf dgvChangeStatus.Rows(i).Cells(j).Value = "OcDD" Then
                            dgvChangeStatus.Rows(i).Cells(j).Style.BackColor = Color.Lavender
                        ElseIf dgvChangeStatus.Rows(i).Cells(j).Value = "OOS" Then
                            dgvChangeStatus.Rows(i).Cells(j).Style.BackColor = Color.OrangeRed
                        ElseIf dgvChangeStatus.Rows(i).Cells(j).Value = "VaCI" Then
                            dgvChangeStatus.Rows(i).Cells(j).Style.BackColor = Color.LightGreen
                        ElseIf dgvChangeStatus.Rows(i).Cells(j).Value = "VaCN" Then
                            dgvChangeStatus.Rows(i).Cells(j).Style.BackColor = Color.LightSeaGreen
                        ElseIf dgvChangeStatus.Rows(i).Cells(j).Value = "VaD" Then
                            dgvChangeStatus.Rows(i).Cells(j).Style.BackColor = Color.Goldenrod
                        ElseIf dgvChangeStatus.Rows(i).Cells(j).Value = "VaCN - EA" Then
                            dgvChangeStatus.Rows(i).Cells(j).Style.BackColor = Color.Orange
                        ElseIf dgvChangeStatus.Rows(i).Cells(j).Value = "VaCI - EA" Then
                            dgvChangeStatus.Rows(i).Cells(j).Style.BackColor = Color.LightGreen
                        ElseIf dgvChangeStatus.Rows(i).Cells(j).Value = "OcD - ED" Then
                            dgvChangeStatus.Rows(i).Cells(j).Style.BackColor = Color.DimGray
                        ElseIf dgvChangeStatus.Rows(i).Cells(j).Value = "OcDD - ED" Then
                            dgvChangeStatus.Rows(i).Cells(j).Style.BackColor = Color.DimGray
                       
                        End If

                    End If
                Next
            Next

        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try

        'ngisi datagridview combobox
        'dgvChangeStatus_CellClick(sender, e)






    End Sub





    Private Sub dgvChangeStatus_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvChangeStatus.CellClick
        If isFirstClick = 0 Then
            For i = 0 To dtRoomStatus.Rows.Count - 1
                If i <> dtRoomStatus.Rows.Count - 1 Then
                    Dim cbCell = TryCast(dgvChangeStatus.Rows(i).Cells("cboChangeto"), DataGridViewComboBoxCell)
                    Dim StatusOption As String() = {"OcD", "OcC"}
                    Select Case dgvChangeStatus.Rows(i).Cells("ROOM STATUS").Value.ToString()
                        Case "VaCI"
                            StatusOption = New String() {"VaCI", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "VaCN"
                            StatusOption = New String() {"VaCN", "VaCI", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "VaD"
                            StatusOption = New String() {"VaD", "VaCI", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "OcC"
                            StatusOption = New String() {"OcC", "OcDD", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "OcD"
                            StatusOption = New String() {"OcD", "OcC", "OcDD", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "OcDD"
                            StatusOption = New String() {"OcDD", "OcC", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "OOS"
                            StatusOption = New String() {"OOS", "VaCI"}
                            cbCell.DataSource = StatusOption

                        Case "VaCN - EA"
                            StatusOption = New String() {"VaCN", "VaCI", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "VaCI - EA"
                            StatusOption = New String() {"VaCI", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "OcD - ED"
                            StatusOption = New String() {"OcD", "OcDD", "OcDP", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "OcDD - ED"
                            StatusOption = New String() {"OcDD", "OcC", "OOS"}
                            cbCell.DataSource = StatusOption
                            Exit Select
                            ' case "other": add other colors
                    End Select
                    isFirstClick = 0
                Else

                    Dim cbCell = TryCast(dgvChangeStatus.Rows(i).Cells("cboChangeto"), DataGridViewComboBoxCell)
                    Dim StatusOption As String() = {"OcD", "OcC"}
                    Select Case dgvChangeStatus.Rows(i).Cells("ROOM STATUS").Value.ToString()
                        Case "VaCI"
                            StatusOption = New String() {"VaCI", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "VaCN"
                            StatusOption = New String() {"VaCN", "VaCI", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "VaD"
                            StatusOption = New String() {"VaD", "VaCI", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "OcC"
                            StatusOption = New String() {"OcC", "OcDD", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "OcD"
                            StatusOption = New String() {"OcD", "OcC", "OcDD", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "OcDD"
                            StatusOption = New String() {"OcDD", "OcC", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "OOS"
                            StatusOption = New String() {"OOS", "VaCI"}
                            cbCell.DataSource = StatusOption

                        Case "VaCN - EA"
                            StatusOption = New String() {"VaCN", "VaCI", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "VaCI - EA"
                            StatusOption = New String() {"VaCI", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "OcD - ED"
                            StatusOption = New String() {"OcD", "OcDD", "OcDP", "OOS"}
                            cbCell.DataSource = StatusOption

                        Case "OcDD - ED"
                            StatusOption = New String() {"OcDD", "OcC", "OOS"}
                            cbCell.DataSource = StatusOption
                            Exit Select
                            ' case "other": add other colors
                    End Select
                    isFirstClick = 1
                End If
            Next
        Else

        End If

    End Sub
   
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'Get the index & Text value of the current combo selection in a datagridview
        For i = 0 To dtRoomStatus.Rows.Count - 1
            Try
                Dim myComboBoxCell As DataGridViewComboBoxCell = DirectCast(dgvChangeStatus.Item("cboChangeto", i), DataGridViewComboBoxCell)
                Dim mText As String = myComboBoxCell.Value
                Dim sql As String = ""
                If mText = "" Then
                    sql = "UPDATE `chamberdb`.`room` SET `status_room_id` = '" & mText & "' WHERE `room`.`room_num` = '" & dgvChangeStatus.Item(3, i).Value & "';"
                Else
                    sql = "UPDATE `chamberdb`.`room` SET `status_room_id` = '" & mText & "' WHERE `room`.`room_num` = '" & dgvChangeStatus.Item(0, i).Value & "';"
                End If
                Try
                    Dim command As New MySqlCommand(sql, connection)
                    OpenCloseConnection()
                    command.ExecuteNonQuery()
                    OpenCloseConnection()


                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    OpenCloseConnection()
                End Try
            Catch ex As Exception

            End Try
            
        Next
        MessageBox.Show("Room status has been saved")
        
    End Sub

End Class