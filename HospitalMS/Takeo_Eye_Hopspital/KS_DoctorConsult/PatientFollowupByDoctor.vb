Public Class PatientFollowupByDoctor
    Dim DA_HistoryFollowUp As New DSConsultHistoryTableAdapters.S_FOLLOWUPTableAdapter
    Dim DA_USER As New DSUserManagementTableAdapters.VUsersInGroupTableAdapter
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click
        GridFollowUp.DataSource = DA_HistoryFollowUp.SelectPatientFollowByToday(EmptyString(CboDoctor.SelectedValue), DateFrom.Value.Date, DateTo.Value.Date)
    End Sub

    Private Sub PatientFollowupByDoctor_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        With CboDoctor
            .DataSource = DA_USER.GetDataUserByGroup(36)
            .ValueMember = "UserID"
            .DisplayMember = "UserName"
            .SelectedIndex = -1
        End With

    End Sub
End Class