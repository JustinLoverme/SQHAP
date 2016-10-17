Public Class Home
    Private Sub btnMaintenance_Click(sender As Object, e As EventArgs) Handles btnMaintenance.Click
        Dim bForm As New frmMaintenance
        bForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnArtist_Click(sender As Object, e As EventArgs) Handles btnArtist.Click
        Dim aForm As New frmArtist
        aForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnArt_Click(sender As Object, e As EventArgs) Handles btnArt.Click
        Dim cForm As New frmArtwork
        cForm.ShowDialog()
        Me.Close()
    End Sub

    Private Sub btnEvents_Click(sender As Object, e As EventArgs) Handles btnEvents.Click
        Dim dForm As New frmEvents
        dForm.ShowDialog()
        Me.Close()
    End Sub
End Class
