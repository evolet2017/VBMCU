<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FixedAsset
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FixedAsset))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.SP_ASSET_LISTINGDataGridView = New System.Windows.Forms.DataGridView()
        Me.SP_SALES_DISPOSALDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_ASSET_LISTINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MBv8LedgerDataSet = New MCUv8Accounting.MBv8LedgerDataSet()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_SALES_DISPOSALBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_ASSET_LISTINGTableAdapter = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.SP_ASSET_LISTINGTableAdapter()
        Me.TableAdapterManager = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.TableAdapterManager()
        Me.SP_SALES_DISPOSALTableAdapter = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.SP_SALES_DISPOSALTableAdapter()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.SP_ASSET_LISTINGDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_SALES_DISPOSALDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_ASSET_LISTINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MBv8LedgerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_SALES_DISPOSALBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1238, 530)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SP_ASSET_LISTINGDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1230, 504)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Assets"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SP_SALES_DISPOSALDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1230, 504)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Sales and Disposals"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.LinkLabel1)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.Button1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1230, 504)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Import CSV's"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'SP_ASSET_LISTINGDataGridView
        '
        Me.SP_ASSET_LISTINGDataGridView.AllowUserToAddRows = False
        Me.SP_ASSET_LISTINGDataGridView.AllowUserToDeleteRows = False
        Me.SP_ASSET_LISTINGDataGridView.AutoGenerateColumns = False
        Me.SP_ASSET_LISTINGDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_ASSET_LISTINGDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.SP_ASSET_LISTINGDataGridView.DataSource = Me.SP_ASSET_LISTINGBindingSource
        Me.SP_ASSET_LISTINGDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SP_ASSET_LISTINGDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SP_ASSET_LISTINGDataGridView.Name = "SP_ASSET_LISTINGDataGridView"
        Me.SP_ASSET_LISTINGDataGridView.ReadOnly = True
        Me.SP_ASSET_LISTINGDataGridView.Size = New System.Drawing.Size(1224, 498)
        Me.SP_ASSET_LISTINGDataGridView.TabIndex = 0
        '
        'SP_SALES_DISPOSALDataGridView
        '
        Me.SP_SALES_DISPOSALDataGridView.AllowUserToAddRows = False
        Me.SP_SALES_DISPOSALDataGridView.AllowUserToDeleteRows = False
        Me.SP_SALES_DISPOSALDataGridView.AutoGenerateColumns = False
        Me.SP_SALES_DISPOSALDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_SALES_DISPOSALDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15})
        Me.SP_SALES_DISPOSALDataGridView.DataSource = Me.SP_SALES_DISPOSALBindingSource
        Me.SP_SALES_DISPOSALDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SP_SALES_DISPOSALDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.SP_SALES_DISPOSALDataGridView.Name = "SP_SALES_DISPOSALDataGridView"
        Me.SP_SALES_DISPOSALDataGridView.ReadOnly = True
        Me.SP_SALES_DISPOSALDataGridView.Size = New System.Drawing.Size(1224, 498)
        Me.SP_SALES_DISPOSALDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "asset_code"
        Me.DataGridViewTextBoxColumn2.HeaderText = "asset_code"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "asset_desc"
        Me.DataGridViewTextBoxColumn3.HeaderText = "asset_desc"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "po_date"
        Me.DataGridViewTextBoxColumn4.HeaderText = "po_date"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "VendorLink"
        Me.DataGridViewTextBoxColumn5.HeaderText = "VendorLink"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "pur_cost"
        Me.DataGridViewTextBoxColumn6.HeaderText = "pur_cost"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'SP_ASSET_LISTINGBindingSource
        '
        Me.SP_ASSET_LISTINGBindingSource.DataMember = "SP_ASSET_LISTING"
        Me.SP_ASSET_LISTINGBindingSource.DataSource = Me.MBv8LedgerDataSet
        '
        'MBv8LedgerDataSet
        '
        Me.MBv8LedgerDataSet.DataSetName = "MBv8LedgerDataSet"
        Me.MBv8LedgerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn7.HeaderText = "id"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "asset_code"
        Me.DataGridViewTextBoxColumn8.HeaderText = "asset_code"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "asset_desc"
        Me.DataGridViewTextBoxColumn9.HeaderText = "asset_desc"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "po_date"
        Me.DataGridViewTextBoxColumn10.HeaderText = "po_date"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "VendorLink"
        Me.DataGridViewTextBoxColumn11.HeaderText = "VendorLink"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "pur_cost"
        Me.DataGridViewTextBoxColumn12.HeaderText = "pur_cost"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "pur_salvagevalue"
        Me.DataGridViewTextBoxColumn13.HeaderText = "pur_salvagevalue"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "current_value"
        Me.DataGridViewTextBoxColumn14.HeaderText = "current_value"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "monthlydep"
        Me.DataGridViewTextBoxColumn15.HeaderText = "monthlydep"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'SP_SALES_DISPOSALBindingSource
        '
        Me.SP_SALES_DISPOSALBindingSource.DataMember = "SP_SALES_DISPOSAL"
        Me.SP_SALES_DISPOSALBindingSource.DataSource = Me.MBv8LedgerDataSet
        '
        'SP_ASSET_LISTINGTableAdapter
        '
        Me.SP_ASSET_LISTINGTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.accounttypeTableAdapter = Nothing
        Me.TableAdapterManager.appconfigTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.BankAccountsTableAdapter = Nothing
        Me.TableAdapterManager.BankAccTrn_CopyTableAdapter = Nothing
        Me.TableAdapterManager.BankAccTrnTableAdapter = Nothing
        Me.TableAdapterManager.BankAsset2TableAdapter = Nothing
        Me.TableAdapterManager.BankAssetDepreTableAdapter = Nothing
        Me.TableAdapterManager.BankAssetTableAdapter = Nothing
        Me.TableAdapterManager.BankAssetTransTableAdapter = Nothing
        Me.TableAdapterManager.BankBillerTableAdapter = Nothing
        Me.TableAdapterManager.BankBillerTransTableAdapter = Nothing
        Me.TableAdapterManager.BankCashAdvanceTableAdapter = Nothing
        Me.TableAdapterManager.BankChecksTableAdapter = Nothing
        Me.TableAdapterManager.BankCheckTrnTableAdapter = Nothing
        Me.TableAdapterManager.BankCustomGLEntryTableAdapter = Nothing
        Me.TableAdapterManager.BankOperationsTableAdapter = Nothing
        Me.TableAdapterManager.BankOpTransTableAdapter = Nothing
        Me.TableAdapterManager.BankPayablesTableAdapter = Nothing
        Me.TableAdapterManager.BankPettyCashTableAdapter = Nothing
        Me.TableAdapterManager.BankRecon2TableAdapter = Nothing
        Me.TableAdapterManager.BankReconTableAdapter = Nothing
        Me.TableAdapterManager.BankReportsTableAdapter = Nothing
        Me.TableAdapterManager.CheckBooksTableAdapter = Nothing
        Me.TableAdapterManager.CIF2TableAdapter = Nothing
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.dashboardTableAdapter = Nothing
        Me.TableAdapterManager.DF_DATAFORMTableAdapter = Nothing
        Me.TableAdapterManager.DF_TBALTableAdapter = Nothing
        Me.TableAdapterManager.EOD_DatesTableAdapter = Nothing
        Me.TableAdapterManager.EODTableAdapter = Nothing
        Me.TableAdapterManager.GLAC_backupTableAdapter = Nothing
        Me.TableAdapterManager.GLAC_V8TableAdapter = Nothing
        Me.TableAdapterManager.GLACTableAdapter = Nothing
        Me.TableAdapterManager.GLEntryTableAdapter = Nothing
        Me.TableAdapterManager.GLSC_V8TableAdapter = Nothing
        Me.TableAdapterManager.glsc2014TableAdapter = Nothing
        Me.TableAdapterManager.GLSortDescTableAdapter = Nothing
        Me.TableAdapterManager.MasterTRNTableAdapter = Nothing
        Me.TableAdapterManager.menuleftTableAdapter = Nothing
        Me.TableAdapterManager.ModulesTableAdapter = Nothing
        Me.TableAdapterManager.SOAReconTransTableAdapter = Nothing
        Me.TableAdapterManager.SVUCDEPTableAdapter = Nothing
        Me.TableAdapterManager.tmpdashTableAdapter = Nothing
        Me.TableAdapterManager.transactionTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = MCUv8Accounting.MBv8LedgerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.userlevelTableAdapter = Nothing
        Me.TableAdapterManager.usertableTableAdapter = Nothing
        Me.TableAdapterManager.VendorsTableAdapter = Nothing
        '
        'SP_SALES_DISPOSALTableAdapter
        '
        Me.SP_SALES_DISPOSALTableAdapter.ClearBeforeFill = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(25, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Choose File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(110, 21)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(599, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(663, 78)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = resources.GetString("Label1.Text")
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.Location = New System.Drawing.Point(22, 157)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(160, 16)
        Me.LinkLabel1.TabIndex = 3
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Download CSV Template"
        '
        'FixedAsset
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1238, 530)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FixedAsset"
        Me.Text = "FixedAsset"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.SP_ASSET_LISTINGDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_SALES_DISPOSALDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_ASSET_LISTINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MBv8LedgerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_SALES_DISPOSALBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents MBv8LedgerDataSet As MBv8LedgerDataSet
    Friend WithEvents SP_ASSET_LISTINGBindingSource As BindingSource
    Friend WithEvents SP_ASSET_LISTINGTableAdapter As MBv8LedgerDataSetTableAdapters.SP_ASSET_LISTINGTableAdapter
    Friend WithEvents TableAdapterManager As MBv8LedgerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SP_ASSET_LISTINGDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents SP_SALES_DISPOSALBindingSource As BindingSource
    Friend WithEvents SP_SALES_DISPOSALTableAdapter As MBv8LedgerDataSetTableAdapters.SP_SALES_DISPOSALTableAdapter
    Friend WithEvents SP_SALES_DISPOSALDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
