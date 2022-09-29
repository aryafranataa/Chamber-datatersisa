Imports MySql.Data.MySqlClient

Public Class PaymentMethod
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtPayment As New DataTable


    Private Sub kosongin()
        dtPayment.Clear()
        tboPaymentCode.Text = ""
        tboPaymentName.Text = ""
    End Sub

    Private Sub dgvPayment_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPayment.CellClick
        If e.RowIndex >= 0 And e.ColumnIndex >= 0 Then
            tboPaymentCode.Text = dgvPayment.Rows(e.RowIndex).Cells(0).Value
            tboPaymentName.Text = dgvPayment.Rows(e.RowIndex).Cells(1).Value
        End If

        tboPaymentName.Select()
    End Sub

    Private Sub PaymentMethod_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()
        Try

            cmd1 = New MySqlCommand("SELECT method_id as 'PAYMENT CODE', method_name as 'PAYMENT NAME' FROM method m;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtPayment)
            dgvPayment.DataSource = dtPayment
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String = ""
        sql = "UPDATE `chamberdb`.`method` SET `method_name` = '" & tboPaymentName.Text & "' WHERE `method`.`method_id` = '" & tboPaymentCode.Text & "';;"
        Try
            Dim command As New MySqlCommand(sql, connection)
            OpenCloseConnection()
            command.ExecuteNonQuery()
            OpenCloseConnection()
            MessageBox.Show("Payment has been saved")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            OpenCloseConnection()
        End Try
    End Sub
End Class