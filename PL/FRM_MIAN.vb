Public Class FRM_MIAN
    Private Sub BunifuImageButton1_Click(sender As Object, e As EventArgs) Handles BunifuImageButton1.Click
        Environment.Exit(0)
    End Sub

    Private Sub BunifuImageButton2_Click(sender As Object, e As EventArgs) Handles BunifuImageButton2.Click
        If Me.WindowState = FormWindowState.Normal Then
            Me.WindowState = FormWindowState.Maximized
        Else
            Me.WindowState = FormWindowState.Normal
        End If
    End Sub

    Private Sub BunifuImageButton3_Click(sender As Object, e As EventArgs) Handles BunifuImageButton3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub BunifuImageButton6_Click(sender As Object, e As EventArgs) Handles BunifuImageButton6.Click
        If P_MB.Size.Width = 237 Then
            P_MB.Width = 50
            Button1.RightToLeft = RightToLeft.Yes
            Button2.RightToLeft = RightToLeft.Yes
            Button3.RightToLeft = RightToLeft.Yes
            Button4.RightToLeft = RightToLeft.Yes
            Button5.RightToLeft = RightToLeft.Yes
            Button6.RightToLeft = RightToLeft.Yes
        Else
            P_MB.Width = 237
            Button1.RightToLeft = RightToLeft.No
            Button2.RightToLeft = RightToLeft.No
            Button3.RightToLeft = RightToLeft.No
            Button4.RightToLeft = RightToLeft.No
            Button5.RightToLeft = RightToLeft.No
            Button6.RightToLeft = RightToLeft.No
        End If
    End Sub

End Class