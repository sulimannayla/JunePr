Option Explicit On 
Module Module2
    Public comp As String
    Public Const A = "›ﬁÿ"
    Public Const B = "·«€Ì—"
    Public Const k = "Ê"
    Public Const w = "Ã‰ÌÂ«"
    Public Const q = "ﬁ—‘«"
    Public Const o = "√·›"
    Public Const e = "„·ÌÊ‰"
    Public Const h = "¬·«›"
    Public Const USD = "œÊ·«— √„—ÌﬂÏ "
    Public Const KG = "ﬂÃ„"
    Public Const TN = "ÿ‰"
    Public Const SS = "”‰ « "
    Public Const sp = " "

    Public FUSD As Byte
    Public gsDatabase As String
    Public Function NUM(ByVal n As Double) As String
        Dim r(120) As String
        r(1) = "Ê«Õœ"
        r(2) = "√À‰Ì‰"
        r(3) = "À·«À…"
        r(4) = "√—»⁄Â"
        r(5) = "Œ„”…"
        r(6) = "” …"
        r(7) = "”»⁄…"
        r(8) = "À„«‰Ì…"
        r(9) = " ”⁄…"
        r(10) = "⁄‘—…"
        r(11) = "√ÕœÏ ⁄‘—…"
        r(12) = "√À‰« ⁄‘—…"
        r(20) = "⁄‘—Ê‰"
        r(30) = "À·«ÀÊ‰"
        r(40) = "√—»⁄Ê‰"
        r(50) = "Œ„”Ê‰"
        r(60) = "” Ê‰"
        r(70) = "”»⁄Ê‰"
        r(80) = "À„«‰Ê‰"
        r(90) = " ”⁄Ê‰"
        r(100) = "„«∆Â"
        r(101) = "„«∆ «‰"
        r(102) = "À·«À„«∆Â"
        r(102) = "√—»⁄„«∆Â"
        r(102) = "Œ„”„«∆Â"
        r(103) = "” „«∆Â"
        r(104) = "”»⁄„«∆Â"
        r(105) = "À„«‰„«∆Â"
        r(106) = " ”⁄„«∆Â"
        r(110) = "√·›"
        r(115) = "¬·«›"
        r(118) = "„·ÌÊ‰"
        Select Case n
            Case 1
                NUM = r(1)
            Case 2
                NUM = r(2)
            Case 3
                NUM = r(3)
            Case 4
                NUM = r(4)
            Case 5
                NUM = r(5)
            Case 6
                NUM = r(6)
            Case 7
                NUM = r(7)
            Case 8
                NUM = r(8)
            Case 9
                NUM = r(9)
            Case 10
                NUM = r(10)
            Case 11
                NUM = r(11)
            Case 12
                NUM = r(12)
            Case 13
                NUM = r(3) & " " & r(10)
            Case 14
                NUM = r(4) & " " & r(10)
            Case 15
                NUM = r(5) & " " & r(10)
            Case 16
                NUM = r(6) & " " & r(10)
            Case 17
                NUM = r(7) & " " & r(10)
            Case 18
                NUM = r(8) & " " & r(10)
            Case 19
                NUM = r(9) & " " & r(10)
            Case 20
                NUM = r(20)
            Case 21
                NUM = r(1) & " " & k & r(20)
            Case 22
                NUM = r(2) & " " & k & r(20)
            Case 23
                NUM = r(3) & " " & k & r(20)
            Case 24
                NUM = r(4) & " " & k & r(20)
            Case 25
                NUM = r(5) & " " & k & r(20)
            Case 26
                NUM = r(6) & " " & k & r(20)
            Case 27
                NUM = r(7) & " " & k & r(20)
            Case 28
                NUM = r(8) & " " & k & r(20)
            Case 29
                NUM = r(9) & " " & k & r(20)
            Case 30
                NUM = r(30)
            Case 31
                NUM = r(1) & " " & k & r(30)
            Case 32
                NUM = r(2) & " " & k & r(30)
            Case 33
                NUM = r(3) & " " & k & r(30)
            Case 34
                NUM = r(4) & " " & k & r(30)
            Case 35
                NUM = r(5) & " " & k & r(30)
            Case 36
                NUM = r(6) & " " & k & r(30)
            Case 37
                NUM = r(7) & " " & k & r(30)
            Case 38
                NUM = r(8) & " " & k & r(30)
            Case 39
                NUM = r(9) & " " & k & r(30)
            Case 40
                NUM = r(40)
            Case 41
                NUM = r(1) & " " & k & r(40)
            Case 42
                NUM = r(2) & " " & k & r(40)
            Case 43
                NUM = r(3) & " " & r(40)
            Case 44
                NUM = r(4) & " " & k & r(40)
            Case 45
                NUM = r(5) & " " & k & r(40)
            Case 46
                NUM = r(6) & " " & k & r(40)
            Case 47
                NUM = r(7) & " " & k & r(40)
            Case 48
                NUM = r(8) & " " & k & r(40)
            Case 49
                NUM = r(9) & " " & k & r(40)
            Case 50
                NUM = r(50)
            Case 51
                NUM = r(1) & " " & k & r(50)
            Case 52
                NUM = r(2) & " " & k & r(50)
            Case 53
                NUM = r(3) & " " & k & r(50)
            Case 54
                NUM = r(4) & " " & k & r(50)
            Case 55
                NUM = r(5) & " " & k & r(50)
            Case 56
                NUM = r(6) & " " & k & r(50)
            Case 57
                NUM = r(7) & " " & k & r(50)
            Case 58
                NUM = r(8) & " " & k & r(50)
            Case 59
                NUM = r(9) & " " & k & r(50)
            Case 60
                NUM = r(60)
            Case 61
                NUM = r(1) & " " & k & r(60)
            Case 62
                NUM = r(2) & " " & k & r(60)
            Case 63
                NUM = r(3) & " " & k & r(60)
            Case 64
                NUM = r(4) & " " & k & r(60)
            Case 65
                NUM = r(5) & " " & k & r(60)
            Case 66
                NUM = r(6) & " " & k & r(60)
            Case 67
                NUM = r(7) & " " & k & r(60)
            Case 68
                NUM = r(8) & " " & k & r(60)
            Case 69
                NUM = r(9) & " " & k & r(60)
            Case 70
                NUM = r(70)
            Case 71
                NUM = r(1) & " " & k & r(70)
            Case 72
                NUM = r(2) & " " & k & r(70)
            Case 73
                NUM = r(3) & " " & k & r(70)
            Case 74
                NUM = r(4) & " " & k & r(70)
            Case 75
                NUM = r(5) & " " & k & r(70)
            Case 76
                NUM = r(6) & " " & k & r(70)
            Case 77
                NUM = r(7) & " " & k & r(70)
            Case 78
                NUM = r(8) & " " & k & r(70)
            Case 79
                NUM = r(9) & " " & k & r(70)
            Case 80
                NUM = r(80)
            Case 81
                NUM = r(1) & " " & k & r(80)
            Case 82
                NUM = r(2) & " " & k & r(80)
            Case 83
                NUM = r(3) & " " & k & r(80)
            Case 84
                NUM = r(4) & " " & k & r(80)
            Case 85
                NUM = r(5) & " " & k & r(80)
            Case 86
                NUM = r(6) & " " & k & r(80)
            Case 87
                NUM = r(7) & " " & k & r(80)
            Case 88
                NUM = r(8) & " " & k & r(80)
            Case 89
                NUM = r(9) & " " & k & r(80)
            Case 90
                NUM = r(90)
            Case 91
                NUM = r(1) & " " & k & r(90)
            Case 92
                NUM = r(2) & " " & k & r(90)
            Case 93
                NUM = r(3) & " " & k & r(90)
            Case 94
                NUM = r(4) & " " & k & r(90)
            Case 95
                NUM = r(5) & " " & k & r(90)
            Case 96
                NUM = r(6) & " " & k & r(90)
            Case 97
                NUM = r(7) & " " & k & r(90)
            Case 98
                NUM = r(8) & " " & k & r(90)
            Case 99
                NUM = r(9) & " " & k & r(90)
            Case 100
                NUM = r(100)
        End Select
    End Function
    Public Function Num1(ByVal n As Double) As String
        Dim i As Integer
        Dim h As Integer
        Dim u As Integer
        Dim r(120) As String
        r(100) = "„«∆Â"
        r(101) = "„«∆ «‰"
        r(102) = "À·«À„«∆Â"
        r(103) = "√—»⁄„«∆Â"
        r(104) = "Œ„”„«∆Â"
        r(105) = "” „«∆Â"
        r(106) = "”»⁄„«∆Â"
        r(107) = "À„«‰„«∆Â"
        r(108) = " ”⁄„«∆Â"
        r(109) = "√·›"
        For i = 101 To 199
            Select Case n
                Case i
                    Num1 = r(100) & " " & k & NUM(n - 100)
            End Select
        Next i
        For i = 201 To 299
            Select Case n
                Case i
                    Num1 = r(101) & " " & k & NUM(n - 200)
            End Select
        Next i
        For i = 301 To 399
            Select Case n
                Case i
                    Num1 = r(102) & " " & k & NUM(n - 300)
            End Select
        Next i
        For i = 401 To 499
            Select Case n
                Case i
                    Num1 = r(103) & " " & k & NUM(n - 400)
            End Select
        Next i
        For i = 501 To 599
            Select Case n
                Case i
                    Num1 = r(104) & " " & k & NUM(n - 500)
            End Select
        Next i
        For i = 601 To 699
            Select Case n
                Case i
                    Num1 = r(105) & " " & k & NUM(n - 600)
            End Select
        Next i
        For i = 701 To 799
            Select Case n
                Case i
                    Num1 = r(106) & " " & k & NUM(n - 700)
            End Select
        Next i
        For i = 801 To 899
            Select Case n
                Case i
                    Num1 = r(107) & " " & k & NUM(n - 800)
            End Select
        Next i
        For i = 901 To 999
            Select Case n
                Case i
                    Num1 = r(108) & " " & k & NUM(n - 900)
            End Select
        Next i
        Select Case n
            Case 100
                Num1 = r(100)
            Case 200
                Num1 = r(101)
            Case 300
                Num1 = r(102)
            Case 400
                Num1 = r(103)
            Case 500
                Num1 = r(104)
            Case 600
                Num1 = r(105)
            Case 700
                Num1 = r(106)
            Case 800
                Num1 = r(107)
            Case 900
                Num1 = r(108)
            Case 1000
                Num1 = r(109)
        End Select
    End Function
    Public Function Num2(ByVal n As Double) As String
        Dim i As Double
        Dim txt As String
        For i = 1000 To 999999
            Select Case n
                Case i
                    If i / 1000 < 100 Then
                        Num2 = NUM(i / 1000) & " " & o
                    ElseIf i / 1000 >= 100 And i / 1000 <= 1000 Then
                        Num2 = Num1(i / 1000) & " " & o & " " & Num4(i / 1000)
                    End If
            End Select
        Next
    End Function
    Public Function Num3(ByVal n As Double) As String
        Dim r(120) As String
        r(1) = "√·›"
        r(2) = "√·›«‰"
        r(3) = "À·«À… ¬·«›"
        r(4) = "√—»⁄Â ¬·«›"
        r(5) = "Œ„”… ¬·«›"
        r(6) = "” … ¬·«›"
        r(7) = "”»⁄… ¬·«›"
        r(8) = "À„«‰Ì… ¬·«›"
        r(9) = " ”⁄… ¬·«›"
        r(10) = "⁄‘—… ¬·«›"
        Select Case n
            Case 1
                Num3 = r(1)
            Case 2
                Num3 = r(2)
            Case 3
                Num3 = r(3)
            Case 4
                Num3 = r(4)
            Case 5
                Num3 = r(5)
            Case 6
                Num3 = r(6)
            Case 7
                Num3 = r(7)
            Case 8
                Num3 = r(8)
            Case 9
                Num3 = r(9)
            Case 10
                Num3 = r(10)
        End Select
    End Function
    Public Function Num4(ByVal n As Double) As String
        Dim i As Double
        Dim txt As String
        For i = 1000 To 1000000
            Select Case n
                Case i
                    If i Mod 1000 < 100 Then Num4 = NUM(i Mod 1000)
                    If i Mod 1000 >= 100 And i Mod 1000 <= 1000 Then Num4 = Num1(i Mod 1000)

            End Select
        Next
    End Function
    Public Function Num5(ByVal n As Double) As String
        Dim S As Integer
        If FUSD = 1 Then
            S = Val(n) Mod 1000
            If Val(n) >= 100000 Then
                Num5 = A & " " & Num2((n) - (S))
                If S > 0 Then Num5 = A & " " & Num2((n) - S) & " " & k & Num4(n) & " " & w
                If S = 0 Then Num5 = Num5 & " " & w
            ElseIf Val(n / 1000) >= 1 And Val(n / 1000) <= 10 Then
                Num5 = A & " " & Num3(((n) - S) / 1000) & " " & w
                If S > 0 Then Num5 = A & " " & Num3(((n) - S) / 1000) & " " & k & Num4(n) & " " & w
                If S = 0 Then Num5 = Num5 & " " & w
            ElseIf Val(n / 1000) >= 10 And Val(n / 1000) <= 100 Then
                Num5 = A & " " & NUM(((n) - S) / 1000) & " " & o
                If S > 0 Then Num5 = Num5 & " " & k & Num4(n) & " " & w
                If S = 0 Then Num5 = Num5 & " " & w
            ElseIf Val(n / 1000) >= 100 And Val(n / 1000) < 1000 Then
                Num5 = A & " " & Num1(((n) - S) / 1000) & " " & o
                If S > 0 Then Num5 = Num5 & " " & k & Num4(n) & " " & w
                If S = 0 Then Num5 = Num5 & " " & w
            ElseIf Val(n) <= 100 Then
                Num5 = A & " " & NUM(n) & " " & w
            ElseIf Val(n) >= 100 And Val(n) <= 1000 Then
                Num5 = A & " " & Num1(n) & " " & w
            End If
        ElseIf FUSD = 2 Then
            S = Val(n) Mod 1000
            If Val(n) >= 100000 Then
                Num5 = A & " " & Num2((n) - S)
                If S > 0 Then Num5 = A & " " & Num2((n) - S) & " " & k & Num4(n) & " " & USD
                If S = 0 Then Num5 = Num5 & " " & USD
            ElseIf Val(n / 1000) >= 1 And Val(n / 1000) <= 10 Then
                Num5 = A & " " & Num3(((n) - S) / 1000) & " " & USD
                If S > 0 Then Num5 = A & " " & Num3(((n) - S) / 1000) & " " & k & Num4(n) & " " & USD
                If S = 0 Then Num5 = Num5 & " " & USD
            ElseIf Val(n / 1000) >= 10 And Val(n / 1000) <= 100 Then
                Num5 = A & " " & NUM(((n) - S) / 1000) & " " & o
                If S > 0 Then Num5 = Num5 & " " & k & Num4(n) & " " & USD
                If S = 0 Then Num5 = Num5 & " " & USD
            ElseIf Val(n / 1000) >= 100 And Val(n / 1000) < 1000 Then
                Num5 = A & " " & Num1(((n) - S) / 1000) & " " & o
                If S > 0 Then Num5 = Num5 & " " & k & Num4(n) & " " & USD
                If S = 0 Then Num5 = Num5 & " " & USD
            ElseIf Val(n) <= 100 Then
                Num5 = A & " " & NUM(n) & " " & USD
            ElseIf Val(n) >= 100 And Val(n) <= 1000 Then
                Num5 = A & " " & Num1(n) & " " & USD
            End If
        ElseIf FUSD = 3 Then
            S = Val(n) Mod 1000
            If Val(n) >= 100000 Then
                Num5 = A & " " & Num2((n) - S)
                If S > 0 Then Num5 = A & " " & Num2((n) - S) & " " & k & Num4(n) & " " & TN
                If S = 0 Then Num5 = Num5 & " " & TN
            ElseIf Val(n / 1000) >= 1 And Val(n / 1000) <= 10 Then
                Num5 = A & " " & Num3(((n) - S) / 1000) & " " & TN
                If S > 0 Then Num5 = A & " " & Num3(((n) - S) / 1000) & " " & k & Num4(n) & " " & TN
                If S = 0 Then Num5 = Num5 & " " & TN
            ElseIf Val(n / 1000) >= 10 And Val(n / 1000) <= 100 Then
                Num5 = A & " " & NUM(((n) - S) / 1000) & " " & o
                If S > 0 Then Num5 = Num5 & " " & k & Num4(n) & " " & TN
                If S = 0 Then Num5 = Num5 & " " & TN
            ElseIf Val(n / 1000) >= 100 And Val(n / 1000) < 1000 Then
                Num5 = A & " " & Num1(((n) - S) / 1000) & " " & o
                If S > 0 Then Num5 = Num5 & " " & k & Num4(n) & " " & TN
                If S = 0 Then Num5 = Num5 & " " & TN
            ElseIf Val(n) <= 100 Then
                Num5 = A & " " & NUM(n) & " " & TN
            ElseIf Val(n) >= 100 And Val(n) <= 1000 Then
                Num5 = A & " " & Num1(n) & " " & TN
            End If
        End If
    End Function

    Public Function Num6(ByVal n As Double) As String
        Dim i As Double
        Dim txt As String
        Dim F As String
        Dim S As String
        Dim m As Double
        F = Format(n, "#,#0.00")
        S = Right(F, 2)
        If FUSD = 1 Then
            For i = 1 To 100
                Select Case Val(S)
                    Case i
                        Num6 = NUM(i) & " " & q
                End Select
            Next
        ElseIf FUSD = 3 Then
            F = Format(n, "#,#0.000")
            S = Right(F, 3)
            For i = 1 To 999
                Select Case Val(S)
                    Case i
                        Num6 = Num1(i) & " " & KG
                End Select
            Next i
        ElseIf FUSD = 2 Then
            F = Format(n, "#,#0.00")
            S = Right(F, 2)
            For i = 1 To 100
                Select Case Val(S)
                    Case i
                        Num6 = NUM(i) & " " & SS
                End Select
            Next i
        End If
    End Function
    Public Function Num7(ByVal n As Double) As String
        Dim F As String
        Dim S As String
        F = Format(n, "#,#0.00")
        Num7 = Num5(Val(n) - Val(Right(F, 3)))
        If Val(Right(F, 3)) > 0 Then Num7 = Num7 & " " & k & Num6(F)
    End Function
    Public Function Num10(ByVal n As Double) As String
        Dim c As Long
        If FUSD = 1 Then
            If Val(n) >= 1000000 And Val(n) <= 100000000 Then
                c = Val(n) Mod 1000000
                Num10 = A & " " & NUM(((n) - c) / 1000000) & " " & e
                If c > 0 Then Num10 = Num10 & " " & k & Num8(c)
                If c = 0 Then Num10 = Num10 & " " & w
            End If
        ElseIf FUSD = 2 Then
            If Val(n) >= 1000000 And Val(n) <= 100000000 Then
                c = Val(n) Mod 1000000
                Num10 = A & " " & NUM(((n) - c) / 1000000) & " " & e
                If c > 0 Then Num10 = Num10 & " " & k & Num8(c)
                If c = 0 Then Num10 = Num10 & " " & USD
            End If
        ElseIf FUSD = 3 Then
            If Val(n) >= 1000000 And Val(n) <= 100000000 Then
                c = Val(n) Mod 1000000
                Num10 = A & " " & NUM(((n) - c) / 1000000) & " " & e
                If c > 0 Then Num10 = Num10 & " " & k & Num8(c)
                If c = 0 Then Num10 = Num10 & " " & TN
            End If
        End If
    End Function
    Public Function Num8(ByVal n As Double) As String
        Dim S As Integer
        If FUSD = 1 Then
            S = Val(n) Mod 1000
            If Val(n) >= 100000 Then
                Num8 = Num2((n) - S)
                If S > 0 Then Num8 = Num2((n) - S) & " " & k & Num4(n) & " " & w
                If S = 0 Then Num8 = Num2((n) - S) & " " & w
            ElseIf Val(n / 1000) >= 1 And Val(n / 1000) <= 10 Then
                Num8 = A & " " & Num3(((n) - S) / 1000) & " " & w
                If S > 0 Then Num8 = Num3(((n) - S) / 1000) & " " & k & Num4(n) & " " & w
                If S = 0 Then Num8 = Num3(((n) - S) / 1000) & " " & w
            ElseIf Val(n / 1000) >= 10 And Val(n / 1000) <= 100 Then
                Num8 = NUM(((n) - S) / 1000) & " " & o
                If S > 0 Then Num8 = Num8 & " " & k & Num4(n) & " " & w
                If S = 0 Then Num8 = Num8 & " " & w
            ElseIf Val(n / 1000) >= 100 And Val(n / 1000) < 1000 Then
                Num8 = Num1(((n) - S) / 1000) & " " & o
                If S > 0 Then Num8 = Num8 & " " & k & Num4(n) & " " & w
                If S = 0 Then Num8 = Num8 & " " & w
            ElseIf Val(n) >= 100 And Val(n) <= 1000 Then
                Num8 = Num1(n) & " " & w
            ElseIf Val(n) <= 100 Then
                Num8 = NUM(n) & " " & w

            End If
        ElseIf FUSD = 2 Then
            S = Val(n) Mod 1000
            If Val(n) >= 100000 Then
                Num8 = Num2((n) - S)
                If S > 0 Then Num8 = Num2((n) - S) & " " & k & Num4(n) & " " & USD
                If S = 0 Then Num8 = Num2((n) - S) & " " & USD
            ElseIf Val(n / 1000) >= 1 And Val(n / 1000) <= 10 Then
                Num8 = A & " " & Num3(((n) - S) / 1000) & " " & USD
                If S > 0 Then Num8 = Num3(((n) - S) / 1000) & " " & k & Num4(n) & " " & USD
                If S = 0 Then Num8 = Num3(((n) - S) / 1000) & " " & USD
            ElseIf Val(n / 1000) >= 10 And Val(n / 1000) <= 100 Then
                Num8 = NUM(((n) - S) / 1000) & " " & o
                If S > 0 Then Num8 = Num8 & " " & k & Num4(n) & " " & USD
                If S = 0 Then Num8 = Num8 & " " & USD
            ElseIf Val(n / 1000) >= 100 And Val(n / 1000) < 1000 Then
                Num8 = Num1(((n) - S) / 1000) & " " & o
                If S > 0 Then Num8 = Num8 & " " & k & Num4(n) & " " & USD
                If S = 0 Then Num8 = Num8 & " " & USD
            ElseIf Val(n) <= 100 Then
                Num8 = NUM(n) & " " & USD
            ElseIf Val(n) >= 100 And Val(n) <= 1000 Then
                Num8 = Num1(n) & " " & USD
            End If
        ElseIf FUSD = 3 Then
            S = Val(n) Mod 1000
            If Val(n) >= 100000 Then
                Num8 = Num2((n) - S)
                If S > 0 Then Num8 = Num2((n) - S) & " " & k & Num4(n) & " " & TN
                If S = 0 Then Num8 = Num2((n) - S) & " " & TN
            ElseIf Val(n / 1000) >= 1 And Val(n / 1000) <= 10 Then
                Num8 = A & " " & Num3(((n) - S) / 1000) & " " & TN
                If S > 0 Then Num8 = Num3(((n) - S) / 1000) & " " & k & Num4(n) & " " & TN
                If S = 0 Then Num8 = Num3(((n) - S) / 1000) & " " & TN
            ElseIf Val(n / 1000) >= 10 And Val(n / 1000) <= 100 Then
                Num8 = NUM(((n) - S) / 1000) & " " & o
                If S > 0 Then Num8 = Num8 & " " & k & Num4(n) & " " & TN
                If S = 0 Then Num8 = Num8 & " " & TN
            ElseIf Val(n / 1000) >= 100 And Val(n / 1000) < 1000 Then
                Num8 = Num1(((n) - S) / 1000) & " " & o
                If S > 0 Then Num8 = Num8 & " " & k & Num4(n) & " " & TN
                If S = 0 Then Num8 = Num8 & " " & TN
            ElseIf Val(n) <= 100 Then
                Num8 = NUM(n) & " " & TN
            ElseIf Val(n) >= 100 And Val(n) <= 1000 Then
                Num8 = Num1(n) & " " & TN
            End If
        End If
    End Function
    Public Function Num9(ByVal n As Double, ByVal FLAG As Byte) As String
        Dim F As String
        Dim S As String
        FUSD = FLAG
        F = Format(Math.Abs(n), "#,#0.00")
        If Val(F) > 0 And Val(F) < 1 Then
            Num9 = A & " " & Num6(F) & " " & B
        End If
        If Val(n) >= 1 And Val(n) < 1000000 Then
            Num9 = Num7(Math.Abs(n)) & " " & B
        ElseIf Val(n) >= 1000000 And Val(n) <= 100000000 Then
            Num9 = Num10(Val(Math.Abs(n)) - Val(Right(F, 3))) & " " & B
            If Val(Right(F, 3)) > 0 Then Num9 = Num10(Math.Abs(Val(n)) - Val(Right(F, 3))) & " " & k & Num6(F) & " " & B
        End If
    End Function
    Public Function Horof(ByVal X As Double)
        Dim Ma As String = " Ã‰ÌÂ«"
        Dim Mi As String = " ﬁ—‘√"
        Dim F As String = """ ›ﬁÿ "
        Dim L As String = "·«€Ì—"""
        Dim N As Integer = Int(X)
        Dim B As Double = Val(Right(Format(Math.Abs(X), "000000000000.00"), 2))
        Dim R As String = F & " " & SHorof(N)
        Dim Result As String
        If R <> "" And B > 0 Then Result = R & Ma & " Ê " & NUM(B) & " " & Mi
        If R <> "" And B = 0 Then Result = R & Ma
        If R = "" And B <> 0 Then Result = NUM(B) & " " & Mi
        Horof = Result & " " & L
    End Function

    Public Function SHorof(ByVal X As Double)
        Dim C = Format(Math.Abs(X), "000000000000")
        Dim C1 As String = Val(Mid(C, 12, 1))

        Dim Letter1 As String
        Select Case C1
            'Case Is = 0 : Letter1 = "À„«‰" 'issa1
            Case Is = 1 : Letter1 = "Ê«Õœ"
            Case Is = 2 : Letter1 = "«À‰«‰"
            Case Is = 3 : Letter1 = "À·«À…"
            Case Is = 4 : Letter1 = "«—»⁄…"
            Case Is = 5 : Letter1 = "Œ„”…"
            Case Is = 6 : Letter1 = "” …"
            Case Is = 7 : Letter1 = "”»⁄…"
            Case Is = 8 : Letter1 = "À„«‰Ì…"
            Case Is = 9 : Letter1 = " ”⁄…"
        End Select

        Dim C2 As String = Val(Mid(C, 11, 1))
        Dim Letter2 As String
        Select Case C2
            Case Is = 1 : Letter2 = "⁄‘—"
            Case Is = 2 : Letter2 = "⁄‘—Ê‰"
            Case Is = 3 : Letter2 = "À·«ÀÊ‰"
            Case Is = 4 : Letter2 = "«—»⁄Ê‰"
            Case Is = 5 : Letter2 = "Œ„”Ê‰"
            Case Is = 6 : Letter2 = "” Ê‰"
            Case Is = 7 : Letter2 = "”»⁄Ê‰"
            Case Is = 8 : Letter2 = "À„«‰Ê‰"
            Case Is = 9 : Letter2 = " ”⁄Ê‰"
        End Select

        If Letter1 <> "" And C2 > 1 Then Letter2 = Letter1 + " Ê" + Letter2
        If Letter2 = "" Then Letter2 = Letter1
        If C1 = 0 And C2 = 1 Then Letter2 = Letter2 + "…"
        If C1 = 1 And C2 = 1 Then Letter2 = "«ÕœÏ ⁄‘—"
        If C1 = 2 And C2 = 1 Then Letter2 = "«À‰Ï ⁄‘—"
        If C1 > 2 And C2 = 1 Then Letter2 = Letter1 + " " + Letter2
        Dim C3 As String = Val(Mid(C, 10, 1))
        Dim Letter3 As String
        Select Case C3
            Case Is = 1 : Letter3 = "„«∆…"
            Case Is = 2 : Letter3 = "„∆ «‰"

            Case Is > 2 : If SHorof(C3) = "À„«‰Ì…" Then
                    Letter3 = Left(SHorof(C3), Len(SHorof(C3)) - 2) + "„«∆…"
                Else
                    Letter3 = Left(SHorof(C3), Len(SHorof(C3)) - 1) + "„«∆…"
                End If
        End Select
        If Letter3 <> "" And Letter2 <> "" Then Letter3 = Letter3 + " Ê" + Letter2
        If Letter3 = "" Then Letter3 = Letter2

        Dim C4 As String = Val(Mid(C, 7, 3))
        Dim Letter4 As String
        Select Case C4
            Case Is = 1 : Letter4 = "«·›"
            Case Is = 2 : Letter4 = "«·›«‰"
            Case 3 To 10 : Letter4 = SHorof(C4) + " ¬·«›"
            Case Is >= 10 : Letter4 = SHorof(C4) + " «·›"
        End Select
        If Letter4 <> "" And Letter3 <> "" Then Letter4 = Letter4 + " Ê" + Letter3
        If Letter4 = "" Then Letter4 = Letter3

        Dim C5 As String = Val(Mid(C, 4, 3))
        Dim Letter5 As String
        Select Case C5
            Case Is = 1 : Letter5 = "„·ÌÊ‰"
            Case Is = 2 : Letter5 = "„·ÌÊ‰«‰"
            Case 3 To 10 : Letter5 = SHorof(C5) + " „·«ÌÌ‰"
            Case Is > 10 : Letter5 = SHorof(C5) + " „·ÌÊ‰"
        End Select
        If Letter5 <> "" And Letter4 <> "" Then Letter5 = Letter5 + " Ê" + Letter4
        If Letter5 = "" Then Letter5 = Letter4

        Dim C6 As String = Val(Mid(C, 1, 3))
        Dim Letter6 As String
        Select Case C6
            Case Is = 1 : Letter6 = "„·Ì«—"
            Case Is = 2 : Letter6 = "„·Ì«—«‰"
            Case Is > 2 : Letter6 = SHorof(C6) + " „·Ì«—"
        End Select
        If Letter6 <> "" And Letter5 <> "" Then Letter6 = Letter6 + " Ê" + Letter5
        If Letter6 = "" Then Letter6 = Letter5
        SHorof = Letter6
    End Function



End Module

