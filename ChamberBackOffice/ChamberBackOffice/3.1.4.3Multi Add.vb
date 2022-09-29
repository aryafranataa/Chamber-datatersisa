Imports MySql.Data.MySqlClient

Public Class Multi_Add
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtRoomDatabase As New DataTable
    Dim dtRoomChosen As New DataTable
    Dim dtInRoomFacility As New DataTable
    Dim dtInRoomFacilityChosen As New DataTable

    Dim column As New DataColumn

    Dim row As DataRow
    Private Sub kosongin()
        dtRoomDatabase.Clear()
        dtRoomChosen.Clear()
        dtInRoomFacility.Clear()
        dtInRoomFacilityChosen.Clear()

    End Sub


    Private Sub Multi_Add_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()

        Try
            cmd1 = New MySqlCommand("select room_id as 'ROOM CODE', type_id as 'TYPE', room_num as 'ROOM NUMBER' from room where aktif = 1;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtRoomDatabase)

            cmd1 = New MySqlCommand("SELECT room_specification_id as 'INF CODE', room_specification_name as 'INROOM FACILITY' FROM specification s where aktif = 1;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtInRoomFacility)


            dgvRoom.DataSource = dtRoomDatabase
            dgvInRoomFacility.DataSource = dtInRoomFacility


            Dim column As DataGridViewColumn = dgvRoom.Columns(0)
            column.Width = 50

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try



        Try
            'buat coloum untuk dt ID facility choose
            'Declare DataColumn and DataRow variables. 

            'Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = New DataColumn()
            column.DataType = System.Type.GetType("System.String")
            column.ColumnName = "ROOM CODE"
            dtRoomChosen.Columns.Add(column)

            'Create second column.
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "TYPE"
            dtRoomChosen.Columns.Add(column)

            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "ROOM NUMBER"
            dtRoomChosen.Columns.Add(column)

            '=======================================================================
            'Create new DataColumn, set DataType, ColumnName and add to DataTable.    
            column = New DataColumn()
            column.DataType = System.Type.GetType("System.String")
            column.ColumnName = "INF CODE"
            dtInRoomFacilityChosen.Columns.Add(column)

            'Create second column.
            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "INROOM FACILITY"
            dtInRoomFacilityChosen.Columns.Add(column)

            column = New DataColumn()
            column.DataType = Type.GetType("System.String")
            column.ColumnName = "QTY"
            dtInRoomFacilityChosen.Columns.Add(column)


        Catch

        End Try

    End Sub

    Private Sub btnAddRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddRoom.Click

        Try

            ''test apakah spesifikasi sudah di tambahakan
            Dim test As Integer = 0
            Dim counter As Integer = 0
            For Each Me.row In dtRoomChosen.Rows
                If (dtRoomChosen.Rows(counter).Item(0).ToString) = (dgvRoom.Item(0, dgvRoom.CurrentRow.Index).Value) Then
                    test += 1
                End If
                counter += 1
            Next

            If test = 0 Then

                'masukkan ke dt chosen either with code or not
                row = dtRoomChosen.NewRow()

                row("ROOM CODE") = dtRoomDatabase.Rows(dgvRoom.CurrentRow.Index).Item(0)
                row("TYPE") = dtRoomDatabase.Rows(dgvRoom.CurrentRow.Index).Item(1)
                row("ROOM NUMBER") = dtRoomDatabase.Rows(dgvRoom.CurrentRow.Index).Item(2)
                dtRoomChosen.Rows.Add(row)
                dgvSelectedRoom.DataSource = dtRoomChosen

                Dim column As DataGridViewColumn = dgvSelectedRoom.Columns(0)
                column.Width = 50


                column = New DataGridViewColumn
                column = dgvSelectedRoom.Columns(1)
                column.Width = 50


            Else
                MsgBox(dgvRoom.Item(2, dgvRoom.CurrentRow.Index).Value + " has been inserted")
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try




    End Sub

    Private Sub btnAddInRoomFacility_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddInRoomFacility.Click
        If tboQty.Text <> "" Then
            Try

                ''test apakah spesifikasi sudah di tambahakan
                Dim test As Integer = 0
                Dim counter As Integer = 0
                For Each Me.row In dtInRoomFacilityChosen.Rows
                    If (dtInRoomFacilityChosen.Rows(counter).Item(0).ToString) = (dgvInRoomFacility.Item(0, dgvInRoomFacility.CurrentRow.Index).Value) Then
                        test += 1
                    End If
                    counter += 1
                Next

                If test = 0 Then

                    'masukkan ke dt chosen either with code or not
                    row = dtInRoomFacilityChosen.NewRow()

                    row("INF CODE") = dtInRoomFacility.Rows(dgvInRoomFacility.CurrentRow.Index).Item(0)
                    row("INROOM FACILITY") = dtInRoomFacility.Rows(dgvInRoomFacility.CurrentRow.Index).Item(1)
                    row("QTY") = tboQty.Text
                    dtInRoomFacilityChosen.Rows.Add(row)
                    dgvSelectedInRoomFacility.DataSource = dtInRoomFacilityChosen

                    Dim column As DataGridViewColumn = dgvSelectedInRoomFacility.Columns(0)
                    column.Width = 50


                    column = New DataGridViewColumn
                    column = dgvSelectedInRoomFacility.Columns(1)
                    column.Width = 100

                    column = New DataGridViewColumn
                    column = dgvSelectedInRoomFacility.Columns(2)
                    column.Width = 50


                Else
                    MsgBox(dgvInRoomFacility.Item(1, dgvInRoomFacility.CurrentRow.Index).Value + " has been inserted")
                End If


            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try


        Else
            MessageBox.Show("Please insert Quantity")
            tboQty.Select()



        End If
        
    End Sub

    Private Sub tboQty_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboQty.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub dgvInRoomFacility_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvInRoomFacility.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            Try
                tboQty.Text = ""
                tboQty.Select()
            Catch ex As Exception

            End Try
            
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim isExit As Boolean = False
        If Not (dtInRoomFacilityChosen Is Nothing And dtRoomChosen Is Nothing) Then

            For i = 0 To dtRoomChosen.Rows.Count - 1
                For j = 0 To dtInRoomFacilityChosen.Rows.Count - 1
                    Try
                        Dim sql As String = "INSERT INTO `chamberdb`.`room_specification` (`room_id`, `room_specification_id`, `qty`, `aktif`) VALUES ('" & dtRoomChosen.Rows(i).Item("ROOM CODE") & "', '" & dtInRoomFacilityChosen.Rows(j).Item("INF CODE") & "', '" & dtInRoomFacilityChosen.Rows(j).Item("QTY") & "', '1');"
                        Dim command As New MySqlCommand(sql, connection)
                        OpenCloseConnection()
                        command.ExecuteNonQuery()
                        OpenCloseConnection()
                    Catch ex As Exception
                        Dim result As Integer = MessageBox.Show(dtInRoomFacilityChosen.Rows(j).Item("INROOM FACILITY") & " in room number '" & dtRoomChosen.Rows(i).Item("ROOM NUMBER") & "' has been existed. Do you want to skip inserting this '" & dtInRoomFacilityChosen.Rows(j).Item("INROOM FACILITY") & "' into room number '" & dtRoomChosen.Rows(i).Item("ROOM NUMBER") & "' and continue the process?", "Conflict InRoom Facility", MessageBoxButtons.YesNo)
                        If result = DialogResult.No Then
                            Exit For
                            isExit = True
                        ElseIf result = DialogResult.Yes Then

                        End If


                    End Try



                Next

                If isExit = True Then
                    Exit For
                End If


            Next
            MessageBox.Show("All In-Room fasliies have inserted into selected rooms")
            Me.Close()
        Else
            MessageBox.Show("Please select room and InRoom Facility which will be added")

        End If


    End Sub
End Class