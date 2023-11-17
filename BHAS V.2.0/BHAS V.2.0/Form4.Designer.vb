<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnedit = New System.Windows.Forms.Button()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FullNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContactNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TableBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlueHouseAppartmentDataSet3 = New BHAS_V._2._0.BlueHouseAppartmentDataSet3()
        Me.TblboardersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlueHouseAppartmentDataSet = New BHAS_V._2._0.BlueHouseAppartmentDataSet()
        Me.Tbl_boardersTableAdapter = New BHAS_V._2._0.BlueHouseAppartmentDataSetTableAdapters.tbl_boardersTableAdapter()
        Me.BlueHouseAppartmentDataSet1 = New BHAS_V._2._0.BlueHouseAppartmentDataSet1()
        Me.BlueHouseAppartmentDataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BlueHouseAppartmentDataSet2 = New BHAS_V._2._0.BlueHouseAppartmentDataSet2()
        Me.BlueHouseAppartmentDataSet2BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableTableAdapter = New BHAS_V._2._0.BlueHouseAppartmentDataSet3TableAdapters.TableTableAdapter()
        Me.BlueHouseAppartmentDataSet4 = New BHAS_V._2._0.BlueHouseAppartmentDataSet()
        Me.BlueHouseAppartmentDataSet5 = New BHAS_V._2._0.BlueHouseAppartmentDataSet()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueHouseAppartmentDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblboardersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueHouseAppartmentDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueHouseAppartmentDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueHouseAppartmentDataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueHouseAppartmentDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueHouseAppartmentDataSet2BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueHouseAppartmentDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueHouseAppartmentDataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btndelete
        '
        Me.btndelete.BackColor = System.Drawing.Color.Firebrick
        Me.btndelete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.Color.White
        Me.btndelete.Location = New System.Drawing.Point(478, 272)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(112, 38)
        Me.btndelete.TabIndex = 9
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = False
        '
        'btnedit
        '
        Me.btnedit.BackColor = System.Drawing.Color.SeaGreen
        Me.btnedit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnedit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnedit.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnedit.ForeColor = System.Drawing.Color.White
        Me.btnedit.Location = New System.Drawing.Point(360, 272)
        Me.btnedit.Name = "btnedit"
        Me.btnedit.Size = New System.Drawing.Size(112, 38)
        Me.btnedit.TabIndex = 8
        Me.btnedit.Text = "Edit"
        Me.btnedit.UseVisualStyleBackColor = False
        '
        'btnadd
        '
        Me.btnadd.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btnadd.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Font = New System.Drawing.Font("Elephant", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.ForeColor = System.Drawing.Color.White
        Me.btnadd.Location = New System.Drawing.Point(242, 272)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(112, 38)
        Me.btnadd.TabIndex = 7
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.FullNameDataGridViewTextBoxColumn, Me.ContactNoDataGridViewTextBoxColumn, Me.GenderDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.TableBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(14, 11)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(824, 243)
        Me.DataGridView1.TabIndex = 10
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Width = 125
        '
        'FullNameDataGridViewTextBoxColumn
        '
        Me.FullNameDataGridViewTextBoxColumn.DataPropertyName = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.HeaderText = "FullName"
        Me.FullNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FullNameDataGridViewTextBoxColumn.Name = "FullNameDataGridViewTextBoxColumn"
        Me.FullNameDataGridViewTextBoxColumn.Width = 125
        '
        'ContactNoDataGridViewTextBoxColumn
        '
        Me.ContactNoDataGridViewTextBoxColumn.DataPropertyName = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.HeaderText = "ContactNo"
        Me.ContactNoDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.ContactNoDataGridViewTextBoxColumn.Name = "ContactNoDataGridViewTextBoxColumn"
        Me.ContactNoDataGridViewTextBoxColumn.Width = 125
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        Me.GenderDataGridViewTextBoxColumn.Width = 125
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        Me.AddressDataGridViewTextBoxColumn.Width = 125
        '
        'TableBindingSource
        '
        Me.TableBindingSource.DataMember = "Table"
        Me.TableBindingSource.DataSource = Me.BlueHouseAppartmentDataSet3
        '
        'BlueHouseAppartmentDataSet3
        '
        Me.BlueHouseAppartmentDataSet3.DataSetName = "BlueHouseAppartmentDataSet3"
        Me.BlueHouseAppartmentDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblboardersBindingSource
        '
        Me.TblboardersBindingSource.DataMember = "tbl_boarders"
        Me.TblboardersBindingSource.DataSource = Me.BlueHouseAppartmentDataSet
        '
        'BlueHouseAppartmentDataSet
        '
        Me.BlueHouseAppartmentDataSet.DataSetName = "BlueHouseAppartmentDataSet"
        Me.BlueHouseAppartmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Tbl_boardersTableAdapter
        '
        Me.Tbl_boardersTableAdapter.ClearBeforeFill = True
        '
        'BlueHouseAppartmentDataSet1
        '
        Me.BlueHouseAppartmentDataSet1.DataSetName = "BlueHouseAppartmentDataSet1"
        Me.BlueHouseAppartmentDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BlueHouseAppartmentDataSet1BindingSource
        '
        Me.BlueHouseAppartmentDataSet1BindingSource.DataSource = Me.BlueHouseAppartmentDataSet1
        Me.BlueHouseAppartmentDataSet1BindingSource.Position = 0
        '
        'BlueHouseAppartmentDataSet2
        '
        Me.BlueHouseAppartmentDataSet2.DataSetName = "BlueHouseAppartmentDataSet2"
        Me.BlueHouseAppartmentDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BlueHouseAppartmentDataSet2BindingSource
        '
        Me.BlueHouseAppartmentDataSet2BindingSource.DataSource = Me.BlueHouseAppartmentDataSet2
        Me.BlueHouseAppartmentDataSet2BindingSource.Position = 0
        '
        'TableTableAdapter
        '
        Me.TableTableAdapter.ClearBeforeFill = True
        '
        'BlueHouseAppartmentDataSet4
        '
        Me.BlueHouseAppartmentDataSet4.DataSetName = "BlueHouseAppartmentDataSet"
        Me.BlueHouseAppartmentDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BlueHouseAppartmentDataSet5
        '
        Me.BlueHouseAppartmentDataSet5.DataSetName = "BlueHouseAppartmentDataSet"
        Me.BlueHouseAppartmentDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(843, 342)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnedit)
        Me.Controls.Add(Me.btnadd)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Master List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TableBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueHouseAppartmentDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblboardersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueHouseAppartmentDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueHouseAppartmentDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueHouseAppartmentDataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueHouseAppartmentDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueHouseAppartmentDataSet2BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueHouseAppartmentDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueHouseAppartmentDataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btndelete As Button
    Friend WithEvents btnedit As Button
    Friend WithEvents btnadd As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BlueHouseAppartmentDataSet As BlueHouseAppartmentDataSet
    Friend WithEvents TblboardersBindingSource As BindingSource
    Friend WithEvents Tbl_boardersTableAdapter As BlueHouseAppartmentDataSetTableAdapters.tbl_boardersTableAdapter
    Friend WithEvents BlueHouseAppartmentDataSet1BindingSource As BindingSource
    Friend WithEvents BlueHouseAppartmentDataSet1 As BlueHouseAppartmentDataSet1
    Friend WithEvents BlueHouseAppartmentDataSet2BindingSource As BindingSource
    Friend WithEvents BlueHouseAppartmentDataSet2 As BlueHouseAppartmentDataSet2
    Friend WithEvents BlueHouseAppartmentDataSet3 As BlueHouseAppartmentDataSet3
    Friend WithEvents TableBindingSource As BindingSource
    Friend WithEvents TableTableAdapter As BlueHouseAppartmentDataSet3TableAdapters.TableTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FullNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ContactNoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BlueHouseAppartmentDataSet4 As BlueHouseAppartmentDataSet
    Friend WithEvents BlueHouseAppartmentDataSet5 As BlueHouseAppartmentDataSet
End Class
