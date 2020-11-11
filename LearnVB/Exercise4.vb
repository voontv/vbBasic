Public Class Exercise4
    Function getFiboInPosition(ByVal position As Integer) As Integer

        If position <= 2 Then
            Return 1
        End If

        Dim n(position - 1) As Integer
        Dim i As Integer
        n(0) = 1
        n(1) = 1
        For i = 2 To (position - 1)
            n(i) = n(i - 1) + n(i - 2)
        Next

        Return n(position - 1)
    End Function

    Sub showFiboInRange(ByVal positionRange As Integer)

        For i As Integer = 1 To positionRange
            If getFiboInPosition(i) <= positionRange Then
                Console.WriteLine("so can xuat la {0}", getFiboInPosition(i))
            Else
                Exit For
            End If
        Next
    End Sub
End Class
