Imports System
Imports System.Globalization

Module Program
    Sub Main(args As String())

        Dim employee As String
        Dim company As String
        Dim ans As String
        Dim asSalary As Integer
        Dim ms As Integer

        Do
            Console.Clear()
            Console.Write("NAME OF EMPLOYEE: ")
            employee = Console.ReadLine()
            Console.Write("NAME OF COMPANY: ")
            company = Console.ReadLine()
            Console.Write("MONTHLY SALARY: ")
            ms = Convert.ToInt32(Console.ReadLine())

            asSalary = ms * 12

            Console.WriteLine(vbNewLine & vbTab & "INCOME TAX: " & Format(incomeTax(asSalary), "0.00"))
            Console.WriteLine(vbTab & "SSS CONTRIBUTION: " & SSScon(ms))
            Console.WriteLine(vbTab & "PAG-IBIG: " & PagIbig(ms))
            Console.WriteLine(vbTab & "PHILHEALTH: " & Philhealth(ms))

            Console.Write(vbNewLine & "ANOTHER INQUIRY [Y/N]? ")
            ans = Console.ReadLine()
        Loop While ans.Equals("Y", StringComparison.OrdinalIgnoreCase)

        Console.Clear()
        Console.WriteLine(vbNewLine & vbTab & "THANK YOU")
    End Sub

    Function incomeTax(asSalary As Single) As Single
        Dim IT As Single
        If asSalary <= 250000 Then
            IT = 0
        ElseIf asSalary <= 400000 Then
            IT = (0.20F * (asSalary - 250000))
        ElseIf asSalary <= 800000 Then
            IT = (30000 + 0.25F * (asSalary - 400000))
        ElseIf asSalary <= 2000000 Then
            IT = (130000 + 0.30F * (asSalary - 800000))
        ElseIf asSalary <= 8000000 Then
            IT = (490000 + 0.32F * (asSalary - 2000000))
        Else
            IT = (2410000 + 0.35F * (asSalary - 8000000))
        End If
        Return IT / 12 ' Return monthly tax
    End Function

    Function SSScon(ms As Integer) As Integer
        Dim sss As Integer = 0
        Select Case ms
            Case < 2250
                sss = 80
            Case 2250 To 2749
                sss = 100
            Case 2750 To 3249
                sss = 120
            Case 3250 To 3749
                sss = 140
            Case 3750 To 4249
                sss = 160
            Case 4250 To 4749
                sss = 180
            Case 4750 To 5249
                sss = 200
            Case 5250 To 5749
                sss = 220
            Case 5750 To 6249
                sss = 240
            Case 6250 To 6749
                sss = 260
            Case 6750 To 7249
                sss = 280
            Case 7250 To 7749
                sss = 300
            Case 7750 To 8249
                sss = 320
            Case 8250 To 8749
                sss = 340
            Case 8750 To 9249
                sss = 360
            Case 9250 To 9749
                sss = 380
            Case 9750 To 10249
                sss = 400
            Case 10250 To 10749
                sss = 420
            Case 10750 To 11249
                sss = 440
            Case 11250 To 11749
                sss = 460
            Case 11750 To 12249
                sss = 480
            Case 12250 To 12749
                sss = 500
            Case 12750 To 13249
                sss = 520
            Case 13250 To 13749
                sss = 540
            Case 13750 To 14249
                sss = 560
            Case 14250 To 14749
                sss = 580
            Case 14750 To 15249
                sss = 600
            Case 15250 To 15749
                sss = 620
            Case 15750 To 16249
                sss = 640
            Case 16250 To 16749
                sss = 660
            Case 16750 To 17249
                sss = 680
            Case 17250 To 17749
                sss = 700
            Case 17750 To 18249
                sss = 720
            Case 18250 To 18749
                sss = 740
            Case 18750 To 19249
                sss = 760
            Case 19250 To 19749
                sss = 780
            Case > 19750
                sss = 800
        End Select
        Return sss
    End Function

    Function PagIbig(ms As Single) As Single
        Dim PI As Single
        If ms <= 1500 Then
            PI = 0.01F * ms
        Else
            PI = 0.02F * ms
        End If
        Return PI
    End Function

    Function Philhealth(ms As Single) As Single
        Dim PH As Single = 0
        Select Case ms
            Case < 9000
                PH = 100.0F
            Case 9000 To 9999.99
                PH = 112.5F
            Case 10000 To 10999.99
                PH = 125.0F
            Case 11000 To 11999.99
                PH = 137.5F
            Case 12000 To 12999.99
                PH = 150.0F
            Case 13000 To 13999.99
                PH = 162.5F
            Case 14000 To 14999.99
                PH = 175.0F
            Case 15000 To 15999.99
                PH = 187.5F
            Case 16000 To 16999.99
                PH = 200.0F
            Case 17000 To 17999.99
                PH = 212.5F
            Case 18000 To 18999.99
                PH = 225.0F
            Case 19000 To 19999.99
                PH = 237.5F
            Case 20000 To 20999.99
                PH = 250.0F
            Case 21000 To 21999.99
                PH = 262.5F
            Case 22000 To 22999.99
                PH = 275.0F
            Case 23000 To 23999.99
                PH = 287.5F
            Case 24000 To 24999.99
                PH = 300.0F
            Case 25000 To 25999.99
                PH = 312.5F
            Case 26000 To 26999.99
                PH = 325.0F
            Case 27000 To 27999.99
                PH = 337.5F
            Case 28000 To 28999.99
                PH = 350.0F
            Case 29000 To 29999.99
                PH = 362.5F
            Case 30000 To 30999.99
                PH = 375.0F
            Case 31000 To 31999.99
                PH = 387.5F
            Case 32000 To 32999.99
                PH = 400.0F
            Case 33000 To 33999.99
                PH = 412.5F
            Case 34000 To 34999.99
                PH = 425.0F
            Case > 35000
                PH = 437.5F
        End Select
        Return PH
    End Function
    
End Module
