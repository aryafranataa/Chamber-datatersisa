Imports MySql.Data.MySqlClient

Public Class InRoomFacility

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtInRoomFacility As New DataTable
    Dim InRoomFacility As String


    Private Sub RefreshingPage()
        dtInRoomFacility.Clear()
        tboInroomFacilityCode.Text = ""
        tboInroomFacilityName.Text = ""
        InRoomFacility = ""

        tboInroomFacilityCode.Select()


        Try
            cmd1 = New MySqlCommand("SELECT s.room_specification_id as 'IRF CODE', s.room_specification_name as 'IR FACILITY' FROM specification s where aktif = '1';", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtInRoomFacility)

            dgvInRoomFacility.DataSource = dtInRoomFacility


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If tboInroomFacilityCode.Text = "" Or tboInroomFacilityName.Text = "" Then
            MessageBox.Show("Pelase complete all field")
            RefreshingPage()
        Else
            Dim sql As String = "INSERT INTO `chamberdb`.`specification` (`room_specification_id`, `room_specification_name`, `aktif`) VALUES ('" & tboInroomFacilityCode.Text.ToUpper & "', '" & tboInroomFacilityName.Text.ToUpper & "', '1');"
            Dim command As New MySqlCommand(sql, connection)
            Try
                OpenCloseConnection()
                command.ExecuteNonQuery()
                OpenCloseConnection()


            Catch ex As Exception
                MessageBox.Show("Please insert another code")
                OpenCloseConnection()
            End Try

            btnRefresh_Click(sender, e)

        End If
    End Sub

    Private Sub InRoomFacility_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshingPage()



    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        InRoomFacility_Load(sender, e)

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If tboInroomFacilityCode.Text = "" Or tboInroomFacilityName.Text = "" Then
            MessageBox.Show("Pelase complete all field")
            RefreshingPage()
        Else

            Dim sqlUpdate As String
            Dim cmd1 As New MySqlCommand
            sqlUpdate = "UPDATE `chamberdb`.`specification` SET `room_specification_id` = '" & tboInroomFacilityCode.Text & "', `room_specification_name` = '" & tboInroomFacilityName.Text & "' WHERE `specification`.`room_specification_id` = '" & InRoomFacility & "';"
            Try
                OpenCloseConnection()
                cmd1 = New MySqlCommand(sqlUpdate, connection)
                cmd1.ExecuteNonQuery()
                OpenCloseConnection()
                MessageBox.Show("In Room Facility has been updated")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try

            btnRefresh_Click(sender, e)

        End If
    End Sub



    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If tboInroomFacilityCode.Text = "" Or tboInroomFacilityName.Text = "" Then
            MessageBox.Show("Pelase select the field that will be deleted")
            RefreshingPage()
        Else
            Dim result As Integer = MessageBox.Show("In Room Facility '" & tboInroomFacilityName.Text.ToUpper & "' is going to be deleted permanently. Do you want to continue this process?", "Warning", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim sqlUpdate As String
                Dim cmd1 As New MySqlCommand
                sqlUpdate = "UPDATE `chamberdb`.`specification` SET `aktif` = '0' WHERE `specification`.`room_specification_id` = '" & dgvInRoomFacility.Item(0, dgvInRoomFacility.CurrentRow.Index).Value & "';"
                'UPDATE `chamberdb`.`specification` SET `aktif` = '0' WHERE `specification`.`room_specification_id` = 'INF05';
                Try
                    OpenCloseConnection()
                    cmd1 = New MySqlCommand(sqlUpdate, connection)
                    cmd1.ExecuteNonQuery()
                    OpenCloseConnection()
                    MessageBox.Show("In Room Facility has been deleted")
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

                RefreshingPage()
            ElseIf result = DialogResult.No Then

            End If
        End If


    End Sub

    Private Sub dgvInRoomFacility_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInRoomFacility.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            InRoomFacility = dgvInRoomFacility.Rows(e.RowIndex).Cells(0).Value
            tboInroomFacilityCode.Text = dgvInRoomFacility.Rows(e.RowIndex).Cells(0).Value
            tboInroomFacilityName.Text = dgvInRoomFacility.Rows(e.RowIndex).Cells(1).Value
        End If
    End Sub
End Class