''' <summary>
''' Author: Nigel Mansell
''' Date: 9/30/2017
''' Description: This class, through the use of the procedures btnAdd, btnCalculate,
''' btnReset, and btnExit, adds to a list of costs due to the users selections from 
''' the two list boxes, lstWorkshop and lstLocation, and also calculates the total 
''' cost from all costs within the list of costs.  
''' </summary>
Public Class Form1

    ''' <summary>
    ''' This procedure adds a workshop to a list of costs.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'variables to be used for calculations'
        Dim stressDays As Integer = 3
        Dim stressFee As Integer = 595
        Dim managementDays As Integer = 3
        Dim ManagementFee As Integer = 695
        Dim skillsDays As Integer = 3
        Dim skillsFee As Integer = 995
        Dim negotiationDays As Integer = 5
        Dim negotiationFee As Integer = 1295
        Dim howToDays As Integer = 1
        Dim howToFee As Integer = 395
        Dim Austin As Integer = 95
        Dim Chicago As Integer = 125
        Dim Dallas As Integer = 110
        Dim Orlando As Integer = 100
        Dim Phoenix As Integer = 92
        Dim Raleigh As Integer = 90
        Dim costs As Integer = 0

        'Checks that a workshop is selected, if not, displays message'
        If lstWorkshop.SelectedIndex >= 0 Then

            'Checks that a location is selected, if not, displays message'
            If lstLocation.SelectedIndex >= 0 Then

                'Calculates for handling stess and any location'
                If lstWorkshop.SelectedIndex = 0 Then
                    If lstLocation.SelectedIndex = 0 Then
                        costs += (Austin * stressDays) + stressFee
                    End If
                    If lstLocation.SelectedIndex = 1 Then
                        costs += (Chicago * stressDays) + stressFee
                    End If
                    If lstLocation.SelectedIndex = 2 Then
                        costs += (Dallas * stressDays) + stressFee
                    End If
                    If lstLocation.SelectedIndex = 3 Then
                        costs += (Orlando * stressDays) + stressFee
                    End If
                    If lstLocation.SelectedIndex = 4 Then
                        costs += (Phoenix * stressDays) + stressFee
                    End If
                    If lstLocation.SelectedIndex = 5 Then
                        costs += (Raleigh * stressDays) + stressFee
                    End If
                    lstCosts.Items.Add(costs.ToString("c"))
                End If

                'Calculates for time management and any location'
                If lstWorkshop.SelectedIndex = 1 Then
                    If lstLocation.SelectedIndex = 0 Then
                        costs += (Austin * managementDays) + ManagementFee
                    End If
                    If lstLocation.SelectedIndex = 1 Then
                        costs += (Chicago * managementDays) + ManagementFee
                    End If
                    If lstLocation.SelectedIndex = 2 Then
                        costs += (Dallas * managementDays) + ManagementFee
                    End If
                    If lstLocation.SelectedIndex = 3 Then
                        costs += (Orlando * managementDays) + ManagementFee
                    End If
                    If lstLocation.SelectedIndex = 4 Then
                        costs += (Phoenix * managementDays) + ManagementFee
                    End If
                    If lstLocation.SelectedIndex = 5 Then
                        costs += (Raleigh * managementDays) + ManagementFee
                    End If
                    lstCosts.Items.Add(costs.ToString("c"))
                End If

                'Calculates for supervision skills and any location'
                If lstWorkshop.SelectedIndex = 2 Then
                    If lstLocation.SelectedIndex = 0 Then
                        costs += (Austin * skillsDays) + skillsFee
                    End If
                    If lstLocation.SelectedIndex = 1 Then
                        costs += (Chicago * skillsDays) + skillsFee
                    End If
                    If lstLocation.SelectedIndex = 2 Then
                        costs += (Dallas * skillsDays) + skillsFee
                    End If
                    If lstLocation.SelectedIndex = 3 Then
                        costs += (Orlando * skillsDays) + skillsFee
                    End If
                    If lstLocation.SelectedIndex = 4 Then
                        costs += (Phoenix * skillsDays) + skillsFee
                    End If
                    If lstLocation.SelectedIndex = 5 Then
                        costs += (Raleigh * skillsDays) + skillsFee
                    End If
                    lstCosts.Items.Add(costs.ToString("c"))
                End If

                'Calculates for negotiation and any location'
                If lstWorkshop.SelectedIndex = 3 Then
                    If lstLocation.SelectedIndex = 0 Then
                        costs += (Austin * negotiationDays) + negotiationFee
                    End If
                    If lstLocation.SelectedIndex = 1 Then
                        costs += (Chicago * negotiationDays) + negotiationFee
                    End If
                    If lstLocation.SelectedIndex = 2 Then
                        costs += (Dallas * negotiationDays) + negotiationFee
                    End If
                    If lstLocation.SelectedIndex = 3 Then
                        costs += (Orlando * negotiationDays) + negotiationFee
                    End If
                    If lstLocation.SelectedIndex = 4 Then
                        costs += (Phoenix * negotiationDays) + negotiationFee
                    End If
                    If lstLocation.SelectedIndex = 5 Then
                        costs += (Raleigh * negotiationDays) + negotiationFee
                    End If
                    lstCosts.Items.Add(costs.ToString("c"))
                End If

                'Calculates for how to interview and any location'
                If lstWorkshop.SelectedIndex = 4 Then
                    If lstLocation.SelectedIndex = 0 Then
                        costs += (Austin * howToDays) + howToFee
                    End If
                    If lstLocation.SelectedIndex = 1 Then
                        costs += (Chicago * howToDays) + howToFee
                    End If
                    If lstLocation.SelectedIndex = 2 Then
                        costs += (Dallas * howToDays) + howToFee
                    End If
                    If lstLocation.SelectedIndex = 3 Then
                        costs += (Orlando * howToDays) + howToFee
                    End If
                    If lstLocation.SelectedIndex = 4 Then
                        costs += (Phoenix * howToDays) + howToFee
                    End If
                    If lstLocation.SelectedIndex = 5 Then
                        costs += (Raleigh * howToDays) + howToFee
                    End If
                    lstCosts.Items.Add(costs.ToString("c"))
                End If
                btnCalculate.Enabled = True
            Else
                MessageBox.Show("You must pick a location before continuing.")
            End If

        Else
            MessageBox.Show("You must pick a workshop before continuing.")
        End If
    End Sub

    ''' <summary>
    ''' This procedure calcualtes all costs within list of costs, displays a
    ''' message if the list is empty
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim total As Integer = 0
        If lstCosts.Items.Count > 0 Then
            For Each item In lstCosts.Items
                total += CInt(item)
            Next
            lblCost.Text = total.ToString("c")
            lblTotal.Visible = True
        End If

    End Sub

    ''' <summary>
    ''' This procedure deselects all lists, clears the list of costs and the 
    ''' total, sets focus on first listbox
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lstCosts.Items.Clear()
        lstWorkshop.ClearSelected()
        lstLocation.ClearSelected()
        lblCost.Text = Nothing
        btnCalculate.Enabled = False
        lstWorkshop.SelectedIndex = 0
        lblTotal.Visible = False
    End Sub

    ''' <summary>
    ''' This procedure exits out of the program
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
