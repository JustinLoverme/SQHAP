<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.btnArtist = New System.Windows.Forms.Button()
        Me.btnMaintenance = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnArt = New System.Windows.Forms.Button()
        Me.btnEvents = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnArtist
        '
        Me.btnArtist.Location = New System.Drawing.Point(27, 226)
        Me.btnArtist.Name = "btnArtist"
        Me.btnArtist.Size = New System.Drawing.Size(116, 51)
        Me.btnArtist.TabIndex = 0
        Me.btnArtist.Text = "Artist"
        Me.btnArtist.UseVisualStyleBackColor = True
        '
        'btnMaintenance
        '
        Me.btnMaintenance.Location = New System.Drawing.Point(441, 226)
        Me.btnMaintenance.Name = "btnMaintenance"
        Me.btnMaintenance.Size = New System.Drawing.Size(116, 51)
        Me.btnMaintenance.TabIndex = 1
        Me.btnMaintenance.Text = "Maintenance"
        Me.btnMaintenance.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(205, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'btnArt
        '
        Me.btnArt.Location = New System.Drawing.Point(165, 226)
        Me.btnArt.Name = "btnArt"
        Me.btnArt.Size = New System.Drawing.Size(116, 51)
        Me.btnArt.TabIndex = 17
        Me.btnArt.Text = "Artwork"
        Me.btnArt.UseVisualStyleBackColor = True
        '
        'btnEvents
        '
        Me.btnEvents.Location = New System.Drawing.Point(300, 226)
        Me.btnEvents.Name = "btnEvents"
        Me.btnEvents.Size = New System.Drawing.Size(116, 51)
        Me.btnEvents.TabIndex = 18
        Me.btnEvents.Text = "Events"
        Me.btnEvents.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(506, 13)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 19
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(589, 365)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnEvents)
        Me.Controls.Add(Me.btnArt)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnMaintenance)
        Me.Controls.Add(Me.btnArtist)
        Me.Name = "Home"
        Me.Text = "Stone Quarry Hill Art Park"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnArtist As Button
    Friend WithEvents btnMaintenance As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnArt As Button
    Friend WithEvents btnEvents As Button
    Friend WithEvents btnExit As Button
End Class
