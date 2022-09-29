Imports MySql.Data.MySqlClient
Public Class Facility

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtFacility As New DataTable
    Dim FacilityID As String

    Private Sub RefreshingPage()
        dtFacility.Clear()
        tboFacilityID.Text = ""
        tboFacilityName.Text = ""
        tboRate.Text = ""
        FacilityID = ""

        Try
            cmd1 = New MySqlCommand("SELECT facility_id as `FACILITY ID`, facility_NAME AS `FACILITY  NAME`, rate_facility as `RATE` FROM facility f WHERE aktif = '1';", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtFacility)
            dgvFacility.DataSource = dtFacility


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        tboFacilityID.Select()
    End Sub


    Private Sub dgvFacility_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacility.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            FacilityID = dgvFacility.Rows(e.RowIndex).Cells(0).Value
            tboFacilityID.Text = dgvFacility.Rows(e.RowIndex).Cells(0).Value
            tboFacilityName.Text = dgvFacility.Rows(e.RowIndex).Cells(1).Value
            tboRate.Text = dgvFacility.Rows(e.RowIndex).Cells(2).Value
        End If


    End Sub

    Private Sub Facility_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        RefreshingPage()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If tboFacilityID.Text = "" Or tboFacilityName.Text = "" Then
            MessageBox.Show("Pelase complete all field")
            RefreshingPage()
        Else
            Dim sql As String = "INSERT INTO `chamberdb`.`facility` (`facility_id`, `facility_name`, `rate_facility`, `aktif`) VALUES ('" & tboFacilityID.Text.ToUpper & "', '" & tboFacilityName.Text.ToUpper & "', '" & tboRate.Text.ToUpper & "', '1');"
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

        If tboFacilityID.Text = "" Or tboFacilityName.Text = "" Then
            MessageBox.Show("Pelase complete all field")
            RefreshingPage()

        Else
            Dim sqlUpdate As String
            Dim cmd1 As New MySqlCommand
            sqlUpdate = "UPDATE `chamberdb`.`facility` SET `facility_name` = '" & tboFacilityName.Text & "', `rate_facility` = '" & tboRate.Text & "' WHERE `facility`.`facility_id` = '" & FacilityID & "';"

            Try
                OpenCloseConnection()
                cmd1 = New MySqlCommand(sqlUpdate, connection)
                cmd1.ExecuteNonQuery()
                OpenCloseConnection()
                MessageBox.Show("Facility has been updated")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try

            RefreshingPage()

        End If

    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If tboFacilityID.Text = "" Or tboFacilityName.Text = "" Then
            MessageBox.Show("Pelase select the field that will be deleted")
            RefreshingPage()
        Else
            Dim result As Integer = MessageBox.Show("Facility '" & tboFacilityName.Text.ToUpper & "' is going to be deleted permanently. Do you want to continue this process?", "Warning", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                Dim sqlUpdate As String
                Dim cmd1 As New MySqlCommand
                sqlUpdate = "UPDATE  `chamberdb`.`facility` SET  `aktif` =  '0' WHERE  `facility`.`facility_id` =  '" & dgvFacility.Item(0, dgvFacility.CurrentRow.Index).Value & "';"

                Try
                    OpenCloseConnection()
                    cmd1 = New MySqlCommand(sqlUpdate, connection)
                    cmd1.ExecuteNonQuery()
                    OpenCloseConnection()
                    MessageBox.Show("Facility has been deleted")
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

                RefreshingPage()
            ElseIf result = DialogResult.No Then

            End If



        End If

    End Sub

   
    Private Sub tboRate_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboRate.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub
End Class