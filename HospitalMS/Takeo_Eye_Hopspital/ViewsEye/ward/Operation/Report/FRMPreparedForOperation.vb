Public Class FRMPreparedForOperation
    Public Title1 As String = ""
    Public Title2 As String = ""
    Public OptionReport As Integer
    Public DateFrom As Date
    Public DateTo As Date
    Dim DA_OT As New DSOTTableAdapters.ViewPreparForOperationTableAdapter
    Private Sub FRMPreparedForOperation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim TblPreparForOperation As DataTable
        Dim CR As New CRPreparForOperation
        If OptionReport = 1 Then
            TblPreparForOperation = DA_OT.GetData
        Else
            TblPreparForOperation = DA_OT.SelectOTHistory(DateFrom.Date, DateTo.Date)
        End If
        
        CR.SetDataSource(TblPreparForOperation)
        CR.SetParameterValue("Title1", Title1)
        CR.SetParameterValue("Title2", Title2)
        CRVPreparedForOperation.ReportSource = CR
       
        'CR.Refresh()
    End Sub
End Class