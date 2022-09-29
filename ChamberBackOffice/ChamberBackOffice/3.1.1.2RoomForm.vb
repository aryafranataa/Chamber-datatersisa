Imports MySql.Data.MySqlClient

Public Class RoomForm

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtRoomForm As New DataTable

    Dim dtFacilityDatabase As New DataTable
    Dim dtFacilityDatabasewithCode As New DataTable
    Dim dtFacilityChosen As New DataTable
    Dim dtFacilityChosenwithCode As New DataTable

    Dim row As DataRow


    Private Sub kosongin()
        If insertorupdateRoom = 1 Then

            RoomCode = ""
            dtRoomForm.Clear()
            dtFacilityChosen.Clear()
            dtFacilityDatabase.Clear()
            dtFacilityChosenwithCode.Clear()
            dtFacilityDatabasewithCode.Clear()
            tboFloor.Text = ""
            tboRoomTypeID.Text = ""
            tboRoomTypeName.Text = ""
            tboStandadCapacity.Text = ""
            tboRoomNumber.Text = ""
            tboQuantity.Text = ""
            lblRoomNumberAvailable.Text = "-"
            lblRoomTypeAvailable.Text = "-"
            lblRoomNumberAvailable.ForeColor = Color.Red
            lblRoomTypeAvailable.ForeColor = Color.Red

            cboAddOnePerson.SelectedItem = "----"
            btnSavenNew.Visible = True
          

        ElseIf insertorupdateRoom = 0 Then

            dtRoomForm.Clear()
            dtFacilityChosen.Clear()
            dtFacilityDatabase.Clear()
            dtFacilityChosenwithCode.Clear()
            dtFacilityDatabasewithCode.Clear()
            tboFloor.Text = ""
            tboRoomTypeID.Text = ""
            tboRoomTypeName.Text = ""
            tboStandadCapacity.Text = ""
            tboRoomNumber.Text = ""
            tboQuantity.Text = ""
            lblRoomNumberAvailable.Text = "-"
            lblRoomTypeAvailable.Text = "-"
            lblRoomNumberAvailable.ForeColor = Color.Red
            lblRoomTypeAvailable.ForeColor = Color.Red

            cboAddOnePerson.SelectedItem = "----"
            btnSavenNew.Visible = False

        End If


    End Sub


    Private Sub RoomForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()

        If insertorupdateRoom = 1 Then
            Try
                cmd1 = New MySqlCommand("SELECT room_specification_id as 'IRF CODE', room_specification_name as 'INROOM FACILITY' FROM specification s where aktif = 1;", connection)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtFacilityDatabasewithCode)

                'duplikate dtDatabase dan tampilkan
                cmd1 = New MySqlCommand("SELECT room_specification_name as 'INROOM FACILITY' FROM specification s where aktif = 1;", connection)
                adapter = New MySqlDataAdapter(cmd1)

                adapter.Fill(dtFacilityDatabase)

                dgvFacilityDatabase.DataSource = dtFacilityDatabase

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try


            'Fill in Room Type
            Dim ACCNcmd1 As New MySqlCommand
            Dim ACCNAdapter1 As New MySqlDataAdapter
            Dim dtACCN1 As New DataTable
            Dim ACCNComand1 As String
            ACCNComand1 = "SELECT * FROM `type` t where aktif = 1;"
            Try
                OpenCloseConnection()
                ACCNcmd1 = New MySqlCommand(ACCNComand1, connection)
                ACCNAdapter1 = New MySqlDataAdapter(ACCNcmd1)
                ACCNAdapter1.Fill(dtACCN1)
                OpenCloseConnection()
                Dim col As New AutoCompleteStringCollection
                For i = 0 To dtACCN1.Rows.Count - 1
                    col.Add(dtACCN1.Rows(i)("type_id").ToString())
                Next
                tboRoomTypeID.AutoCompleteSource = AutoCompleteSource.CustomSource
                tboRoomTypeID.AutoCompleteCustomSource = col
                tboRoomTypeID.AutoCompleteMode = AutoCompleteMode.Suggest
            Catch ex As Exception
                'MessageBox.Show(ex.ToString)
            End Try

        ElseIf insertorupdateRoom = 0 Then

            Try
                'select room dulu
                cmd1 = New MySqlCommand("SELECT * FROM room r where aktif = 1 and room_id = '" & RoomCode & "';", connection)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtRoomForm)

                If dtRoomForm.Rows.Count > 0 Then
                    tboRoomTypeID.Text = dtRoomForm.Rows(0).Item("type_id")
                    tboRoomTypeID_Leave(sender, e)
                    tboRoomNumber.Text = dtRoomForm.Rows(0).Item("room_num")
                    tboRoomNumber_Leave(sender, e)
                    tboFloor.Text = dtRoomForm.Rows(0).Item("floor")
                    If dtRoomForm.Rows(0).Item("one_person") = "1" Then
                        cboAddOnePerson.SelectedItem = "Yes"
                    ElseIf dtRoomForm.Rows(0).Item("one_person") = "0" Then
                        cboAddOnePerson.SelectedItem = "No"
                    ElseIf IsDBNull(dtRoomForm.Rows(0).Item("one_person")) Then
                        cboAddOnePerson.SelectedItem = "----"
                    End If
                    tboStandadCapacity.Text = dtRoomForm.Rows(0).Item("standart_capacity")
                End If

                'select facility Database
                cmd1 = New MySqlCommand("SELECT room_specification_id as 'IRF CODE', room_specification_name as 'INROOM FACILITY' FROM specification s where aktif = 1;", connection)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtFacilityDatabasewithCode)

                'duplikate dtDatabase dan tampilkan
                cmd1 = New MySqlCommand("SELECT room_specification_name as 'INROOM FACILITY' FROM specification s where aktif = 1;", connection)
                adapter = New MySqlDataAdapter(cmd1)

                adapter.Fill(dtFacilityDatabase)

                dgvFacilityDatabase.DataSource = dtFacilityDatabase



                'select Facility Chosen with Code'
                cmd1 = New MySqlCommand("SELECT rs.room_specification_id AS 'IRF CODE', s.room_specification_name as 'INROOM FACILITY', rs.qty AS 'QUANTITY' FROM room_specification rs, room r, specification s where rs.room_id = r.room_id and rs.room_specification_id = s.room_specification_id and r.aktif = 1 and rs.aktif = 1 and s.aktif = 1 and rs.room_id = '" & RoomCode & "';", connection)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtFacilityChosenwithCode)

                'select Facility Chosen'
                cmd1 = New MySqlCommand("SELECT s.room_specification_name as 'INROOM FACILITY', rs.qty AS 'QUANTITY' FROM room_specification rs, room r, specification s where rs.room_id = r.room_id and rs.room_specification_id = s.room_specification_id and r.aktif = 1 and rs.aktif = 1 and s.aktif = 1 and rs.room_id = '" & RoomCode & "';", connection)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtFacilityChosen)

                dgvFacilityChosen.DataSource = dtFacilityChosen

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try




        End If










        Try
            'buat coloum untuk dt ID facility choose
            'Declare DataColumn and DataRow variables. 

            'Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = New DataColumn()
            column.DataType = System.Type.GetType("System.String")
            column.ColumnName = "INF CODE"
            dtFacilityChosenwithCode.Columns.Add(column)

            'Create second column.
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "INROOM FACILITY"
            dtFacilityChosenwithCode.Columns.Add(column)

            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "QUANTITY"
            dtFacilityChosenwithCode.Columns.Add(column)


            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "INROOM FACILITY"
            dtFacilityChosen.Columns.Add(column)

            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "QUANTITY"
            dtFacilityChosen.Columns.Add(column)

            'Dim column2 As DataGridViewColumn = dgvFacilityChosen.Columns(0)
            'column2.Width = 30

            'column2 = New DataGridViewColumn
            'column2 = dgvFacilityChosen.Columns(1)
            'column2.Width = 30


        Catch

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

    Private Sub tboFloor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboFloor.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tboStandadCapacity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboStandadCapacity.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub tboQuantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboQuantity.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub tboRoomTypeID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomTypeID.Leave
        Dim dtType As New DataTable
        dtType.Clear()
        Try
            cmd1 = New MySqlCommand("SELECT * FROM `type` t where type_id = '" & tboRoomTypeID.Text & "'", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtType)

            If dtType.Rows.Count >= 1 Then
                lblRoomTypeAvailable.Text = "Valid"
                tboRoomTypeName.Text = dtType.Rows(0).Item(1)
                lblRoomTypeAvailable.ForeColor = Color.Green

                ''Fill in Room Number
                'Dim ACCNcmd As New MySqlCommand
                'Dim ACCNAdapter As New MySqlDataAdapter
                'Dim dtACCN As New DataTable
                'Dim ACCNComand As String
                'ACCNComand = "SELECT room_num FROM room r where aktif=1 and type_id = '" & tboRoomTypeID.Text & "';"
                'Try
                '    OpenCloseConnection()
                '    ACCNcmd = New MySqlCommand(ACCNComand, connection)
                '    ACCNAdapter = New MySqlDataAdapter(ACCNcmd)
                '    ACCNAdapter.Fill(dtACCN)
                '    OpenCloseConnection()
                '    Dim col As New AutoCompleteStringCollection
                '    For i = 0 To dtACCN.Rows.Count - 1
                '        col.Add(dtACCN.Rows(i)("room_num").ToString())
                '    Next
                '    tboRoomNumber.AutoCompleteSource = AutoCompleteSource.CustomSource
                '    tboRoomNumber.AutoCompleteCustomSource = col
                '    tboRoomNumber.AutoCompleteMode = AutoCompleteMode.Suggest
                'Catch ex As Exception
                '    'MessageBox.Show(ex.ToString)
                'End Try




            ElseIf dtType.Rows.Count = 0 Then
                lblRoomTypeAvailable.Text = "Invalid"
                lblRoomTypeAvailable.ForeColor = Color.Red
                tboRoomTypeName.Text = ""



                Dim dtACCN As New DataTable
                Dim col As New AutoCompleteStringCollection
                tboRoomNumber.AutoCompleteSource = AutoCompleteSource.CustomSource
                tboRoomNumber.AutoCompleteCustomSource = col
                tboRoomNumber.AutoCompleteMode = AutoCompleteMode.Suggest
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub

    Private Sub tboRoomNumber_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomNumber.Leave
        Dim dtRoomNumeber As New DataTable

        Try

            If insertorupdateRoom = 1 Then
                cmd1 = New MySqlCommand("SELECT room_num FROM room r where aktif=1 and room_num = '" & tboRoomNumber.Text & "'", connection)
            ElseIf insertorupdateRoom = 0 Then
                cmd1 = New MySqlCommand("select a.room_num from (SELECT * FROM room r where room_num <> '" & RoomNumber & "') a where a.room_num = '" & tboRoomNumber.Text & "';", connection)           '
            End If
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtRoomNumeber)

            If dtRoomNumeber.Rows.Count > 0 Then
                lblRoomNumberAvailable.Text = "This room number has been existed"
                lblRoomNumberAvailable.ForeColor = Color.Red
            Else
                lblRoomNumberAvailable.Text = "Room Number is available"
                lblRoomNumberAvailable.ForeColor = Color.Green

            End If






        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub refreshfacilitychosen()
        dtFacilityChosen.Clear()
        dtFacilityChosenwithCode.Clear()
        dtFacilityDatabase.Clear()
        dtFacilityDatabasewithCode.Clear()
        Try
            'select facility Database
            cmd1 = New MySqlCommand("SELECT room_specification_id as 'IRF CODE', room_specification_name as 'INROOM FACILITY' FROM specification s where aktif = 1;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtFacilityDatabasewithCode)

            'duplikate dtDatabase dan tampilkan
            cmd1 = New MySqlCommand("SELECT room_specification_name as 'INROOM FACILITY' FROM specification s where aktif = 1;", connection)
            adapter = New MySqlDataAdapter(cmd1)

            adapter.Fill(dtFacilityDatabase)

            dgvFacilityDatabase.DataSource = dtFacilityDatabase

            'select Facility Chosen with Code'
            cmd1 = New MySqlCommand("SELECT rs.room_specification_id AS 'IRF CODE', s.room_specification_name as 'INROOM FACILITY', rs.qty AS 'QUANTITY' FROM room_specification rs, room r, specification s where rs.room_id = r.room_id and rs.room_specification_id = s.room_specification_id and r.aktif = 1 and rs.aktif = 1 and s.aktif = 1 and rs.room_id = '" & RoomCode & "';", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtFacilityChosenwithCode)

            'select Facility Chosen'
            cmd1 = New MySqlCommand("SELECT s.room_specification_name as 'INROOM FACILITY', rs.qty AS 'QUANTITY' FROM room_specification rs, room r, specification s where rs.room_id = r.room_id and rs.room_specification_id = s.room_specification_id and r.aktif = 1 and rs.aktif = 1 and s.aktif = 1 and rs.room_id = '" & RoomCode & "';", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtFacilityChosen)

            dgvFacilityChosen.DataSource = dtFacilityChosen

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        If insertorupdateRoom = 1 Then
            If tboQuantity.Text <> "" Then

                Try

                    ''test apakah spesifikasi sudah di tambahakan
                    Dim test As Integer = 0
                    Dim counter As Integer = 0
                    For Each Me.row In dtFacilityChosen.Rows
                        If (dtFacilityChosen.Rows(counter).Item(0).ToString) = (dgvFacilityDatabase.Item(0, dgvFacilityDatabase.CurrentRow.Index).Value) Then
                            test += 1
                        End If
                        counter += 1
                    Next

                    If test = 0 Then

                        'masukkan ke dt chosen either with code or not
                        row = dtFacilityChosenwithCode.NewRow()

                        row("INF CODE") = dtFacilityDatabasewithCode.Rows(dgvFacilityDatabase.CurrentRow.Index).Item(0)
                        row("INROOM FACILITY") = dtFacilityDatabasewithCode.Rows(dgvFacilityDatabase.CurrentRow.Index).Item(1)
                        row("QUANTITY") = tboQuantity.Text
                        dtFacilityChosenwithCode.Rows.Add(row)

                        row = dtFacilityChosen.NewRow()
                        row("INROOM FACILITY") = dtFacilityDatabase.Rows(dgvFacilityDatabase.CurrentRow.Index).Item(0)
                        row("QUANTITY") = tboQuantity.Text
                        dtFacilityChosen.Rows.Add(row)

                        dgvFacilityChosen.DataSource = dtFacilityChosen



                    Else
                        MsgBox(dgvFacilityDatabase.Item(0, dgvFacilityDatabase.CurrentRow.Index).Value + " has been inserted")
                    End If


                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try

            Else
                MessageBox.Show("Please insert quantitiy.")
                tboQuantity.Select()

            End If


        ElseIf insertorupdateRoom = 0 Then
            If tboQuantity.Text <> "" Then

                Try
                    'INSERT INTO `chamberdb`.`room_specification` (`room_id`, `room_specification_id`, `qty`, `aktif`) VALUES ('19', 'INF05', '4', '1');
                    'INSERT INTO `chamberdb`.`room_specification` (`" & RoomCode & "`, `" & dtFacilityDatabasewithCode.Rows(dgvFacilityDatabase.CurrentRow.Index).Item(0) & "`, `" & tboQuantity.Text & "`, `aktif`) VALUES ('19', 'INF05', '4', '1');"
                    Dim sql As String = "INSERT INTO `chamberdb`.`room_specification` (`room_id`, `room_specification_id`, `qty`, `aktif`) VALUES ('" & RoomCode & "', '" & dtFacilityDatabasewithCode.Rows(dgvFacilityDatabase.CurrentRow.Index).Item(0) & "', '" & tboQuantity.Text & "', '1');"
                    Dim command As New MySqlCommand(sql, connection)
                    OpenCloseConnection()
                    command.ExecuteNonQuery()
                    OpenCloseConnection()
                Catch ex As Exception
                    MsgBox(dgvFacilityDatabase.Item(0, dgvFacilityDatabase.CurrentRow.Index).Value + " has been inserted")
                End Try
                refreshfacilitychosen()
            Else
                MessageBox.Show("Please insert quantitiy.")
                tboQuantity.Select()

            End If

        End If





    End Sub

    Private Sub dgvFacilityChosen_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacilityChosen.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            tboQuantity.Text = dgvFacilityChosen.Rows(e.RowIndex).Cells(1).Value
        End If
    End Sub

    Private Sub dgvFacilityDatabase_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvFacilityDatabase.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            tboQuantity.Text = ""
            tboQuantity.Select()
        End If
    End Sub

    Private Sub btnRemoveFacility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemoveFacility.Click
        If insertorupdateRoom = 1 Then
            If dtFacilityChosen.Rows.Count = 0 Then
            Else
                dtFacilityChosenwithCode.Rows.RemoveAt(dgvFacilityChosen.CurrentRow.Index)
                dtFacilityChosen.Rows.RemoveAt(dgvFacilityChosen.CurrentRow.Index)

            End If

        ElseIf insertorupdateRoom = 0 Then
            If dtFacilityChosen.Rows.Count = 0 Then
            Else
                Try
                    Dim sql As String = "DELETE FROM `room_specification` WHERE `room_id` = '" & RoomCode & "' and `room_specification_id` = '" & dtFacilityChosenwithCode.Rows(dgvFacilityChosen.CurrentRow.Index).Item(0) & "' ;"
                    Dim command As New MySqlCommand(sql, connection)
                    OpenCloseConnection()
                    command.ExecuteNonQuery()
                    OpenCloseConnection()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
                refreshfacilitychosen()

            End If



        End If



    End Sub

    Private Sub btnNewFacility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNewFacility.Click
        InRoomFacility.ShowDialog()
        RoomForm_Load(sender, e)
    End Sub

    Private Sub BtnEditFacility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnEditFacility.Click

        If insertorupdateRoom = 1 Then
            If tboQuantity.Text <> "" Then

                dtFacilityChosenwithCode.Rows(dgvFacilityChosen.CurrentRow.Index).Item(2) = tboQuantity.Text
                dtFacilityChosen.Rows(dgvFacilityChosen.CurrentRow.Index).Item(1) = tboQuantity.Text

                dgvFacilityChosen.DataSource = dtFacilityChosen

            Else
                MessageBox.Show("Please insert quantitiy.")
                tboQuantity.Select()

            End If

        ElseIf insertorupdateRoom = 0 Then
            If tboQuantity.Text <> "" Then


                Dim sql As String = "UPDATE `chamberdb`.`room_specification` SET `qty` = '" & tboQuantity.Text & "' WHERE `room_specification`.`room_id` = '" & RoomCode & "' AND `room_specification`.`room_specification_id` = '" & dtFacilityChosenwithCode.Rows(dgvFacilityChosen.CurrentRow.Index).Item(0) & "';"
                Dim command As New MySqlCommand(sql, connection)
                Try
                    OpenCloseConnection()
                    command.ExecuteNonQuery()
                    OpenCloseConnection()
                Catch ex As Exception
                    MessageBox.Show("Please insert another code")
                    OpenCloseConnection()
                End Try
                refreshfacilitychosen()

            Else
                MessageBox.Show("Please insert quantitiy.")
                tboQuantity.Select()

            End If

        End If




    End Sub


    Private Sub btnSavenNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavenNew.Click
        If insertorupdateRoom = 1 Then


            If lblRoomTypeAvailable.ForeColor = Color.Green Then
                If lblRoomNumberAvailable.ForeColor = Color.Green Then
                    If tboFloor.Text <> "" Or tboStandadCapacity.Text <> "" Or cboAddOnePerson.SelectedIndex <> 0 Then
                        Dim sql As String = "INSERT INTO `chamberdb`.`room` (`room_id`, `type_id`, `username`, `status_room_id`, `room_num`, `floor`, `aktif`, `one_person`, `standart_capacity`, `status_hk_id`) VALUES (NULL, '" & tboRoomTypeID.Text & "', '" & username & "', 'VaCI', '" & tboRoomNumber.Text & "', '" & tboFloor.Text & "', '1', '" & If(cboAddOnePerson.SelectedItem = "Yes", "1", "0") & "', '" & tboStandadCapacity.Text & "', NULL);"
                        Dim command As New MySqlCommand(sql, connection)
                        Try
                            OpenCloseConnection()
                            command.ExecuteNonQuery()
                            OpenCloseConnection()
                        Catch ex As Exception
                            MessageBox.Show("Please insert another code")
                            OpenCloseConnection()
                        End Try

                        Dim dtRoomID As New DataTable

                        If dtFacilityChosen.Rows.Count <> 0 Then
                            Try
                                cmd1 = New MySqlCommand("SELECT room_id FROM room r where aktif=1 and room_num = '" & tboRoomNumber.Text & "'", connection)
                                adapter = New MySqlDataAdapter(cmd1)
                                adapter.Fill(dtRoomID)

                                OpenCloseConnection()
                                For i = 0 To dtFacilityChosen.Rows.Count - 1
                                    sql = "INSERT INTO `chamberdb`.`room_specification` (`room_id`, `room_specification_id`, `qty`, `aktif`) VALUES ('" & dtRoomID.Rows(0).Item(0) & "', '" & dtFacilityChosenwithCode.Rows(i).Item("INF CODE") & "', '" & tboQuantity.Text & "', '1');"
                                    command = New MySqlCommand(sql, connection)
                                    command.ExecuteNonQuery()
                                Next
                                OpenCloseConnection()
                            Catch ex As Exception

                            End Try

                            MessageBox.Show("Room has been setup")
                            RoomForm_Load(sender, e)
                        End If



                    Else

                        MessageBox.Show("Please complete all fields.")
                    End If

                Else
                    MessageBox.Show("Please insert another room number")
                End If

            Else
                MessageBox.Show("Please select existed type room.")
            End If

        ElseIf insertorupdateRoom = 0 Then

            If lblRoomTypeAvailable.ForeColor = Color.Green Then
                If lblRoomNumberAvailable.ForeColor = Color.Green Then
                    If tboFloor.Text <> "" Or tboStandadCapacity.Text <> "" Or cboAddOnePerson.SelectedIndex <> 0 Then

                        Dim sql As String = "UPDATE `chamberdb`.`room` SET `type_id` = '" & tboRoomTypeID.Text & "', `room_num` = '" & tboRoomNumber.Text & "', `floor` = '" & tboFloor.Text & "', `aktif` = '1', `one_person` = '" & If(cboAddOnePerson.SelectedItem = "Yes", "1", "0") & "', `standart_capacity` = '" & tboStandadCapacity.Text & "' WHERE `room`.`room_id` = '" & RoomCode & "';"
                        Dim command As New MySqlCommand(sql, connection)
                        Try
                            OpenCloseConnection()
                            command.ExecuteNonQuery()
                            OpenCloseConnection()
                            MessageBox.Show("Room has been setup")

                        Catch ex As Exception
                            MessageBox.Show("Please insert another code")
                            OpenCloseConnection()
                        End Try

                    Else

                        MessageBox.Show("Please complete all fields.")
                    End If

                Else
                    MessageBox.Show("Please insert another room number")
                End If

            Else
                MessageBox.Show("Please select existed type room.")
            End If

        End If


    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnSavenNew_Click(sender, e)
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click

    End Sub
End Class