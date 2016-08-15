<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Banking
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
        Dim BankIDLabel As System.Windows.Forms.Label
        Dim BankNameLabel As System.Windows.Forms.Label
        Dim BankAccountNumLabel As System.Windows.Forms.Label
        Dim BankAccountTypeLabel As System.Windows.Forms.Label
        Dim GLACCLabel As System.Windows.Forms.Label
        Dim BankAcctStatusLabel As System.Windows.Forms.Label
        Dim RemarksLabel As System.Windows.Forms.Label
        Dim DateAddedLabel As System.Windows.Forms.Label
        Dim UserIDLabel As System.Windows.Forms.Label
        Dim StartingBalanceLabel As System.Windows.Forms.Label
        Me.MBv8LedgerDataSet = New MCUv8Accounting.MBv8LedgerDataSet()
        Me.SP_BANKING_ACCOUNTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_BANKING_ACCOUNTSTableAdapter = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.SP_BANKING_ACCOUNTSTableAdapter()
        Me.TableAdapterManager = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.TableAdapterManager()
        Me.SP_BANKING_ACCOUNTSDataGridView = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.BankAccTrnDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BankAccTrnBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BankIDTextBox = New System.Windows.Forms.TextBox()
        Me.BankAccountsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankNameTextBox = New System.Windows.Forms.TextBox()
        Me.BankAccountNumTextBox = New System.Windows.Forms.TextBox()
        Me.BankAccountTypeTextBox = New System.Windows.Forms.TextBox()
        Me.GLACCTextBox = New System.Windows.Forms.TextBox()
        Me.BankAcctStatusTextBox = New System.Windows.Forms.TextBox()
        Me.RemarksTextBox = New System.Windows.Forms.TextBox()
        Me.DateAddedDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.UserIDTextBox = New System.Windows.Forms.TextBox()
        Me.StartingBalanceTextBox = New System.Windows.Forms.TextBox()
        Me.BankAccountsTableAdapter = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.BankAccountsTableAdapter()
        Me.BankAccTrnTableAdapter = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.BankAccTrnTableAdapter()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ButtonDeposit_Post_cash = New System.Windows.Forms.Button()
        Me.LabelDeposit_bank_name = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.glbalance = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Action = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Transactions = New System.Windows.Forms.DataGridViewLinkColumn()
        BankIDLabel = New System.Windows.Forms.Label()
        BankNameLabel = New System.Windows.Forms.Label()
        BankAccountNumLabel = New System.Windows.Forms.Label()
        BankAccountTypeLabel = New System.Windows.Forms.Label()
        GLACCLabel = New System.Windows.Forms.Label()
        BankAcctStatusLabel = New System.Windows.Forms.Label()
        RemarksLabel = New System.Windows.Forms.Label()
        DateAddedLabel = New System.Windows.Forms.Label()
        UserIDLabel = New System.Windows.Forms.Label()
        StartingBalanceLabel = New System.Windows.Forms.Label()
        CType(Me.MBv8LedgerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_BANKING_ACCOUNTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_BANKING_ACCOUNTSDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.BankAccTrnDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankAccTrnBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.BankAccountsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'BankIDLabel
        '
        BankIDLabel.AutoSize = True
        BankIDLabel.Location = New System.Drawing.Point(27, 29)
        BankIDLabel.Name = "BankIDLabel"
        BankIDLabel.Size = New System.Drawing.Size(49, 13)
        BankIDLabel.TabIndex = 0
        BankIDLabel.Text = "Bank ID:"
        '
        'BankNameLabel
        '
        BankNameLabel.AutoSize = True
        BankNameLabel.Location = New System.Drawing.Point(27, 55)
        BankNameLabel.Name = "BankNameLabel"
        BankNameLabel.Size = New System.Drawing.Size(66, 13)
        BankNameLabel.TabIndex = 2
        BankNameLabel.Text = "Bank Name:"
        '
        'BankAccountNumLabel
        '
        BankAccountNumLabel.AutoSize = True
        BankAccountNumLabel.Location = New System.Drawing.Point(27, 81)
        BankAccountNumLabel.Name = "BankAccountNumLabel"
        BankAccountNumLabel.Size = New System.Drawing.Size(103, 13)
        BankAccountNumLabel.TabIndex = 4
        BankAccountNumLabel.Text = "Bank Account Num:"
        '
        'BankAccountTypeLabel
        '
        BankAccountTypeLabel.AutoSize = True
        BankAccountTypeLabel.Location = New System.Drawing.Point(27, 107)
        BankAccountTypeLabel.Name = "BankAccountTypeLabel"
        BankAccountTypeLabel.Size = New System.Drawing.Size(105, 13)
        BankAccountTypeLabel.TabIndex = 6
        BankAccountTypeLabel.Text = "Bank Account Type:"
        '
        'GLACCLabel
        '
        GLACCLabel.AutoSize = True
        GLACCLabel.Location = New System.Drawing.Point(27, 133)
        GLACCLabel.Name = "GLACCLabel"
        GLACCLabel.Size = New System.Drawing.Size(45, 13)
        GLACCLabel.TabIndex = 8
        GLACCLabel.Text = "GLACC:"
        '
        'BankAcctStatusLabel
        '
        BankAcctStatusLabel.AutoSize = True
        BankAcctStatusLabel.Location = New System.Drawing.Point(392, 29)
        BankAcctStatusLabel.Name = "BankAcctStatusLabel"
        BankAcctStatusLabel.Size = New System.Drawing.Size(93, 13)
        BankAcctStatusLabel.TabIndex = 10
        BankAcctStatusLabel.Text = "Bank Acct Status:"
        '
        'RemarksLabel
        '
        RemarksLabel.AutoSize = True
        RemarksLabel.Location = New System.Drawing.Point(392, 55)
        RemarksLabel.Name = "RemarksLabel"
        RemarksLabel.Size = New System.Drawing.Size(52, 13)
        RemarksLabel.TabIndex = 12
        RemarksLabel.Text = "Remarks:"
        '
        'DateAddedLabel
        '
        DateAddedLabel.AutoSize = True
        DateAddedLabel.Location = New System.Drawing.Point(392, 82)
        DateAddedLabel.Name = "DateAddedLabel"
        DateAddedLabel.Size = New System.Drawing.Size(67, 13)
        DateAddedLabel.TabIndex = 14
        DateAddedLabel.Text = "Date Added:"
        '
        'UserIDLabel
        '
        UserIDLabel.AutoSize = True
        UserIDLabel.Location = New System.Drawing.Point(392, 107)
        UserIDLabel.Name = "UserIDLabel"
        UserIDLabel.Size = New System.Drawing.Size(46, 13)
        UserIDLabel.TabIndex = 16
        UserIDLabel.Text = "User ID:"
        '
        'StartingBalanceLabel
        '
        StartingBalanceLabel.AutoSize = True
        StartingBalanceLabel.Location = New System.Drawing.Point(392, 133)
        StartingBalanceLabel.Name = "StartingBalanceLabel"
        StartingBalanceLabel.Size = New System.Drawing.Size(88, 13)
        StartingBalanceLabel.TabIndex = 18
        StartingBalanceLabel.Text = "Starting Balance:"
        '
        'MBv8LedgerDataSet
        '
        Me.MBv8LedgerDataSet.DataSetName = "MBv8LedgerDataSet"
        Me.MBv8LedgerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SP_BANKING_ACCOUNTSBindingSource
        '
        Me.SP_BANKING_ACCOUNTSBindingSource.DataMember = "SP_BANKING_ACCOUNTS"
        Me.SP_BANKING_ACCOUNTSBindingSource.DataSource = Me.MBv8LedgerDataSet
        '
        'SP_BANKING_ACCOUNTSTableAdapter
        '
        Me.SP_BANKING_ACCOUNTSTableAdapter.ClearBeforeFill = True
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
        'SP_BANKING_ACCOUNTSDataGridView
        '
        Me.SP_BANKING_ACCOUNTSDataGridView.AllowUserToAddRows = False
        Me.SP_BANKING_ACCOUNTSDataGridView.AllowUserToDeleteRows = False
        Me.SP_BANKING_ACCOUNTSDataGridView.AutoGenerateColumns = False
        Me.SP_BANKING_ACCOUNTSDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_BANKING_ACCOUNTSDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn10, Me.glbalance, Me.Action, Me.Transactions})
        Me.SP_BANKING_ACCOUNTSDataGridView.DataSource = Me.SP_BANKING_ACCOUNTSBindingSource
        Me.SP_BANKING_ACCOUNTSDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SP_BANKING_ACCOUNTSDataGridView.Location = New System.Drawing.Point(0, 0)
        Me.SP_BANKING_ACCOUNTSDataGridView.MultiSelect = False
        Me.SP_BANKING_ACCOUNTSDataGridView.Name = "SP_BANKING_ACCOUNTSDataGridView"
        Me.SP_BANKING_ACCOUNTSDataGridView.ReadOnly = True
        Me.SP_BANKING_ACCOUNTSDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SP_BANKING_ACCOUNTSDataGridView.Size = New System.Drawing.Size(920, 282)
        Me.SP_BANKING_ACCOUNTSDataGridView.TabIndex = 1
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SP_BANKING_ACCOUNTSDataGridView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(920, 565)
        Me.SplitContainer1.SplitterDistance = 282
        Me.SplitContainer1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(920, 279)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.BankAccTrnDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(912, 253)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transactions"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'BankAccTrnDataGridView
        '
        Me.BankAccTrnDataGridView.AllowUserToAddRows = False
        Me.BankAccTrnDataGridView.AllowUserToDeleteRows = False
        Me.BankAccTrnDataGridView.AutoGenerateColumns = False
        Me.BankAccTrnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.BankAccTrnDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16})
        Me.BankAccTrnDataGridView.DataSource = Me.BankAccTrnBindingSource
        Me.BankAccTrnDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.BankAccTrnDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.BankAccTrnDataGridView.Name = "BankAccTrnDataGridView"
        Me.BankAccTrnDataGridView.ReadOnly = True
        Me.BankAccTrnDataGridView.Size = New System.Drawing.Size(906, 247)
        Me.BankAccTrnDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn8.HeaderText = "id"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "v8RunDate"
        Me.DataGridViewTextBoxColumn9.HeaderText = "v8RunDate"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "GLACC"
        Me.DataGridViewTextBoxColumn11.HeaderText = "GLACC"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn12.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Balance"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Balance"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Recon"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Recon"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "MasterID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "MasterID"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Tag"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Tag"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        '
        'BankAccTrnBindingSource
        '
        Me.BankAccTrnBindingSource.DataMember = "BankAccTrn"
        Me.BankAccTrnBindingSource.DataSource = Me.MBv8LedgerDataSet
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(BankIDLabel)
        Me.TabPage2.Controls.Add(Me.BankIDTextBox)
        Me.TabPage2.Controls.Add(BankNameLabel)
        Me.TabPage2.Controls.Add(Me.BankNameTextBox)
        Me.TabPage2.Controls.Add(BankAccountNumLabel)
        Me.TabPage2.Controls.Add(Me.BankAccountNumTextBox)
        Me.TabPage2.Controls.Add(BankAccountTypeLabel)
        Me.TabPage2.Controls.Add(Me.BankAccountTypeTextBox)
        Me.TabPage2.Controls.Add(GLACCLabel)
        Me.TabPage2.Controls.Add(Me.GLACCTextBox)
        Me.TabPage2.Controls.Add(BankAcctStatusLabel)
        Me.TabPage2.Controls.Add(Me.BankAcctStatusTextBox)
        Me.TabPage2.Controls.Add(RemarksLabel)
        Me.TabPage2.Controls.Add(Me.RemarksTextBox)
        Me.TabPage2.Controls.Add(DateAddedLabel)
        Me.TabPage2.Controls.Add(Me.DateAddedDateTimePicker)
        Me.TabPage2.Controls.Add(UserIDLabel)
        Me.TabPage2.Controls.Add(Me.UserIDTextBox)
        Me.TabPage2.Controls.Add(StartingBalanceLabel)
        Me.TabPage2.Controls.Add(Me.StartingBalanceTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(588, 253)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bank Account Details"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'BankIDTextBox
        '
        Me.BankIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BankAccountsBindingSource, "BankID", True))
        Me.BankIDTextBox.Location = New System.Drawing.Point(138, 26)
        Me.BankIDTextBox.Name = "BankIDTextBox"
        Me.BankIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BankIDTextBox.TabIndex = 1
        '
        'BankAccountsBindingSource
        '
        Me.BankAccountsBindingSource.DataMember = "BankAccounts"
        Me.BankAccountsBindingSource.DataSource = Me.MBv8LedgerDataSet
        '
        'BankNameTextBox
        '
        Me.BankNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BankAccountsBindingSource, "BankName", True))
        Me.BankNameTextBox.Location = New System.Drawing.Point(138, 52)
        Me.BankNameTextBox.Name = "BankNameTextBox"
        Me.BankNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BankNameTextBox.TabIndex = 3
        '
        'BankAccountNumTextBox
        '
        Me.BankAccountNumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BankAccountsBindingSource, "BankAccountNum", True))
        Me.BankAccountNumTextBox.Location = New System.Drawing.Point(138, 78)
        Me.BankAccountNumTextBox.Name = "BankAccountNumTextBox"
        Me.BankAccountNumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BankAccountNumTextBox.TabIndex = 5
        '
        'BankAccountTypeTextBox
        '
        Me.BankAccountTypeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BankAccountsBindingSource, "BankAccountType", True))
        Me.BankAccountTypeTextBox.Location = New System.Drawing.Point(138, 104)
        Me.BankAccountTypeTextBox.Name = "BankAccountTypeTextBox"
        Me.BankAccountTypeTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BankAccountTypeTextBox.TabIndex = 7
        '
        'GLACCTextBox
        '
        Me.GLACCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BankAccountsBindingSource, "GLACC", True))
        Me.GLACCTextBox.Location = New System.Drawing.Point(138, 130)
        Me.GLACCTextBox.Name = "GLACCTextBox"
        Me.GLACCTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GLACCTextBox.TabIndex = 9
        '
        'BankAcctStatusTextBox
        '
        Me.BankAcctStatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BankAccountsBindingSource, "BankAcctStatus", True))
        Me.BankAcctStatusTextBox.Location = New System.Drawing.Point(503, 26)
        Me.BankAcctStatusTextBox.Name = "BankAcctStatusTextBox"
        Me.BankAcctStatusTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BankAcctStatusTextBox.TabIndex = 11
        '
        'RemarksTextBox
        '
        Me.RemarksTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BankAccountsBindingSource, "Remarks", True))
        Me.RemarksTextBox.Location = New System.Drawing.Point(503, 52)
        Me.RemarksTextBox.Name = "RemarksTextBox"
        Me.RemarksTextBox.Size = New System.Drawing.Size(200, 20)
        Me.RemarksTextBox.TabIndex = 13
        '
        'DateAddedDateTimePicker
        '
        Me.DateAddedDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.BankAccountsBindingSource, "DateAdded", True))
        Me.DateAddedDateTimePicker.Location = New System.Drawing.Point(503, 78)
        Me.DateAddedDateTimePicker.Name = "DateAddedDateTimePicker"
        Me.DateAddedDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DateAddedDateTimePicker.TabIndex = 15
        '
        'UserIDTextBox
        '
        Me.UserIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BankAccountsBindingSource, "UserID", True))
        Me.UserIDTextBox.Location = New System.Drawing.Point(503, 104)
        Me.UserIDTextBox.Name = "UserIDTextBox"
        Me.UserIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.UserIDTextBox.TabIndex = 17
        '
        'StartingBalanceTextBox
        '
        Me.StartingBalanceTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BankAccountsBindingSource, "StartingBalance", True))
        Me.StartingBalanceTextBox.Location = New System.Drawing.Point(503, 130)
        Me.StartingBalanceTextBox.Name = "StartingBalanceTextBox"
        Me.StartingBalanceTextBox.Size = New System.Drawing.Size(200, 20)
        Me.StartingBalanceTextBox.TabIndex = 19
        '
        'BankAccountsTableAdapter
        '
        Me.BankAccountsTableAdapter.ClearBeforeFill = True
        '
        'BankAccTrnTableAdapter
        '
        Me.BankAccTrnTableAdapter.ClearBeforeFill = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
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
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl2)
        Me.SplitContainer2.Size = New System.Drawing.Size(1226, 567)
        Me.SplitContainer2.SplitterDistance = 922
        Me.SplitContainer2.TabIndex = 3
        '
        'TabControl2
        '
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Controls.Add(Me.TabPage4)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(298, 565)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ButtonDeposit_Post_cash)
        Me.TabPage3.Controls.Add(Me.LabelDeposit_bank_name)
        Me.TabPage3.Controls.Add(Me.TextBox2)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.TextBox1)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(290, 539)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Deposit"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ButtonDeposit_Post_cash
        '
        Me.ButtonDeposit_Post_cash.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ButtonDeposit_Post_cash.Location = New System.Drawing.Point(198, 169)
        Me.ButtonDeposit_Post_cash.Name = "ButtonDeposit_Post_cash"
        Me.ButtonDeposit_Post_cash.Size = New System.Drawing.Size(75, 23)
        Me.ButtonDeposit_Post_cash.TabIndex = 5
        Me.ButtonDeposit_Post_cash.Text = "Post Cash"
        Me.ButtonDeposit_Post_cash.UseVisualStyleBackColor = True
        '
        'LabelDeposit_bank_name
        '
        Me.LabelDeposit_bank_name.AutoSize = True
        Me.LabelDeposit_bank_name.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelDeposit_bank_name.Location = New System.Drawing.Point(19, 22)
        Me.LabelDeposit_bank_name.Name = "LabelDeposit_bank_name"
        Me.LabelDeposit_bank_name.Size = New System.Drawing.Size(138, 29)
        Me.LabelDeposit_bank_name.TabIndex = 4
        Me.LabelDeposit_bank_name.Text = "Bank Name"
        '
        'TextBox2
        '
        Me.TextBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox2.Location = New System.Drawing.Point(22, 133)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(251, 20)
        Me.TextBox2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Transaction Reference"
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.Location = New System.Drawing.Point(22, 85)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(251, 20)
        Me.TextBox1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Amount"
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.Button1)
        Me.TabPage4.Controls.Add(Me.CheckBox1)
        Me.TabPage4.Controls.Add(Me.TextBox5)
        Me.TabPage4.Controls.Add(Me.TextBox6)
        Me.TabPage4.Controls.Add(Me.Label8)
        Me.TabPage4.Controls.Add(Me.TextBox3)
        Me.TabPage4.Controls.Add(Me.Label5)
        Me.TabPage4.Controls.Add(Me.TextBox4)
        Me.TabPage4.Controls.Add(Me.Label6)
        Me.TabPage4.Controls.Add(Me.ComboBox2)
        Me.TabPage4.Controls.Add(Me.Label4)
        Me.TabPage4.Controls.Add(Me.ComboBox1)
        Me.TabPage4.Controls.Add(Me.Label3)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(614, 539)
        Me.TabPage4.TabIndex = 1
        Me.TabPage4.Text = "Fund Transfer"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Location = New System.Drawing.Point(520, 357)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Post"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(22, 298)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(93, 17)
        Me.CheckBox1.TabIndex = 17
        Me.CheckBox1.Text = "Bank Charges"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'TextBox5
        '
        Me.TextBox5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox5.Location = New System.Drawing.Point(20, 320)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(575, 20)
        Me.TextBox5.TabIndex = 16
        '
        'TextBox6
        '
        Me.TextBox6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox6.Location = New System.Drawing.Point(20, 267)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(575, 20)
        Me.TextBox6.TabIndex = 14
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(19, 247)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 13)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Particulars"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(20, 207)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(575, 20)
        Me.TextBox3.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Transaction Reference"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(20, 159)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(575, 20)
        Me.TextBox4.TabIndex = 10
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(19, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(43, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Amount"
        '
        'ComboBox2
        '
        Me.ComboBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(20, 102)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(575, 21)
        Me.ComboBox2.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "To Bank Account"
        '
        'ComboBox1
        '
        Me.ComboBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(20, 42)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(575, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "From Bank Account"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "BankID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "BankID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
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
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "BankAccountNum"
        Me.DataGridViewTextBoxColumn3.HeaderText = "BankAccountNum"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "BankAccountType"
        Me.DataGridViewTextBoxColumn4.HeaderText = "BankAccountType"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "GLACC"
        Me.DataGridViewTextBoxColumn5.HeaderText = "GLACC"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "BankAcctStatus"
        Me.DataGridViewTextBoxColumn6.HeaderText = "BankAcctStatus"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Remarks"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Remarks"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Visible = False
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "StartingBalance"
        Me.DataGridViewTextBoxColumn10.HeaderText = "StartingBalance"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Visible = False
        '
        'glbalance
        '
        Me.glbalance.DataPropertyName = "glbalance"
        Me.glbalance.HeaderText = "glbalance"
        Me.glbalance.Name = "glbalance"
        Me.glbalance.ReadOnly = True
        '
        'Action
        '
        Me.Action.DataPropertyName = "Action"
        Me.Action.HeaderText = "Action"
        Me.Action.Name = "Action"
        Me.Action.ReadOnly = True
        '
        'Transactions
        '
        Me.Transactions.DataPropertyName = "Transactions"
        Me.Transactions.HeaderText = "Transactions"
        Me.Transactions.Name = "Transactions"
        Me.Transactions.ReadOnly = True
        '
        'Banking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1226, 567)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Name = "Banking"
        Me.Text = "Banking"
        CType(Me.MBv8LedgerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_BANKING_ACCOUNTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_BANKING_ACCOUNTSDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.BankAccTrnDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankAccTrnBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.BankAccountsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MBv8LedgerDataSet As MBv8LedgerDataSet
    Friend WithEvents SP_BANKING_ACCOUNTSBindingSource As BindingSource
    Friend WithEvents SP_BANKING_ACCOUNTSTableAdapter As MBv8LedgerDataSetTableAdapters.SP_BANKING_ACCOUNTSTableAdapter
    Friend WithEvents TableAdapterManager As MBv8LedgerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents SP_BANKING_ACCOUNTSDataGridView As DataGridView
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents BankAccountsBindingSource As BindingSource
    Friend WithEvents BankAccountsTableAdapter As MBv8LedgerDataSetTableAdapters.BankAccountsTableAdapter
    Friend WithEvents BankIDTextBox As TextBox
    Friend WithEvents BankNameTextBox As TextBox
    Friend WithEvents BankAccountNumTextBox As TextBox
    Friend WithEvents BankAccountTypeTextBox As TextBox
    Friend WithEvents GLACCTextBox As TextBox
    Friend WithEvents BankAcctStatusTextBox As TextBox
    Friend WithEvents RemarksTextBox As TextBox
    Friend WithEvents DateAddedDateTimePicker As DateTimePicker
    Friend WithEvents UserIDTextBox As TextBox
    Friend WithEvents StartingBalanceTextBox As TextBox
    Friend WithEvents BankAccTrnBindingSource As BindingSource
    Friend WithEvents BankAccTrnTableAdapter As MBv8LedgerDataSetTableAdapters.BankAccTrnTableAdapter
    Friend WithEvents BankAccTrnDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents ButtonDeposit_Post_cash As Button
    Friend WithEvents LabelDeposit_bank_name As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents glbalance As DataGridViewTextBoxColumn
    Friend WithEvents Action As DataGridViewButtonColumn
    Friend WithEvents Transactions As DataGridViewLinkColumn
End Class
