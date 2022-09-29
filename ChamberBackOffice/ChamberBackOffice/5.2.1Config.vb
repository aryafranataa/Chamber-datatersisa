Imports MySql.Data.MySqlClient

Public Class Config
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtConfig As New DataTable

    Private Sub kosongin()
        dtConfig.Clear()
        tboDP.Text = ""
        tboDeposit.Text = ""
    End Sub

    Private Sub Config_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()
        Try

            cmd1 = New MySqlCommand("select * from config", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtConfig)

            If dtConfig.Rows.Count > 0 Then
                If dtConfig.Rows(0).Item("dp_percent") = "1" Then
                    cboPercentDP.Checked = True
                Else
                    cboPercentDP.Checked = False
                End If
                If dtConfig.Rows(0).Item("deposit_percent") = "1" Then
                    cboPercentDP.Checked = True
                Else
                    cboPercentDP.Checked = False
                End If

                tboDeposit.Text = dtConfig.Rows(0).Item("deposit_amount")
                tboDP.Text = dtConfig.Rows(0).Item("dp_amount")


            End If



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try


    End Sub

    Private Sub cboActiveDP_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPercentDP.CheckedChanged
        If cboPercentDP.Checked = True Then
            lblDP.Text = tboDP.Text & " %"
        Else
            lblDP.Text = "Rp. " & tboDP.Text
        End If
    End Sub

    Private Sub cboActiveDeposit_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPercentDeposit.CheckedChanged
        If cboPercentDeposit.Checked = True Then
            lblDeposit.Text = tboDeposit.Text & " %"
        Else
            lblDeposit.Text = "Rp. " & tboDeposit.Text
        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String = ""
        sql = "UPDATE `chamberdb`.`config` SET `dp_amount` = '" & tboDP.Text & "', `dp_percent` = '" & If(cboPercentDP.Checked = True, "1", "0") & "', `deposit_amount` = '" & tboDeposit.Text & "', `deposit_percent` = '" & If(cboPercentDeposit.Checked = True, "1", "0") & "';"
        Try
            Dim command As New MySqlCommand(sql, connection)
            OpenCloseConnection()
            command.ExecuteNonQuery()
            OpenCloseConnection()
            MessageBox.Show("Payment detail has been saved")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            OpenCloseConnection()
        End Try
    End Sub

    Private Sub tboDP_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboDP.TextChanged
        cboActiveDP_CheckedChanged(sender, e)
    End Sub

    Private Sub tboDeposit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboDeposit.TextChanged
        cboActiveDeposit_CheckedChanged(sender, e)
    End Sub

    Private Sub tboDP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboDP.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tboDeposit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboDeposit.KeyPress
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