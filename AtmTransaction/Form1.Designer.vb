<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.PanelMain = New System.Windows.Forms.Panel()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.PanelResult = New System.Windows.Forms.Panel()
        Me.lblRemAvailBal = New System.Windows.Forms.Label()
        Me.lblWithDepBalSide = New System.Windows.Forms.Label()
        Me.lblWithDepAmount = New System.Windows.Forms.Label()
        Me.lblWithDepSide = New System.Windows.Forms.Label()
        Me.PanelBalance = New System.Windows.Forms.Panel()
        Me.lblAvailBal = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PanelWithDep = New System.Windows.Forms.Panel()
        Me.lblMsgMain = New System.Windows.Forms.Label()
        Me.btnExecuteMain = New System.Windows.Forms.Button()
        Me.tbxWithDepAmount = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblWithDepHeader = New System.Windows.Forms.Label()
        Me.btnAccBalMain = New System.Windows.Forms.Button()
        Me.btnWithdrawMain = New System.Windows.Forms.Button()
        Me.btnDepositMain = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblNameMain = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanelMain.SuspendLayout()
        Me.PanelResult.SuspendLayout()
        Me.PanelBalance.SuspendLayout()
        Me.PanelWithDep.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMain
        '
        Me.PanelMain.Controls.Add(Me.PanelResult)
        Me.PanelMain.Controls.Add(Me.btnReset)
        Me.PanelMain.Controls.Add(Me.PanelBalance)
        Me.PanelMain.Controls.Add(Me.PanelWithDep)
        Me.PanelMain.Controls.Add(Me.btnAccBalMain)
        Me.PanelMain.Controls.Add(Me.btnWithdrawMain)
        Me.PanelMain.Controls.Add(Me.btnDepositMain)
        Me.PanelMain.Controls.Add(Me.Label2)
        Me.PanelMain.Controls.Add(Me.lblNameMain)
        Me.PanelMain.Controls.Add(Me.Label1)
        Me.PanelMain.Location = New System.Drawing.Point(12, 12)
        Me.PanelMain.Name = "PanelMain"
        Me.PanelMain.Size = New System.Drawing.Size(480, 384)
        Me.PanelMain.TabIndex = 0
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(378, 354)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'PanelResult
        '
        Me.PanelResult.Controls.Add(Me.lblRemAvailBal)
        Me.PanelResult.Controls.Add(Me.lblWithDepBalSide)
        Me.PanelResult.Controls.Add(Me.lblWithDepAmount)
        Me.PanelResult.Controls.Add(Me.lblWithDepSide)
        Me.PanelResult.Location = New System.Drawing.Point(28, 210)
        Me.PanelResult.Name = "PanelResult"
        Me.PanelResult.Size = New System.Drawing.Size(425, 96)
        Me.PanelResult.TabIndex = 8
        Me.PanelResult.Visible = False
        '
        'lblRemAvailBal
        '
        Me.lblRemAvailBal.AutoSize = True
        Me.lblRemAvailBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRemAvailBal.Location = New System.Drawing.Point(237, 57)
        Me.lblRemAvailBal.Name = "lblRemAvailBal"
        Me.lblRemAvailBal.Size = New System.Drawing.Size(50, 20)
        Me.lblRemAvailBal.TabIndex = 3
        Me.lblRemAvailBal.Text = "Value"
        '
        'lblWithDepBalSide
        '
        Me.lblWithDepBalSide.AutoSize = True
        Me.lblWithDepBalSide.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWithDepBalSide.Location = New System.Drawing.Point(14, 57)
        Me.lblWithDepBalSide.Name = "lblWithDepBalSide"
        Me.lblWithDepBalSide.Size = New System.Drawing.Size(158, 18)
        Me.lblWithDepBalSide.TabIndex = 2
        Me.lblWithDepBalSide.Text = "Rem/Avail Balance: "
        '
        'lblWithDepAmount
        '
        Me.lblWithDepAmount.AutoSize = True
        Me.lblWithDepAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWithDepAmount.Location = New System.Drawing.Point(237, 20)
        Me.lblWithDepAmount.Name = "lblWithDepAmount"
        Me.lblWithDepAmount.Size = New System.Drawing.Size(50, 20)
        Me.lblWithDepAmount.TabIndex = 1
        Me.lblWithDepAmount.Text = "Value"
        '
        'lblWithDepSide
        '
        Me.lblWithDepSide.AutoSize = True
        Me.lblWithDepSide.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWithDepSide.Location = New System.Drawing.Point(14, 22)
        Me.lblWithDepSide.Name = "lblWithDepSide"
        Me.lblWithDepSide.Size = New System.Drawing.Size(144, 18)
        Me.lblWithDepSide.TabIndex = 0
        Me.lblWithDepSide.Text = "Amount With/Dep "
        '
        'PanelBalance
        '
        Me.PanelBalance.Controls.Add(Me.lblAvailBal)
        Me.PanelBalance.Controls.Add(Me.Label4)
        Me.PanelBalance.Location = New System.Drawing.Point(17, 49)
        Me.PanelBalance.Name = "PanelBalance"
        Me.PanelBalance.Size = New System.Drawing.Size(436, 36)
        Me.PanelBalance.TabIndex = 7
        Me.PanelBalance.Visible = False
        '
        'lblAvailBal
        '
        Me.lblAvailBal.AutoSize = True
        Me.lblAvailBal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvailBal.Location = New System.Drawing.Point(199, 7)
        Me.lblAvailBal.Name = "lblAvailBal"
        Me.lblAvailBal.Size = New System.Drawing.Size(50, 20)
        Me.lblAvailBal.TabIndex = 1
        Me.lblAvailBal.Text = "Value"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(155, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Account Balance: "
        '
        'PanelWithDep
        '
        Me.PanelWithDep.Controls.Add(Me.lblMsgMain)
        Me.PanelWithDep.Controls.Add(Me.btnExecuteMain)
        Me.PanelWithDep.Controls.Add(Me.tbxWithDepAmount)
        Me.PanelWithDep.Controls.Add(Me.Label3)
        Me.PanelWithDep.Controls.Add(Me.lblWithDepHeader)
        Me.PanelWithDep.Location = New System.Drawing.Point(28, 205)
        Me.PanelWithDep.Name = "PanelWithDep"
        Me.PanelWithDep.Size = New System.Drawing.Size(425, 131)
        Me.PanelWithDep.TabIndex = 6
        Me.PanelWithDep.Visible = False
        '
        'lblMsgMain
        '
        Me.lblMsgMain.AutoSize = True
        Me.lblMsgMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMsgMain.ForeColor = System.Drawing.Color.Maroon
        Me.lblMsgMain.Location = New System.Drawing.Point(23, 38)
        Me.lblMsgMain.Name = "lblMsgMain"
        Me.lblMsgMain.Size = New System.Drawing.Size(0, 13)
        Me.lblMsgMain.TabIndex = 4
        '
        'btnExecuteMain
        '
        Me.btnExecuteMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExecuteMain.Location = New System.Drawing.Point(192, 93)
        Me.btnExecuteMain.Name = "btnExecuteMain"
        Me.btnExecuteMain.Size = New System.Drawing.Size(97, 35)
        Me.btnExecuteMain.TabIndex = 3
        Me.btnExecuteMain.Text = "Execute"
        Me.btnExecuteMain.UseVisualStyleBackColor = True
        '
        'tbxWithDepAmount
        '
        Me.tbxWithDepAmount.Location = New System.Drawing.Point(163, 61)
        Me.tbxWithDepAmount.Name = "tbxWithDepAmount"
        Me.tbxWithDepAmount.Size = New System.Drawing.Size(151, 20)
        Me.tbxWithDepAmount.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 63)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Enter Amount"
        '
        'lblWithDepHeader
        '
        Me.lblWithDepHeader.AutoSize = True
        Me.lblWithDepHeader.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.lblWithDepHeader.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWithDepHeader.ForeColor = System.Drawing.Color.White
        Me.lblWithDepHeader.Location = New System.Drawing.Point(165, 7)
        Me.lblWithDepHeader.Name = "lblWithDepHeader"
        Me.lblWithDepHeader.Padding = New System.Windows.Forms.Padding(5)
        Me.lblWithDepHeader.Size = New System.Drawing.Size(176, 30)
        Me.lblWithDepHeader.TabIndex = 0
        Me.lblWithDepHeader.Text = "WIthdrawal/Deposit"
        '
        'btnAccBalMain
        '
        Me.btnAccBalMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAccBalMain.Location = New System.Drawing.Point(173, 142)
        Me.btnAccBalMain.Name = "btnAccBalMain"
        Me.btnAccBalMain.Size = New System.Drawing.Size(157, 35)
        Me.btnAccBalMain.TabIndex = 5
        Me.btnAccBalMain.Text = "Show Balance"
        Me.btnAccBalMain.UseVisualStyleBackColor = True
        '
        'btnWithdrawMain
        '
        Me.btnWithdrawMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnWithdrawMain.Location = New System.Drawing.Point(348, 142)
        Me.btnWithdrawMain.Name = "btnWithdrawMain"
        Me.btnWithdrawMain.Size = New System.Drawing.Size(102, 35)
        Me.btnWithdrawMain.TabIndex = 4
        Me.btnWithdrawMain.Text = "Withdrawal"
        Me.btnWithdrawMain.UseVisualStyleBackColor = True
        '
        'btnDepositMain
        '
        Me.btnDepositMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDepositMain.Location = New System.Drawing.Point(28, 142)
        Me.btnDepositMain.Name = "btnDepositMain"
        Me.btnDepositMain.Size = New System.Drawing.Size(99, 35)
        Me.btnDepositMain.TabIndex = 3
        Me.btnDepositMain.Text = "Deposit"
        Me.btnDepositMain.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(169, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Padding = New System.Windows.Forms.Padding(5)
        Me.Label2.Size = New System.Drawing.Size(161, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Choose Transaction"
        '
        'lblNameMain
        '
        Me.lblNameMain.AutoSize = True
        Me.lblNameMain.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNameMain.Location = New System.Drawing.Point(216, 13)
        Me.lblNameMain.Name = "lblNameMain"
        Me.lblNameMain.Size = New System.Drawing.Size(90, 20)
        Me.lblNameMain.TabIndex = 1
        Me.lblNameMain.Text = "Demo User"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(24, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Name"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 399)
        Me.Controls.Add(Me.PanelMain)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "ATM Transactions"
        Me.PanelMain.ResumeLayout(False)
        Me.PanelMain.PerformLayout()
        Me.PanelResult.ResumeLayout(False)
        Me.PanelResult.PerformLayout()
        Me.PanelBalance.ResumeLayout(False)
        Me.PanelBalance.PerformLayout()
        Me.PanelWithDep.ResumeLayout(False)
        Me.PanelWithDep.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMain As Panel
    Friend WithEvents PanelResult As Panel
    Friend WithEvents lblRemAvailBal As Label
    Friend WithEvents lblWithDepBalSide As Label
    Friend WithEvents lblWithDepAmount As Label
    Friend WithEvents lblWithDepSide As Label
    Friend WithEvents PanelBalance As Panel
    Friend WithEvents lblAvailBal As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PanelWithDep As Panel
    Friend WithEvents lblMsgMain As Label
    Friend WithEvents btnExecuteMain As Button
    Friend WithEvents tbxWithDepAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblWithDepHeader As Label
    Friend WithEvents btnAccBalMain As Button
    Friend WithEvents btnWithdrawMain As Button
    Friend WithEvents btnDepositMain As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lblNameMain As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnReset As Button
End Class
