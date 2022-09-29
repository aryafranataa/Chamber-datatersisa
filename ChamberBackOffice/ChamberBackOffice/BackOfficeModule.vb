Imports MySql.Data.MySqlClient
Module BackOfficeModule

    Public Sub ubahstatusroomNightAudit()
        'select jumlah room
        Dim cmd1 As New MySqlCommand
        Dim adapter As New MySqlDataAdapter
        Dim dtRoom As New DataTable

        Try

            cmd1 = New MySqlCommand("select * from room where aktif = 1", connection)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtRoom)

            If dtRoom.Rows.Count > 0 Then
                'ubah semua status room
                Dim sql As String = ""
                For i = 0 To dtRoom.Rows.Count - 1
                    If dtRoom.Rows(i).Item("status_room_id") = "OcC" Then
                        sql = ""
                        sql = "UPDATE `chamberdb`.`room` SET `status_room_id` = 'OcD' WHERE `room`.`room_id` = '" & dtRoom.Rows(i).Item("room_id") & "';"

                        Try
                            Dim command As New MySqlCommand(sql, connection)
                            OpenCloseConnection()
                            command.ExecuteNonQuery()
                            OpenCloseConnection()
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                            OpenCloseConnection()
                        End Try


                    ElseIf dtRoom.Rows(i).Item("status_room_id") = "VaCI" Then
                        sql = ""
                        sql = "UPDATE `chamberdb`.`room` SET `status_room_id` = 'VaC' WHERE `room`.`room_id` = '" & dtRoom.Rows(i).Item("room_id") & "';"

                        Try
                            Dim command As New MySqlCommand(sql, connection)
                            OpenCloseConnection()
                            command.ExecuteNonQuery()
                            OpenCloseConnection()
                        Catch ex As Exception
                            MessageBox.Show(ex.ToString)
                            OpenCloseConnection()
                        End Try

                    End If

                Next
            End If


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try



    End Sub


    Public Sub OpenCloseConnection()
        Try
            connection.Open()
        Catch ex As Exception
            connection.Close()
        End Try
    End Sub

    Function ubahKodeDiBelakang(ByVal angka As Integer, ByVal rangelengthOnya As Integer)
        Dim angkaJadi As String = ""
        Dim lengthCharacter As Integer
        lengthCharacter = angka.ToString().Length

        For i = rangelengthOnya To 1 Step -1
            If i > lengthCharacter Then
                angkaJadi = angkaJadi & "0"
            ElseIf i = lengthCharacter Then
                Exit For
            Else
            End If
        Next

        angkaJadi = angkaJadi & angka.ToString
        Return angkaJadi

    End Function

   

    Public connection As MySqlConnection = New MySqlConnection("server=localhost;userid=root;password=admin;database=chamberdb")

    'variable global yang di pakai
    Public username As String = "admin"
    Public UserNameForm As String
    Public column As DataColumn
    Public row As DataRow

    'variable global di Housekeeping
    Public LnFCode As String


    'variable global di master data - room
    Public RoomTypeID As String
    Public RoomNumber As String
    Public RoomCode As String

    'variable global di master data - employee
    Public EmployeeCode As String


    'ini insert untuk Housekeeping
    Public insertorupdateLostandFound As Integer '0=update 1 = insert

    'ini insert untuk master configuration 
    Public insertorupdateHotelProfile As Integer '0 = update 1 = insert

    'ini insert untuk master data - room
    Public insertorupdateRoom As Integer '0 = update 1 = insert
    Public insertorupdateRoomType As Integer '0 = update 1 = insert
    Public insertorupdateFacility As Integer '0 = update 1 = insert

    'ini insert untuk master data - employee
    Public insertofupdateUser As Integer '0 = update 1 = insert
    Public insertofupdateEmployee As Integer '0 = update 1 = insert
    Public isReset As Integer '0=tidak (berarti change)  1=iya (berarti reset)
    Public isAuthenticated As Integer '0=tidak (berarti tidak dapat access)  1=iya (berarti dapat access)

    'back
    Public fileLocation As String



End Module
