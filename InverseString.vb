Module Module1

    Sub Main()
        Dim MainString As String = ""
        Dim Counter As Integer = 0
        Dim NextChar As Char = ""
        Dim InversedString As String = ""

        Console.Write("Enter String To Inverse: ")
        MainString = Console.ReadLine

        For Counter = Len(MainString) To 1 Step -1
            NextChar = Mid(MainString, Counter, 1)
            InversedString = InversedString + NextChar
        Next

        Console.WriteLine("INVERSED STRING IS " & InversedString)
        Console.ReadKey()

    End Sub

End Module
