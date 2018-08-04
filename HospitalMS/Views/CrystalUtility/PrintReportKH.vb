Module PrintReportKH
    Dim DS As New DataSet
    Dim cnn As New SqlClient.SqlConnection(My.Settings.AppConnection)
    Dim myReport As New clsCrystalReport()
    Private Function PrintReport(ByVal FileDir As String, ByVal DataSetName As String, ByVal SQL As String) As clsCrystalReport
        cnn.Open()
        DS.Clear()

        Dim Da As New SqlClient.SqlDataAdapter(SQL, cnn)
        Da.Fill(DS, DataSetName)

        myReport.ReportPath(Application.StartupPath & "\" & FileDir)
        myReport.SetDataSource(DS, DataSetName)
        cnn.Close()
        ' myReport.PrintToPrinter(
        Return myReport
    End Function
End Module
