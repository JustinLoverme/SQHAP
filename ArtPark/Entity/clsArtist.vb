' Class Name:   clsArtist
' Purpose:  A container to hold all attributes and methods in a class
' Change log:  

Public Class clsArtist

    ' *******************************************************************************************
    ' attributes
    '********************************************************************************************
    Private intArtistID As Integer
    Private strName As String
    Private strPhone As String
    Private strEmail As String
    Private strWebsite As String
    Public AIR As Boolean
    ' *******************************************************************************************
    ' Property methods - getters and setters
    '********************************************************************************************
    Public Property ArtistID() As Integer
        Get
            Return intArtistID
        End Get
        Set(value As Integer)
            If value > 0 Then
                intArtistID = value
            Else
                ' decide what you want to do
                intArtistID = -1
            End If
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return strPhone
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strPhone = value
            Else
                strPhone = "Null String"
            End If
        End Set
    End Property
    Public Property Email() As String
        Get
            Return strEmail
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strEmail = value
            Else
                strEmail = "Null String"
            End If
        End Set
    End Property
    Public Property Name() As String
        Get
            Return strName
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strName = value
            Else
                strName = "Null String"
            End If
        End Set
    End Property
    Public Property Website() As String
        Get
            Return strWebsite
        End Get
        Set(value As String)
            If value <> String.Empty Then
                strWebsite = value
            Else
                strWebsite = "Null String"
            End If
        End Set
    End Property

    Public Property CbAIR() As Boolean
        Get
            Return AIR
        End Get
        Set(value As Boolean)
            AIR = value
        End Set
    End Property


    ' *******************************************************************************************
    ' Constructors
    '********************************************************************************************

    ' default constructor
    Public Sub New()
        intArtistID = 0
        strName = ""
        strWebsite = ""
        strEmail = ""
        strPhone = ""
        AIR = False
    End Sub

    ' parameter based constructor
    Public Sub New(ByVal aArtistID As Integer, ByVal aName As String,
                  ByVal aWebsite As String, ByVal aEmail As String, ByVal aPhone As String, ByVal aAIR As Boolean)
        intArtistID = aArtistID
        strName = aName
        strWebsite = aWebsite
        strEmail = aEmail
        strPhone = aPhone
        AIR = aAIR
    End Sub

    ' *******************************************************************************************
    ' Class Methods
    '********************************************************************************************

    ' Method Name:  classInfo
    ' Purpose:      To obtain a record from the database for this entity
    ' Parameter:    None
    ' Return:       A record of this entity - String
    ' Change Log:   10/12/16
    Public Function classInfo() As String
        Return "ArtistID = " & ArtistID() & vbCr & "Artist Name: " & Name() & vbCr _
            & "Artist Phone Number: " & Phone() & vbCr & "Artist Email: " & Email() & vbCr _
            & vbCr & "Artist Website: " & Website() & vbCr
    End Function

    ' Method Name:  GetRecords
    ' Purpose:      To obtain all the records from the database for this entity
    ' Parameter:    None
    ' Return:       All the records for this entity - Dataset
    ' Change Log:   10/12/16
    Public Shared Function GetRecords() As DataSet
        Try
            Return clsArtistDA.GetRecords()
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsArtist. Method: GetRecords(). Error: " _
                            & ex.Message)
            Return Nothing
        End Try
    End Function

    ' Method Name:  DeleteRecord
    ' Purpose:      To delete a record from the database for this entity
    ' Parameter:    Primary Key - String
    ' Return:       Result (number of rows affected) - Integer
    ' Change Log:   10/12/16
    Public Shared Function DeleteRecord(ByVal aPrimaryKey As String) As Integer
        Try
            Return clsArtistDA.DeleteRecord(aPrimaryKey)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsArtist. Method: DeleteRecord(String). Error: " _
                            & ex.Message)
            Return -9
        End Try
    End Function

    ' Method Name:  AddRecord
    ' Purpose:      To add a record from the database for this entity
    ' Parameter:    Object (artist) - clsArtist
    ' Return:       Result (number of rows affected) - Integer
    ' Change Log:   10/12/16
    Public Shared Function AddRecord(ByVal aArtist As clsArtist) As Integer
        Try
            Return clsArtistDA.AddRecord(aArtist)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsArtist. Method: AddRecord(Object). Error: " _
                            & ex.Message)
            Return -9
        End Try
    End Function

    ' Method Name:  UpdateRecord
    ' Purpose:      To update a record from the database for this entity
    ' Parameter:    Object (artist) - clsArtist
    ' Return:       Result (number of rows affected) - Integer
    ' Change Log:   10/12/16
    Public Shared Function UpdateRecord(ByVal aArtist As clsArtist) As Integer
        Try
            Return clsArtistDA.UpdateRecord(aArtist)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Class: clsArtist. Method: UpdateRecord(Object). Error: " _
                            & ex.Message)
            Return -9
        End Try
    End Function
End Class
