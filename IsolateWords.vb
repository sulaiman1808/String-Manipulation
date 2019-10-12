Module Module1

    Sub Main()
        Dim MainString As String = ""
        Dim Counter As Integer = 0
        Dim NextChar As Char = ""
        Dim FinalString As String = ""

        Console.Write("Enter String To Isolate Words: ")
        MainString = Console.ReadLine

        For Counter = 1 To Len(MainString)
            NextChar = Mid(MainString, Counter, 1)
            If NextChar <> " " Then
                FinalString = FinalString + NextChar
            ElseIf Counter = Len(MainString) Or NextChar = " " Then
                Console.WriteLine(FinalString)
                FinalString = ""
            End If

        Next
        Console.WriteLine(FinalString)
        Console.ReadKey()




    End Sub

End Module
