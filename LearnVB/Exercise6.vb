Public Class Exercise6

    Function sumRange(ByVal number As Integer) As Integer
        Dim sum As Integer = 0

        For i As Integer = 1 To number
            sum += i * (i + 1)
        Next

        Return sum
    End Function

End Class
