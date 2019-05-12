''' <summary>
''' Author: Nigel Mansell
''' Date: 10/07/2017
''' This form takes in information from the user to display the cost for all
''' options chosen, along with what was entered into the two text boxes.
''' </summary>
Public Class Form1

    ' Verify that the two input values are valid
    ' numbers and neither is less than zero.
    Function ValidateInputs() As Boolean
        Dim parts As Decimal
        Dim labor As Decimal
        If IsNumeric(txtBoxParts.Text()) And IsNumeric(txtBoxLabor.Text()) Then
            parts = CDec(txtBoxParts.Text)
            labor = CDec(txtBoxLabor.Text)
            If parts >= 0 And labor >= 0 Then
                Return True
            Else
                MessageBox.Show("Both parts and labor must not be less than zero.")
                Return False
            End If
        Else
            MessageBox.Show("Both parts and labor must be numeric.")
            Return False
        End If

    End Function

    ' Calculate all oil and lubrication charges.
    Function CalcOilLubeCharges() As Decimal
        Dim oil As Decimal = 36D
        Dim lube As Decimal = 28D
        Dim total As Decimal = 0
        If chkBoxOil.Checked = True Then
            total += oil
        End If
        If chkBoxLube.Checked = True Then
            total += lube
        End If
        Return total
    End Function

    ' Calculate radiator and transmission flush charges.
    Function CalcFlushCharges() As Decimal
        Dim radiator As Decimal = 50D
        Dim transmission As Decimal = 120D
        Dim total As Decimal = 0
        If chkBoxRadiator.Checked = True Then
            total += radiator
        End If
        If chkBoxTransmission.Checked = True Then
            total += transmission
        End If
        Return total
    End Function

    ' Calculate inspection, muffler, and tire
    ' rotation charges.
    Function CalcMiscCharges() As Decimal
        Dim inspection As Decimal = 15D
        Dim muffler As Decimal = 200D
        Dim rotation As Decimal = 20D
        Dim total As Decimal = 0
        If chkBoxInspection.Checked = True Then
            total += inspection
        End If
        If chkBoxMuffler.Checked = True Then
            total += muffler
        End If
        If chkBoxRotation.Checked = True Then
            total += rotation
        End If
        Return total

    End Function

    'Calculate and display the total of all charges,
    ' including labor, parts, and services.
    Sub CalculateTotalCharges()

        Dim oil As Decimal = CalcOilLubeCharges()
        Dim radAndTrans As Decimal = CalcFlushCharges()
        Dim misc As Decimal = CalcMiscCharges()
        Dim tax As Decimal = 0.06D
        Dim parts As Decimal
        Dim labor As Decimal
        Dim servicesAndLabor As Decimal
        Dim total As Decimal = 0

        If ValidateInputs() = True Then
            parts = CDec(txtBoxParts.Text)
            labor = CDec(txtBoxLabor.Text)
            servicesAndLabor = (oil + radAndTrans + misc + labor)
            total = servicesAndLabor + parts + (parts * tax)
            txtBoxServices.Text = servicesAndLabor.ToString("c")
            txtBoxTax.Text = (parts * tax).ToString("c")
            txtBoxChargers.Text = parts.ToString("c")
            txtBoxTotal.Text = total.ToString("c")
        End If
    End Sub

    ' Reset the oil change and lube job check boxes.
    Sub ClearOilLube()
        chkBoxOil.Checked = False
        chkBoxLube.Checked = False
    End Sub

    ' Clear the radiator and transmission flush check boxes.
    Sub ClearFlushes()
        chkBoxRadiator.Checked = False
        chkBoxTransmission.Checked = False
    End Sub

    'Clear the inspection, muffler replacement, and tire
    ' rotation check boxes.
    Sub ClearMisc()
        chkBoxInspection.Checked = False
        chkBoxMuffler.Checked = False
        chkBoxRotation.Checked = False
    End Sub

    'Clear the parts and labor check boxes.
    Sub ClearOther()
        txtBoxParts.Text = Nothing
        txtBoxLabor.Text = Nothing
        txtBoxServices.Text = Nothing
        txtBoxTax.Text = Nothing
        txtBoxChargers.Text = Nothing
        txtBoxTotal.Text = Nothing
    End Sub

    ''' <summary>
    ''' Calls the four calculate functions from above to display for the user.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        CalculateTotalCharges()
    End Sub

    ''' <summary>
    ''' Calls the four reset and clear function from above to uncheck and clear 
    ''' all check boxes and text boxes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearFlushes()
        ClearOilLube()
        ClearMisc()
        ClearOther()
    End Sub

    ''' <summary>
    ''' Exits out of the form.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
