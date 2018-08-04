Imports CrystalDecisions.Shared

Public Class DashboardListCosult
    Dim DA_DRConsult As New DSConsultHistoryTableAdapters.S_DOCTOR_CONSULTTableAdapter
    Dim DA_USER As New DSUserManagementTableAdapters.VUsersInGroupTableAdapter

    Dim DA_COUNT_LASER As New DSConsultHistoryTableAdapters.VIEW_S_LASER_CONSULTTableAdapter
    Dim DA_COUNT_INVES As New DSConsultHistoryTableAdapters.VIEW_S_INVESTIGATE_CONSULTTableAdapter
    Dim DA_COUNT_LABO As New DSConsultHistoryTableAdapters.VIEW_S_LABORATE_CONSULTTableAdapter
    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboDoctor
            .DataSource = DA_USER.GetDataUserByGroup(36)
            .ValueMember = "UserID"
            .DisplayMember = "UserName"
            .SelectedIndex = -1
        End With

        With CboDoctor1
            .DataSource = DA_USER.GetDataUserByGroup(36)
            .ValueMember = "UserID"
            .DisplayMember = "UserName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnPrintPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnPrintPreview.Click

        Dim DoctorConsult As New DoctorConsultlist
        Dim TblDrConsult As DataTable
        If ChDoctor.Checked = True Then
            TblDrConsult = DA_DRConsult.SelectDateToDateWithDoctor(DateFrom.Value.Date, DateTo.Value.Date, CInt(CboDoctor.SelectedValue))
        Else
            TblDrConsult = DA_DRConsult.SelectDateToDate(DateFrom.Value.Date, DateTo.Value.Date)
        End If

        DoctorConsult.SetDataSource(TblDrConsult)
        DoctorConsult.SetParameterValue("Title", "From: " & DateFrom.Text & " To: " & DateTo.Text)
        ' Declare for export Big app form
        Dim CrExportOptionsBig As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\DRConsult.pdf"
        CrExportOptionsBig = DoctorConsult.ExportOptions
        With CrExportOptionsBig
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With
        DoctorConsult.Export()
        Application.DoEvents()
        Application.DoEvents()
        AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\DRConsult.pdf"
        AxAcroPDF1.setZoom(70)
    End Sub

    Private Sub ChDoctor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDoctor.CheckedChanged
        CboDoctor.Enabled = ChDoctor.Checked
    End Sub

    Private Sub BtnTotalInvestigate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTotalInvestigate.Click

        Dim TblLaser As DataTable
        Dim TblInves As DataTable
        Dim TblLabo As DataTable
        If ChDoctor1.Checked = True Then
            TblLaser = DA_COUNT_LASER.SelectLaserDateToDateWithDR(DateFrom1.Value.Date, DateTo1.Value.Date, CInt(CboDoctor1.SelectedValue))
            TblInves = DA_COUNT_INVES.SelectInvesDateToDateWithDr(DateFrom1.Value.Date, DateTo1.Value.Date, CInt(CboDoctor1.SelectedValue))
            TblLabo = DA_COUNT_LABO.SelectLaboDateToDateWithDR(DateFrom1.Value.Date, DateTo1.Value.Date, CInt(CboDoctor1.SelectedValue))
        Else
            TblLaser = DA_COUNT_LASER.SelectTotalLaserDateToDate(DateFrom1.Value.Date, DateTo1.Value.Date)
            TblInves = DA_COUNT_INVES.SelectInvesDateToDate(DateFrom1.Value.Date, DateTo1.Value.Date)
            TblLabo = DA_COUNT_LABO.SelectTotalLaboDateToDate(DateFrom1.Value.Date, DateTo1.Value.Date)
        End If

       
        Dim CrTotalInves As New DoctorConsultInvestigate
        CrTotalInves.Subreports("TotalLaser").SetDataSource(TblLaser)
        CrTotalInves.Subreports("TotalInvestigate").SetDataSource(TblInves)
        CrTotalInves.Subreports("TotalLabo").SetDataSource(TblLabo)
        CrTotalInves.SetParameterValue("Title", IIf(ChDoctor1.Checked = True, "With Dr. " & CboDoctor1.Text, "") & " From: " & DateFrom1.Text & " To: " & DateTo1.Text)
        Dim CrExportOptionsBig As ExportOptions
        Dim CrDiskFileDestinationOptionsBig As New DiskFileDestinationOptions()
        Dim CrFormatTypeOptionsBig As New PdfRtfWordFormatOptions()
        CrDiskFileDestinationOptionsBig.DiskFileName = My.Application.Info.DirectoryPath & "\DRTotalInvestigage.pdf"
        CrExportOptionsBig = CrTotalInves.ExportOptions
        With CrExportOptionsBig
            .ExportDestinationType = ExportDestinationType.DiskFile
            .ExportFormatType = ExportFormatType.PortableDocFormat
            .DestinationOptions = CrDiskFileDestinationOptionsBig
            .FormatOptions = CrFormatTypeOptionsBig
        End With
        CrTotalInves.Export()
        Application.DoEvents()
        Application.DoEvents()
        AxAcroPDF1.src = My.Application.Info.DirectoryPath & "\DRTotalInvestigage.pdf"
        AxAcroPDF1.setZoom(70)
    End Sub

    Private Sub ChDoctor1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ChDoctor1.CheckedChanged
        CboDoctor1.Enabled = ChDoctor1.Checked
    End Sub
End Class
