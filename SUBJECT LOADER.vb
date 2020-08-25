
Imports MySql.Data.MySqlClient
Imports Guna.UI

Public Class SUBJECT_LOADER

    Private Sub GunaButtonSAVE_Click(sender As Object, e As EventArgs) Handles GunaButtonSAVE.Click

        Dim subj As String = GunaTextBoxsub.Text
        Try
            'Checking for empty field
            If subj.Trim = "" Or subj.Trim = "Subject" Then
                MsgBox("Oops! Please fill-in the Space to continue")
            Else
                Dim buttonset As DialogResult

                'comfirmation before submission
                buttonset = MessageBox.Show("Are you sure you want to 'Save Record' ? Click 'OK' to Save, 'Cancel' to Continue Computation", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
                If buttonset = DialogResult.OK Then
                    'checking duplicate of record
                    If subjExist(subj) Then
                        MsgBox("This SUBJECT is already in the database")
                        'insertion when all conditions are met
                    Else


                        sql = "insert into subjects(Subjects) values('" & subj & "')"


                        conndb()

                        cmd = New MySqlCommand(sql, conn)
                        dr = cmd.ExecuteReader()
                        MsgBox("Subject inserted successfully")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.ToString())

        Finally


            cmd.Dispose()
            conn.Close()

        End Try

        Me.Controls.Clear()
        InitializeComponent()

    End Sub

    Public Function subjExist(ByVal subj As String) As Boolean
        'this code check if there is duplicate of subject in the table by passing into the database
        Dim con As New LOGIN_REG_CONNECTION()
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT  `Subjects` FROM `subjects` WHERE `Subjects` =@subj", con.getconnection)
        command.Parameters.Add("@subj", MySqlDbType.VarChar).Value = subj
        adapter.SelectCommand = command
        adapter.Fill(table)
        If table.Rows.Count > 0 Then
            Return True
        Else
            Return False

        End If

    End Function

    Private Sub GunaTextBoxsub_TextChanged(sender As Object, e As EventArgs) Handles GunaTextBoxsub.TextChanged

    End Sub
End Class