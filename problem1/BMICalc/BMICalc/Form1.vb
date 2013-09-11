Option Strict On

Public Class Form1

    Private Sub btnCalcBMI_Click(sender As System.Object, e As System.EventArgs) Handles btnCalcBMI.Click


        Dim wst As String
        Dim hst As String
        Dim w As Double
        Dim h As Double
        Dim bmi As Double

        hst = txtHeight.Text
        wst = txtWeight.Text
        w = CDbl(wst)
        h = CDbl(hst)

        bmi = (w * 703) / (h ^ 2)
        textbox1.Text = CStr(bmi)

    End Sub
End Class
