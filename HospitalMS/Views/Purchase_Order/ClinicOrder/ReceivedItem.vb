Public Class ReceivedItem

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim FReceiveMedicine As New ForReceiveOrder
        FReceiveMedicine.ShowDialog()
    End Sub
End Class
