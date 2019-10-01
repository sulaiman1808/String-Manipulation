Module Module1

    Sub Main()

        Dim String1, NextChar As String
        Dim AlphabetCount, NonAlphabetCount As Integer


        String1 = ""
        NextChar = ""
        AlphabetCount = 0
        NonAlphabetCount = 0


        Console.Write("Enter String To Be Processed:")
        String1 = Console.ReadLine


        For Count = 1 To Len(String1)
            NextChar = Mid(String1, Count, 1)

            If NextChar >= "A" And NextChar <= "z" Then
                AlphabetCount = AlphabetCount + 1


            Else
                NonAlphabetCount = Len(String1) - AlphabetCount

            End If


        Next

        Console.WriteLine("AlphabetCount= " & AlphabetCount)
        Console.WriteLine("NonAlphabetCount= " & NonAlphabetCount)
        Console.ReadKey()





    End Sub

End Module
