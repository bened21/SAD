Imports SAD_UI_FOR_ADMIN.Class1
Imports SAD_UI_FOR_ADMIN.main_supervisor
Public Class update_account
    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        Dim result = MessageBox.Show("Are sure you want to update the account selected?", "Update Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If result = DialogResult.No Then

        ElseIf result = DialogResult.Yes Then
            If txtpwd.Text = txtconfirm.Text Then
                execSQL("update accounts set USERNAME = '" & txtuid.Text & "', PASSWORD = '" & txtpwd.Text & "' where  FIRSTNAME = '" & lbluid.Text & "'")
                If rowAffected > 0 Then
                    MsgBox("Username and Password Updated!", MsgBoxStyle.Information, "DONE!")
                    execSQL("insert into trail values(' ','" & DateAndTime.Today & "', 'Accounts', 'Update Account " & lbluid.Text & "', '" & Login.username & "')")
                End If
            Else
                MsgBox("Password and Confirm Password must be equal!", MsgBoxStyle.Information, "ERROR!")
            End If
        End If


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

End Class