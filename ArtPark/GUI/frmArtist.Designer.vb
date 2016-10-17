<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArtist
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmArtist))
        Me.txtArtistID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.lblArtistID = New System.Windows.Forms.Label()
        Me.lblArtistName = New System.Windows.Forms.Label()
        Me.lblArtistPhoneNumber = New System.Windows.Forms.Label()
        Me.lblArtistEmail = New System.Windows.Forms.Label()
        Me.lblArtistInResidence = New System.Windows.Forms.Label()
        Me.lblArtistWebsite = New System.Windows.Forms.Label()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.cbYes = New System.Windows.Forms.CheckBox()
        Me.cbNo = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtArtistID
        '
        Me.txtArtistID.Location = New System.Drawing.Point(382, 12)
        Me.txtArtistID.Name = "txtArtistID"
        Me.txtArtistID.Size = New System.Drawing.Size(100, 20)
        Me.txtArtistID.TabIndex = 0
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(382, 54)
        Me.txtName.Multiline = True
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 1
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(382, 99)
        Me.txtPhone.Multiline = True
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 2
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(382, 147)
        Me.txtEmail.Multiline = True
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 3
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(382, 231)
        Me.txtWebsite.Multiline = True
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(100, 20)
        Me.txtWebsite.TabIndex = 5
        '
        'lblArtistID
        '
        Me.lblArtistID.AutoSize = True
        Me.lblArtistID.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtistID.Location = New System.Drawing.Point(252, 19)
        Me.lblArtistID.Name = "lblArtistID"
        Me.lblArtistID.Size = New System.Drawing.Size(51, 16)
        Me.lblArtistID.TabIndex = 6
        Me.lblArtistID.Text = "Artist ID"
        '
        'lblArtistName
        '
        Me.lblArtistName.AutoSize = True
        Me.lblArtistName.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtistName.Location = New System.Drawing.Point(253, 61)
        Me.lblArtistName.Name = "lblArtistName"
        Me.lblArtistName.Size = New System.Drawing.Size(37, 16)
        Me.lblArtistName.TabIndex = 7
        Me.lblArtistName.Text = "Name"
        '
        'lblArtistPhoneNumber
        '
        Me.lblArtistPhoneNumber.AutoSize = True
        Me.lblArtistPhoneNumber.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtistPhoneNumber.Location = New System.Drawing.Point(253, 103)
        Me.lblArtistPhoneNumber.Name = "lblArtistPhoneNumber"
        Me.lblArtistPhoneNumber.Size = New System.Drawing.Size(86, 16)
        Me.lblArtistPhoneNumber.TabIndex = 8
        Me.lblArtistPhoneNumber.Text = "Phone Number"
        '
        'lblArtistEmail
        '
        Me.lblArtistEmail.AutoSize = True
        Me.lblArtistEmail.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtistEmail.Location = New System.Drawing.Point(254, 151)
        Me.lblArtistEmail.Name = "lblArtistEmail"
        Me.lblArtistEmail.Size = New System.Drawing.Size(36, 16)
        Me.lblArtistEmail.TabIndex = 9
        Me.lblArtistEmail.Text = "Email"
        '
        'lblArtistInResidence
        '
        Me.lblArtistInResidence.AutoSize = True
        Me.lblArtistInResidence.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtistInResidence.Location = New System.Drawing.Point(253, 190)
        Me.lblArtistInResidence.Name = "lblArtistInResidence"
        Me.lblArtistInResidence.Size = New System.Drawing.Size(108, 16)
        Me.lblArtistInResidence.TabIndex = 10
        Me.lblArtistInResidence.Text = "Artist In Residence"
        '
        'lblArtistWebsite
        '
        Me.lblArtistWebsite.AutoSize = True
        Me.lblArtistWebsite.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtistWebsite.Location = New System.Drawing.Point(253, 229)
        Me.lblArtistWebsite.Name = "lblArtistWebsite"
        Me.lblArtistWebsite.Size = New System.Drawing.Size(51, 16)
        Me.lblArtistWebsite.TabIndex = 11
        Me.lblArtistWebsite.Text = "Website"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(502, 154)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 12
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(502, 183)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(502, 276)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 14
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(394, 330)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 16
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(313, 330)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 17
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(106, 331)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 20
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(25, 331)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 21
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(204, 335)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(13, 13)
        Me.lblCurrent.TabIndex = 22
        Me.lblCurrent.Text = "0"
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(264, 335)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblTotal.TabIndex = 23
        Me.lblTotal.Text = "0"
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(502, 330)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMainMenu.TabIndex = 24
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(502, 113)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 25
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(502, 9)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'cbYes
        '
        Me.cbYes.AutoSize = True
        Me.cbYes.Location = New System.Drawing.Point(383, 191)
        Me.cbYes.Name = "cbYes"
        Me.cbYes.Size = New System.Drawing.Size(44, 17)
        Me.cbYes.TabIndex = 27
        Me.cbYes.Text = "Yes"
        Me.cbYes.UseVisualStyleBackColor = True
        '
        'cbNo
        '
        Me.cbNo.AutoSize = True
        Me.cbNo.Location = New System.Drawing.Point(433, 191)
        Me.cbNo.Name = "cbNo"
        Me.cbNo.Size = New System.Drawing.Size(40, 17)
        Me.cbNo.TabIndex = 28
        Me.cbNo.Text = "No"
        Me.cbNo.UseVisualStyleBackColor = True
        '
        'frmArtist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 365)
        Me.Controls.Add(Me.cbNo)
        Me.Controls.Add(Me.cbYes)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnMainMenu)
        Me.Controls.Add(Me.lblTotal)
        Me.Controls.Add(Me.lblCurrent)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnLast)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.lblArtistWebsite)
        Me.Controls.Add(Me.lblArtistInResidence)
        Me.Controls.Add(Me.lblArtistEmail)
        Me.Controls.Add(Me.lblArtistPhoneNumber)
        Me.Controls.Add(Me.lblArtistName)
        Me.Controls.Add(Me.lblArtistID)
        Me.Controls.Add(Me.txtWebsite)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.txtPhone)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtArtistID)
        Me.Name = "frmArtist"
        Me.Text = "Stone Quarry Hill Artpark :: Artist"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtArtistID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtPhone As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtWebsite As TextBox
    Friend WithEvents lblArtistID As Label
    Friend WithEvents lblArtistName As Label
    Friend WithEvents lblArtistPhoneNumber As Label
    Friend WithEvents lblArtistEmail As Label
    Friend WithEvents lblArtistInResidence As Label
    Friend WithEvents lblArtistWebsite As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents lblCurrent As Label
    Friend WithEvents lblTotal As Label
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents cbYes As CheckBox
    Friend WithEvents cbNo As CheckBox
End Class
