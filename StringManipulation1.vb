Module Module1

    Sub Main()

        Dim FirstString As String
        Dim SecondString As String
        Dim Word1 As String
        Dim Word2 As String
        Dim SpacePosition As Integer


        FirstString = ""
        SecondString = ""
        Word1 = ""
        Word2 = ""
        SpacePosition = 0


        Console.Write("Enter First String To Be Processed: ")
        FirstString = Console.ReadLine


        Console.Write("Enter Second String To Be Processed: ")
        SecondString = Console.ReadLine


        SpacePosition = InStr(FirstString, " ")
        Word1 = Left(FirstString, SpacePosition - 1)


        SpacePosition = InStr(SecondString, " ")
        Word2 = Mid(SecondString, SpacePosition + 1, Len(SecondString))


        Console.Write("FinalString: " & Word1 & " " & Word2)


        Console.ReadKey()


    End Sub

End Module
