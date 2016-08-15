<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabelCashReceived = New System.Windows.Forms.LinkLabel()
        Me.Labelcash_receive = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabelChecksReceived = New System.Windows.Forms.LinkLabel()
        Me.Labelchecks_receive = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.LinkLabelLoanDisbursement = New System.Windows.Forms.LinkLabel()
        Me.Labelloan_disbursement = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.LinkLabelShareWithdrawals = New System.Windows.Forms.LinkLabel()
        Me.Labelshare_withdrawals = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.LinkLabelBillsPayment = New System.Windows.Forms.LinkLabel()
        Me.Labelbills_payment = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.LinkLabelPuchases = New System.Windows.Forms.LinkLabel()
        Me.Labelpuchases = New System.Windows.Forms.Label()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.LinkLabelPettyCash = New System.Windows.Forms.LinkLabel()
        Me.Labelreflenish_pettycash = New System.Windows.Forms.Label()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.LinkLabelCashAdvance = New System.Windows.Forms.LinkLabel()
        Me.Labelcash_advance = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TimerDashboard = New System.Windows.Forms.Timer(Me.components)
        Me.BW_RELOAD = New System.ComponentModel.BackgroundWorker()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelTotalCashDeposited = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LabelTotalCashDeposited)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.LinkLabelCashReceived)
        Me.GroupBox1.Controls.Add(Me.Labelcash_receive)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(294, 152)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CASH RECEIVED"
        '
        'LinkLabelCashReceived
        '
        Me.LinkLabelCashReceived.AutoSize = True
        Me.LinkLabelCashReceived.Location = New System.Drawing.Point(159, 126)
        Me.LinkLabelCashReceived.Name = "LinkLabelCashReceived"
        Me.LinkLabelCashReceived.Size = New System.Drawing.Size(129, 13)
        Me.LinkLabelCashReceived.TabIndex = 16
        Me.LinkLabelCashReceived.TabStop = True
        Me.LinkLabelCashReceived.Text = "View Full Transaction >>>"
        '
        'Labelcash_receive
        '
        Me.Labelcash_receive.AutoSize = True
        Me.Labelcash_receive.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcash_receive.Location = New System.Drawing.Point(20, 39)
        Me.Labelcash_receive.Name = "Labelcash_receive"
        Me.Labelcash_receive.Size = New System.Drawing.Size(72, 25)
        Me.Labelcash_receive.TabIndex = 13
        Me.Labelcash_receive.Text = "$ 0.00"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.LinkLabelChecksReceived)
        Me.GroupBox2.Controls.Add(Me.Labelchecks_receive)
        Me.GroupBox2.Location = New System.Drawing.Point(312, 55)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(294, 152)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "CHECKS RECEIVED"
        '
        'LinkLabelChecksReceived
        '
        Me.LinkLabelChecksReceived.AutoSize = True
        Me.LinkLabelChecksReceived.Location = New System.Drawing.Point(159, 126)
        Me.LinkLabelChecksReceived.Name = "LinkLabelChecksReceived"
        Me.LinkLabelChecksReceived.Size = New System.Drawing.Size(129, 13)
        Me.LinkLabelChecksReceived.TabIndex = 17
        Me.LinkLabelChecksReceived.TabStop = True
        Me.LinkLabelChecksReceived.Text = "View Full Transaction >>>"
        '
        'Labelchecks_receive
        '
        Me.Labelchecks_receive.AutoSize = True
        Me.Labelchecks_receive.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelchecks_receive.Location = New System.Drawing.Point(22, 39)
        Me.Labelchecks_receive.Name = "Labelchecks_receive"
        Me.Labelchecks_receive.Size = New System.Drawing.Size(72, 25)
        Me.Labelchecks_receive.TabIndex = 15
        Me.Labelchecks_receive.Text = "$ 0.00"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.LinkLabelLoanDisbursement)
        Me.GroupBox3.Controls.Add(Me.Labelloan_disbursement)
        Me.GroupBox3.Location = New System.Drawing.Point(612, 55)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(294, 152)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "LOAN DISBURSEMENT"
        '
        'LinkLabelLoanDisbursement
        '
        Me.LinkLabelLoanDisbursement.AutoSize = True
        Me.LinkLabelLoanDisbursement.Location = New System.Drawing.Point(159, 126)
        Me.LinkLabelLoanDisbursement.Name = "LinkLabelLoanDisbursement"
        Me.LinkLabelLoanDisbursement.Size = New System.Drawing.Size(129, 13)
        Me.LinkLabelLoanDisbursement.TabIndex = 17
        Me.LinkLabelLoanDisbursement.TabStop = True
        Me.LinkLabelLoanDisbursement.Text = "View Full Transaction >>>"
        '
        'Labelloan_disbursement
        '
        Me.Labelloan_disbursement.AutoSize = True
        Me.Labelloan_disbursement.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelloan_disbursement.Location = New System.Drawing.Point(23, 39)
        Me.Labelloan_disbursement.Name = "Labelloan_disbursement"
        Me.Labelloan_disbursement.Size = New System.Drawing.Size(72, 25)
        Me.Labelloan_disbursement.TabIndex = 15
        Me.Labelloan_disbursement.Text = "$ 0.00"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.LinkLabelShareWithdrawals)
        Me.GroupBox4.Controls.Add(Me.Labelshare_withdrawals)
        Me.GroupBox4.Location = New System.Drawing.Point(912, 55)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(294, 152)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "SHARE WITHDRAWALS"
        '
        'LinkLabelShareWithdrawals
        '
        Me.LinkLabelShareWithdrawals.AutoSize = True
        Me.LinkLabelShareWithdrawals.Location = New System.Drawing.Point(159, 126)
        Me.LinkLabelShareWithdrawals.Name = "LinkLabelShareWithdrawals"
        Me.LinkLabelShareWithdrawals.Size = New System.Drawing.Size(129, 13)
        Me.LinkLabelShareWithdrawals.TabIndex = 17
        Me.LinkLabelShareWithdrawals.TabStop = True
        Me.LinkLabelShareWithdrawals.Text = "View Full Transaction >>>"
        '
        'Labelshare_withdrawals
        '
        Me.Labelshare_withdrawals.AutoSize = True
        Me.Labelshare_withdrawals.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelshare_withdrawals.Location = New System.Drawing.Point(21, 39)
        Me.Labelshare_withdrawals.Name = "Labelshare_withdrawals"
        Me.Labelshare_withdrawals.Size = New System.Drawing.Size(72, 25)
        Me.Labelshare_withdrawals.TabIndex = 15
        Me.Labelshare_withdrawals.Text = "$ 0.00"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.LinkLabelBillsPayment)
        Me.GroupBox7.Controls.Add(Me.Labelbills_payment)
        Me.GroupBox7.Location = New System.Drawing.Point(312, 258)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(294, 152)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "BILLS PAYMENT"
        '
        'LinkLabelBillsPayment
        '
        Me.LinkLabelBillsPayment.AutoSize = True
        Me.LinkLabelBillsPayment.Location = New System.Drawing.Point(159, 127)
        Me.LinkLabelBillsPayment.Name = "LinkLabelBillsPayment"
        Me.LinkLabelBillsPayment.Size = New System.Drawing.Size(129, 13)
        Me.LinkLabelBillsPayment.TabIndex = 17
        Me.LinkLabelBillsPayment.TabStop = True
        Me.LinkLabelBillsPayment.Text = "View Full Transaction >>>"
        '
        'Labelbills_payment
        '
        Me.Labelbills_payment.AutoSize = True
        Me.Labelbills_payment.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelbills_payment.Location = New System.Drawing.Point(22, 43)
        Me.Labelbills_payment.Name = "Labelbills_payment"
        Me.Labelbills_payment.Size = New System.Drawing.Size(72, 25)
        Me.Labelbills_payment.TabIndex = 15
        Me.Labelbills_payment.Text = "$ 0.00"
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.LinkLabelPuchases)
        Me.GroupBox8.Controls.Add(Me.Labelpuchases)
        Me.GroupBox8.Location = New System.Drawing.Point(12, 258)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(294, 152)
        Me.GroupBox8.TabIndex = 4
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "PURCHASE(S)"
        '
        'LinkLabelPuchases
        '
        Me.LinkLabelPuchases.AutoSize = True
        Me.LinkLabelPuchases.Location = New System.Drawing.Point(159, 127)
        Me.LinkLabelPuchases.Name = "LinkLabelPuchases"
        Me.LinkLabelPuchases.Size = New System.Drawing.Size(129, 13)
        Me.LinkLabelPuchases.TabIndex = 17
        Me.LinkLabelPuchases.TabStop = True
        Me.LinkLabelPuchases.Text = "View Full Transaction >>>"
        '
        'Labelpuchases
        '
        Me.Labelpuchases.AutoSize = True
        Me.Labelpuchases.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelpuchases.Location = New System.Drawing.Point(20, 43)
        Me.Labelpuchases.Name = "Labelpuchases"
        Me.Labelpuchases.Size = New System.Drawing.Size(72, 25)
        Me.Labelpuchases.TabIndex = 15
        Me.Labelpuchases.Text = "$ 0.00"
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.LinkLabelPettyCash)
        Me.GroupBox11.Controls.Add(Me.Labelreflenish_pettycash)
        Me.GroupBox11.Location = New System.Drawing.Point(312, 467)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(294, 152)
        Me.GroupBox11.TabIndex = 9
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "REFLENISH PETTY CASH"
        '
        'LinkLabelPettyCash
        '
        Me.LinkLabelPettyCash.AutoSize = True
        Me.LinkLabelPettyCash.Location = New System.Drawing.Point(159, 127)
        Me.LinkLabelPettyCash.Name = "LinkLabelPettyCash"
        Me.LinkLabelPettyCash.Size = New System.Drawing.Size(129, 13)
        Me.LinkLabelPettyCash.TabIndex = 17
        Me.LinkLabelPettyCash.TabStop = True
        Me.LinkLabelPettyCash.Text = "View Full Transaction >>>"
        '
        'Labelreflenish_pettycash
        '
        Me.Labelreflenish_pettycash.AutoSize = True
        Me.Labelreflenish_pettycash.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelreflenish_pettycash.Location = New System.Drawing.Point(22, 43)
        Me.Labelreflenish_pettycash.Name = "Labelreflenish_pettycash"
        Me.Labelreflenish_pettycash.Size = New System.Drawing.Size(72, 25)
        Me.Labelreflenish_pettycash.TabIndex = 15
        Me.Labelreflenish_pettycash.Text = "$ 0.00"
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.LinkLabelCashAdvance)
        Me.GroupBox12.Controls.Add(Me.Labelcash_advance)
        Me.GroupBox12.Location = New System.Drawing.Point(12, 467)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(294, 152)
        Me.GroupBox12.TabIndex = 8
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "CASH ADVANCE"
        '
        'LinkLabelCashAdvance
        '
        Me.LinkLabelCashAdvance.AutoSize = True
        Me.LinkLabelCashAdvance.Location = New System.Drawing.Point(159, 127)
        Me.LinkLabelCashAdvance.Name = "LinkLabelCashAdvance"
        Me.LinkLabelCashAdvance.Size = New System.Drawing.Size(129, 13)
        Me.LinkLabelCashAdvance.TabIndex = 17
        Me.LinkLabelCashAdvance.TabStop = True
        Me.LinkLabelCashAdvance.Text = "View Full Transaction >>>"
        '
        'Labelcash_advance
        '
        Me.Labelcash_advance.AutoSize = True
        Me.Labelcash_advance.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Labelcash_advance.Location = New System.Drawing.Point(20, 43)
        Me.Labelcash_advance.Name = "Labelcash_advance"
        Me.Labelcash_advance.Size = New System.Drawing.Size(72, 25)
        Me.Labelcash_advance.TabIndex = 15
        Me.Labelcash_advance.Text = "$ 0.00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(234, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Customer Transactions"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(307, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Outstanding Accounts Payable"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 426)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Operations"
        '
        'TimerDashboard
        '
        Me.TimerDashboard.Interval = 3000
        '
        'BW_RELOAD
        '
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(632, 594)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 15
        Me.Button1.Text = "Reload"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(20, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 18)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Total Cash Deposited :"
        '
        'LabelTotalCashDeposited
        '
        Me.LabelTotalCashDeposited.AutoSize = True
        Me.LabelTotalCashDeposited.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelTotalCashDeposited.ForeColor = System.Drawing.Color.Red
        Me.LabelTotalCashDeposited.Location = New System.Drawing.Point(20, 98)
        Me.LabelTotalCashDeposited.Name = "LabelTotalCashDeposited"
        Me.LabelTotalCashDeposited.Size = New System.Drawing.Size(48, 18)
        Me.LabelTotalCashDeposited.TabIndex = 17
        Me.LabelTotalCashDeposited.Text = "$ 0.00"
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 637)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox11)
        Me.Controls.Add(Me.GroupBox12)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Dashboard"
        Me.Text = "Dashboard"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.GroupBox8.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents GroupBox11 As GroupBox
    Friend WithEvents GroupBox12 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Labelcash_receive As Label
    Friend WithEvents Labelchecks_receive As Label
    Friend WithEvents Labelloan_disbursement As Label
    Friend WithEvents Labelshare_withdrawals As Label
    Friend WithEvents Labelbills_payment As Label
    Friend WithEvents Labelpuchases As Label
    Friend WithEvents Labelreflenish_pettycash As Label
    Friend WithEvents Labelcash_advance As Label
    Friend WithEvents LinkLabelCashReceived As LinkLabel
    Friend WithEvents LinkLabelChecksReceived As LinkLabel
    Friend WithEvents LinkLabelLoanDisbursement As LinkLabel
    Friend WithEvents LinkLabelShareWithdrawals As LinkLabel
    Friend WithEvents LinkLabelBillsPayment As LinkLabel
    Friend WithEvents LinkLabelPuchases As LinkLabel
    Friend WithEvents LinkLabelPettyCash As LinkLabel
    Friend WithEvents LinkLabelCashAdvance As LinkLabel
    Friend WithEvents TimerDashboard As Timer
    Friend WithEvents BW_RELOAD As System.ComponentModel.BackgroundWorker
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelTotalCashDeposited As Label
    Friend WithEvents Label4 As Label
End Class
