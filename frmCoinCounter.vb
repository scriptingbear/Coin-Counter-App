Imports System.Collections.Generic

Public Class frmCoinCounter
    Private Sub Calculate(ByVal Amount As Double)
        '=======================================================
        'Determine number of quarters, dimes, nickels and 
        'pennies in Amount and populate corresponding labels
        '=======================================================
        Dim arCoins As New List(Of Label) From {lblQuarters, lblDimes, lblNickels, lblPennies}

        For Each obj As Label In arCoins
            Dim dblCoin As Double = obj.Tag
            Dim intCoinCount = Int(Amount / dblCoin)
            obj.Text = CStr(intCoinCount)
            Amount -= intCoinCount * dblCoin
        Next obj


    End Sub

    Private Sub spnAmount_Click(sender As Object, e As EventArgs) Handles spnAmount.Click
        '=======================================================
        'Pass value of up down control to Calculate() and update
        'the label for each coin denomination.
        '=======================================================
        Calculate(spnAmount.Value)
    End Sub
End Class
