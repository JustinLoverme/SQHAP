<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMaintenance
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMaintenance))
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnMainMenu = New System.Windows.Forms.Button()
        Me.lblTotal = New System.Windows.Forms.Label()
        Me.lblCurrent = New System.Windows.Forms.Label()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.lblReCheck = New System.Windows.Forms.Label()
        Me.lblMdate = New System.Windows.Forms.Label()
        Me.lblArtID = New System.Windows.Forms.Label()
        Me.lblMaintID = New System.Windows.Forms.Label()
        Me.txtReCheck = New System.Windows.Forms.TextBox()
        Me.txtMdate = New System.Windows.Forms.TextBox()
        Me.txtArtID = New System.Windows.Forms.TextBox()
        Me.txtMaintID = New System.Windows.Forms.TextBox()
        Me.lblDesc = New System.Windows.Forms.Label()
        Me.txtDesc = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(502, 10)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 73
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(502, 114)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 72
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnMainMenu
        '
        Me.btnMainMenu.Location = New System.Drawing.Point(502, 331)
        Me.btnMainMenu.Name = "btnMainMenu"
        Me.btnMainMenu.Size = New System.Drawing.Size(75, 23)
        Me.btnMainMenu.TabIndex = 71
        Me.btnMainMenu.Text = "Main Menu"
        Me.btnMainMenu.UseVisualStyleBackColor = True
        '
        'lblTotal
        '
        Me.lblTotal.AutoSize = True
        Me.lblTotal.Location = New System.Drawing.Point(264, 336)
        Me.lblTotal.Name = "lblTotal"
        Me.lblTotal.Size = New System.Drawing.Size(13, 13)
        Me.lblTotal.TabIndex = 70
        Me.lblTotal.Text = "0"
        '
        'lblCurrent
        '
        Me.lblCurrent.AutoSize = True
        Me.lblCurrent.Location = New System.Drawing.Point(204, 336)
        Me.lblCurrent.Name = "lblCurrent"
        Me.lblCurrent.Size = New System.Drawing.Size(13, 13)
        Me.lblCurrent.TabIndex = 69
        Me.lblCurrent.Text = "0"
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(25, 332)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 68
        Me.btnFirst.Text = "First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(106, 332)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(75, 23)
        Me.btnPrevious.TabIndex = 67
        Me.btnPrevious.Text = "Previous"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(313, 331)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 66
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(394, 331)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 65
        Me.btnLast.Text = "Last"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 64
        Me.PictureBox1.TabStop = False
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(502, 277)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 63
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(502, 184)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 62
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(502, 155)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 61
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'lblReCheck
        '
        Me.lblReCheck.AutoSize = True
        Me.lblReCheck.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblReCheck.Location = New System.Drawing.Point(254, 152)
        Me.lblReCheck.Name = "lblReCheck"
        Me.lblReCheck.Size = New System.Drawing.Size(82, 16)
        Me.lblReCheck.TabIndex = 60
        Me.lblReCheck.Text = "ReCheck Date"
        '
        'lblMdate
        '
        Me.lblMdate.AutoSize = True
        Me.lblMdate.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMdate.Location = New System.Drawing.Point(253, 104)
        Me.lblMdate.Name = "lblMdate"
        Me.lblMdate.Size = New System.Drawing.Size(102, 16)
        Me.lblMdate.TabIndex = 59
        Me.lblMdate.Text = "Maintenance Date"
        '
        'lblArtID
        '
        Me.lblArtID.AutoSize = True
        Me.lblArtID.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblArtID.Location = New System.Drawing.Point(253, 62)
        Me.lblArtID.Name = "lblArtID"
        Me.lblArtID.Size = New System.Drawing.Size(63, 16)
        Me.lblArtID.TabIndex = 58
        Me.lblArtID.Text = "Artwork ID"
        '
        'lblMaintID
        '
        Me.lblMaintID.AutoSize = True
        Me.lblMaintID.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaintID.Location = New System.Drawing.Point(252, 20)
        Me.lblMaintID.Name = "lblMaintID"
        Me.lblMaintID.Size = New System.Drawing.Size(90, 16)
        Me.lblMaintID.TabIndex = 57
        Me.lblMaintID.Text = "Maintenance ID"
        '
        'txtReCheck
        '
        Me.txtReCheck.Location = New System.Drawing.Point(382, 148)
        Me.txtReCheck.Multiline = True
        Me.txtReCheck.Name = "txtReCheck"
        Me.txtReCheck.Size = New System.Drawing.Size(100, 20)
        Me.txtReCheck.TabIndex = 56
        '
        'txtMdate
        '
        Me.txtMdate.Location = New System.Drawing.Point(382, 100)
        Me.txtMdate.Multiline = True
        Me.txtMdate.Name = "txtMdate"
        Me.txtMdate.Size = New System.Drawing.Size(100, 20)
        Me.txtMdate.TabIndex = 55
        '
        'txtArtID
        '
        Me.txtArtID.Location = New System.Drawing.Point(382, 55)
        Me.txtArtID.Multiline = True
        Me.txtArtID.Name = "txtArtID"
        Me.txtArtID.Size = New System.Drawing.Size(100, 20)
        Me.txtArtID.TabIndex = 54
        '
        'txtMaintID
        '
        Me.txtMaintID.Location = New System.Drawing.Point(382, 13)
        Me.txtMaintID.Name = "txtMaintID"
        Me.txtMaintID.Size = New System.Drawing.Size(100, 20)
        Me.txtMaintID.TabIndex = 53
        '
        'lblDesc
        '
        Me.lblDesc.AutoSize = True
        Me.lblDesc.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDesc.Location = New System.Drawing.Point(254, 191)
        Me.lblDesc.Name = "lblDesc"
        Me.lblDesc.Size = New System.Drawing.Size(107, 16)
        Me.lblDesc.TabIndex = 75
        Me.lblDesc.Text = "Maintenance Desc."
        '
        'txtDesc
        '
        Me.txtDesc.Location = New System.Drawing.Point(382, 187)
        Me.txtDesc.Multiline = True
        Me.txtDesc.Name = "txtDesc"
        Me.txtDesc.Size = New System.Drawing.Size(100, 20)
        Me.txtDesc.TabIndex = 76
        '
        'frmMaintenance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 365)
        Me.Controls.Add(Me.txtDesc)
        Me.Controls.Add(Me.lblDesc)
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
        Me.Controls.Add(Me.lblReCheck)
        Me.Controls.Add(Me.lblMdate)
        Me.Controls.Add(Me.lblArtID)
        Me.Controls.Add(Me.lblMaintID)
        Me.Controls.Add(Me.txtReCheck)
        Me.Controls.Add(Me.txtMdate)
        Me.Controls.Add(Me.txtArtID)
        Me.Controls.Add(Me.txtMaintID)
        Me.Name = "frmMaintenance"
        Me.Text = "Stone Quarry Hill Artpark :: Maintenance"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnMainMenu As Button
    Friend WithEvents lblTotal As Label
    Friend WithEvents lblCurrent As Label
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents lblReCheck As Label
    Friend WithEvents lblMdate As Label
    Friend WithEvents lblArtID As Label
    Friend WithEvents lblMaintID As Label
    Friend WithEvents txtReCheck As TextBox
    Friend WithEvents txtMdate As TextBox
    Friend WithEvents txtArtID As TextBox
    Friend WithEvents txtMaintID As TextBox
    Friend WithEvents lblDesc As Label
    Friend WithEvents txtDesc As TextBox
End Class
