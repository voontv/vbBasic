Public Class DanhSachBaiTap
    Sub HienThiDanhSach()
        Console.WriteLine("Vui lòng chọn danh sach bai tap")
        Console.WriteLine("1. Tim boi chung nho nhat va uoc chung lon nhat")
        Console.WriteLine("2. Tim tong chu so cua 1 so nguyen")
        Console.WriteLine("3. Nhap vao so nguyen va phan tich so do ra thua so nguyen to")
        Console.WriteLine("4. Nhap vao so nguyen n va xuat ra so Fibo khon lon hon n")
        Console.WriteLine("6. Tong day so theo quy luat")
        Console.WriteLine("7. Tinh giai thua cua 1 chang")
    End Sub

    Sub ThucHienBaiTap()
        Dim selectBt As Integer
        Console.WriteLine("Nhap bai tap ban chon select bai tap = ")
        selectBt = Int(Console.ReadLine())

        Console .WriteLine ("Ban vua nhap {0}", selectBt )
        Select Case selectBt
            Case 1
                Dim exercise1 As New Exercise1()
                Dim num1 As Integer
                Dim num2 As Integer

                Console.WriteLine("Nhap so thu nhat")
                num1 = Int(Console.ReadLine())

                Console.WriteLine("Nhap so thu hai")
                num2 = Int(Console.ReadLine())

                Console.WriteLine("Uoc chung lon nhat la {0} ", exercise1.UCLN(num1, num2))
                Console.WriteLine("Boi chung nho nhat la {0} ", exercise1.BCNN(num1, num2))

            Case 2
                Dim exercise2 As New Exercise2()
                Dim num As Integer

                Console.WriteLine("Nhap so nguyen can tim")
                num = Int(Console.ReadLine())

                Console.WriteLine("Tong cac chu so la {0}", exercise2.SumAllNumberInteger(num))

            Case 3
                Dim exercise3 As New Exercise3()
                Dim num As Integer

                Console.WriteLine("Nhap so nguyen can tim")
                num = Int(Console.ReadLine())
                Console.WriteLine("So phan tich ra  so nguyen to {0}", exercise3.phanTichNguyenTo(num))

            Case 4
                Dim exercise4 As New Exercise4()
                Dim num As Integer

                Console.WriteLine("Nhap so nguyen")
                num = Int(Console.ReadLine)
                exercise4.showFiboInRange(num)

            Case 5
                Dim exercise5 As New Exercise5()
                exercise5.showNumber()

            Case 6
                Dim exercise6 As New Exercise6()
                Dim num As Integer

                Console.WriteLine("Nhap so nguyen")
                num = Int(Console.ReadLine)
                Console.WriteLine("Ket qua la {0} ", exercise6.sumRange(num))

            Case 7
                Dim exercise7 As New Exercise7()
                Dim num As Integer

                Console.WriteLine("Nhap so nguyen")
                num = Int(Console.ReadLine)
                Console.WriteLine("Ket qua la {0} ", exercise7.giaiThua(num))

            Case 0
                Console.WriteLine("Thoat chuong trinh")
        End Select
    End Sub
End Class
