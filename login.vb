Public Class login
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Enter_Click(sender As Object, e As EventArgs) Handles Enter.Click
        Dim err As New err
        Dim home As New pageHome
        If Masked1.Text = "" Then
            err.ShowDialog()

        ElseIf Username.Text = "" Then
            err.ShowDialog()

        End If

        If Masked1.Text <> "" And Username.Text <> "" Then
            home.nam = Me.Username.Text
            MDI.user = Me.Username.Text
            Me.Close()
            home.MdiParent = MDI
            home.Show()
        End If
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class