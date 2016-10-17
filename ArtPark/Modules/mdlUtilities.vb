Module mdlUtilities
    ' Method Name:  IsPresent
    ' Purpose:      To check if a user entered anything
    ' Parameter:    aTextbox - control, aName - String
    ' Return:       T/F - Boolean
    ' Change Log:  

    Public Function IsPresent(ByVal aTextbox As Control, ByVal aName As String) As Boolean
        ' check if a user entered anything
        If (aTextbox.Text = "") Then
            MessageBox.Show(aName & " is a required field.", "Null Input")
            Return False
        Else
            Return True
        End If
    End Function

    ' Method Name:  IsValidNumber
    ' Purpose:      To check if a user entered a number
    ' Parameter:    aTextbox - control, aName - String
    ' Return:       T/F - Boolean
    ' Change Log:  

    Public Function IsValidNumber(ByVal aTextbox As Control, ByVal aName As String) As Boolean
        ' check if a user entered anything
        If IsPresent(aTextbox, aName) Then
            ' check if it's a number
            If IsNumeric(aTextbox.Text.Trim) Then
                Return True
            Else
                MessageBox.Show("Please enter only a number for " & aName, "Error Input")
                aTextbox.Focus()
                Return False
            End If
        End If
        Return False
    End Function

    ' Method Name:  IsValidText
    ' Purpose:      To check if a user entered a non-number string
    ' Parameter:    aTextbox - control, aName - String
    ' Return:       T/F - Boolean
    ' Change Log:   
    Public Function IsValidText(ByVal aTextbox As Control, ByVal aName As String) As Boolean
        ' check if a user entered anything
        If IsPresent(aTextbox, aName) Then
            ' check if it's not a number
            If Not IsNumeric(aTextbox.Text.Trim) Then
                Return True
            Else
                MessageBox.Show("Please don't enter a number for " & aName, "Error Input")
                aTextbox.Focus()
                Return False
            End If
        End If
        Return False
    End Function

End Module
