Imports SAD_UI_FOR_ADMIN.Class1
Public Class Login
    Public username, usertype, firstname, dp As String
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DSRec.Clear()
        DSRec = GetDataTable("select accounts.USERTYPE from accounts where accounts.USERNAME = '" & txtuid.Text & "' and accounts.PASSWORD = '" & txtpwd.Text & "'")

        If DSRec.Rows.Count > 0 Then
            usertype = DSRec.Rows(0).Item("USERTYPE")
            username = txtuid.Text
            DSRec = GetDataTable("select accounts.FIRSTNAME from accounts where accounts.USERNAME = '" & txtuid.Text & "'")
            firstname = DSRec.Rows(0).Item("FIRSTNAME")
            If usertype = "User" Then
                Dim stud As New main_user
                stud.Show()
                DSRec = GetDataTable("select accounts.DEPARTMENT from accounts where accounts.USERNAME = '" & txtuid.Text & "'")
                dp = DSRec.Rows(0).Item("DEPARTMENT")
                execSQL("insert into trail values(' ','" & DateAndTime.Today & "', 'Login', ' ', '" & username & "')")
                Me.Hide()
            ElseIf usertype = "Technical Staff" Then
                Dim tech As New main
                tech.Show()
                execSQL("insert into trail values(' ','" & DateAndTime.Today & "', 'Login', ' ', '" & username & "')")
                Me.Hide()
            Else
                Dim admin As New main_supervisor
                admin.Show()
                execSQL("insert into trail values(' ','" & DateAndTime.Today & "', 'Login', ' ', '" & username & "')")
                Me.Hide()
            End If
        Else
            MsgBox("Invalid username or password", MsgBoxStyle.Critical, "ERROR!")
            txtuid.Clear()
            txtpwd.Clear()
            txtuid.Focus()
        End If
    End Sub

End Class