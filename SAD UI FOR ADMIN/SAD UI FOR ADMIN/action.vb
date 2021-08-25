Imports SAD_UI_FOR_ADMIN.Class1
Imports SAD_UI_FOR_ADMIN.main_supervisor
Public Class action

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        Dim result = MessageBox.Show("Are sure you want to verify the status?", "Verify Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            execSQL("update tickets set VERIFIED = 'YES' where TICKET_ID = '" & lbl.Text & "'")
            If rowAffected > 0 Then
                MsgBox("Ticket Verified!", MsgBoxStyle.Information, "DONE!")
                execSQL("insert into trail values(' ','" & DateAndTime.Today & "', 'Tickets', 'Ticket Confirmed', '" & Login.username & "')")
            End If
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnAssign.Click
        Dim a As New assign
        a.Show()
        a.ticketsid.Text = lbl.Text
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnFinished.Click
        Dim result = MessageBox.Show("Are sure you want to update the status?", "Update Status", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            execSQL("update tickets set STATUS = 'FINISHED' where TICKET_ID = '" & ticketsid.Text & "'")
            If rowAffected > 0 Then
                MsgBox("Tickets Status Changed!", MsgBoxStyle.Information, "DONE!")
                execSQL("insert into trail values(' ','" & DateAndTime.Today & "', 'Tickets', 'Ticket Status Changed', '" & Login.username & "')")
            End If
            Me.Close()
        End If


    End Sub

End Class