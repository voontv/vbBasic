Public Class Exercise2
    Function SumAllNumberInteger(ByVal num As Integer) As Integer

        Dim sum As Integer = 0

        Do
            sum += (num Mod 10)
            num = Int(num / 10)
        Loop While (num > 0)

        Return sum
    End Function
End Class
