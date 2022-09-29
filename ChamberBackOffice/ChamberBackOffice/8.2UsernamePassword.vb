Imports MySql.Data.MySqlClient
Public Class UsernamePassword
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtUsernamePassword As New DataTable

    Private Sub UsernamePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        isAuthenticated = 0
        tboUsername.Text = ""
        tboPassword.Text = ""

        tboUsername.Select()
    End Sub


    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        If tboUsername.Text <> "" Or tboPassword.Text <> "" Then
            Try
                cmd1 = New MySqlCommand("SELECT if(md5('" & tboPassword.Text & "') = u.`password`,'1','0') as 'VALID PASSWORD', if(group_id='UG0002' or group_id = 'UG0001', '1', '0') as 'VALID GROUP',  u.username, u.name FROM `user` u where username = '" & tboUsername.Text & "' and u.aktif = 1;", connection)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtUsernamePassword)

                If dtUsernamePassword.Rows.Count > 0 Then
                    If dtUsernamePassword.Rows(0).Item("VALID PASSWORD") = "1" And dtUsernamePassword.Rows(0).Item("VALID GROUP") = "1" Then
                        isAuthenticated = 1
                        Me.Close()
                    Else
                        isAuthenticated = 0
                        tboPassword.Text = ""
                        tboUsername.Text = ""
                        tboUsername.Select()

                    End If


                Else
                    isAuthenticated = 0
                    tboPassword.Text = ""
                    tboUsername.Text = ""
                    tboUsername.Select()


                End If



            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        Else
            tboUsername.Text = ""
            tboPassword.Text = ""
            tboUsername.Select()

        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        isAuthenticated = 0
        Me.Close()
    End Sub
End Class