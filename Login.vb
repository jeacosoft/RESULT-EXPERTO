Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub LOGBTN_Click(sender As Object, e As EventArgs) Handles LOGBTN.Click
        'check before the user can login if the textboxes are empty
        'if they contain the default values (username and password)
        'check if the user exist in the database
        Dim conn As New LOGIN_REG_CONNECTION()
        Dim adapter As New MySqlDataAdapter()
        Dim table As New DataTable()
        Dim command As New MySqlCommand("SELECT  `Username`, `Password` FROM `userdata` WHERE `Username` = @usn AND `Password` = @pass", conn.getconnection())

        command.Parameters.Add("@usn", MySqlDbType.VarChar).Value = TextBoxusname.Text
        command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = TextBoxpassword.Text

        If TextBoxusname.Text.Trim() = "" Or TextBoxusname.Text.Trim().ToLower() = "username" Then
            MessageBox.Show("Please Enter your Username to continue", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
        Else
            adapter.SelectCommand = command
            adapter.Fill(table)
            If table.Rows.Count > 0 Then

                Dim result As DialogResult = MessageBox.Show("WELCOME!!! YOU CAN NOW PROCEED", "info", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
                If result = DialogResult.Cancel Then

                Else
                    Me.Hide()
                    MessageBox.Show("Please be warned that any score entered into this app will be calculated as entered, so be careful when inputting score to avoid output error while computing students' result.  CLICK 'OK' TO CONTINUE.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    Form1.Show()
                End If

            Else
                MessageBox.Show("Incorrect Username or Password please enter the correct data to continues", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

            End If

        End If
        ' this will check the who signed in in other to know what to display

    End Sub

    Private Sub CANCEL_Click(sender As Object, e As EventArgs) Handles CANCEL.Click


        Me.Controls.Clear()
        InitializeComponent()

    End Sub

    Private Sub ButtonExit_Click(sender As Object, e As EventArgs)
        Application.Exit()
    End Sub



    Private Sub TextBoxusname_Enter(sender As Object, e As EventArgs) Handles TextBoxusname.Enter
        Dim usname As String = TextBoxusname.Text
        If usname.Trim().ToLower() = "username" Or usname.Trim() = "" Then
            TextBoxusname.Text = ""
            TextBoxusname.ForeColor = Color.Black

        End If
    End Sub

    Private Sub TextBoxusname_Leave(sender As Object, e As EventArgs) Handles TextBoxusname.Leave
        Dim usname As String = TextBoxusname.Text
        If usname.Trim().ToLower() = "username" Or usname.Trim() = "" Then
            TextBoxusname.Text = "username"
            TextBoxusname.ForeColor = Color.DarkGray

        End If
    End Sub

    Private Sub TextBoxpassword_Enter(sender As Object, e As EventArgs) Handles TextBoxpassword.Enter
        Dim pas As String = TextBoxpassword.Text
        If pas.Trim().ToLower() = "Password" Or pas.Trim() = "" Then
            TextBoxpassword.Text = ""
            TextBoxpassword.ForeColor = Color.Black
            TextBoxpassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub TextBoxpassword_Leave(sender As Object, e As EventArgs) Handles TextBoxpassword.Leave
        Dim pas As String = TextBoxpassword.Text
        If pas.Trim().ToLower() = "Password" Or pas.Trim() = "" Then
            TextBoxpassword.Text = "Password"
            TextBoxpassword.ForeColor = Color.DarkGray
            TextBoxpassword.UseSystemPasswordChar = False
        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Admin_Log.Show()
        Me.Hide()
    End Sub
End Class