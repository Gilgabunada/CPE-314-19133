Imports System
Imports System.Globalization

' ' ' ' Stud Assesment ' ' ' ' 

Module Program

    Public TotalFee As Double
    Public unit As Integer
    Public types As Integer
    Public value As Double 

    Sub Main(args As String())

        Dim id As Integer 
        Dim address, name, course As String
        Dim year_level As Byte
        Dim ans As String

        Do 
            Console.Clear() ' Clear the console for each new entry
            Console.Write("ID: ")
            id = Convert.ToInt32(Console.ReadLine())

            Console.Write("Name: ")
            name = Console.ReadLine()

            Console.Write("Address: ")
            address = Console.ReadLine()

            Console.Write("Course: ")
            course = Console.ReadLine()

            Console.Write("Year Level: ")
            year_level = Convert.ToByte(Console.ReadLine())

            Console.Write("Unit No.: ")
            unit = Convert.ToInt32(Console.ReadLine())

            value = Scholarship() 
            Console.WriteLine("Tuition Fee: {0}", Computation(unit, value))

            Console.Write(vbNewLine & "Do you want to enter another record? [Y/N]: ")
            ans = Console.ReadLine()

        Loop While ans.Equals("Y", StringComparison.OrdinalIgnoreCase)

        Console.Clear()
        Console.WriteLine(vbNewLine & vbTab & "THANK YOU")

    End Sub
    
    Function Scholarship() As Double
        Console.WriteLine(vbNewLine & vbTab & "Type of Scholarship")
        Console.WriteLine(vbTab & "Press [1] Academic")
        Console.WriteLine(vbTab & "Press [2] Athletic")
        Console.WriteLine(vbTab & "Press [3] Sugbo")
        Console.WriteLine(vbTab & "Press [4] Working")
        Console.WriteLine(vbTab & "Press [5] Presidential")
        Console.WriteLine(vbTab & "Press [6] No Scholarship")
        Console.Write(vbTab & "Type: ")

        types = Convert.ToInt32(Console.ReadLine())
        
        Select Case types
            Case 1
                Console.WriteLine(vbNewLine &"Scholarship: Academic")
                Return 0.60
            Case 2
                Console.WriteLine(vbNewLine &"Scholarship: Athletic")
                Return 0.50
            Case 3
                Console.WriteLine(vbNewLine &"Scholarship: Sugbo")
                Return 0.30
            Case 4
                Console.WriteLine(vbNewLine &"Scholarship: Working")
                Return 0.80
            Case 5
                Console.WriteLine(vbNewLine &"Scholarship: Presidential")
                Return 0.90
            Case 6
                Console.WriteLine(vbNewLine &"No Scholarship")
                Return 1.0
            Case Else
                Console.WriteLine(vbNewLine &"Invalid Scholarship Type")
                Return 1.0 
        End Select
    End Function
    
    Function Computation(ByVal unit As Integer, ByVal value As Double) As Double
        Dim TuitionFee As Double
        Dim perUnit As Double = 800.0 ' Assuming this is a constant fee per unit

        TuitionFee = perUnit * unit
        TuitionFee *= value
        
        Return TuitionFee
    End Function
    
End Module
