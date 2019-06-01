'Name: Sean Fox
'Course: CIT-161-Z03B
'Date: 6-1-19
'Program Name: Workshop Selector
'Description: Chapter 5, Programming Challenge 3 - Create an application that computes the cost of attendance specific workshops in specific cities
' and the total cost for all workshops attended

Public Class Form1
    Dim decTotalCost As Decimal = 0
    Private Sub BtnAddWorkshop_Click(sender As Object, e As EventArgs) Handles btnAddWorkshop.Click
        Dim intDays As Integer
        Dim decCost As Decimal
        Dim decLodgingFee As Decimal
        Dim strWorkshop As String = lbWorkshop.SelectedItem.ToString
        Dim strLocation As String = lbLocation.SelectedItem.ToString

        Select Case strWorkshop
            Case "Handling Stress"
                intDays = 3
                decCost = 595
            Case "Time Management"
                intDays = 3
                decCost = 695
            Case "Supervision Skills"
                intDays = 3
                decCost = 995
            Case "Negotiation"
                intDays = 5
                decCost = 1295
            Case "How to Interview"
                intDays = 1
                decCost = 395
        End Select

        Select Case strLocation
            Case "Austin"
                decLodgingFee = 95
            Case "Chicago"
                decLodgingFee = 125
            Case "Dallas"
                decLodgingFee = 110
            Case "Orlando"
                decLodgingFee = 100
            Case "Phoenix"
                decLodgingFee = 92
            Case "Raleigh"
                decLodgingFee = 90
        End Select

        Dim decWorkshopCost As Decimal = intDays * decLodgingFee + decCost
        decTotalCost += decWorkshopCost
        lbCost.Items.Add(strWorkshop + " Workshop in " + strLocation + " = " + decWorkshopCost.ToString("c"))
    End Sub

    Private Sub BtnCalcTotal_Click(sender As Object, e As EventArgs) Handles btnCalcTotal.Click
        lblTotalCost.Text = decTotalCost.ToString("c")
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lbWorkshop.SelectedIndex = -1
        lbLocation.SelectedIndex = -1
        lbCost.Items.Clear()
        lblTotalCost.Text = String.Empty
        decTotalCost = 0
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
