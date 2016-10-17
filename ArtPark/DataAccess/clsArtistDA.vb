Imports System.Data.OleDb

Public Class clsArtistDA



    ' Method Name:  GetRecords
    ' Purpose:      To get all the records from the database for this entity
    ' Parameter:    Nothing
    ' Return:       All the records of this entity - Dataset

    Public Shared Function GetRecords() As DataSet
        Dim dbConnection As OleDbConnection = Nothing
        ' error handling
        Try
            ' connect to the database
            dbConnection = ConnectToDb()

            ' check the status of the connection
            If dbConnection Is Nothing Then
                MessageBox.Show("Connection failed!")
                Return Nothing
            End If

            ' the connection if made
            ' create a SQL string
            Dim strQuery As String
            strQuery = "SELECT * FROM Artist"

            ' Setup ADO component
            ' create a data adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            ' create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            ' configure the components
            dbCommand.CommandText = strQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.SelectCommand = dbCommand

            ' declare a dataset
            Dim ds As New DataSet

            ' fill the dataset
            dbDataAdapter.Fill(ds, "Artist")

            Return ds
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsArtistDA. Method: GetRecords(). Error: " _
                            & ex.Message)
            Return Nothing
        Finally
            CloseDb(dbConnection)
        End Try
    End Function


    ' Method Name:  DeleteRecord
    ' Purpose:      To delete a record from the database for this entity
    ' Parameter:    Primary Key - String
    ' Return:       Result (number of rows affected) - Integer


    Public Shared Function DeleteRecord(ByVal aPrimaryKey As String) As Integer
        Dim dbConnection As OleDbConnection = Nothing
        ' error handling
        Try
            ' connect to the database
            dbConnection = ConnectToDb()

            ' check the status of the connection
            If dbConnection Is Nothing Then
                MessageBox.Show("Connection failed!")
                Return Nothing
            End If

            ' the connection if made
            ' create a SQL string
            Dim strQuery As String
            strQuery = "DELETE FROM Artist WHERE ArtistID = ?"

            ' Setup ADO component
            ' create a data adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            ' create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            ' add a new parameter
            dbCommand.Parameters.Add(New OleDbParameter("@ArtistID", aPrimaryKey))

            ' configure the components
            dbCommand.CommandText = strQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.SelectCommand = dbCommand

            ' declare a variable to hold the result
            Dim intResult As Integer
            ' call the method to get the result
            intResult = dbCommand.ExecuteNonQuery

            ' return the result
            Return intResult
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsArtistDA. Method: DeleteRecord(String). Error: " _
                            & ex.Message)
            Return -9
        Finally
            CloseDb(dbConnection)
        End Try
    End Function


    ' Method Name:  AddRecord
    ' Purpose:      To add a record from the database for this entity
    ' Parameter:    Object (aArtist) - clsArtist
    ' Return:       Result (number of rows affected) - Integer

    Public Shared Function AddRecord(ByVal aArtist As clsArtist) As Integer
        Dim dbConnection As OleDbConnection = Nothing
        ' error handling
        Try
            ' connect to the database
            dbConnection = ConnectToDb()

            ' check the status of the connection
            If dbConnection Is Nothing Then
                MessageBox.Show("Connection failed!")
                Return Nothing
            End If

            ' the connection if made
            ' create a SQL string
            Dim strQuery As String
            strQuery = "INSERT INTO Artist (ArtistID, FullName, Phone, Email, Website, AIR) VALUES (?, ?, ?, ?, ?, ?)"

            ' Setup ADO component
            ' create a data adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            ' create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            ' add new parameters
            dbCommand.Parameters.Add(New OleDbParameter("@ArtistID", aArtist.ArtistID))
            dbCommand.Parameters.Add(New OleDbParameter("@FullName", aArtist.Name))
            dbCommand.Parameters.Add(New OleDbParameter("@Phone", aArtist.Phone))
            dbCommand.Parameters.Add(New OleDbParameter("@Website", aArtist.Website))
            dbCommand.Parameters.Add(New OleDbParameter("@Email", aArtist.Email))
            dbCommand.Parameters.Add(New OleDbParameter("@AIR", aArtist.AIR))

            ' configure the components
            dbCommand.CommandText = strQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.SelectCommand = dbCommand

            ' declare a variable to hold the result
            Dim intResult As Integer
            ' call the method to get the result
            intResult = dbCommand.ExecuteNonQuery

            ' return the result
            Return intResult
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsArtistDA. Method: AddRecord(Object). Error: " _
                            & ex.Message)
            Return -9
        Finally
            CloseDb(dbConnection)
        End Try
    End Function

    ' Method Name:  UpdateRecord
    ' Purpose:      To update a record from the database for this entity
    ' Parameter:    Object (aArtist) - clsArtist
    ' Return:       Result (number of rows affected) - Integer

    Public Shared Function UpdateRecord(ByVal aArtist As clsArtist) As Integer
        Dim dbConnection As OleDbConnection = Nothing
        ' error handling
        Try
            ' connect to the database
            dbConnection = ConnectToDb()

            ' check the status of the connection
            If dbConnection Is Nothing Then
                MessageBox.Show("Connection failed!")
                Return Nothing
            End If

            ' the connection if made
            ' create a SQL string
            Dim strQuery As String
            strQuery = "UPDATE Artist SET Website = ?, Email = ?, FullName = ?, Phone = ? WHERE ArtistID = ?"

            ' Setup ADO component
            ' create a data adapter object
            Dim dbDataAdapter As New OleDbDataAdapter
            ' create a command object for the data adapter
            Dim dbCommand As New OleDbCommand

            ' add new parameters

            dbCommand.Parameters.Add(New OleDbParameter("Full@Name", aArtist.Name))
            dbCommand.Parameters.Add(New OleDbParameter("@Phone", aArtist.Phone))
            dbCommand.Parameters.Add(New OleDbParameter("@Website", aArtist.Website))
            dbCommand.Parameters.Add(New OleDbParameter("@Email", aArtist.Email))
            ' *********** adding your primary key field last *************************************
            dbCommand.Parameters.Add(New OleDbParameter("@ArtistID", aArtist.ArtistID))
            ' ************************************************************************************

            ' configure the components
            dbCommand.CommandText = strQuery
            dbCommand.Connection = dbConnection
            dbDataAdapter.SelectCommand = dbCommand

            ' declare a variable to hold the result
            Dim intResult As Integer
            ' call the method to get the result
            intResult = dbCommand.ExecuteNonQuery

            ' return the result
            Return intResult
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsArtistDA. Method: UpdateRecord(Object). Error: " _
                            & ex.Message)
            Return -9
        Finally
            CloseDb(dbConnection)
        End Try
    End Function
End Class
