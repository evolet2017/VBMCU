<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CashChecksReceived
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SP_BANK_CASH_INFO_LOADDataGridView = New System.Windows.Forms.DataGridView()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCash_posting_transaction_reference = New System.Windows.Forms.TextBox()
        Me.TextBoxCashPostingAmount = New System.Windows.Forms.TextBox()
        Me.ButtonPostCashDeposit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabelB = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelGLC = New System.Windows.Forms.LinkLabel()
        Me.LinkLabelAN = New System.Windows.Forms.LinkLabel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.LinkLabelAT = New System.Windows.Forms.LinkLabel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBoxCRDeposit = New System.Windows.Forms.ComboBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Sp_bankcheckloadDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SP_BANK_CASH_INFO_LOADBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MBv8LedgerDataSet = New MCUv8Accounting.MBv8LedgerDataSet()
        Me.Sp_bankcheckloadBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Sp_bankcheckloadTableAdapter = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.sp_bankcheckloadTableAdapter()
        Me.TableAdapterManager = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.TableAdapterManager()
        Me.SP_BANK_CASH_INFO_LOADTableAdapter = New MCUv8Accounting.MBv8LedgerDataSetTableAdapters.SP_BANK_CASH_INFO_LOADTableAdapter()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ACTION = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SP_BANK_CASH_INFO_LOADDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.Sp_bankcheckloadDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SP_BANK_CASH_INFO_LOADBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MBv8LedgerDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Sp_bankcheckloadBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1258, 531)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.TextBox3)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.SP_BANK_CASH_INFO_LOADDataGridView)
        Me.TabPage1.Controls.Add(Me.TabControl2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1250, 505)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Cash Received"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(852, 290)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Search :"
        '
        'TextBox3
        '
        Me.TextBox3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox3.Location = New System.Drawing.Point(905, 288)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(335, 20)
        Me.TextBox3.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 276)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(232, 25)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Received Transactions"
        '
        'SP_BANK_CASH_INFO_LOADDataGridView
        '
        Me.SP_BANK_CASH_INFO_LOADDataGridView.AllowUserToAddRows = False
        Me.SP_BANK_CASH_INFO_LOADDataGridView.AllowUserToDeleteRows = False
        Me.SP_BANK_CASH_INFO_LOADDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SP_BANK_CASH_INFO_LOADDataGridView.AutoGenerateColumns = False
        Me.SP_BANK_CASH_INFO_LOADDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SP_BANK_CASH_INFO_LOADDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.SP_BANK_CASH_INFO_LOADDataGridView.DataSource = Me.SP_BANK_CASH_INFO_LOADBindingSource
        Me.SP_BANK_CASH_INFO_LOADDataGridView.Location = New System.Drawing.Point(12, 314)
        Me.SP_BANK_CASH_INFO_LOADDataGridView.MultiSelect = False
        Me.SP_BANK_CASH_INFO_LOADDataGridView.Name = "SP_BANK_CASH_INFO_LOADDataGridView"
        Me.SP_BANK_CASH_INFO_LOADDataGridView.ReadOnly = True
        Me.SP_BANK_CASH_INFO_LOADDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.SP_BANK_CASH_INFO_LOADDataGridView.Size = New System.Drawing.Size(1228, 183)
        Me.SP_BANK_CASH_INFO_LOADDataGridView.TabIndex = 1
        '
        'TabControl2
        '
        Me.TabControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl2.Controls.Add(Me.TabPage3)
        Me.TabControl2.Location = New System.Drawing.Point(8, 6)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1236, 255)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.GroupBox2)
        Me.TabPage3.Controls.Add(Me.GroupBox1)
        Me.TabPage3.Controls.Add(Me.Label2)
        Me.TabPage3.Controls.Add(Me.ComboBoxCRDeposit)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1228, 229)
        Me.TabPage3.TabIndex = 0
        Me.TabPage3.Text = "Bank Deposit"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(411, 44)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(74, 13)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Account Type"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.TextBoxCash_posting_transaction_reference)
        Me.GroupBox2.Controls.Add(Me.TextBoxCashPostingAmount)
        Me.GroupBox2.Controls.Add(Me.ButtonPostCashDeposit)
        Me.GroupBox2.Location = New System.Drawing.Point(525, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(366, 139)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cash Posting"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 63)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Transaction Reference"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Amount"
        '
        'TextBoxCash_posting_transaction_reference
        '
        Me.TextBoxCash_posting_transaction_reference.Location = New System.Drawing.Point(15, 79)
        Me.TextBoxCash_posting_transaction_reference.Name = "TextBoxCash_posting_transaction_reference"
        Me.TextBoxCash_posting_transaction_reference.Size = New System.Drawing.Size(335, 20)
        Me.TextBoxCash_posting_transaction_reference.TabIndex = 5
        '
        'TextBoxCashPostingAmount
        '
        Me.TextBoxCashPostingAmount.Location = New System.Drawing.Point(15, 37)
        Me.TextBoxCashPostingAmount.Name = "TextBoxCashPostingAmount"
        Me.TextBoxCashPostingAmount.Size = New System.Drawing.Size(335, 20)
        Me.TextBoxCashPostingAmount.TabIndex = 2
        '
        'ButtonPostCashDeposit
        '
        Me.ButtonPostCashDeposit.Location = New System.Drawing.Point(248, 106)
        Me.ButtonPostCashDeposit.Name = "ButtonPostCashDeposit"
        Me.ButtonPostCashDeposit.Size = New System.Drawing.Size(102, 23)
        Me.ButtonPostCashDeposit.TabIndex = 4
        Me.ButtonPostCashDeposit.Text = "Post Cash Deposit"
        Me.ButtonPostCashDeposit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LinkLabelB)
        Me.GroupBox1.Controls.Add(Me.LinkLabelGLC)
        Me.GroupBox1.Controls.Add(Me.LinkLabelAN)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.LinkLabelAT)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(489, 139)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Information"
        '
        'LinkLabelB
        '
        Me.LinkLabelB.AutoSize = True
        Me.LinkLabelB.Location = New System.Drawing.Point(164, 109)
        Me.LinkLabelB.Name = "LinkLabelB"
        Me.LinkLabelB.Size = New System.Drawing.Size(10, 13)
        Me.LinkLabelB.TabIndex = 7
        Me.LinkLabelB.TabStop = True
        Me.LinkLabelB.Text = ":"
        '
        'LinkLabelGLC
        '
        Me.LinkLabelGLC.AutoSize = True
        Me.LinkLabelGLC.Location = New System.Drawing.Point(164, 85)
        Me.LinkLabelGLC.Name = "LinkLabelGLC"
        Me.LinkLabelGLC.Size = New System.Drawing.Size(10, 13)
        Me.LinkLabelGLC.TabIndex = 6
        Me.LinkLabelGLC.TabStop = True
        Me.LinkLabelGLC.Text = ":"
        '
        'LinkLabelAN
        '
        Me.LinkLabelAN.AutoSize = True
        Me.LinkLabelAN.Location = New System.Drawing.Point(164, 60)
        Me.LinkLabelAN.Name = "LinkLabelAN"
        Me.LinkLabelAN.Size = New System.Drawing.Size(10, 13)
        Me.LinkLabelAN.TabIndex = 5
        Me.LinkLabelAN.TabStop = True
        Me.LinkLabelAN.Text = ":"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(21, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 13)
        Me.Label11.TabIndex = 4
        Me.Label11.Text = "Balance"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 85)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(108, 13)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "General Ledger Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 60)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(87, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Account Number"
        '
        'LinkLabelAT
        '
        Me.LinkLabelAT.AutoSize = True
        Me.LinkLabelAT.Location = New System.Drawing.Point(164, 35)
        Me.LinkLabelAT.Name = "LinkLabelAT"
        Me.LinkLabelAT.Size = New System.Drawing.Size(10, 13)
        Me.LinkLabelAT.TabIndex = 1
        Me.LinkLabelAT.TabStop = True
        Me.LinkLabelAT.Text = ":"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Account Type"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Bank Account"
        '
        'ComboBoxCRDeposit
        '
        Me.ComboBoxCRDeposit.FormattingEnabled = True
        Me.ComboBoxCRDeposit.Location = New System.Drawing.Point(24, 41)
        Me.ComboBoxCRDeposit.Name = "ComboBoxCRDeposit"
        Me.ComboBoxCRDeposit.Size = New System.Drawing.Size(366, 21)
        Me.ComboBoxCRDeposit.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.TextBox4)
        Me.TabPage2.Controls.Add(Me.Sp_bankcheckloadDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1250, 505)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Checks Received"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 11)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(151, 25)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Check Posting"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(854, 18)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Search :"
        '
        'TextBox4
        '
        Me.TextBox4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox4.Location = New System.Drawing.Point(907, 16)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(335, 20)
        Me.TextBox4.TabIndex = 16
        '
        'Sp_bankcheckloadDataGridView
        '
        Me.Sp_bankcheckloadDataGridView.AllowUserToAddRows = False
        Me.Sp_bankcheckloadDataGridView.AllowUserToDeleteRows = False
        Me.Sp_bankcheckloadDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Sp_bankcheckloadDataGridView.AutoGenerateColumns = False
        Me.Sp_bankcheckloadDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.Sp_bankcheckloadDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.ACTION})
        Me.Sp_bankcheckloadDataGridView.DataSource = Me.Sp_bankcheckloadBindingSource
        Me.Sp_bankcheckloadDataGridView.Location = New System.Drawing.Point(3, 43)
        Me.Sp_bankcheckloadDataGridView.MultiSelect = False
        Me.Sp_bankcheckloadDataGridView.Name = "Sp_bankcheckloadDataGridView"
        Me.Sp_bankcheckloadDataGridView.ReadOnly = True
        Me.Sp_bankcheckloadDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.Sp_bankcheckloadDataGridView.Size = New System.Drawing.Size(1244, 459)
        Me.Sp_bankcheckloadDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "account"
        Me.DataGridViewTextBoxColumn9.HeaderText = "account"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        Me.DataGridViewTextBoxColumn9.ReadOnly = True
        Me.DataGridViewTextBoxColumn9.Width = 200
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "fullname"
        Me.DataGridViewTextBoxColumn10.HeaderText = "fullname"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        Me.DataGridViewTextBoxColumn10.Width = 850
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "amount"
        Me.DataGridViewTextBoxColumn11.HeaderText = "amount"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        Me.DataGridViewTextBoxColumn11.Width = 200
        '
        'SP_BANK_CASH_INFO_LOADBindingSource
        '
        Me.SP_BANK_CASH_INFO_LOADBindingSource.DataMember = "SP_BANK_CASH_INFO_LOAD"
        Me.SP_BANK_CASH_INFO_LOADBindingSource.DataSource = Me.MBv8LedgerDataSet
        '
        'MBv8LedgerDataSet
        '
        Me.MBv8LedgerDataSet.DataSetName = "MBv8LedgerDataSet"
        Me.MBv8LedgerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Sp_bankcheckloadBindingSource
        '
        Me.Sp_bankcheckloadBindingSource.DataMember = "sp_bankcheckload"
        Me.Sp_bankcheckloadBindingSource.DataSource = Me.MBv8LedgerDataSet
        '
        'Sp_bankcheckloadTableAdapter
        '
        Me.Sp_bankcheckloadTableAdapter.ClearBeforeFill = True
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
        'SP_BANK_CASH_INFO_LOADTableAdapter
        '
        Me.SP_BANK_CASH_INFO_LOADTableAdapter.ClearBeforeFill = True
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "id"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 5
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "CHQNUM"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Check #"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "DEPAMT"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "debitacct"
        Me.DataGridViewTextBoxColumn4.HeaderText = "debitacct"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Visible = False
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "BANKACCT"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Bank Account"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.ReadOnly = True
        Me.DataGridViewTextBoxColumn5.Width = 300
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "REFERENCE"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Reference"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.ReadOnly = True
        Me.DataGridViewTextBoxColumn6.Width = 400
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "STATUS"
        Me.DataGridViewTextBoxColumn7.HeaderText = "STATUS"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.ReadOnly = True
        Me.DataGridViewTextBoxColumn7.Width = 200
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "TRNDATE"
        Me.DataGridViewTextBoxColumn8.HeaderText = "TRNDATE"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.ReadOnly = True
        Me.DataGridViewTextBoxColumn8.Visible = False
        '
        'ACTION
        '
        Me.ACTION.DataPropertyName = "ACTION"
        Me.ACTION.HeaderText = "ACTION"
        Me.ACTION.Name = "ACTION"
        Me.ACTION.ReadOnly = True
        '
        'CashChecksReceived
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1258, 531)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "CashChecksReceived"
        Me.Text = "Cash/Checks Received"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.SP_BANK_CASH_INFO_LOADDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.Sp_bankcheckloadDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SP_BANK_CASH_INFO_LOADBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MBv8LedgerDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Sp_bankcheckloadBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MBv8LedgerDataSet As MBv8LedgerDataSet
    Friend WithEvents Sp_bankcheckloadBindingSource As BindingSource
    Friend WithEvents Sp_bankcheckloadTableAdapter As MBv8LedgerDataSetTableAdapters.sp_bankcheckloadTableAdapter
    Friend WithEvents TableAdapterManager As MBv8LedgerDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Sp_bankcheckloadDataGridView As DataGridView
    Friend WithEvents TabControl2 As TabControl
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents SP_BANK_CASH_INFO_LOADBindingSource As BindingSource
    Friend WithEvents SP_BANK_CASH_INFO_LOADTableAdapter As MBv8LedgerDataSetTableAdapters.SP_BANK_CASH_INFO_LOADTableAdapter
    Friend WithEvents SP_BANK_CASH_INFO_LOADDataGridView As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCash_posting_transaction_reference As TextBox
    Friend WithEvents TextBoxCashPostingAmount As TextBox
    Friend WithEvents ButtonPostCashDeposit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ComboBoxCRDeposit As ComboBox
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents LinkLabelB As LinkLabel
    Friend WithEvents LinkLabelGLC As LinkLabel
    Friend WithEvents LinkLabelAN As LinkLabel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents LinkLabelAT As LinkLabel
    Friend WithEvents Label8 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents ACTION As DataGridViewButtonColumn
End Class
