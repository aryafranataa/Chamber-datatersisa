Imports MySql.Data.MySqlClient
Public Class EmployeeSearch
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtEmployee As New DataTable

    Private Sub EmployeeSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tboEmployeeCode.Text = ""
        tboName.Text = ""
        tboJobPosition.Text = ""
        btnSearch_Click(sender, e)


    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dtEmployee.Clear()
        'tampilin
        Try

            cmd1 = New MySqlCommand("SELECT e.employee_id as 'EMPLOYE CODE', e.employee_name as 'NAME', e.employee_address as 'ADDRESS', s.sex_name as 'SEX', e.username as 'USERNAME', j.job_name as 'POSITION' FROM employee e, sex s, job j where e.employee_id <> 'EMP0000' and j.job_id <> 'JOP00000' and j.job_id = e.job_id and e.sex_id=s.sex_id and e.aktif = 1 having e.employee_id like """ & "%" & tboEmployeeCode.Text & "%" & """ and e.employee_name like """ & "%" & tboName.Text & "%" & """ and j.job_name like """ & "%" & tboJobPosition.Text & "%" & """ order by e.employee_id asc ;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtEmployee)

            dgvEmployee.DataSource = dtEmployee
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        insertofupdateEmployee = 0
        
        Try
            EmployeeCode = dgvEmployee.Item(0, dgvEmployee.CurrentRow.Index).Value

            EmployeeForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Please select the employee that will be edited")
        End Try

        EmployeeSearch_Load(sender, e)
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        insertofupdateEmployee = 1

        EmployeeForm.ShowDialog()
        btnSearch_Click(sender, e)
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim result As Integer = MessageBox.Show("Employee '" & dgvEmployee.Item(1, dgvEmployee.CurrentRow.Index).Value & "' is going to be deleted permanently. Do you want to continue this porcess?", "Warning", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim sql As String = "UPDATE  `chamberdb`.`employee` SET  `aktif` =  '0' WHERE  `employee`.`username` =  '" & dgvEmployee.Item(4, dgvEmployee.CurrentRow.Index).Value & "';"
            Dim sql2 As String = "UPDATE  `chamberdb`.`user` SET  `aktif` =  '0' WHERE  `user`.`username` =  '" & dgvEmployee.Item(4, dgvEmployee.CurrentRow.Index).Value & "';"

            Try
                OpenCloseConnection()
                Dim command As New MySqlCommand(sql, connection)
                command.ExecuteNonQuery()
                command = New MySqlCommand(sql2, connection)
                command.ExecuteNonQuery()
                OpenCloseConnection()
                MessageBox.Show("Employee '" & dgvEmployee.Item(1, dgvEmployee.CurrentRow.Index).Value & "' has been deleted")
                EmployeeSearch_Load(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                OpenCloseConnection()
            End Try

        ElseIf result = DialogResult.No Then

        End If
    End Sub


End Class