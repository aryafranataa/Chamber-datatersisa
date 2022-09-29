Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Imports MySql.Data.MySqlClient

Imports System.Collections.Generic.List(Of String)

Public Class Rate


    Private TotalCheckBoxes As Integer = 0
    Private TotalCheckedCheckBoxes As Integer = 0
    Private HeaderCheckBox As CheckBox = Nothing
    Private IsHeaderCheckBoxClicked As Boolean = False


    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtType As New DataTable
    Dim dtMirrorShowRateperRoom As New DataTable
    Dim StatementSelect() As String
    Dim counter As Integer
    Dim ArrayeRowTypeCodeActive() As String
    Dim RateCodeStartFrom As Integer
    'Dim ArrayStatement() As String
    Dim dtMurniDatabase As New DataTable
    Dim MyList As New List(Of String)()


    Public Sub New()
        InitializeComponent()
    End Sub


    Private Sub penambahanCounter()
        counter += 1
        'ReDim Preserve ArrayStatement(counter - 1)



    End Sub
    Public Sub kosongin()

        dtType.Clear()
        tboRate.Text = ""

        Array.Clear(StatementSelect, 0, StatementSelect.Length)
        Array.Clear(ArrayeRowTypeCodeActive, 0, ArrayeRowTypeCodeActive.Length)

        dtpRateFrom.Value = Today
        dtpRateTo.Value = dtpRateFrom.Value.AddDays(2)
        RateCodeStartFrom = 0
        counter = 0

        'ReDim ArrayStatement(0)
        dtMurniDatabase.Clear()


        Dim MyList As New List(Of String)()


    End Sub

    Public Sub RefreshingPage()
        ReDim Preserve StatementSelect(dgvRoomType.Rows.Count + 1)
        ReDim Preserve ArrayeRowTypeCodeActive(dgvRoomType.Rows.Count)

        kosongin()
        'StatementSelect(0) = "select r.rate_id as 'RATE CODE', r.type_id as 'TYPE CODE', r.rate_room as 'ROOM RATE', r.date_on as 'START DATE', r.date_off as 'END DATE' from rate r where aktif = 1"
        Try
            'data table 2 
            'buat tampilin
            'Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = New DataColumn()
            column.DataType = System.Type.GetType("System.String")
            column.ColumnName = "RATE CODE"
            dtMirrorShowRateperRoom.Columns.Add(column)

            'Create second column.
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "TYPE CODE"
            dtMirrorShowRateperRoom.Columns.Add(column)

            'Create third column
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "ROOM RATE"
            dtMirrorShowRateperRoom.Columns.Add(column)

            'Create fourth column
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "WITH BREAKFAST"
            dtMirrorShowRateperRoom.Columns.Add(column)


            dtMirrorShowRateperRoom.Columns.Add("START DATE", GetType(DateTime))

            dtMirrorShowRateperRoom.Columns.Add("END DATE", GetType(DateTime))


            'ngambil data dari database buat ngisi ke dt Mirror
            Try
                cmd1 = New MySqlCommand("select r.rate_id as 'RATE CODE', r.type_id as 'TYPE CODE', r.rate_room as 'ROOM RATE', r.rate_room_breakfast as 'WITH BREAKFAST', r.date_on as 'START DATE', r.date_off as 'END DATE' from rate r where aktif = 1;", connection)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtMurniDatabase)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try


        Catch ex As Exception

        End Try


    End Sub


    Private Sub RoomRateSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AddHeaderCheckBox()
        AddHandler HeaderCheckBox.KeyUp, New KeyEventHandler(AddressOf HeaderCheckBox_KeyUp)
        AddHandler HeaderCheckBox.MouseClick, New MouseEventHandler(AddressOf HeaderCheckBox_MouseClick)
        BindGridView()
        RefreshingPage()
    End Sub

    Private Sub AddHeaderCheckBox()
        HeaderCheckBox = New CheckBox()

        HeaderCheckBox.Size = New Size(15, 15)
        'Add the CheckBox into the DataGridView
        Me.dgvRoomType.Controls.Add(HeaderCheckBox)
    End Sub
    Private Sub BindGridView()

        dgvRoomType.DataSource = GetDataSource()
        TotalCheckBoxes = dgvRoomType.RowCount
        TotalCheckedCheckBoxes = 0
        Dim column As DataGridViewColumn = dgvRoomType.Columns(0)
        column.Width = 30

        column = New DataGridViewColumn
        column = dgvRoomType.Columns(1)
        column.Width = 60

        column = New DataGridViewColumn
        column = dgvRoomType.Columns(2)
        column.Width = 80

    End Sub


    Private Function GetDataSource() As DataTable
        Dim dTable As New DataTable()
        Dim dRow As DataRow = Nothing

        dTable.Columns.Add("/".ToString, System.Type.[GetType]("System.Boolean"))
        dTable.Columns.Add("TYPE CODE")
        dTable.Columns.Add("RATE")
        dTable.Columns.Add("WITH BREAKFAST")

        Try
            cmd1 = New MySqlCommand("select t.type_id as `TYPE CODE`, if(r.rate_room is not null, r.rate_room, if((select r.rate_room from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off <= " & Today.ToString("yyyyMMdd") & " order by r.date_off desc limit 1) is not null, (select r.rate_room from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off <= " & Today.ToString("yyyyMMdd") & " order by r.date_off desc limit 1), if( (select r.rate_room from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off >= " & Today.ToString("yyyyMMdd") & " order by r.date_off asc limit 1) is not null, (select r.rate_room from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off >= " & Today.ToString("yyyyMMdd") & " order by r.date_off asc limit 1), 'Not Set'))) as `RATE`, if(r.rate_room_breakfast is not null, r.rate_room_breakfast, if((select r.rate_room_breakfast from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off <= " & Today.ToString("yyyyMMdd") & " order by r.date_off desc limit 1) is not null, (select r.rate_room_breakfast from rate r  where r.aktif = '1' and r.type_id = t.type_id and r.date_off <= " & Today.ToString("yyyyMMdd") & " order by r.date_off desc limit 1), if( (select r.rate_room_breakfast from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off >= " & Today.ToString("yyyyMMdd") & " order by r.date_off asc limit 1) is not null, (select r.rate_room_breakfast from rate r where r.aktif = '1' and r.type_id = t.type_id and r.date_off >= " & Today.ToString("yyyyMMdd") & " order by r.date_off asc limit 1), 'Not Set'))) as `WITH BREAKFAST` from `type` t left join rate r on (t.type_id=r.type_id and r.aktif='1' and t.aktif='1' and " & Today.ToString("yyyyMMdd") & " between r.date_on and r.date_off) group by t.type_id;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dTable)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return dTable
    End Function

    Private Sub HeaderCheckBox_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Space Then
            HeaderCheckBoxClick(DirectCast(sender, CheckBox))
        End If
    End Sub

    Private Sub HeaderCheckBox_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        HeaderCheckBoxClick(DirectCast(sender, CheckBox))
    End Sub

    Private Sub HeaderCheckBoxClick(ByVal HCheckBox As CheckBox)

        IsHeaderCheckBoxClicked = True

        For Each Row As DataGridViewRow In dgvRoomType.Rows
            If HCheckBox.Checked = True Then
                DirectCast(Row.Cells("/"), DataGridViewCheckBoxCell).Value = True
                StatementSelect(Row.Index + 1) = "[TYPE CODE] = '" & dgvRoomType.Item(1, Row.Index).Value & "'"
                ArrayeRowTypeCodeActive(Row.Index) = Row.Index
                AmbilDataDaridtMurniDatabase()
            ElseIf HCheckBox.Checked = False Then
                DirectCast(Row.Cells("/"), DataGridViewCheckBoxCell).Value = False
                StatementSelect(Row.Index + 1) = ""
                ArrayeRowTypeCodeActive(Row.Index) = ""
                dtMirrorShowRateperRoom.Clear()
            End If
        Next
        'StatementSelect(StatementSelect.Length) = ""



        dgvRoomType.RefreshEdit()
        TotalCheckedCheckBoxes = If(HCheckBox.Checked, TotalCheckBoxes, 0)


        IsHeaderCheckBoxClicked = False
    End Sub



    Private Sub dgvRoomType_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRoomType.CellValueChanged
        If Not IsHeaderCheckBoxClicked Then

            RowCheckBoxClick(DirectCast(dgvRoomType(e.ColumnIndex, e.RowIndex), DataGridViewCheckBoxCell))
        End If
       
    End Sub

    Public Sub AmbilDataDaridtMurniDatabase()
        StatementSelect(StatementSelect.Length - 1) = ""
        dtMirrorShowRateperRoom.Clear()
        Dim counter As Byte = 0

        For i = 0 To StatementSelect.Length - 2
            If StatementSelect(i) <> "" Then 'ngecek apakah statement ada isinya
                counter += 1
                If counter = 2 Then
                    StatementSelect(StatementSelect.Length - 1) = StatementSelect(StatementSelect.Length - 1) & " or " & StatementSelect(i)
                ElseIf counter > 2 Then
                    StatementSelect(StatementSelect.Length - 1) = StatementSelect(StatementSelect.Length - 1) & " or " & StatementSelect(i)
                ElseIf counter <= 1 Then
                    StatementSelect(StatementSelect.Length - 1) = StatementSelect(i)
                End If
            ElseIf StatementSelect(i) = "" Then
                'yauda di pas aja
            End If
        Next

        Dim foundRows As DataRow()

        'clear found row

        ' Use the Select method to find all rows matching the filter.
        foundRows = dtMurniDatabase.[Select](StatementSelect(StatementSelect.Length - 1))
        Dim row As DataRow
        dtMirrorShowRateperRoom.Clear()
        For i = 0 To foundRows.GetUpperBound(0)
            row = dtMirrorShowRateperRoom.NewRow()
            row("RATE CODE") = foundRows(i)(0)
            row("TYPE CODE") = foundRows(i)(1)
            row("ROOM RATE") = foundRows(i)(2)
            row("WITH BREAKFAST") = foundRows(i)(3)
            row("START DATE") = foundRows(i)(4)
            row("END DATE") = foundRows(i)(5)
            dtMirrorShowRateperRoom.Rows.Add(row)
        Next

        dgvDisplayRate.DataSource = dtMirrorShowRateperRoom

    End Sub

    Public Sub AmbilDataDariDatabase()
        dtMirrorShowRateperRoom.Clear()
        Dim counter As Byte = 0
        Try
            For i = 0 To StatementSelect.Length - 2
                If StatementSelect(i) <> "" Then 'ngecek apakah statement ada isinya
                    counter += 1
                    If counter = 2 Then
                        StatementSelect(StatementSelect.Length - 1) = StatementSelect(StatementSelect.Length - 1) & " and " & StatementSelect(i)
                    ElseIf counter > 2 Then
                        StatementSelect(StatementSelect.Length - 1) = StatementSelect(StatementSelect.Length - 1) & " or " & StatementSelect(i)
                    ElseIf counter <= 1 Then
                        StatementSelect(StatementSelect.Length - 1) = StatementSelect(i)
                    End If
                ElseIf StatementSelect(i) = "" Then
                    'yauda di pas aja
                End If
            Next

            cmd1 = New MySqlCommand(StatementSelect(StatementSelect.Length - 1), connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtMirrorShowRateperRoom)

            dgvDisplayRate.DataSource = dtMirrorShowRateperRoom
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
    End Sub

    Private Sub AmbilDataDisplayRate()
        Try
            cmd1 = New MySqlCommand(StatementSelect(0), connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtMirrorShowRateperRoom)
            dgvDisplayRate.DataSource = dtMirrorShowRateperRoom
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

    End Sub


    Private Sub RowCheckBoxClick(ByVal RCheckBox As DataGridViewCheckBoxCell)
            If RCheckBox IsNot Nothing Then
                'Modifiy Counter;            
                If CBool(RCheckBox.Value) AndAlso TotalCheckedCheckBoxes < TotalCheckBoxes Then
                    TotalCheckedCheckBoxes += 1

                    StatementSelect(dgvRoomType.CurrentRow.Index + 1) = "[TYPE CODE] = '" & dgvRoomType.Item(1, dgvRoomType.CurrentRow.Index).Value & "'"
                    ArrayeRowTypeCodeActive(dgvRoomType.CurrentRow.Index) = dgvRoomType.CurrentRow.Index

                    AmbilDataDaridtMurniDatabase()
                ElseIf TotalCheckedCheckBoxes > 0 Then
                    StatementSelect(dgvRoomType.CurrentRow.Index + 1) = ""
                    ArrayeRowTypeCodeActive(dgvRoomType.CurrentRow.Index) = ""

                    TotalCheckedCheckBoxes -= 1
                    If TotalCheckedCheckBoxes = 0 Then
                        dtMirrorShowRateperRoom.Clear()
                    Else
                        AmbilDataDaridtMurniDatabase()
                    End If

                End If

                'Change state of the header CheckBox.
                If TotalCheckedCheckBoxes < TotalCheckBoxes Then
                    HeaderCheckBox.Checked = False
                ElseIf TotalCheckedCheckBoxes = TotalCheckBoxes Then
                    HeaderCheckBox.Checked = True
                End If

            End If

    End Sub


    Private Sub dgvRoomType_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRoomType.CurrentCellDirtyStateChanged
        If TypeOf dgvRoomType.CurrentCell Is DataGridViewCheckBoxCell Then
            dgvRoomType.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub


    Private Sub dgvRoomType_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvRoomType.CellPainting
        If e.RowIndex = -1 AndAlso e.ColumnIndex = 0 Then
            ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex)
        End If
    End Sub

    Private Sub ResetHeaderCheckBoxLocation(ByVal ColumnIndex As Integer, ByVal RowIndex As Integer)
        'Get the column header cell bounds
        Dim oRectangle As Rectangle = Me.dgvRoomType.GetCellDisplayRectangle(ColumnIndex, RowIndex, True)

        Dim oPoint As New Point()

        oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) \ 2 + 1
        oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) \ 2 + 1

        'Change the location of the CheckBox to make it stay on the header
        HeaderCheckBox.Location = oPoint
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

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Try 'proses masukkan ke database
            For i = 0 To MyList.Count - 1

                Dim sql As String = MyList(i)
                Dim command As New MySqlCommand(sql, connection)
                Try
                    OpenCloseConnection()
                    command.ExecuteNonQuery()
                    OpenCloseConnection()
                Catch ex As Exception
                    MessageBox.Show("System can not Executed in Row " & i & " " & MyList(i))
                    Exit For
                End Try
            Next
            MessageBox.Show("All data has been saved")
            RefreshingPage()
        Catch ex As Exception
            MessageBox.Show("Adding room rate has been Canceled")
        End Try
    End Sub



    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        'cek tanggal pada type id tertentu

        If tboRate.Text <> "" Then
            If dtpRateFrom.Value < dtpRateTo.Value Then
                If TotalCheckedCheckBoxes >= 1 Then
                    penambahanCounter()
                    For i = 0 To ArrayeRowTypeCodeActive.Length - 1
                        If ArrayeRowTypeCodeActive(i) <> "" Then 'ngecek type id yang ke cek list. ini ada isinya nggak?
                            penambahanCounter()
                            Dim expression As String = "[TYPE CODE] = '" & dgvRoomType.Item(1, Convert.ToInt32(ArrayeRowTypeCodeActive(i))).Value & "' AND (([START DATE] >= '" & dtpRateFrom.Value.ToString("dd/MM/yyyy") & "' AND [START DATE] <= '" & dtpRateTo.Value.ToString("dd/MM/yyyy") & "') OR ([END DATE] >= '" & dtpRateFrom.Value.ToString("dd/MM/yyyy") & "' AND [END DATE] <= '" & dtpRateTo.Value.ToString("dd/MM/yyyy") & "'))"
                            ' Sort descending by column named CompanyName. 
                            Dim foundRows As DataRow()

                            ' Use the Select method to find all rows matching the filter.
                            foundRows = dtMirrorShowRateperRoom.[Select](expression)

                            Dim checkRangeTanggal As Boolean = False

                            ' Print column 0 of each returned row. 
                            If foundRows.Length > 0 Then
                                MessageBox.Show(foundRows.Length.ToString & " record(s) existed in the selected date range")
                                checkRangeTanggal = False

                            ElseIf foundRows.Length = 0 Then
                                checkRangeTanggal = True
                            ElseIf foundRows.Length > 0 Then
                                checkRangeTanggal = False
                            End If
                            'ngecek berapa jumlah data
                            Dim expression2 As String = "([TYPE CODE] = '" & dgvRoomType.Item(1, Convert.ToInt32(ArrayeRowTypeCodeActive(i))).Value & "')"
                            ' Sort descending by column named CompanyName. 
                            Dim foundRows2 As DataRow()

                            ' Use the Select method to find all rows matching the filter.
                            foundRows2 = dtMirrorShowRateperRoom.[Select](expression2)
                            RateCodeStartFrom = foundRows2.Length


                            If checkRangeTanggal = True Then

                                'TAMBAH KE MIRROR DULU
                                row = dtMurniDatabase.NewRow()

                                row("RATE CODE") = "R" & dgvRoomType.Item(1, Convert.ToInt32(ArrayeRowTypeCodeActive(i))).Value & ubahKodeDiBelakang((RateCodeStartFrom + 1), 3)
                                row("TYPE CODE") = dgvRoomType.Item(1, Convert.ToInt32(ArrayeRowTypeCodeActive(i))).Value
                                row("ROOM RATE") = tboRate.Text
                                row("WITH BREAKFAST") = tboBreakfast.Text
                                row("START DATE") = dtpRateFrom.Value.ToString("yyyy-MM-dd")
                                row("END DATE") = dtpRateTo.Value.ToString("yyyy-MM-dd")


                                'SALIN KE STATEMENT 
                                MyList.Add("INSERT INTO `chamberdb`.`rate` (`rate_id`, `type_id`, `rate_room`, `date_on`, `date_off`, `aktif`, `rate_room_breakfast`) VALUES ('" & row("RATE CODE") & "', '" & row("TYPE CODE") & "', '" & row("ROOM RATE") & "', '" & Format(CDate(row("START DATE")), "yyyyMMdd") & "', '" & Format(CDate(row("END DATE")), "yyyyMMdd") & "', '1', '" & row("WITH BREAKFAST") & "' );")

                                'ArrayStatement(counter - 1) = "INSERT INTO `chamberdb`.`rate` (`rate_id`, `type_id`, `rate_room`, `date_on`, `date_off`, `aktif`) VALUES ('" & row("RATE CODE") & "', '" & row("TYPE CODE") & "', '" & row("ROOM RATE") & "', '" & row("START DATE") & "', '" & row("END DATE") & "', '1');"


                                dtMurniDatabase.Rows.Add(row)
                                checkRangeTanggal = False

                                AmbilDataDaridtMurniDatabase()

                            ElseIf checkRangeTanggal = False Then
                                Dim result As Integer = MessageBox.Show("New rate was conflicted with recorded date in type code = " & dgvRoomType.Item(1, Convert.ToInt32(ArrayeRowTypeCodeActive(i))).Value & ". Do you want to skip the conflicted date and continue this process ?", "Conflict Date Rate", MessageBoxButtons.YesNo)
                                If result = DialogResult.No Then
                                    Exit For
                                ElseIf result = DialogResult.Yes Then

                                End If


                                tboRate.Select()
                            End If

                        ElseIf ArrayeRowTypeCodeActive(i) = "" Then
                            'lewat aja
                        End If
                    Next

                    tboRate.Text = ""
                    tboRate.Select()

                Else
                    MessageBox.Show("Please check Type Room")
                End If
            Else
                MessageBox.Show("Date Error")
                dtpRateFrom.Value = Today
                dtpRateTo.Value = dtpRateFrom.Value.AddDays(2)
            End If

        Else
            MessageBox.Show("Please insert Rate")
        End If



    End Sub

    Private Sub btnSavenNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click


        Dim expression As String = "[TYPE CODE] = '" & dgvDisplayRate.Item(1, dgvDisplayRate.CurrentRow.Index).Value & "' AND (([START DATE] >= '" & dtpRateFrom.Value.ToString("dd/MM/yyyy") & "' AND [START DATE] <= '" & dtpRateTo.Value.ToString("dd/MM/yyyy") & "') OR ([END DATE] >= '" & dtpRateFrom.Value.ToString("dd/MM/yyyy") & "' AND [END DATE] <= '" & dtpRateTo.Value.ToString("dd/MM/yyyy") & "')) and [RATE CODE] <> '" & dgvDisplayRate.Item(0, dgvDisplayRate.CurrentRow.Index).Value & "'"
        ' Sort descending by column named CompanyName. 
        Dim foundRows As DataRow()

        ' Use the Select method to find all rows matching the filter.
        foundRows = dtMurniDatabase.[Select](expression)

        Dim checkRangeTanggal As Boolean = False

        ' Print column 0 of each returned row. 
        If foundRows.Length > 0 Then
            MessageBox.Show(foundRows.Length.ToString & " record(s) existed in the selected date range")
            checkRangeTanggal = False

        ElseIf foundRows.Length = 0 Then
            checkRangeTanggal = True
        End If



        If tboRate.Text <> "" Then
            If dtpRateFrom.Value < dtpRateTo.Value Then
                If checkRangeTanggal = True Then
                    'lakukanlah pengupdatean itu
                    penambahanCounter()
                    'edit KE MIRROR DULU
                    dtMurniDatabase.Rows(dgvDisplayRate.CurrentRow.Index).Item("ROOM RATE") = tboRate.Text
                    dtMurniDatabase.Rows(dgvDisplayRate.CurrentRow.Index).Item("WITH BREAKFAST") = tboBreakfast.Text
                    dtMurniDatabase.Rows(dgvDisplayRate.CurrentRow.Index).Item("START DATE") = dtpRateFrom.Value.ToString("yyyy-MM-dd")
                    dtMurniDatabase.Rows(dgvDisplayRate.CurrentRow.Index).Item("END DATE") = dtpRateTo.Value.ToString("yyyy-MM-dd")

                    'edit yg di datagridview
                    dgvDisplayRate.Rows(dgvDisplayRate.CurrentRow.Index).Cells(2).Value = tboRate.Text
                    dgvDisplayRate.Rows(dgvDisplayRate.CurrentRow.Index).Cells(3).Value = tboBreakfast.Text
                    dgvDisplayRate.Rows(dgvDisplayRate.CurrentRow.Index).Cells(4).Value = dtpRateFrom.Value.Date
                    dgvDisplayRate.Rows(dgvDisplayRate.CurrentRow.Index).Cells(5).Value = dtpRateTo.Value.Date


                    'salin ke statement
                    'ArrayStatement(counter, 1) = "UPDATE `chamberdb`.`rate` SET `rate_room` = '" & dtMirrorRate.Rows(rowdgvRate).Item("ROOM RATE") & "', `date_on` = '" & Format(CDate(dtMirrorRate.Rows(rowdgvRate).Item("START DATE")), "yyyyMMdd") & "', `date_off` = '" & Format(CDate(dtMirrorRate.Rows(rowdgvRate).Item("END DATE")), "yyyyMMdd") & "' WHERE `rate`.`rate_id` = '" & RateID & "';"

                    MyList.Add("UPDATE `chamberdb`.`rate` SET `rate_room_breakfast` = '" & dtMurniDatabase.Rows(dgvDisplayRate.CurrentRow.Index).Item("WITH BREAKFAST") & "' , `rate_room` = '" & dtMurniDatabase.Rows(dgvDisplayRate.CurrentRow.Index).Item("ROOM RATE") & "', `date_on` = '" & Format(CDate(dtMurniDatabase.Rows(dgvDisplayRate.CurrentRow.Index).Item("START DATE")), "yyyyMMdd") & "', `date_off` = '" & Format(CDate(dtMurniDatabase.Rows(dgvDisplayRate.CurrentRow.Index).Item("END DATE")), "yyyyMMdd") & "' WHERE `rate`.`rate_id` = '" & dgvDisplayRate.Item(0, dgvDisplayRate.CurrentRow.Index).Value & "';")


                    checkRangeTanggal = False
                    tboRate.Select()

                ElseIf checkRangeTanggal = False Then
                    MessageBox.Show("New start date or end date rate conflicted with recorded date.")
                    checkRangeTanggal = False
                    tboRate.Select()
                End If
            Else
                dtpRateFrom.Value = Today
                dtpRateTo.Value = dtpRateFrom.Value.AddDays(2)
            End If

        Else
            tboRate.Text = dgvDisplayRate.Rows(dgvDisplayRate.CurrentRow.Index).Cells(0).Value
            MessageBox.Show("Please complete the form")

        End If

    End Sub


    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Try
            Dim result As Integer = MessageBox.Show("Rate = '" & dgvDisplayRate.Rows(dgvDisplayRate.CurrentRow.Index).Cells(2).Value & "' from room type = '" & dgvDisplayRate.Rows(dgvDisplayRate.CurrentRow.Index).Cells(1).Value & "'will be deleted permanently. Are you sure?", "Error Input Rate", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then

            ElseIf result = DialogResult.Yes Then
                Dim sqlUpdate As String
                Dim cmd1 As New MySqlCommand
                sqlUpdate = "UPDATE `chamberdb`.`rate` SET `aktif` = '0' WHERE `rate`.`rate_id` = '" & dgvDisplayRate.Rows(dgvDisplayRate.CurrentRow.Index).Cells(0).Value & "';"

                Try
                    OpenCloseConnection()
                    cmd1 = New MySqlCommand(sqlUpdate, connection)
                    cmd1.ExecuteNonQuery()
                    OpenCloseConnection()
                    MessageBox.Show("Rate has been deleted")

                    kosongin()

                    Try
                        cmd1 = New MySqlCommand("select r.rate_id as 'RATE CODE', r.type_id as 'TYPE CODE', r.rate_room as 'ROOM RATE', r.date_on as 'START DATE', r.date_off as 'END DATE' from rate r where aktif = 1", connection)
                        adapter = New MySqlDataAdapter(cmd1)
                        adapter.Fill(dtMurniDatabase)
                    Catch ex As Exception
                        MessageBox.Show(ex.ToString)
                    End Try

                Catch ex As Exception
                    MessageBox.Show(ex.ToString)

                End Try

            End If
        Catch ex As Exception
            MessageBox.Show("Choose rate which will be deleted")
        End Try

    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        RoomRateSearch_Load(sender, e)
    End Sub

    Private Sub dgvDisplayRate_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvDisplayRate.CellContentClick

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

    Private Sub tboBreakfast_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboBreakfast.KeyPress
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