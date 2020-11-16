Public Class Exercise7

    Function giaiThua(ByVal number As Integer) As Long
        Dim sum As Long = 1

        If number <= 1 Then
            Return 1
        End If

        For i As Integer = 1 To number
            sum *= i
        Next

        Return sum
    End Function

End Class
