Imports MySql.Data.MySqlClient
Public Class Admin_Log

    Sub showresult()
        conndb()
        cmd = New MySqlCommand("select * from calculabase", conn)
        da = New MySqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "calculabase")
        Form1.DataGridView1.DataSource = ds
        Form1.DataGridView1.DataMember = "calculabase"
        cmd.Dispose()
        ds.Dispose()
        conn.Close()



    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Buttonadmlog.Click
        'check before the user can login if the textboxes are empty
        'if they contain the default values (username and password)
        'check if the user exist in the database
        Dim conn As New LOGIN_REG_CONNECTION
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT  `Username`, `Password` FROM `userdata` WHERE `Username` = @usn AND `Password` = @pass", conn.getconnection())


        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxusn.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxpassword.Text

        If TextBoxusn.Text.Trim() = "" Or TextBoxusn.Text.Trim().ToLower() = "username" Then
            MessageBox.Show("Please Enter your Username to continue", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Else
            adapter.SelectCommand = command
            adapter.Fill(table)
            If table.Rows.Count > 0 Then

                Dim result As DialogResult = MessageBox.Show("WELCOME MY ADMIN!!! YOU CAN NOW PROCEED", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If result = DialogResult.Cancel Then

                Else
                    Me.Hide()
                    MessageBox.Show("Thanks for using our App!  We encourage You to be couscious when entering any value to avoid vatal error.  CLICK 'OK' TO CONTINUE.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    AdminResult.Show()
                End If

            Else
                MessageBox.Show("Incorrect Username or Password please enter the correct data to continues", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            End If

        End If


        'this displays the result as instructed above under show
        showresult()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Login.Show()
        Me.Hide()

    End Sub
End Class