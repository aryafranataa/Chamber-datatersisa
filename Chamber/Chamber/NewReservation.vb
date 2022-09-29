Imports MySql.Data.MySqlClient
Public Class NewReservation
    Dim AddDateArrvial As Integer
    Dim AddDateDeparture As Integer
    Dim dtCustID As New DataTable
    Dim dtType As New DataTable
    Dim dtTitle As New DataTable
    Dim dtRoom As New DataTable
    Dim dtSelectedType As New DataTable


    Private Sub NewReservation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'isi semua field (customer id, room type dll)
        'untuk awal new reservation, ID res  di set 1 tetapi bisa  di module
        insertorupdate = 1 'diset sebagai insert


        Try
            con.Open()
            cmd1 = New MySqlCommand("select count(reservation_id) from reservation", con)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtCustID)

            tboCustID.Text = Convert.ToInt16(dtCustID.Rows(0).Item(0)) + 1

            cmd1 = New MySqlCommand("select * from type_customer t order by type_name desc", con)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtType)
            cboType.DataSource = dtType
            cboType.DisplayMember = "type_name"
            cboType.ValueMember = "customer_type_id"

            cboType_SelectedIndexChanged(sender, e)

            cmd1 = New MySqlCommand("select * from salutation", con)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtTitle)
            cboTitle.DataSource = dtTitle
            cboTitle.DisplayMember = "salutation_id"
            cboTitle.ValueMember = "salutation_id"


            cmd1 = New MySqlCommand("select type_room_id as `ROOM TYPE` from type_room", con)
            adapter = New MySqlDataAdapter(cmd1)
            adapter.Fill(dtRoom)
            con.Close()
            'dgcChooseType.ColumnCount = 1

            'dgcChooseType.DataSource = dtRoom
            'dgcChooseType.Columns(0).Name = "QTY"

            Dim chk As New DataGridViewCheckBoxColumn
            dgcChooseType.Columns.Add(chk)
            chk.Name = "chk"
            dgcChooseType.Columns(0).Width = "55"

            dtRoom.Columns.Add()
            dtRoom.Columns(1).ColumnName = "QTY"
            dgcChooseType.DataSource = dtRoom


            dtSelectedType.Columns.Add()
            dtSelectedType.Columns(0).ColumnName = "TYPE"


            For i = 0 To dtRoom.Rows.Count - 1
                dtSelectedType.Rows.Add("")
            Next

            'masukan ke data grid view dari data grid manual


            dtpDeparture.Value = DateTime.Today.AddDays(1)

            AddDateArrvial = 0
            AddDateArrvial = 0

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try





    End Sub

    Private Sub cboType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboType.SelectedIndexChanged
        If cboType.SelectedValue.ToString = "SINCI" Then
            gboGuestProfile.Visible = True
            nudNmofRoom.Value = 1

        Else

            gboGuestProfile.Visible = False
        End If
    End Sub

    Private Sub btnArrivalPlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArrivalPlus.Click
        AddDateArrvial += 1
        AddDateDeparture += 1
        dtpArrival.Value = DateTime.Today.AddDays(AddDateArrvial)

    End Sub

    Private Sub btnArrivalMins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnArrivalMins.Click
        AddDateArrvial -= 1
        AddDateDeparture -= 1
        dtpArrival.Value = DateTime.Today.AddDays(AddDateArrvial)
    End Sub

    Private Sub btnDeparturePlus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeparturePlus.Click
        AddDateDeparture += 1
        dtpDeparture.Value = DateTime.Today.AddDays(AddDateDeparture)
    End Sub

    Private Sub btnDepartureMins_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDepartureMins.Click
        AddDateDeparture -= 1
        dtpDeparture.Value = DateTime.Today.AddDays(AddDateDeparture)
    End Sub

    Private Sub dtpArrival_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpArrival.ValueChanged
        dtpDeparture.Value = DateTime.Today.AddDays(AddDateDeparture)
    End Sub

    Private Sub dtpDeparture_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpDeparture.ValueChanged
        Try
            nudNights.Value = DateDiff(DateInterval.Day, CDate(dtpArrival.Text),
                                CDate(dtpDeparture.Text))

        Catch ex As Exception
            MessageBox.Show("Departure can't submit before Arrivals")
        End Try

    End Sub

    Dim statementWhere As String


    Dim countDT As Byte
    Dim count As Byte

    Private Sub dgcChooseType_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgcChooseType.CellValueChanged
        statementWhere = ""
        count = 0
        If dgcChooseType.Rows(e.RowIndex).Cells(0).Value = True Then
            dtSelectedType.Rows(e.RowIndex).Item(0) = (dgcChooseType.Rows(e.RowIndex).Cells(1).Value)

        ElseIf dgcChooseType.Rows(e.RowIndex).Cells(0).Value = False Then
            dtSelectedType.Rows(e.RowIndex).Item(0) = ""

        End If

        For i = 0 To dtSelectedType.Rows.Count - 1

            If dtSelectedType.Rows(i).Item(0) <> "" Then
                count += 1
                If count = 1 Then
                    statementWhere = statementWhere + "`type_room_id` = '" + dtSelectedType.Rows(i).Item(0) + "' "
                Else
                    statementWhere = statementWhere + " or `type_room_id` = '" + dtSelectedType.Rows(i).Item(0) + "' "
                End If

            End If

        Next








    End Sub


    Private Sub btnSumbit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSumbit.Click
        Dim dtRoomAvailable As New DataTable



        If statementWhere = "" Then
            dgvChooseRoom.DataSource = Nothing
        Else
            Try
                cmd1 = New MySqlCommand("SELECT room_num as `ROOM NUM`, type_room_id as `ROOM TYPE`, FLOOR, status_room_id as `ROOM STATUS` FROM room r where status_room_id = 'cl/va' and (" + statementWhere + ");", con)
                adapter = New MySqlDataAdapter(cmd1)
                adapter.Fill(dtRoomAvailable)
                dgvChooseRoom.DataSource = dtRoomAvailable



            Catch ex As Exception

            End Try


        End If





    End Sub


    Private Sub chkSame_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkSame.CheckedChanged
        If chkSame.Checked = True Then
            Try
                Dim parts = tboCustName.Text.Split(" ")
                tboFirstName.Text = parts(0)
                tboLastName.Text = parts(1)
            Catch
                MessageBox.Show("Please insert customer name")
            End Try
        Else
            tboFirstName.Text = ""
            tboLastName.Text = ""
        End If



    End Sub

    Private Sub dgcChooseType_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgcChooseType.CellContentClick

    End Sub
End Class