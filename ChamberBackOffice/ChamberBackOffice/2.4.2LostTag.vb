Imports System.Console
Imports MySql.Data.MySqlClient
Public Class LostandFoundTag
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtLostandFound As New DataTable

    Private Sub kosongin()

        tboCustomerCode.Text = ""
        tboItem.Text = ""
        tboLnFCode.Text = ""
        tboIdentityCard.Text = ""
        tboRoomNumber.Text = ""
        lblRoomNumber.Text = "-"
        tboNote.Text = ""

        dtpLostDate.Enabled = True
        lueLostby.Enabled = True

        dtLostandFound.Clear()
    End Sub




    Private Sub LostandFoundTag_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()


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
            lueLostby.EditValue = "CUS00000"
        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try




        If insertorupdateLostandFound = 1 Then
            lblLnF.Visible = False
            tboLnFCode.Visible = False
            tboRoomNumber.Enabled = True
            tboRoomNumber.Select()
            btnSavenNew.Visible = True


        ElseIf insertorupdateLostandFound = 0 Then
            lblLnF.Visible = True
            tboLnFCode.Visible = True
            tboRoomNumber.Enabled = False

            tboLnFCode.Text = LnFCode
            btnSavenNew.Visible = False

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

    Private Sub btnPlus1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlus1.Click
        dtpLostDate.Value = dtpLostDate.Value.AddDays(+1)
    End Sub

    Private Sub btnMinus1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinus1.Click
        dtpLostDate.Value = dtpLostDate.Value.AddDays(-1)
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

    Private Sub lueLostby_EditValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lueLostby.EditValueChanged

        If lueLostby.EditValue = "CUS00000" Then
            'do nothing
            tboCustomerCode.Text = ""
            tboIdentityCard.Text = ""
        Else


            tboIdentityCard.Text = lueLostby.Properties.GetDataSourceValue("Legal_id", lueLostby.ItemIndex)
            tboCustomerCode.Text = lueLostby.Properties.GetDataSourceValue("Customer_id", lueLostby.ItemIndex)

        End If
    End Sub

    Private Sub btnSavenNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavenNew.Click
        If insertorupdateLostandFound = 1 Then
            If lblRoomNumber.ForeColor = Color.Green Then
                If tboItem.Text <> "" Then
                    If tboCustomerCode.Text <> "" Then
                        Dim sql As String = "INSERT INTO `chamberdb`.`lost_found` (`lost_found_id`, `room`, `date_found`, `item`, `date_lost`, `found_by`, `lost_by`, `aktif`, `note`) VALUES (NULL, '" & tboRoomNumber.Text & "', NULL, '" & tboItem.Text & "', '" & dtpLostDate.Value.ToString("yyyyMMdd") & "', 'EMP00000', '" & tboCustomerCode.Text & "', '1', '" & tboNote.Text & "');"
                        Dim command As New MySqlCommand(sql, connection)
                        Try
                            OpenCloseConnection()
                            command.ExecuteNonQuery()
                            OpenCloseConnection()
                            MessageBox.Show("New lost tag has been added")

                            LostandFoundTag_Load(sender, e)
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
                If tboCustomerCode.Text <> "" Then
                    Dim sql As String = "UPDATE `chamberdb`.`lost_found` SET `item` = '" & tboItem.Text & "', `date_lost` = '" & dtpLostDate.Value.ToString("yyyyMMdd") & "', `lost_by` = '" & tboCustomerCode.Text & "', `aktif` = '0', `note` = '" & tboNote.Text & "' WHERE `lost_found`.`lost_found_id` = " & tboLnFCode.Text & ";"
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
                            LostandFoundTag_Load(sender, e)
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