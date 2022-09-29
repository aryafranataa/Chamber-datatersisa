Imports MySql.Data.MySqlClient
Public Class JobPosition
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtJobPosition As New DataTable
    Dim JobPositionCode As String
    Private Sub RefreshingPage()
        dtJobPosition.Clear()
        tboJobPositionCode.Text = ""
        tboJobPositionName.Text = ""

        JobPositionCode = ""

        Try
            cmd1 = New MySqlCommand("SELECT job_id as 'JOB CODE', job_name as 'JOB POSITION' FROM job j where aktif = 1 and job_id <> 'JOP00000';", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtJobPosition)
            dgvJobPosition.DataSource = dtJobPosition
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        tboJobPositionCode.Select()
    End Sub

    Private Sub JobPosition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshingPage()
    End Sub



    Private Sub dgvJobPosition_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvJobPosition.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            JobPositionCode = dgvJobPosition.Rows(e.RowIndex).Cells(0).Value
            tboJobPositionCode.Text = dgvJobPosition.Rows(e.RowIndex).Cells(0).Value
            tboJobPositionName.Text = dgvJobPosition.Rows(e.RowIndex).Cells(1).Value
        End If
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If tboJobPositionCode.Text = "" Or tboJobPositionName.Text = "" Then
            MessageBox.Show("Pelase complete all field")
            RefreshingPage()
        Else
            Dim sql As String = "INSERT INTO `chamberdb`.`job` (`job_id`, `job_name`, `aktif`) VALUES ('" & tboJobPositionCode.Text.ToUpper & "', '" & tboJobPositionName.Text.ToUpper & "', '1');"
            Dim command As New MySqlCommand(sql, connection)
            Try
                OpenCloseConnection()
                command.ExecuteNonQuery()
                OpenCloseConnection()
            Catch ex As Exception
                MessageBox.Show("Please insert another code")
                OpenCloseConnection()
            End Try

            RefreshingPage()

        End If
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        tboJobPositionCode.Text = dgvJobPosition.Item(0, dgvJobPosition.CurrentRow.Index).Value

        If tboJobPositionName.Text = "" Or tboJobPositionName.Text = "" Then
            MessageBox.Show("Pelase complete all field")
            RefreshingPage()

        Else
            Dim sqlUpdate As String
            Dim cmd1 As New MySqlCommand
            sqlUpdate = "UPDATE `chamberdb`.`job` SET `job_name` = '" & tboJobPositionName.Text & "' WHERE `job`.`job_id` = '" & dgvJobPosition.Item(0, dgvJobPosition.CurrentRow.Index).Value & "';"

            Try
                OpenCloseConnection()
                cmd1 = New MySqlCommand(sqlUpdate, connection)
                cmd1.ExecuteNonQuery()
                OpenCloseConnection()
                MessageBox.Show("Job position has been updated")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try

            RefreshingPage()

        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        If tboJobPositionCode.Text = "" Or tboJobPositionName.Text = "" Then
            MessageBox.Show("Pelase select the field which will be deleted")
            RefreshingPage()
        Else
            Dim sqlUpdate As String
            Dim cmd1 As New MySqlCommand
            sqlUpdate = "UPDATE  `chamberdb`.`job` SET  `aktif` =  '0' WHERE  `job`.`job_id` =  '" & dgvJobPosition.Item(0, dgvJobPosition.CurrentRow.Index).Value & "';"

            Try
                OpenCloseConnection()
                cmd1 = New MySqlCommand(sqlUpdate, connection)
                cmd1.ExecuteNonQuery()
                OpenCloseConnection()
                MessageBox.Show("Job position has been deleted")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

            RefreshingPage()
        End If
    End Sub

    Private Sub dgvJobPosition_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvJobPosition.CellContentClick

    End Sub
End Class