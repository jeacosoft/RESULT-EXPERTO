Public Class flash
    Dim value As Integer = 50
    Private Sub flash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Hide()

        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If value = 600 Then
            Timer1.Stop()

            Admin_Log.Show()
            Me.Hide()

        Else
            value += 5

        End If

        If value = 80 Then
            Label1.Show()
        ElseIf value = 160 Then
            Label1.Hide()
            Label2.Visible = True
        ElseIf value = 240 Then
            Label1.Hide()
            Label2.Hide()
            Label3.Show()
        ElseIf value = 320 Then
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            Label4.Show()

        ElseIf value = 400 Then
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            Label4.Hide()

            Label5.Show()

        ElseIf value = 480 Then
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            Label4.Hide()

            Label5.Hide()

            Label6.Show()
        ElseIf value = 560 Then
            Label1.Hide()
            Label2.Hide()
            Label3.Hide()
            Label4.Hide()

            Label5.Hide()

            Label6.Hide()
            Label7.Show()


        End If
    End Sub
End Class