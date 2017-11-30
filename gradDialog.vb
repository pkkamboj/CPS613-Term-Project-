Public Class gradDialog
    Private Sub gradDialog_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ViewProgramButton.Click
        Me.Close()
        MDI.home.Visible = False
        MDI.enroll.MdiParent = MDI
        MDI.enroll.WindowState = FormWindowState.Maximized
        MDI.enroll.Visible = True
    End Sub
End Class