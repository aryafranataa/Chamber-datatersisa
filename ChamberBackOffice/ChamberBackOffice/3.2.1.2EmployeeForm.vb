Imports MySql.Data.MySqlClient

Public Class EmployeeForm

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtEmployeeForm As New DataTable


    Private Sub kosongin()
        tboAddress.Text = ""
        tboEmail.Text = ""
        tboEmployeeCode.Text = ""
        tboEmployeeName.Text = ""
        tboPhone1.Text = ""
        tboPhone2.Text = ""
        tboUsername.Text = ""

        cboJobPosition.DataSource = Nothing
        cboSex.DataSource = Nothing

        dtEmployeeForm.Clear()


        tboPassword.Text = ""
        tboVerifyPassword.Text = ""


    End Sub

    Private Sub RefreshingPage()
        kosongin()

        Try
            Dim dtSex As New DataTable
            cmd1 = New MySqlCommand("SELECT * FROM sex s where sex_id <> 1 order by sex_id desc", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtSex)

            cboSex.DataSource = dtSex
            cboSex.ValueMember = "sex_id"
            cboSex.DisplayMember = "sex_name"

            Dim dtJobPosition As New DataTable
            cmd1 = New MySqlCommand("SELECT * FROM job j where aktif = 1", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtJobPosition)

            cboJobPosition.DataSource = dtJobPosition
            cboJobPosition.ValueMember = "job_id"
            cboJobPosition.DisplayMember = "job_name"

            Dim dtUserGroup As New DataTable
            cmd1 = New MySqlCommand("SELECT * FROM user_group u where aktif = 1 and group_id <> 'UG0000'", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtUserGroup)

            cboUserGroup.DataSource = dtUserGroup
            cboUserGroup.ValueMember = "group_id"
            cboUserGroup.DisplayMember = "group_name"


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


        If insertofupdateEmployee = 1 Then
            tboEmployeeCode.Enabled = True
            tboEmployeeCode.Text = ""
            lblPassword.Text = "Password"

            tboEmployeeCode.Select()


        ElseIf insertofupdateEmployee = 0 Then
            tboEmployeeCode.Enabled = False
            tboEmployeeCode.Text = EmployeeCode
            lblPassword.Text = "New Password"

            tboEmployeeName.Select()
            'ambil data untuk semua form

            Try

                cmd1 = New MySqlCommand("select e.employee_id,e.employee_name,e.employee_address,e.sex_id,e.employee_phone1, e.employee_phone2,e.employee_email,e.job_id, u.username, u.group_id from employee e left join `user` u on e.username = u.username and e.aktif = 1 where e.employee_id = '" & tboEmployeeCode.Text & "';", connection)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtEmployeeForm)

                tboEmployeeName.Text = dtEmployeeForm.Rows(0).Item("employee_name")
                tboEmail.Text = dtEmployeeForm.Rows(0).Item("employee_email")
                tboAddress.Text = dtEmployeeForm.Rows(0).Item("employee_address")
                tboPhone1.Text = dtEmployeeForm.Rows(0).Item("employee_phone1")
                tboPhone2.Text = dtEmployeeForm.Rows(0).Item("employee_phone2")
                cboJobPosition.SelectedValue = dtEmployeeForm.Rows(0).Item("job_id")
                cboSex.SelectedValue = dtEmployeeForm.Rows(0).Item("sex_id")

                If Not IsDBNull(dtEmployeeForm.Rows(0).Item("username")) Then
                    tboUsername.Text = dtEmployeeForm.Rows(0).Item("username")
                    tboUsername.Enabled = False
                    cboUserGroup.SelectedValue = dtEmployeeForm.Rows(0).Item("group_id")
                    tboOldPassword.Visible = True
                    lblOldPassword.Visible = True
                    cboUserGroup.Enabled = True


                Else
                    cboUserGroup.SelectedIndex = 0
                    cboUserGroup.Enabled = False

                    tboUsername.Text = ""
                    tboUsername.Enabled = True

                    tboOldPassword.Visible = False
                    lblOldPassword.Visible = False


                End If



            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try

        End If

    End Sub

    Private Sub EmployeeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If insertofupdateEmployee = 1 Then

            chkActive.Checked = False
            chkActive.Visible = True
            chkActive_CheckedChanged(sender, e)
        Else

            chkActive.Checked = True
            chkActive.Visible = False
            chkActive_CheckedChanged(sender, e)
        End If

        RefreshingPage()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnSavenNew_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnSavenNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavenNew.Click
        If insertofupdateEmployee = 1 Then
            If tboEmployeeCode.Text <> "" Then 'pastikan terisi
                If lblValidOrNot.ForeColor <> Color.Red Then
                    If chkActive.Checked = True Then
                        If lblUsername.ForeColor <> Color.Red Then
                            If tboPassword.Text = tboVerifyPassword.Text And tboPassword.Text <> "" And tboVerifyPassword.Text <> "" Then

                                'masukin ke employee

                                Dim sql As String = "INSERT INTO `chamberdb`.`employee` (`employee_id`, `employee_name`, `employee_address`, `sex_id`, `employee_phone1`, `employee_phone2`, `employee_email`, `username`, `job_id`, `aktif`) VALUES ('" & tboEmployeeCode.Text & "', '" & tboEmployeeName.Text & "', '" & tboAddress.Text & "', '" & cboSex.SelectedValue & "', '" & tboPhone1.Text & "', '" & tboPhone2.Text & "', '" & tboEmail.Text & "', '" & tboUsername.Text & "', '" & cboJobPosition.SelectedValue & "', '1');"
                                Dim command As New MySqlCommand(sql, connection)
                                Try
                                    OpenCloseConnection()
                                    command.ExecuteNonQuery()
                                    OpenCloseConnection()
                                Catch ex As Exception
                                    MessageBox.Show(ex.ToString)
                                    OpenCloseConnection()
                                End Try

                                'mau ke user 

                                sql = "INSERT INTO `chamberdb`.`user` (`username`, `group_id`, `password`, `name`, `aktif`) VALUES ('" & tboUsername.Text & "', '" & cboUserGroup.SelectedValue & "', MD5('" & tboPassword.Text & "'), '" & tboEmployeeName.Text & "', '1');"
                                command = New MySqlCommand(sql, connection)
                                Try
                                    OpenCloseConnection()
                                    command.ExecuteNonQuery()
                                    OpenCloseConnection()
                                    MessageBox.Show("Employee '" & tboEmployeeName.Text & " has been added")
                                    insertofupdateEmployee = 1
                                    EmployeeForm_Load(sender, e)
                                Catch ex As Exception
                                    MessageBox.Show(ex.ToString)
                                    OpenCloseConnection()
                                End Try



                            ElseIf tboPassword.Text <> tboVerifyPassword.Text Then
                                MessageBox.Show("Invalid verifying password. Password did not match. Please try again.")
                                tboPassword.Text = ""
                                tboVerifyPassword.Text = ""
                                tboOldPassword.Text = ""

                                tboPassword.Select()

                            End If




                        ElseIf lblUsername.ForeColor <> Color.Red Then
                            MessageBox.Show("Username has been already existed. Please choose another username")
                            tboPassword.Text = ""
                            tboVerifyPassword.Text = ""
                            tboOldPassword.Text = ""

                            tboEmployeeCode.Select()
                        End If

                    ElseIf chkActive.Checked = False Then
                        Dim sql As String = "INSERT INTO `chamberdb`.`employee` (`employee_id`, `employee_name`, `employee_address`, `sex_id`, `employee_phone1`, `employee_phone2`, `employee_email`, `username`, `job_id`, `aktif`) VALUES ('" & tboEmployeeCode.Text & "', '" & tboEmployeeName.Text & "', '" & tboAddress.Text & "', '" & cboSex.SelectedValue & "', '" & tboPhone1.Text & "', '" & tboPhone2.Text & "', '" & tboEmail.Text & "', 'UG0000', '" & cboJobPosition.SelectedValue & "', '1');"
                        Dim command As New MySqlCommand(sql, connection)
                        Try
                            OpenCloseConnection()
                            command.ExecuteNonQuery()
                            OpenCloseConnection()
                            MessageBox.Show("Employee '" & tboEmployeeName.Text.ToUpper & "' has been added")
                            insertofupdateEmployee = 1
                            EmployeeForm_Load(sender, e)
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                            OpenCloseConnection()
                        End Try
                    End If




                ElseIf lblValidOrNot.ForeColor = Color.Red Then
                    MessageBox.Show("Employee Code has been already existed. Please choose another empolyee code")
                    tboPassword.Text = ""
                    tboVerifyPassword.Text = ""
                    tboOldPassword.Text = ""

                    tboEmployeeCode.Select()
                End If





            End If




        ElseIf insertofupdateEmployee = 0 Then

            Dim dtOldpassword As New DataTable
            If tboOldPassword.Visible = True Then 'kalau user punya username dan ganti password
                If tboOldPassword.Text <> "" Then
                    Try
                        cmd1 = New MySqlCommand("SELECT if(md5('" & tboOldPassword.Text & "') = u.password, 1,0) as 'IS VALID' FROM user u where u.aktif = 1 and u.username = '" & tboUsername.Text & "'", connection)
                        adapter = New MySqlDataAdapter(cmd1)
                        adapter.Fill(dtOldpassword)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                    If dtOldpassword.Rows.Count = 1 Then
                        If dtOldpassword.Rows(0).Item(0) = 1 Then
                            If lblUsername.ForeColor = Color.Green Then
                                If tboPassword.Text = tboVerifyPassword.Text Then
                                    Dim sqlUpdate As String
                                    Dim sqlUpdate2 As String
                                    Dim cmd1 As New MySqlCommand
                                    sqlUpdate = "UPDATE `chamberdb`.`employee` SET `employee_name` = '" & tboEmployeeName.Text & "', `employee_address` = '" & tboAddress.Text & "', `sex_id` = '" & cboSex.SelectedValue & "', `employee_phone1` = '" & tboPhone1.Text & "', `employee_phone2` = '" & tboPhone2.Text & "', `employee_email` = '" & tboEmail.Text & "', `job_id` = '" & cboJobPosition.SelectedValue & "', `employee`.`username` = '" & tboUsername.Text & "' WHERE `employee`.`employee_id` = '" & tboEmployeeCode.Text & "';"
                                    sqlUpdate2 = "UPDATE `chamberdb`.`user` SET `group_id` = '" & cboUserGroup.SelectedValue & "', `password` = md5('" & tboPassword.Text & "'), `name` = '" & tboEmployeeName.Text & "', `aktif` = '1' WHERE `user`.`username` = '" & tboUsername.Text & "';"

                                    Try
                                        OpenCloseConnection()
                                        cmd1 = New MySqlCommand(sqlUpdate, connection)
                                        cmd1.ExecuteNonQuery()
                                        cmd1 = New MySqlCommand(sqlUpdate2, connection)
                                        cmd1.ExecuteNonQuery()
                                        OpenCloseConnection()
                                        MessageBox.Show("Employee '" & tboEmployeeName.Text.ToUpper & "' has been updated")
                                        insertofupdateEmployee = 1
                                        EmployeeForm_Load(sender, e)
                                    Catch ex As Exception
                                        MessageBox.Show(ex.ToString)

                                    End Try


                                Else
                                    MessageBox.Show("Invalid verifying password. New Password did'n match. Please try again.")
                                End If

                            ElseIf lblUsername.ForeColor = Color.Red Then
                                MessageBox.Show("username has been alreadey existed. Plase choose another username or blank it.")
                            End If
                        ElseIf dtOldpassword.Rows(0).Item(0) = 0 Then
                            tboOldPassword.Text = ""
                            tboPassword.Text = ""
                            tboVerifyPassword.Text = ""

                            tboOldPassword.Select()
                            MessageBox.Show("Old password did not match. Please try again")

                        End If


                    End If


                ElseIf tboOldPassword.Text = "" Then
                    Dim sqlUpdate As String
                    Dim sqlUpdate2 As String
                    Dim cmd1 As New MySqlCommand
                    sqlUpdate = "UPDATE `chamberdb`.`employee` SET `employee_name` = '" & tboEmployeeName.Text & "', `employee_address` = '" & tboAddress.Text & "', `sex_id` = '" & cboSex.SelectedValue & "', `employee_phone1` = '" & tboPhone1.Text & "', `employee_phone2` = '" & tboPhone2.Text & "', `employee_email` = '" & tboEmail.Text & "', `job_id` = '" & cboJobPosition.SelectedValue & "', `employee`.`username` = '" & tboUsername.Text & "' WHERE `employee`.`employee_id` = '" & tboEmployeeCode.Text & "';"
                    sqlUpdate2 = "UPDATE `chamberdb`.`user` SET `group_id` = '" & cboUserGroup.SelectedValue & "', `name` = '" & tboEmployeeName.Text & "', `aktif` = '1' WHERE `user`.`username` = '" & tboUsername.Text & "';"

                    Try
                        OpenCloseConnection()
                        cmd1 = New MySqlCommand(sqlUpdate, connection)
                        cmd1.ExecuteNonQuery()
                        cmd1 = New MySqlCommand(sqlUpdate2, connection)
                        cmd1.ExecuteNonQuery()
                        OpenCloseConnection()
                        MessageBox.Show("Employee '" & tboEmployeeName.Text.ToUpper & "' has been updated")
                        insertofupdateEmployee = 1
                        EmployeeForm_Load(sender, e)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)

                    End Try

                End If

            ElseIf tboOldPassword.Visible = False Then
                If lblUsername.ForeColor = Color.Green Then
                    If tboPassword.Text = tboVerifyPassword.Text Then
                        Dim sqlUpdate As String
                        Dim sqlUpdate2 As String
                        Dim cmd1 As New MySqlCommand
                        sqlUpdate = "UPDATE `chamberdb`.`employee` SET `employee_name` = '" & tboEmployeeName.Text & "', `employee_address` = '" & tboAddress.Text & "', `sex_id` = '" & cboSex.SelectedValue & "', `employee_phone1` = '" & tboPhone1.Text & "', `employee_phone2` = '" & tboPhone2.Text & "', `employee_email` = '" & tboEmail.Text & "', `job_id` = '" & cboJobPosition.SelectedValue & "', `employee`.`username` = '" & tboUsername.Text & "' WHERE `employee`.`employee_id` = '" & tboEmployeeCode.Text & "';"
                        sqlUpdate2 = "INSERT INTO `chamberdb`.`user` (`username`, `group_id`, `password`, `name`, `aktif`) VALUES ('" & tboUsername.Text & "', '" & cboUserGroup.SelectedValue & "', MD5('" & tboPassword.Text & "'), '" & tboEmployeeName.Text & "', '1');"

                        Try
                            OpenCloseConnection()
                            cmd1 = New MySqlCommand(sqlUpdate, connection)
                            cmd1.ExecuteNonQuery()
                            cmd1 = New MySqlCommand(sqlUpdate2, connection)
                            cmd1.ExecuteNonQuery()
                            OpenCloseConnection()
                            MessageBox.Show("Employee '" & tboEmployeeName.Text.ToUpper & "' has been updated")
                            insertofupdateEmployee = 1
                            EmployeeForm_Load(sender, e)
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)

                        End Try
                    Else
                        MessageBox.Show("Invalid verifying password. New Password did'n match. Please try again.")
                    End If

                ElseIf lblUsername.ForeColor = Color.Red Then
                    MessageBox.Show("username has been alreadey existed. Plase choose another username or blank it.")
                End If

            End If




        End If

    End Sub

    Private Sub tboPhone1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboPhone1.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tboPhone2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboPhone2.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnAddJobPosition_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddJobPosition.Click
        JobPosition.ShowDialog()
        Try
            Dim dtJobPosition As New DataTable
            cmd1 = New MySqlCommand("SELECT * FROM job j where aktif = 1", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtJobPosition)

            cboJobPosition.DataSource = dtJobPosition
            cboJobPosition.ValueMember = "job_id"
            cboJobPosition.DisplayMember = "job_name"
        Catch ex As Exception

        End Try



    End Sub

    Private Sub tboEmployeeCode_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboEmployeeCode.Leave
        If insertofupdateEmployee = 1 Then    'insert
            If tboEmployeeCode.Text <> "" Then 'pastikan terisi
                Try
                    Dim dtEmployeeCode As New DataTable
                    cmd1 = New MySqlCommand("SELECT * from employee u where employee_id ='" + tboEmployeeCode.Text + "'", connection)
                    adapter = New MySqlDataAdapter(cmd1)
                    adapter.Fill(dtEmployeeCode)
                    If dtEmployeeCode.Rows.Count = 1 Then
                        lblValidOrNot.Text = "This employeee code has been already existed"
                        lblValidOrNot.ForeColor = Color.Red
                        tboEmployeeCode.Select()
                    ElseIf dtEmployeeCode.Rows.Count = 0 Then
                        'do nothing
                        'tboRoomTypeID.Enabled = False
                        lblValidOrNot.Text = "This employee code is available"
                        lblValidOrNot.ForeColor = Color.Green
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            End If

        ElseIf insertorupdateRoomType = 0 Then     'update
        

        End If
    End Sub

    Private Sub tboUsername_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboUsername.Leave
        If insertofupdateEmployee = 1 Then    'insert
            If chkActive.Checked = True Then
                If tboUsername.Text <> "" Then 'pastikan terisi
                    Try
                        Dim dtEmployeeCode As New DataTable
                        cmd1 = New MySqlCommand("SELECT * from user u where username ='" + tboUsername.Text + "'", connection)
                        adapter = New MySqlDataAdapter(cmd1)
                        adapter.Fill(dtEmployeeCode)
                        If dtEmployeeCode.Rows.Count = 1 Then
                            lblUsername.Text = "This username has beed already existed"
                            lblUsername.ForeColor = Color.Red

                            tboUsername.Select()
                        ElseIf dtEmployeeCode.Rows.Count = 0 Then
                            'do nothing
                            'tboRoomTypeID.Enabled = False
                            lblUsername.Text = "This username is available"
                            lblUsername.ForeColor = Color.Green

                            tboPassword.Text = ""
                            tboVerifyPassword.Text = ""



                            tboPassword.Enabled = True
                            tboVerifyPassword.Enabled = True
                            lblPassword.Enabled = True
                            lblVerifyPassword.Enabled = True
                            lblUserGroup.Enabled = True
                            cboUserGroup.Enabled = True





                        End If
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try
                End If

            ElseIf chkActive.Checked = False Then
                lblUsername.Text = ""
                lblUsername.ForeColor = Color.Red
            End If

           

        ElseIf insertorupdateRoomType = 0 Then     'update
           
            If tboUsername.Text <> "" Then 'pastikan terisi
                Try
                    Dim dtEmployeeCode As New DataTable
                    cmd1 = New MySqlCommand("SELECT * from user u where username ='" + tboUsername.Text + "'", connection)
                    adapter = New MySqlDataAdapter(cmd1)
                    adapter.Fill(dtEmployeeCode)
                    If dtEmployeeCode.Rows.Count = 1 Then
                        lblUsername.Text = "This username has been already existed"
                        lblUsername.ForeColor = Color.Red

                        tboPassword.Text = ""
                        tboVerifyPassword.Text = ""


                        tboPassword.Enabled = False
                        tboVerifyPassword.Enabled = False
                        lblPassword.Enabled = False
                        lblVerifyPassword.Enabled = False
                        lblUserGroup.Enabled = False
                        cboUserGroup.Enabled = False

                    ElseIf dtEmployeeCode.Rows.Count = 0 Then
                        'do nothing
                        'tboRoomTypeID.Enabled = False
                        lblUsername.Text = "This username is available"
                        lblUsername.ForeColor = Color.Green

                        tboPassword.Text = ""
                        tboVerifyPassword.Text = ""


                        tboPassword.Enabled = True
                        tboVerifyPassword.Enabled = True
                        lblPassword.Enabled = True
                        lblVerifyPassword.Enabled = True
                        lblUserGroup.Enabled = True
                        cboUserGroup.Enabled = True


                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            ElseIf tboUsername.Text = "" Then
                lblUsername.Text = "Username is not set"
                lblUsername.ForeColor = Color.Green

                tboPassword.Text = ""
                tboVerifyPassword.Text = ""


                tboPassword.Enabled = False
                tboVerifyPassword.Enabled = False
                lblPassword.Enabled = False
                lblVerifyPassword.Enabled = False
                lblUserGroup.Enabled = False
                cboUserGroup.Enabled = False




            End If
        End If
    End Sub

    Private Sub chkActive_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkActive.CheckedChanged
        If insertofupdateEmployee = 1 Then

            If chkActive.Checked = False Then
                tboUsername.Text = ""
                lblUsername.Text = ""
                lblUsername.ForeColor = Color.Red
                tboPassword.Text = ""
                tboVerifyPassword.Text = ""

                tboPassword.Enabled = False
                tboVerifyPassword.Enabled = False
                lblPassword.Enabled = False
                lblVerifyPassword.Enabled = False
                lblOldPassword.Visible = False
                tboOldPassword.Visible = False
                lblUserGroup.Enabled = False
                cboUserGroup.Enabled = False
                tboUsername.Enabled = False

            ElseIf chkActive.Checked = True Then
                tboUsername.Text = ""
                lblUsername.Text = ""

                tboPassword.Text = ""
                tboVerifyPassword.Text = ""

                tboUsername.Enabled = True
            End If




        ElseIf insertofupdateEmployee = 0 Then
            If chkActive.Checked = True Then

                lblValidOrNot.Text = ""
                lblValidOrNot.ForeColor = Color.Green
                lblUsername.Text = ""
                lblUsername.ForeColor = Color.Green


                tboOldPassword.Text = ""
                tboPassword.Text = ""
                tboVerifyPassword.Text = ""


                tboPassword.Enabled = True
                tboVerifyPassword.Enabled = True
                lblPassword.Enabled = True
                lblVerifyPassword.Enabled = True

                cboUserGroup.Enabled = False
                lblOldPassword.Visible = False
                tboOldPassword.Visible = False
                lblUserGroup.Enabled = False
                tboUsername.Enabled = False
                tboOldPassword.Visible = False
                lblOldPassword.Visible = False


            End If

        End If


    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class