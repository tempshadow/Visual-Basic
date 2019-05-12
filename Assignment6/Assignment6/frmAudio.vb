Public Class frmAudio
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Module1.Add()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Module1.Close()
    End Sub
End Class