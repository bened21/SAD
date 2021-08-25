Imports SAD_UI_FOR_ADMIN.Class1
Public Class main

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()
       Login.Show()
        Login.txtuid.Clear()
        Login.txtpwd.Clear()
        Login.txtuid.Focus()
    End Sub

    Private Sub view_Click(sender As Object, e As EventArgs) Handles view.Click
        data_tickets.Show()
        cbsearch.ResetText()
        DSRec = GetDataTable("select * from tickets where ASSIGNEDTO = '" & Login.firstname & "'")
        data_tickets.DataSource = DSRec
    End Sub

    Private Sub main_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        data_tickets.Show()
        DSRec = GetDataTable(" select * from tickets where ASSIGNEDTO = '" & Login.firstname & "'")
        data_tickets.DataSource = DSRec
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
            a.btnVerify.Hide()
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


        a.ticketsid.Text = data_tickets.CurrentRow.Cells(0).Value.ToString()
    End Sub

    Private Sub cbsearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbsearch.SelectedIndexChanged
        If cbsearch.SelectedIndex = 0 Then
            DSRec = GetDataTable(" select * from tickets where STATUS = 'ONGOING' and  ASSIGNEDTO = '" & Login.firstname & "'")
            data_tickets.DataSource = DSRec
        ElseIf cbsearch.SelectedIndex = 1 Then
            DSRec = GetDataTable(" select * from tickets where STATUS = 'FINISHED' and  ASSIGNEDTO = '" & Login.firstname & "'")
            data_tickets.DataSource = DSRec
        ElseIf cbsearch.SelectedIndex = 2 Then
            DSRec = GetDataTable(" select * from tickets where VERIFIED = 'YES' and  ASSIGNEDTO = '" & Login.firstname & "'")
            data_tickets.DataSource = DSRec
        ElseIf cbsearch.SelectedIndex = 3 Then
            DSRec = GetDataTable(" select * from tickets where VERIFIED = 'NO' and  ASSIGNEDTO = '" & Login.firstname & "'")
            data_tickets.DataSource = DSRec
        Else
            MsgBox("No selected search category!", MsgBoxStyle.Critical, "ERROR!")
        End If
    End Sub
End Class
