Public Class Exercise8

    'Const saiSo As Double = 0.0001
    Function tinhSoPI() As Double
        Dim sum As Double = 0.0
        Dim n As Integer = 0
        Dim e As Double
        Dim saiSo As Double = 0.0001

        Do
            e = 1 / (2 * n + 1)

            If n Mod 2 = 0 Then
                sum += e
            Else
                sum -= e
            End If

            n += 1
        Loop While ((e - saiSo) > 0)


        Return Math.Round((4 * sum), 5)
    End Function
End Class
