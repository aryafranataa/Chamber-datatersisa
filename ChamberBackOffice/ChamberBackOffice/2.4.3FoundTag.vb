Imports System.Console
Imports MySql.Data.MySqlClient



Public Class FoundTag

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtLostandFound As New DataTable

    Private Sub kosongin()

        tboEmployeeCode.Text = ""
        lueFoundby.EditValue = ""
        tboItem.Text = ""
        tboLnFCode.Text = ""
        tboPosition.Text = ""
        tboRoomNumber.Text = ""
        lblRoomNumber.Text = "-"
        tboNote.Text = ""

        dtpFoundDate.Enabled = True
        lueFoundby.Enabled = True


    End Sub

    Private Sub FoundTag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()

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
            lueFoundby.EditValue = "EMP00000"
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
            lblLnF.Visible = False
            tboLnFCode.Visible = False
            tboRoomNumber.Enabled = True
            btnSavenNew.Visible = True


            tboRoomNumber.Select()



        ElseIf insertorupdateLostandFound = 0 Then
            lblLnF.Visible = True
            tboLnFCode.Visible = True
            tboRoomNumber.Enabled = False
            btnSavenNew.Visible = False


            tboLnFCode.Text = LnFCode


            'load form
            Try
                cmd1 = New MySqlCommand("SELECT * FROM lost_found l where lost_found_id = " & tboLnFCode.Text & " ;", connection)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtLostandFound)

                tboRoomNumber.Text = dtLostandFound.Rows(0).Item("room")
                tboItem.Text = dtLostandFound.Rows(0).Item("item")
                tboNote.Text = dtLostandFound.Rows(0).Item("note")




            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try
















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

    Private Sub lueFoundby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueFoundby.EditValueChanged
        If lueFoundby.EditValue = "EMP00000" Then
            'do nothing
            tboEmployeeCode.Text = ""
            tboPosition.Text = ""
        Else
            tboEmployeeCode.Text = lueFoundby.Properties.GetDataSourceValue("employee_id", lueFoundby.ItemIndex)
            tboPosition.Text = lueFoundby.Properties.GetDataSourceValue("job_name", lueFoundby.ItemIndex)
        End If
    End Sub

    Private Sub btnPlus1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus1.Click
        dtpFoundDate.Value = dtpFoundDate.Value.AddDays(+1)
    End Sub

    Private Sub btnMinus1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus1.Click
        dtpFoundDate.Value = dtpFoundDate.Value.AddDays(-1)
    End Sub

    Private Sub btnSavenNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavenNew.Click
        If insertorupdateLostandFound = 1 Then
            If lblRoomNumber.ForeColor = Color.Green Then
                If tboItem.Text <> "" Then
                    If tboEmployeeCode.Text <> "" Then
                        Dim sql As String = "INSERT INTO `chamberdb`.`lost_found` (`lost_found_id`, `room`, `date_found`, `item`, `date_lost`, `found_by`, `lost_by`, `aktif`, `note`) VALUES (NULL, '" & tboRoomNumber.Text & "', '" & dtpFoundDate.Value.ToString("yyyyMMdd") & "', '" & tboItem.Text & "', NULL, '" & tboEmployeeCode.Text & "', 'CUS00000', '1', '" & tboNote.Text & "');"
                        Dim command As New MySqlCommand(sql, connection)
                        Try
                            OpenCloseConnection()
                            command.ExecuteNonQuery()
                            OpenCloseConnection()
                            MessageBox.Show("New found tag has been added")

                            FoundTag_Load(sender, e)
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


        ElseIf insertorupdateLostandFound = 0 Then
            If tboItem.Text <> "" Then
                If tboEmployeeCode.Text <> "" Then
                    Dim sql As String = "UPDATE `chamberdb`.`lost_found` SET `found_by` = '" & tboEmployeeCode.Text & "' , `date_found` = '" & dtpFoundDate.Value.ToString("yyyyMMdd") & "', `item` = '" & tboItem.Text & "', `note` = '" & tboNote.Text & "', `aktif` = '0' WHERE `lost_found`.`lost_found_id` = '" & tboLnFCode.Text & "';"
                    Dim command As New MySqlCommand(sql, connection)
                    Try
                        Dim result As Integer = MessageBox.Show("This lost and found tag will be automatically released. Do you want to continue this process?", "Release", MessageBoxButtons.YesNoCancel)
                        If result = DialogResult.Cancel Then
                            Me.Close()
                        ElseIf result = DialogResult.No Then

                        ElseIf result = DialogResult.Yes Then
                            OpenCloseConnection()
                            command.ExecuteNonQuery()
                            OpenCloseConnection()
                            FoundTag_Load(sender, e)
                        End If


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



        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnSavenNew_Click(sender, e)
        Me.Close()
    End Sub
End Class