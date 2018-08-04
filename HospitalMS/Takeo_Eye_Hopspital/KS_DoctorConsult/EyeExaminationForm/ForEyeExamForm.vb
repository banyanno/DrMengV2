Public Class ForEyeExamForm
    Dim DA_EyeExamination As New DSEyeExamformTableAdapters.EYE_EXAMINATION_FORMTableAdapter
    Dim DA_Patient As New DSConsultHistoryTableAdapters.TblPatientsTableAdapter
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateTextField(PatientID, "", ErrExam) = False Then Exit Sub
        If ValidateTextField(TxtName, "", ErrExam) = False Then Exit Sub
        If ValidateTextField(Gender, "", ErrExam) = False Then Exit Sub
        If LblSaveOption.Text = "0" Then
            If MessageBox.Show("Do you want save new Eye examination form?", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_EyeExamination.InsertEyeExaminationForm( _
                PatientID.Text, TxtName.Text, Gender.Text, DOB.Text, Address.Text, Tell.Text, _
               DistRightEye.Text, DistRightEye.Text, NearRightEye.Text, NearLeftEye.Text, _
                SphereRightEye.Text, SphereLeftEye.Text, CylinderRightEye.Text, CylinderLeftEye.Text, _
                AxisRightEye.Text, AxisLeftEye.Text, AddRightEye.Text, AddLeftEye.Text, SpectacleBoolean.Text, _
                SpectacleRightEye1.Text, SpectacleRightEye2.Text, SpectacleRightEye3.Text, _
                SpectacleRightEye4.Text, SpectacleLeftEye1.Text, SpectacleLeftEye2.Text, SpectacleLeftEye3.Text, _
                SpectacleLeftEye4.Text, ExternalRightEye.Text, ExternalLeftEye.Text, ConjunctivaRightEye.Text, _
                ConjunctivaLeftEye.Text, CornerRightEye.Text, CorneaLeftEye.Text, AnteriorRightEye.Text, AnteriorLeftEye.Text, _
                PupilRightEye.Text, PupilLeftEye.Text, LensRightEye.Text, LensLeftEye.Text, IOPRightEye.Text, IOPLeftEye.Text, _
                MRightEye1.Text, MRightEye2.Text, MRightEye3.Text, MRightEye4.Text, MRightEye5.Text, MRightEye6.Text, MRightEye7.Text, _
                MRightEye8.Text, MLeftEye1.Text, MLeftEye2.Text, MLeftEye3.Text, MLeftEye4.Text, MLeftEye5.Text, _
                MLeftEye6.Text, MLeftEye7.Text, MLeftEye8.Text, VisualRightEye1.Text, VisualRightEye2.Text, VisualRightEye3.Text, _
                VisualRightEye4.Text, VisualLeftEye1.Text, VisualLeftEye2.Text, VisualLeftEye3.Text, VisualLeftEye4.Text, _
                AnteriorRightEye1.Text, AnteriorRightEye2.Text, AnteriorRightEye3.Text, AnteriorRightEye4.Text, _
                AnteriorLeftEye1.Text, AnteriorLeftEye2.Text, AnteriorLeftEye3.Text, AnteriorLeftEye4.Text, Plates.Text, _
                Errors.Text, DiagRightEye.Text, DiagLeftEye.Text, TreatRightEye.Text, TreatLeftEye.Text, Month3.Text, Month6.Text, Month12.Text, _
                Remarks.Text, Now.Date, OpticRightEye.Text, OpticLeftEye.Text, CupRightEye.Text, CupLeftEye.Text, MaculaRightEye.Text, _
                MaculaLeftEye.Text, VesselRightEye.Text, VesselLeftEye.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error save new eye examination form", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            If MessageBox.Show("Do you want to update eye examination?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_EyeExamination.UpdateEyeExam( _
               PatientID.Text, TxtName.Text, Gender.Text, DOB.Text, Address.Text, Tell.Text, _
              DistRightEye.Text, DistRightEye.Text, NearRightEye.Text, NearLeftEye.Text, _
               SphereRightEye.Text, SphereLeftEye.Text, CylinderRightEye.Text, CylinderLeftEye.Text, _
               AxisRightEye.Text, AxisLeftEye.Text, AddRightEye.Text, AddLeftEye.Text, SpectacleBoolean.Text, _
               SpectacleRightEye1.Text, SpectacleRightEye2.Text, SpectacleRightEye3.Text, _
               SpectacleRightEye4.Text, SpectacleLeftEye1.Text, SpectacleLeftEye2.Text, SpectacleLeftEye3.Text, _
               SpectacleLeftEye4.Text, ExternalRightEye.Text, ExternalLeftEye.Text, ConjunctivaRightEye.Text, _
               ConjunctivaLeftEye.Text, CornerRightEye.Text, CorneaLeftEye.Text, AnteriorRightEye.Text, AnteriorLeftEye.Text, _
               PupilRightEye.Text, PupilLeftEye.Text, LensRightEye.Text, LensLeftEye.Text, IOPRightEye.Text, IOPLeftEye.Text, _
               MRightEye1.Text, MRightEye2.Text, MRightEye3.Text, MRightEye4.Text, MRightEye5.Text, MRightEye6.Text, MRightEye7.Text, _
               MRightEye8.Text, MLeftEye1.Text, MLeftEye2.Text, MLeftEye3.Text, MLeftEye4.Text, MLeftEye5.Text, _
               MLeftEye6.Text, MLeftEye7.Text, MLeftEye8.Text, VisualRightEye1.Text, VisualRightEye2.Text, VisualRightEye3.Text, _
               VisualRightEye4.Text, VisualLeftEye1.Text, VisualLeftEye2.Text, VisualLeftEye3.Text, VisualLeftEye4.Text, _
               AnteriorRightEye1.Text, AnteriorRightEye2.Text, AnteriorRightEye3.Text, AnteriorRightEye4.Text, _
               AnteriorLeftEye1.Text, AnteriorLeftEye2.Text, AnteriorLeftEye3.Text, AnteriorLeftEye4.Text, Plates.Text, _
               Errors.Text, DiagRightEye.Text, DiagLeftEye.Text, TreatRightEye.Text, TreatLeftEye.Text, Month3.Text, Month6.Text, Month12.Text, _
               Remarks.Text, Now.Date, OpticRightEye.Text, OpticLeftEye.Text, CupRightEye.Text, CupLeftEye.Text, MaculaRightEye.Text, _
               MaculaLeftEye.Text, VesselRightEye.Text, VesselLeftEye.Text, LblSaveOption.Text) = 1 Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                Else
                    MessageBox.Show("Error update eye examination form", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        FindPatient(EmptyString(PatientID.Text))
    End Sub
    Public Sub FindPatient(ByVal PatientNo As Double)
        Dim tlbPatient As DataTable = DA_Patient.SelectByPatientNo(PatientNo)
        If tlbPatient.Rows.Count <= 0 Then
            MessageBox.Show("Doesn't have patient ID in system. Please check ID's patient again.", "Patient", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TxtName.Text = ""
            Gender.Text = ""
            Tell.Text = ""
            Address.Text = ""
            DOB.Text = ""
        Else
            For Each rows As DataRow In tlbPatient.Rows
                TxtName.Text = rows("NameEng")
                Gender.Text = rows("Sex")
                DOB.Text = rows("Age")
                Tell.Text = rows("Telephone")
                Address.Text = rows("Address")
            Next
        End If
    End Sub

    Private Sub LblSaveOption_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LblSaveOption.Click

    End Sub
End Class