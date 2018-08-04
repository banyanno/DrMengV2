Public Class UCWaitingLabolatory
    Dim DA_Check_Labo As New DS_Invest_LaserTableAdapters.S_PATIENT_LABTableAdapter
    Dim DA_Check_Labo_Detail As New DS_Invest_LaserTableAdapters.S_PATIENT_LABO_DETIALTableAdapter
    Dim DAPatientWait As New DSWaitingConsultTableAdapters.TblPatientsTableAdapter
    Private Sub BtnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRefresh.Click
        GridPatientWaiting.DataSource = DA_Check_Labo.SelectPatientWaitingLabo
    End Sub

    Private Sub GridPatientWaiting_SelectionChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GridPatientWaiting.SelectionChanged
        Try
            PictureBox1.Image = ByteArrayToImage(DAPatientWait.SelectPicture(GridPatientWaiting.GetRow.Cells("PATIENT_NO").Value))
            GridLaboDetail.DataSource = DA_Check_Labo_Detail.SelectDetail(GridPatientWaiting.GetRow.Cells("WAITING_ID").Value)

        Catch ex As Exception
            PictureBox1.Image = Nothing
            GridLaboDetail.DataSource = Nothing
        End Try
    End Sub

    Private Sub GridLaboDetail_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridLaboDetail.RowDoubleClick
        If GridLaboDetail.SelectedItems.Count = 0 Then Exit Sub
        Dim LResult As New LaboResult
        LResult.LblSaveOption.Text = GridLaboDetail.GetRow.Cells("LABO_DETIAL_ID").Value
        LResult.TxtLabo.Text = GridLaboDetail.GetRow.Cells("LABO_NAME").Value
        LResult.TxtLaboResult.Text = GridLaboDetail.GetRow.Cells("LABO_DESCRIPTION").Value
        If LResult.ShowDialog = DialogResult.OK Then
            GridLaboDetail.DataSource = DA_Check_Labo_Detail.SelectDetail(GridPatientWaiting.GetRow.Cells("WAITING_ID").Value)
        End If
    End Sub

    Private Sub UCWaitingLabolatory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridPatientWaiting.DataSource = DA_Check_Labo.SelectPatientWaitingLabo
    End Sub

  
    Private Sub BtnComplete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnComplete.Click
        Try
            If MessageBox.Show("Do you want to save complete labolatory?", "Labo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                If DA_Check_Labo.UpdateCheckStatus(True, Now.Date, USER_NAME, GridPatientWaiting.GetRow.Cells("LAB_ID").Value) = 1 Then
                    GridPatientWaiting.DataSource = DA_Check_Labo.SelectPatientWaitingLabo
                    If GridPatientWaiting.SelectedItems.Count = 0 Then
                        PictureBox1.Image = Nothing
                        GridLaboDetail.DataSource = Nothing
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub RadPNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPNo.CheckedChanged
        TxtFPatientNo.Enabled = True
        TxtPatientName.Enabled = False
        TxtPatientTel.Enabled = False
    End Sub

    Private Sub RadPName_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPName.CheckedChanged
        TxtFPatientNo.Enabled = False
        TxtPatientName.Enabled = True
        TxtPatientTel.Enabled = False
    End Sub

    Private Sub RadPTel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadPTel.CheckedChanged
        TxtFPatientNo.Enabled = False
        TxtPatientName.Enabled = False
        TxtPatientTel.Enabled = True
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        If RadPNo.Checked = True Then
            GridPatientWaiting.DataSource = DA_Check_Labo.SelectByPatientNo(EmptyString(TxtFPatientNo.Text))
        ElseIf RadPName.Checked = True Then
            GridPatientWaiting.DataSource = DA_Check_Labo.SelectPatientByName(TxtPatientName.Text)
        ElseIf RadPTel.Checked = True Then
            GridPatientWaiting.DataSource = DA_Check_Labo.SelectPatientTel(TxtPatientTel.Text)
        End If
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub BtnNewLabo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewLabo.Click
        If GridLaboDetail.SelectedItems.Count = 0 Then Exit Sub
        Dim LResult As New LaboResult
        LResult.LblSaveOption.Text = GridLaboDetail.GetRow.Cells("LABO_DETIAL_ID").Value
        LResult.TxtLabo.Text = GridLaboDetail.GetRow.Cells("LABO_NAME").Value
        LResult.TxtLaboResult.Text = GridLaboDetail.GetRow.Cells("LABO_DESCRIPTION").Value
        If LResult.ShowDialog = DialogResult.OK Then
            GridLaboDetail.DataSource = DA_Check_Labo_Detail.SelectDetail(GridPatientWaiting.GetRow.Cells("WAITING_ID").Value)
        End If
    End Sub
End Class
