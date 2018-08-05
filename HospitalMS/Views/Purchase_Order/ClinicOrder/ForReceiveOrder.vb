Public Class ForReceiveOrder
    Dim TableReceiveTem As DataTable = New DSInventoryClinic.RECEIVE_ITEM_TEM_DETAILDataTable
    Dim DAItem As New DSInventoryClinicTableAdapters.tblItemTableAdapter
    Dim DASupplier As New DSInventoryClinicTableAdapters.tblLabourFactoryTableAdapter

    Dim DAReceiveMaster As New DSInventoryClinicTableAdapters.ITEM_RECIEVE_MASTERTableAdapter
    Dim DAReceiveItemDedial As New DSInventoryClinicTableAdapters.ITEM_RECIEVE_DETIALTableAdapter

    Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()
        With CboItem
            .DataSource = DAItem.GetData
            .ValueMember = "ItemID"
            .DisplayMember = "ItemName"
            .SelectedIndex = -1
        End With
        With CboSupplier
            .DataSource = DASupplier.GetData()
            .ValueMember = "LabourFacID"
            .DisplayMember = "LabourFacName"
            .SelectedIndex = -1
        End With
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub BtnAddItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAddItem.Click
        If ValidateCombobox(CboItem, "", ErrReceive) = False Then Exit Sub
        If ValidateTextField(TxtQTYReceive, "", ErrReceive) = False Then Exit Sub
        If ValidateTextField(TxtItemPrice, "", ErrReceive) = False Then Exit Sub
        If ValidateDateTimePicker(DateExpiry, "", ErrReceive) = False Then Exit Sub
        AddReceiveTem()
        CalculateTotalReceive(TableReceiveTem, EmptyString(TxtVATPercent.Text), EmptyString(TxtDeposit.Text))
    End Sub
    Function CheckValue(ByVal myTable As DataTable, ByVal columnName As String, ByVal searchValue As String) As Boolean
        For Each row As DataRow In myTable.Rows
            ' MsgBox(row(columnName))
            If row(columnName) = searchValue Then Return True
        Next
        Return False
    End Function
    Private Sub AddReceiveTem()
        If CheckValue(TableReceiveTem, "ITEM_ID", CboItem.SelectedValue) = True Then
            MessageBox.Show("The Item existing in list receive! pls check again.", "Receive", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboItem.Focus()
            CboItem.SelectAll()
            Exit Sub
        End If
        Try
            Dim Dr As DataRow
            Dr = TableReceiveTem.NewRow
            Dr("RECEIVETEM_ID") = CboItem.SelectedValue
            Dr("ITEM_ID") = CboItem.SelectedValue
            Dr("ITEM_NAME") = CboItem.Text
            Dr("ITEM_QTY") = TxtQTYReceive.Text
            Dr("ITEM_MEASURE") = CboReceiveMeasure.Text
            Dr("ITEM_PRICE") = TxtItemPrice.Text
            Dr("ITEM_EXPIRYDATE") = IIf(DateExpiry.Checked = True, DateExpiry.Value, Nothing)
            Dr("TOTAL_AMOUNT") = CDbl(TxtQTYReceive.Text) * CDbl(TxtItemPrice.Text)
            TableReceiveTem.Rows.Add(Dr)
        Catch ex As Exception
            MessageBox.Show("Not correct Item name. Please check item again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            CboItem.Select()
            CboItem.Focus()
        End Try
        
        RefreshDGTem()
        CleanItemReceived()
    End Sub
    Private Sub CleanItemReceived()
        CboItem.SelectedIndex = -1
        TxtQTYReceive.Text = ""
        TxtItemPrice.Text = ""
        CboReceiveMeasure.SelectedIndex = -1
        CboReceiveMeasure.Text = ""
        DateExpiry.Checked = False
    End Sub
    Private Sub DeleteRow(ByVal TblTem As DataTable, ByVal filter As String)
        Try
            TableReceiveTem.EndLoadData()
            Dim ndx As Int32
            Dim rows = TableReceiveTem.Select("RECEIVETEM_ID=" & filter)
            If rows.Count > 0 Then
                ndx = TableReceiveTem.Rows.IndexOf(rows(0))
                TableReceiveTem.Rows(ndx).Delete()
                ' TblTem.AcceptChanges()
                ' MsgBox(ndx)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
       
        'Try
        '    'TblTem.Select("RECEIVETEM_ID=" & filter)
        '    'TblTem.Rows(0).Delete()
        '    'TblTem.Rows.Find(filter).Delete()

        '    TblTem.AcceptChanges()
        'Catch ex As Exception
        '    MsgBox(ex.Message)
        'End Try
    End Sub
    Private Sub RefreshDGTem()
        GridListItemReceive.Refetch()
        GridListItemReceive.Refresh()
        GridListItemReceive.DataSource = TableReceiveTem
    End Sub
    Private Sub CalculateTotalReceive(ByVal tblReceiveTem As DataTable, ByVal Tax As Double, ByVal Diposit As Double)
        Try
            Dim TotalExcludeVAT As Double = 0
            Dim TotalAmountDue As Double = 0
            For Each Row As DataRow In tblReceiveTem.Rows
                TotalExcludeVAT = TotalExcludeVAT + CDbl(Row("TOTAL_AMOUNT"))
            Next
            TxtTotalAmoutExcludVAT.Text = TotalExcludeVAT
            TxtVAT.Text = (Tax / 100) * TotalExcludeVAT
            TxtTotalAmountIncludVAT.Text = TotalExcludeVAT + EmptyString(TxtVAT.Text)
            TxtTotalAmounDue.Text = ((TotalExcludeVAT + EmptyString(TxtVAT.Text)) - Diposit)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        

    End Sub

    Private Sub TxtQTYReceive_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtQTYReceive.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtItemPrice_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtItemPrice.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub BtnRemoveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnRemoveItem.Click

        If GridListItemReceive.SelectedItems.Count = 0 Then Exit Sub
        DeleteRow(TableReceiveTem, GridListItemReceive.GetRow.Cells("RECEIVETEM_ID").Value.ToString)
        RefreshDGTem()
        CalculateTotalReceive(TableReceiveTem, EmptyString(TxtVATPercent.Text), EmptyString(TxtDeposit.Text))
    End Sub
   
    Private Sub BtnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnCancel.Click
        Me.Close()
        Me.Dispose()
    End Sub

  
    Private Sub TxtVATPercent_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtVATPercent.KeyUp
        CalculateTotalReceive(TableReceiveTem, EmptyString(TxtVATPercent.Text), EmptyString(TxtDeposit.Text))
    End Sub

    Private Sub TxtDeposit_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TxtDeposit.KeyUp
        CalculateTotalReceive(TableReceiveTem, EmptyString(TxtVATPercent.Text), EmptyString(TxtDeposit.Text))
    End Sub

    Private Sub TxtVATPercent_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtVATPercent.KeyPress
        SetDisableKeyString(e)
    End Sub

    Private Sub TxtDeposit_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtDeposit.KeyPress
        SetDisableKeyString(e)
    End Sub

   
    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        If ValidateCombobox(CboSupplier, "", ErrReceive) = False Then Exit Sub
        If ValidateTextField(TxtInvoiceReferenceNo, "", ErrReceive) = False Then Exit Sub
        If ValidateDateTimePicker(DateInvoiceReference, "", ErrReceive) = False Then Exit Sub
        If ValidateDateTimePicker(DateInvoiceDueDate, "", ErrReceive) = False Then Exit Sub
        If GridListItemReceive.SelectedItems.Count = 0 Then
            MessageBox.Show("Please enter item to list receive.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        ' Save New Receive by Item
        If LblSaveOption.Text = "0" Then
            If DAReceiveMaster.InsertReceiveMaster(Now.Date, TxtInvoiceReferenceNo.Text, DateInvoiceReference.Value.Date, DateInvoiceDueDate.Value.Date, TxtTeam.Text, CboSupplier.SelectedValue, CboSupplier.Text, "", EmptyString(TxtTotalAmoutExcludVAT.Text), EmptyString(TxtVATPercent.Text), EmptyString(TxtVAT.Text), EmptyString(TxtTotalAmountIncludVAT.Text), EmptyString(TxtDeposit.Text), EmptyString(TxtTotalAmounDue.Text), TxtReceiveNote.Text, 1, "") = 1 Then
                Dim LastSaveID As Double = DAReceiveMaster.SelectMaxReceive
                For Each rows In TableReceiveTem.Rows
                    DAReceiveItemDedial.InsertNewItemReceiveDetial(LastSaveID, CDbl(rows("ITEM_ID")), CStr(rows("ITEM_NAME")), CSng(rows("ITEM_MEASURE")), CDate(rows("ITEM_EXPIRYDATE")), CDbl(rows("ITEM_QTY")), CDbl(rows("ITEM_PRICE")), CDbl(rows("TOTAL_AMOUNT")))
                Next
            End If
            ' Update Existing item
        Else

        End If
    End Sub
End Class