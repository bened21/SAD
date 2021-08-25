Imports SAD_UI_FOR_ADMIN.Class1

Public Class add_account

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub btncreate_Click(sender As Object, e As EventArgs) Handles btncreate.Click
        DSRec = GetDataTable("select * from accounts where USERNAME = '" & txtuid.Text & "'")
        If DSRec.Rows.Count > 0 Then
            MsgBox("Record Exists!", MsgBoxStyle.Critical, "ERROR!")
        Else
            execSQL("insert into accounts(USERNAME, PASSWORD, USERTYPE, FIRSTNAME, LASTNAME, DEPARTMENT) values ('" & txtuid.Text & "' , '" & txtpwd.Text & "', '" & cbtype.Text & "' ,'" & txtfirst.Text & "' , '" & txtlast.Text & "',  '" & cbdept.Text & "')")
            execSQL("insert into trail values(' ','" & DateAndTime.Today & "', 'Accounts', 'Create Account " & txtfirst.Text & "', '" & Login.username & "')")
        End If
        Me.Close()

    End Sub

    Private Sub cbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbtype.SelectedIndexChanged
        If cbtype.SelectedIndex = 0 Then
        ElseIf cbtype.SelectedIndex = 1 Then
        Else
            cbdept.Enabled = True
        End If
    End Sub
End Class