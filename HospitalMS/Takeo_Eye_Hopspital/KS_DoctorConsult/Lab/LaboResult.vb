Public Class LaboResult
    Dim DA_UpdateResult As New DS_Invest_LaserTableAdapters.S_PATIENT_LABO_DETIALTableAdapter
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MessageBox.Show("Do you update result of labo?", "Labo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_UpdateResult.UpdateResult(TxtLaboResult.Text, LblSaveOption.Text) = 1 Then
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class