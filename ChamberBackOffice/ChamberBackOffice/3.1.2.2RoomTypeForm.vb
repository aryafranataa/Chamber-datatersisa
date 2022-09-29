Imports MySql.Data.MySqlClient

Public Class RoomTypeForm

    Dim numberofRoom As Integer
    Dim numberFrom As Integer
    Dim numberTo As Integer
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter


    Dim RateIDstartFrom As Integer
    Dim dtRate As New DataTable
    Dim counter As Integer
    Public dtMirrorRate As New DataTable
    'Dim dtMirrorRoom As New DataTable
    Dim ArrayStatement(30, 1) As String
    Dim dtRoom As New DataTable





    Private Sub penambahanCounter()
        counter += 1
    End Sub


    Private Sub chkAddMultiRoom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAddMultiRoom.CheckedChanged
        If chkAddMultiRoom.Checked = False Then
            gboRoom.Visible = False
        Else
            gboRoom.Visible = True
        End If
    End Sub


    Private Sub kosongin()
        RateID = ""
        tboFloor.Text = ""
        'tboNumberofRoom.Text = ""
        tboWithBreakfast.Text = ""
        tboRate.Text = ""
        tboRoomTypeID.Text = ""
        tboRoomTypeName.Text = ""

        counter = 0
        RateIDstartFrom = 0
        numberofRoom = 0
        numberFrom = 0
        numberTo = 0
        dtpRateTo.Value = DateTime.Now.AddDays(2)
        Array.Clear(ArrayStatement, 0, 62)
        'satuuu pakeeet
        dtRate.Clear()
        dtMirrorRate.Clear()
        '----sampeee siniiii
        dtRoom.Clear()
    End Sub


    Private Sub RefreshingPage()
        kosongin()

        If insertorupdateRoomType = 1 Then
            tboRoomTypeID.Enabled = True
            tboRoomTypeID.Text = ""

        ElseIf insertorupdateRoomType = 0 Then
            tboRoomTypeID.Enabled = False
            tboRoomTypeID.Text = RoomTypeID
        End If

        'ngambil data RoomType
        Try
            Dim dtRoomType As New DataTable
            dtRoomType.Clear()
            cmd1 = New MySqlCommand("select * from type where type_id = '" + tboRoomTypeID.Text + "'", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtRoomType)
            If dtRoomType.Rows.Count = 1 Then
                tboRoomTypeID.Text = dtRoomType.Rows(0)("type_id")
                tboRoomTypeName.Text = dtRoomType.Rows(0)("type_name")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        'satuuuuuu paaaaakeeeeeeeeeeeeet-----------------------
        'ambil data Rate
        Try

            dtRate.Clear()
            cmd1 = New MySqlCommand("SELECT rate_room as 'ROOM RATE', rate_room_breakfast as 'WITH BREAKFAST', date_on as 'START DATE', date_off as 'END DATE' FROM rate where type_id='" & tboRoomTypeID.Text & "'", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtRate)
            dgvRate.DataSource = dtRate
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

        'ambil Mirroring ID data dari Rate
        Try
            cmd1 = New MySqlCommand("select rate_id as 'RATE ID', rate_room as 'ROOM RATE', rate_room_breakfast as 'WITH BREAKFAST', date_on as 'START DATE', date_off as 'END DATE' FROM rate where type_id='" & tboRoomTypeID.Text & "';", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtMirrorRate)
            RateIDstartFrom = dtMirrorRate.Rows.Count
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        'sampeeee siiniiiiiiiiiii----------------------------

        'ambil data Room
        Try
            cmd1 = New MySqlCommand("select room_num as 'ROOM NUMBER', floor as 'FLOOR' from room where aktif = 1 and type_id = '" & tboRoomTypeID.Text & "' ;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtRoom)
            dgvRoom.DataSource = dtRoom

        Catch ex As Exception
        End Try

        'atur width column

        Dim column As DataGridViewColumn = dgvRate.Columns(0)
        column.Width = 60

        column = New DataGridViewColumn
        column = dgvRate.Columns(1)
        column.Width = 100

        column = New DataGridViewColumn
        column = dgvRate.Columns(2)
        column.Width = 90

        column = New DataGridViewColumn
        column = dgvRate.Columns(3)
        column.Width = 90

        tboRoomTypeID.Select()

    End Sub




    Private Sub RoomTypeForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        chkAddMultiRoom_CheckedChanged(sender, e)
        Try

            'buat table DI BELAKANG (MIRROR)
            'Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = New DataColumn()
            column.DataType = System.Type.GetType("System.String")
            column.ColumnName = "RATE ID"
            dtMirrorRate.Columns.Add(column)


            'Create second column.
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "ROOM RATE"
            dtMirrorRate.Columns.Add(column)

            'Create second column.
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "WITH BREAKFAST"
            dtMirrorRate.Columns.Add(column)

            'Create second column.
            'column = New DataColumn()
            'column.DataType = Type.GetType("System.String")
            'column.ColumnName = "START DATE"
            'dtMirrorRate.Columns.Add(column)

            dtMirrorRate.Columns.Add("START DATE", GetType(DateTime))

            ''Create second column.
            'column = New DataColumn()
            'column.DataType = Type.GetType("System.String")
            'column.ColumnName = "END DATE"
            'dtMirrorRate.Columns.Add(column)

            dtMirrorRate.Columns.Add("END DATE", GetType(DateTime))

            'DI TAMPILIIN
            'Create Room Rate
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "ROOM RATE"
            dtRate.Columns.Add(column)

            'Create Room Rate
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "WITH BREAKFAST"
            dtRate.Columns.Add(column)

            'create Start Date
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "START DATE"
            dtRate.Columns.Add(column)

            'create end date
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "END DATE"
            dtRate.Columns.Add(column)

            '--------------------------------------dari sini mulai roooom


            ''buat table DI BELAKANG (MIRROR)
            ''Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            'column = New DataColumn()
            'column.DataType = System.Type.GetType("System.String")
            'column.ColumnName = "ROOM ID"
            'dtMirrorRoom.Columns.Add(column)

            ''Create second column.
            'column = New DataColumn()
            'column.DataType = Type.GetType("System.String")
            'column.ColumnName = "ROOM NUMBER"
            'dtMirrorRoom.Columns.Add(column)

            'DI TAMPILIIN
            'Create Room NUMBER
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "ROOM NUMBER"
            dtRoom.Columns.Add(column)

            'Create Room NUMBER
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "FLOOR"
            dtRoom.Columns.Add(column)


        Catch ex As Exception

        End Try




        RefreshingPage()

    End Sub


    Private Sub tboStandardOccupancy_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tboMaximumOccupancy_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tboExtraBed_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tboExtraBedCharge_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tboNumberofRoom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
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

    Private Sub tboRoomNumber_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tboRoomNumberto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub



    Dim maxNumber As Integer = 0


    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        btnSavenNew_Click(sender, e)
        Me.Close()

    End Sub

    Private Sub tboRoomTypeID_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomTypeID.Leave
        If insertorupdateRoomType = 1 Then    'insert
            If tboRoomTypeID.Text <> "" Then 'pastikan terisi
                Try
                    Dim dtRoomType As New DataTable
                    cmd1 = New MySqlCommand("select * from `type` where type_id = '" + tboRoomTypeID.Text + "'", connection)
                    adapter = New MySqlDataAdapter(cmd1)
                    adapter.Fill(dtRoomType)
                    If dtRoomType.Rows.Count = 1 Then
                        tboRoomTypeID.Text = ""
                        tboRoomTypeName.Text = ""
                        MessageBox.Show("This room type ID is already exist")
                        tboRoomTypeID.Select()
                    ElseIf dtRoomType.Rows.Count = 0 Then
                        'do nothing
                        tboRoomTypeID.Enabled = False
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                End Try
            End If

        ElseIf insertorupdateRoomType = 0 Then     'update


        End If

    End Sub


    Dim rowdgvRate As String
    Dim RateID As String
    Private Sub dgvRate_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRate.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            rowdgvRate = 0
            rowdgvRate = e.RowIndex
            Try
                RateID = dtMirrorRate.Rows(e.RowIndex).Item("RATE ID")
                tboRate.Text = dgvRate.Rows(e.RowIndex).Cells(0).Value
                tboWithBreakfast.Text = dgvRate.Rows(e.RowIndex).Cells(1).Value
                dtpRateFrom.Value = dgvRate.Rows(e.RowIndex).Cells(2).Value
                dtpRateTo.Text = dgvRate.Rows(e.RowIndex).Cells(3).Value
            Catch ex As Exception

            End Try
        End If
    End Sub

    Private Sub btnAddRate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRate.Click
        'check tanggal dari applikasi

        Dim expression As String = "([START DATE] >= '" & dtpRateFrom.Value.ToString("dd/MM/yyyy") & "' AND [START DATE] <= '" & dtpRateTo.Value.ToString("dd/MM/yyyy") & "') OR ([END DATE] >= '" & dtpRateFrom.Value.ToString("dd/MM/yyyy") & "' AND [END DATE] <= '" & dtpRateTo.Value.ToString("dd/MM/yyyy") & "')"
        ' Sort descending by column named CompanyName. 
        Dim foundRows As DataRow()

        ' Use the Select method to find all rows matching the filter.
        foundRows = dtMirrorRate.[Select](expression)

        Dim checkRangeTanggal As Boolean = False

        ' Print column 0 of each returned row. 
        If foundRows.Length > 0 Then
            MessageBox.Show(foundRows.Length.ToString & " record(s) existed in the selected date range")
            checkRangeTanggal = False

        ElseIf foundRows.Length = 0 Then
            checkRangeTanggal = True
        End If

        If tboRoomTypeID.Text <> "" And tboRoomTypeName.Text <> "" And tboRate.Text <> "" Then
            If dtpRateFrom.Value < dtpRateTo.Value Then
                If checkRangeTanggal = True Then
                    penambahanCounter()
                    'TAMBAH KE MIRROR DULU
                    row = dtMirrorRate.NewRow()

                    row("RATE ID") = "R" & tboRoomTypeID.Text & ubahKodeDiBelakang((RateIDstartFrom + counter), 3)
                    row("ROOM RATE") = tboRate.Text
                    row("WITH BREAKFAST") = tboWithBreakfast.Text
                    row("START DATE") = dtpRateFrom.Value.ToString("yyyy-MM-dd")
                    row("END DATE") = dtpRateTo.Value.ToString("yyyy-MM-dd")

                    dtMirrorRate.Rows.Add(row)

                    'TAMPILIN DI LAYAR
                    row = dtRate.NewRow()
                    row("ROOM RATE") = tboRate.Text
                    row("WITH BREAKFAST") = tboWithBreakfast.Text
                    row("START DATE") = dtpRateFrom.Value.Date
                    row("END DATE") = dtpRateTo.Value.Date

                    dtRate.Rows.Add(row)
                    dgvRate.DataSource = dtRate


                    'SALIN KE STATEMENT


                    ArrayStatement(counter, 0) = "1"
                    ArrayStatement(counter, 1) = "INSERT INTO `chamberdb`.`rate` (`rate_id`, `type_id`, `rate_room`, `date_on`, `date_off`, `aktif`, `rate_room_breakfast`) VALUES ('" & dtMirrorRate.Rows((RateIDstartFrom + counter) - 1).Item("RATE ID") & "', '" & tboRoomTypeID.Text & "', '" & dtMirrorRate.Rows((RateIDstartFrom + counter) - 1).Item("ROOM RATE") & "', '" & Format(CDate(dtMirrorRate.Rows((RateIDstartFrom + counter) - 1).Item("START DATE")), "yyyyMMdd") & "', '" & Format(CDate(dtMirrorRate.Rows((RateIDstartFrom + counter) - 1).Item("END DATE")), "yyyyMMdd") & "', '1', '" & dtMirrorRate.Rows((RateIDstartFrom + counter) - 1).Item("WITH BREAKFAST") & "');"

                    tboRate.Text = ""
                    tboWithBreakfast.Text = ""
                    checkRangeTanggal = False

                    tboRate.Select()


                ElseIf checkRangeTanggal = False Then
                    MessageBox.Show("New start date or end date rate conlfict with recorded date.")
                    checkRangeTanggal = False
                    tboRate.Select()
                End If
            Else
                dtpRateFrom.Value = Today
                dtpRateTo.Value = dtpRateFrom.Value.AddDays(2)
            End If



        Else
            tboRate.Text = ""
            tboWithBreakfast.Text = ""
            Try
                tboRoomTypeID.Select()
            Catch ex As Exception
                tboRoomTypeName.Select()
            End Try

            MessageBox.Show("Please complete the form")
        End If

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        Dim expression As String = "(([START DATE] >= '" & dtpRateFrom.Value.ToString("dd/MM/yyyy") & "' AND [START DATE] <= '" & dtpRateTo.Value.ToString("dd/MM/yyyy") & "') OR ([END DATE] >= '" & dtpRateFrom.Value.ToString("dd/MM/yyyy") & "' AND [END DATE] <= '" & dtpRateTo.Value.ToString("dd/MM/yyyy") & "')) and [RATE ID] <> '" & RateID & "'"
        ' Sort descending by column named CompanyName. 
        Dim foundRows As DataRow()

        ' Use the Select method to find all rows matching the filter.
        foundRows = dtMirrorRate.[Select](expression)

        Dim checkRangeTanggal As Boolean = False

        ' Print column 0 of each returned row. 
        If foundRows.Length > 0 Then
            MessageBox.Show(foundRows.Length.ToString & " record(s) existed in the selected date range")
            checkRangeTanggal = False

        ElseIf foundRows.Length = 0 Then
            checkRangeTanggal = True
        End If



        If tboRoomTypeID.Text <> "" And tboRoomTypeName.Text <> "" And tboRate.Text <> "" Then
            If dtpRateFrom.Value < dtpRateTo.Value Then
                If checkRangeTanggal = True Then
                    'lakukanlah pengupdatean itu
                    penambahanCounter()
                    'edit KE MIRROR DULU
                    dtMirrorRate.Rows(rowdgvRate).Item("ROOM RATE") = tboRate.Text
                    dtMirrorRate.Rows(rowdgvRate).Item("WITH BREAKFAST") = tboWithBreakfast.Text
                    dtMirrorRate.Rows(rowdgvRate).Item("START DATE") = dtpRateFrom.Value.ToString("yyyy-MM-dd")
                    dtMirrorRate.Rows(rowdgvRate).Item("END DATE") = dtpRateTo.Value.ToString("yyyy-MM-dd")

                    'edit yg di datagridview
                    dgvRate.Rows(rowdgvRate).Cells(0).Value = tboRate.Text
                    dgvRate.Rows(rowdgvRate).Cells(1).Value = tboWithBreakfast.Text
                    dgvRate.Rows(rowdgvRate).Cells(2).Value = dtpRateFrom.Value.Date
                    dgvRate.Rows(rowdgvRate).Cells(3).Value = dtpRateTo.Value.Date


                    'salin ke statement
                    ArrayStatement(counter, 0) = "0"
                    ArrayStatement(counter, 1) = "UPDATE `chamberdb`.`rate` SET `rate_room_breakfast` = '" & dtMirrorRate.Rows(rowdgvRate).Item("WITH BREAKFAST") & "', `rate_room` = '" & dtMirrorRate.Rows(rowdgvRate).Item("ROOM RATE") & "', `date_on` = '" & Format(CDate(dtMirrorRate.Rows(rowdgvRate).Item("START DATE")), "yyyyMMdd") & "', `date_off` = '" & Format(CDate(dtMirrorRate.Rows(rowdgvRate).Item("END DATE")), "yyyyMMdd") & "' WHERE `rate`.`rate_id` = '" & RateID & "';"

                    checkRangeTanggal = False

                    tboRate.Select()






                ElseIf checkRangeTanggal = False Then
                    MessageBox.Show("New start date or end date rate conlfict with recorded date.")
                    checkRangeTanggal = False
                    tboRate.Select()
                End If
            Else
                dtpRateFrom.Value = Today
                dtpRateTo.Value = dtpRateFrom.Value.AddDays(2)
            End If


        Else
            tboRate.Text = dgvRate.Rows(rowdgvRate).Cells(0).Value
            Try
                tboRoomTypeID.Select()
            Catch ex As Exception
                tboRoomTypeName.Select()
            End Try
            MessageBox.Show("Please complete the form")


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

    Private Sub tboRoomFrom_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboRoomFrom.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub tboRoomTo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboRoomTo.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub btnAddRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRoom.Click

        Dim expression As String = "([ROOM NUMBER] >= " & Convert.ToInt32(tboRoomFrom.Text) & " AND [ROOM NUMBER] <= " & Convert.ToInt32(tboRoomTo.Text) & ")"
        ' Sort descending by column named CompanyName. 
        Dim foundRows As DataRow()

        ' Use the Select method to find all rows matching the filter.
        foundRows = dtRoom.[Select](expression)



        'If Convert.ToInt32(tboNumberofRoom.Text) >= (Convert.ToInt32(tboRoomTo.Text) - Convert.ToInt32(tboRoomFrom)) Then
        If tboFloor.Text <> "" And tboRoomFrom.Text <> "" And tboRoomTo.Text <> "" Then
            If foundRows.Length = 0 Then
                If (Convert.ToInt32(tboRoomTo.Text) >= Convert.ToInt32(tboRoomFrom.Text)) Then
                    'Dim range As Byte = Convert.ToInt32(tboRoomTo.Text) - Convert.ToInt32(tboRoomFrom)

                    'cara pertama-------------------
                    'tambah ke mirror dulu
                    'For i = 0 To range - 1
                    'Next
                    'tambah ke dgv
                    '----------------------------

                    'penambahanCounter()


                    'cara kedua---------------------
                    'masukin ke dgv

                    'TAMPILIN DI LAYAR dan masukin ke statement

                    For i = Convert.ToInt32(tboRoomFrom.Text) To Convert.ToInt32(tboRoomTo.Text)
                        penambahanCounter()

                        'tampilin
                        row = dtRoom.NewRow()
                        row("ROOM NUMBER") = i.ToString
                        row("FLOOR") = tboFloor.Text
                        dtRoom.Rows.Add(row)


                        'masukin statement

                        ArrayStatement(counter, 0) = "1"
                        ArrayStatement(counter, 1) = "INSERT INTO `chamberdb`.`room` (`room_id`, `type_id`, `username`, `status_room_id`, `room_num`, `floor`, `aktif`) VALUES (NULL, '" & tboRoomTypeID.Text & "', '" & username & "', 'VaCI', '" & i & "', '" & tboFloor.Text & "', '1');"

                    Next

                    'masukin ke statement

                    tboFloor.Text = ""
                    tboRoomFrom.Text = ""
                    tboRoomTo.Text = ""

                    tboFloor.Select()


                Else
                    MessageBox.Show("Number of Room out of Range")
                End If

            ElseIf foundRows.Length = 1 Then
                MessageBox.Show("There is " & foundRows.Length & " room number which already existed")
            ElseIf foundRows.Length > 1 Then
                MessageBox.Show("There are " & foundRows.Length & " room numbers which already existed")
            End If
        Else
            MessageBox.Show("Please complete all fields")
            tboFloor.Select()
        End If

    End Sub

    Private Sub dgvRoom_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRoom.CellContentClick

    End Sub

    Private Sub btnSavenNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSavenNew.Click

        If insertorupdateRoomType = 1 Then 'insert
            'masukkan statement ke dtStatement
            ArrayStatement(0, 0) = "1"
            ArrayStatement(0, 1) = "INSERT INTO `chamberdb`.`type` (`type_id`, `type_name`, `aktif`) VALUES ('" & tboRoomTypeID.Text & "', '" & tboRoomTypeName.Text & "', '1')"

        ElseIf insertorupdateRoomType = 0 Then 'update
            'masukkan statement ke dtStatement
            ArrayStatement(0, 0) = "0"
            ArrayStatement(0, 1) = "UPDATE `chamberdb`.`type` SET `type_name` = '" & tboRoomTypeName.Text & "' WHERE `type`.`type_id` = '" & tboRoomTypeID.Text & "';"
        End If

        Try 'proses masukkan ke database
            For i = 0 To 30
                If ArrayStatement(i, 0) = "1" Then
                    'insert type room dulu
                    Dim sql As String = ArrayStatement(i, 1)
                    Dim command As New MySqlCommand(sql, connection)
                    Try
                        OpenCloseConnection()
                        command.ExecuteNonQuery()
                        OpenCloseConnection()

                    Catch ex As Exception
                        MessageBox.Show("System can not Executed in Row " & i & " " & ArrayStatement(i, 1))
                        Exit For
                    End Try
                ElseIf ArrayStatement(i, 0) = "0" Then
                    Dim sql As String = ArrayStatement(i, 1)
                    Dim command As New MySqlCommand(sql, connection)
                    Try
                        OpenCloseConnection()
                        command.ExecuteNonQuery()
                        OpenCloseConnection()

                    Catch ex As Exception
                        MessageBox.Show("System can not Executed in Row " & i & " " & ArrayStatement(i, 1))
                        Exit For
                    End Try
                ElseIf ArrayStatement(i, 0) = "" Then
                    Exit For
                End If
            Next
            MessageBox.Show("All data has been saved")
            RefreshingPage()
        Catch ex As Exception
            MessageBox.Show("Adding Type Room has been Canceled")
        End Try

    End Sub

    Private Sub btnPlusStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlusStart.Click
        dtpRateFrom.Value = dtpRateFrom.Value.AddDays(1)

    End Sub

    Private Sub btnMinStart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinStart.Click
        dtpRateFrom.Value = dtpRateFrom.Value.AddDays(-1)
    End Sub

    Private Sub btnPlusEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPlusEnd.Click
        dtpRateTo.Value = dtpRateTo.Value.AddDays(1)
    End Sub

    Private Sub btnMinEnd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMinEnd.Click
        dtpRateTo.Value = dtpRateTo.Value.AddDays(-1)
    End Sub

    Private Sub dgvRoom_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRoom.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            tboRoomTo.Enabled = False
            tboRoomFrom.Text = dgvRoom.Rows(e.RowIndex).Cells(0).Value
            tboRoomTo.Text = ""
            tboFloor.Text = dgvRoom.Rows(e.RowIndex).Cells(1).Value

        End If
    End Sub

    Private Sub tboFloor_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboFloor.Leave
        tboRoomFrom.Text = ""
        tboRoomTo.Text = ""
        If tboFloor.Text.Length > 1 Then
            tboRoomFrom.MaxLength = 4
            tboRoomTo.MaxLength = 4
        ElseIf tboFloor.Text.Length = 1 Then
            tboRoomFrom.MaxLength = 3
            tboRoomTo.MaxLength = 3
        End If

    End Sub


    Private Sub btnEditRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditRoom.Click
        Dim expression As String = "([ROOM NUMBER] = '" & tboRoomFrom.Text & "')"
        ' Sort descending by column named CompanyName. 
        Dim foundRows As DataRow()

        ' Use the Select method to find all rows matching the filter.
        foundRows = dtRoom.[Select](expression)

        If tboFloor.Text <> "" And tboRoomFrom.Text <> "" Then
            If foundRows.Length = 0 Then

                penambahanCounter()

                ArrayStatement(counter, 0) = "0"
                ArrayStatement(counter, 1) = "UPDATE `chamberdb`.`room` SET `username` = '" & username & "', `room_num` = '" & tboRoomFrom.Text & "', `floor` = '" & tboFloor.Text & "' WHERE `room`.`room_num` = '" & dgvRoom.Item(0, dgvRoom.CurrentRow.Index).Value & "';"

                dtRoom.Rows(dgvRoom.CurrentRow.Index).Item("ROOM NUMBER") = tboRoomFrom.Text
                dtRoom.Rows(dgvRoom.CurrentRow.Index).Item("FLOOR") = tboFloor.Text



                tboFloor.Text = ""
                tboRoomFrom.Text = ""
                tboRoomTo.Text = ""

                tboFloor.Select()

            ElseIf foundRows.Length = 1 Then
                MessageBox.Show("There is " & foundRows.Length & " room number which already existed")
            ElseIf foundRows.Length > 1 Then
                MessageBox.Show("There are " & foundRows.Length & " room numbers which already existed")
            End If
        Else
            MessageBox.Show("Please complete room and floor fields")
        End If



    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        RefreshingPage()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        RefreshingPage()
    End Sub

    Private Sub tboFloor_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboFloor.Enter
        tboRoomTo.Enabled = True
    End Sub

    Private Sub tboWithBreakfast_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboWithBreakfast.KeyPress
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