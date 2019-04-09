
Imports System.Drawing.Printing

Public Class EPOS

    ' These are the variables to save the prices of the items 

    Dim ChickenMeal As Single = 7.99
    Dim CurryMeal As Single = 5.99
    Dim PizzaMeal As Single = 9.99
    Dim IceCream As Single = 2.99
    Dim Donut As Single = 0.99
    Dim Cheesecake As Single = 4.99
    Dim Pepsi As Single = 0.85
    Dim Coffee As Single = 1.99
    Dim Water As Single = 0.99

    Dim drag As Boolean
    Dim MoveFormMouse As Point




    Private Sub EPOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' This starts the timer

        Timer1.Start()

        'This gets the text from the internal database
        lblNameReg.Text = My.Settings.Name
        lblPosReg.Text = My.Settings.Position
        lblEmailReg.Text = My.Settings.Email

        'This makes all the buttons invisible
        ChickenAdd.Visible = False
        CurryAdd.Visible = False
        PizzaAdd.Visible = False
        IceCreamAdd.Visible = False
        DonutAdd.Visible = False
        CheesecakeAdd.Visible = False
        PepsiAdd.Visible = False
        CoffeAdd.Visible = False
        WaterAdd.Visible = False
        NumericUpDown1.Visible = False
        lblQty.Visible = False


        ' This sets up the numeric updown maximum 
        NumericUpDown1.Maximum = 9
        NumericUpDown1.Minimum = 1


        ' Makes the text invisible
        PictureBoxError.Visible = False
        lblErrorUP.Visible = False
        lblPayMore.Visible = False

    End Sub

    'This event puts the date and time on labels and displays them
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTime.Text = DateTime.Now.ToString("HH:mm")
        lblDate.Text = DateTime.Now.ToString("dd/MM/yy")
    End Sub

    'All the events below makes one button visible and all the other buttons invisible 
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        PictureBox12.Image = My.Resources.Chicken2

        ChickenAdd.Visible = True
        CurryAdd.Visible = False
        PizzaAdd.Visible = False
        IceCreamAdd.Visible = False
        DonutAdd.Visible = False
        CheesecakeAdd.Visible = False
        PepsiAdd.Visible = False
        CoffeAdd.Visible = False
        WaterAdd.Visible = False
        NumericUpDown1.Visible = True
        lblQty.Visible = True

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        PictureBox12.Image = My.Resources.Curry1

        ChickenAdd.Visible = False
        CurryAdd.Visible = True
        PizzaAdd.Visible = False
        IceCreamAdd.Visible = False
        DonutAdd.Visible = False
        CheesecakeAdd.Visible = False
        PepsiAdd.Visible = False
        CoffeAdd.Visible = False
        WaterAdd.Visible = False
        NumericUpDown1.Visible = True
        lblQty.Visible = True

    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        PictureBox12.Image = My.Resources.Pizza1

        ChickenAdd.Visible = False
        CurryAdd.Visible = False
        PizzaAdd.Visible = True
        IceCreamAdd.Visible = False
        DonutAdd.Visible = False
        CheesecakeAdd.Visible = False
        PepsiAdd.Visible = False
        CoffeAdd.Visible = False
        WaterAdd.Visible = False
        NumericUpDown1.Visible = True
        lblQty.Visible = True

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        PictureBox12.Image = My.Resources.Ice_cream1

        ChickenAdd.Visible = False
        CurryAdd.Visible = False
        PizzaAdd.Visible = False
        IceCreamAdd.Visible = True
        DonutAdd.Visible = False
        CheesecakeAdd.Visible = False
        PepsiAdd.Visible = False
        CoffeAdd.Visible = False
        WaterAdd.Visible = False
        NumericUpDown1.Visible = True
        lblQty.Visible = True

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        PictureBox12.Image = My.Resources.Donut1

        ChickenAdd.Visible = False
        CurryAdd.Visible = False
        PizzaAdd.Visible = False
        IceCreamAdd.Visible = False
        DonutAdd.Visible = True
        CheesecakeAdd.Visible = False
        PepsiAdd.Visible = False
        CoffeAdd.Visible = False
        WaterAdd.Visible = False
        NumericUpDown1.Visible = True
        lblQty.Visible = True

    End Sub

    Private Sub PictureBox9_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        PictureBox12.Image = My.Resources.Cheesecake1

        ChickenAdd.Visible = False
        CurryAdd.Visible = False
        PizzaAdd.Visible = False
        IceCreamAdd.Visible = False
        DonutAdd.Visible = False
        CheesecakeAdd.Visible = True
        PepsiAdd.Visible = False
        CoffeAdd.Visible = False
        WaterAdd.Visible = False
        NumericUpDown1.Visible = True
        lblQty.Visible = True

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        PictureBox12.Image = My.Resources.Pepsi1

        ChickenAdd.Visible = False
        CurryAdd.Visible = False
        PizzaAdd.Visible = False
        IceCreamAdd.Visible = False
        DonutAdd.Visible = False
        CheesecakeAdd.Visible = False
        PepsiAdd.Visible = True
        CoffeAdd.Visible = False
        WaterAdd.Visible = False
        NumericUpDown1.Visible = True
        lblQty.Visible = True

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        PictureBox12.Image = My.Resources.Coffe1

        ChickenAdd.Visible = False
        CurryAdd.Visible = False
        PizzaAdd.Visible = False
        IceCreamAdd.Visible = False
        DonutAdd.Visible = False
        CheesecakeAdd.Visible = False
        PepsiAdd.Visible = False
        CoffeAdd.Visible = True
        WaterAdd.Visible = False
        NumericUpDown1.Visible = True
        lblQty.Visible = True

    End Sub

    Private Sub PictureBox10_Click(sender As Object, e As EventArgs) Handles PictureBox10.Click
        PictureBox12.Image = My.Resources.Water1

        ChickenAdd.Visible = False
        CurryAdd.Visible = False
        PizzaAdd.Visible = False
        IceCreamAdd.Visible = False
        DonutAdd.Visible = False
        CheesecakeAdd.Visible = False
        PepsiAdd.Visible = False
        CoffeAdd.Visible = False
        WaterAdd.Visible = True
        NumericUpDown1.Visible = True
        lblQty.Visible = True

    End Sub


    ' All the events below add the item to the list view 
    Private Sub ChickenAdd_Click(sender As Object, e As EventArgs) Handles ChickenAdd.Click
        Dim i As ListViewItem

        i = lvItems.Items.Add("Whole Chicken")
        i.SubItems.Add(FormatCurrency(ChickenMeal))
        i.SubItems.Add(NumericUpDown1.Value)
        i.SubItems.Add(FormatCurrency(ChickenMeal * NumericUpDown1.Value))

        Dim Subtotal As Double
        Dim CountList As ListViewItem
        Dim VATPrice As Double

        'This code adds all the items prices, and are the same for all the other events 
        For Each CountList In lvItems.Items
            Subtotal += CountList.SubItems.Item(3).Text()
        Next

        'This code calculates the price of the meal, vat and subtotal 
        VATPrice = Subtotal / 1.2

        lblTotalPriceGO.Text = FormatCurrency(Subtotal)
        lblSubtotalGO.Text = FormatCurrency(VATPrice)
        lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
        lblDiscountGO.Text = FormatCurrency("0.00")


    End Sub

    Private Sub CurryAdd_Click(sender As Object, e As EventArgs) Handles CurryAdd.Click
        Dim i As ListViewItem

        i = lvItems.Items.Add("Hot Curry")
        i.SubItems.Add(FormatCurrency(CurryMeal))
        i.SubItems.Add(NumericUpDown1.Value)
        i.SubItems.Add(FormatCurrency(CurryMeal * NumericUpDown1.Value))

        Dim Subtotal As Double
        Dim CountList As ListViewItem
        Dim VATPrice As Double

        For Each CountList In lvItems.Items
            Subtotal += CountList.SubItems.Item(3).Text()
        Next

        VATPrice = Subtotal / 1.2

        lblTotalPriceGO.Text = FormatCurrency(Subtotal)
        lblSubtotalGO.Text = FormatCurrency(VATPrice)
        lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
        lblDiscountGO.Text = FormatCurrency("0.00")
    End Sub

    Private Sub PizzaAdd_Click(sender As Object, e As EventArgs) Handles PizzaAdd.Click
        Dim i As ListViewItem

        i = lvItems.Items.Add("Peperoni Pizza")
        i.SubItems.Add(FormatCurrency(PizzaMeal))
        i.SubItems.Add(NumericUpDown1.Value)
        i.SubItems.Add(FormatCurrency(PizzaMeal * NumericUpDown1.Value))

        Dim Subtotal As Double
        Dim CountList As ListViewItem
        Dim VATPrice As Double

        For Each CountList In lvItems.Items
            Subtotal += CountList.SubItems.Item(3).Text()
        Next

        VATPrice = Subtotal / 1.2

        lblTotalPriceGO.Text = FormatCurrency(Subtotal)
        lblSubtotalGO.Text = FormatCurrency(VATPrice)
        lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
        lblDiscountGO.Text = FormatCurrency("0.00")
    End Sub

    Private Sub IceCreamAdd_Click(sender As Object, e As EventArgs) Handles IceCreamAdd.Click
        Dim i As ListViewItem

        i = lvItems.Items.Add("Ice Cream")
        i.SubItems.Add(FormatCurrency(IceCream))
        i.SubItems.Add(NumericUpDown1.Value)
        i.SubItems.Add(FormatCurrency(IceCream * NumericUpDown1.Value))

        Dim Subtotal As Double
        Dim CountList As ListViewItem
        Dim VATPrice As Double

        For Each CountList In lvItems.Items
            Subtotal += CountList.SubItems.Item(3).Text()
        Next

        VATPrice = Subtotal / 1.2

        lblTotalPriceGO.Text = FormatCurrency(Subtotal)
        lblSubtotalGO.Text = FormatCurrency(VATPrice)
        lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
        lblDiscountGO.Text = FormatCurrency("0.00")
    End Sub

    Private Sub DonutAdd_Click(sender As Object, e As EventArgs) Handles DonutAdd.Click
        Dim i As ListViewItem

        i = lvItems.Items.Add("Donut")
        i.SubItems.Add(FormatCurrency(Donut))
        i.SubItems.Add(NumericUpDown1.Value)
        i.SubItems.Add(FormatCurrency(Donut * NumericUpDown1.Value))

        Dim Subtotal As Double
        Dim CountList As ListViewItem
        Dim VATPrice As Double

        For Each CountList In lvItems.Items
            Subtotal += CountList.SubItems.Item(3).Text()
        Next

        VATPrice = Subtotal / 1.2

        lblTotalPriceGO.Text = FormatCurrency(Subtotal)
        lblSubtotalGO.Text = FormatCurrency(VATPrice)
        lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
        lblDiscountGO.Text = FormatCurrency("0.00")
    End Sub

    Private Sub CheesecakeAdd_Click(sender As Object, e As EventArgs) Handles CheesecakeAdd.Click
        Dim i As ListViewItem

        i = lvItems.Items.Add("Cheesecake")
        i.SubItems.Add(FormatCurrency(Cheesecake))
        i.SubItems.Add(NumericUpDown1.Value)
        i.SubItems.Add(FormatCurrency(Cheesecake * NumericUpDown1.Value))

        Dim Subtotal As Double
        Dim CountList As ListViewItem
        Dim VATPrice As Double

        For Each CountList In lvItems.Items
            Subtotal += CountList.SubItems.Item(3).Text()
        Next

        VATPrice = Subtotal / 1.2

        lblTotalPriceGO.Text = FormatCurrency(Subtotal)
        lblSubtotalGO.Text = FormatCurrency(VATPrice)
        lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
        lblDiscountGO.Text = FormatCurrency("0.00")
    End Sub

    Private Sub PepsiAdd_Click(sender As Object, e As EventArgs) Handles PepsiAdd.Click
        Dim i As ListViewItem

        i = lvItems.Items.Add("Pepsi")
        i.SubItems.Add(FormatCurrency(Pepsi))
        i.SubItems.Add(NumericUpDown1.Value)
        i.SubItems.Add(FormatCurrency(Pepsi * NumericUpDown1.Value))

        Dim Subtotal As Double
        Dim CountList As ListViewItem
        Dim VATPrice As Double

        For Each CountList In lvItems.Items
            Subtotal += CountList.SubItems.Item(3).Text()
        Next

        VATPrice = Subtotal / 1.2

        lblTotalPriceGO.Text = FormatCurrency(Subtotal)
        lblSubtotalGO.Text = FormatCurrency(VATPrice)
        lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
        lblDiscountGO.Text = FormatCurrency("0.00")
    End Sub

    Private Sub CoffeeAdd_Click(sender As Object, e As EventArgs) Handles CoffeAdd.Click
        Dim i As ListViewItem

        i = lvItems.Items.Add("Coffee")
        i.SubItems.Add(FormatCurrency(Coffee))
        i.SubItems.Add(NumericUpDown1.Value)
        i.SubItems.Add(FormatCurrency(Coffee * NumericUpDown1.Value))

        Dim Subtotal As Double
        Dim CountList As ListViewItem
        Dim VATPrice As Double

        For Each CountList In lvItems.Items
            Subtotal += CountList.SubItems.Item(3).Text()
        Next

        VATPrice = Subtotal / 1.2

        lblTotalPriceGO.Text = FormatCurrency(Subtotal)
        lblSubtotalGO.Text = FormatCurrency(VATPrice)
        lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
        lblDiscountGO.Text = FormatCurrency("0.00")
    End Sub

    Private Sub WaterAdd_Click(sender As Object, e As EventArgs) Handles WaterAdd.Click
        Dim i As ListViewItem

        i = lvItems.Items.Add("Water")
        i.SubItems.Add(FormatCurrency(Water))
        i.SubItems.Add(NumericUpDown1.Value)
        i.SubItems.Add(FormatCurrency(Water * NumericUpDown1.Value))

        Dim Subtotal As Double
        Dim CountList As ListViewItem
        Dim VATPrice As Double

        For Each CountList In lvItems.Items
            Subtotal += CountList.SubItems.Item(3).Text()
        Next

        VATPrice = Subtotal / 1.2

        lblTotalPriceGO.Text = FormatCurrency(Subtotal)
        lblSubtotalGO.Text = FormatCurrency(VATPrice)
        lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
        lblDiscountGO.Text = FormatCurrency("0.00")
    End Sub

    'This event below clears the all the items 
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        lvItems.Items.Clear()

        Dim Subtotal As Double
        Dim CountList As ListViewItem
        Dim VATPrice As Double

        For Each CountList In lvItems.Items
            Subtotal += CountList.SubItems.Item(3).Text()
        Next

        VATPrice = Subtotal / 1.2

        lblTotalPriceGO.Text = FormatCurrency(Subtotal)
        lblSubtotalGO.Text = FormatCurrency(VATPrice)
        lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
        lblDiscountGO.Text = FormatCurrency("0.00")
    End Sub

    'This events below allows to drag and move the form 
    Private Sub EPOS_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            drag = True
            Me.Cursor = Cursors.NoMove2D
            MoveFormMouse = e.Location

        End If
    End Sub

    Private Sub EPOS_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Me.Location = Me.Location + (e.Location - MoveFormMouse)
        End If
    End Sub

    Private Sub EPOS_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            drag = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    ' This code opens the login form 
    Private Sub PictureBox15_Click(sender As Object, e As EventArgs) Handles PbLogin.Click
        Me.Hide()
        Login.Show()
        Login.txtUsername.Clear()
        Login.txtPassword.Clear()
    End Sub

    'This event below allows to remove one item 
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As ListViewItem

        'This is a try and catch expressio, so if an item is not selected the program does not match 
        Try
            i = lvItems.SelectedItems(0)
            i.Remove()

        Catch ex As Exception

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)


        End Try

        ' This add three variables and calculates the price of the subtotal after removing an item 
        Dim Subtotal As Double
        Dim CountList As ListViewItem
        Dim VATPrice As Double

        For Each CountList In lvItems.Items
            Subtotal += CountList.SubItems.Item(3).Text()
        Next

        VATPrice = Subtotal / 1.2

        lblTotalPriceGO.Text = FormatCurrency(Subtotal)
        lblSubtotalGO.Text = FormatCurrency(VATPrice)
        lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
        lblDiscountGO.Text = FormatCurrency("0.00")

    End Sub

    ' Sets ticket number to 0 
    Dim TicketNumber As Integer = 0

    Private Sub PictureBox16_Click(sender As Object, e As EventArgs) Handles PbTender.Click

        ' Three variables are added for the subtotal, VAT and discount 
        Dim AmountGiven As Double

        Dim Subtotal As Double
        Dim CountList As ListViewItem
        Dim VATPrice As Double
        Dim DiscountedAmount As Double

        ' This calculates the total price of the items 
        For Each CountList In lvItems.Items
            Subtotal += CountList.SubItems.Item(3).Text()
        Next

        VATPrice = Subtotal / 1.2

        ' Changes the format to currency 
        lblTotalPriceGO.Text = FormatCurrency(Subtotal)
        lblSubtotalGO.Text = FormatCurrency(VATPrice)
        lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
        lblDiscountGO.Text = FormatCurrency("0.00")

        'This is an if statement to do the calcualtion 
        If txtAmountEnter.Text = "" Then

            ' If the price is 0 or nothing, then computer beeps and shows error message 
            PictureBoxError.Visible = True
            lblErrorUP.Visible = True
            lblPayMore.Visible = False

            My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)

        Else

            PictureBoxError.Visible = False
            lblErrorUP.Visible = False

            ' Converts text to integer
            AmountGiven = Double.Parse(txtAmountEnter.Text)

            'If amount is smaller than subtotal then shows error message and beeps 
            If AmountGiven < Subtotal Then
                PictureBoxError.Visible = True
                lblPayMore.Visible = True

                My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Beep)


            Else

                ' Confirms if discuount is checked or not 
                If CheckBoxDiscount.Checked = True Then

                    'If discount is checked then this caluclations reduces the price 
                    DiscountedAmount = Subtotal * 0.9

                    lblTotalPriceGO.Text = FormatCurrency(DiscountedAmount)

                    lblChangeGO.Text = FormatCurrency(AmountGiven - DiscountedAmount)

                    lblAmountGivenGO.Text = FormatCurrency(AmountGiven)

                    lblDiscountGO.Text = FormatCurrency(Subtotal * 0.1)

                    'Adds ticket number +1 
                    TicketNumber += 1
                    UpdateLabel()

                    PictureBoxError.Visible = False
                    lblPayMore.Visible = False

                Else

                    ' Calculation without the discount 
                    lblChangeGO.Text = FormatCurrency(AmountGiven - Subtotal)

                    lblAmountGivenGO.Text = FormatCurrency(AmountGiven)

                    ' Adds ticket number
                    TicketNumber += 1
                    UpdateLabel()

                    PictureBoxError.Visible = False
                    lblPayMore.Visible = False
                End If
            End If
        End If



    End Sub

    'Updates the label of the ticket number
    Sub UpdateLabel()
        lblNumber.Text = CStr(TicketNumber)
    End Sub

    'Opens the help form 
    Private Sub PictureBox13_Click(sender As Object, e As EventArgs) Handles PbInformation.Click
        Me.Hide()
        Help.Show()
    End Sub

    'This are events used for the dialpad numbers
    Private Sub PictureBox19_Click(sender As Object, e As EventArgs) Handles Pt1.Click
        txtAmountEnter.Text = txtAmountEnter.Text & "1"
    End Sub

    Private Sub PictureBox27_Click(sender As Object, e As EventArgs) Handles Pt0.Click
        txtAmountEnter.Text = txtAmountEnter.Text & "0"
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PtPoint.Click
        txtAmountEnter.Text = txtAmountEnter.Text & "."
    End Sub

    Private Sub Pt8_Click(sender As Object, e As EventArgs) Handles Pt8.Click
        txtAmountEnter.Text = txtAmountEnter.Text & "8"
    End Sub

    Private Sub ptC_Click(sender As Object, e As EventArgs) Handles ptC.Click
        txtAmountEnter.Clear()
    End Sub

    Private Sub Pt3_Click(sender As Object, e As EventArgs) Handles Pt3.Click
        txtAmountEnter.Text = txtAmountEnter.Text & "3"
    End Sub

    Private Sub Pt2_Click(sender As Object, e As EventArgs) Handles Pt2.Click
        txtAmountEnter.Text = txtAmountEnter.Text & "2"
    End Sub

    Private Sub Pt4_Click(sender As Object, e As EventArgs) Handles Pt4.Click
        txtAmountEnter.Text = txtAmountEnter.Text & "4"
    End Sub

    Private Sub Pt5_Click(sender As Object, e As EventArgs) Handles Pt5.Click
        txtAmountEnter.Text = txtAmountEnter.Text & "5"
    End Sub

    Private Sub Pt6_Click(sender As Object, e As EventArgs) Handles Pt6.Click
        txtAmountEnter.Text = txtAmountEnter.Text & "6"
    End Sub

    Private Sub Pt9_Click(sender As Object, e As EventArgs) Handles Pt9.Click
        txtAmountEnter.Text = txtAmountEnter.Text & "9"
    End Sub

    Private Sub Pt7_Click(sender As Object, e As EventArgs) Handles Pt7.Click
        txtAmountEnter.Text = txtAmountEnter.Text & "7"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)
        lvItems.EnsureVisible(0)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        lvItems.EnsureVisible(lvItems.Items.Count - 1)
    End Sub

    ' This events are used to create the hover effect on the buttons 
    Private Sub PbTender_MouseEnter(sender As Object, e As EventArgs) Handles PbTender.MouseEnter
        PbTender.Image = My.Resources.Shop1
    End Sub

    Private Sub PbTender_MouseLeave(sender As Object, e As EventArgs) Handles PbTender.MouseLeave
        PbTender.Image = My.Resources.Shop
    End Sub

    Private Sub PbInformation_MouseLeave(sender As Object, e As EventArgs) Handles PbInformation.MouseLeave
        PbInformation.Image = My.Resources.Information1
    End Sub

    Private Sub PbInformation_MouseEnter(sender As Object, e As EventArgs) Handles PbInformation.MouseEnter
        PbInformation.Image = My.Resources.Information
    End Sub

    Private Sub PbPrint_MouseEnter(sender As Object, e As EventArgs) Handles PbPrint.MouseEnter
        PbPrint.Image = My.Resources.Print1
    End Sub

    Private Sub PbPrint_MouseLeave(sender As Object, e As EventArgs) Handles PbPrint.MouseLeave
        PbPrint.Image = My.Resources.Print
    End Sub

    Private Sub PbLogin_MouseEnter(sender As Object, e As EventArgs) Handles PbLogin.MouseEnter
        PbLogin.Image = My.Resources.Log_Out1
    End Sub

    Private Sub PbLogin_MouseLeave(sender As Object, e As EventArgs) Handles PbLogin.MouseLeave
        PbLogin.Image = My.Resources.Log_Out
    End Sub

    ' This event allows to set up the page 
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage


        ' Varibles create to save the font, locations x & y 
        Dim lvwItem As ListViewItem
        Dim lvwSubItem As ListViewItem.ListViewSubItem
        Dim xPos As Integer = 0
        Dim yPos As Integer = 0
        Dim TextF As New Font("Segoe UI", 40)
        Dim title As String = "Indi Spice"

        Dim TextFTitle As New Font("Segoe UI", 40)


        ' Imports a picutre to print 
        e.Graphics.DrawImage(My.Resources.Invoice, 0, 0)

        ' Counter for display purposes
        Dim listviewcount As Integer = 1

        ' Loop through our listview items
        For Each lvwItem In lvItems.Items
            xPos = -200

            ' Print the count
            ' Debug.Print(listviewcount)

            ' Print the subitems of this particular ListViewItem
            For Each lvwSubItem In lvwItem.SubItems
                xPos += 50 + (listviewcount + 250) - (listviewcount - 250)
                yPos = 1450 + (listviewcount * 150)
                e.Graphics.DrawString(lvwSubItem.Text(),
                    TextF, Brushes.Black, xPos, yPos)
            Next

            ' Increment the count (for display purposes)
            listviewcount += 1
        Next





        ' Adds the name of the server
        e.Graphics.DrawString(lblNameReg.Text, TextFTitle, System.Drawing.Brushes.Black, 535, 1190)


        ' This labels shows the subtotal VAT and the discount 
        e.Graphics.DrawString(lblSubtotalGO.Text, TextFTitle, System.Drawing.Brushes.Black, 2000, 2750)

        e.Graphics.DrawString(lblVATGO.Text, TextFTitle, System.Drawing.Brushes.Black, 2000, 2835)

        e.Graphics.DrawString(lblDiscountGO.Text, TextFTitle, System.Drawing.Brushes.Black, 2000, 2925)


        ' This labels shows the total price, amount give  and the change 
        e.Graphics.DrawString(lblTotalPriceGO.Text, TextFTitle, System.Drawing.Brushes.Black, 2000, 3050)

        e.Graphics.DrawString(lblAmountGivenGO.Text, TextFTitle, System.Drawing.Brushes.Black, 2000, 3135)

        e.Graphics.DrawString(lblChangeGO.Text, TextFTitle, System.Drawing.Brushes.Black, 2000, 3225)


    End Sub

    'This event sets up the dialog 
    Private Sub PbPrint_Click(sender As Object, e As EventArgs) Handles PbPrint.Click

        ' Changes the paper size to an A4
        Dim xCustomSize As New PaperSize("Custom Paper Size", 2480, 3570)

        ' Changes the difault size to the custom size 
        PrintDocument1.DefaultPageSettings.PaperSize = xCustomSize

        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
    End Sub

    'This event is discount calculation event 
    Private Sub CheckBoxDiscount_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxDiscount.CheckedChanged
        'If statement to check wheter button is checked or not
        If CheckBoxDiscount.Checked = True Then

            'If checked creates variables and applies discount of 10%
            Dim Subtotal As Double
            Dim CountList As ListViewItem
            Dim VATPrice As Double

            For Each CountList In lvItems.Items
                Subtotal += CountList.SubItems.Item(3).Text()
            Next

            'Calcualtes price and adds it to the prices labels 
            VATPrice = Subtotal / 1.2

            lblTotalPriceGO.Text = FormatCurrency(Subtotal * 0.9)
            lblSubtotalGO.Text = FormatCurrency(VATPrice)
            lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
            lblDiscountGO.Text = FormatCurrency(Subtotal * 0.1)

            ' If it is not checked, recalcualtes all the items 
        ElseIf CheckBoxDiscount.Checked = False Then
            Dim Subtotal As Double
            Dim CountList As ListViewItem
            Dim VATPrice As Double

            For Each CountList In lvItems.Items
                Subtotal += CountList.SubItems.Item(3).Text()
            Next

            VATPrice = Subtotal / 1.2

            lblTotalPriceGO.Text = FormatCurrency(Subtotal)
            lblSubtotalGO.Text = FormatCurrency(VATPrice)
            lblVATGO.Text = FormatCurrency(Subtotal - VATPrice)
            lblDiscountGO.Text = FormatCurrency("0.00")


        End If
    End Sub

End Class