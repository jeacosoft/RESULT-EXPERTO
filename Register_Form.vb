Imports MySql.Data.MySqlClient
Public Class Register_Form
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Application.Exit()

    End Sub

    Private Sub ButtonReg_Click(sender As Object, e As EventArgs) Handles ButtonReg.Click
        Dim sname As String = TextBoxsname.Text
        Dim oname As String = TextBoxothername.Text
        Dim username As String = TextBoxusername.Text
        Dim email As String = TextBoxemail.Text
        Dim pass As String = TextBoxpassword.Text
        Dim cpass As String = TextBoxcpass.Text

        If sname.Trim() = "" Or oname.Trim() = "" Or username.Trim() = "" Or email.Trim() = "" Or pass.Trim() = "" Then
            MessageBox.Show("PLEASE FILL ALL THE FIELDS TO PROCEED", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            'use this "Not String.Equals(pass, cpass)" or pass <> cpass
        ElseIf pass <> cpass Then
            MsgBox("Your Password does match, please check the password to continue")
        ElseIf usernameExist(username) Then
            MsgBox("This username is already in our database")
        Else
            Dim conn As New LOGIN_REG_CONNECTION()
            Dim command As New MySqlCommand("INSERT INTO `userdata`( `Surname`, `Othername`, `Email`, `Username`, `Password`) VALUES (@sn, @on , @em, @usn, @pass)", conn.getconnection)
            command.Parameters.Add("@sn", MySqlDbType.VarChar).Value = sname
            command.Parameters.Add("@on", MySqlDbType.VarChar).Value = oname
            command.Parameters.Add("@em", MySqlDbType.VarChar).Value = email
            command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass

            conn.Openconnection()
            If command.ExecuteNonQuery() = 1 Then
                MsgBox("Your have successfully signed Up, you can now proceed")
                conn.closeConnection()


                Me.Controls.Clear()
                InitializeComponent()
                Me.Hide()
                Login.Show()

            Else
                MsgBox("Your Record failed to submit successfull, please try again")



            End If
        End If

    End Sub
    Public Function usernameExist(ByVal username As String) As Boolean
        Dim con As New LOGIN_REG_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT  `Surname` FROM `userdata` WHERE `Username` =@usn", con.getconnection)
        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = username
        adapter.SelectCommand = command
        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False

        End If


    End Function

    Private Sub ButtonCancel_Click(sender As Object, e As EventArgs) Handles ButtonCancel.Click


        Me.Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub LinkLabelold_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabelold.LinkClicked

    End Sub

    Private Sub LinkLabelold_MouseEnter(sender As Object, e As EventArgs) Handles LinkLabelold.MouseEnter
        LinkLabelold.ForeColor = Color.Blue
    End Sub

    Private Sub LinkLabelold_Leave(sender As Object, e As EventArgs) Handles LinkLabelold.Leave
        LinkLabelold.ForeColor = Color.WhiteSmoke
    End Sub

    Private Sub LinkLabelold_Click(sender As Object, e As EventArgs) Handles LinkLabelold.Click
        Me.Hide()
        Login.Show()
    End Sub
End Class