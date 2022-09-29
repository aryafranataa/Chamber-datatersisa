Imports DevExpress.XtraTab
Imports MySql.Data.MySqlClient
Public Class _1
    Dim cmd1 As New MySqlCommand
    Dim adapter As New MySqlDataAdapter

    Dim cekTabName As String
    Dim cekTabText As String
    Dim statusCekTab As Integer
    Dim posotionTabPage As Integer


    Private Sub tutupNavigation()
     
    End Sub

    Private Sub OpenNavigation()
       
    End Sub

    Private Sub cekTabPages()
        For i = 0 To xtcUtama.TabPages.Count - 1 Step 1
            If xtcUtama.TabPages(i).Text = cekTabText Or xtcUtama.TabPages(i).Name = cekTabName Then
                statusCekTab = 1
                posotionTabPage = i
                Exit For
            Else
                statusCekTab = 0
            End If
        Next
    End Sub

    Private Sub xtcUtama_CloseButtonClick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles xtcUtama.CloseButtonClick
        If xtcUtama.TabPages.Count = 1 Then
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count
        Else
            xtcUtama.TabPages.Remove(xtcUtama.SelectedTabPage())
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        End If
    End Sub
    Private Sub xtcUtama_CloseButtonClick(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If xtcUtama.TabPages.Count = 1 Then
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count
        Else
            xtcUtama.TabPages.Remove(xtcUtama.SelectedTabPage())
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        End If
    End Sub

    Private Sub _1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        tutupNavigation()
        'VisibleNavigation()
        OpenNavigation()

        lblDate.Text = Today.ToString("dd - MMMM - yyyy")
        lblUsername.Text = username
     
    End Sub

    Private Sub Refreshing()
        ngbHousekeeping.Visible = True
        ngbConfigurationDatabase.Visible = True
        ngbMasterDataEmployee.Visible = True
        ngbMasterDataRoom.Visible = True
        ngbReport.Visible = True
        ngbConfigurationGeneral.Visible = True
        ngbConfigurationPayment.Visible = True
        ngbMiscellaneous.Visible = True
    End Sub



    Private Sub tsmiHome_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiHome.Click
        Refreshing()

        'VisibleNavigation()
        OpenNavigation()
        tutupNavigation()
    End Sub

    

  
    Private Sub tsmiHousekeeping_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiHousekeeping.Click
        ngbHousekeeping.Visible = True
        ngbConfigurationDatabase.Visible = False
        ngbMasterDataEmployee.Visible = False
        ngbMasterDataRoom.Visible = False
        ngbReport.Visible = False
        ngbConfigurationGeneral.Visible = False
        ngbConfigurationPayment.Visible = False
        ngbMiscellaneous.Visible = False
    End Sub
    
    Private Sub tsmiRoom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiRoom.Click
        ngbHousekeeping.Visible = False
        ngbConfigurationDatabase.Visible = False
        ngbMasterDataEmployee.Visible = False
        ngbMasterDataRoom.Visible = True
        ngbReport.Visible = False
        ngbConfigurationGeneral.Visible = False
        ngbConfigurationPayment.Visible = False
        ngbMiscellaneous.Visible = False
    End Sub

    Private Sub tsmiEmployee_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiEmployee.Click
        ngbHousekeeping.Visible = False
        ngbConfigurationDatabase.Visible = False
        ngbMasterDataEmployee.Visible = True
        ngbMasterDataRoom.Visible = False
        ngbReport.Visible = False
        ngbConfigurationGeneral.Visible = False
        ngbConfigurationPayment.Visible = False
        ngbMiscellaneous.Visible = False
    End Sub

    Private Sub tsmiReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiReport.Click
        ngbHousekeeping.Visible = False
        ngbConfigurationDatabase.Visible = False
        ngbMasterDataEmployee.Visible = False
        ngbMasterDataRoom.Visible = False
        ngbReport.Visible = True
        ngbConfigurationGeneral.Visible = False
        ngbConfigurationPayment.Visible = False
        ngbMiscellaneous.Visible = False
    End Sub

    Private Sub GeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneralToolStripMenuItem.Click
        ngbHousekeeping.Visible = False
        ngbConfigurationDatabase.Visible = False
        ngbMasterDataEmployee.Visible = False
        ngbMasterDataRoom.Visible = False
        ngbReport.Visible = False
        ngbConfigurationGeneral.Visible = True
        ngbConfigurationPayment.Visible = False
        ngbMiscellaneous.Visible = False
    End Sub

    Private Sub PaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentToolStripMenuItem.Click
        ngbHousekeeping.Visible = False
        ngbConfigurationDatabase.Visible = False
        ngbMasterDataEmployee.Visible = False
        ngbMasterDataRoom.Visible = False
        ngbReport.Visible = False
        ngbConfigurationGeneral.Visible = False
        ngbConfigurationPayment.Visible = True
        ngbMiscellaneous.Visible = False
    End Sub

    Private Sub DatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DatabaseToolStripMenuItem.Click
        ngbHousekeeping.Visible = False
        ngbConfigurationDatabase.Visible = True
        ngbMasterDataEmployee.Visible = False
        ngbMasterDataRoom.Visible = False
        ngbReport.Visible = False
        ngbConfigurationGeneral.Visible = False
        ngbConfigurationPayment.Visible = False
        ngbMiscellaneous.Visible = False
    End Sub


    Private Sub nbiRoomStatus_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiRoomStatus.LinkClicked
        cekTabText = "Room Status"
        cekTabName = "xtpRoomStatus"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpRoomStatus"
            Dim textTab As String = "Room Status"
            Dim insertForm As New RoomStatus
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub


    Private Sub nbiRoomType_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiRoomType.LinkClicked
        cekTabText = "Room Type"
        cekTabName = "xtpRoomType"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpRoomType"
            Dim textTab As String = "Room Type"
            Dim insertForm As New RoomTypeSearch
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiRoom_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiRoom.LinkClicked
        cekTabText = "Room"
        cekTabName = "xtpRoom"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpRoom"
            Dim textTab As String = "Room"
            Dim insertForm As New RoomSearch
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiHotelProfile_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiHotelProfile.LinkClicked
        cekTabText = "Hotel Profile"
        cekTabName = "xtpHotelProfile"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpHotelProfile"
            Dim textTab As String = "Hotel Profile"
            Dim insertForm As New HotelProfile
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiSex_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiSex.LinkClicked
        cekTabText = "Sex"
        cekTabName = "xtpSex"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpSex"
            Dim textTab As String = "Sex"
            Dim insertForm As New Sex
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiSalutation_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiSalutation.LinkClicked
        cekTabText = "Salutation"
        cekTabName = "xtpSalutation"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpSalutation"
            Dim textTab As String = "Salutation"
            Dim insertForm As New Salutation
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiBackup_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiBackup.LinkClicked
        Backup.ShowDialog()
    End Sub

    
    Private Sub nbiRestore_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiRestore.LinkClicked
        Restore.ShowDialog()
    End Sub

    Private Sub nbiBankAccount_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiBankAccount.LinkClicked
        cekTabText = "Bank Account"
        cekTabName = "xtpBankAccount"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpBankAccount"
            Dim textTab As String = "Bank Account"
            Dim insertForm As New BankAccount
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiUser_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiUser.LinkClicked
        cekTabText = "User"
        cekTabName = "xtpUser"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpUser"
            Dim textTab As String = "User"
            Dim insertForm As New UserSearch
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiRoomInspection_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiRoomInspection.LinkClicked
        cekTabText = "Room Inspection"
        cekTabName = "xtpRoomInspection"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpRoomInspection"
            Dim textTab As String = "Room Inspection"
            Dim insertForm As New RoomInspectionList
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiChangeRoomStatus_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiChangeRoomStatus.LinkClicked
        cekTabText = "Change Room Status"
        cekTabName = "xtpChangeRoomStatus"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpChangeRoomStatus"
            Dim textTab As String = "Change Room Status"
            Dim insertForm As New ChangeRoomStatus
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiLostandFound_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiLostandFound.LinkClicked
        cekTabText = "Lost and Found"
        cekTabName = "xtpLostandFound"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpLostandFound"
            Dim textTab As String = "Lost and Found"
            Dim insertForm As New LostandFound
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiJobPosition_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiJobPosition.LinkClicked
        cekTabText = "Job Position"
        cekTabName = "xtpJobPosition"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpJobPosition"
            Dim textTab As String = "Job Position"
            Dim insertForm As New JobPosition
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiEmployee_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiEmployee.LinkClicked
        cekTabText = "Employee"
        cekTabName = "xtpEmployee"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpEmployee"
            Dim textTab As String = "Employee"
            Dim insertForm As New EmployeeSearch
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub


    Private Sub nbiRate_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiRate.LinkClicked
        cekTabText = "Rate"
        cekTabName = "xtpRate"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpRate"
            Dim textTab As String = "Rate"
            Dim insertForm As New Rate
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiInRoomFaciliies_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiInRoomFaciliies.LinkClicked
        cekTabText = "InRoom Facility"
        cekTabName = "xtpInRoomFacility"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpInRoomFacility"
            Dim textTab As String = "InRoom Facility"
            Dim insertForm As New InRoomFacilitySearch
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub nbiPaymentMethod_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiPaymentMethod.LinkClicked
        cekTabText = "Payment Method"
        cekTabName = "xtpPaymentMethod"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpPaymentMethod"
            Dim textTab As String = "Payment Method"
            Dim insertForm As New PaymentMethod
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    


    Private Sub tsmiNightAudit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiNightAudit.Click

        ubahstatusroomNightAudit()

        Dim result As Integer = MessageBox.Show("Do you want to continue this process?", "Night Audit", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            MessageBox.Show("Yes")
        ElseIf result = DialogResult.No Then
            MessageBox.Show("NO")

        End If

    End Sub

    Private Sub nbiComplimentandAmenities_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiComplimentandAmenities.LinkClicked
        cekTabText = "Compliments and Amenities"
        cekTabName = "xtpCompliments"
        statusCekTab = 0
        cekTabPages()
        If statusCekTab = 0 Then
            Dim nameTab As String = "xtpCompliments"
            Dim textTab As String = "Compliments and Amenities"
            Dim insertForm As New ComplimentsandAmenities
            insertForm.TopLevel = False
            insertForm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Dim myTabPage As New XtraTabPage()
            myTabPage.Name = nameTab
            myTabPage.Text = textTab
            xtcUtama.TabPages.Add(myTabPage)
            xtcUtama.TabPages(xtcUtama.TabPages.Count - 1).Controls.Add(insertForm)
            insertForm.Show()
            xtcUtama.SelectedTabPageIndex = xtcUtama.TabPages.Count - 1
        ElseIf statusCekTab = 1 Then
            xtcUtama.SelectedTabPageIndex = posotionTabPage
        End If
    End Sub

    Private Sub NavBarItem2_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles NavBarItem2.LinkClicked
        ComplimentsandAmenities.ShowDialog()
    End Sub

    Private Sub nbiConfig_LinkClicked(ByVal sender As System.Object, ByVal e As DevExpress.XtraNavBar.NavBarLinkEventArgs) Handles nbiConfig.LinkClicked
        Config.ShowDialog()
    End Sub
End Class