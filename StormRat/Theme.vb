Public Class Theme

    Private Sub Theme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ThemeTextBox.Text = Storm_Rat.themeCustomization : ButtonATextBox.Text = Storm_Rat.buttonACustomization
        ButtonBTextBox.Text = Storm_Rat.buttonBCustomization : LabelPictureBox.BackColor = Storm_Rat.textColor
    End Sub

    Private Sub LabelPictureBox_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LabelPictureBox.DoubleClick
        Dim cd As New ColorDialog : If cd.ShowDialog = DialogResult.OK Then LabelPictureBox.BackColor = cd.Color
    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If ThemeTextBox.Text = "" Or ButtonATextBox.Text = "" Or ButtonBTextBox.Text = "" Then
            MessageBox.Show("Please make sure all the fields are filled in correctly.", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Exit Sub
        End If
        Storm_Rat.themeCustomization = ThemeTextBox.Text : Storm_Rat.buttonACustomization = ButtonATextBox.Text
        Storm_Rat.buttonBCustomization = ButtonBTextBox.Text : Storm_Rat.textColor = LabelPictureBox.BackColor
        ChangeTheme(Storm_Rat.StormTheme) : Me.Close()
    End Sub

    Sub ChangeTheme(ByVal c As Control)
        Storm_Rat.StormTheme.Custimization = ThemeTextBox.Text
        For Each ctl As Control In c.Controls
            If TypeOf ctl Is StormButtonA Then
                If Not ButtonATextBox.Text.Replace(" ", "") = "" Then Dim SBA As StormButtonA = DirectCast(ctl, StormButtonA) : SBA.Custimization = ButtonATextBox.Text
            ElseIf TypeOf ctl Is StormButtonB Then
                If Not ButtonBTextBox.Text.Replace(" ", "") = "" Then Dim SBB As StormButtonB = DirectCast(ctl, StormButtonB) : SBB.Custimization = ButtonBTextBox.Text
            ElseIf TypeOf ctl Is Label Then
                Dim lbl As Label = DirectCast(ctl, Label) : lbl.ForeColor = LabelPictureBox.BackColor
            ElseIf TypeOf ctl Is CheckBox Then
                Dim cb As CheckBox = DirectCast(ctl, CheckBox) : cb.ForeColor = LabelPictureBox.BackColor
            ElseIf TypeOf ctl Is Panel Or TypeOf ctl Is StormRat.GroupBox Then
                ChangeTheme(ctl)
            End If
        Next ctl
    End Sub
End Class