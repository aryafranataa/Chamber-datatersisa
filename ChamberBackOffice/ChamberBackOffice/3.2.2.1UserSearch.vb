Imports MySql.Data.MySqlClient
Public Class UserSearch
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtUserGroup As New DataTable
    Private Sub UserSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tboGroupName.Text = ""
        tboName.Text = ""
        tboUsername.Text = ""

        tboName.Select()

        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboUsername_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboUsername.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dtUserGroup.Clear()

        Try
            cmd1 = New MySqlCommand("select u.name as 'NAME', u.username as 'USERNAME', g.group_name as 'GROUP NAME' from user_group g, `user` u where g.aktif = '1' and u.aktif='1' and u.group_id=g.group_id and username <> 'sadmin' and username <> 'user' having (g.group_name like """ & "%" & tboGroupName.Text & "%" & """ and u.username like """ & "%" & tboUsername.Text & "%" & """ and u.name like """ & "%" & tboName.Text & "%" & """);", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtUserGroup)
            dgvUser.DataSource = dtUserGroup
        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
    End Sub


    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        insertofupdateUser = 1

        UserForm.ShowDialog()
        btnSearch_Click(sender, e)
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        insertofupdateUser = 0

        Try
            UserNameForm = dgvUser.Item(1, dgvUser.CurrentRow.Index).Value
            UserForm.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Please select the user that will be edited")
        End Try

        btnSearch_Click(sender, e)
    End Sub

    
    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click

        Dim result As Integer = MessageBox.Show("user '" & dgvUser.Item(0, dgvUser.CurrentRow.Index).Value & "' is going to be deleted permanently. Do you want to continue this porcess?", "Warning", MessageBoxButtons.YesNo)

        If result = DialogResult.Yes Then
            Dim sql As String = "UPDATE  `chamberdb`.`user` SET  `aktif` =  '0' WHERE  `user`.`username` =  '" & dgvUser.Item(1, dgvUser.CurrentRow.Index).Value & "';"
            Dim command As New MySqlCommand(sql, connection)
            Try
                OpenCloseConnection()
                command.ExecuteNonQuery()
                OpenCloseConnection()
                MessageBox.Show("User '" & dgvUser.Item(2, dgvUser.CurrentRow.Index).Value & "' has been deleted")
                UserSearch_Load(sender, e)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)
                OpenCloseConnection()
            End Try

        ElseIf result = DialogResult.No Then

        End If

    End Sub



    Private Sub tboName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboName.TextChanged
        btnSearch_Click(sender, e)
    End Sub

    Private Sub tboGroupName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tboGroupName.TextChanged
        btnSearch_Click(sender, e)
    End Sub
End Class