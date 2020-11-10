Public Class Exercise3

    Function isNguyenTo(ByVal number As Integer) As Boolean

        If number < 2 Then
            Return False

        End If
        For i As Integer = 2 To Int(number / 2)
            If (number Mod i) = 0 Then
                Return False
            End If
        Next

        Return True
    End Function

    Function phanTichNguyenTo(ByVal number As Integer) As String

        Dim phantichNT As String = ""
        Dim i As Integer = 2

        If isNguyenTo(number) = True Then
            Return "" + number
        End If

        Do
            If (number Mod i) = 0 And isNguyenTo(i) = True Then

                If (Int(number / i) >= i) Then
                    phantichNT += CStr(i) + " * "
                Else
                    phantichNT += CStr(i)
                End If

                number = Int(number / i)

            Else
                i += 1
            End If

        Loop While (number >= i)
        Return phantichNT
    End Function
End Class
