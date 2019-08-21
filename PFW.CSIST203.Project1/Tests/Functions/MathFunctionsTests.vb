Imports System
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PFW.CSIST203.Project1.Tests.Functions

    ''' <summary>
    ''' MathFunctions class testing harness
    ''' </summary>
    Public MustInherit Class MathFunctionsTests
        Inherits TestBase

        Protected Property MathFunctionObj As PFW.CSIST203.Project1.Functions.MathFunctions = New Project1.Functions.MathFunctions()

        ''' <summary>
        ''' Add method testing harness
        ''' </summary>
        <TestClass>
        Public Class AddMethod
            Inherits MathFunctionsTests

            <TestMethod>
            Public Sub IntegerAddition()
                Assert.AreEqual(10D, Decimal.Parse(MathFunctionObj.Add("5", "5")))
                Assert.AreEqual(10D, Decimal.Parse(MathFunctionObj.Add("1", "9")))
                Assert.AreEqual(10D, Decimal.Parse(MathFunctionObj.Add("-20", "30")))
                Assert.AreEqual(10D, Decimal.Parse(MathFunctionObj.Add("0", "10")))
                Assert.AreEqual(10D, Decimal.Parse(MathFunctionObj.Add("10", "0")))
                Assert.AreEqual(10D, Decimal.Parse(MathFunctionObj.Add(" 10 ", " 0 ")))
            End Sub

            <TestMethod>
            Public Sub NonIntegerAddition()
                Assert.AreEqual(10D, Decimal.Parse(MathFunctionObj.Add("0.1", "9.9")))
                Assert.AreEqual(10D, Decimal.Parse(MathFunctionObj.Add("45.23", "-35.23")))
                Assert.AreEqual(10D, Decimal.Parse(MathFunctionObj.Add("  45.23", "-35.23 ")))
            End Sub

            <TestMethod>
            Public Sub BadInput()
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Add("text", "10"))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Add("10", "text"))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Add("", ""))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Add(Nothing, ""))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Add("", Nothing))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Add(Nothing, Nothing))
            End Sub

        End Class

        ''' <summary>
        ''' Subtract method testing harness
        ''' </summary>
        <TestClass>
        Public Class SubtractMethod
            Inherits MathFunctionsTests

            <TestMethod>
            Public Sub IntegerSubtraction()
                Assert.AreEqual(0.0D, Decimal.Parse(MathFunctionObj.Subtract("5", "5")))
                Assert.AreEqual(-8D, Decimal.Parse(MathFunctionObj.Subtract("1", "9")))
                Assert.AreEqual(-50D, Decimal.Parse(MathFunctionObj.Subtract("-20", "30")))
                Assert.AreEqual(-10D, Decimal.Parse(MathFunctionObj.Subtract("0", "10")))
                Assert.AreEqual(10D, Decimal.Parse(MathFunctionObj.Subtract("10", "0")))
                Assert.AreEqual(10D, Decimal.Parse(MathFunctionObj.Subtract("10 ", " 0")))
            End Sub

            <TestMethod>
            Public Sub NonIntegerSubtraction()
                Assert.AreEqual(-9.8D, Decimal.Parse(MathFunctionObj.Subtract("0.1", "9.9")))
                Assert.AreEqual(80.46D, Decimal.Parse(MathFunctionObj.Subtract("45.23", "-35.23")))
                Assert.AreEqual(5.2D, Decimal.Parse(MathFunctionObj.Subtract("0", "-5.2")))
                Assert.AreEqual(5.2D, Decimal.Parse(MathFunctionObj.Subtract(" 0", "  -5.2")))
            End Sub

            <TestMethod>
            Public Sub BadInput()
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Subtract("text", "10"))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Subtract("10", "text"))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Subtract("", ""))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Subtract(Nothing, ""))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Subtract("", Nothing))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Subtract(Nothing, Nothing))
            End Sub

        End Class

        ''' <summary>
        ''' Multiplication testing harness
        ''' </summary>
        <TestClass>
        Public Class MultiplyMethod
            Inherits MathFunctionsTests

            <TestMethod>
            Public Sub IntegerMultiplication()
                For i As Integer = 0 To 10
                    For j As Integer = 0 To 10
                        Dim result = CType(i * j, Decimal)
                        Assert.AreEqual(result, Decimal.Parse(MathFunctionObj.Multiply(i.ToString(), j.ToString())))
                        Assert.AreEqual(result, Decimal.Parse(MathFunctionObj.Multiply(j.ToString(), i.ToString())))
                        Assert.AreEqual(result, Decimal.Parse(MathFunctionObj.Multiply(" " & i.ToString(), j.ToString())))
                        Assert.AreEqual(result, Decimal.Parse(MathFunctionObj.Multiply(" " & i.ToString(), " " & j.ToString())))
                    Next
                Next
            End Sub

            <TestMethod>
            Public Sub NonIntegerMultiplication()
                For Each d1 As Double In {3.5, 2.5, 7.12, 123.9}
                    For Each d2 As Double In {1.2, 10.23, -23.1, 0.223, 0, 10.1}
                        Dim result = CType(d1 * d2, Decimal)
                        Assert.AreEqual(result, Decimal.Parse(MathFunctionObj.Multiply(d1.ToString(), d2.ToString())))
                        Assert.AreEqual(result, Decimal.Parse(MathFunctionObj.Multiply(d2.ToString(), d1.ToString())))
                        Assert.AreEqual(result, Decimal.Parse(MathFunctionObj.Multiply(d2.ToString() & " ", d1.ToString())))
                        Assert.AreEqual(result, Decimal.Parse(MathFunctionObj.Multiply(d2.ToString(), " " & d1.ToString())))
                    Next
                Next
            End Sub

            <TestMethod>
            Public Sub BadInput()
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Multiply("text", "10"))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Multiply("10", "text"))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Multiply("", ""))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Multiply(Nothing, ""))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Multiply("", Nothing))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Multiply(Nothing, Nothing))
            End Sub

        End Class

        ''' <summary>
        ''' Division method testing harness
        ''' </summary>
        <TestClass>
        Public Class DivideMethod
            Inherits MathFunctionsTests

            <TestMethod>
            Public Sub IntegerDivision()
                Assert.AreEqual(1D, Decimal.Parse(MathFunctionObj.Divide("5", "5")))
                Assert.AreEqual(5D, Decimal.Parse(MathFunctionObj.Divide("10", "2")))
                Assert.AreEqual(0.5D, Decimal.Parse(MathFunctionObj.Divide("5", "10")))
            End Sub

            <TestMethod>
            Public Sub NonIntegerDivision()
                Assert.AreEqual(5D, Decimal.Parse(MathFunctionObj.Divide("0.5", "0.1")))
                Assert.AreEqual(3.8D, Decimal.Parse(MathFunctionObj.Divide("11.4", "3")))
                Assert.AreEqual(13.5D, Decimal.Parse(MathFunctionObj.Divide("310.5", "23")))
                Assert.AreEqual(4.3D, Decimal.Parse(MathFunctionObj.Divide("349.16", "81.2")))
            End Sub

            <TestMethod>
            Public Sub DivideByZero()
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Divide("1.0", "0"))
            End Sub

            <TestMethod>
            Public Sub BadInput()
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Divide("text", "10"))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Divide("10", "text"))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Divide("", ""))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Divide(Nothing, ""))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Divide("", Nothing))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Divide(Nothing, Nothing))
            End Sub

        End Class

        ''' <summary>
        ''' Modulus method testing harness
        ''' </summary>
        <TestClass>
        Public Class ModulusMethod
            Inherits MathFunctionsTests

            <TestMethod>
            Public Sub VarietyOfCalculations()
                Assert.AreEqual(0D, Decimal.Parse(MathFunctionObj.Modulus("5", "5")))
                Assert.AreEqual(1D, Decimal.Parse(MathFunctionObj.Modulus("9", "2")))
                Assert.AreEqual(2.1D, Decimal.Parse(MathFunctionObj.Modulus("25.1", "23")))
                Assert.AreEqual(-15.6D, Decimal.Parse(MathFunctionObj.Modulus("-178.2", "27.1")))
            End Sub

            <TestMethod>
            Public Sub DivideByZero()
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Modulus("1.0", "0"))
            End Sub

            <TestMethod>
            Public Sub BadInput()
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Modulus("text", "10"))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Modulus("10", "text"))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Modulus("", ""))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Modulus(Nothing, ""))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Modulus("", Nothing))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Modulus(Nothing, Nothing))
            End Sub

        End Class

        ''' <summary>
        ''' Power method testing harness
        ''' </summary>
        <TestClass>
        Public Class PowerMethod
            Inherits MathFunctionsTests

            <TestMethod>
            Public Sub VarietyOfCalculations()
                Assert.AreEqual(25D, Decimal.Parse(MathFunctionObj.Power("5", "2")))
                Assert.AreEqual(100D, Decimal.Parse(MathFunctionObj.Power("10", "2")))
                Assert.AreEqual(4096D, Decimal.Parse(MathFunctionObj.Power("8", "4")))
                Assert.AreEqual(1079986.28684488D, Decimal.Parse(MathFunctionObj.Power("25.3", "4.3")))
            End Sub

            <TestMethod>
            Public Sub ZeroRaisedtoANonZeroPower()
                Assert.AreEqual(0D, Decimal.Parse(MathFunctionObj.Power(0, 1)))
                Assert.AreEqual(0D, Decimal.Parse(MathFunctionObj.Power(0, 2)))
                Assert.AreEqual(0D, Decimal.Parse(MathFunctionObj.Power(0, 0.5)))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Power(0, -5))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Power(0, -0.5))
            End Sub

            Public Sub ZeroRaisedtoZeroPower()
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Modulus(0, 0))
            End Sub

            <TestMethod>
            Public Sub NonZeroRaisedToZero()
                Assert.AreEqual(1D, Decimal.Parse(MathFunctionObj.Power("1", "1")))
                Assert.AreEqual(0.5D, Decimal.Parse(MathFunctionObj.Power("0.5", "1")))
                Assert.AreEqual(-1D, Decimal.Parse(MathFunctionObj.Power("-1", "1")))
            End Sub

            <TestMethod>
            Public Sub BadInput()
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Power("text", "10"))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Power("10", "text"))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Power("", ""))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Power(Nothing, ""))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Power("", Nothing))
                Assert.AreEqual(Project1.Functions.MathFunctions.ErrorMessage, MathFunctionObj.Power(Nothing, Nothing))
            End Sub

        End Class


    End Class

End Namespace


