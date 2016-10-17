' Form Name:    frmArtist
' Purpose:      To allow the user to either enter data or display an object
' Change Log:   10/12/16

Option Strict On


Public Class frmArtist

    'Declare variables
    Dim cbAir As Boolean

    Private dsArtist As New DataSet
    Public Sub DisplayRecord(ByVal aIndex As Integer)
        Try
            If dsArtist.Tables("Artist").Rows.Count = 0 Then
                Exit Sub
            End If

            lblCurrent.Text = (aIndex + 1).ToString
            lblTotal.Text = (dsArtist.Tables("Artist").Rows.Count).ToString

            txtArtistID.Text = dsArtist.Tables("Artist").Rows(aIndex).Item(0).ToString
            txtName.Text = dsArtist.Tables("Artist").Rows(aIndex).Item(1).ToString
            txtPhone.Text = dsArtist.Tables("Artist").Rows(aIndex).Item(2).ToString
            txtWebsite.Text = dsArtist.Tables("Artist").Rows(aIndex).Item(4).ToString
            txtEmail.Text = dsArtist.Tables("Artist").Rows(aIndex).Item(3).ToString
            'filling checkbox
            If dsArtist.Tables("Artist").Rows(aIndex).Item(5).ToString = "True" Then
                cbYes.Checked = True
                cbNo.Checked = False
            Else
                cbNo.Checked = True
                cbYes.Checked = False
            End If


        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtist. Method: DisplayRecord(index). Error: " _
                           & ex.Message)
        End Try

    End Sub


    Private Sub frmArtist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Home.Hide()
        dsArtist = clsArtist.GetRecords()
        DisplayRecord(0)

    End Sub

    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Try
            ' go to the first record
            DisplayRecord(0)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtist. Method: btnFirst_Click(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        Try
            ' go to the last record
            DisplayRecord(dsArtist.Tables("Artist").Rows.Count - 1)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtist. Method: btnLast_Click(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        Try
            ' check to see if it is the first record
            If lblCurrent.Text = "1" Then
                ' don't do anything
                Exit Sub
            End If

            ' go to the previous one
            DisplayRecord(CInt(lblCurrent.Text) - 2)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtist. Method: btnPrevious_Click(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        Try
            If (CInt(lblCurrent.Text) = dsArtist.Tables("Artist").Rows.Count) Then
                ' do nothing, because we don't care
                Exit Sub
            End If
            ' go to the next record
            DisplayRecord(CInt(lblCurrent.Text))
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtist. Method: btnNext_Click(). Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnMainMenu_Click(sender As Object, e As EventArgs) Handles btnMainMenu.Click
        Home.Show()
        Me.Hide()
    End Sub
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' a variable to hold user's response
        Dim intResponse As Integer

        Try
            intResponse = MessageBox.Show("Are you certain you want to delete the record?",
                                          "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning,
                                          MessageBoxDefaultButton.Button2)
            ' check the user response
            If intResponse = vbNo Then
                Exit Sub
            ElseIf txtArtistID.Text.Length = 0 Or Not IsNumeric(txtArtistID.Text.Trim) Then
                MessageBox.Show("You must enter a valid ID number for record deletion.")
                Exit Sub
            Else
                ' user answered Yes! and ID field has a valid value
                Dim intResult As Integer
                intResult = clsArtist.DeleteRecord(txtArtistID.Text.Trim)

                ' evaluate the return result
                If intResult = 1 Then
                    MessageBox.Show("The record has been deleted!")
                ElseIf intResult = 0 Then
                    MessageBox.Show("Massive failure: delete failed!")
                Else
                    MessageBox.Show("Something is very wrong, prepare to die!!!")
                End If
            End If

            ' get the updated dataset
            dsArtist = clsArtist.GetRecords()
            ' display the first record
            DisplayRecord(0)
        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtist. Method: btnDelete_Click(). Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim myArtist As clsArtist
        Try
            ' validate the user input
            If IsValidNumber(txtArtistID, "ArtistID") Then
                If IsValidText(txtName, "Name") Then
                    If IsValidText(txtEmail, "Email") Then
                        If IsValidNumber(txtPhone, "Phone") Then
                            If IsValidText(txtWebsite, "Website") Then
                                If cbYes.Checked = True Or cbNo.Checked = True Then

                                    myArtist = New clsArtist(CInt(txtArtistID.Text.Trim),
                                                              txtName.Text, txtPhone.Text, txtEmail.Text,
                                                              txtWebsite.Text, cbAir)

                                    ' declare a variable to holds the result
                                    Dim intResult As Integer
                                    ' call the function to add a record
                                    intResult = clsArtist.AddRecord(myArtist)
                                    ' evaluate the result
                                    If intResult = 1 Then
                                        MessageBox.Show("A record has been successfully added!")
                                    ElseIf intResult = 0 Then
                                        MessageBox.Show("Add failed!")
                                    Else
                                        MessageBox.Show("Massive fail on your part...")

                                    End If

                                    ' get the updated dataset
                                    dsArtist = clsArtist.GetRecords()
                                    ' display the first record
                                    DisplayRecord(0)

                                Else
                                    MessageBox.Show("Select a yes or no box for if the Artist is in residence")
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtist. Method: btnAdd_Click(). Error: " & ex.Message)
        End Try
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Dim myArtist As clsArtist
        Try
            ' validate the user input
            If IsValidNumber(txtArtistID, "ArtistID") Then
                If IsValidText(txtName, "Name") Then
                    If IsValidText(txtEmail, "Email") Then
                        If IsValidNumber(txtPhone, "Phone") Then
                            If IsValidText(txtWebsite, "Website") Then
                                If cbYes.Checked = True Or cbNo.Checked = True Then

                                    ' get all valid input to create an object 
                                    myArtist = New clsArtist(CInt(txtArtistID.Text.Trim),
                                                              txtName.Text, txtPhone.Text, txtEmail.Text,
                                                              txtWebsite.Text, cbAir)
                                    ' declare a variable to holds the result
                                    Dim intResult As Integer
                                    ' call the function to add a record
                                    intResult = clsArtist.UpdateRecord(myArtist)
                                    ' evaluate the result
                                    If intResult = 1 Then
                                        MessageBox.Show("A record has been successfully updated!")
                                    ElseIf intResult = 0 Then
                                        MessageBox.Show("Update failed!")
                                    Else
                                        MessageBox.Show("Massive fail on your part...")

                                    End If

                                    ' get the updated dataset
                                    dsArtist = clsArtist.GetRecords()
                                    ' display the first record
                                    DisplayRecord(0)
                                Else
                                    MessageBox.Show("Select a yes or no box for if the Artist is in residence")
                                End If
                            End If
                        End If
                    End If
                End If
            End If

        Catch ex As Exception
            MessageBox.Show("Error occurred in Form: frmArtist. Method: btnUpdate_Click(). Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'clears all input fields
        txtName.Text = ""
        txtPhone.Text = ""
        txtArtistID.Text = ""
        txtEmail.Text = ""
        txtWebsite.Text = ""
        cbYes.Checked = False
        cbNo.Checked = False
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub cbNo_CheckedChanged(sender As Object, e As EventArgs) Handles cbNo.CheckedChanged
        cbAir = False
    End Sub

    Private Sub cbYes_CheckedChanged(sender As Object, e As EventArgs) Handles cbYes.CheckedChanged
        cbAir = True
    End Sub
End Class