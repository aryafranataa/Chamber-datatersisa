Imports MySql.Data.MySqlClient

Public Class ChangePasswordForm

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtOldPassword As New DataTable



    Public Sub kosongin()
        tboUserName.Text = ""
        tboNewPassword.Text = ""
        tboOldPassword.Text = ""
        tboVerifyPassword.Text = ""
    End Sub


    Private Sub ChangePasswordForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()
        If isReset = 1 Then
            tboUserName.Text = UserNameForm
            tboUserName.Enabled = False

            tboOldPassword.Visible = False
            lblOldPassword.Visible = False

        ElseIf isReset = 0 Then
            tboUserName.Enabled = True
            tboOldPassword.Visible = True
            lblOldPassword.Visible = True


        End If
    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If isReset = 1 Then
            If tboNewPassword.Text = tboVerifyPassword.Text Then
                Dim sql As String = "UPDATE `chamberdb`.`user` SET `password` = md5('" & tboNewPassword.Text & "') WHERE `user`.`username` = '" & tboUserName.Text & "';"
                Dim command As New MySqlCommand(sql, connection)
                Try
                    OpenCloseConnection()
                    command.ExecuteNonQuery()
                    OpenCloseConnection()
                    MessageBox.Show(tboUserName.Text & "'s new password has been set")
                    Me.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.ToString)
                    OpenCloseConnection()
                End Try
            Else
                MessageBox.Show("Invalid verifying password. Please try again.")
                kosongin()
                tboNewPassword.Select()


            End If
        ElseIf isReset = 0 Then

            Try
                cmd1 = New MySqlCommand("SELECT if(md5('" & tboOldPassword.Text & "')=`password`,1,0) as 'VALID' FROM `user` u where username='" & tboUserName.Text & "';", connection)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtOldPassword)

                If dtOldPassword.Rows.Count > 0 Then
                    If dtOldPassword.Rows(0).Item("VALID") = 1 Then
                        If tboNewPassword.Text = tboVerifyPassword.Text Then
                            Dim sql As String = "UPDATE `chamberdb`.`user` SET `password` = md5('" & tboNewPassword.Text & "') WHERE `user`.`username` = '" & tboUserName.Text & "';"
                            Dim command As New MySqlCommand(sql, connection)
                            Try
                                OpenCloseConnection()
                                command.ExecuteNonQuery()
                                OpenCloseConnection()
                                MessageBox.Show(tboUserName.Text.ToLower & "'s new password has been set")
                                Me.Close()
                            Catch ex As Exception
                                MessageBox.Show(ex.ToString)
                                OpenCloseConnection()
                            End Try
                        Else
                            MessageBox.Show("Invalid verifying new password. Please try again.")
                            kosongin()
                            tboNewPassword.Select()
                        End If

                    ElseIf dtOldPassword.Rows(0).Item("VALID") = 0 Then
                        MessageBox.Show("Invalid verifying old password. Please try again.")
                        kosongin()
                        tboOldPassword.Select()
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.ToString)
            End Try

        End If




    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class