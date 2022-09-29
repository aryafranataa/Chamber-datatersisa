Imports MySql.Data.MySqlClient
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports System.Drawing
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class RoomInspectionList

    Dim dtRIO As New DataTable
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter


    Private TotalCheckBoxes As Integer = 0
    Private TotalCheckedCheckBoxes As Integer = 0
    Private HeaderCheckBox As CheckBox = Nothing
    Private IsHeaderCheckBoxClicked As Boolean = False

    Dim ComplimentandAmmenities As New DataTable



    Private Sub GridView1_PrintInitialize(ByVal sender As System.Object, _
               ByVal e As DevExpress.XtraGrid.Views.Base.PrintInitializeEventArgs) _
               Handles GridView1.PrintInitialize
        Dim pb As PrintingSystemBase = CType(e.PrintingSystem, PrintingSystemBase)
        pb.PageSettings.Landscape = True
        pb.PageMargins.Top = 15
        pb.PageMargins.Left = 15
        pb.PageMargins.Bottom = 15
        pb.PageMargins.Right = 15
        pb.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Dim reportHeader As String = "Room Inspection List"
        pb.Graph.StringFormat = New BrickStringFormat(StringAlignment.Center)
        pb.Graph.Font = New Font("Tahoma", 14, FontStyle.Bold)
        Dim rec As RectangleF = New RectangleF(0, 0, pb.Graph.ClientPageSize.Width, 50)
        pb.Graph.DrawString(reportHeader, Color.Black, rec, BorderSide.None)

    End Sub

    Private Sub FillGC()
        'Cek DB RIO
        Dim RIOcmd As New MySqlCommand
        Dim RIOAdapter As New MySqlDataAdapter

        Dim RIOComand As String
        RIOComand = "select r.room_num as 'RN',r.floor as 'FL', r.type_id as 'TY',  if(pi.`CUST STATUS` = 6, concat(`ROOM STATUS`,' - ', 'ED'),if(pi.`CUST STATUS` = 7, concat(`ROOM STATUS`,' - ', 'EA'),`ROOM STATUS`)) as 'RS' from (select rm.room_num, rm.floor, rm.type_id, rm.status_room_id AS 'ROOM STATUS' from room rm where aktif = 1) r right join (SELECT SUM(CASE WHEN (arrival_Date <= 20150218 and depart_date >= 20150218 ) THEN if(checkout_by is not null,if(depart_date = 20150218,1,5),if(checkin_by is not null and checkout_by is null,IF(depart_date = 20150218,6,4),if(checkin_by is null and with_dp = '1',IF(arrival_Date = 20150218,7,IF(depart_date = 20150218,6,3)),if(checkin_by is null and with_dp = '0', IF(arrival_Date = 20150218,7,IF(depart_date = 20150218,6,2)), 1)))) ELSE 0 END) AS 'CUST STATUS', rv.room_num FROM reservation_checkin_out rv, room rm where rv.aktif = 1 and rv.room_num = rm.room_num  group by rv.room_num asc order by rv.room_num) pi on r.room_num = pi.room_num;"
        Try
            OpenCloseConnection()
            RIOcmd = New MySqlCommand(RIOComand, connection)
            RIOAdapter = New MySqlDataAdapter(RIOcmd)
            RIOAdapter.Fill(dtRIO)
            OpenCloseConnection()
            'dgvRoomInspection.DataSource = dtRIO
            'gcInspectionList.DataSource = dtRIO

            gcInspectionList.DataSource = Nothing
            GridView1.Columns.Clear()
            gcInspectionList.DataSource = dtRIO
            gcInspectionList.RefreshDataSource()


        Catch ex As Exception
            'MessageBox.Show(ex.ToString)
        End Try
    End Sub

 



    Private Sub RoomInspectionList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load





        AddHeaderCheckBox()
        AddHandler HeaderCheckBox.KeyUp, New KeyEventHandler(AddressOf HeaderCheckBox_KeyUp)
        AddHandler HeaderCheckBox.MouseClick, New MouseEventHandler(AddressOf HeaderCheckBox_MouseClick)
        BindGridView()

        'Fill Count
        Dim item As GridGroupSummaryItem = New GridGroupSummaryItem()
        item.SummaryType = DevExpress.Data.SummaryItemType.Count
        GridView1.GroupSummary.Add(item)

        FillGC()
    End Sub

    Private Sub AddHeaderCheckBox()
        HeaderCheckBox = New CheckBox()

        HeaderCheckBox.Size = New Size(15, 15)
        'Add the CheckBox into the DataGridView
        Me.dgvHKList.Controls.Add(HeaderCheckBox)
    End Sub

    Private Sub BindGridView()

        dgvHKList.DataSource = GetDataSource()
        TotalCheckBoxes = dgvHKList.RowCount
        TotalCheckedCheckBoxes = 0
        Dim column As DataGridViewColumn = dgvHKList.Columns(0)
        column.Width = 30

        column = New DataGridViewColumn
        column = dgvHKList.Columns(1)
        column.Width = 100
    End Sub


    Private Function GetDataSource() As DataTable
        Dim dTable As New DataTable()
        Dim dRow As DataRow = Nothing

        dTable.Columns.Add("/".ToString, System.Type.[GetType]("System.Boolean"))
        dTable.Columns.Add("COMPLIMENT & AMENITIES")

        Try
            cmd1 = New MySqlCommand("SELECT hk_list_name as 'COMPLIMENT & AMENITIES' FROM hk_list h where aktif = 1;", connection)
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

        For Each Row As DataGridViewRow In dgvHKList.Rows
            If HCheckBox.Checked = True Then
                DirectCast(Row.Cells("/"), DataGridViewCheckBoxCell).Value = True
                Try
                    dtRIO.Columns.Add(dgvHKList.Item(1, Row.Index).Value)
                Catch ex As Exception

                End Try


            ElseIf HCheckBox.Checked = False Then
                DirectCast(Row.Cells("/"), DataGridViewCheckBoxCell).Value = False
                Try
                    dtRIO.Columns.Remove(dgvHKList.Item(1, Row.Index).Value)
                Catch ex As Exception

                End Try

            End If
        Next
        'StatementSelect(StatementSelect.Length) = ""



        dgvHKList.RefreshEdit()

        gcInspectionList.DataSource = Nothing
        GridView1.Columns.Clear()
        gcInspectionList.DataSource = dtRIO

        TotalCheckedCheckBoxes = If(HCheckBox.Checked, TotalCheckBoxes, 0)


        IsHeaderCheckBoxClicked = False

    End Sub

    Private Sub btnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintPreview.Click

        gcInspectionList.DataSource = Nothing
        GridView1.Columns.Clear()
        gcInspectionList.DataSource = dtRIO
        gcInspectionList.RefreshDataSource()


        gcInspectionList.ShowRibbonPrintPreview()
    End Sub

    Private Sub dgvHKList_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvHKList.CellValueChanged
        If Not IsHeaderCheckBoxClicked Then
            RowCheckBoxClick(DirectCast(dgvHKList(e.ColumnIndex, e.RowIndex), DataGridViewCheckBoxCell))
        End If
    End Sub

    Private Sub RowCheckBoxClick(ByVal RCheckBox As DataGridViewCheckBoxCell)
        If RCheckBox IsNot Nothing Then
            'Modifiy Counter;            
            If CBool(RCheckBox.Value) AndAlso TotalCheckedCheckBoxes < TotalCheckBoxes Then
                TotalCheckedCheckBoxes += 1

                dtRIO.Columns.Add(dgvHKList.Item(1, dgvHKList.CurrentRow.Index).Value)
               
                

            ElseIf TotalCheckedCheckBoxes > 0 Then
                TotalCheckedCheckBoxes -= 1

                dtRIO.Columns.Remove(dgvHKList.Item(1, dgvHKList.CurrentRow.Index).Value)
              

            End If

            'Change state of the header CheckBox.
            If TotalCheckedCheckBoxes < TotalCheckBoxes Then
                HeaderCheckBox.Checked = False
            ElseIf TotalCheckedCheckBoxes = TotalCheckBoxes Then
                HeaderCheckBox.Checked = True
            End If

            gcInspectionList.DataSource = Nothing
            GridView1.Columns.Clear()
            gcInspectionList.DataSource = dtRIO


        End If

    End Sub

    Private Sub dgvHKList_CurrentCellDirtyStateChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgvHKList.CurrentCellDirtyStateChanged
        If TypeOf dgvHKList.CurrentCell Is DataGridViewCheckBoxCell Then
            dgvHKList.CommitEdit(DataGridViewDataErrorContexts.Commit)
        End If
    End Sub

    Private Sub dgvHKList_CellPainting(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellPaintingEventArgs) Handles dgvHKList.CellPainting
        If e.RowIndex = -1 AndAlso e.ColumnIndex = 0 Then
            ResetHeaderCheckBoxLocation(e.ColumnIndex, e.RowIndex)
        End If
    End Sub

    Private Sub ResetHeaderCheckBoxLocation(ByVal ColumnIndex As Integer, ByVal RowIndex As Integer)
        'Get the column header cell bounds
        Dim oRectangle As Rectangle = Me.dgvHKList.GetCellDisplayRectangle(ColumnIndex, RowIndex, True)

        Dim oPoint As New Point()

        oPoint.X = oRectangle.Location.X + (oRectangle.Width - HeaderCheckBox.Width) \ 2 + 1
        oPoint.Y = oRectangle.Location.Y + (oRectangle.Height - HeaderCheckBox.Height) \ 2 + 1

        'Change the location of the CheckBox to make it stay on the header
        HeaderCheckBox.Location = oPoint
    End Sub

    'Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    PrintDocument1.Print()
    'End Sub

    'Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs)
    '    Dim bm As New Bitmap(Me.dgvRoomInspection.Width, Me.dgvRoomInspection.Height)
    '    dgvRoomInspection.DrawToBitmap(bm, New Rectangle(0, 0, Me.dgvRoomInspection.Width, Me.dgvRoomInspection.Height))
    '    e.Graphics.DrawImage(bm, 0, 0)
    'End Sub
End Class