Imports System.Console
Imports MySql.Data.MySqlClient
Public Class LostandFoundForm
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtLostandFound As New DataTable


    Private Sub kosongin()
        tboCustomerCode.Text = ""
        tboEmployeeCode.Text = ""
        lueFoundby.EditValue = ""
        tboIdentityCard.Text = ""
        tboItem.Text = ""
        tboLnFCode.Text = ""
        lueLostby.EditValue = ""
        tboPosition.Text = ""
        tboRoomNumber.Text = ""
        lblStatus.Text = ""
        lblRoomNumber.Text = "-"

        chkNotFound.Enabled = True
        chkNotLost.Enabled = True

        dtpFoundDate.Enabled = True
        dtpLostDate.Enabled = True

        lueFoundby.Enabled = True
        lueLostby.Enabled = True

    End Sub

 


    Private Sub LostandFoundForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        chkNotFound.Checked = False
        chkNotLost.Checked = False
        chkNotFound_CheckedChanged(sender, e)
        chkNotLost_CheckedChanged(sender, e)


        kosongin()


        'Fill Lue Cus Name
        Dim Cuscmd As New MySqlCommand
        Dim CusAdapter As New MySqlDataAdapter
        Dim dtCus As New DataTable
        Dim CusComand As String
        CusComand = "select Customer_id, Legal_id, Name from customer where aktif = '1';"
        Try
            OpenCloseConnection()
            Cuscmd = New MySqlCommand(CusComand, connection)
            CusAdapter = New MySqlDataAdapter(Cuscmd)
            CusAdapter.Fill(dtCus)
            OpenCloseConnection()
            lueLostby.Properties.DataSource = dtCus
            lueLostby.Properties.DisplayMember = "Name"
            lueLostby.Properties.ValueMember = "Customer_id"
            lueLostby.EditValue = ""
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try

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
            lueFoundby.Properties.DataSource = dtFound
            lueFoundby.Properties.DisplayMember = "employee_name"
            lueFoundby.Properties.ValueMember = "employee_id"
            lueFoundby.EditValue = ""
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try


        'Fill in Room Number
        Dim ACCNcmd As New MySqlCommand
        Dim ACCNAdapter As New MySqlDataAdapter
        Dim dtACCN As New DataTable
        Dim ACCNComand As String
        ACCNComand = "SELECT room_num FROM room r where aktif=1;"
        Try
            OpenCloseConnection()
            ACCNcmd = New MySqlCommand(ACCNComand, connection)
            ACCNAdapter = New MySqlDataAdapter(ACCNcmd)
            ACCNAdapter.Fill(dtACCN)
            OpenCloseConnection()
            Dim col As New AutoCompleteStringCollection
            For i = 0 To dtACCN.Rows.Count - 1
                col.Add(dtACCN.Rows(i)("room_num").ToString())
            Next
            tboRoomNumber.AutoCompleteSource = AutoCompleteSource.CustomSource
            tboRoomNumber.AutoCompleteCustomSource = col
            tboRoomNumber.AutoCompleteMode = AutoCompleteMode.Suggest
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try


        If insertorupdateLostandFound = 1 Then
            tboLnFCode.Text = ""
            lblLnF.Visible = False
            tboLnFCode.Visible = False

            tboRoomNumber.Select()

        ElseIf insertorupdateLostandFound = 0 Then
            tboLnFCode.Text = LnFCode
            lblLnF.Visible = True
            tboLnFCode.Visible = True
            lblStatus.Text = "Suspended"
            lblStatus.ForeColor = Color.Red

            dtLostandFound.Clear()
            Try

                cmd1 = New MySqlCommand("SELECT * FROM lost_found l where lost_found_id = '" & tboLnFCode.Text & "'", connection)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtLostandFound)

                If dtLostandFound.Rows.Count > 0 Then
                    tboRoomNumber.Text = dtLostandFound.Rows(0).Item("room")
                    tboItem.Text = dtLostandFound.Rows(0).Item("item")

                    If dtLostandFound.Rows(0).Item("found_by") <> "" Or IsDBNull(dtLostandFound.Rows(0).Item("found_by")) Then
                        chkNotFound.Enabled = False
                        dtpLostDate.Enabled = False

                        lueFoundby.EditValue = dtLostandFound.Rows(0).Item("found_by")
                        lueFoundby.Enabled = False
                        dtpFoundDate.Enabled = False
                        chkNotFound.Checked = True

                    ElseIf dtLostandFound.Rows(0).Item("found_by") = "" Or Not IsDBNull(dtLostandFound.Rows(0).Item("found_by")) Then
                        chkNotLost.Enabled = False
                        dtpFoundDate.Enabled = False

                        lueLostby.EditValue = dtLostandFound.Rows(0).Item("lost_by")
                        lueLostby.Enabled = False
                        dtpLostDate.Enabled = False
                        chkNotLost.Checked = True


                    End If


                    lblRoomNumber.Text = "Valid"
                    lblRoomNumber.ForeColor = Color.Green
                    tboRoomNumber.Enabled = False
                    tboItem.Enabled = False



                Else
                    MessageBox.Show("This Lost and Found Code is expired.")
                    Me.Close()
                End If


            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try



            tboRoomNumber.Select()
        End If
    End Sub

    Private Sub chkNotFound_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNotFound.CheckedChanged


        If insertorupdateLostandFound = 1 Then
            If chkNotFound.Checked = False Then
                dtpFoundDate.Enabled = False
                lueFoundby.EditValue = ""
                tboEmployeeCode.Text = ""
                tboPosition.Text = ""

                lueFoundby.Enabled = False
                tboEmployeeCode.Enabled = False
                tboPosition.Enabled = False


            ElseIf chkNotFound.Checked = True Then
                dtpFoundDate.Enabled = True

                lueFoundby.Enabled = True
                tboEmployeeCode.Enabled = False
                tboPosition.Enabled = False
            End If

            If chkNotFound.Checked = True And chkNotLost.Checked = True Then
                MessageBox.Show("Please checked up either lost or found's tag.")
                chkNotFound.Checked = False
                chkNotLost.Checked = False

                chkNotFound_CheckedChanged(sender, e)
                chkNotLost_CheckedChanged(sender, e)

            ElseIf chkNotFound.Checked = True Or chkNotLost.Checked = True Then
                tboRoomNumber.Text = ""
                tboItem.Text = ""

                tboRoomNumber.Enabled = True
                tboItem.Enabled = True

                lblStatus.Text = "Suspended"
                lblStatus.ForeColor = Color.Red

            ElseIf chkNotFound.Checked = False And chkNotLost.Checked = False Then

                tboRoomNumber.Text = ""
                tboItem.Text = ""

                tboRoomNumber.Enabled = False
                tboItem.Enabled = False

                lblStatus.Text = "Suspended"
                lblStatus.ForeColor = Color.Red

            End If


        ElseIf insertorupdateLostandFound = 0 Then
            If chkNotFound.Checked = False Then
                dtpFoundDate.Enabled = False
                lueFoundby.Enabled = False
            ElseIf chkNotFound.Checked = True Then
                If chkNotFound.Enabled = False Then
                    dtpFoundDate.Enabled = False
                    lueFoundby.Enabled = False
                Else
                    dtpFoundDate.Enabled = True
                    lueFoundby.Enabled = True

                End If

            End If
        End If


    End Sub

    Private Sub chkNotLost_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkNotLost.CheckedChanged


        If insertorupdateLostandFound = 1 Then
            If chkNotLost.Checked = False Then
                dtpLostDate.Enabled = False

                tboCustomerCode.Text = ""
                lueLostby.EditValue = ""
                tboIdentityCard.Text = ""

                lueLostby.Enabled = False

                tboCustomerCode.Enabled = False
                tboIdentityCard.Enabled = False


            ElseIf chkNotLost.Checked = True Then
                dtpLostDate.Enabled = True

                lueLostby.Enabled = True

                tboCustomerCode.Enabled = False
                tboIdentityCard.Enabled = False
            End If

            If chkNotFound.Checked = True And chkNotLost.Checked = True Then
                MessageBox.Show("Please checked up either lost or found's tag.")
                chkNotFound.Checked = False
                chkNotLost.Checked = False

                chkNotFound_CheckedChanged(sender, e)
                chkNotLost_CheckedChanged(sender, e)

            ElseIf chkNotFound.Checked = True Or chkNotLost.Checked = True Then
                tboRoomNumber.Text = ""
                tboItem.Text = ""

                tboRoomNumber.Enabled = True
                tboItem.Enabled = True

                lblStatus.Text = "Suspended"
                lblStatus.ForeColor = Color.Red

            ElseIf chkNotFound.Checked = False And chkNotLost.Checked = False Then

                tboRoomNumber.Text = ""
                tboItem.Text = ""

                tboRoomNumber.Enabled = False
                tboItem.Enabled = False

                lblStatus.Text = "Suspended"
                lblStatus.ForeColor = Color.Red

            End If


        ElseIf insertorupdateLostandFound = 0 Then
            If chkNotLost.Checked = False Then
                dtpLostDate.Enabled = False
                lueLostby.Enabled = False

            ElseIf chkNotLost.Checked = True Then
                If chkNotLost.Enabled = False Then
                    dtpLostDate.Enabled = False
                    lueLostby.Enabled = False

                Else

                    dtpLostDate.Enabled = True
                    lueLostby.Enabled = True
                End If

            End If


        End If
    End Sub

    Private Sub btnSavenNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavenNew.Click
        If insertorupdateLostandFound = 1 Then
            If chkNotFound.Checked = True Xor chkNotLost.Checked = True Then
                If lblRoomNumber.ForeColor = Color.Green Then
                    If tboItem.Text <> "" Then
                        If tboEmployeeCode.Text <> "" Xor tboCustomerCode.Text <> "" Then
                            Dim sql As String = "INSERT INTO `chamberdb`.`lost_found` (`lost_found_id`, `room`, `date_found`, `item`, `date_lost`, `found_by`, `lost_by`, `aktif`) VALUES (NULL, '101', " & dtpFoundDate.Value.ToString("yyyyMMdd") & ", '" & tboItem.Text & "', " & dtpLostDate.Value.ToString("yyyyMMdd") & ", '" & tboEmployeeCode.Text & "', '" & tboCustomerCode.Text & "', '1');"
                            Dim command As New MySqlCommand(sql, connection)
                            Try
                                OpenCloseConnection()
                                command.ExecuteNonQuery()
                                OpenCloseConnection()
                            Catch ex As Exception
                                MessageBox.Show("Please insert another code")
                                OpenCloseConnection()
                            End Try

                        Else
                            MessageBox.Show("Please complete all the fields")
                        End If
                    Else
                        MessageBox.Show("Please complete all the fields")
                    End If


                Else
                    MessageBox.Show("Room Number does not exist. Please try again.")
                    tboRoomNumber.Text = ""
                    tboRoomNumber.Select()
                End If
            Else
                MessageBox.Show("Please checked up either item has been found or lost")

            End If


        ElseIf insertorupdateLostandFound = 0 Then

        End If
    End Sub

    Private Sub lueLostby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueLostby.EditValueChanged

        If lueLostby.EditValue = "CUS00000" Then
            'do nothing
            tboCustomerCode.Text = ""
            tboIdentityCard.Text = ""
        Else

            Dim Cuscmd As New MySqlCommand
            Dim CusAdapter As New MySqlDataAdapter
            Dim dtCus As New DataTable
            Dim CusComand As String
            CusComand = "select customer_id as 'CUSTOMER CODE', legal_id as 'ID CARD' from customer where Customer_id='" & lueLostby.EditValue & "' and aktif = '1';"
            Try
                OpenCloseConnection()
                Cuscmd = New MySqlCommand(CusComand, connection)
                CusAdapter = New MySqlDataAdapter(Cuscmd)
                CusAdapter.Fill(dtCus)
                OpenCloseConnection()

                tboIdentityCard.Text = dtCus.Rows(0)("ID CARD").ToString
                tboCustomerCode.Text = dtCus.Rows(0)("CUSTOMER CODE").ToString

            Catch ex As Exception

            End Try
        End If

    End Sub

    Private Sub lueFoundby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFoundby.EditValueChanged
        If lueFoundby.EditValue = "EMP000" Then
            'do nothing
            tboEmployeeCode.Text = ""
            tboPosition.Text = ""
        Else
            Dim Cuscmd As New MySqlCommand
            Dim CusAdapter As New MySqlDataAdapter
            Dim dtCus As New DataTable
            Dim CusComand As String


            CusComand = "SELECT e.employee_id, e.employee_name, j.job_name  FROM employee e, job j where e.job_id = j.job_id and e.aktif=1 and e.employee_id = '" & lueFoundby.EditValue & "' order by employee_id asc;"
            Try
                OpenCloseConnection()
                Cuscmd = New MySqlCommand(CusComand, connection)
                CusAdapter = New MySqlDataAdapter(Cuscmd)
                CusAdapter.Fill(dtCus)
                OpenCloseConnection()

                tboEmployeeCode.Text = dtCus.Rows(0)("employee_id").ToString
                tboPosition.Text = dtCus.Rows(0)("job_name").ToString

            Catch ex As Exception

            End Try

        End If


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

    Private Sub tboRoomNumber_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomNumber.Leave
        Dim dtRoomNumeber As New DataTable

        Try

            cmd1 = New MySqlCommand("SELECT room_num FROM room r where aktif=1 and room_num = '" & tboRoomNumber.Text & "'", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtRoomNumeber)

            If dtRoomNumeber.Rows.Count > 0 Then
                lblRoomNumber.Text = "Valid"
                lblRoomNumber.ForeColor = Color.Green
            Else
                lblRoomNumber.Text = "Invalid"
                lblRoomNumber.ForeColor = Color.Red
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub
End Class