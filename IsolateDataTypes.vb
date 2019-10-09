Module Module1

    Sub Main()

        Dim MainString As String = ""
        Dim Counter As Integer = 0
        Dim NextChar As String = ""
        Dim LETTERS As String = ""
        Dim NUMBERS As String = 0
        Dim SPECIALCHARACTERS As String = ""

        Console.Write("Enter String To Be Processed: ")
        MainString = Console.ReadLine

        For Counter = 1 To Len(MainString)
            NextChar = Mid(MainString, Counter, 1)
            If (NextChar >= "A" And NextChar <= "Z") Or (NextChar >= "a" And NextChar <= "z") Then
                LETTERS = LETTERS + NextChar
            ElseIf (NextChar >= "0" And NextChar <= "9") Then
                NUMBERS = NUMBERS + NextChar
            Else
                SPECIALCHARACTERS = SPECIALCHARACTERS + NextChar
            End If
        Next
    Console.WriteLine("LETTERS: " & LETTERS)
        Console.WriteLine("NUMBERS: " & NUMBERS)
        Console.WriteLine("SPECIALCHARACTERS: " & SPECIALCHARACTERS)
        Console.ReadKey()

    End Sub

End Module

