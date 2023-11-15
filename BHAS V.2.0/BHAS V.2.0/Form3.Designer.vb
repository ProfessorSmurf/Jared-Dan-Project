<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnpayments = New System.Windows.Forms.Button()
        Me.btnrooms = New System.Windows.Forms.Button()
        Me.btnmasterlist = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(279, 25)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(272, 200)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnpayments
        '
        Me.btnpayments.BackColor = System.Drawing.Color.Firebrick
        Me.btnpayments.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpayments.ForeColor = System.Drawing.Color.White
        Me.btnpayments.Location = New System.Drawing.Point(540, 276)
        Me.btnpayments.Margin = New System.Windows.Forms.Padding(4)
        Me.btnpayments.Name = "btnpayments"
        Me.btnpayments.Size = New System.Drawing.Size(159, 47)
        Me.btnpayments.TabIndex = 6
        Me.btnpayments.Text = "Payments"
        Me.btnpayments.UseVisualStyleBackColor = False
        '
        'btnrooms
        '
        Me.btnrooms.BackColor = System.Drawing.Color.SeaGreen
        Me.btnrooms.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrooms.ForeColor = System.Drawing.Color.White
        Me.btnrooms.Location = New System.Drawing.Point(328, 276)
        Me.btnrooms.Margin = New System.Windows.Forms.Padding(4)
        Me.btnrooms.Name = "btnrooms"
        Me.btnrooms.Size = New System.Drawing.Size(159, 47)
        Me.btnrooms.TabIndex = 5
        Me.btnrooms.Text = "Rooms"
        Me.btnrooms.UseVisualStyleBackColor = False
        '
        'btnmasterlist
        '
        Me.btnmasterlist.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnmasterlist.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmasterlist.ForeColor = System.Drawing.Color.White
        Me.btnmasterlist.Location = New System.Drawing.Point(113, 276)
        Me.btnmasterlist.Margin = New System.Windows.Forms.Padding(4)
        Me.btnmasterlist.Name = "btnmasterlist"
        Me.btnmasterlist.Size = New System.Drawing.Size(159, 47)
        Me.btnmasterlist.TabIndex = 4
        Me.btnmasterlist.Text = "Masterlist"
        Me.btnmasterlist.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 393)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnpayments)
        Me.Controls.Add(Me.btnrooms)
        Me.Controls.Add(Me.btnmasterlist)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btnpayments As Button
    Friend WithEvents btnrooms As Button
    Friend WithEvents btnmasterlist As Button
    Friend WithEvents Label1 As Label
End Class
