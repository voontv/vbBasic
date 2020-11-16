Public Class Exercise5

    Function isOk(ByVal number As Integer) As Boolean

        Dim lengthNumber As Integer = CStr(number).Length
        Dim sum As Integer = 0
        Dim numbertg As Integer = number

        Do
            sum += Int(Math.Pow((numbertg Mod 10), lengthNumber))

            If sum > number Then
                Return False
            End If

            numbertg = Int(numbertg / 10)
        Loop While numbertg > 0

        If number = sum Then
            Return True
        Else
            Return False
        End If
    End Function

    Sub showNumber()

        For i As Integer = 100 To 100000
            If isOk(i) Then
                Console.WriteLine(i)
            End If
        Next
    End Sub

End Class
