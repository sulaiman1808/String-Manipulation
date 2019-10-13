Module Module1

    Sub Main()
        Dim FirstString, SecondString, FirstName, LastName As String
        Dim SpacePosition As Integer


        FirstString = ""
        SecondString = ""
        SpacePosition = 0
        FirstName = ""
        LastName = ""


        Console.Write("Enter First String To Be Processed: ")
        FirstString = Console.ReadLine()

        SpacePosition = InStr(FirstString, " ")
        FirstName = Mid(FirstString, 1, SpacePosition)

        Console.Write("Enter Second String To Be Processed: ")
        SecondString = Console.ReadLine

        SpacePosition = InStr(SecondString, " ")
        LastName = Mid(SecondString, SpacePosition + 1, Len(SecondString))

        Console.WriteLine("Final String: " & FirstName & " " & LastName)
        Console.ReadKey()


    End Sub

End Module
