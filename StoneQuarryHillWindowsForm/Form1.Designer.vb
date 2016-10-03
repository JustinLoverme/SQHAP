<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArtPark
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
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtCurrent = New System.Windows.Forms.TextBox()
        Me.btnPrev = New System.Windows.Forms.Button()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.lblForm = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(460, 429)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(75, 23)
        Me.btnLast.TabIndex = 0
        Me.btnLast.Text = "Last >>"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(353, 429)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(75, 23)
        Me.btnNext.TabIndex = 1
        Me.btnNext.Text = "Next >"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(555, 431)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(65, 20)
        Me.txtTotal.TabIndex = 2
        '
        'txtCurrent
        '
        Me.txtCurrent.Location = New System.Drawing.Point(228, 430)
        Me.txtCurrent.Name = "txtCurrent"
        Me.txtCurrent.Size = New System.Drawing.Size(100, 20)
        Me.txtCurrent.TabIndex = 3
        '
        'btnPrev
        '
        Me.btnPrev.Location = New System.Drawing.Point(130, 429)
        Me.btnPrev.Name = "btnPrev"
        Me.btnPrev.Size = New System.Drawing.Size(75, 23)
        Me.btnPrev.TabIndex = 4
        Me.btnPrev.Text = "< Previous"
        Me.btnPrev.UseVisualStyleBackColor = True
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(27, 428)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(75, 23)
        Me.btnFirst.TabIndex = 5
        Me.btnFirst.Text = "<< First"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'lblForm
        '
        Me.lblForm.AutoSize = True
        Me.lblForm.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblForm.Location = New System.Drawing.Point(21, 85)
        Me.lblForm.Name = "lblForm"
        Me.lblForm.Size = New System.Drawing.Size(95, 31)
        Me.lblForm.TabIndex = 6
        Me.lblForm.Text = "Label1"
        '
        'frmArtPark
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(682, 495)
        Me.Controls.Add(Me.lblForm)
        Me.Controls.Add(Me.btnFirst)
        Me.Controls.Add(Me.btnPrev)
        Me.Controls.Add(Me.txtCurrent)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnLast)
        Me.Name = "frmArtPark"
        Me.Text = "Stone Quarry Hill Art Park"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnLast As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtCurrent As TextBox
    Friend WithEvents btnPrev As Button
    Friend WithEvents btnFirst As Button
    Friend WithEvents lblForm As Label
End Class
