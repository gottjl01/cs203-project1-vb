Imports System.ComponentModel

Public Class frmMain

    Dim mathFunctions As PFW.CSIST203.Project1.Functions.MathFunctions
    Dim arrayFunctions As PFW.CSIST203.Project1.Functions.ArrayFunctions

    Private Sub FrmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mathFunctions = New PFW.CSIST203.Project1.Functions.MathFunctions()
        arrayFunctions = New PFW.CSIST203.Project1.Functions.ArrayFunctions()
        log4net.Config.XmlConfigurator.ConfigureAndWatch(New System.IO.FileInfo(System.AppDomain.CurrentDomain.SetupInformation.ConfigurationFile))
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        lblOperator.Text = "+"
        txtResultant.Text = mathFunctions.Add(txtValue1.Text, txtValue2.Text)
    End Sub

    Private Sub BtnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        lblOperator.Text = "-"
        txtResultant.Text = mathFunctions.Subtract(txtValue1.Text, txtValue2.Text)
    End Sub

    Private Sub BtnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        lblOperator.Text = "*"
        txtResultant.Text = mathFunctions.Multiply(txtValue1.Text, txtValue2.Text)
    End Sub

    Private Sub BtnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        lblOperator.Text = "/"
        txtResultant.Text = mathFunctions.Divide(txtValue1.Text, txtValue2.Text)
    End Sub

    Private Sub BtnModulus_Click(sender As Object, e As EventArgs) Handles btnModulus.Click
        lblOperator.Text = "%"
        txtResultant.Text = mathFunctions.Modulus(txtValue1.Text, txtValue2.Text)
    End Sub

    Private Sub BtnPower_Click(sender As Object, e As EventArgs) Handles btnPower.Click
        lblOperator.Text = "^"
        txtResultant.Text = mathFunctions.Power(txtValue1.Text, txtValue2.Text)
    End Sub

    Protected Overrides Sub OnClosing(e As CancelEventArgs)
        MyBase.OnClosing(e)
        log4net.LogManager.Shutdown()
    End Sub

    Private Sub SetArrayValues(data As String())
        txtArray1.Text = data(0)
        txtArray2.Text = data(1)
        txtArray3.Text = data(2)
        txtArray4.Text = data(3)
        txtArray5.Text = data(4)
    End Sub

    Private Function GetArrayValues() As String()
        Dim arr(4) As String
        arr(0) = txtArray1.Text
        arr(1) = txtArray2.Text
        arr(2) = txtArray3.Text
        arr(3) = txtArray4.Text
        arr(4) = txtArray5.Text
        Return arr
    End Function

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        arrayFunctions.Store(GetArrayValues())
    End Sub

    Private Sub BtnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        SetArrayValues(arrayFunctions.Load(5))
    End Sub

    Private Sub BtnRandomize_Click(sender As Object, e As EventArgs) Handles btnRandomize.Click
        SetArrayValues(arrayFunctions.Randomize(GetArrayValues()))
    End Sub

    Private Sub BtnShiftRight_Click(sender As Object, e As EventArgs) Handles btnShiftRight.Click
        SetArrayValues(arrayFunctions.ShiftRight(GetArrayValues()))
    End Sub

    Private Sub BtnShiftLeft_Click(sender As Object, e As EventArgs) Handles btnShiftLeft.Click
        SetArrayValues(arrayFunctions.ShiftLeft(GetArrayValues()))
    End Sub

    Private Sub BtnReverse_Click(sender As Object, e As EventArgs) Handles btnReverse.Click
        SetArrayValues(arrayFunctions.Reverse(GetArrayValues()))
    End Sub

End Class