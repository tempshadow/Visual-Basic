Public Class frmCart
    Private Sub ResetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles toolReset.Click
        lstBoxProducts.Items.Clear()
        txtBoxShipping.Text = Nothing
        txtBoxSubtotal.Text = Nothing
        txtBoxTax.Text = Nothing
        txtBoxTotal.Text = Nothing
    End Sub

    Private Sub toolExit_Click(sender As Object, e As EventArgs) Handles toolExit.Click
        Application.Exit()
    End Sub

    Private Sub toolPrint_Click(sender As Object, e As EventArgs) Handles toolPrint.Click, PrintToolStripMenuItem.Click
        frmPrint.ShowDialog()
    End Sub

    Private Sub toolAudio_Click(sender As Object, e As EventArgs) Handles toolAudio.Click, AudioToolStripMenuItem.Click
        frmAudio.ShowDialog()
    End Sub

    Private Sub toolAbout_Click(sender As Object, e As EventArgs) Handles toolAbout.Click
        MessageBox.Show("This is: Shopping Cart." & vbCrLf & "Created by: Nigel Mansell")
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        lstBoxProducts.Items.Remove(lstBoxProducts.SelectedItem)
        Module1.Calculate()
    End Sub
End Class
