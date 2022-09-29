Imports MySql.Data.MySqlClient
Public Class LostandFound

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtLostFound As New DataTable

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dtLostFound.Clear()
        Try
            cmd1 = New MySqlCommand("SELECT l.lost_found_id as 'ID', l.room as 'ROOM', date_found as 'FOUND DATE',l.item as 'ITEM', l.date_lost as 'LOST DATE', e.employee_name as 'EMP NAME',c.name as 'CUS NAME' FROM lost_found l, employee e, customer c where l.aktif = 1 and e.employee_id= l.found_by and c.customer_id=l.lost_by having l.room like """ & "%" & tboRoomNumber.Text & "%" & """ and l.item like """ & "%" & tboItem.Text & "%" & """ and e.employee_name like """ & "%" & tboFoundby.Text & "%" & """ and  c.name like """ & "%" & tboLostby.Text & "%" & """ order by lost_found_id asc;", connection)
            'SELECT l.lost_found_id as 'ID', l.room as 'ROOM', if(date_found is null,'',l.date_found) as 'FOUND DATE',l.item as 'ITEM', if(l.date_lost is null,'', l.date_lost) as 'LOST DATE', e.employee_name as 'EMP NAME',c.name as 'CUS NAME' FROM lost_found l, employee e, customer c where  e.employee_id= l.found_by and c.customer_id=l.lost_by;", connection)
            'having l.room like """ & "%" & tboRoomNumber.Text & "%" & """ and l.item like """ & "%" & tboItem.Text & "%" & """ and e.employee_name like """ & "%" & tboFoundby.Text & "%" & """ and  c.name like """ & "%" & tboLostby.Text & "%" & """ and `LOST DATE` like """ & "%" & dtpLostfrom.Value.ToString("yyyyMMdd") & "%" & """ and `FOUND DATE` like """ & "%" & dtpFoundfrom.Value.ToString("yyyyMMdd") & "%" & """;"
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtLostFound)
            dgvLostandFound.DataSource = dtLostFound
            Dim column As DataGridViewColumn = dgvLostandFound.Columns(0)
            column.Width = 30

            column = New DataGridViewColumn
            column = dgvLostandFound.Columns(1)
            column.Width = 50


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub LostandFound_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        
        tboFoundby.Text = ""
        tboItem.Text = ""
        tboLostby.Text = ""
        tboRoomNumber.Text = ""


        btnSearch_Click(sender, e)
        tboRoomNumber.Select()

    End Sub

    Private Sub btnLost_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLost.Click
        insertorupdateLostandFound = 1

        LostandFoundTag.ShowDialog()
        btnSearch_Click(sender, e)
    End Sub

    Private Sub Found_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Found.Click
        insertorupdateLostandFound = 1

        FoundTag.ShowDialog()
        btnSearch_Click(sender, e)
    End Sub

    Private Sub btnRelease_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRelease.Click
        insertorupdateLostandFound = 0

        Try
            LnFCode = dgvLostandFound.Item(0, dgvLostandFound.CurrentRow.Index).Value
            If dgvLostandFound.Item(5, dgvLostandFound.CurrentRow.Index).Value = "....." Then
                FoundTag.ShowDialog()

            Else
                LostandFoundTag.ShowDialog()
            End If

            btnSearch_Click(sender, e)
        Catch ex As Exception
            MessageBox.Show("Please select the item which will be released")
        End Try

        LostandFound_Load(sender, e)
    End Sub

    Private Sub tboRoomNumber_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboRoomNumber.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboFoundby_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboFoundby.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboItem_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboItem.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboLostby_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboLostby.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub dgvLostandFound_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvLostandFound.CellContentClick

    End Sub
End Class