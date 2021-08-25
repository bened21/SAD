Imports MySql.Data.MySqlClient     ' sql library
Imports SAD_UI_FOR_ADMIN.Class1
Public Class assign
    Public tech, Ticketid As String

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.Close()
    End Sub

    Private Sub index_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DSRec = GetDataTable(" select USERNAME, FIRSTNAME, LASTNAME from accounts where USERTYPE = 'Technical Staff'")
        data_accounts.DataSource = DSRec
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        tech = data_accounts.CurrentRow.Cells(1).Value.ToString()
        Dim result = MessageBox.Show("Are sure you want to update the account selected?", "Update Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            DSRec = GetDataTable("select * from tickets where ASSIGNEDTO = '" & tech & "' and TICKET_ID = '" & ticketsid.Text & "' ")
            If DSRec.Rows.Count > 0 Then
                MsgBox("Record Exists!", MsgBoxStyle.Critical, "ERROR!")
            Else
                execSQL("update tickets set ASSIGNEDTO = '" & tech & "' where TICKET_ID = '" & ticketsid.Text & "'")
                execSQL("insert into trail values(' ','" & DateAndTime.Today & "', 'Tickets', 'Assign Ticket to " & tech & "', '" & Login.username & "')")
                MsgBox("Tickets Assigned!", MsgBoxStyle.Information, "Tadah!")
            End If
            Me.Close()
        End If
    End Sub

End Class
