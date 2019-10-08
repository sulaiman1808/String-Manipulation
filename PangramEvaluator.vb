Module Module1

    Sub Main()

        Dim MainString As String = ""
        Dim NextChar As Char = ""
        Dim Counter As Integer = 0
        Dim AllAlphabetsString As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim IsItPangram As Boolean = False

        Console.Write("Enter A Sentence To Check Whether It Is A Pangram Or Not: ")
        MainString = Console.ReadLine

        For Counter = 1 To Len(AllAlphabetsString)
            NextChar = UCase(Mid(AllAlphabetsString, Counter, 1))
            If InStr(MainString, NextChar) > 0 Then
                IsItPangram = True
            ElseIf Len(MainString) < 26 Then
                IsItPangram = False
            End If

        Next
        If IsItPangram = True Then
            Console.WriteLine("YES! THE SENTENCE IS A PANGRAM!")
            Console.ReadKey()
        Else
            Console.WriteLine("NO! THE SENTENCE AIN'T A PANGRAM!")
            Console.ReadKey()
        End If

    End Sub

End Module
