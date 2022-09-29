Imports MySql.Data.MySqlClient

Public Class HotelProfile

    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter
    Dim dtHotelProfile As New DataTable

    Private Sub kosongin()
        dtHotelProfile.Clear()
        tboHotelName.Text = ""
        tboHotelAddress.Text = ""
        tboPhone.Text = ""
        tboFax.Text = ""
        tboPhone2.Text = ""
        tboWebsite.Text = ""
        tboNPWP.Text = ""
        tboEmail.Text = ""
    End Sub

    Private Sub HotelProfile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        kosongin()
        Try

            cmd1 = New MySqlCommand("SELECT hotel_name as 'HOTEL NAME', hotel_address as 'HOTEL ADDRESS', phone_number1 as 'PHONE NUMBER', fax_number as 'FAX', phone_number2 as 'PHONE NUMBER 2', web as 'WEBSITE', npwp as 'NPWP', email as 'EMAIL'   FROM hotel_profile h;", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtHotelProfile)

            If dtHotelProfile.Rows.Count > 0 Then
                insertorupdateHotelProfile = 0
                tboHotelName.Text = dtHotelProfile.Rows(0).Item("HOTEL NAME")
                tboHotelAddress.Text = dtHotelProfile.Rows(0).Item("HOTEL ADDRESS")
                tboPhone.Text = dtHotelProfile.Rows(0).Item("PHONE NUMBER")
                tboFax.Text = dtHotelProfile.Rows(0).Item("FAX")
                tboPhone2.Text = dtHotelProfile.Rows(0).Item("PHONE NUMBER 2")
                tboWebsite.Text = dtHotelProfile.Rows(0).Item("WEBSITE")
                tboNPWP.Text = dtHotelProfile.Rows(0).Item("NPWP")
                tboEmail.Text = dtHotelProfile.Rows(0).Item("EMAIL")
            Else
                insertorupdateHotelProfile = 1
            End If
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
        tboHotelName.Select()
    End Sub

   

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim sql As String = ""

        If insertorupdateHotelProfile = 1 Then 'insert
            sql = "INSERT INTO `chamberdb`.`hotel_profile` (`hotel_name`, `hotel_address`, `phone_number1`, `fax_number`, `phone_number2`, `web`, `npwp`, `email`) VALUES ('" & tboHotelName.Text & "', '" & tboHotelAddress.Text & "', '" & tboPhone.Text & "', '" & tboFax.Text & "', '" & tboPhone2.Text & "', '" & tboWebsite.Text & "', '" & tboNPWP.Text & "', '" & tboEmail.Text & "');"

        ElseIf insertorupdateHotelProfile = 0 Then 'update
            sql = "UPDATE `chamberdb`.`hotel_profile` SET `hotel_name` = '" & tboHotelName.Text & "', `hotel_address` = '" & tboHotelAddress.Text & "', `phone_number1` = '" & tboPhone.Text & "', `fax_number` = '" & tboFax.Text & "', `phone_number2` = '" & tboPhone2.Text & "', `web` = '" & tboWebsite.Text & "', `npwp` = '" & tboNPWP.Text & "', `email` = '" & tboEmail.Text & "' WHERE `hotel_profile`.`hotel_name` = '" & dtHotelProfile(0)(0) & "' AND `hotel_profile`.`hotel_address` = '" & dtHotelProfile(0)(1) & "' AND `hotel_profile`.`phone_number1` = '" & dtHotelProfile(0)(2) & "' AND `hotel_profile`.`fax_number` = '" & dtHotelProfile(0)(3) & "' AND `hotel_profile`.`phone_number2` = '" & dtHotelProfile(0)(4) & "' AND `hotel_profile`.`web` = '" & dtHotelProfile(0)(5) & "' AND `hotel_profile`.`npwp` = '" & dtHotelProfile(0)(6) & "' AND `hotel_profile`.`email` = '" & dtHotelProfile(0)(7) & "';"
        End If

        Try
            Dim command As New MySqlCommand(sql, connection)
            OpenCloseConnection()
            Command.ExecuteNonQuery()
            OpenCloseConnection()
            MessageBox.Show("Hotel profile has been saved")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)
            OpenCloseConnection()
        End Try

        HotelProfile_Load(sender, e)
    End Sub

    Private Sub tboNPWP_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboNPWP.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub tboPhone_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboPhone.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub


    Private Sub tboPhone2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboPhone2.KeyPress
        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If
    End Sub

 
    Private Sub tboFax_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tboFax.KeyPress
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