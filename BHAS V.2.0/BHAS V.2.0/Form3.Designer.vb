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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 30)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(292, 277)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'btnpayments
        '
        Me.btnpayments.BackColor = System.Drawing.Color.Firebrick
        Me.btnpayments.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpayments.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpayments.ForeColor = System.Drawing.Color.Transparent
        Me.btnpayments.Location = New System.Drawing.Point(334, 144)
        Me.btnpayments.Name = "btnpayments"
        Me.btnpayments.Size = New System.Drawing.Size(119, 38)
        Me.btnpayments.TabIndex = 6
        Me.btnpayments.Text = "Payments"
        Me.btnpayments.UseVisualStyleBackColor = False
        '
        'btnrooms
        '
        Me.btnrooms.BackColor = System.Drawing.Color.SeaGreen
        Me.btnrooms.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnrooms.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnrooms.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnrooms.ForeColor = System.Drawing.Color.Transparent
        Me.btnrooms.Location = New System.Drawing.Point(334, 100)
        Me.btnrooms.Name = "btnrooms"
        Me.btnrooms.Size = New System.Drawing.Size(119, 38)
        Me.btnrooms.TabIndex = 5
        Me.btnrooms.Text = "Rooms"
        Me.btnrooms.UseVisualStyleBackColor = False
        '
        'btnmasterlist
        '
        Me.btnmasterlist.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnmasterlist.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmasterlist.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmasterlist.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmasterlist.ForeColor = System.Drawing.Color.Transparent
        Me.btnmasterlist.Location = New System.Drawing.Point(334, 56)
        Me.btnmasterlist.Name = "btnmasterlist"
        Me.btnmasterlist.Size = New System.Drawing.Size(119, 38)
        Me.btnmasterlist.TabIndex = 4
        Me.btnmasterlist.Text = "Masterlist"
        Me.btnmasterlist.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 7)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(42, 16)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Label1"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Magenta
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.Location = New System.Drawing.Point(334, 188)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 38)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Collection Data"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Location = New System.Drawing.Point(334, 232)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(119, 38)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Expenses"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(487, 334)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnpayments)
        Me.Controls.Add(Me.btnrooms)
        Me.Controls.Add(Me.btnmasterlist)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
