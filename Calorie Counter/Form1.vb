Public Class Caloreasy

    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.Enabled = False


        Form3.Show()
        Form3.TopMost = True


        If Form3.Label4.Text = "closed" Then
            Me.Enabled = True
        End If

        Me.WindowState = FormWindowState.Normal
        Me.StartPosition = FormStartPosition.Manual
        With Screen.PrimaryScreen.WorkingArea
            Me.SetBounds(.Left, .Top, .Width, .Height)
        End With

    End Sub









    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked = True Then
            ComboBox2.Enabled = True
            NumericUpDown2.Enabled = True
        ElseIf CheckBox2.Checked = False Then
            ComboBox2.Enabled = False
            NumericUpDown2.Enabled = False
            ComboBox2.SelectedIndex = -1
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked = True Then
            ComboBox3.Enabled = True
            NumericUpDown3.Enabled = True
        ElseIf CheckBox3.Checked = False Then
            ComboBox3.Enabled = False
            NumericUpDown3.Enabled = False
            ComboBox3.SelectedIndex = -1
        End If
    End Sub
    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged
        If CheckBox4.Checked = True Then
            ComboBox4.Enabled = True
            NumericUpDown4.Enabled = True
        ElseIf CheckBox4.Checked = False Then
            ComboBox4.Enabled = False
            NumericUpDown4.Enabled = False
            ComboBox4.SelectedIndex = -1
        End If
    End Sub
    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.CheckedChanged
        If CheckBox5.Checked = True Then
            ComboBox5.Enabled = True
            NumericUpDown5.Enabled = True
        ElseIf CheckBox5.Checked = False Then
            ComboBox5.Enabled = False
            NumericUpDown5.Enabled = False
            ComboBox5.SelectedIndex = -1
        End If
    End Sub
    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.CheckedChanged
        If CheckBox6.Checked = True Then
            ComboBox6.Enabled = True
            NumericUpDown6.Enabled = True
        ElseIf CheckBox6.Checked = False Then
            ComboBox6.Enabled = False
            NumericUpDown6.Enabled = False
            ComboBox6.SelectedIndex = -1
        End If
    End Sub
    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.CheckedChanged
        If CheckBox7.Checked = True Then
            ComboBox7.Enabled = True
            NumericUpDown7.Enabled = True
        ElseIf CheckBox7.Checked = False Then
            ComboBox7.Enabled = False
            NumericUpDown7.Enabled = False
            ComboBox7.SelectedIndex = -1
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim chknCalorieGram As Decimal
        chknCalorieGram = 1.65

        Dim beefCalorieGram As Decimal
        beefCalorieGram = 2.5

        Dim porkCalorieGram As Decimal
        porkCalorieGram = 2.42

        Dim slmCalorieGram As Decimal
        slmCalorieGram = 2.08

        Dim potCalorieGram As Decimal
        potCalorieGram = 0.77

        Dim carCalorieGram As Decimal
        carCalorieGram = 0.41

        Dim wrCalorieGram As Decimal
        wrCalorieGram = 1.3

        Dim brCalorieGram As Decimal
        brCalorieGram = 1.11

        Dim breadCalorieGram As Decimal
        breadCalorieGram = 2.65

        Dim chedCalorieGram As Decimal
        chedCalorieGram = 4.02

        Dim pstaCalorieGram As Decimal
        pstaCalorieGram = 1.31

        Dim cdCalorieGram As Decimal
        cdCalorieGram = 4.95

        Dim yelpCalorieGram As Decimal
        yelpCalorieGram = 0.27

        Dim wbxCalorieGram As Decimal
        wbxCalorieGram = 1.34

        Dim rgCalorieGram As Decimal
        rgCalorieGram = 0.67







        Dim weight As Decimal
        weight = NumericUpDown1.Value

        Dim calories As Decimal
        Dim total As Decimal


        If ComboBox1.SelectedItem = "Grilled chicken breast" Then
            calories = weight * chknCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Grilled topside of beef" Then
            calories = weight * beefCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Grilled pork chop" Then
            calories = weight * porkCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Grilled salmon fillet" Then
            calories = weight * slmCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Potatoes" Then
            calories = weight * potCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Carrots" Then
            calories = weight * carCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "White basmati rice" Then
            calories = weight * wrCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Brown basmati rice" Then
            calories = weight * brCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Wholemeal bread" Then
            calories = weight * breadCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Cheddar cheese" Then
            calories = weight * chedCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Pasta" Then
            calories = weight * pstaCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Chocolate digestive" Then
            calories = weight * cdCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Yellow pepper" Then
            calories = weight * yelpCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Weetabix" Then
            calories = weight * wbxCalorieGram
            total = total + calories

        ElseIf ComboBox1.SelectedItem = "Red grapes" Then
            calories = weight * rgCalorieGram
            total = total + calories
        End If




        Dim weight2 As Decimal
        weight2 = NumericUpDown2.Value

        If ComboBox2.SelectedItem = "Grilled chicken breast" Then
            calories = weight2 * chknCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Grilled topside of beef" Then
            calories = weight2 * beefCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Grilled pork chop" Then
            calories = weight2 * porkCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Grilled salmon fillet" Then
            calories = weight2 * slmCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Potatoes" Then
            calories = weight2 * potCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Carrots" Then
            calories = weight2 * carCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "White basmati rice" Then
            calories = weight2 * wrCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Brown basmati rice" Then
            calories = weight2 * brCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Wholemeal bread" Then
            calories = weight2 * breadCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Cheddar cheese" Then
            calories = weight2 * chedCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Pasta" Then
            calories = weight2 * pstaCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Chocolate digestive" Then
            calories = weight2 * cdCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Yellow pepper" Then
            calories = weight2 * yelpCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Weetabix" Then
            calories = weight2 * wbxCalorieGram
            total = total + calories

        ElseIf ComboBox2.SelectedItem = "Red grapes" Then
            calories = weight2 * rgCalorieGram
            total = total + calories
        End If





        Dim weight3 As Decimal
        weight3 = NumericUpDown3.Value

        If ComboBox3.SelectedItem = "Grilled chicken breast" Then
            calories = weight3 * chknCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Grilled topside of beef" Then
            calories = weight3 * beefCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Grilled pork chop" Then
            calories = weight3 * porkCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Grilled salmon fillet" Then
            calories = weight3 * slmCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Potatoes" Then
            calories = weight3 * potCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Carrots" Then
            calories = weight3 * carCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "White basmati rice" Then
            calories = weight3 * wrCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Brown basmati rice" Then
            calories = weight3 * brCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Wholemeal bread" Then
            calories = weight3 * breadCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Cheddar cheese" Then
            calories = weight3 * chedCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Pasta" Then
            calories = weight3 * pstaCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Chocolate digestive" Then
            calories = weight3 * cdCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Yellow pepper" Then
            calories = weight3 * yelpCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Weetabix" Then
            calories = weight3 * wbxCalorieGram
            total = total + calories

        ElseIf ComboBox3.SelectedItem = "Red grapes" Then
            calories = weight3 * rgCalorieGram
            total = total + calories
        End If




        Dim weight4 As Decimal
        weight4 = NumericUpDown4.Value

        If ComboBox4.SelectedItem = "Grilled chicken breast" Then
            calories = weight4 * chknCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Grilled topside of beef" Then
            calories = weight4 * beefCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Grilled pork chop" Then
            calories = weight4 * porkCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Grilled salmon fillet" Then
            calories = weight4 * slmCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Potatoes" Then
            calories = weight4 * potCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Carrots" Then
            calories = weight4 * carCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "White basmati rice" Then
            calories = weight4 * wrCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Brown basmati rice" Then
            calories = weight4 * brCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Wholemeal bread" Then
            calories = weight4 * breadCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Cheddar cheese" Then
            calories = weight4 * chedCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Pasta" Then
            calories = weight4 * pstaCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Chocolate digestive" Then
            calories = weight4 * cdCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Yellow pepper" Then
            calories = weight4 * yelpCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Weetabix" Then
            calories = weight4 * wbxCalorieGram
            total = total + calories

        ElseIf ComboBox4.SelectedItem = "Red grapes" Then
            calories = weight4 * rgCalorieGram
            total = total + calories
        End If





        Dim weight5 As Decimal
        weight5 = NumericUpDown5.Value

        If ComboBox5.SelectedItem = "Grilled chicken breast" Then
            calories = weight5 * chknCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Grilled topside of beef" Then
            calories = weight5 * beefCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Grilled pork chop" Then
            calories = weight5 * porkCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Grilled salmon fillet" Then
            calories = weight5 * slmCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Potatoes" Then
            calories = weight5 * potCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Carrots" Then
            calories = weight5 * carCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "White basmati rice" Then
            calories = weight5 * wrCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Brown basmati rice" Then
            calories = weight5 * brCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Wholemeal bread" Then
            calories = weight5 * breadCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Cheddar cheese" Then
            calories = weight5 * chedCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Pasta" Then
            calories = weight5 * pstaCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Chocolate digestive" Then
            calories = weight5 * cdCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Yellow pepper" Then
            calories = weight5 * yelpCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Weetabix" Then
            calories = weight5 * wbxCalorieGram
            total = total + calories

        ElseIf ComboBox5.SelectedItem = "Red grapes" Then
            calories = weight5 * rgCalorieGram
            total = total + calories
        End If






        Dim weight6 As Decimal
        weight6 = NumericUpDown3.Value

        If ComboBox6.SelectedItem = "Grilled chicken breast" Then
            calories = weight6 * chknCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Grilled topside of beef" Then
            calories = weight6 * beefCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Grilled pork chop" Then
            calories = weight6 * porkCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Grilled salmon fillet" Then
            calories = weight6 * slmCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Potatoes" Then
            calories = weight6 * potCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Carrots" Then
            calories = weight6 * carCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "White basmati rice" Then
            calories = weight6 * wrCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Brown basmati rice" Then
            calories = weight6 * brCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Wholemeal bread" Then
            calories = weight6 * breadCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Cheddar cheese" Then
            calories = weight6 * chedCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Pasta" Then
            calories = weight6 * pstaCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Chocolate digestive" Then
            calories = weight6 * cdCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Yellow pepper" Then
            calories = weight6 * yelpCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Weetabix" Then
            calories = weight6 * wbxCalorieGram
            total = total + calories

        ElseIf ComboBox6.SelectedItem = "Red grapes" Then
            calories = weight6 * rgCalorieGram
            total = total + calories
        End If





        Dim weight7 As Decimal
        weight7 = NumericUpDown3.Value

        If ComboBox7.SelectedItem = "Grilled chicken breast" Then
            calories = weight7 * chknCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Grilled topside of beef" Then
            calories = weight7 * beefCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Grilled pork chop" Then
            calories = weight7 * porkCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Grilled salmon fillet" Then
            calories = weight7 * slmCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Potatoes" Then
            calories = weight7 * potCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Carrots" Then
            calories = weight7 * carCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "White basmati rice" Then
            calories = weight7 * wrCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Brown basmati rice" Then
            calories = weight7 * brCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Wholemeal bread" Then
            calories = weight7 * breadCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Cheddar cheese" Then
            calories = weight7 * chedCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Pasta" Then
            calories = weight7 * pstaCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Chocolate digestive" Then
            calories = weight7 * cdCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Yellow pepper" Then
            calories = weight7 * yelpCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Weetabix" Then
            calories = weight7 * wbxCalorieGram
            total = total + calories

        ElseIf ComboBox7.SelectedItem = "Red grapes" Then
            calories = weight7 * rgCalorieGram
            total = total + calories
        End If



        Label9.Text = total.ToString
        Label9.TextAlign = ContentAlignment.MiddleCenter
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Label10.Location = New Point(172, 150)

        If ComboBox1.SelectedIndex = 0 Then
            Label10.Text = "Average weight of one chicken breast: 300g"
        ElseIf ComboBox1.SelectedIndex = 1 Then
            Label10.Text = "Average weight of topside of beef: 250g"
        ElseIf ComboBox1.SelectedIndex = 2 Then
            Label10.Text = "Average weight of pork chop (without bone): 150g"
        ElseIf ComboBox1.SelectedIndex = 3 Then
            Label10.Text = "Average weight of salmon fillet: 120g"
        ElseIf ComboBox1.SelectedIndex = 4 Then
            Label10.Text = "Average weight of one potato: 150g"
        ElseIf ComboBox1.SelectedIndex = 5 Then
            Label10.Text = "Average weight of one carrot: 100g"
        ElseIf ComboBox1.SelectedIndex = 6 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox1.SelectedIndex = 7 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox1.SelectedIndex = 8 Then
            Label10.Text = "Average weight of slice of bread: 50g"
        ElseIf ComboBox1.SelectedIndex = 9 Then
            Label10.Text = "Average weight of slice of cheese: 10g"
        ElseIf ComboBox1.SelectedIndex = 10 Then
            Label10.Text = "Average weight of one portion of pasta: 75g dried|120g cooked"
        ElseIf ComboBox1.SelectedIndex = 11 Then
            Label10.Text = "Average weight of biscuit: 17g"
        ElseIf ComboBox1.SelectedIndex = 12 Then
            Label10.Text = "Average weight of one pepper: 170g"
        ElseIf ComboBox1.SelectedIndex = 13 Then
            Label10.Text = "Average weight of one weetabix: 19g"
        ElseIf ComboBox1.SelectedIndex = 14 Then
            Label10.Text = "Average weight of one grape: 6g"
        Else
            Label10.Text = ""
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub


    Private Sub picturebox6_hover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseHover
        PictureBox6.BackgroundImage = New Bitmap("Z:\Caloreasy\images\x red.png")

    End Sub

    Private Sub picturebox6_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox6.MouseLeave
        PictureBox6.BackgroundImage = New Bitmap("Z:\Caloreasy\images\x.png")
    End Sub
    Private Sub picturebox8_hover(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseHover
        PictureBox8.BackgroundImage = New Bitmap("Z:\Caloreasy\images\_ red.png")

    End Sub

    Private Sub picturebox8_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox8.MouseLeave
        PictureBox8.BackgroundImage = New Bitmap("Z:\Caloreasy\images\_.png")
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Me.Enabled = False
        Form2.Show()
        Form2.TopMost = True
        Form2.TopMost = False


    End Sub


    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        Label10.Location = New Point(172, 260)

        If ComboBox2.SelectedIndex = 0 Then
            Label10.Text = "Average weight of one chicken breast: 300g"
        ElseIf ComboBox2.SelectedIndex = 1 Then
            Label10.Text = "Average weight of topside of beef: 250g"
        ElseIf ComboBox2.SelectedIndex = 2 Then
            Label10.Text = "Average weight of pork chop (without bone): 150g"
        ElseIf ComboBox2.SelectedIndex = 3 Then
            Label10.Text = "Average weight of salmon fillet: 120g"
        ElseIf ComboBox2.SelectedIndex = 4 Then
            Label10.Text = "Average weight of one potato: 150g"
        ElseIf ComboBox2.SelectedIndex = 5 Then
            Label10.Text = "Average weight of one carrot: 100g"
        ElseIf ComboBox2.SelectedIndex = 6 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox2.SelectedIndex = 7 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox2.SelectedIndex = 8 Then
            Label10.Text = "Average weight of slice of bread: 50g"
        ElseIf ComboBox2.SelectedIndex = 9 Then
            Label10.Text = "Average weight of slice of cheese: 10g"
        ElseIf ComboBox2.SelectedIndex = 10 Then
            Label10.Text = "Average weight of one portion of pasta: 75g dried|120g cooked"
        ElseIf ComboBox2.SelectedIndex = 11 Then
            Label10.Text = "Average weight of biscuit: 17g"
        ElseIf ComboBox2.SelectedIndex = 12 Then
            Label10.Text = "Average weight of one pepper: 170g"
        ElseIf ComboBox2.SelectedIndex = 13 Then
            Label10.Text = "Average weight of one weetabix: 19g"
        ElseIf ComboBox2.SelectedIndex = 14 Then
            Label10.Text = "Average weight of one grape: 6g"
        Else
            Label10.Text = ""
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Label10.Location = New Point(172, 370)

        If ComboBox3.SelectedIndex = 0 Then
            Label10.Text = "Average weight of one chicken breast: 300g"
        ElseIf ComboBox3.SelectedIndex = 1 Then
            Label10.Text = "Average weight of topside of beef: 250g"
        ElseIf ComboBox3.SelectedIndex = 2 Then
            Label10.Text = "Average weight of pork chop (without bone): 150g"
        ElseIf ComboBox3.SelectedIndex = 3 Then
            Label10.Text = "Average weight of salmon fillet: 120g"
        ElseIf ComboBox3.SelectedIndex = 4 Then
            Label10.Text = "Average weight of one potato: 150g"
        ElseIf ComboBox3.SelectedIndex = 5 Then
            Label10.Text = "Average weight of one carrot: 100g"
        ElseIf ComboBox3.SelectedIndex = 6 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox3.SelectedIndex = 7 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox3.SelectedIndex = 8 Then
            Label10.Text = "Average weight of slice of bread: 50g"
        ElseIf ComboBox3.SelectedIndex = 9 Then
            Label10.Text = "Average weight of slice of cheese: 10g"
        ElseIf ComboBox3.SelectedIndex = 10 Then
            Label10.Text = "Average weight of one portion of pasta: 75g dried|120g cooked"
        ElseIf ComboBox3.SelectedIndex = 11 Then
            Label10.Text = "Average weight of biscuit: 17g"
        ElseIf ComboBox3.SelectedIndex = 12 Then
            Label10.Text = "Average weight of one pepper: 170g"
        ElseIf ComboBox3.SelectedIndex = 13 Then
            Label10.Text = "Average weight of one weetabix: 19g"
        ElseIf ComboBox3.SelectedIndex = 14 Then
            Label10.Text = "Average weight of one grape: 6g"
        Else
            Label10.Text = ""
        End If
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        Label10.Location = New Point(172, 480)
        If ComboBox4.SelectedIndex = 0 Then
            Label10.Text = "Average weight of one chicken breast: 300g"
        ElseIf ComboBox4.SelectedIndex = 1 Then
            Label10.Text = "Average weight of topside of beef: 250g"
        ElseIf ComboBox4.SelectedIndex = 2 Then
            Label10.Text = "Average weight of pork chop (without bone): 150g"
        ElseIf ComboBox4.SelectedIndex = 3 Then
            Label10.Text = "Average weight of salmon fillet: 120g"
        ElseIf ComboBox4.SelectedIndex = 4 Then
            Label10.Text = "Average weight of one potato: 150g"
        ElseIf ComboBox4.SelectedIndex = 5 Then
            Label10.Text = "Average weight of one carrot: 100g"
        ElseIf ComboBox4.SelectedIndex = 6 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox4.SelectedIndex = 7 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox4.SelectedIndex = 8 Then
            Label10.Text = "Average weight of slice of bread: 50g"
        ElseIf ComboBox4.SelectedIndex = 9 Then
            Label10.Text = "Average weight of slice of cheese: 10g"
        ElseIf ComboBox4.SelectedIndex = 10 Then
            Label10.Text = "Average weight of one portion of pasta: 75g dried|120g cooked"
        ElseIf ComboBox4.SelectedIndex = 11 Then
            Label10.Text = "Average weight of biscuit: 17g"
        ElseIf ComboBox4.SelectedIndex = 12 Then
            Label10.Text = "Average weight of one pepper: 170g"
        ElseIf ComboBox4.SelectedIndex = 13 Then
            Label10.Text = "Average weight of one weetabix: 19g"
        ElseIf ComboBox4.SelectedIndex = 14 Then
            Label10.Text = "Average weight of one grape: 6g"
        Else
            Label10.Text = ""
        End If
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox5.SelectedIndexChanged
        Label10.Location = New Point(172, 590)
        If ComboBox5.SelectedIndex = 0 Then
            Label10.Text = "Average weight of one chicken breast: 300g"
        ElseIf ComboBox5.SelectedIndex = 1 Then
            Label10.Text = "Average weight of topside of beef: 250g"
        ElseIf ComboBox5.SelectedIndex = 2 Then
            Label10.Text = "Average weight of pork chop (without bone): 150g"
        ElseIf ComboBox5.SelectedIndex = 3 Then
            Label10.Text = "Average weight of salmon fillet: 120g"
        ElseIf ComboBox5.SelectedIndex = 4 Then
            Label10.Text = "Average weight of one potato: 150g"
        ElseIf ComboBox5.SelectedIndex = 5 Then
            Label10.Text = "Average weight of one carrot: 100g"
        ElseIf ComboBox5.SelectedIndex = 6 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox5.SelectedIndex = 7 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox5.SelectedIndex = 8 Then
            Label10.Text = "Average weight of slice of bread: 50g"
        ElseIf ComboBox5.SelectedIndex = 9 Then
            Label10.Text = "Average weight of slice of cheese: 10g"
        ElseIf ComboBox5.SelectedIndex = 10 Then
            Label10.Text = "Average weight of one portion of pasta: 75g dried|120g cooked"
        ElseIf ComboBox5.SelectedIndex = 11 Then
            Label10.Text = "Average weight of biscuit: 17g"
        ElseIf ComboBox5.SelectedIndex = 12 Then
            Label10.Text = "Average weight of one pepper: 170g"
        ElseIf ComboBox5.SelectedIndex = 13 Then
            Label10.Text = "Average weight of one weetabix: 19g"
        ElseIf ComboBox5.SelectedIndex = 14 Then
            Label10.Text = "Average weight of one grape: 6g"
        Else
            Label10.Text = ""
        End If
    End Sub

    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox6.SelectedIndexChanged
        Label10.Location = New Point(172, 700)
        If ComboBox6.SelectedIndex = 0 Then
            Label10.Text = "Average weight of one chicken breast: 300g"
        ElseIf ComboBox6.SelectedIndex = 1 Then
            Label10.Text = "Average weight of topside of beef: 250g"
        ElseIf ComboBox6.SelectedIndex = 2 Then
            Label10.Text = "Average weight of pork chop (without bone): 150g"
        ElseIf ComboBox6.SelectedIndex = 3 Then
            Label10.Text = "Average weight of salmon fillet: 120g"
        ElseIf ComboBox6.SelectedIndex = 4 Then
            Label10.Text = "Average weight of one potato: 150g"
        ElseIf ComboBox6.SelectedIndex = 5 Then
            Label10.Text = "Average weight of one carrot: 100g"
        ElseIf ComboBox6.SelectedIndex = 6 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox6.SelectedIndex = 7 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox6.SelectedIndex = 8 Then
            Label10.Text = "Average weight of slice of bread: 50g"
        ElseIf ComboBox6.SelectedIndex = 9 Then
            Label10.Text = "Average weight of slice of cheese: 10g"
        ElseIf ComboBox6.SelectedIndex = 10 Then
            Label10.Text = "Average weight of one portion of pasta: 75g dried|120g cooked"
        ElseIf ComboBox6.SelectedIndex = 11 Then
            Label10.Text = "Average weight of biscuit: 17g"
        ElseIf ComboBox6.SelectedIndex = 12 Then
            Label10.Text = "Average weight of one pepper: 170g"
        ElseIf ComboBox6.SelectedIndex = 13 Then
            Label10.Text = "Average weight of one weetabix: 19g"
        ElseIf ComboBox6.SelectedIndex = 14 Then
            Label10.Text = "Average weight of one grape: 6g"
        Else
            Label10.Text = ""
        End If
    End Sub

    Private Sub ComboBox7_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox7.SelectedIndexChanged
        Label10.Location = New Point(172, 810)

        If ComboBox7.SelectedIndex = 0 Then
            Label10.Text = "Average weight of one chicken breast: 300g"
        ElseIf ComboBox7.SelectedIndex = 1 Then
            Label10.Text = "Average weight of topside of beef: 250g"
        ElseIf ComboBox7.SelectedIndex = 2 Then
            Label10.Text = "Average weight of pork chop (without bone): 150g"
        ElseIf ComboBox7.SelectedIndex = 3 Then
            Label10.Text = "Average weight of salmon fillet: 120g"
        ElseIf ComboBox7.SelectedIndex = 4 Then
            Label10.Text = "Average weight of one potato: 150g"
        ElseIf ComboBox7.SelectedIndex = 5 Then
            Label10.Text = "Average weight of one carrot: 100g"
        ElseIf ComboBox7.SelectedIndex = 6 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox7.SelectedIndex = 7 Then
            Label10.Text = "Average weight of one rice serving: 90g"
        ElseIf ComboBox7.SelectedIndex = 8 Then
            Label10.Text = "Average weight of slice of bread: 50g"
        ElseIf ComboBox7.SelectedIndex = 9 Then
            Label10.Text = "Average weight of slice of cheese: 10g"
        ElseIf ComboBox7.SelectedIndex = 10 Then
            Label10.Text = "Average weight of one portion of pasta: 75g dried|120g cooked"
        ElseIf ComboBox7.SelectedIndex = 11 Then
            Label10.Text = "Average weight of biscuit: 17g"
        ElseIf ComboBox7.SelectedIndex = 12 Then
            Label10.Text = "Average weight of one pepper: 170g"
        ElseIf ComboBox7.SelectedIndex = 13 Then
            Label10.Text = "Average weight of one weetabix: 19g"
        ElseIf ComboBox7.SelectedIndex = 14 Then
            Label10.Text = "Average weight of one grape: 6g"
        Else
            Label10.Text = ""
        End If
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs)
        Throw New NotImplementedException
    End Sub

End Class
