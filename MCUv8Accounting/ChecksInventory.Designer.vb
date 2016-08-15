<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ChecksInventory
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
        Me.components = New System.ComponentModel.Container()
        Dim BankNameLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.SP_CHECKS_INVENTORYDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GLACC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_CHECKS_INVENTORYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MBv8LedgerDataSet = New MCUv8Accounting.MBv8LedgerDataSet()
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView = New System.Windows.Forms.DataGridView()
        Me.SP_CHECKS_INVENTORY_DETAILBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_CHECKS_INVENTORYTableAdapter = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.SP_CHECKS_INVENTORYTableAdapter()
        Me.TableAdapterManager = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.TableAdapterManager()
        Me.SP_CHECKS_INVENTORY_DETAILTableAdapter = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.SP_CHECKS_INVENTORY_DETAILTableAdapter()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BankAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankAccountsTableAdapter = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.BankAccountsTableAdapter()
        Me.BankNameComboBox = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.StatusAction = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Status = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        BankNameLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SP_CHECKS_INVENTORYDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CHECKS_INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MBv8LedgerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CHECKS_INVENTORY_DETAILDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_CHECKS_INVENTORY_DETAILBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BankAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.AutoScroll = True
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.SP_CHECKS_INVENTORYDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.AutoScroll = True
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Button2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SP_CHECKS_INVENTORY_DETAILDataGridView)
        Me.SplitContainer1.Size = New System.Drawing.Size(937, 559)
        Me.SplitContainer1.SplitterDistance = 256
        Me.SplitContainer1.TabIndex = 0
        '
        'SP_CHECKS_INVENTORYDataGridView
        '
        Me.SP_CHECKS_INVENTORYDataGridView.AllowUserToAddRows = False
        Me.SP_CHECKS_INVENTORYDataGridView.AllowUserToDeleteRows = False
        Me.SP_CHECKS_INVENTORYDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SP_CHECKS_INVENTORYDataGridView.AutoGenerateColumns = False
        Me.SP_CHECKS_INVENTORYDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CHECKS_INVENTORYDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.GLACC})
        Me.SP_CHECKS_INVENTORYDataGridView.DataSource = Me.SP_CHECKS_INVENTORYBindingSource
        Me.SP_CHECKS_INVENTORYDataGridView.Location = New System.Drawing.Point(0, 37)
        Me.SP_CHECKS_INVENTORYDataGridView.MultiSelect = False
        Me.SP_CHECKS_INVENTORYDataGridView.Name = "SP_CHECKS_INVENTORYDataGridView"
        Me.SP_CHECKS_INVENTORYDataGridView.ReadOnly = True
        Me.SP_CHECKS_INVENTORYDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SP_CHECKS_INVENTORYDataGridView.Size = New System.Drawing.Size(935, 219)
        Me.SP_CHECKS_INVENTORYDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BankAccountNum"
        Me.DataGridViewTextBoxColumn1.HeaderText = "BankAccountNum"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "BankName"
        Me.DataGridViewTextBoxColumn2.HeaderText = "BankName"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "CheckID"
        Me.DataGridViewTextBoxColumn3.HeaderText = "CheckID"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TotalChecks"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TotalChecks"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Issued"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Issued"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Remaining"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Remaining"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "DateIssued"
        Me.DataGridViewTextBoxColumn7.HeaderText = "DateIssued"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "BookStatus"
        Me.DataGridViewTextBoxColumn8.HeaderText = "BookStatus"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "EC"
        Me.DataGridViewTextBoxColumn9.HeaderText = "EC"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "EncodedBy"
        Me.DataGridViewTextBoxColumn10.HeaderText = "EncodedBy"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'GLACC
        '
        Me.GLACC.DataPropertyName = "GLACC"
        Me.GLACC.HeaderText = "GLACC"
        Me.GLACC.Name = "GLACC"
        Me.GLACC.ReadOnly = True
        '
        'SP_CHECKS_INVENTORYBindingSource
        '
        Me.SP_CHECKS_INVENTORYBindingSource.DataMember = "SP_CHECKS_INVENTORY"
        Me.SP_CHECKS_INVENTORYBindingSource.DataSource = Me.MBv8LedgerDataSet
        '
        'MBv8LedgerDataSet
        '
        Me.MBv8LedgerDataSet.DataSetName = "MBv8LedgerDataSet"
        Me.MBv8LedgerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_CHECKS_INVENTORY_DETAILDataGridView
        '
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView.AllowUserToAddRows = False
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView.AllowUserToDeleteRows = False
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView.AutoGenerateColumns = False
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StatusAction, Me.Status, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18})
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView.DataSource = Me.SP_CHECKS_INVENTORY_DETAILBindingSource
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView.Location = New System.Drawing.Point(0, 35)
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView.Name = "SP_CHECKS_INVENTORY_DETAILDataGridView"
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView.ReadOnly = True
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView.Size = New System.Drawing.Size(937, 225)
        Me.SP_CHECKS_INVENTORY_DETAILDataGridView.TabIndex = 0
        '
        'SP_CHECKS_INVENTORY_DETAILBindingSource
        '
        Me.SP_CHECKS_INVENTORY_DETAILBindingSource.DataMember = "SP_CHECKS_INVENTORY_DETAIL"
        Me.SP_CHECKS_INVENTORY_DETAILBindingSource.DataSource = Me.MBv8LedgerDataSet
        '
        'SP_CHECKS_INVENTORYTableAdapter
        '
        Me.SP_CHECKS_INVENTORYTableAdapter.ClearBeforeFill = True
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
        'SP_CHECKS_INVENTORY_DETAILTableAdapter
        '
        Me.SP_CHECKS_INVENTORY_DETAILTableAdapter.ClearBeforeFill = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(1257, 559)
        Me.SplitContainer2.SplitterDistance = 937
        Me.SplitContainer2.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(316, 559)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Label2)
        Me.TabPage1.Controls.Add(Me.TextBox2)
        Me.TabPage1.Controls.Add(Label1)
        Me.TabPage1.Controls.Add(Me.TextBox1)
        Me.TabPage1.Controls.Add(BankNameLabel)
        Me.TabPage1.Controls.Add(Me.BankNameComboBox)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(308, 533)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Check Used Listing"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BankAccountsBindingSource
        '
        Me.BankAccountsBindingSource.DataMember = "BankAccounts"
        Me.BankAccountsBindingSource.DataSource = Me.MBv8LedgerDataSet
        '
        'BankAccountsTableAdapter
        '
        Me.BankAccountsTableAdapter.ClearBeforeFill = True
        '
        'BankNameLabel
        '
        BankNameLabel.AutoSize = True
        BankNameLabel.Location = New System.Drawing.Point(24, 37)
        BankNameLabel.Name = "BankNameLabel"
        BankNameLabel.Size = New System.Drawing.Size(66, 13)
        BankNameLabel.TabIndex = 0
        BankNameLabel.Text = "Bank Name:"
        '
        'BankNameComboBox
        '
        Me.BankNameComboBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BankNameComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BankAccountsBindingSource, "BankName", True))
        Me.BankNameComboBox.FormattingEnabled = True
        Me.BankNameComboBox.Location = New System.Drawing.Point(27, 61)
        Me.BankNameComboBox.Name = "BankNameComboBox"
        Me.BankNameComboBox.Size = New System.Drawing.Size(258, 21)
        Me.BankNameComboBox.TabIndex = 1
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(27, 113)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 20)
        Me.TextBox1.TabIndex = 2
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(24, 92)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(71, 13)
        Label1.TabIndex = 3
        Label1.Text = "Start of series"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(24, 144)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(68, 13)
        Label2.TabIndex = 5
        Label2.Text = "End of series"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(27, 165)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(258, 20)
        Me.TextBox2.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(210, 201)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(785, 266)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(140, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Cancel / Recall Selection"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'StatusAction
        '
        Me.StatusAction.HeaderText = "StatusAction"
        Me.StatusAction.Name = "StatusAction"
        Me.StatusAction.ReadOnly = True
        '
        'Status
        '
        Me.Status.HeaderText = "Status"
        Me.Status.Name = "Status"
        Me.Status.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "CheckID"
        Me.DataGridViewTextBoxColumn11.HeaderText = "CheckID"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "IssuedTo"
        Me.DataGridViewTextBoxColumn12.HeaderText = "IssuedTo"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "CheckDate"
        Me.DataGridViewTextBoxColumn13.HeaderText = "CheckDate"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Particulars"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Particulars"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "TransDesc"
        Me.DataGridViewTextBoxColumn16.HeaderText = "TransDesc"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Tag"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Tag"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "UserID"
        Me.DataGridViewTextBoxColumn18.HeaderText = "UserID"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 24)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Check Used Listing"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(179, 24)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Check Books Listing"
        '
        'ChecksInventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 559)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "ChecksInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ChecksInventory"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.SP_CHECKS_INVENTORYDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CHECKS_INVENTORYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MBv8LedgerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CHECKS_INVENTORY_DETAILDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_CHECKS_INVENTORY_DETAILBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.BankAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents MBv8LedgerDataSet As MBv8LedgerDataSet
    Friend WithEvents SP_CHECKS_INVENTORYBindingSource As BindingSource
    Friend WithEvents SP_CHECKS_INVENTORYTableAdapter As MBv8LedgerDataSetTableAdapters.SP_CHECKS_INVENTORYTableAdapter
    Friend WithEvents TableAdapterManager As MBv8LedgerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SP_CHECKS_INVENTORYDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewLinkColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents GLACC As DataGridViewTextBoxColumn
    Friend WithEvents SP_CHECKS_INVENTORY_DETAILBindingSource As BindingSource
    Friend WithEvents SP_CHECKS_INVENTORY_DETAILTableAdapter As MBv8LedgerDataSetTableAdapters.SP_CHECKS_INVENTORY_DETAILTableAdapter
    Friend WithEvents SP_CHECKS_INVENTORY_DETAILDataGridView As DataGridView
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents BankAccountsBindingSource As BindingSource
    Friend WithEvents BankAccountsTableAdapter As MBv8LedgerDataSetTableAdapters.BankAccountsTableAdapter
    Friend WithEvents BankNameComboBox As ComboBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents StatusAction As DataGridViewCheckBoxColumn
    Friend WithEvents Status As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
End Class
