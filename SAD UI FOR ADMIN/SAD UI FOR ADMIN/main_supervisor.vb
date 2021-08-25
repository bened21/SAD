Imports MySql.Data.MySqlClient     ' sql library
Imports SAD_UI_FOR_ADMIN.Class1
Public Class main_supervisor
    Public uname, i, _date, _uname, _categ, _desc, _dept, _assigned, _status, _verified As String
    Public row As Integer

    Private Sub logout_Click(sender As Object, e As EventArgs) Handles logout.Click
        Me.Close()
        execSQL("insert into trail values(' ','" & DateAndTime.Today & "', 'Logout', '', '" & Login.username & "')")
        Login.Show()
        Login.txtuid.Clear()
        Login.txtpwd.Clear()
        Login.txtuid.Focus()
    End Sub

    Public Sub account_mng_Click(sender As Object, e As EventArgs) Handles account_mng.Click
        tab1.Hide()
        tab3.Hide()
        tab4.Show()
        data_trail.Hide()
        data_accounts.Show()
        btnselect.Hide()
        btncreate.Show()
        btnupdate.Show()
        btndelete.Show()
        data_tickets.Hide()
        Label3.Hide()
        cbsearch.Hide()
        DSRec = GetDataTable("select * from accounts")
        data_accounts.DataSource = DSRec
    End Sub

    Private Sub view_Click(sender As Object, e As EventArgs) Handles view.Click
        tab1.Show()
            tab3.Hide()
            tab4.Hide()
            data_accounts.Hide()
            btncreate.Hide()
            btnupdate.Hide()
            btndelete.Hide()
            btnselect.Show()
            data_trail.Hide()
            data_tickets.Show()
            cbsearch.ResetText()
            Label3.Show()
            cbsearch.Show()
            DSRec = GetDataTable(" select * from tickets")
            data_tickets.DataSource = DSRec
    End Sub

    Private Sub verify_Click(sender As Object, e As EventArgs)
        tab1.Hide()
        tab3.Hide()
        tab4.Hide()
        data_accounts.Hide()
        btncreate.Hide()
        btnupdate.Hide()
        btndelete.Hide()
        data_trail.Hide()
        data_tickets.Show()
    End Sub

    Private Sub audit_Click(sender As Object, e As EventArgs) Handles audit.Click
        tab1.Hide()
        tab3.Show()
        tab4.Hide()
        btnselect.Hide()
        btncreate.Hide()
        btnupdate.Hide()
        btndelete.Hide()
        data_tickets.Hide()
        data_accounts.Hide()
        Label3.Hide()
        cbsearch.Hide()
        data_trail.Show()
        DSRec = GetDataTable(" select DATE, SUBTYPE, ACTION, USERNAME from trail")
        data_trail.DataSource = DSRec
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim add As New add_account
        add.Show()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        uname = data_accounts.CurrentRow.Cells(0).Value.ToString
        Dim result = MessageBox.Show("Are sure you want to delete the account selected?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            execSQL("delete from accounts where USERNAME = '" & uname & "'")
            If rowAffected > 0 Then
                MsgBox("User Deleted!", MsgBoxStyle.Critical, "ERROR!")
                execSQL("insert into trail values(' ','" & DateAndTime.Today & "', 'Accounts', 'Delete Account " & uname & "', '" & Login.username & "')")
                DSRec = GetDataTable("select * from accounts")
                data_accounts.DataSource = DSRec
            End If
        End If


    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        Dim u As New update_account
        u.Show()
        u.lbluid.Text = data_accounts.CurrentRow.Cells(3).Value.ToString()
    End Sub

    Private Sub btnselect_Click(sender As Object, e As EventArgs) Handles btnselect.Click
        Dim a As New action
        a.Show()
        a.lbl.Text = data_tickets.CurrentRow.Cells(0).Value.ToString()
        a.txtSender.Text = data_tickets.CurrentRow.Cells(1).Value.ToString()
        a.txtDate.Text = data_tickets.CurrentRow.Cells(2).Value.ToString()
        a.txtCateg.Text = data_tickets.CurrentRow.Cells(3).Value.ToString()
        a.txtDesc.Text = data_tickets.CurrentRow.Cells(4).Value.ToString()
        a.txtDepart.Text = data_tickets.CurrentRow.Cells(5).Value.ToString()
        a.txtAssigned.Text = data_tickets.CurrentRow.Cells(6).Value.ToString()
        a.txtStatus.Text = data_tickets.CurrentRow.Cells(7).Value.ToString()
        a.txtVerified.Text = data_tickets.CurrentRow.Cells(8).Value.ToString()

        If a.txtVerified.Text = "NO" And a.txtStatus.Text = "FINISHED" Then
            a.btnVerify.Show()
            a.btnAssign.Hide()
        ElseIf a.txtVerified.Text = "NO" And a.txtStatus.Text = "ONGOING" Then
            If Login.usertype = "Technical Staff" Then
                a.btnFinished.Show()
                a.btnAssign.Hide()
            ElseIf a.txtAssigned.Text = String.Empty Then
                a.btnAssign.Show()
            Else
                a.btnAssign.Hide()
            End If
        Else
            a.btnFinished.Hide()
            a.btnVerify.Hide()
            a.btnAssign.Hide()
        End If
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsearch.SelectedIndexChanged
        If cbsearch.SelectedIndex = 0 Then
            DSRec = GetDataTable(" select * from tickets where STATUS = 'ONGOING'")
            data_tickets.DataSource = DSRec
        ElseIf cbsearch.SelectedIndex = 1 Then
            DSRec = GetDataTable(" select * from tickets where STATUS = 'FINISHED'")
            data_tickets.DataSource = DSRec
        ElseIf cbsearch.SelectedIndex = 2 Then
            DSRec = GetDataTable(" select * from tickets where VERIFIED = 'YES'")
            data_tickets.DataSource = DSRec
        ElseIf cbsearch.SelectedIndex = 3 Then
            DSRec = GetDataTable(" select * from tickets where VERIFIED = 'NO'")
            data_tickets.DataSource = DSRec
        Else
            MsgBox("No selected search category!", MsgBoxStyle.Critical, "ERROR!")
        End If
    End Sub

    Private Sub main_supervisor_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        DSRec = GetDataTable(" select * from accounts")
        data_accounts.DataSource = DSRec
        DSRec = GetDataTable(" select * from tickets")
        data_tickets.DataSource = DSRec
    End Sub

End Class