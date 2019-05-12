Module Module1
    'Print books'
    Public Const BookYourWay = 11.95
    Public Const BookPaperScotland = 14.5
    Public Const BookPaperCalculus = 29.95
    Public Const BookStress = 18.5

    'Audio books'
    Public Const BookAudioCalculus = 29.95
    Public Const BookAudioScotland = 14.5
    Public Const BookScience = 12.95
    Public Const BookRelaxation = 11.5

    'Tax and shop'
    Public Const Tax = 0.06
    Public Const ShipCharge = 2.0

    Public Sub Main()
        Application.Run(frmCart)
    End Sub

    Public Sub Calculate()
        Dim subTotal As Decimal = 0
        Dim totalTax As Decimal = 0
        Dim totalShipping As Decimal = 0
        Dim total As Decimal = 0
        For Each item In frmCart.lstBoxProducts.Items
            If item.ToString = "I Did It Your Way (Print)" Then
                subTotal += CDec(BookYourWay)
            End If
            If item.ToString = "The History of Scotland (Print)" Then
                subTotal += CDec(BookPaperScotland)
            End If
            If item.ToString = "Learn Calculus in One Day (Print)" Then
                subTotal += CDec(BookPaperCalculus)
            End If
            If item.ToString = "Feel the Stress (Print)" Then
                subTotal += CDec(BookStress)
            End If
            If item.ToString = "Learn Calculus in One Day (Audio)" Then
                subTotal += CDec(BookAudioCalculus)
            End If
            If item.ToString = "Relaxation Techniques (Audio)" Then
                subTotal += CDec(BookRelaxation)
            End If
            If item.ToString = "The History of Scotland (Audio)" Then
                subTotal += CDec(BookAudioScotland)
            End If
            If item.ToString = "The Science of Body Language (Audio)" Then
                subTotal += CDec(BookScience)
            End If
        Next
        totalTax = (subTotal * CDec(Tax))
        totalShipping = (frmCart.lstBoxProducts.Items.Count * CDec(ShipCharge))
        total = subTotal + totalTax + totalShipping

        frmCart.txtBoxSubtotal.Text = subTotal.ToString("c")
        frmCart.txtBoxTax.Text = totalTax.ToString("c")
        frmCart.txtBoxShipping.Text = totalShipping.ToString("c")
        frmCart.txtBoxTotal.Text = total.ToString("c")
    End Sub

    Public Sub Add()

        If Application.OpenForms().OfType(Of frmPrint).Any Then
            frmCart.lstBoxProducts.Items.Add(frmPrint.lstBoxPrint.SelectedItem)
            Calculate()
        End If

        If Application.OpenForms().OfType(Of frmAudio).Any Then
            frmCart.lstBoxProducts.Items.Add(frmAudio.lstBoxAudio.SelectedItem)
            Calculate()
        End If
    End Sub

    Public Sub Close()
        If frmPrint.btnClose.Focused() Then
            frmPrint.Close()
        End If
        If frmAudio.btnClose.Focused() Then
            frmAudio.Close()
        End If
    End Sub

End Module
