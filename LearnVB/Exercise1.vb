Public Class Exercise1
    Function UCLN(ByVal num1 As Integer, ByVal num2 As Integer) As Long

        Dim result As Long = 1
        If (num1 = 0) Or (num2 = 0) Then
            result = 0
        ElseIf ((num1 Mod num2) = 0) Then
            result = num2
        ElseIf ((num2 Mod num1) = 0) Then
            result = num1
        Else
            Dim i As Integer
            If num1 > num2 Then
                i = num1 - num2
            Else
                i = num2 - num1
            End If
            For j As Integer = i To 1 Step -1
                If (num1 Mod j) = 0 And (num2 Mod j) = 0 Then
                    result = j
                    Exit For
                End If
            Next
        End If

        Return result

    End Function

    Function BCNN(ByVal num1 As Integer, ByVal num2 As Integer) As Long
        If (num1 * num2 = 0) Then
            Return 0
        ElseIf UCLN(num1, num2) = 1 Then
            Return num1 * num2
        ElseIf num1 > num2 Then
            Return num2 * UCLN(num1, num2)
        Else
            Return num1 * UCLN(num1, num2)
        End If
    End Function
End Class
