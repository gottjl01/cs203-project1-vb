Namespace PFW.CSIST203.Project1.Functions

    Public Class ArrayFunctions

        ''' <summary>
        ''' The persistent file used to load and store data when the Store() and Load() methods are utilized
        ''' </summary>
        ''' <returns></returns>
        Friend Property PersistentFile As String

        ''' <summary>
        ''' The default name of the persistent file used when storing and loading when the parameterless constructor is used
        ''' </summary>
        Public Shared ReadOnly DefaultPersistentFile As String = "data.txt"

        Friend Property Randomizer As Random

        Public Sub New()
            Throw New NotImplementedException()
        End Sub

        Public Sub New(persistentFile As String)
            Throw New NotImplementedException()
        End Sub

        Public Sub New(persistentFile As String, seed? As Integer)
            Throw New NotImplementedException()
        End Sub


        Public Sub Store(data As String())
            Throw New NotImplementedException()
        End Sub

        Public Function Load(dataCount As Integer) As String()
            Throw New NotImplementedException()
        End Function

        Public Function Randomize(data As String()) As String()
            Throw New NotImplementedException()
        End Function

        Public Function ShiftRight(data As String()) As String()
            Throw New NotImplementedException()
        End Function

        Public Function ShiftLeft(data As String()) As String()
            Throw New NotImplementedException()
        End Function

        Public Function Reverse(data As String()) As String()
            Throw New NotImplementedException()
        End Function

    End Class

End Namespace
