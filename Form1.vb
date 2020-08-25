Imports MySql.Data.MySqlClient
Public Class Form1
    Dim tti As Double
    Dim ttii As Double
    Dim ttiii As Double
    Dim ttiv As Double
    Dim ttv As Double
    Dim ttvi As Double
    Dim ttvii As Double
    Dim ttviii As Double
    Dim ttix As Double
    Dim ttx As Double
    Dim ttxi As Double
    Dim ttxii As Double
    Dim ttxiii As Double
    Dim ttxiv As Double
    Dim ttxv As Double
    Dim ttxvi As Double
    Dim ttxvii As Double
    Dim n As Integer = 0





    Private Sub ex1_TextChanged(sender As Object, e As EventArgs) Handles ex1.TextChanged

        Try
            tti = Val(fca1.Text) + Val(sca1.Text) + Val(ex1.Text)
            tt1.Text = System.Convert.ToString(tti)
            Dim grade As Integer
            grade = Integer.Parse(tt1.Text)

            Select Case grade

                Case <= 39
                    G1.Text = "FAIL:F"
                Case 40 To 49
                    G1.Text = "PASS:P"
                Case 50 To 59
                    G1.Text = "CRED:C"
                Case 60 To 69
                    G1.Text = "GOOD:B"
                Case Is >= 70
                    G1.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select




        Catch ex As Exception
            MessageBox.Show("An Error has occurred!!Please check your entry")
        End Try

    End Sub

    Private Sub ex2_TextChanged(sender As Object, e As EventArgs) Handles ex2.TextChanged
        Try

            ttii = Val(fca3.Text) + Val(sca2.Text) + Val(ex2.Text)
            tt2.Text = System.Convert.ToString(ttii)


            Dim grade As Integer
            grade = Integer.Parse(tt2.Text)

            Select Case grade

                Case <= 39
                    G2.Text = "FAIL:F"
                Case 40 To 49
                    G2.Text = "PASS:P"
                Case 50 To 59
                    G2.Text = "CRED:C"
                Case 60 To 69
                    G2.Text = "GOOD:B"
                Case Is >= 70
                    G2.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select


        Catch ex As Exception

        End Try
    End Sub

    Private Sub ex3_TextChanged(sender As Object, e As EventArgs) Handles ex3.TextChanged
        Try

            ttiii = Val(fca4.Text) + Val(sca3.Text) + Val(ex3.Text)
            tt3.Text = System.Convert.ToString(ttiii)

            Dim grade As Integer
            grade = Integer.Parse(tt3.Text)

            Select Case grade

                Case <= 39
                    G3.Text = "FAIL:F"
                Case 40 To 49
                    G3.Text = "PASS:P"
                Case 50 To 59
                    G3.Text = "CRED:C"
                Case 60 To 69
                    G3.Text = "GOOD:B"
                Case Is >= 70
                    G3.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ex4_TextChanged(sender As Object, e As EventArgs) Handles ex4.TextChanged
        Try

            ttiv = Val(fca5.Text) + Val(sca4.Text) + Val(ex4.Text)
            tt4.Text = System.Convert.ToString(ttiv)
            Dim grade As Integer
            grade = Integer.Parse(tt4.Text)

            Select Case grade

                Case <= 39
                    G4.Text = "FAIL:F"
                Case 40 To 49
                    G4.Text = "PASS:P"
                Case 50 To 59
                    G4.Text = "CRED:C"
                Case 60 To 69
                    G4.Text = "GOOD:B"
                Case Is >= 70
                    G4.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ex5_TextChanged(sender As Object, e As EventArgs) Handles ex5.TextChanged
        Try


            ttv = Val(fca6.Text) + Val(sca5.Text) + Val(ex5.Text)
            tt5.Text = System.Convert.ToString(ttv)
            Dim grade As Integer
            grade = Integer.Parse(tt5.Text)

            Select Case grade

                Case <= 39
                    G5.Text = "FAIL:F"
                Case 40 To 49
                    G5.Text = "PASS:P"
                Case 50 To 59
                    G5.Text = "CRED:C"
                Case 60 To 69
                    G5.Text = "GOOD:B"
                Case Is >= 70
                    G5.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try

    End Sub

    Private Sub ex6_TextChanged(sender As Object, e As EventArgs) Handles ex6.TextChanged
        Try

            ttvi = Val(fca7.Text) + Val(sca6.Text) + Val(ex6.Text)
            tt6.Text = System.Convert.ToString(ttvi)

            Dim grade As Integer
            grade = Integer.Parse(tt6.Text)

            Select Case grade

                Case <= 39
                    G6.Text = "FAIL:F"
                Case 40 To 49
                    G6.Text = "PASS:P"
                Case 50 To 59
                    G6.Text = "CRED:C"
                Case 60 To 69
                    G6.Text = "GOOD:B"
                Case Is >= 70
                    G6.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ex7_TextChanged(sender As Object, e As EventArgs) Handles ex7.TextChanged
        Try

            ttvii = Val(fca8.Text) + Val(sca7.Text) + Val(ex7.Text)
            tt7.Text = System.Convert.ToString(ttvii)

            Dim grade As Integer
            grade = Integer.Parse(tt7.Text)

            Select Case grade

                Case <= 39
                    G7.Text = "FAIL:F"
                Case 40 To 49
                    G7.Text = "PASS:P"
                Case 50 To 59
                    G7.Text = "CRED:C"
                Case 60 To 69
                    G7.Text = "GOOD:B"
                Case Is >= 70
                    G7.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ex8_TextChanged(sender As Object, e As EventArgs) Handles ex8.TextChanged
        Try

            ttviii = Val(fca9.Text) + Val(sca8.Text) + Val(ex8.Text)
            tt8.Text = System.Convert.ToString(ttviii)

            Dim grade As Integer
            grade = Integer.Parse(tt8.Text)

            Select Case grade

                Case <= 39
                    G8.Text = "FAIL:F"
                Case 40 To 49
                    G8.Text = "PASS:P"
                Case 50 To 59
                    G8.Text = "CRED:C"
                Case 60 To 69
                    G8.Text = "GOOD:B"
                Case Is >= 70
                    G8.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ex9_TextChanged(sender As Object, e As EventArgs) Handles ex9.TextChanged
        Try

            ttix = Val(fca10.Text) + Val(sca9.Text) + Val(ex9.Text)
            tt9.Text = System.Convert.ToString(ttix)

            Dim grade As Integer
            grade = Integer.Parse(tt9.Text)

            Select Case grade

                Case <= 39
                    G9.Text = "FAIL:F"
                Case 40 To 49
                    G9.Text = "PASS:P"
                Case 50 To 59
                    G9.Text = "CRED:C"
                Case 60 To 69
                    G9.Text = "GOOD:B"
                Case Is >= 70
                    G9.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ex10_TextChanged(sender As Object, e As EventArgs) Handles ex10.TextChanged
        Try

            ttx = Val(fca11.Text) + Val(sca10.Text) + Val(ex10.Text)
            tt10.Text = System.Convert.ToString(ttx)

            Dim grade As Integer
            grade = Integer.Parse(tt10.Text)

            Select Case grade

                Case <= 39
                    G10.Text = "FAIL:F"
                Case 40 To 49
                    G10.Text = "PASS:P"
                Case 50 To 59
                    G10.Text = "CRED:C'"
                Case 60 To 69
                    G10.Text = "GOOD:B"
                Case Is >= 70
                    G10.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ex11_TextChanged(sender As Object, e As EventArgs) Handles ex11.TextChanged
        Try

            ttxi = Val(fca12.Text) + Val(sca11.Text) + Val(ex11.Text)
            tt11.Text = System.Convert.ToString(ttxi)

            Dim grade As Integer
            grade = Integer.Parse(tt11.Text)

            Select Case grade

                Case <= 39
                    G11.Text = "FAIL:F"
                Case 40 To 49
                    G11.Text = "PASS:P"
                Case 50 To 59
                    G11.Text = "CRED:C"
                Case 60 To 69
                    G11.Text = "GOOD:B"
                Case Is >= 70
                    G11.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ex12_TextChanged(sender As Object, e As EventArgs) Handles ex12.TextChanged
        Try

            ttxii = Val(fca13.Text) + Val(sca12.Text) + Val(ex12.Text)
            tt12.Text = System.Convert.ToString(ttxii)
            Dim grade As Integer
            grade = Integer.Parse(tt12.Text)

            Select Case grade

                Case <= 39
                    G12.Text = "FAIL:F"
                Case 40 To 49
                    G12.Text = "PASS:P"
                Case 50 To 59
                    G12.Text = "CRED:C"
                Case 60 To 69
                    G12.Text = "GOOD:B"
                Case Is >= 70
                    G12.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ex13_TextChanged(sender As Object, e As EventArgs) Handles ex13.TextChanged
        Try

            ttxiii = Val(fca14.Text) + Val(sca13.Text) + Val(ex13.Text)
            tt13.Text = System.Convert.ToString(ttxiii)

            Dim grade As Integer
            grade = Integer.Parse(tt13.Text)

            Select Case grade

                Case <= 39
                    G13.Text = "FAIL:F"
                Case 40 To 49
                    G13.Text = "PASS:P"
                Case 50 To 59
                    G13.Text = "CRED:C"
                Case 60 To 69
                    G13.Text = "GOOD:B"
                Case Is >= 70
                    G13.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ex14_TextChanged(sender As Object, e As EventArgs) Handles ex14.TextChanged
        Try

            ttxiv = Val(fca15.Text) + Val(sca14.Text) + Val(ex14.Text)
            tt14.Text = System.Convert.ToString(ttxiv)

            Dim grade As Integer
            grade = Integer.Parse(tt14.Text)

            Select Case grade

                Case <= 39
                    G14.Text = "FAIL:F"
                Case 40 To 49
                    G14.Text = "PASS:P"
                Case 50 To 59
                    G14.Text = "CRED:C"
                Case 60 To 69
                    G14.Text = "GOOD:B"
                Case Is >= 70
                    G14.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub ex15_TextChanged(sender As Object, e As EventArgs) Handles ex15.TextChanged
        Try

            ttxv = Val(fca16.Text) + Val(sca15.Text) + Val(ex15.Text)
            tt15.Text = System.Convert.ToString(ttxv)

            Dim grade As Integer
            grade = Integer.Parse(tt15.Text)

            Select Case grade

                Case <= 39
                    G15.Text = "FAIL:F"
                Case 40 To 49
                    G15.Text = "PASS:P"
                Case 50 To 59
                    G15.Text = "CRED:C"
                Case 60 To 69
                    G15.Text = "GOOD:B"
                Case Is >= 70
                    G15.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        'computation section where total, averager etc is computed
        Try
            If TextBoxSUB.Text = "Enter no of Subjects " Then
                MsgBox("Please fill in the number of SUBJECT(s) offered by this candidates, to proceed the computation")

            Else
                'total score
                ttxvi = Val(tt1.Text) + Val(tt2.Text) + Val(tt3.Text) + Val(tt4.Text) + Val(tt5.Text) + Val(tt6.Text) + Val(tt7.Text) + Val(tt8.Text) + Val(tt9.Text) + Val(tt10.Text) + Val(tt11.Text) + Val(tt12.Text) + Val(tt13.Text) + Val(tt14.Text) + Val(tt15.Text) + Val(tt16.Text) + Val(tt17.Text) + Val(tt18.Text)

                ttsc.Text = System.Convert.ToString(ttxvi)
                ttsc.Text = ttxvi.ToString("N")
                'Average score

                ttxvii = ttxvi / Val(TextBoxSUB.Text)

                Avsc.Text = System.Convert.ToString(ttxvii)
                Avsc.Text = ttxvii.ToString("N")

                'display pane/listbox
                'DataGridView1..Add(namestr.Text & " " & " :" & "TOTAL SCORE :" & ttsc.Text & "," & "AVERAGE SCORE " & ":" & Avsc.Text)

                '  DataGridView1.AllowUserToAddRows = True


                ' DataGridView1.Rows.Add(namestr.Text, n, ttsc.Text, Avsc.Text)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'switching btw clear and reset
        'clear

        'switching btw clear and reset
        'clear

        ex1.Text = ""
                ex2.Text = ""
                ex3.Text = ""
                ex4.Text = ""
                ex5.Text = ""
                ex6.Text = ""
                ex7.Text = ""
                ex8.Text = ""
                ex9.Text = ""
                ex10.Text = ""
                ex11.Text = ""
                ex12.Text = ""
                ex13.Text = ""
                ex14.Text = ""
                ex15.Text = ""
                ex16.Text = ""
                ex17.Text = ""
                ex18.Text = ""
                sca1.Text = ""
                sca2.Text = ""
                sca3.Text = ""
                sca4.Text = ""
                sca5.Text = ""
                sca6.Text = ""
                sca7.Text = ""
                sca8.Text = ""
                sca9.Text = ""
                sca11.Text = ""
                sca10.Text = ""
                sca12.Text = ""
                sca13.Text = ""
                sca14.Text = ""
                sca15.Text = ""
                sca16.Text = ""
                sca17.Text = ""
                sca18.Text = ""

                fca1.Text = ""
                fca3.Text = ""
                fca4.Text = ""
                fca5.Text = ""
                fca6.Text = ""
                fca7.Text = ""
                fca8.Text = ""
                fca9.Text = ""
                fca10.Text = ""
                fca11.Text = ""
                fca12.Text = ""
                fca13.Text = ""
                fca15.Text = ""
                fca14.Text = ""
                fca16.Text = ""
                fca17.Text = ""
                fca18.Text = ""
                fca19.Text = ""
                tt1.Text = ""
                tt2.Text = ""
                tt3.Text = ""

                tt4.Text = ""
                tt5.Text = ""
                tt6.Text = ""
                tt7.Text = ""
                tt8.Text = ""
                tt9.Text = ""
                tt10.Text = ""
                tt11.Text = ""
                tt12.Text = ""
                tt13.Text = ""
                tt14.Text = ""
                tt15.Text = ""
                tt17.Text = ""
                tt16.Text = ""
                tt18.Text = ""
                G1.Text = ""
                G2.Text = ""
                G3.Text = ""
                G4.Text = ""
                G5.Text = ""
                G6.Text = ""
                G8.Text = ""
                G9.Text = ""
                G10.Text = ""
                G11.Text = ""
                G12.Text = ""
                G13.Text = ""
                G14.Text = ""
                G15.Text = ""
                G16.Text = ""
                G17.Text = ""
                G18.Text = ""
                Avsc.Text = ""
                ttsc.Text = ""
                TextBoxSUB.Text = ""


                'resetting the counter loop to zero

                'resetting the counter loop to zero
                n = 0











    End Sub



    ' counter loop to counter and check the number of textbox/subjects selected then the number will be use to divid the total for average
    Private Sub ex1_Leave(sender As Object, e As EventArgs) Handles ex1.TextChanged
        'leave is used to execute code after all action has ended on the control
        n += 1
    End Sub

    Private Sub ex2_Leave(sender As Object, e As EventArgs) Handles ex2.TextChanged
        n += 1
    End Sub

    Private Sub ex3_Leave(sender As Object, e As EventArgs) Handles ex3.TextChanged
        n += 1
    End Sub

    Private Sub ex4_Leave(sender As Object, e As EventArgs) Handles ex4.TextChanged
        n += 1
    End Sub

    Private Sub ex5_Leave(sender As Object, e As EventArgs) Handles ex5.TextChanged
        n += 1
    End Sub

    Private Sub ex6_Leave(sender As Object, e As EventArgs) Handles ex6.TextChanged
        n += 1
    End Sub

    Private Sub ex7_Leave(sender As Object, e As EventArgs) Handles ex7.TextChanged
        n += 1
    End Sub

    Private Sub ex8_Leave(sender As Object, e As EventArgs) Handles ex8.TextChanged
        n += 1
    End Sub

    Private Sub ex9_Leave(sender As Object, e As EventArgs) Handles ex9.TextChanged
        n += 1
    End Sub

    Private Sub ex10_Leave(sender As Object, e As EventArgs) Handles ex10.TextChanged
        n += 1
    End Sub

    Private Sub ex11_Leave(sender As Object, e As EventArgs) Handles ex11.TextChanged
        n += 1
    End Sub

    Private Sub ex12_Leave(sender As Object, e As EventArgs) Handles ex12.TextChanged
        n += 1
    End Sub

    Private Sub ex13_Leave(sender As Object, e As EventArgs) Handles ex13.TextChanged
        n += 1
    End Sub

    Private Sub ex14_Leave(sender As Object, e As EventArgs) Handles ex14.TextChanged
        n += 1
    End Sub

    Private Sub ex15_Leave(sender As Object, e As EventArgs) Handles ex15.TextChanged
        n += 1
    End Sub



    Private Sub ex1_TextChanged_1(sender As Object, e As EventArgs) Handles ex1.TextChanged

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        'Login.Show()
        'Me.Hide()
        Dim READER As MySqlDataReader
        Try
            conndb()

            sql = "select * from subjects"
            cmd = New MySqlCommand(sql, conn)
            READER = cmd.ExecuteReader

            While READER.Read
                Dim sName = READER.GetString("Subjects")
                C1.Items.Add(sName)
                C2.Items.Add(sName)
                C3.Items.Add(sName)
                C4.Items.Add(sName)
                C5.Items.Add(sName)
                C6.Items.Add(sName)
                C7.Items.Add(sName)
                C8.Items.Add(sName)
                C9.Items.Add(sName)
                C10.Items.Add(sName)
                C11.Items.Add(sName)
                C12.Items.Add(sName)
                C13.Items.Add(sName)
                C14.Items.Add(sName)
                C15.Items.Add(sName)
                C16.Items.Add(sName)
                C17.Items.Add(sName)
                C18.Items.Add(sName)

            End While



        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            conn.Dispose()


        End Try




    End Sub

    Private Sub tt1_TextChanged(sender As Object, e As EventArgs)



    End Sub




    'this will connect to the database calculabase and fetch the data and display it on the datagridview1 as stated
    ' to access it we use showresult() anywhere we want to call this function

    Sub showresult()
        conndb()
        cmd = New MySqlCommand("select * from calculabase", conn)
        da = New MySqlDataAdapter(cmd)
        ds = New DataSet
        da.Fill(ds, "calculabase")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "calculabase"
        cmd.Dispose()
        ds.Dispose()
        conn.Close()



    End Sub
    Private Sub save_Click(sender As Object, e As EventArgs) Handles save.Click
        Dim dat As DateTime = DateTimePicker1.Value
        'inserting/saving the record into the database
        ' Try

        If namestr.Text.Trim = "" Or ttsc.Text.Trim = "" Or Avsc.Text.Trim = "" Or TextBoxClass.Text.Trim = "" Then
            MsgBox("Please check that you filled in all the necessary fields e.g NAME, CLASS,TERM, TOTAL SCORE AND THE AVERAGE SCORE of this candidate, before you proceed with SAVING, thanks")




        Else
            Dim buttonset As DialogResult


            buttonset = MessageBox.Show("Are you sure you want to 'Save Record' ? Click 'OK' to Save, 'Cancel' to Continue Computation", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If buttonset = DialogResult.OK Then




                sql = "insert into calculabase(Name,Class,Term,Subjects,FirstCA,SecondCA,ExamScore,TotalScore,Grade,Subjectsii,FirstCAii,SecondCAii,ExamScoreii,TotalScoreii,Gradeii,iiiSubjects,iiiFirstCA,iiiSecondCA,iiiExamScore,iiiTotalScore,iiiGrade,ivSubjects,ivFirstCA,ivSecondCA,ivExamScore,ivTotalScore,ivGrade,vSubjects,vFirstCA,vSecondCA,vExamScore,vTotalScore,vGrade,viSubjects,viFirstCA,viSecondCA,viExamScore,viTotalScore,viGrade,viiSubjects,viiFirstCA,viiSecondCA,viiExamScore,viiTotalScore,viiGrade,viiiSubjects,viiiFirstCA,viiiSecondCA,viiiExamScore,viiiTotalScore,viiiGrade,ixSubjects,ixFirstCA,ixSecondCA,ixExamScore,ixTotalScore,ixGrade,xSubjects,xFirstCA,xSecondCA,xExamScore,xTotalScore,xGrade,xiSubjects,xiFirstCA,xiSecondCA,xiExamScore,xiTotalScore,xiGrade,xiiSubjects,xiiFirstCA,xiiSecondCA,xiiExamScore,xiiTotalScore,xiiGrade,xiiiSubjects,xiiiFirstCA,xiiiSecondCA,xiiiExamScore,xiiiTotalScore,xiiiGrade,
xivSubjects,xivFirstCA,xivSecondCA,xivExamScore,xivTotalScore,xivGrade,xvSubjects,xvFirstCA,xvSecondCA,xvExamScore,
xvTotalScore,xvGrade,`xviSubject`,`xviFirstCA`,`xviSecondCA`,`xviExamScore`,`xviTotalScore`,`xviGrade`,`xviiSubject`,`xviiFirstCA`,`xviiSecondCA`,`xviiExamScore`,`xviiTotalScore`,`xviiGrade`,`xviiiSubject`,`xviiiFirstCA`,`xviiiSecondCA`,
`xviiiExamScore`,`xviiiTotalScore`,`xviiiGrade`, NumberOfSubject,xvGrandScore,xvAverageScore, Date) values('" & namestr.Text & "','" & TextBoxClass.Text & "',
'" & TextBoxTerm.Text & "','" & C1.Text & "','" & fca1.Text & "','" & sca1.Text & "','" & ex1.Text & "','" & tt1.Text & "','" & G1.Text & "','" & C2.Text & "',
'" & fca3.Text & "','" & sca2.Text & "','" & ex2.Text & "','" & tt2.Text & "','" & G2.Text & "','" & C3.Text & "','" & fca4.Text & "','" & sca3.Text & "',
'" & ex3.Text & "','" & tt3.Text & "','" & G3.Text & "','" & C4.Text & "','" & fca5.Text & "','" & sca4.Text & "','" & ex4.Text & "','" & tt4.Text & "',
'" & G4.Text & "','" & C5.Text & "','" & fca6.Text & "','" & sca5.Text & "','" & ex5.Text & "','" & tt5.Text & "','" & G5.Text & "','" & C6.Text & "',
'" & fca7.Text & "','" & sca6.Text & "','" & ex6.Text & "','" & tt6.Text & "','" & G6.Text & "','" & C7.Text & "','" & fca8.Text & "','" & sca7.Text & "',
'" & ex7.Text & "','" & tt7.Text & "','" & G7.Text & "','" & C8.Text & "','" & fca9.Text & "','" & sca8.Text & "','" & ex8.Text & "','" & tt8.Text & "',
'" & G8.Text & "','" & C9.Text & "','" & fca10.Text & "','" & sca9.Text & "','" & ex9.Text & "','" & tt9.Text & "','" & G9.Text & "','" & C10.Text & "',
'" & fca11.Text & "','" & sca10.Text & "','" & ex10.Text & "','" & tt10.Text & "','" & G10.Text & "','" & C11.Text & "','" & fca12.Text & "','" & sca11.Text & "',
'" & ex11.Text & "','" & tt11.Text & "','" & G11.Text & "','" & C12.Text & "','" & fca13.Text & "','" & sca12.Text & "','" & ex12.Text & "','" & tt12.Text & "',
'" & G12.Text & "','" & C13.Text & "','" & fca14.Text & "','" & sca13.Text & "','" & ex13.Text & "','" & tt13.Text & "','" & G13.Text & "','" & C14.Text & "',
'" & fca15.Text & "','" & sca14.Text & "','" & ex14.Text & "','" & tt14.Text & "','" & G14.Text & "','" & C15.Text & "','" & fca16.Text & "','" & sca15.Text & "',
'" & ex15.Text & "','" & tt15.Text & "','" & G15.Text & "','" & C16.Text & "','" & fca17.Text & "','" & sca16.Text & "','" & ex16.Text & "','" & tt16.Text & "','" & G16.Text & "',
'" & C17.Text & "','" & fca18.Text & "','" & sca17.Text & "','" & ex17.Text & "','" & tt17.Text & "','" & G17.Text & "','" & C18.Text & "','" & fca19.Text & "','" & sca18.Text & "','" & ex18.Text & "','" & tt18.Text & "','" & G18.Text & "','" & TextBoxSUB.Text & "','" & ttsc.Text & "','" & Avsc.Text & "','" & dat & "')"


                conndb()

                cmd = New MySqlCommand(sql, conn)
                dr = cmd.ExecuteReader()
                MsgBox("Data inserted successfully")
                cmd.Dispose()
                conn.Close()
                showresult()
                'Me.Controls.Clear()
                ' InitializeComponent()
                ' Form1_Load(e, e)

            End If
        End If


        'Catch ex As Exception
        ' MsgBox(ex.ToString())

        ' Finally


        cmd.Dispose()
        conn.Close()

        ' End Try




    End Sub
    Public Function idExist(ByVal id As String) As Boolean
        'this code check if there is duplicate of Item in the table
        Dim con As New LOGIN_REG_CONNECTION
        Dim table As New DataTable()
        Dim adapter As New MySqlDataAdapter()
        Dim command As New MySqlCommand("SELECT  id FROM `calculabase` WHERE `id` =@id", con.getconnection)
        command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id
        adapter.SelectCommand = command
        adapter.Fill(table)
        If table.Rows.Count <> 1 Then
            Return True
        Else
            Return False

        End If
    End Function





    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub


    'counting increaments

    Private Sub TextBoxsearch_TextChanged(sender As Object, e As EventArgs) Handles TextBoxsearch.TextChanged

    End Sub

    Private Sub TextBoxsearch_Enter(sender As Object, e As EventArgs) Handles TextBoxsearch.Enter
        TextBoxsearch.Text = ""
    End Sub

    Private Sub ButtonLOGOUT_Click(sender As Object, e As EventArgs) Handles ButtonLOGOUT.Click
        Me.Close()

        Login.Show()

    End Sub

    Private Sub TextBoxSUB_Enter(sender As Object, e As EventArgs) Handles TextBoxSUB.Enter
        TextBoxSUB.Text = ""
    End Sub



    Private Bitmap As Bitmap
    Private Sub Buttonprint_Click(sender As Object, e As EventArgs)
        'this will print the datagridview records
        Dim height As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        Bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(Bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = height
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(Bitmap, 0, 0)
        Dim rectprint As RectangleF = e.PageSettings.PrintableArea
        'change the height of to width if printing in landscape mode
        If Me.DataGridView1.Height - rectprint.Height > 0 Then
            e.HasMorePages = True
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub labelsignup_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Register_Form.Show()
    End Sub

    Private Sub GunaButtonSAVE_Click(sender As Object, e As EventArgs)
        SUBJECT_LOADER.Show()
    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        'this will search the database and display result on the datagridview
        'if  function is to sense the value on the combobox in other to know how to search the database
        Try


            Select Case ComboBoxSEARCH.Text
                Case "NAME"

                    conndb()
                    cmd = New MySqlCommand("select * from  `calculabase` where Name like '%" & TextBoxsearch.Text & "%'", conn)
                    da = New MySqlDataAdapter(cmd)
                    ds = New DataSet
                    da.Fill(ds, " `calculabase`")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = " `calculabase`"
                    cmd.Dispose()
                    ds.Dispose()
                    conn.Close()
                'if the ID is selected on the combobox the function will switch to searching the database by Id
                Case "ID"
                    conndb()
                    cmd = New MySqlCommand("select * from  `calculabase` where id like '%" & TextBoxsearch.Text & "%'", conn)
                    da = New MySqlDataAdapter(cmd)
                    ds = New DataSet
                    da.Fill(ds, " `calculabase`")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = " `calculabase`"
                    cmd.Dispose()
                    ds.Dispose()
                    conn.Close()

                'if the CLASS is selected on the combobox the function will switch to searching the database by Class

                Case "CLASS"

                    conndb()
                    cmd = New MySqlCommand("select * from  `calculabase` where Class like  '%" & TextBoxsearch.Text & "%'", conn)
                    da = New MySqlDataAdapter(cmd)
                    ds = New DataSet
                    da.Fill(ds, " `calculabase`")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = " `calculabase`"
                    cmd.Dispose()
                    ds.Dispose()
                    conn.Close()

                'if the TERM is selected on the combobox the function will switch to searching the database by Term
                Case "TERM"
                    conndb()
                    cmd = New MySqlCommand("select * from  `calculabase` where Term like '%" & TextBoxsearch.Text & "%'", conn)
                    da = New MySqlDataAdapter(cmd)
                    ds = New DataSet
                    da.Fill(ds, " `calculabase`")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = " `calculabase`"
                    cmd.Dispose()
                    ds.Dispose()
                    conn.Close()

                'if the DATE is selected on the combobox the function will switch to searching the database by Date
                Case "DATE"
                    conndb()
                    cmd = New MySqlCommand("select * from  `calculabase` where Date like '%" & TextBoxsearch.Text & "%'", conn)
                    da = New MySqlDataAdapter(cmd)
                    ds = New DataSet
                    da.Fill(ds, " `calculabase`")
                    DataGridView1.DataSource = ds
                    DataGridView1.DataMember = " `calculabase`"
                    cmd.Dispose()
                    ds.Dispose()
                    conn.Close()
                Case Else

                    MsgBox("Please Choose  your search Parameter from the ComboBox")

            End Select
        Catch ex As Exception
            MsgBox("AN ERROR OCCURED PLEASE CHECK YOUR SPELLING OR THE PARAMETER SELECTED ON THE COMBOBOX")
        End Try


    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub ex16_TextChanged(sender As Object, e As EventArgs) Handles ex16.TextChanged
        Try

            ttxvi = Val(fca17.Text) + Val(sca16.Text) + Val(ex16.Text)
            tt16.Text = System.Convert.ToString(ttxvi)

            Dim grade As Integer
            grade = Integer.Parse(tt16.Text)

            Select Case grade

                Case <= 39
                    G16.Text = "FAIL:F"
                Case 40 To 49
                    G16.Text = "PASS:P"
                Case 50 To 59
                    G16.Text = "CRED:C"
                Case 60 To 69
                    G16.Text = "GOOD:B"
                Case Is >= 70
                    G16.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ex17_TextChanged(sender As Object, e As EventArgs) Handles ex17.TextChanged
        Try

            ttxvii = Val(fca18.Text) + Val(sca17.Text) + Val(ex17.Text)
            tt17.Text = System.Convert.ToString(ttxvii)

            Dim grade As Integer
            grade = Integer.Parse(tt17.Text)

            Select Case grade

                Case <= 39
                    G17.Text = "FAIL:F"
                Case 40 To 49
                    G17.Text = "PASS:P"
                Case 50 To 59
                    G17.Text = "CRED:C"
                Case 60 To 69
                    G17.Text = "GOOD:B"
                Case Is >= 70
                    G17.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ex18_TextChanged(sender As Object, e As EventArgs) Handles ex18.TextChanged
        Try
            Dim ttxviii As Double
            ttxviii = Val(fca19.Text) + Val(sca18.Text) + Val(ex18.Text)
            tt18.Text = System.Convert.ToString(ttxviii)

            Dim grade As Integer
            grade = Integer.Parse(tt18.Text)

            Select Case grade

                Case <= 39
                    G18.Text = "FAIL:F"
                Case 40 To 49
                    G18.Text = "PASS:P"
                Case 50 To 59
                    G18.Text = "CRED:C"
                Case 60 To 69
                    G18.Text = "GOOD:B"
                Case Is >= 70
                    G18.Text = "EXC:A"
                Case Else
                    MessageBox.Show("An error occurred, please check your enry")


            End Select
        Catch ex As Exception

        End Try
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try


            Dim selectedgr As DataGridViewRow
            selectedgr = DataGridView1.Rows(e.RowIndex)

            namestr.Text = selectedgr.Cells(1).Value.ToString
            TextBoxTerm.Text = selectedgr.Cells(3).Value.ToString
            TextBoxClass.Text = selectedgr.Cells(2).Value.ToString
            C1.Text = selectedgr.Cells(4).Value.ToString
            fca1.Text = selectedgr.Cells(5).Value.ToString
            sca1.Text = selectedgr.Cells(6).Value.ToString
            ex1.Text = selectedgr.Cells(7).Value.ToString
            tt1.Text = selectedgr.Cells(8).Value.ToString
            G1.Text = selectedgr.Cells(9).Value.ToString


            C2.Text = selectedgr.Cells(10).Value.ToString
            fca3.Text = selectedgr.Cells(11).Value.ToString
            sca2.Text = selectedgr.Cells(12).Value.ToString
            ex2.Text = selectedgr.Cells(13).Value.ToString
            tt2.Text = selectedgr.Cells(14).Value.ToString
            G2.Text = selectedgr.Cells(15).Value.ToString


            C3.Text = selectedgr.Cells(16).Value.ToString
            fca4.Text = selectedgr.Cells(17).Value.ToString
            sca3.Text = selectedgr.Cells(18).Value.ToString
            ex3.Text = selectedgr.Cells(19).Value.ToString
            tt3.Text = selectedgr.Cells(20).Value.ToString
            G3.Text = selectedgr.Cells(21).Value.ToString


            C4.Text = selectedgr.Cells(22).Value.ToString
            fca5.Text = selectedgr.Cells(23).Value.ToString
            sca4.Text = selectedgr.Cells(24).Value.ToString
            ex4.Text = selectedgr.Cells(25).Value.ToString
            tt4.Text = selectedgr.Cells(26).Value.ToString
            G4.Text = selectedgr.Cells(27).Value.ToString


            C5.Text = selectedgr.Cells(28).Value.ToString
            fca6.Text = selectedgr.Cells(29).Value.ToString
            sca5.Text = selectedgr.Cells(30).Value.ToString
            ex5.Text = selectedgr.Cells(31).Value.ToString
            tt5.Text = selectedgr.Cells(32).Value.ToString
            G5.Text = selectedgr.Cells(33).Value.ToString


            C6.Text = selectedgr.Cells(34).Value.ToString
            fca7.Text = selectedgr.Cells(35).Value.ToString
            sca6.Text = selectedgr.Cells(36).Value.ToString
            ex6.Text = selectedgr.Cells(37).Value.ToString
            tt6.Text = selectedgr.Cells(38).Value.ToString
            G6.Text = selectedgr.Cells(39).Value.ToString



            C7.Text = selectedgr.Cells(40).Value.ToString
            fca8.Text = selectedgr.Cells(41).Value.ToString
            sca7.Text = selectedgr.Cells(42).Value.ToString
            ex7.Text = selectedgr.Cells(43).Value.ToString
            tt7.Text = selectedgr.Cells(44).Value.ToString
            G7.Text = selectedgr.Cells(45).Value.ToString


            C8.Text = selectedgr.Cells(46).Value.ToString
            fca9.Text = selectedgr.Cells(47).Value.ToString
            sca8.Text = selectedgr.Cells(48).Value.ToString
            ex8.Text = selectedgr.Cells(49).Value.ToString
            tt8.Text = selectedgr.Cells(50).Value.ToString
            G8.Text = selectedgr.Cells(51).Value.ToString


            C9.Text = selectedgr.Cells(52).Value.ToString
            fca10.Text = selectedgr.Cells(53).Value.ToString
            sca9.Text = selectedgr.Cells(54).Value.ToString
            ex9.Text = selectedgr.Cells(55).Value.ToString
            tt9.Text = selectedgr.Cells(56).Value.ToString
            G9.Text = selectedgr.Cells(57).Value.ToString



            C10.Text = selectedgr.Cells(58).Value.ToString
            fca11.Text = selectedgr.Cells(59).Value.ToString
            sca10.Text = selectedgr.Cells(60).Value.ToString
            ex10.Text = selectedgr.Cells(61).Value.ToString
            tt10.Text = selectedgr.Cells(62).Value.ToString
            G10.Text = selectedgr.Cells(63).Value.ToString



            C11.Text = selectedgr.Cells(64).Value.ToString
            fca12.Text = selectedgr.Cells(65).Value.ToString
            sca11.Text = selectedgr.Cells(66).Value.ToString
            ex11.Text = selectedgr.Cells(67).Value.ToString
            tt11.Text = selectedgr.Cells(68).Value.ToString
            G11.Text = selectedgr.Cells(69).Value.ToString


            C12.Text = selectedgr.Cells(70).Value.ToString
            fca13.Text = selectedgr.Cells(71).Value.ToString
            sca12.Text = selectedgr.Cells(72).Value.ToString
            ex12.Text = selectedgr.Cells(73).Value.ToString
            tt12.Text = selectedgr.Cells(74).Value.ToString
            G12.Text = selectedgr.Cells(75).Value.ToString



            C13.Text = selectedgr.Cells(76).Value.ToString
            fca14.Text = selectedgr.Cells(77).Value.ToString
            sca13.Text = selectedgr.Cells(78).Value.ToString
            ex13.Text = selectedgr.Cells(79).Value.ToString
            tt13.Text = selectedgr.Cells(80).Value.ToString
            G13.Text = selectedgr.Cells(81).Value.ToString


            C14.Text = selectedgr.Cells(82).Value.ToString
            fca15.Text = selectedgr.Cells(83).Value.ToString
            sca14.Text = selectedgr.Cells(84).Value.ToString
            ex14.Text = selectedgr.Cells(85).Value.ToString
            tt14.Text = selectedgr.Cells(86).Value.ToString
            G14.Text = selectedgr.Cells(87).Value.ToString


            C15.Text = selectedgr.Cells(88).Value.ToString
            fca16.Text = selectedgr.Cells(89).Value.ToString
            sca15.Text = selectedgr.Cells(90).Value.ToString
            ex15.Text = selectedgr.Cells(91).Value.ToString
            tt15.Text = selectedgr.Cells(92).Value.ToString
            G15.Text = selectedgr.Cells(93).Value.ToString

            ttsc.Text = selectedgr.Cells(95).Value.ToString
            Avsc.Text = selectedgr.Cells(96).Value.ToString
            TextBoxSUB.Text = selectedgr.Cells(94).Value.ToString
            'TextBoxsel.Text = selectedgr.Cells(0).Value.ToString

        Catch ex As Exception
            MsgBox(e)
        End Try
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        showresult()
    End Sub
End Class

