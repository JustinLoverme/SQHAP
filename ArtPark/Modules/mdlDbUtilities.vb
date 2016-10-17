Imports System.Data.OleDb

Module mdlDbUtilities
    ' Method Name:      ConnectToDb
    ' Purpose:          To connect to a database
    ' Parameter:        None
    ' Return:           Database connection - OleDbConnection Object
    ' Change Log:       10/12/16

    Public Function ConnectToDb() As OleDbConnection
        ' error handling
        Try
            ' try to connect to the database
            ' declare and create a new connection object
            Dim dbConnection As New OleDbConnection

            ' configure the connection string
            Dim strConnectionString As String
            strConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=../../Database/SQHAP_DB.accdb"

            dbConnection.ConnectionString = strConnectionString

            ' open the database connection
            dbConnection.Open()

            ' return the object that has been configured
            Return dbConnection

        Catch ex As Exception
            MessageBox.Show("Error occurred in Module: mdlDbUtilities. Method: ConnectToDb(). Error: " _
                            & ex.Message)
            Return Nothing
        End Try
    End Function

    ' Method Name:      CloseDb
    ' Purpose:          To disconnect from a database
    ' Parameter:        Database connection - OleDbConnection Object
    ' Return:           None
    ' Change Log:       10/12/16

    Public Sub CloseDb(ByVal aConnection As OleDbConnection)
        ' error handling
        Try
            aConnection.Close()
        Catch ex As Exception
            MessageBox.Show("Error occurred in Module: mdlDbUtilities. Method: CloseDb(). Error: " _
                            & ex.Message)
        End Try
    End Sub

End Module

