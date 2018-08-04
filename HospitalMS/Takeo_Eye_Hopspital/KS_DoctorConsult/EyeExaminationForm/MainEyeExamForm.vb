Public Class MainEyeExamForm
    Dim DA_EyeExam As New DSEyeExamformTableAdapters.EYE_EXAMINATION_FORMTableAdapter

    Private Sub MainEyeExamForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        GridExEyeExam.DataSource = DA_EyeExam.GetData
    End Sub

    Private Sub BtnPrintForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintForm.Click
        Dim CREyeExam As New CRVEyeExaminationForm
        Dim tblExam As DataTable = DA_EyeExam.GetData
        CREyeExam.SetDataSource(tblExam)
        Me.CrystalReportViewer1.ReportSource = CREyeExam
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Dim EyeExam As New ForEyeExamForm
        EyeExam.ShowDialog()
    End Sub

    Private Sub BtnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdate.Click
        Dim EyeExam As New ForEyeExamForm
        EyeExam.LblSaveOption.Text = GridExEyeExam.GetRow.Cells("EXAM_ID").Value
        EyeExam.PatientID.Text = GridExEyeExam.GetRow.Cells("PATIENT_NUMBER").Value
        EyeExam.TxtName.Text = GridExEyeExam.GetRow.Cells("Name").Value
        EyeExam.Gender.Text = GridExEyeExam.GetRow.Cells("Gender").Value
        EyeExam.DOB.Text = GridExEyeExam.GetRow.Cells("DOB").Value
        EyeExam.Address.Text = GridExEyeExam.GetRow.Cells("Address").Value
        EyeExam.Tell.Text = GridExEyeExam.GetRow.Cells("TEL").Value
        EyeExam.DistRightEye.Text = GridExEyeExam.GetRow.Cells("DIST_RIGHT_EYE").Value
        EyeExam.DistLeftEye.Text = GridExEyeExam.GetRow.Cells("DIST_LEFT_EYE").Value
        EyeExam.NearRightEye.Text = GridExEyeExam.GetRow.Cells("NEAR_RIGHT_EYE").Value
        EyeExam.NearLeftEye.Text = GridExEyeExam.GetRow.Cells("NEAR_LEFT_EYE").Value
        EyeExam.SphereRightEye.Text = GridExEyeExam.GetRow.Cells("SPHERE_RIGHT_EYE").Value
        EyeExam.SphereLeftEye.Text = GridExEyeExam.GetRow.Cells("SPHERE_LEFT_EYE").Value
        EyeExam.CylinderRightEye.Text = GridExEyeExam.GetRow.Cells("CYLINDER_RIGHT_EYE").Value
        EyeExam.CylinderLeftEye.Text = GridExEyeExam.GetRow.Cells("CYLINDER_LEFT_EYE").Value
        EyeExam.AxisRightEye.Text = GridExEyeExam.GetRow.Cells("AXIS_RIGHT_EYE").Value
        EyeExam.AxisLeftEye.Text = GridExEyeExam.GetRow.Cells("AXIS_LEFT_EYE").Value
        EyeExam.AddRightEye.Text = GridExEyeExam.GetRow.Cells("ADD_RIGHT_EYE").Value
        EyeExam.AddLeftEye.Text = GridExEyeExam.GetRow.Cells("ADD_LEFT_EYE").Value
        EyeExam.SpectacleBoolean.Text = GridExEyeExam.GetRow.Cells("SpectacleBoolean").Value
        EyeExam.SpectacleRightEye1.Text = GridExEyeExam.GetRow.Cells("SPECTACLE_RIGHT_EYE1").Value
        EyeExam.SpectacleRightEye2.Text = GridExEyeExam.GetRow.Cells("SPECTACLE_RIGHT_EYE2").Value
        EyeExam.SpectacleRightEye3.Text = GridExEyeExam.GetRow.Cells("SPECTACLE_RIGHT_EYE3").Value
        EyeExam.SpectacleRightEye4.Text = GridExEyeExam.GetRow.Cells("SPECTACLE_RIGHT_EYE4").Value
        EyeExam.SpectacleLeftEye1.Text = GridExEyeExam.GetRow.Cells("SPECTACLE_LEFT_EYE1").Value
        EyeExam.SpectacleLeftEye2.Text = GridExEyeExam.GetRow.Cells("SPECTACLE_LEFT_EYE2").Value
        EyeExam.SpectacleLeftEye3.Text = GridExEyeExam.GetRow.Cells("SPECTACLE_LEFT_EYE3").Value
        EyeExam.SpectacleLeftEye4.Text = GridExEyeExam.GetRow.Cells("SPECTACLE_LEFT_EYE4").Value
        EyeExam.ExternalRightEye.Text = GridExEyeExam.GetRow.Cells("EXTERNAL_RIGHT_EYE").Value
        EyeExam.ExternalLeftEye.Text = GridExEyeExam.GetRow.Cells("EXTERNAL_LEFT_EYE").Value
        EyeExam.ConjunctivaRightEye.Text = GridExEyeExam.GetRow.Cells("CONJUNCTIVA_RIGHT_EYE").Value
        EyeExam.ConjunctivaLeftEye.Text = GridExEyeExam.GetRow.Cells("CONJUNCTIVA_LEFT_EYE").Value
        EyeExam.CornerRightEye.Text = GridExEyeExam.GetRow.Cells("CORNER_RIGHT_EYE").Value
        EyeExam.CorneaLeftEye.Text = GridExEyeExam.GetRow.Cells("CORNER_LEFT_EYE").Value
        EyeExam.AnteriorRightEye.Text = GridExEyeExam.GetRow.Cells("ANTERIOR_RIGHT_EYE").Value
        EyeExam.AnteriorLeftEye.Text = GridExEyeExam.GetRow.Cells("ANTERIOR_LEFT_EYE").Value
        EyeExam.PupilRightEye.Text = GridExEyeExam.GetRow.Cells("PUPIL_RIGHT_EYE").Value
        EyeExam.PupilLeftEye.Text = GridExEyeExam.GetRow.Cells("PUPIL_LEFT_EYE").Value
        EyeExam.LensRightEye.Text = GridExEyeExam.GetRow.Cells("LENS_RIGHT_EYE").Value
        EyeExam.LensLeftEye.Text = GridExEyeExam.GetRow.Cells("LENS_LEFT_EYE").Value
        EyeExam.IOPRightEye.Text = GridExEyeExam.GetRow.Cells("IOP_RIGHT_EYE").Value
        EyeExam.IOPLeftEye.Text = GridExEyeExam.GetRow.Cells("IOP_LEFT_EYE").Value
        EyeExam.MRightEye1.Text = GridExEyeExam.GetRow.Cells("M_RIGHT_EYE1").Value
        EyeExam.MRightEye2.Text = GridExEyeExam.GetRow.Cells("M_RIGHT_EYE2").Value
        EyeExam.MRightEye3.Text = GridExEyeExam.GetRow.Cells("M_RIGHT_EYE3").Value
        EyeExam.MRightEye4.Text = GridExEyeExam.GetRow.Cells("M_RIGHT_EYE4").Value
        EyeExam.MRightEye5.Text = GridExEyeExam.GetRow.Cells("M_RIGHT_EYE5").Value
        EyeExam.MRightEye6.Text = GridExEyeExam.GetRow.Cells("M_RIGHT_EYE6").Value
        EyeExam.MRightEye7.Text = GridExEyeExam.GetRow.Cells("M_RIGHT_EYE7").Value
        EyeExam.MRightEye8.Text = GridExEyeExam.GetRow.Cells("M_RIGHT_EYE8").Value
        EyeExam.MLeftEye1.Text = GridExEyeExam.GetRow.Cells("M_LEFT_EYE1").Value
        EyeExam.MLeftEye2.Text = GridExEyeExam.GetRow.Cells("M_LEFT_EYE2").Value
        EyeExam.MLeftEye3.Text = GridExEyeExam.GetRow.Cells("M_LEFT_EYE3").Value
        EyeExam.MLeftEye4.Text = GridExEyeExam.GetRow.Cells("M_LEFT_EYE4").Value
        EyeExam.MLeftEye5.Text = GridExEyeExam.GetRow.Cells("M_LEFT_EYE5").Value
        EyeExam.MLeftEye6.Text = GridExEyeExam.GetRow.Cells("M_LEFT_EYE6").Value
        EyeExam.MLeftEye7.Text = GridExEyeExam.GetRow.Cells("M_LEFT_EYE7").Value
        EyeExam.MLeftEye8.Text = GridExEyeExam.GetRow.Cells("M_LEFT_EYE8").Value
        EyeExam.VisualRightEye1.Text = GridExEyeExam.GetRow.Cells("VISUAL_RIGHT_EYE1").Value
        EyeExam.VisualRightEye2.Text = GridExEyeExam.GetRow.Cells("VISUAL_RIGHT_EYE2").Value
        EyeExam.VisualRightEye3.Text = GridExEyeExam.GetRow.Cells("VISUAL_RIGHT_EYE3").Value
        EyeExam.VisualRightEye4.Text = GridExEyeExam.GetRow.Cells("VISUAL_RIGHT_EYE4").Value
        EyeExam.VisualLeftEye1.Text = GridExEyeExam.GetRow.Cells("VISUAL_LEFT_EYE1").Value
        EyeExam.VisualLeftEye2.Text = GridExEyeExam.GetRow.Cells("VISUAL_LEFT_EYE2").Value
        EyeExam.VisualLeftEye3.Text = GridExEyeExam.GetRow.Cells("VISUAL_LEFT_EYE3").Value
        EyeExam.VisualLeftEye4.Text = GridExEyeExam.GetRow.Cells("VISUAL_LEFT_EYE4").Value
        EyeExam.AnteriorRightEye1.Text = GridExEyeExam.GetRow.Cells("ANTERIOR_RIGHT_EYE1").Value
        EyeExam.AnteriorRightEye2.Text = GridExEyeExam.GetRow.Cells("ANTERIOR_RIGHT_EYE2").Value
        EyeExam.AnteriorRightEye3.Text = GridExEyeExam.GetRow.Cells("ANTERIOR_RIGHT_EYE3").Value
        EyeExam.AnteriorRightEye4.Text = GridExEyeExam.GetRow.Cells("ANTERIOR_RIGHT_EYE4").Value
        EyeExam.AnteriorLeftEye1.Text = GridExEyeExam.GetRow.Cells("ANTERIOR_LEFT_EYE1").Value
        EyeExam.AnteriorLeftEye2.Text = GridExEyeExam.GetRow.Cells("ANTERIOR_LEFT_EYE2").Value
        EyeExam.AnteriorLeftEye3.Text = GridExEyeExam.GetRow.Cells("ANTERIOR_LEFT_EYE3").Value
        EyeExam.AnteriorLeftEye4.Text = GridExEyeExam.GetRow.Cells("ANTERIOR_LEFT_EYE4").Value
        EyeExam.Plates.Text = GridExEyeExam.GetRow.Cells("PLATE").Value
        EyeExam.Errors.Text = GridExEyeExam.GetRow.Cells("Errors").Value
        EyeExam.OpticRightEye.Text = GridExEyeExam.GetRow.Cells("OPTIC_RIGHT_EYE").Value
        EyeExam.OpticLeftEye.Text = GridExEyeExam.GetRow.Cells("OPTIC_LEFT_EYE").Value
        EyeExam.CupRightEye.Text = GridExEyeExam.GetRow.Cells("CUP_RIGHT_EYE").Value
        EyeExam.CupLeftEye.Text = GridExEyeExam.GetRow.Cells("CUB_LEFT_EYE").Value
        EyeExam.MaculaRightEye.Text = GridExEyeExam.GetRow.Cells("MACULA_RIGHT_EYE").Value
        EyeExam.MaculaLeftEye.Text = GridExEyeExam.GetRow.Cells("MACULA_LEFT_EYE").Value
        EyeExam.VesselRightEye.Text = GridExEyeExam.GetRow.Cells("VESSELS_RIGHT_EYE").Value
        EyeExam.VesselLeftEye.Text = GridExEyeExam.GetRow.Cells("VESSELS_LEFT_EYE").Value
        EyeExam.DiagRightEye.Text = GridExEyeExam.GetRow.Cells("DIAG_RIGHT_EYE").Value
        EyeExam.DiagLeftEye.Text = GridExEyeExam.GetRow.Cells("DIAG_LEFT_EYE").Value
        EyeExam.TreatRightEye.Text = GridExEyeExam.GetRow.Cells("TREAT_RIGHT_EYE").Value
        EyeExam.TreatLeftEye.Text = GridExEyeExam.GetRow.Cells("TREAT_LEFT_EYE").Value
        EyeExam.Month3.Text = GridExEyeExam.GetRow.Cells("Month3").Value
        EyeExam.Month6.Text = GridExEyeExam.GetRow.Cells("Month6").Value
        EyeExam.Month12.Text = GridExEyeExam.GetRow.Cells("Month12").Value
        EyeExam.Remarks.Text = GridExEyeExam.GetRow.Cells("Remarks").Value
        If EyeExam.ShowDialog() = DialogResult.OK Then
            GridExEyeExam.DataSource = DA_EyeExam.SelectByID(EyeExam.LblSaveOption.Text)
        End If
    End Sub

    Private Sub BtnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFind.Click
        GridExEyeExam.DataSource = DA_EyeExam.GetData
    End Sub
End Class
