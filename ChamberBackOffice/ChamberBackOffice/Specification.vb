Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Imports MySql.Data.MySqlClient


Public Class Specification

    Private TotalCheckBoxes As Integer = 0
    Private TotalCheckedCheckBoxes As Integer = 0
    Private HeaderCheckBox As CheckBox = Nothing
    Private IsHeaderCheckBoxClicked As Boolean = False

    '========================================batasin dgv yang ke 2===============

    Private TotalCheckBoxes2 As Integer = 0
    Private TotalCheckedCheckBoxes2 As Integer = 0
    Private HeaderCheckBox2 As CheckBox = Nothing
    Private IsHeaderCheckBoxClicked2 As Boolean = False



    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtSpecification As New DataTable
    Dim SpecificationID As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub RefreshingPage()
        dtSpecification.Clear()
        tboSpecID.Text = ""
        tboSpecName.Text = ""
        SpecificationID = ""

        tboSpecID.Select()


    End Sub

    Private Sub AddHeaderCheckBox()
        HeaderCheckBox = New CheckBox()

        HeaderCheckBox.Size = New Size(15, 15)
        'Add the CheckBox into the DataGridView
        Me.dgvRoom.Controls.Add(HeaderCheckBox)
    End Sub



    Private Sub BindGridView()
        dgvRoom.DataSource = GetDataSource()
        TotalCheckBoxes = dgvRoom.RowCount
        TotalCheckedCheckBoxes = 0
        Dim column As DataGridViewColumn = dgvRoom.Columns(0)
        column.Width = 30
    End Sub



    Private Function GetDataSource() As DataTable
        Dim dTable As New DataTable()
        Dim dRow As DataRow = Nothing

        dTable.Columns.Add("/".ToString, System.Type.[GetType]("System.Boolean"))
        dTable.Columns.Add("TYPE CODE")
        dTable.Columns.Add("ROOM NUMBER")

        Try
            cmd1 = New MySqlCommand("SELECT r.`type_id` as 'TYPE CODE', r.room_num as 'ROOM NUMBER' FROM room r where aktif = '1' having r.type_id like """ & "%" & tboRoomType.Text & "%" & """ and r.room_num like """ & "%" & tboRoomNum.Text & "%" & """;", connection)
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

        'For Each Row As DataGridViewRow In dgvRoom.Rows
        '    If HCheckBox.Checked = True Then
        '        DirectCast(Row.Cells("/"), DataGridViewCheckBoxCell).Value = True
        '        StatementSelect(Row.Index + 1) = "[TYPE CODE] = '" & dgvRoomType.Item(1, Row.Index).Value & "'"
        '        ArrayeRowTypeCodeActive(Row.Index) = Row.Index
        '        AmbilDataDaridtMurniDatabase()
        '    ElseIf HCheckBox.Checked = False Then
        '        DirectCast(Row.Cells("/"), DataGridViewCheckBoxCell).Value = False
        '        StatementSelect(Row.Index + 1) = ""
        '        ArrayeRowTypeCodeActive(Row.Index) = ""
        '        dtMirrorShowRateperRoom.Clear()
        '    End If
        'Next
        ''StatementSelect(StatementSelect.Length) = ""



        'dgvRoom.RefreshEdit()
        'TotalCheckedCheckBoxes = If(HCheckBox.Checked, TotalCheckBoxes, 0)


        IsHeaderCheckBoxClicked = False
    End Sub


    Private Sub dgvRoom_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvRoom.CellValueChanged
        If Not IsHeaderCheckBoxClicked Then

            'RowCheckBoxClick(DirectCast(dgvRoomType(e.ColumnIndex, e.RowIndex), DataGridViewCheckBoxCell))
        End If
    End Sub

    Private Sub RowCheckBoxClick(ByVal RCheckBox As DataGridViewCheckBoxCell)
        If RCheckBox IsNot Nothing Then
            'Modifiy Counter;            
            'If CBool(RCheckBox.Value) AndAlso TotalCheckedCheckBoxes < TotalCheckBoxes Then
            '    TotalCheckedCheckBoxes += 1

            '    StatementSelect(dgvRoomType.CurrentRow.Index + 1) = "[TYPE CODE] = '" & dgvRoomType.Item(1, dgvRoomType.CurrentRow.Index).Value & "'"
            '    ArrayeRowTypeCodeActive(dgvRoomType.CurrentRow.Index) = dgvRoomType.CurrentRow.Index

            '    AmbilDataDaridtMurniDatabase()
            'ElseIf TotalCheckedCheckBoxes > 0 Then
            '    StatementSelect(dgvRoomType.CurrentRow.Index + 1) = ""
            '    ArrayeRowTypeCodeActive(dgvRoomType.CurrentRow.Index) = ""

            '    TotalCheckedCheckBoxes -= 1
            '    If TotalCheckedCheckBoxes = 0 Then
            '        dtMirrorShowRateperRoom.Clear()
            '    Else
            '        AmbilDataDaridtMurniDatabase()
            '    End If

            'End If

            'Change state of the header CheckBox.
            If TotalCheckedCheckBoxes < TotalCheckBoxes Then
                HeaderCheckBox.Checked = False
            ElseIf TotalCheckedCheckBoxes = TotalCheckBoxes Then
                HeaderCheckBox.Checked = True
            End If

        End If

    End Sub

    Private Sub dgvRoom_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvRoom.CurrentCellDirtyStateChanged
        If TypeOf dgvRoom.CurrentCell Is DataGridViewCheckBoxCell Then
            dgvRoom.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvRoom_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvRoom.CellPainting
        If e.RowIndex = -1 AndAlso e.ColumnIndex = 0 Then
            ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex)
        End If
    End Sub

    Private Sub ResetHeaderCheckBoxLocation(ByVal ColumnIndex As Integer, ByVal RowIndex As Integer)
        'Get the column header cell bounds
        Dim oRectangle As Rectangle = Me.dgvRoom.GetCellDisplayRectangle(ColumnIndex, RowIndex, True)

        Dim oPoint As New Point()

        oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) \ 2 + 1
        oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) \ 2 + 1

        'Change the location of the CheckBox to make it stay on the header
        HeaderCheckBox.Location = oPoint
    End Sub






    '===========================================================================
    'yang atas itu dgv yang kanan. yang ini yang kiri untuk specification
    '============================================================================

    Private Sub AddHeaderCheckBox2()
        HeaderCheckBox2 = New CheckBox()

        HeaderCheckBox2.Size = New Size(15, 15)
        'Add the CheckBox into the DataGridView
        Me.dgvSpecCheckbox.Controls.Add(HeaderCheckBox2)
    End Sub



    Private Sub BindGridView2()
        dgvSpecCheckbox.DataSource = GetDataSource2()
        TotalCheckBoxes2 = dgvSpecCheckbox.RowCount
        TotalCheckedCheckBoxes2 = 0
        Dim column As DataGridViewColumn = dgvSpecCheckbox.Columns(0)
        column.Width = 30
    End Sub


    Private Function GetDataSource2() As DataTable
        Dim dTable2 As New DataTable()
        Dim dRow2 As DataRow = Nothing

        dTable2.Columns.Add("/".ToString, System.Type.[GetType]("System.Boolean"))
        dTable2.Columns.Add("SPEC CODE")
        dTable2.Columns.Add("SPECIFICATION")

        Try
            cmd1 = New MySqlCommand("SELECT s.room_specification_id as 'SPEC CODE', s.room_specification_name as 'SPECIFICATION' FROM specification s where aktif = '1' having `SPEC CODE` like """ & "%" & tboSpecID.Text & "%" & """ and `SPECIFICATION` like """ & "%" & tboSpecName.Text & "%" & """;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dTable2)
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        Return dTable2
    End Function


    Private Sub HeaderCheckBox2_KeyUp(ByVal sender As Object, ByVal e As KeyEventArgs)
        If e.KeyCode = Keys.Space Then
            HeaderCheckBoxClick2(DirectCast(sender, CheckBox))
        End If
    End Sub

    Private Sub HeaderCheckBox2_MouseClick(ByVal sender As Object, ByVal e As MouseEventArgs)
        HeaderCheckBoxClick2(DirectCast(sender, CheckBox))
    End Sub


    Private Sub HeaderCheckBoxClick2(ByVal HCheckBox As CheckBox)

        IsHeaderCheckBoxClicked2 = True

        'For Each Row As DataGridViewRow In dgvRoom.Rows
        '    If HCheckBox.Checked = True Then
        '        DirectCast(Row.Cells("/"), DataGridViewCheckBoxCell).Value = True
        '        StatementSelect(Row.Index + 1) = "[TYPE CODE] = '" & dgvRoomType.Item(1, Row.Index).Value & "'"
        '        ArrayeRowTypeCodeActive(Row.Index) = Row.Index
        '        AmbilDataDaridtMurniDatabase()
        '    ElseIf HCheckBox.Checked = False Then
        '        DirectCast(Row.Cells("/"), DataGridViewCheckBoxCell).Value = False
        '        StatementSelect(Row.Index + 1) = ""
        '        ArrayeRowTypeCodeActive(Row.Index) = ""
        '        dtMirrorShowRateperRoom.Clear()
        '    End If
        'Next
        ''StatementSelect(StatementSelect.Length) = ""



        'dgvRoom.RefreshEdit()
        'TotalCheckedCheckBoxes = If(HCheckBox.Checked, TotalCheckBoxes, 0)


        IsHeaderCheckBoxClicked2 = False
    End Sub

    Private Sub dgvSpecCheckbox_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSpecCheckbox.CellValueChanged
        If Not IsHeaderCheckBoxClicked2 Then
            'RowCheckBoxClick(DirectCast(dgvRoomType(e.ColumnIndex, e.RowIndex), DataGridViewCheckBoxCell))
        End If
    End Sub


    Private Sub RowCheckBoxClick2(ByVal RCheckBox As DataGridViewCheckBoxCell)
        If RCheckBox IsNot Nothing Then
            'Modifiy Counter;            
            'If CBool(RCheckBox.Value) AndAlso TotalCheckedCheckBoxes < TotalCheckBoxes Then
            '    TotalCheckedCheckBoxes += 1

            '    StatementSelect(dgvRoomType.CurrentRow.Index + 1) = "[TYPE CODE] = '" & dgvRoomType.Item(1, dgvRoomType.CurrentRow.Index).Value & "'"
            '    ArrayeRowTypeCodeActive(dgvRoomType.CurrentRow.Index) = dgvRoomType.CurrentRow.Index

            '    AmbilDataDaridtMurniDatabase()
            'ElseIf TotalCheckedCheckBoxes > 0 Then
            '    StatementSelect(dgvRoomType.CurrentRow.Index + 1) = ""
            '    ArrayeRowTypeCodeActive(dgvRoomType.CurrentRow.Index) = ""

            '    TotalCheckedCheckBoxes -= 1
            '    If TotalCheckedCheckBoxes = 0 Then
            '        dtMirrorShowRateperRoom.Clear()
            '    Else
            '        AmbilDataDaridtMurniDatabase()
            '    End If

            'End If

            'Change state of the header CheckBox.
            If TotalCheckedCheckBoxes2 < TotalCheckBoxes2 Then
                HeaderCheckBox2.Checked = False
            ElseIf TotalCheckedCheckBoxes = TotalCheckBoxes Then
                HeaderCheckBox2.Checked = True
            End If

        End If

    End Sub

    Private Sub dgvSpecCheckbox_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvSpecCheckbox.CurrentCellDirtyStateChanged
        If TypeOf dgvSpecCheckbox.CurrentCell Is DataGridViewCheckBoxCell Then
            dgvSpecCheckbox.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub


    Private Sub dgvSpecCheckbox_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvSpecCheckbox.CellPainting
        If e.RowIndex = -1 AndAlso e.ColumnIndex = 0 Then
            ResetHeaderCheckBoxLocation2(e.ColumnIndex, e.RowIndex)
        End If
    End Sub

    Private Sub ResetHeaderCheckBoxLocation2(ByVal ColumnIndex As Integer, ByVal RowIndex As Integer)
        'Get the column header cell bounds
        Dim oRectangle As Rectangle = Me.dgvSpecCheckbox.GetCellDisplayRectangle(ColumnIndex, RowIndex, True)

        Dim oPoint As New Point()

        oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) \ 2 + 1
        oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) \ 2 + 1

        'Change the location of the CheckBox to make it stay on the header
        HeaderCheckBox2.Location = oPoint
    End Sub


    Private Sub Specification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        RefreshingPage()


        AddHeaderCheckBox()
        AddHandler HeaderCheckBox.KeyUp, New KeyEventHandler(AddressOf HeaderCheckBox_KeyUp)
        AddHandler HeaderCheckBox.MouseClick, New MouseEventHandler(AddressOf HeaderCheckBox_MouseClick)
        BindGridView()

        AddHeaderCheckBox2()
        AddHandler HeaderCheckBox2.KeyUp, New KeyEventHandler(AddressOf HeaderCheckBox_KeyUp)
        AddHandler HeaderCheckBox2.MouseClick, New MouseEventHandler(AddressOf HeaderCheckBox_MouseClick)
        BindGridView2()


    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        If tboSpecID.Text = "" Or tboSpecName.Text = "" Then
            MessageBox.Show("Pelase complete all field")
            RefreshingPage()
        Else
            Dim sql As String = "INSERT INTO `chamberdb`.`specification` (`room_specification_id`, `room_specification_name`, `aktif`) VALUES ('" & tboSpecID.Text.ToUpper & "', '" & tboSpecName.Text.ToUpper & "', '1');"
            Dim command As New MySqlCommand(sql, connection)
            Try
                OpenCloseConnection()
                command.ExecuteNonQuery()
                OpenCloseConnection()


            Catch ex As Exception
                MessageBox.Show("Please insert another ID")
                OpenCloseConnection()
            End Try

            btnRefresh_Click(sender, e)

        End If

    End Sub




    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click

        If tboSpecID.Text = "" Or tboSpecName.Text = "" Then
            MessageBox.Show("Pelase complete all field")
            RefreshingPage()
        Else

            Dim sqlUpdate As String
            Dim cmd1 As New MySqlCommand
            sqlUpdate = "UPDATE `chamberdb`.`specification` SET `room_specification_id` = '" & tboSpecID.Text & "', `room_specification_name` = '" & tboSpecName.Text & "' WHERE `specification`.`room_specification_id` = '" & SpecificationID & "';"
            Try
                OpenCloseConnection()
                cmd1 = New MySqlCommand(sqlUpdate, connection)
                cmd1.ExecuteNonQuery()
                OpenCloseConnection()
                MessageBox.Show("Specification has been updated")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try

            btnRefresh_Click(sender, e)

        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        If tboSpecID.Text = "" Or tboSpecName.Text = "" Then
            MessageBox.Show("Pelase select the field which will be deleted")
            RefreshingPage()
        Else

            Dim sqlUpdate As String
            Dim cmd1 As New MySqlCommand
            sqlUpdate = "UPDATE `chamberdb`.`specification` SET `aktif` = '0' WHERE `specification`.`room_specification_id` = '" & dgvSpecCheckbox.Item(1, dgvSpecCheckbox.CurrentRow.Index).Value & "';"

            Try
                OpenCloseConnection()
                cmd1 = New MySqlCommand(sqlUpdate, connection)
                cmd1.ExecuteNonQuery()
                OpenCloseConnection()
                MessageBox.Show("Specification has been deleted")
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try

            btnRefresh_Click(sender, e)

        End If

    End Sub
    
   
    Private Sub dgvSpecCheckbox_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvSpecCheckbox.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            SpecificationID = dgvSpecCheckbox.Rows(e.RowIndex).Cells(1).Value
            tboSpecID.Text = dgvSpecCheckbox.Rows(e.RowIndex).Cells(1).Value
            tboSpecName.Text = dgvSpecCheckbox.Rows(e.RowIndex).Cells(2).Value
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        Specification_Load(sender, e)
    End Sub

 
End Class