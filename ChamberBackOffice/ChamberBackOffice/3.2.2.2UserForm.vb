Imports MySql.Data.MySqlClient

Public Class UserForm

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtGroup As New DataTable

    Public Sub kosongin()
        dtGroup.Clear()
        tboEmployeeCode.Text = ""
        tboPassword.Text = ""
        tboUsername.Text = ""
        tboVerifyPassword.Text = ""
        lblValidOrNot.Text = ""

        If username = "admin" Or username = "sadmin" Then
            btnReset.Visible = True
        Else
            btnReset.Visible = False
        End If

     


    End Sub

    Private Sub UserForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()

        Try
            If username = "admin" Or username = "sadmin" Then
                cmd1 = New MySqlCommand("SELECT u.group_id as 'GROUP CODE', u.group_name as 'GROUP NAME' FROM user_group u WHERE u.aktif = '1' and u.group_id <> 'UG0000' and u.group_id <> 'UG0001';", connection)
            Else
                cmd1 = New MySqlCommand("SELECT u.group_id as 'GROUP CODE', u.group_name as 'GROUP NAME' FROM user_group u WHERE u.aktif = '1' and u.group_id <> 'UG0000' and u.group_id <> 'UG0001' and u.group_id <> 'UG0002';", connection)
            End If

            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtGroup)
            cboUserGroup.DataSource = dtGroup
            cboUserGroup.DisplayMember = "GROUP NAME"
            cboUserGroup.ValueMember = "GROUP CODE"

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

        If insertofupdateUser = 1 Then
            tboUsername.Enabled = True
            tboUsername.Text = ""
            tboUsername.Select()
            tboPassword.Visible = True
            tboVerifyPassword.Visible = True
            lblPassword.Visible = True
            lblVerifyPassword.Visible = True
            btnSavenNew.Visible = True

            'Fill Lue Found by
            Dim Foundcmd As New MySqlCommand
            Dim FoundAdapter As New MySqlDataAdapter
            Dim dtFound As New DataTable
            Dim FoundCommand As String
            FoundCommand = "SELECT employee_id, employee_name, j.job_name FROM employee e, job j where j.job_id= e.job_id and j.aktif = 1 and e.aktif = 1 and username = 'UG0000';"
            Try
                OpenCloseConnection()
                Foundcmd = New MySqlCommand(FoundCommand, connection)
                FoundAdapter = New MySqlDataAdapter(Foundcmd)
                FoundAdapter.Fill(dtFound)
                OpenCloseConnection()
                lueName.Properties.DataSource = dtFound
                lueName.Properties.DisplayMember = "employee_name"
                lueName.Properties.ValueMember = "employee_id"
                lueName.EditValue = "EMP00000"
            Catch ex As Exception
                'MessageBox.Show(ex.ToString)
            End Try




        ElseIf insertofupdateUser = 0 Then
            tboUsername.Text = UserNameForm
            tboUsername.Enabled = False

            tboPassword.Visible = False
            tboVerifyPassword.Visible = False
            lblPassword.Visible = False
            lblVerifyPassword.Visible = False
            btnSavenNew.Visible = False


            'Fill Lue Found by
            Dim Foundcmd As New MySqlCommand
            Dim FoundAdapter As New MySqlDataAdapter
            Dim dtFound As New DataTable
            Dim FoundCommand As String
            FoundCommand = "select r.employee_id, r.employee_name, pi.job_name from (select employee_id, employee_name, job_id from employee where aktif = 1 ) r left join (select job_id, job_name from job where aktif = 1) pi on r.job_id = pi.job_id;"
            Try
                OpenCloseConnection()
                Foundcmd = New MySqlCommand(FoundCommand, connection)
                FoundAdapter = New MySqlDataAdapter(Foundcmd)
                FoundAdapter.Fill(dtFound)
                OpenCloseConnection()
                lueName.Properties.DataSource = dtFound
                lueName.Properties.DisplayMember = "employee_name"
                lueName.Properties.ValueMember = "employee_id"


                tboUsername_Leave(sender, e)

                lueName.Enabled = False

                'lueName.EditValue = "EMP00000"
            Catch ex As Exception
                'MessageBox.Show(ex.ToString)
            End Try





        End If
    End Sub

    Private Sub tboUsername_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboUsername.Leave
        If insertofupdateUser = 1 Then    'insert
            If tboUsername.Text <> "" Then 'pastikan terisi
                Try
                    Dim dtUsername As New DataTable
                    cmd1 = New MySqlCommand("SELECT u.username as 'USERNAME' FROM `user` u where username ='" + tboUsername.Text + "'", connection)
                    adapter = New MySqlDataAdapter(cmd1)
                    adapter.Fill(dtUsername)
                    If dtUsername.Rows.Count = 1 Then
                        lblValidOrNot.Text = "This username has been already existed"
                        lblValidOrNot.ForeColor = Color.Red

                    ElseIf dtUsername.Rows.Count = 0 Then
                        'do nothing
                        'tboRoomTypeID.Enabled = False

                        lblValidOrNot.Text = "This username is available"
                        lblValidOrNot.ForeColor = Color.Green
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Else
                lblValidOrNot.Text = "Please insert username"
                lblValidOrNot.ForeColor = Color.Red

            End If

        ElseIf insertorupdateRoomType = 0 Then     'update
            Try
                Dim dtUsername As New DataTable
                cmd1 = New MySqlCommand("select e.employee_id as 'EMPLOYEE CODE', u.name as 'NAME', u.username as 'USERNAME', g.group_name as 'GROUP NAME', g.group_id as 'GROUP CODE' from user_group g, `user`u, employee e where e.username = u.username and g.aktif = '1' and u.aktif='1' and u.group_id=g.group_id and u.username <> 'sadmin' and u.username = '" & tboUsername.Text & "';", connection)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtUsername)
                If dtUsername.Rows.Count >= 1 Then
                    lueName.EditValue = dtUsername.Rows(0).Item("EMPLOYEE CODE")
                    lueName_EditValueChanged(sender, e)
                    cboUserGroup.SelectedValue = dtUsername.Rows(0).Item("GROUP CODE")
                    'tboEmployeeCode.Text = dtUsername.Rows(0).Item("EMPLOYEE CODE")
                End If
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub btnSavenNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavenNew.Click
        If insertofupdateUser = 1 Then    'insert
            If lblValidOrNot.ForeColor = Color.Green Then
                If tboUsername.Text <> "" And tboEmployeeCode.Text <> "" Then
                    If tboPassword.Text <> "" And tboVerifyPassword.Text <> "" And tboPassword.Text = tboVerifyPassword.Text Then
                        Dim sql As String = "INSERT INTO `chamberdb`.`user` (`username`, `group_id`, `password`, `name`, `aktif`) VALUES ('" & tboUsername.Text & "', '" & cboUserGroup.SelectedValue & "', MD5('" & tboPassword.Text & "'), '" & lueName.Properties.GetDataSourceValue("employee_name", lueName.ItemIndex) & "', '1');"
                        Dim sqlUpdate As String = "UPDATE `chamberdb`.`employee` SET `username` = '" & tboUsername.Text & "' WHERE `employee`.`employee_id` = '" & tboEmployeeCode.Text & "';"

                        Dim command As New MySqlCommand(sql, connection)
                        Dim commandUpdate As New MySqlCommand(sqlUpdate, connection)
                        Try
                            OpenCloseConnection()
                            command.ExecuteNonQuery()
                            commandUpdate.ExecuteNonQuery()
                            OpenCloseConnection()
                            MessageBox.Show("user " & tboUsername.Text & " has been added")
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                            OpenCloseConnection()
                        End Try

                        UserForm_Load(sender, e)
                    Else
                        MessageBox.Show("Password did not match with verify password. Please try again.")

                    End If
                Else
                    MessageBox.Show("Please complete all fields")
                    tboUsername.Select()
                End If


            ElseIf lblPassword.ForeColor = Color.Red Then
                MessageBox.Show("Please make sure username is available")
                tboUsername.Select()
            End If




        ElseIf insertofupdateUser = 0 Then ' update

            Dim sql As String = "UPDATE `chamberdb`.`user` SET `group_id` = '" & cboUserGroup.SelectedValue & "', `aktif` = '1' WHERE `user`.`username` = '" & tboUsername.Text & "';"
            Dim command As New MySqlCommand(sql, connection)
            Try
                OpenCloseConnection()
                command.ExecuteNonQuery()
                OpenCloseConnection()
                MessageBox.Show("username " & tboUsername.Text & " has been updated")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                OpenCloseConnection()
            End Try

            UserForm_Load(sender, e)

        ElseIf lblValidOrNot.ForeColor = Color.Red Then
            MessageBox.Show("username has been already existed")
            tboPassword.Text = ""
            tboVerifyPassword.Text = ""
            tboUsername.Select()
        End If
    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click
        Dim result As Integer = MessageBox.Show("Do you want to reset " & tboUsername.Text & "'s password to default password [same like username in lowercase]?", "Reset Password", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            isReset = 1
            ChangePasswordForm.ShowDialog()
        ElseIf result = DialogResult.Yes Then
            UsernamePassword.ShowDialog()
            If isAuthenticated = 1 Then
                Dim sql As String = "UPDATE `chamberdb`.`user` SET `password` = md5('" & tboUsername.Text.ToLower & "') WHERE `user`.`username` = '" & tboUsername.Text & "';"
                Dim command As New MySqlCommand(sql, connection)
                Try
                    OpenCloseConnection()
                    command.ExecuteNonQuery()
                    OpenCloseConnection()
                    MessageBox.Show(tboUsername.Text & "'s password has been reset to default")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    OpenCloseConnection()
                End Try
            ElseIf isAuthenticated = 0 Then
                'MessageBox.Show("")
            End If


        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnSavenNew_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub lueName_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueName.EditValueChanged
        If lueName.EditValue = "EMP00000" Then
            'do nothing
            tboEmployeeCode.Text = ""
            tboJobPosition.Text = ""
        Else
            tboEmployeeCode.Text = lueName.Properties.GetDataSourceValue("employee_id", lueName.ItemIndex)
            tboJobPosition.Text = lueName.Properties.GetDataSourceValue("job_name", lueName.ItemIndex)

        End If

    End Sub

   
End Class