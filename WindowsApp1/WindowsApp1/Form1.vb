''' <summary>
''' Created by Nigel Mansell
''' Date: 9/3/2017
''' This Program uses 6 buttons linked to 6 states along with a clear and 
''' exit button. The six will display the states flag, capital, and
''' abbreviation of the state.Flag pictures are taken from
''' http://www.50states.com/flag/
''' </summary>

Public Class Form1
    ''' <summary>
    ''' This button displays the Virgina flag, its capital, and abbreviation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub VirginiaButton_Click(sender As Object, e As EventArgs) Handles VirginiaButton.Click
        CapAndAbbrevLabel.Text = "Richmond, VA"
        FlagBox.Image = My.Resources.Virginia
        FlagBox.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    ''' <summary>
    ''' This button displays the North Carolina flag, its capital,
    ''' and abbreviation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NorthCarolinaButton_Click(sender As Object, e As EventArgs) Handles NorthCarolinaButton.Click
        CapAndAbbrevLabel.Text = "Raleigh, NC"
        FlagBox.Image = My.Resources.NorthCarolina
        FlagBox.SizeMode = PictureBoxSizeMode.StretchImage

    End Sub

    ''' <summary>
    ''' This button displays the South Carolina flag, its capital,
    ''' and abbreviation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SouthCarolinaButton_Click(sender As Object, e As EventArgs) Handles SouthCarolinaButton.Click
        CapAndAbbrevLabel.Text = "Columbia, SC"
        FlagBox.Image = My.Resources.SouthCarolina
        FlagBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    ''' <summary>
    ''' This button displays the Georgia flag, its capital, and abbreviation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub GeorgiaButton_Click(sender As Object, e As EventArgs) Handles GeorgiaButton.Click
        CapAndAbbrevLabel.Text = "Atlanta, GA"
        FlagBox.Image = My.Resources.Georgia
        FlagBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    ''' <summary>
    ''' This button displays the Alabama flag, its capital, and abbreviation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AlabamaButton_Click(sender As Object, e As EventArgs) Handles AlabamaButton.Click
        CapAndAbbrevLabel.Text = "Montgomery, AL"
        FlagBox.Image = My.Resources.Alabama
        FlagBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    ''' <summary>
    ''' This button displays the Florida flag, its capital, and abbreviation.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FloridaButton_Click(sender As Object, e As EventArgs) Handles FloridaButton.Click
        CapAndAbbrevLabel.Text = "Tallahassee, FL"
        FlagBox.Image = My.Resources.Florida
        FlagBox.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    ''' <summary>
    ''' This button clears the picturebox as well as the capital and
    ''' abbreviatiion label.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        CapAndAbbrevLabel.Text = ""
        FlagBox.Image = Nothing
    End Sub

    ''' <summary>
    ''' This button exits out of the application.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Application.Exit()
    End Sub
End Class
