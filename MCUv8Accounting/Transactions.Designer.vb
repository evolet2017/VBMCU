<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transactions
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
        Me.Sp_PostedTransactionsDataGridView = New System.Windows.Forms.DataGridView()
        Me.Sp_PostedTransactionsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MBv8LedgerDataSet = New MCUv8Accounting.MBv8LedgerDataSet()
        Me.Sp_PostedTransactionsTableAdapter = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.sp_PostedTransactionsTableAdapter()
        Me.TableAdapterManager = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.TableAdapterManager()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.action = New System.Windows.Forms.DataGridViewButtonColumn()
        CType(Me.Sp_PostedTransactionsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_PostedTransactionsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MBv8LedgerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Sp_PostedTransactionsDataGridView
        '
        Me.Sp_PostedTransactionsDataGridView.AllowUserToAddRows = False
        Me.Sp_PostedTransactionsDataGridView.AllowUserToDeleteRows = False
        Me.Sp_PostedTransactionsDataGridView.AutoGenerateColumns = False
        Me.Sp_PostedTransactionsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sp_PostedTransactionsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn9, Me.action})
        Me.Sp_PostedTransactionsDataGridView.DataSource = Me.Sp_PostedTransactionsBindingSource
        Me.Sp_PostedTransactionsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Sp_PostedTransactionsDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.Sp_PostedTransactionsDataGridView.MultiSelect = False
        Me.Sp_PostedTransactionsDataGridView.Name = "Sp_PostedTransactionsDataGridView"
        Me.Sp_PostedTransactionsDataGridView.ReadOnly = True
        Me.Sp_PostedTransactionsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Sp_PostedTransactionsDataGridView.Size = New System.Drawing.Size(896, 486)
        Me.Sp_PostedTransactionsDataGridView.TabIndex = 1
        '
        'Sp_PostedTransactionsBindingSource
        '
        Me.Sp_PostedTransactionsBindingSource.DataMember = "sp_PostedTransactions"
        Me.Sp_PostedTransactionsBindingSource.DataSource = Me.MBv8LedgerDataSet
        '
        'MBv8LedgerDataSet
        '
        Me.MBv8LedgerDataSet.DataSetName = "MBv8LedgerDataSet"
        Me.MBv8LedgerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_PostedTransactionsTableAdapter
        '
        Me.Sp_PostedTransactionsTableAdapter.ClearBeforeFill = True
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
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "TrnID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "TrnID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Description"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Description"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 300
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Explanation"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Explanation"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn4.HeaderText = "amount"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "status"
        Me.DataGridViewTextBoxColumn5.HeaderText = "status"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Reference"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Reference"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 320
        '
        'action
        '
        Me.action.DataPropertyName = "action"
        Me.action.HeaderText = "Action"
        Me.action.Name = "action"
        Me.action.ReadOnly = True
        '
        'Transactions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(896, 486)
        Me.Controls.Add(Me.Sp_PostedTransactionsDataGridView)
        Me.Name = "Transactions"
        Me.Text = "Transactions"
        CType(Me.Sp_PostedTransactionsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_PostedTransactionsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MBv8LedgerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MBv8LedgerDataSet As MBv8LedgerDataSet
    Friend WithEvents Sp_PostedTransactionsBindingSource As BindingSource
    Friend WithEvents Sp_PostedTransactionsTableAdapter As MBv8LedgerDataSetTableAdapters.sp_PostedTransactionsTableAdapter
    Friend WithEvents TableAdapterManager As MBv8LedgerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_PostedTransactionsDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents action As DataGridViewButtonColumn
End Class
