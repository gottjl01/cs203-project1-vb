Imports System
Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace PFW.CSIST203.Project1.Tests.Functions

    ''' <summary>
    ''' Arrayfunctions class testing harness
    ''' </summary>
    Public MustInherit Class ArrayFunctionsTests
        Inherits TestBase

        ''' <summary>
        ''' Helper method designed to ensure that two arrays have elements that are equal
        ''' </summary>
        ''' <param name="arr1">The first array to check</param>
        ''' <param name="arr2">The second array to check</param>
        ''' <returns>True if the two arrays are non-null and their elements are exactly equal, otherwise false</returns>
        Protected Function ArraysMatch(arr1 As String(), arr2 As String()) As Boolean
            Dim result = False
            ' arrays must be non-null and exact length for this comparison to occur
            If Not arr1 Is Nothing AndAlso Not arr2 Is Nothing AndAlso arr1.Length = arr2.Length Then
                result = True
                For i As Integer = 0 To arr1.Length - 1 And result
                    result = result And arr1(i).Equals(arr2(i))
                Next
            End If
            Return result
        End Function

        ''' <summary>
        ''' Constructor testing harness
        ''' </summary>
        <TestClass>
        Public Class _Constructor
            Inherits ArrayFunctionsTests

            <TestMethod>
            Public Sub Parameterless()
                Dim obj As PFW.CSIST203.Project1.Functions.ArrayFunctions
                AssertDelegateSuccess(
                    Sub()
                        obj = New Project1.Functions.ArrayFunctions()
                    End Sub,
                    "Failed to instantiate object correctly using default constructor")
                Assert.IsNotNull(obj, "This object cannot be null")
                Assert.AreEqual(PFW.CSIST203.Project1.Functions.ArrayFunctions.DefaultPersistentFile, obj.PersistentFile)
                Assert.IsNotNull(obj.Randomizer)
            End Sub

            <TestMethod>
            Public Sub PersistentFileParameterOnly()
                Dim path As String = System.IO.Path.GetTempFileName()
                Dim obj As PFW.CSIST203.Project1.Functions.ArrayFunctions
                AssertDelegateSuccess(
                    Sub()
                        obj = New Project1.Functions.ArrayFunctions(path)
                    End Sub,
                    "Failed to instantiate object correctly using default constructor")
                Assert.IsNotNull(obj, "This object cannot be null")
                Assert.AreEqual(path, obj.PersistentFile)
                Assert.IsNotNull(obj.Randomizer)
            End Sub

            <TestMethod>
            Public Sub AllParameters()
                Dim path As String = System.IO.Path.GetTempFileName()
                Dim obj As PFW.CSIST203.Project1.Functions.ArrayFunctions
                AssertDelegateSuccess(
                    Sub()
                        obj = New Project1.Functions.ArrayFunctions(path, 123)
                    End Sub,
                    "Failed to instantiate object correctly using default constructor")
                Assert.IsNotNull(obj, "This object cannot be null")
                Assert.AreEqual(path, obj.PersistentFile)
                Assert.IsNotNull(obj.Randomizer)
            End Sub

            <TestMethod>
            Public Sub NullPersistentFileThrowsException()
                Dim obj As PFW.CSIST203.Project1.Functions.ArrayFunctions
                AssertDelegateFailure(
                    Sub()
                        obj = New Project1.Functions.ArrayFunctions(Nothing)
                    End Sub,
                    GetType(ArgumentException),
                    "Instantiation should not have succeeded with a null persistent file specified")
            End Sub

            <TestMethod>
            Public Sub EmptyOrWhitespacePersistentFilenameThrowsException()
                Dim obj As PFW.CSIST203.Project1.Functions.ArrayFunctions
                AssertDelegateFailure(
                    Sub()
                        obj = New Project1.Functions.ArrayFunctions(String.Empty)
                    End Sub,
                    GetType(ArgumentException),
                    "Instantiation should not have succeeded with an emtpy string for the persistent file")

                AssertDelegateFailure(
                    Sub()
                        obj = New Project1.Functions.ArrayFunctions(" ")
                    End Sub,
                    GetType(ArgumentException),
                    "Instantiation should not have succeeded with a whitespace string for the persistent file")
            End Sub

            <TestMethod>
            Public Sub PersistentFilePointsToNonExistentDirectory()

                Dim obj As PFW.CSIST203.Project1.Functions.ArrayFunctions
                Dim path = "C:\temp\" & System.Guid.NewGuid().ToString() & "\temp.tmp"
                AssertDelegateFailure(
                    Sub()
                        obj = New Project1.Functions.ArrayFunctions(path)
                    End Sub,
                    GetType(System.IO.DirectoryNotFoundException),
                    "Instantiation should not have succeeded with a persistent file path pointing to a non-existent directory")

            End Sub

        End Class

        ''' <summary>
        ''' Store method testing harness
        ''' </summary>
        <TestClass>
        Public Class StoreMethod
            Inherits ArrayFunctionsTests

            <TestMethod>
            Public Sub ContentsAreStoredCorrectly()
                Dim array = {"f", "g", "h", "i", "j"}
                Dim contents = String.Join(System.Environment.NewLine, array)
                Dim tmpFile = System.IO.Path.Combine(Me.GetMethodSpecificWorkingDirectory(), PFW.CSIST203.Project1.Functions.ArrayFunctions.DefaultPersistentFile)
                Dim obj As New PFW.CSIST203.Project1.Functions.ArrayFunctions(tmpFile)
                obj.Store(array)

                ' read the contents of the stored file back
                Dim savedContents = String.Empty

                AssertDelegateSuccess(
                    Sub()
                        Using stream As System.IO.Stream = System.IO.File.OpenRead(tmpFile)
                            Using reader As New System.IO.StreamReader(stream)
                                savedContents = reader.ReadToEnd().Trim()
                            End Using
                        End Using
                    End Sub,
                    "The file handle should have been Dispose()'d of when the ArrayFunctions class finishes storing the data")

                Assert.AreEqual(contents, savedContents, "The saved contents needs to match the expected contents")

            End Sub

        End Class

        ''' <summary>
        ''' Load method testing harness
        ''' </summary>
        <TestClass>
        Public Class LoadMethod
            Inherits ArrayFunctionsTests

            <TestMethod>
            Public Sub FileDoesNotExist()
                Dim directory = Me.GetMethodSpecificWorkingDirectory()
                Dim obj As New PFW.CSIST203.Project1.Functions.ArrayFunctions()
                AssertDelegateFailure(
                    Sub()
                        obj.Load(5)
                    End Sub,
                    GetType(System.IO.FileNotFoundException),
                    "The data file should not have been present for this test and loading from it should have failed")
            End Sub

            <TestMethod>
            Public Sub ContentsAreLoadedCorrectly()
                Dim array = {"a", "b", "c", "d", "e"}
                Dim contents = String.Join(System.Environment.NewLine, array)
                Dim tmpFile = System.IO.Path.Combine(Me.GetMethodSpecificWorkingDirectory(), PFW.CSIST203.Project1.Functions.ArrayFunctions.DefaultPersistentFile)
                System.IO.File.WriteAllText(tmpFile, contents)
                Dim obj As New PFW.CSIST203.Project1.Functions.ArrayFunctions()
                Dim data As String()
                AssertDelegateSuccess(
                    Sub()
                        data = obj.Load(array.Length)
                    End Sub,
                    "No failure reading the persistent file should have occurred")
                Assert.IsTrue(ArraysMatch(data, array), "The data read from the persistent file did not match the expected contents")
            End Sub

        End Class

        ''' <summary>
        ''' ShiftRight method testing harness
        ''' </summary>
        <TestClass>
        Public Class ShiftRightMethod
            Inherits ArrayFunctionsTests

            <TestMethod>
            Public Sub ShiftsCorrectly()
                Dim obj As New PFW.CSIST203.Project1.Functions.ArrayFunctions()
                Dim startingArray() = {"a", "b", "c", "d", "e"}
                Dim shift1() = {"e", "a", "b", "c", "d"}
                Dim result1 = obj.ShiftRight(startingArray)
                Assert.IsTrue(ArraysMatch(result1, shift1), "The shifted array element alignment did Not match the expected result")
                Dim shift2() = {"d", "e", "a", "b", "c"}
                Dim result2 = obj.ShiftRight(obj.ShiftRight(startingArray))
                Assert.IsTrue(ArraysMatch(result2, shift2), "The shifted array element alignment did Not match the expected result")
            End Sub

        End Class

        ''' <summary>
        ''' ShiftLeft method testing harness
        ''' </summary>
        <TestClass>
        Public Class ShiftLeftMethod
            Inherits ArrayFunctionsTests

            <TestMethod>
            Public Sub ShiftsCorrectly()
                Dim obj As New PFW.CSIST203.Project1.Functions.ArrayFunctions()
                Dim startingArray() = {"a", "b", "c", "d", "e"}
                Dim shift1() = {"b", "c", "d", "e", "a"}
                Dim result1 = obj.ShiftLeft(startingArray)
                Assert.IsTrue(ArraysMatch(result1, shift1), "The shifted array element alignment did Not match the expected result")
                Dim shift2() = {"c", "d", "e", "a", "b"}
                Dim result2 = obj.ShiftLeft(obj.ShiftLeft(startingArray))
                Assert.IsTrue(ArraysMatch(result2, shift2), "The shifted array element alignment did Not match the expected result")
            End Sub

        End Class

        ''' <summary>
        ''' Randomize method testing harness
        ''' </summary>
        <TestClass>
        Public Class RandomizeMethod
            Inherits ArrayFunctionsTests

            <TestMethod>
            Public Sub RandomizesCorrectly()
                Dim obj As New PFW.CSIST203.Project1.Functions.ArrayFunctions(PFW.CSIST203.Project1.Functions.ArrayFunctions.DefaultPersistentFile, 123)
                Dim startingArray() = {"a", "b", "c", "d", "e"}
                Dim random1() = {"e", "c", "d", "b", "a"}
                startingArray = obj.Randomize(startingArray)
                Assert.IsTrue(ArraysMatch(startingArray, random1), "The first randomization did not result in the expected result")
                ' reset the array back
                startingArray = {"a", "b", "c", "d", "e"}
                Dim rnd As New Random(123)
                Dim manualRandomizer = startingArray.OrderBy(Function(n) rnd.Next()).ToArray()
                Assert.IsTrue(ArraysMatch(random1, manualRandomizer), "The encapsulated randomization did not match the external implementation expectation")
            End Sub

        End Class

        ''' <summary>
        ''' Reverse method testing harness
        ''' </summary>
        <TestClass>
        Public Class ReverseMethod
            Inherits ArrayFunctionsTests

            <TestMethod>
            Public Sub ReversesCorrectly()
                Dim obj As New PFW.CSIST203.Project1.Functions.ArrayFunctions()
                Dim startingArray() = {"a", "b", "c", "d", "e"}
                Dim reversal = {"e", "d", "c", "b", "a"}
                startingArray = obj.Reverse(startingArray)
                Assert.IsTrue(ArraysMatch(startingArray, reversal))
                startingArray = obj.Reverse(startingArray)
                startingArray = obj.Reverse(startingArray)
                Assert.IsTrue(ArraysMatch(startingArray, reversal))
                startingArray = obj.Reverse(startingArray)
                reversal = obj.Reverse(reversal)
                Assert.IsTrue(ArraysMatch(startingArray, reversal))
            End Sub

        End Class

    End Class

End Namespace


