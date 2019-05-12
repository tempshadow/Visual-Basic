''' <summary>
''' Author: Nigel Mansell
''' Date: 9/17/2017
''' This class uses two radio buttons, three checkboxes and three textboxes to
''' calculate the cost of one to 100 software license.
''' </summary>
Public Class frmSales

    ''' <summary>
    ''' This radio button is selected by default, when the other button is 
    ''' selected, this one is deselected.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles optYearly.CheckedChanged
        If optYearly.Checked = True Then
            optOneTime.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' When this radio button is selected, the other is deselcted.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles optOneTime.CheckedChanged
        If optOneTime.Checked = True Then
            optYearly.Checked = False
        End If
    End Sub

    ''' <summary>
    ''' This button calculates based off which radio button is selected
    ''' along with which checkboxes are selected and how many licenses
    ''' the user enters. After calculations, and checking the email,
    ''' displays back to the user.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Email As String = ""
        Dim EmailTemp As String = ""
        Dim licenseTotal As Integer = 0
        Const YearlyLease As Integer = 5000
        Const OneTimePurchase As Integer = 20000
        Const TechSupport As Integer = 3500
        Const OnSiteTraining As Integer = 2000
        Const CloudBackup As Integer = 300
        Dim LicenseCost As Integer = 0
        Dim featuresCost = 0
        If optYearly.Checked = True Then
            LicenseCost = YearlyLease
        End If

        If optOneTime.Checked = True Then
            LicenseCost = OneTimePurchase
        End If

        If chkSupport.Checked = True Then
            featuresCost += TechSupport
        End If

        If chkTraining.Checked = True Then
            featuresCost += OnSiteTraining
        End If

        If chkBackup.Checked = True Then
            featuresCost += CloudBackup
        End If
        EmailTemp = txtEmail.Text()
        Email = txtEmail.Text().ToLower

        'Checks for the @ symbol
        If Email.Contains("@") = False Then
            MessageBox.Show("Incorrect email format, missing ' @ '")
            txtEmail.Focus()
            txtEmail.SelectAll()
        End If

        'checks for a dot
        If Email.Contains(".") = False Then
            MessageBox.Show("Incorrect email format, missing ' . '")
            txtEmail.Focus()
            txtEmail.SelectAll()
        End If

        'checks for equal email and confirm email
        If Email.Equals(txtConfirm.Text.ToLower) = False Then
            MessageBox.Show("Email and confirm email do not match.")
            txtEmail.Focus()
            txtEmail.SelectAll()
        End If

        Dim total = LicenseCost + featuresCost

        'Nested if statements first checks for equal emails, then checks that
        'the email is more than 0, that the number of license entered is a 
        'whole number between 1 and 100, finishes the calculation depending
        'on whats selected, then outputes accordingly.
        If Email.Equals(txtConfirm.Text.ToLower) = True Then
            If Email.Length > 0 Then

                If (Integer.TryParse(txtLicenseCount.Text, licenseTotal) = True) Then
                    Console.WriteLine(licenseTotal)
                    If (licenseTotal <= 100 And licenseTotal >= 1) Then
                        total = total * licenseTotal

                        If optYearly.Checked = True Then
                            lblEmailOut.Text = "Total number of licenses: " +
                                licenseTotal.ToString() +
                                ", License selected: Yearly. The total cost is: " +
                                total.ToString("c") + "." & vbCrLf & "The bill will be sent to " +
                                EmailTemp
                        End If

                        If optOneTime.Checked = True Then

                            lblEmailOut.Text = "Total number of licenses: " +
                                licenseTotal.ToString() +
                                ", License selected: One-Time Purchase. The total cost is: " +
                                total.ToString("c") + "." & vbCrLf & "The bill will be sent to " +
                                EmailTemp

                        End If

                    Else
                        MessageBox.Show("Please enter a number between 1 and 100.")
                        txtLicenseCount.Focus()
                        txtLicenseCount.SelectAll()

                    End If
                Else
                    MessageBox.Show("Please enter only a number.")
                    txtLicenseCount.Focus()
                    txtLicenseCount.SelectAll()

                End If

            End If

        End If
        txtLicensing.Text() = LicenseCost.ToString("c")
        txtFeatures.Text() = featuresCost.ToString("c")

    End Sub

    ''' <summary>
    ''' Clears out all the all checkboxes, textboxes, and the lable at the
    ''' bottom, also makes use of a messagebox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim msg = "Are you sure you want to clear all?"
        Dim title = "CLEAR"
        Dim yesno = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Critical
        Dim answer = MsgBox(msg, yesno, title)
        If answer = MsgBoxResult.Yes Then
            chkBackup.Checked = False
            chkSupport.Checked = False
            chkTraining.Checked = False
            txtLicensing.Clear()
            txtFeatures.Clear()
            txtEmail.Clear()
            txtConfirm.Clear()
            txtLicenseCount.Clear()
            lblEmailOut.Text = ""
        End If

    End Sub

    ''' <summary>
    ''' Exits the program after making use of a messagebox.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Dim msg = "Are you sure you want to exit?"
        Dim title = "EXIT"
        Dim yesno = MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2 Or
            MsgBoxStyle.Exclamation
        Dim answer = MsgBox(msg, yesno, title)
        If answer = MsgBoxResult.Yes Then
            Application.Exit()
        End If

    End Sub
End Class
