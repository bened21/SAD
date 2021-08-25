Imports SAD_UI_FOR_ADMIN.Class1
Public Class main_user
    Dim uname, depart As String

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
        execSQL("insert into trail values(' ','" & DateAndTime.Today & "', 'Logout', '', '" & Login.username & "')")
        Login.Show()
        Login.txtuid.Clear()
        Login.txtpwd.Clear()
        Login.txtuid.Focus()

    End Sub

    Private Sub request_Click(sender As Object, e As EventArgs) Handles request.Click

        tab1.Show()
        tab2.Hide()
        data_tickets.Hide()
        txt_desc.Show()
        cb_category.Show()
        request_lbl1.Show()
        request_lbl2.Show()
        Label3.Hide()
        cbsearch.Hide()
        btnsend.Show()
    End Sub

    Private Sub records_Click(sender As Object, e As EventArgs) Handles records.Click

        tab1.Hide()
        tab2.Show()
        data_tickets.Show()
        txt_desc.Hide()
        cb_category.Hide()
        request_lbl1.Hide()
        request_lbl2.Hide()
        cbsearch.ResetText()
        btnsend.Hide()
        Label3.Show()
        cbsearch.Show()
        DSRec = GetDataTable("select * from tickets where SENDER = '" & Login.firstname & "'")
        data_tickets.DataSource = DSRec
    End Sub

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        DSRec = GetDataTable("select * from tickets where SENDER = '" & Login.firstname & "' and DATE = '" & DateAndTime.Today & "' and DESCRIPTION = '" & txt_desc.Text & "'")
        If DSRec.Rows.Count > 0 Then
            MsgBox("tickets Exists!", MsgBoxStyle.Critical, "ERROR!")
        Else
            execSQL("insert into tickets values (' ','" & Login.firstname & "', '" & DateAndTime.Today & "' , '" & cb_category.Text & "', '" & txt_desc.Text & "' , '" & Login.dp & "','','ONGOING' ,'NO' )")
            data_tickets.DataSource = DSRec
            MsgBox("Ticket Request Sent!", MsgBoxStyle.Information, "SENT!")
            execSQL("insert into trail values(' ','" & DateAndTime.Today & "', 'Ticket', 'Ticket Request Sent', '" & Login.username & "')")
        End If

        txt_desc.Clear()
        cb_category.ResetText()
    End Sub

    Private Sub cbsearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsearch.SelectedIndexChanged
        If cbsearch.SelectedIndex = 0 Then
            DSRec = GetDataTable(" select * from tickets where STATUS = 'ONGOING' and SENDER = '" & Login.firstname & "'")
            data_tickets.DataSource = DSRec
        ElseIf cbsearch.SelectedIndex = 1 Then
            DSRec = GetDataTable(" select * from tickets where STATUS = 'FINISHED' and SENDER = '" & Login.firstname & "'")
            data_tickets.DataSource = DSRec
        ElseIf cbsearch.SelectedIndex = 2 Then
            DSRec = GetDataTable(" select * from tickets where VERIFIED = 'YES' and SENDER = '" & Login.firstname & "'")
            data_tickets.DataSource = DSRec
        ElseIf cbsearch.SelectedIndex = 3 Then
            DSRec = GetDataTable(" select * from tickets where VERIFIED = 'NO' and SENDER = '" & Login.firstname & "'")
            data_tickets.DataSource = DSRec
        Else
            MsgBox("No selected search category!", MsgBoxStyle.Critical, "ERROR!")
        End If
    End Sub
End Class