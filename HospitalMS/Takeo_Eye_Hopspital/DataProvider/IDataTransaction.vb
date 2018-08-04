Public Interface IDataTransaction
    Function UpdateTransaction(ByVal objSQL As Object) As Integer
    Function InsertTransaction(ByVal objSQL As Object) As Integer
    Function DeleteTransaction(ByVal objSQL As Object) As Integer
    Function SelectAsSqlDataSet(ByVal objSQL As Object) As Object
    Function SelectAsDataTable(ByVal objSQL As Object) As Object
    Function SelectAsScalar(ByVal sql As Object) As Object
    Function SelectAsScalar2012(ByVal sql As Object) As Object
    Function InsertTransaction2012(ByVal ObjSQL As Object) As Integer

End Interface