Public Class Form1
    Private _Balance As Double = 10000

    Private Sub HideAllPanels()
        PanelBalance.Visible = False
        PanelWithDep.Visible = False
        PanelResult.Visible = False
    End Sub

    Private Sub btnAccBalMain_Click(sender As Object, e As EventArgs) Handles btnAccBalMain.Click
        If Not PanelBalance.Visible Then
            btnAccBalMain.Text = "Hide Balance"
            HideAllPanels()
            PanelBalance.Visible = True
            lblAvailBal.Text = String.Format("N{0:F2}", _Balance)
        Else
            btnAccBalMain.Text = "Show Balance"
            PanelBalance.Visible = False
        End If
    End Sub

    Private Sub btnDepositMain_Click(sender As Object, e As EventArgs) Handles btnDepositMain.Click
        lblWithDepHeader.Text = "Deposit"
        tbxWithDepAmount.Clear()
        PanelWithDep.Visible = True
        PanelResult.Visible = False
    End Sub

    Private Sub btnWithdrawMain_Click(sender As Object, e As EventArgs) Handles btnWithdrawMain.Click
        lblWithDepHeader.Text = "WithDrawal"
        tbxWithDepAmount.Clear()
        PanelWithDep.Visible = True
        PanelResult.Visible = False
    End Sub

    Private Sub btnExecuteMain_Click(sender As Object, e As EventArgs) Handles btnExecuteMain.Click
        Dim amount As Double
        If Not Double.TryParse(tbxWithDepAmount.Text, amount) Then
            lblMsgMain.Text = "Please enter a number for amount"
            Return
        Else
            lblMsgMain.Text = ""
        End If

        If lblWithDepHeader.Text = "Deposit" Then
            _Balance += amount
            lblWithDepSide.Text = "Amount Deposited"
            lblWithDepAmount.Text = String.Format("N{0:F2}", amount)
            lblWithDepBalSide.Text = "Available Balance"
            lblRemAvailBal.Text = String.Format("N{0:F2}", _Balance)
            PanelWithDep.Visible = False
            PanelResult.Visible = True
        Else
            If amount > _Balance Then
                lblMsgMain.Text = "Insufficient funds"
            Else
                _Balance -= amount
                lblWithDepSide.Text = "Amount Withdrawn"
                lblWithDepAmount.Text = String.Format("N{0:F2}", amount)
                lblWithDepBalSide.Text = "Remaining Balance"
                lblRemAvailBal.Text = String.Format("N{0:F2}", _Balance)
                PanelWithDep.Visible = False
                PanelResult.Visible = True
            End If
        End If

        lblAvailBal.Text = String.Format("N{0:F2}", _Balance)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        HideAllPanels()
        _Balance = 10000
    End Sub

End Class
