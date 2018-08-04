Public Class NoteWaiting

    Dim DAPatientWaiting As New DSWaitingConsultTableAdapters.S_PATIENT_WAITINGTableAdapter
    Dim DA_VA As New DSWaitingConsultTableAdapters.S_VISUAL_ACUITYTableAdapter
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If MessageBox.Show("Do you want to send  patient to waiting list?", "Waiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            If DAPatientWaiting.InsertNewWaiting(LblPatientNo.Text, 0, TxtNote.Text, "2", GetDateServer.Date, "1") = 1 Then
                DA_VA.InsertNewVA(LblPatientNo.Text, DAPatientWaiting.SelectMaxWaitID, Now.Date, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                'If DAFollowUP.UpdateStatus(2, GridFollowUp.GetRow.Cells("FOLLOW_ID").Value) = 1 Then
                '    ViewPatientFollowUpByDate(DateFollowUp.Value.Date)
                'End If
                MessageBox.Show("Sucessfully sent to waiting list.", "Send", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
        End If
    End Sub
    Dim DA_USER As New DSUserManagementTableAdapters.VUsersInGroupTableAdapter
    Private Sub NoteWaiting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim tblDoctor As DataTable = DA_USER.GetDataUserByGroup(36)
        For Each rows As DataRow In tblDoctor.Rows
            AutoDotor.AddItem(rows("UserName"))
        Next
    End Sub
End Class