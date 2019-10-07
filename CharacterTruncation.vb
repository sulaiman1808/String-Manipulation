Module Module1

    Sub Main()
        Dim MainString As String = ""
        Dim FinalString As String = ""
        Dim CharacterToBeRemoved As Char = ""
        Dim NextChar As Char = ""
        Dim Counter As Integer = 0

        Console.Write("Enter String To Be Processed: ")
        MainString = Console.ReadLine

        Console.Write("Enter Character To Be Truncated: ")
        CharacterToBeRemoved = Console.ReadLine

        For Counter = 1 To Len(MainString)
            NextChar = Mid(MainString, Counter, 1)
            If NextChar <> CharacterToBeRemoved Then
                FinalString = FinalString & NextChar
            End If
        Next

        Console.WriteLine("After Truncation Of" & " " & CharacterToBeRemoved & " " & "The Final String Is " & FinalString)
        Console.ReadKey()

    End Sub

End Module
