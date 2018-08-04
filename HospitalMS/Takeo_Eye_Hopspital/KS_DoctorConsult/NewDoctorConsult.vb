Imports CrystalDecisions.Shared

Public Class NewDoctorConsult

    Dim DA_Diagnosis As New DSWaitingConsultTableAdapters.TblSurgeryTableAdapter
    Dim DA_SurgeryService As New DSWaitingConsultTableAdapters.tblDiagSurgeriesTableAdapter
    Dim DA_Doctor As New DSWaitingConsultTableAdapters.TblDoctorTableAdapter
    Dim DA_Consult As New DSWaitingConsultTableAdapters.S_PATIENT_CONSULTTableAdapter
    Dim DA_FollowUp As New DSWaitingConsultTableAdapters.S_PATIENT_FOLLOWUPTableAdapter
    Public DA_ImageDiagnosis As New DSWaitingConsultTableAdapters.S_IMAGE_DIAGNOSISTableAdapter
    Dim DA_Waiting As New DSWaitingConsultTableAdapters.S_PATIENT_WAITINGTableAdapter
    'Data Investigate 
    Dim DA_TemConsult As New DS_KSPAYMENTTableAdapters.S_TEM_LISTPAYMENTTableAdapter
    Dim DA_LASER_CONSULT As New DS_Invest_LaserTableAdapters.S_LASER_CONSULTTableAdapter
    Dim DA_INVESTIGATE_CONSULT As New DS_Invest_LaserTableAdapters.S_INVESTIGATE_CONSULTTableAdapter
    Dim DA_LABORATE_CONSULT As New DS_Invest_LaserTableAdapters.S_LABORATE_CONSULTTableAdapter


    Dim DA_New_OldPatientBook As New DSConsultHistoryTableAdapters.TblNew_Old_OutPatientTableAdapter
    Dim DA_New_Operation As New DSConsultHistoryTableAdapters.TblNewInPatientTableAdapter
    Dim DA_DoctorConsult As New DSConsultHistoryTableAdapters.S_DOCTOR_CONSULTTableAdapter
    Dim DA_USER As New DSUserManagementTableAdapters.VUsersInGroupTableAdapter
    Dim DA_Patient As New DSDashboardPatientTableAdapters.TblPatientsTableAdapter

    Dim DA_VA As New DSWaitingConsultTableAdapters.S_VISUAL_ACUITYTableAdapter
    Dim DA_PrePrescription As New DSConsultHistoryTableAdapters.S_PRESCRIPTION_PRETableAdapter

    Dim DA_MedicineService As New DS_KSPAYMENTTableAdapters.S_TEM_LISTMEDICINE_PAYMENTTableAdapter

    Dim DA_PresciptionV1 As New DSConsultHistoryTableAdapters.S_PRESCRIPTIONA1TableAdapter

    Private ItemPrice As New DSItemPriceTableAdapters.tblItemPriceTableAdapter


    Dim DA_ConsultFee As New DSWaitingConsultTableAdapters.tblDiagSurgeriesTableAdapter

    Public IS_UPDATE_CONSULT As Boolean = False
    Dim IS_HAVE_Presc As Boolean = False
    Dim DA_Prescription As New DS_KSPAYMENTTableAdapters.V_EYE_PRESCRIPTIONTableAdapter
    Dim DA_Item As New DSConsultHistoryTableAdapters.tblItemTableAdapter
    Dim DA_Ordinance As New DSOrdinanceTableAdapters.S_ORDINANCETableAdapter
    Dim DA_Duration As New DSOrdinanceTableAdapters.S_DURATIONTableAdapter
    Dim DA_Usage As New DSOrdinanceTableAdapters.S_USINAGETableAdapter
    Dim DA_Laser As New DS_Invest_LaserTableAdapters.S_LASERTableAdapter
    Dim DA_Invest As New DS_Invest_LaserTableAdapters.S_INVESTIGATETableAdapter
    Dim DA_Labo As New DS_Invest_LaserTableAdapters.S_LABORATORYTableAdapter
    Dim DA_Lab_check As New DS_Invest_LaserTableAdapters.S_PATIENT_LABTableAdapter
    Dim DA_Lab_Check_Detail As New DS_Invest_LaserTableAdapters.S_PATIENT_LABO_DETIALTableAdapter
    Public IS_CLOSE = False
    Dim WAITING_NO As Double
    Dim DRConsult As DashboardDoctorConsult
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim tblDiagnosis As DataTable = DA_Diagnosis.GetData
        For Each rows As DataRow In tblDiagnosis.Rows
            AutoDiagnosis.AddItem(rows("Surgery"))
        Next

     
        'With CboDiagnosis
        '    '.DataSource = DA_Diagnosis.GetData
        '    '.ValueMember = "SID"
        '    '.DisplayMember = "Surgery"
        '    '.SelectedIndex = -1
        'End With

        With CboDoctorConsult
            .DataSource = DA_USER.GetDataUserByGroup(36)
            .ValueMember = "UserID"
            .DisplayMember = "UserName"
            .SelectedIndex = -1
        End With
        With CboSurgery
            .DataSource = DA_SurgeryService.GetData
            .ValueMember = "SID"
            .DisplayMember = "Surgeries"
            .SelectedIndex = -1
        End With
        'Fill data into Auto 
        'Dim tblItem As DataTable = DA_Item.GetData
        'For Each rows As DataRow In tblItem.Rows
        '    AutoMedication.AddItem(rows("ItemName"))
        'Next
        TxtPriceSurgery.Text = "0"
        ' Add any initialization after the InitializeComponent() call.
        With cbomedicine
            .DataSource = DA_Item.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With

        With txtdosage
            .DataSource = DA_Ordinance.GetData
            .ValueMember = "ORDERNONG_ID"
            .DisplayMember = "LABEL_ORDERNONG"
            .SelectedIndex = -1
        End With

        With TxtUsage
            .DataSource = DA_Usage.GetData
            .ValueMember = "USING_ID"
            .DisplayMember = "USING_LABEL"
            .SelectedIndex = -1
        End With
        With CboDuration
            .DataSource = DA_Duration.GetData
            .ValueMember = "DURATION_ID"
            .DisplayMember = "DURATION"
            .SelectedIndex = -1
        End With
        With CboExamFee
            .DataSource = DA_SurgeryService.SelectExamFee
            .ValueMember = "SurgeriesFee"
            .DisplayMember = "Surgeries"
            .SelectedIndex = -1
        End With
       
        With CboLaser
            .DataSource = DA_Laser.GetData
            .ValueMember = "LASER_ID"
            .DisplayMember = "LASER_NAME"
            .SelectedIndex = -1
        End With
        MchLaser.Items.Clear()
        For Each rowLaser As DataRow In DA_Laser.GetData
            MchLaser.Items.Add(rowLaser("LASER_NAME"))
        Next
        MchLaborate.Items.Clear()
        For Each rowLabo As DataRow In DA_Labo.GetData
            MchLaborate.Items.Add(rowLabo("LABO_NAME"))
        Next
        With cboInvestigate
            .DataSource = DA_Invest.GetData
            .ValueMember = "INVES_ID"
            .DisplayMember = "INVEST_NAME"
            .SelectedIndex = -1
        End With
        MChInvestigate.Items.Clear()
        For Each row As DataRow In DA_Invest.GetData
            MChInvestigate.Items.Add(row("INVEST_NAME"))
        Next


        ' Surgery Registration
        Try
            With CboSurgeon
                .DataSource = ModDoctor.SelectDoctor()
                .DisplayMember = "DoctorName"
                .ValueMember = "doctorNo"
                .Text = Nothing
            End With
            With TxtCirculation
                .DataSource = ModDoctor.SelectDoctor()
                .DisplayMember = "DoctorName"
                .ValueMember = "doctorNo"
                .Text = Nothing
            End With
            With CboAssistant
                .DataSource = ModDoctor.SelectDoctor()
                .DisplayMember = "DoctorName"
                .ValueMember = "doctorNo"
                .Text = Nothing
            End With
            With CboAnesthetist
                .DataSource = ModDoctor.SelectDoctor
                .DisplayMember = "DoctorName"
                .ValueMember = "DoctorNo"
                .Text = Nothing
            End With


        Catch ex As Exception

        End Try
    End Sub
    Sub New(ByVal DRConsult As DashboardDoctorConsult)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        Me.DRConsult = DRConsult
        Dim tblDiagnosis As DataTable = DA_Diagnosis.GetData
        For Each rows As DataRow In tblDiagnosis.Rows
            AutoDiagnosis.AddItem(rows("Surgery"))
        Next

     
        With CboDoctorConsult
            .DataSource = DA_USER.GetDataUserByGroup(36)
            .ValueMember = "UserID"
            .DisplayMember = "UserName"
            .SelectedIndex = -1
        End With
        With CboSurgery
            .DataSource = DA_SurgeryService.GetData
            .ValueMember = "SID"
            .DisplayMember = "Surgeries"
            .SelectedIndex = -1
        End With
        'Fill data into Auto 
        'Dim tblItem As DataTable = DA_Item.GetData
        'For Each rows As DataRow In tblItem.Rows
        '    AutoMedication.AddItem(rows("ItemName"))
        'Next
        TxtPriceSurgery.Text = "0"
        ' Add any initialization after the InitializeComponent() call.
        With cbomedicine
            .DataSource = DA_Item.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With

        With txtdosage
            .DataSource = DA_Ordinance.GetData
            .ValueMember = "ORDERNONG_ID"
            .DisplayMember = "LABEL_ORDERNONG"
            .SelectedIndex = -1
        End With

        With TxtUsage
            .DataSource = DA_Usage.GetData
            .ValueMember = "USING_ID"
            .DisplayMember = "USING_LABEL"
            .SelectedIndex = -1
        End With

        With CboExamFee
            .DataSource = DA_SurgeryService.SelectExamFee
            .ValueMember = "SurgeriesFee"
            .DisplayMember = "Surgeries"
            .SelectedIndex = -1
        End With
        With CboDuration
            .DataSource = DA_Duration.GetData
            .ValueMember = "DURATION_ID"
            .DisplayMember = "DURATION"
            .SelectedIndex = -1
        End With
        With CboLaser
            .DataSource = DA_Laser.GetData
            .ValueMember = "LASER_ID"
            .DisplayMember = "LASER_NAME"
            .SelectedIndex = -1
        End With
        MchLaser.Items.Clear()
        For Each rowLaser As DataRow In DA_Laser.GetData
            MchLaser.Items.Add(rowLaser("LASER_NAME"))
        Next
        With cboInvestigate
            .DataSource = DA_Invest.GetData
            .ValueMember = "INVES_ID"
            .DisplayMember = "INVEST_NAME"
            .SelectedIndex = -1
        End With
        MChInvestigate.Items.Clear()
        For Each row As DataRow In DA_Invest.GetData
            MChInvestigate.Items.Add(row("INVEST_NAME"))
        Next
        MchLaborate.Items.Clear()
        For Each rowLabo As DataRow In DA_Labo.GetData
            MchLaborate.Items.Add(rowLabo("LABO_NAME"))
        Next
        ' Surgery Registration
        Try
            With CboSurgeon
                .DataSource = ModDoctor.SelectDoctor()
                .DisplayMember = "DoctorName"
                .ValueMember = "doctorNo"
                .Text = Nothing
            End With
            With TxtCirculation
                .DataSource = ModDoctor.SelectDoctor()
                .DisplayMember = "DoctorName"
                .ValueMember = "doctorNo"
                .Text = Nothing
            End With
            With CboAssistant
                .DataSource = ModDoctor.SelectDoctor()
                .DisplayMember = "DoctorName"
                .ValueMember = "doctorNo"
                .Text = Nothing
            End With
            With CboAnesthetist
                .DataSource = ModDoctor.SelectDoctor
                .DisplayMember = "DoctorName"
                .ValueMember = "DoctorNo"
                .Text = Nothing
            End With


        Catch ex As Exception

        End Try
    End Sub
    Function CheckStatusReferal(ByVal GroupB As GroupBox) As Boolean
        For Each obj As Object In GroupB.Controls
            If TypeOf obj Is RadioButton Then
                Dim rd As RadioButton = CType(obj, RadioButton)
                If rd.Checked = True Then
                    Return True
                    Exit For
                End If
            End If
        Next
    End Function
    Function CheckMInvestigate(ByVal chM As CheckedListBox) As Boolean
        'Dim ItemCheck As Object
        'For Each ItemCheck In chM.CheckedItems

        'Next
        'MsgBox(chM.CheckedItems(chM.SelectedIndex).ToString)
        'MessageBox.Show()

        For Each indexCheck As Integer In chM.CheckedIndices
            ' MessageBox.Show(indexCheck)
            If indexCheck >= 0 Then
                Return True
                Exit For
            End If
        Next
    End Function
    Private Sub BtnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClose.Click
        DA_Waiting.UpdateDoctorConsulting(False, LblWaitingNo.Text)
        DA_ImageDiagnosis.DeleteImageByWaitingID(LblWaitingNo.Text)
        DA_PrePrescription.DeletePreWaiting(CInt(LblWaitingNo.Text))
        Me.Close()
        Me.Dispose()
    End Sub

    'Private Sub CboDiagnosis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    Try
    '        TxtDiagnosisCode.Text = DA_Diagnosis.SelectDiagnosisCode(CboDiagnosis.SelectedValue)
    '    Catch ex As Exception

    '    End Try
    'End Sub

    Dim CrDiskFileDestinationOptionsBig1 As New DiskFileDestinationOptions()
    Dim CrFormatTypeOptionsBig1 As New PdfRtfWordFormatOptions()
    Dim VReportPrescrip As New PrintPrescription
    Dim ViewPrescrip As New CrpPrescription

    Private Sub ViewPatientPrescrip()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf ViewPatientPrescrip))
        Else
            Dim TblPrescription As DataTable = DA_Prescription.SelectPrescriptionWaitingID(WAITING_NO)
            Dim tblFollowUp As DataTable = DA_FollowUp.SelectPFollowupByWaitingID(WAITING_NO)
            Dim CrExportOptionsBig1 As ExportOptions
            ViewPrescrip.SetDataSource(TblPrescription)
            ViewPrescrip.Subreports("PatientFollowup").SetDataSource(tblFollowUp)
            CrDiskFileDestinationOptionsBig1.DiskFileName = My.Application.Info.DirectoryPath & "\Prescription.pdf"
            CrExportOptionsBig1 = ViewPrescrip.ExportOptions
            With CrExportOptionsBig1
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptionsBig1
                .FormatOptions = CrFormatTypeOptionsBig1
            End With
            ViewPrescrip.Export()
            Application.DoEvents()
            Application.DoEvents()
            VReportPrescrip.AxAcroPDFPrescription.src = My.Application.Info.DirectoryPath & "\Prescription.pdf"
            VReportPrescrip.AxAcroPDFPrescription.setZoom(80)
            VReportPrescrip.ShowDialog()
            VReportPrescrip.AxAcroPDFPrescription.Dispose()
            ViewPrescrip.Close()
            ViewPrescrip.Dispose()
            VReportPrescrip.Close()
            VReportPrescrip.Dispose()
            Me.Close()
            Me.Dispose()
        End If

    End Sub
    'Private Sub DoPrintRegistrationFormV2()
    '    If Me.InvokeRequired Then
    '        Me.Invoke(New MethodInvoker(AddressOf DoPrintRegistrationFormV2))
    '    Else

    '        Dim LabelID As New PatientLabel
    '        ' Dim patientInfo As DataTable = DA_Patients.SelectPatientNo(TxtPatientNo.Text)
    '        Dim FLabel As New IDCard
    '        Dim Drow As DataRow
    '        TPatient.Clear()
    '        Drow = TPatient.NewRow
    '        Drow("NameEng") = TxtNameEng.Text
    '        Drow("Sex") = CboSexPatien.Text
    '        Drow("Age") = EmptyString(TxtAgePatient.Text)
    '        Drow("Telephone") = TxtTel.Text
    '        Drow("PatientNo") = "*" & TxtPatientNo.Text & "*"
    '        TPatient.Rows.Add(Drow)
    '        If ChPrinAppForm.Checked = True Then
    '            EXPORT_PDF_PRINTER(LabelID, TPatient, FLabel.AxAcroPDFPrescription, "IDCard")
    '            FLabel.ShowDialog()
    '        Else
    '            Try
    '                LabelID.SetDataSource(TPatient)
    '                printDocument.PrinterSettings.PrinterName = ModCommon.PrinterRegistrationForm
    '                LabelID.PrintOptions.PrinterName = printDocument.PrinterSettings.PrinterName
    '                LabelID.PrintToPrinter(1, False, 1, 1)
    '                LabelID.Dispose()
    '                LabelID.Close()
    '            Catch ex As Exception
    '                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End Try

    '        End If

    '    End If

    'End Sub
    Private Sub BtnAddImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddImage.Click
        OpenFileDialog1.Filter = "Image Files (JPG,PNG,GIF)|*.JPG;*.PNG;*.GIF"
        'OpenFileDialog1.InitialDirectory = "C:\"
        OpenFileDialog1.Title = "Please select an image file"
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            For Each FName As String In OpenFileDialog1.FileNames
                DA_ImageDiagnosis.InsertNewConsult(LblWaitingNo.Text, ReadFileToBye(FName))
            Next
            GridImageList.DataSource = DA_ImageDiagnosis.SelectByWaitingNo(LblWaitingNo.Text)
        End If
    End Sub

    Private Sub BtnRemoveImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveImage.Click
        If GridImageList.SelectedItems.Count = 0 Then Exit Sub
        If MessageBox.Show("Do you want to remove this image", "Remove Image", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            If DA_ImageDiagnosis.DeleteImage(GridImageList.GetRow.Cells("IMAGE_ID").Value) = 1 Then
                GridImageList.DataSource = DA_ImageDiagnosis.SelectByWaitingNo(LblWaitingNo.Text)
            End If
        End If
    End Sub


    Private Sub ChFollowUp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChFollowUp.CheckedChanged
        GroupFollowup.Enabled = ChFollowUp.Checked
    End Sub




    Private Sub CboSurgery_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboSurgery.SelectedIndexChanged
        Try
            TxtPriceSurgery.Text = DA_SurgeryService.SelectSurgeryFee(CboSurgery.SelectedValue)
            TxtSurgeryCode.Text = DA_SurgeryService.SelectSurgeryCode(CboSurgery.SelectedValue)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub NewDoctorConsult_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If IS_UPDATE_CONSULT = False Then
            CboDoctorConsult.SelectedValue = USER_ID
            CboDoctorConsult.Enabled = False
        Else

        End If

    End Sub



    Private Sub BtnAddDiagnosis_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddDiagnosis.Click
        Dim frmDiagnosis As New FrmMainDiagnosis
        If frmDiagnosis.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim tblDiagnosis As DataTable = DA_Diagnosis.GetData
            For Each rows As DataRow In tblDiagnosis.Rows
                AutoDiagnosis.AddItem(rows("Surgery"))
            Next
        End If

    End Sub

    Private Sub BtnAddSurgery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddSurgery.Click
        Dim FSurgeries As New FRMSurgeryType
        If FSurgeries.ShowDialog() = Windows.Forms.DialogResult.OK Then
            With CboSurgery
                .DataSource = DA_SurgeryService.GetData
                .ValueMember = "SID"
                .DisplayMember = "Surgeries"
                .SelectedIndex = -1
            End With
        End If

    End Sub


    Private Sub BtnAddPrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddPrescription.Click
        If ValidateCombobox(cbomedicine, "", ErrConsult) = False Then Exit Sub
        'If ValidateCombobox(txtdosage, "", ErrConsult) = False Then Exit Sub
        If ValidateTextField(TxtQTY, "", ErrConsult) = False Then Exit Sub
        If ValidateCombobox(TxtUsage, "", ErrConsult) = False Then Exit Sub
        If DA_Item.CheckExistingItem(CInt(cbomedicine.SelectedValue), cbomedicine.Text) <= 0 Then
            MessageBox.Show("The name of medicince dosen't have in inventory. Please tell admin to add medicince.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbomedicine.Focus()
            cbomedicine.SelectAll()
            Exit Sub
        End If
        If IS_UPDATE_CONSULT = True Then
            If DA_PresciptionV1.CheckMedicince(LblWaitingNo.Text, CInt(cbomedicine.SelectedValue)) > 0 Then
                MessageBox.Show("The medicince already in prescription list.", "Prescription", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If
            If DA_PresciptionV1.InsertNewPrescription(CInt(LblWaitingNo.Text), CDbl(TxtPatientNo.Text), CInt(cbomedicine.SelectedValue), cbomedicine.Text, txtdosage.Text, CInt(EmptyString(TxtQTY.Text)), TxtUsage.Text & "-" & CboDuration.Text, GetDateServer.Date, LblPrice.Text, (EmptyString(TxtQTY.Text) * LblPrice.Text)) = 1 Then
                GridPrescription.DataSource = DA_PresciptionV1.SelectPrescriptionHistory(LblWaitingNo.Text)
                CleanPrescrip()
            End If
        Else
            If DA_PresciptionV1.CheckMedicince(LblWaitingNo.Text, CInt(cbomedicine.SelectedValue)) > 0 Then
                MessageBox.Show("The medicince already in prescription list.", "Prescription", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End If

            If DA_PrePrescription.InsertPrePrescription(CInt(LblWaitingNo.Text), CDbl(TxtPatientNo.Text), CInt(cbomedicine.SelectedValue), cbomedicine.Text, txtdosage.Text, CInt(EmptyString(TxtQTY.Text)), TxtUsage.Text & "-" & CboDuration.Text, GetDateServer.Date, LblPrice.Text, (EmptyString(TxtQTY.Text) * LblPrice.Text)) = 1 Then
                GridPrescription.DataSource = DA_PrePrescription.SelectWaitingID(LblWaitingNo.Text)
                CleanPrescrip()
            End If
        End If

    End Sub
    Private Sub CleanPrescrip()
        cbomedicine.SelectedIndex = -1
        TxtUsage.SelectedIndex = -1
        txtdosage.SelectedIndex = -1
        CboDuration.SelectedIndex = -1
        TxtQTY.Text = ""
        cbomedicine.Focus()
        cbomedicine.Select()
    End Sub

    Private Sub BtnRemovePrescription_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemovePrescription.Click
        If GridPrescription.SelectedItems.Count = 0 Then Exit Sub
        If IS_UPDATE_CONSULT = True Then
            If DA_PresciptionV1.DeletePrescription(GridPrescription.GetRow.Cells("PRES_ID").Value) = 1 Then
                GridPrescription.DataSource = DA_PresciptionV1.SelectPrescriptionHistory(LblWaitingNo.Text)
            End If
        Else
            If DA_PrePrescription.DeletePrePrescription(GridPrescription.GetRow.Cells("PRES_ID").Value) = 1 Then
                GridPrescription.DataSource = DA_PrePrescription.SelectWaitingID(LblWaitingNo.Text)
            End If
        End If

    End Sub

    Private Sub TxtQTY_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQTY.KeyPress
        SetDisableKeyString(e)
    End Sub


    Private Sub cbomedicine_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbomedicine.SelectedValueChanged
        Try
            Dim TblTemItem As DataTable = ItemPrice.GetItemPriceDataByItemID(CInt(cbomedicine.SelectedValue))  'SelectByItemID(CInt(cbomedicine.SelectedValue))
            LblPrice.Text = "0"
            For Each row As DataRow In TblTemItem.Rows
                LblPrice.Text = CDbl(row("Price"))
            Next
        Catch ex As Exception
            'MsgBox(ex.Message)
            LblPrice.Text = "0"
        End Try

    End Sub

    Private Sub BtnOrdinance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOrdinance.Click
        Dim FOrdinance As New FormOrdinance
        If FOrdinance.ShowDialog = Windows.Forms.DialogResult.OK Then
            With txtdosage
                .DataSource = DA_Ordinance.GetData
                .ValueMember = "ORDERNONG_ID"
                .DisplayMember = "LABEL_ORDERNONG"
                .SelectedIndex = -1
            End With
        End If
    End Sub

    Private Sub BtnUsage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUsage.Click
        Dim FUsage As New UsageLabel
        If FUsage.ShowDialog = Windows.Forms.DialogResult.OK Then
            With TxtUsage
                .DataSource = DA_Usage.GetData
                .ValueMember = "USING_ID"
                .DisplayMember = "USING_LABEL"
                .SelectedIndex = -1
            End With
        End If
    End Sub

    Private Sub NewDoctorConsult_FormClosed(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles MyBase.FormClosed
        DA_Waiting.UpdateDoctorConsulting(False, LblWaitingNo.Text)
        'DA_ImageDiagnosis.DeleteImageByWaitingID(LblWaitingNo.Text)
        DA_PrePrescription.DeletePreWaiting(CInt(LblWaitingNo.Text))
    End Sub

    Private Sub NewDoctorConsult_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        DA_Waiting.UpdateDoctorConsulting(False, LblWaitingNo.Text)
        ' DA_ImageDiagnosis.DeleteImageByWaitingID(LblWaitingNo.Text)
        DA_PrePrescription.DeletePreWaiting(CInt(LblWaitingNo.Text))
    End Sub

    Public Sub ViewConsultForUpdate(ByVal WaitingNo As Double)
       

        '============== View Consultation Detail ==============================
        Dim TblConsult As DataTable = DA_Consult.SelectWithWaitingNo(WaitingNo)
        For Each rows In TblConsult.Rows
            CboDiagRight.Text = rows("DIAGNOSIS")
            TxtDiagnosisCode.Text = rows("DIAGNOSIS_CODE")
            ChIssueGlasses.Checked = rows("IS_GLASSES")
            'Dim IS_Diagnosis As String = rows("IS_ON_EYE")
            'CboEyes.Text = IS_Diagnosis
            'If IS_Diagnosis = "Left Eye" Then
            '    RadDiagnosisLefEye.Checked = True
            'ElseIf IS_Diagnosis = "Right Eye" Then
            '    RadDiagnosisRighEye.Checked = True
            'ElseIf IS_Diagnosis = "Both Eyes" Then
            '    RadDiagnosisBothEyes.Checked = True
            'End If
            TxtDiagnosisNote.Text = rows("DIAGNOSIS_NOTE")
            Dim IS_ManagePaitent As String = rows("IS_ON_MANAGEMENT")
            CboManagerment.Text = IS_ManagePaitent
            'If IS_ManagePaitent = "Inpatient" Then
            '    RadManageInpatient.Checked = True
            'ElseIf IS_ManagePaitent = "Out Patient" Then
            '    RadManageOutPatient.Checked = True
            'ElseIf IS_ManagePaitent = "Surgery" Then
            '    RadManageSurgery.Checked = True
            '    Try
            '        CboSurgery.Text = rows("OPERATION_ON")
            '    Catch ex As Exception

            '    End Try

            'End If
            TxtMedication.Text = rows("MEDICATION")
            CboDoctorConsult.Text = rows("OPHTHAMOLOGIST")
            GridImageList.DataSource = DA_ImageDiagnosis.SelectImageDiagnosis(WaitingNo)
        Next
        '============== Load prescription ============================= 
        GridPrescription.DataSource = DA_PresciptionV1.SelectPrescriptionHistory(WaitingNo)
    End Sub


    Private Sub BtnAddMedicince_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddMedicince.Click
        Dim FItem As New frmItem
        FItem.ShowDialog()
        With cbomedicine
            .DataSource = DA_Item.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub GroupBox4_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox4.Enter

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim FCamera As New FormCamera(Me)
        FCamera.IS_UpdateImage = 3
        FCamera.ShowDialog()
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        DA_Waiting.UpdateDoctorConsulting(False, LblWaitingNo.Text)
        DA_ImageDiagnosis.DeleteImageByWaitingID(LblWaitingNo.Text)
        DA_PrePrescription.DeletePreWaiting(CInt(LblWaitingNo.Text))
        Me.Close()
    End Sub
    Private Sub InsertNewSurgery()

        If DA_New_Operation.InsertNewOT(TxtPatientNo.Text, "", CboDiagRight.Text, TxtRE.Text, TxtLE.Text, CboSurgery.Text) = 1 Then
            Dim NewWardID As Integer = DA_New_Operation.SelectMaxInpatient
            If ModOTRegistration.SaveNewOTRegist(NewWardID, TxtPatientNo.Text, CboOperationTime.Text, TxtAnesthesia.Text, CboAnesthetist.Text, _
            "", _
            CboSurgery.Text, _
            "", 0, 0, "", _
            CboSurgeon.Text, _
            CboAssistant.Text, _
            TxtCirculation.Text, _
            TxtCompli.Text, _
            False, _
            DateOT.Value.Date, _
            DateOT.Value.Date, "") = 1 Then
                ModNewInPatient.UpdateOTWating(NewWardID, 2)
                ModNewInPatient.UpdateOTHistory(NewWardID, 2, Now.Date)
            End If
        End If
    End Sub
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        If ValidateCombobox(CboExamFee, "", ErrConsult) = False Then
            Exit Sub
        End If
        If ChLaser.Checked = True Then
            'If ValidateCombobox(CboLaser, "", ErrConsult) = False Then
            '    Exit Sub
            'End If
            If CheckMInvestigate(MchLaser) = False Then
                MessageBox.Show("Please select at least one laser.", "Laser", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MchLaser.BackColor = Color.PapayaWhip
                MchLaser.Select()
                Exit Sub
            Else
                MchLaser.BackColor = Color.White
            End If
        End If
        If ChInvestigate.Checked = True Then
            If CheckMInvestigate(MChInvestigate) = False Then
                MessageBox.Show("Please select at least one investigate.", "Investigate", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MChInvestigate.BackColor = Color.PapayaWhip
                MChInvestigate.Select()
                Exit Sub
            Else
                MChInvestigate.BackColor = Color.White
            End If
            'If ValidateCombobox(cboInvestigate, "", ErrConsult) = False Then
            '    Exit Sub
            'End If
        End If
        If ChLaborat.Checked = True Then
            If CheckMInvestigate(MchLaborate) = False Then
                MessageBox.Show("Please select at least one Lab.", "Lab", MessageBoxButtons.OK, MessageBoxIcon.Error)
                MchLaborate.BackColor = Color.PapayaWhip
                MchLaborate.Select()
                Exit Sub
            Else
                MchLaborate.BackColor = Color.White
            End If
        End If
        'If CheckStatusReferal(GroupEye) = False Then
        '    MessageBox.Show("Please select patient eye!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    GroupEye.BackColor = Color.Tomato
        '    UiTab1.SelectedIndex = 0
        '    Exit Sub
        'Else
        '    GroupEye.BackColor = Color.Transparent
        'End If


        If ValidateCombobox(CboEyeDiagnosis, "", ErrConsult) = False Then Exit Sub
        If ValidateCombobox(CboManagerment, "", ErrConsult) = False Then Exit Sub
        If CboManagerment.Text = "Surgery" Then

            If ValidateCombobox(CboSurgery, "", ErrConsult) = False Then
                Exit Sub
            End If
            UiTab2.SelectedIndex = 1
            If ValidateDateTimePicker(DateOT, "Please select date opteration", ErrConsult) = False Then Exit Sub
            If ValidateDateTimePicker(CboOperationTime, "Time operation", ErrConsult) = False Then Exit Sub
            If DA_SurgeryService.CheckExistingSurgeries(CboSurgery.SelectedValue, CboSurgery.Text) <= 0 Then
                MessageBox.Show("The name of surgery dosen't have in system. Please add surgery.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                CboSurgery.Focus()
                CboSurgery.SelectAll()
                Exit Sub
            End If
        End If
        Dim Is_Old As Boolean = False
        Dim ChEye As String
        ' In case want to update consultattion
        If IS_UPDATE_CONSULT = True Then

            If MessageBox.Show("Do you want to edit examination?", "Consult", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then

                'Dim IS_Diagnosis As String = CboEyes.Text
                Dim IS_Management As String = CboManagerment.Text

                'Update Main Consult 
                DA_Consult.UpdateConsultationID(1, TxtDiagnosisCode.Text, CboDiagRight.Text, "", TxtDiagnosisNote.Text, IS_Management, _
                                                TxtMedication.Text, CboDoctorConsult.Text, ChIssueGlasses.Checked, CboSurgery.Text, ChConsultFree.Checked, CboDiagLeftEye.Text, TxtDiagCodeLeftEye.Text, LblConsult.Text)
                'Update VA In case VA change values
                DA_VA.UpdateVA(TxtRE.Text, TxtRPh.Text, TxtRREF.Text, TxtRRE.Text, TxtLE.Text, TxtLPh.Text, TxtLREF.Text, TxtLLE.Text, TxtHistory.Text, TxtIOPRE.Text, TxtIOPLE.Text, "", "", "", LblWaitingNo.Text)
                Me.DialogResult = Windows.Forms.DialogResult.OK
            End If
            ' [======================= Helllllllllllll ===============================]
            ' {======================= AAAAAAAAAAAAAAA ===============================}
        Else

            If MessageBox.Show("Do you want to save new examination?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                If DA_New_OldPatientBook.SelectExistingPatientBook(TxtPatientNo.Text) >= 1 Then
                    Is_Old = True
                End If
                'Dim IS_Diagnosis As String = CboEyes.Text
                Dim IS_Management As String = CboManagerment.Text
                If LblWaitingNo.Text = 0 Then
                    DA_Waiting.InsertNewWaiting(TxtPatientNo.Text, 0, "", "3", GetDateServer.Date, "1")
                    WAITING_NO = DA_Waiting.SelectMaxWaitID
                    ' ================ Insert New Patient VA ==================================================
                Else
                    WAITING_NO = LblWaitingNo.Text
                End If
                If DA_VA.CheckVAWaitingNo(WAITING_NO) = 0 Then
                    DA_VA.InsertNewVA(TxtPatientNo.Text, WAITING_NO, Now.Date, "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                End If
                If DA_New_OldPatientBook.SelectExistingPatientBook(TxtPatientNo.Text) >= 1 Then
                    Is_Old = True
                End If

                DA_Patient.UpdatePatientInfo(TxtNameEng.Text, CboSexPatien.Text, TxtTel.Text, TxtPatientNo.Text)

                If DA_Consult.InsertNewConsult(WAITING_NO, TxtPatientNo.Text, 0, TxtDiagnosisCode.Text, _
                                               CboDiagRight.Text, "", TxtDiagnosisNote.Text, IS_Management, TxtMedication.Text, _
                                               CboDoctorConsult.Text, ChIssueGlasses.Checked, CboSurgery.Text, ChConsultFree.Checked, TxtDiagCodeLeftEye.Text, CboDiagLeftEye.Text) = 1 Then
                    'Save into doctor consult
                    Dim TotalLaser As Double = 0
                    Dim TotalInvestigate As Double = 0
                    Dim TotalLabo As Double = 0
                    Dim LASER As String = ""
                    Dim INVESTIGATE As String = ""
                    Dim LABOLARY As String = ""

                    If ChLaser.Checked = True Then
                        For Each chMul As Object In MchLaser.CheckedItems
                            Dim LaserPrice As Double = CDbl(DA_Laser.SelectLPriceByName(chMul.ToString))
                            DA_TemConsult.InsertNewWaitingPayment(WAITING_NO, "Laser:" & chMul.ToString, LaserPrice)
                            LASER = LASER + chMul.ToString + vbCrLf
                            TotalLaser = TotalLaser + LaserPrice
                            DA_LASER_CONSULT.InsertLaserConsult(WAITING_NO, chMul.ToString, LaserPrice)
                        Next
                        'DA_TemConsult.InsertNewWaitingPayment(WAITING_NO, "Laser:" & CboLaser.Text, CDbl(LblLaserPrice.Text))
                    End If
                    If ChInvestigate.Checked = True Then
                        For Each chMul As Object In MChInvestigate.CheckedItems
                            Dim InvesPrice As Double = CDbl(DA_Invest.SelectInvestigatePriceByName(chMul.ToString))
                            DA_TemConsult.InsertNewWaitingPayment(WAITING_NO, "Investigate:" & chMul.ToString, CDbl(DA_Invest.SelectInvestigatePriceByName(chMul.ToString)))
                            INVESTIGATE = INVESTIGATE + chMul.ToString + vbCrLf
                            TotalInvestigate = TotalInvestigate + InvesPrice
                            DA_INVESTIGATE_CONSULT.InsertInvestConsult(WAITING_NO, chMul.ToString, InvesPrice)
                        Next
                        'DA_TemConsult.InsertNewWaitingPayment(WAITING_NO, "Investigate:" & cboInvestigate.Text, CDbl(LblInvestPrice.Text))
                    End If

                    ' In case patient have laboratory:
                    If ChLaborat.Checked = True Then
                        DA_Lab_check.InsertNewPatientLabo(WAITING_NO, Now.Date, TxtPatientNo.Text, TxtNameEng.Text, TxtTel.Text, TxtAgePatient.Text, CboSexPatien.Text, False, "", USER_NAME, Nothing)
                        For Each chMul As Object In MchLaborate.CheckedItems
                            Dim PriceLabo As Double = CDbl(DA_Labo.GetLaboPrice(chMul.ToString))
                            DA_TemConsult.InsertNewWaitingPayment(WAITING_NO, "Labo:" & chMul.ToString, CDbl(DA_Labo.GetLaboPrice(chMul.ToString)))
                            DA_Lab_Check_Detail.InsertLaboDetail(WAITING_NO, chMul.ToString, "")
                            LABOLARY = LABOLARY + chMul.ToString + vbCrLf
                            TotalLabo = TotalLabo + PriceLabo
                            DA_LABORATE_CONSULT.InsertLaborateConsult(WAITING_NO, chMul.ToString, PriceLabo)
                        Next
                    End If

                    DA_DoctorConsult.InsertNewDoctorConsult(CInt(CboDoctorConsult.SelectedValue), CboDoctorConsult.Text, Now.Date, _
                                                            TxtPatientNo.Text, TxtNameEng.Text, TxtNameKhmer.Text, CboSexPatien.Text, "", _
                                                            CboDiagRight.Text, IS_Management, CboSurgery.Text, CDbl(IIf(ChConsultFree.Checked = True, 0, CDbl(CboExamFee.SelectedValue))), _
                                                            EmptyString(TxtPriceSurgery.Text), CBool(IIf(ChConsultFree.Checked = True, True, False)), CboExamFee.Text, _
                                                            CDbl(IIf(ChLaser.Checked = False, 0, TotalLaser)), CDbl(IIf(ChInvestigate.Checked = False, 0, TotalInvestigate)), CDbl(IIf(ChLaborat.Checked = False, 0, TotalLabo)), WAITING_NO)
                    'Save Into New or Old Patient Book
                    DA_New_OldPatientBook.InsertNewPatientBook(0, TxtPatientNo.Text, CboDiagRight.Text & " (" & TxtDiagnosisCode.Text & ")", Now.Date, Is_Old, TxtDiagnosisCode.Text)
                    'Save into patient Surgery
                    If CboManagerment.Text = "Surgery" Then
                        InsertNewSurgery()
                        'DA_New_Operation.InsertNewOT(TxtPatientNo.Text, IS_Diagnosis, CboDiagnosis.Text, TxtRE.Text, TxtLE.Text, CboSurgery.Text)
                    End If

                    'Update VA In case VA change values


                    'Save into waiting pay for issue invoice
                    DA_TemConsult.InsertNewWaitingPayment(WAITING_NO, "Consultation Fee", CDbl(IIf(ChConsultFree.Checked = True, 0, CboExamFee.SelectedValue)))

                    'In case have refraction
                    If ChRefraction.Checked = True Then
                        DA_TemConsult.InsertNewWaitingPayment(WAITING_NO, "Refraction", CDbl(DA_ConsultFee.RefractionFee))
                    End If
                    'In Case Patient have investigate 
                 

                    


                    'In case have addmitted room
                    If ChAddmitted.Checked = True Then
                        DA_TemConsult.InsertNewWaitingPayment(WAITING_NO, "Addmitted room charge", CDbl(DA_ConsultFee.AdmittedRoomFee))
                    End If

                    If CboManagerment.Text = "Surgery" Then
                        DA_TemConsult.InsertNewWaitingPayment(WAITING_NO, CboManagerment.Text & " On " & CboSurgery.Text, EmptyString(TxtPriceSurgery.Text))
                    End If
                    'Save into folloup
                    If ChFollowUp.Checked = True Then

                        DA_FollowUp.InsertPatientFollowup(WAITING_NO, TxtPatientNo.Text, DateFollowUp.Value.Date, TxtFollowUpNote.Text, CboDoctorConsult.Text, TimeFollowup.Text, 1, USER_ID)
                    End If
                    ' ================ Insert New Patient VA ==================================================\
                    DA_VA.UpdateVA(TxtRE.Text, TxtRPh.Text, TxtRREF.Text, TxtRRE.Text, TxtLE.Text, TxtLPh.Text, TxtLREF.Text, TxtLLE.Text, TxtHistory.Text, TxtIOPRE.Text, TxtIOPLE.Text, LASER, INVESTIGATE, LABOLARY, WAITING_NO)
                    'DA_VA.InsertNewVA(TxtPatientNo.Text, WAITING_NO, Now.Date, "", "", "", "", "", "", "", "", "", "", "", "", LASER, INVESTIGATE, LABOLARY)
                    '================= Save Prescription ==============================
                    For i As Integer = 0 To GridPrescription.GetRows.Count - 1
                        'MsgBox(GridPrescription.GetRow(i).Cells("MEDICINCE_NAME").Value)
                        DA_PresciptionV1.InsertNewPrescription( _
                        CDbl(WAITING_NO), CDbl(TxtPatientNo.Text), CInt(GridPrescription.GetRow(i).Cells("MEDICINCE_ID").Value), _
                        GridPrescription.GetRow(i).Cells("MEDICINCE_NAME").Value, GridPrescription.GetRow(i).Cells("ORDINANCE").Value, _
                        CInt(GridPrescription.GetRow(i).Cells("MEDICINCE_QTY").Value), GridPrescription.GetRow(i).Cells("USAGE").Value, _
                        Now.Date, _
                        GridPrescription.GetRow(i).Cells("MEDICINCE_PRICE").Value, GridPrescription.GetRow(i).Cells("TOTAL_PRICE").Value)
                        IS_HAVE_Presc = True
                    Next
                    '============ Print Prescription =====================
                    'LblLoadPring.Visible = True
                    'ContainerControlCommand1.Visible = True
                    PicLoadReport.Visible = True
                    BgLoadRegistrationForm.RunWorkerAsync()
             
                End If
            End If


            
        End If
    End Sub

    Private Sub BtnDuration_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDuration.Click
        Dim FDuration As New FormDuration
        FDuration.ShowDialog()
        With CboDuration
            .DataSource = DA_Duration.GetData
            .ValueMember = "DURATION_ID"
            .DisplayMember = "DURATION"
            .SelectedIndex = -1
        End With
    End Sub

    Private Sub ChLaser_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChLaser.CheckedChanged
        MchLaser.Enabled = ChLaser.Checked
        For Each index As Integer In MchLaser.CheckedIndices
            MchLaser.SetItemCheckState(index, CheckState.Unchecked)
        Next
        MchLaser.BackColor = Color.White
        'CboLaser.Enabled = ChLaser.Checked
        'LblLaserPrice.Text = "0"
        'CboLaser.SelectedIndex = -1
    End Sub

    Private Sub ChInvestigate_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChInvestigate.CheckedChanged
        MChInvestigate.Enabled = ChInvestigate.Checked
        'LblInvestPrice.Text = "0"
        'cboInvestigate.SelectedIndex = -1
        For Each Index As Int16 In MChInvestigate.CheckedIndices
            MChInvestigate.SetItemCheckState(Index, CheckState.Unchecked)
        Next
        MChInvestigate.BackColor = Color.White
    End Sub



    Private Sub CboLaser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboLaser.SelectedIndexChanged
        Try
            LblLaserPrice.Text = DA_Laser.SelectLaserPrice(CboLaser.SelectedValue)
        Catch ex As Exception
            LblLaserPrice.Text = "0"
        End Try
    End Sub

    Private Sub cboInvestigate_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboInvestigate.SelectedIndexChanged
        Try
            LblInvestPrice.Text = DA_Invest.SelectInvestPrice(cboInvestigate.SelectedValue)
        Catch ex As Exception
            LblInvestPrice.Text = "0"
        End Try
    End Sub

    Private Sub GridImageList_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridImageList.RowDoubleClick
        If GridImageList.SelectedItems.Count = 0 Then Exit Sub
        Dim ImgZoom As New ImageZoom
        ImgZoom.PictureZoom.Image = GridImageList.GetRow.Cells("DIAGNOSIS_IMAGE").Value
        ImgZoom.ShowDialog()
    End Sub


    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboManagerment.SelectedIndexChanged
        If CboManagerment.Text = "Surgery" Then
            CboSurgery.Enabled = True
            BtnAddSurgery.Enabled = True
            GroupSurgery.Enabled = True
        Else
            TxtPriceSurgery.Text = "0"
            CboSurgery.SelectedIndex = -1
            CboSurgery.Enabled = False
            BtnAddSurgery.Enabled = False
            GroupSurgery.Enabled = False
        End If
    End Sub
    Dim DA_History As New DSConsultHistoryTableAdapters.S_REPORT_HISTORYTableAdapter
    Dim DA_PrescHist As New DSConsultHistoryTableAdapters.S_PRESCRIPTIONA1TableAdapter
    Dim DA_Patient_Image As New DSConsultHistoryTableAdapters.S_PATIENT_IMAGE_VIEWTableAdapter
    Private Sub BtnViewHistory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnViewHistory.Click
        If BtnViewHistory.Text = "View History" Then
            'LblLoadPring.Visible = True
            'ContainerControlCommand1.Visible = True
            BgLoadHistoryPatient.RunWorkerAsync()

        Else
            BtnViewHistory.Text = "View History"
            SplitContainer1.Panel2Collapsed = True

        End If


    End Sub
    Private Sub PrintPatientHistory()
        If Me.InvokeRequired Then
            Me.Invoke(New MethodInvoker(AddressOf PrintPatientHistory))
        Else
            BtnViewHistory.Text = "Hide History"
            SplitContainer1.Panel2Collapsed = False
            Dim RPHistory As New ReportPatientHistory
            Dim TblPHistory As DataTable = DA_History.SelectHistoryPatientNo(EmptyString(TxtPatientNo.Text))
            Dim tblImgHistory As DataTable = DA_Patient_Image.SelectPatientNo(EmptyString(TxtPatientNo.Text))
            Dim TblVA As DataTable = DA_VA.SelectVAByPatientNo(EmptyString(TxtPatientNo.Text))
            Dim TblPresc As DataTable = DA_PrescHist.SelectPresPatientNo(EmptyString(TxtPatientNo.Text))
            RPHistory.SetDataSource(TblPHistory)
            RPHistory.Subreports("Finding").SetDataSource(TblVA)
            RPHistory.Subreports("VA").SetDataSource(TblVA)
            RPHistory.Subreports("ResultDiagnosis").SetDataSource(TblPHistory)
            RPHistory.Subreports("ManagePatient").SetDataSource(TblPHistory)
            RPHistory.Subreports("PatientImages").SetDataSource(tblImgHistory)
            RPHistory.Subreports("CryPrescription").SetDataSource(TblPresc)
            Dim CrExportOptionsBig As ExportOptions
            Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
            CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\PatientHistory.pdf"
            CrExportOptionsBig = RPHistory.ExportOptions

            With CrExportOptionsBig
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = CrDiskFileDestinationOptionsBig
                .FormatOptions = CrFormatTypeOptionsBig
            End With

            RPHistory.Export()
            AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\PatientHistory.pdf"
            AxAcroPDF1.setZoom(100)
            RPHistory.Close()
            RPHistory.Dispose()
        End If
    End Sub
    Private Sub BtnNewReferral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewReferral.Click
        Dim FReferral As New NewReferral
        FReferral.PatientNo.Text = TxtPatientNo.Text
        FReferral.PatientName.Text = TxtNameEng.Text
        FReferral.Sex.Text = CboSexPatien.Text
        FReferral.Age.Text = TxtAgePatient.Text
        FReferral.PictureBox1.Image = PictureBox1.Image
        FReferral.ChiefComplaint.Text = TxtHistory.Text
        FReferral.SLIT_LAM.Text = TxtMedication.Text
        FReferral.DIAGNOSIS.Text = CboEyeDiagnosis.Text & " " & CboDiagRight.Text
        FReferral.ODCCPH.Text = TxtRPh.Text
        FReferral.OSCCPH.Text = TxtLPh.Text
        FReferral.ODMMHG.Text = TxtIOPRE.Text
        FReferral.OSMMHG.Text = TxtIOPLE.Text
        Dim treatment As String = ""
        For Each rowEx As Janus.Windows.GridEX.GridEXRow In GridPrescription.GetRows

            treatment = treatment & rowEx.Cells("MEDICINCE_NAME").Value & vbCrLf
        Next
        FReferral.TREATMENT.Text = treatment
        FReferral.ShowDialog()
    End Sub

    Private Sub GridPrescription_RowDoubleClick(ByVal sender As System.Object, ByVal e As Janus.Windows.GridEX.RowActionEventArgs) Handles GridPrescription.RowDoubleClick
        'TxtUsage.DropDownStyle = ComboBoxStyle.DropDown
        'TxtUsage.Text = GridPrescription.GetRow.Cells("USAGE").Value
        Dim FEditPresc As New EditPrescription
        FEditPresc.LblSaveOption.Text = GridPrescription.GetRow.Cells("PRES_ID").Value
        FEditPresc.cbomedicine.SelectedValue = GridPrescription.GetRow.Cells("MEDICINCE_ID").Value
        FEditPresc.TxtQTY.Text = GridPrescription.GetRow.Cells("MEDICINCE_QTY").Value
        FEditPresc.LblPrice.Text = GridPrescription.GetRow.Cells("MEDICINCE_PRICE").Value
        FEditPresc.txtdosage.Text = GridPrescription.GetRow.Cells("ORDINANCE").Value
        FEditPresc.TxtUsage.Text = GridPrescription.GetRow.Cells("USAGE").Value
        ' FEditPresc.CboDuration.Text = GridPrescription.GetRow.Cells("USAGE").Value

        If FEditPresc.ShowDialog = Windows.Forms.DialogResult.OK Then
            GridPrescription.DataSource = DA_PrePrescription.SelectWaitingID(LblWaitingNo.Text)
        End If
    End Sub

    Private Sub BgLoadRegistrationForm_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadRegistrationForm.DoWork
        Me.ViewPatientPrescrip()
    End Sub

    Private Sub BgLoadRegistrationForm_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadRegistrationForm.RunWorkerCompleted
        ' LblLoadPring.Visible = False
        PicLoadReport.Visible = False
        '  ContainerControlCommand1.Visible = False
        DA_PrePrescription.DeletePreWaiting(CInt(WAITING_NO))
        DA_Waiting.UpdatePatientStatus("", "3", "2", WAITING_NO)
        Me.DispostProcessDeclaration()
        DRConsult.RefreshInterface()
        Me.Close()
        Me.Dispose()
    End Sub

    Private Sub BgLoadHistory_DoWork(ByVal sender As System.Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles BgLoadHistoryPatient.DoWork
        PrintPatientHistory()
    End Sub

    Private Sub BgLoadHistory_RunWorkerCompleted(ByVal sender As System.Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BgLoadHistoryPatient.RunWorkerCompleted
        'LblLoadPring.Visible = False
        'ContainerControlCommand1.Visible = False
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckMInvestigate(MChInvestigate) = True Then
            MsgBox("Success")
        Else
            MsgBox("Fail")
        End If
    End Sub

    Private Sub ChLaborat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChLaborat.CheckedChanged
        MchLaborate.Enabled = ChLaborat.Checked
        For Each index As Integer In MchLaborate.CheckedIndices
            MchLaborate.SetItemCheckState(index, CheckState.Unchecked)
        Next
        MchLaborate.BackColor = Color.White
    End Sub

    Private Sub BtnCertificate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCertificate.Click
        Dim FCertificate As New FormCertificate
        FCertificate.TxtPatientNo.Text = TxtPatientNo.Text
        FCertificate.TxtPatientName.Text = TxtNameEng.Text
        FCertificate.TxtSex.Text = CboSexPatien.Text
        FCertificate.TxtAge.Text = TxtAgePatient.Text

        If FCertificate.ShowDialog = Windows.Forms.DialogResult.OK Then
            PrintCertifcate(DA_Certifcate.SelectLastCertID) ' FCertificate.TxtPatientNo.Text)
            'LoadPatientCertificate()
        End If
    End Sub
    Dim DA_Certifcate As New DSCertificateTableAdapters.S_PATIENT_CERTIFICATETableAdapter
    Private Sub PrintCertifcate(ByVal PatientNo As String)
        Dim FViewCertificate As New FormViewCertificate
        Dim CCertificate As New CRVCertificate
        Dim TCertificate As DataTable = DA_Certifcate.SelectCertificateByPNO(PatientNo)
        EXPORT_PDF_PRINTER(CCertificate, TCertificate, FViewCertificate.AxAcroPDF1, "MedicalCertificate")
        FViewCertificate.ShowDialog()
    End Sub
    Dim ValueCodeRight As String = ""
    Dim ValueCodeLeft As String = ""
    Private Sub AutoDiagnosis_Selected(ByVal sender As System.Object, ByVal e As AutocompleteMenuNS.SelectedEventArgs) Handles AutoDiagnosis.Selected
        Try
            ReturnCodeRight(e.Item.Text)
        Catch ex As Exception
            ' TxtDiagnosisCode.Text = ""
        End Try
    End Sub

    Private Function ReturnCodeRight(ByVal Diagnosis) As String
        Try
            ValueCodeRight = ValueCodeRight + "," + DA_Diagnosis.SelectCodeByName(Diagnosis)
            TxtDiagnosisCode.Text = ValueCodeRight.Substring(1, ValueCodeRight.Length - 1)
        Catch ex As Exception

        End Try

    End Function

    Private Sub AutoDiagLeft_Selected(ByVal sender As System.Object, ByVal e As AutocompleteMenuNS.SelectedEventArgs)
        Try
            ReturnCodeLeft(e.Item.Text)
        Catch ex As Exception

        End Try
    End Sub
    Private Function ReturnCodeLeft(ByVal Diagnosis) As String
        Try
            ValueCodeLeft = ValueCodeLeft + "," + DA_Diagnosis.SelectCodeByName(Diagnosis)
            TxtDiagCodeLeftEye.Text = ValueCodeLeft.Substring(1, ValueCodeLeft.Length - 1)
        Catch ex As Exception

        End Try

    End Function

    Private Sub CboEyeDiagnosis_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CboEyeDiagnosis.SelectedIndexChanged
        If CboEyeDiagnosis.Text = "" Then
            CboDiagRight.Text = ""
            CboDiagRight.Select()
        ElseIf CboEyeDiagnosis.Text = "Right Eye" Then
            CboDiagRight.Text = "RE:"
            CboDiagRight.Select()
        ElseIf CboEyeDiagnosis.Text = "Left Eye" Then
            CboDiagRight.Text = "LE:"
            CboDiagRight.Focus()
        ElseIf CboEyeDiagnosis.Text = "Both Eyes" Then
            CboDiagRight.Text = "RE:   LE:"
            CboDiagRight.Focus()
        ElseIf CboEyeDiagnosis.Text = "BE" Then
            CboDiagRight.Text = "BE:"
            CboDiagRight.Focus()
        End If
    End Sub


    Private Sub DispostProcessDeclaration()
        DA_Diagnosis.Dispose()
        DA_SurgeryService.Dispose()
        DA_Doctor.Dispose()
        DA_Consult.Dispose()
        DA_FollowUp.Dispose()
        DA_ImageDiagnosis.Dispose()
        DA_Waiting.Dispose()
        DA_TemConsult.Dispose()
        DA_New_OldPatientBook.Dispose()
        DA_New_Operation.Dispose()
        DA_DoctorConsult.Dispose()
        DA_USER.Dispose()
        DA_Patient.Dispose()

        DA_VA.Dispose()
        DA_PrePrescription.Dispose()

        DA_MedicineService.Dispose()

        DA_PresciptionV1.Dispose()

        ItemPrice.Dispose()
        DA_ConsultFee.Dispose()
        DA_Prescription.Dispose()
        DA_Item.Dispose()
        DA_Ordinance.Dispose()
        DA_Duration.Dispose()
        DA_Usage.Dispose()
        DA_Laser.Dispose()
        DA_Invest.Dispose()
        DA_Labo.Dispose()
        DA_Lab_check.Dispose()
        DA_Lab_Check_Detail.Dispose()
    End Sub

    Private Sub TxtFollowUpNote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtFollowUpNote.TextChanged

    End Sub
End Class