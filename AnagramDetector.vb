Module Module1

    Sub Main()
        Dim Word1 As String = ""
        Dim Word2 As String = ""
        Dim AsciiSum1 As Integer = 0
        Dim AsciiSum2 As Integer = 0
        Dim Counter1 As Integer = 0
        Dim Counter2 As Integer = 0
        Dim Char1 As Char = ""
        Dim Char2 As Char = ""

        Console.Write("Enter First Word: ")
        Word1 = Console.ReadLine

        Console.Write("Enter Second Word: ")
        Word2 = Console.ReadLine

        For Counter1 = 1 To Len(Word1)
            Char1 = Mid(Word1, Counter1, 1)
            If (Char1 >= "A" And Char1 <= "Z") Or (Char1 >= "a" And Char1 <= "z") Then
                AsciiSum1 = AsciiSum1 + Asc(Char1)
            End If

        Next

        For Counter2 = 1 To Len(Word2)
            Char2 = Mid(Word2, Counter2, 1)
            If (Char2 >= "A" And Char2 <= "Z") Or (Char2 >= "a" And Char2 <= "z") Then
                AsciiSum2 = AsciiSum2 + Asc(Char2)
            End If

        Next
        If AsciiSum1 = AsciiSum2 Then
            Console.WriteLine("YES!" & " " & Word1 & " " & "AND" & " " & Word2 & " " & "ARE ANAGRAMS!")
        Else : Console.WriteLine("SORRY!" & " " & Word1 & " " & "AND" & " " & Word2 & " " & "ARE NOT ANAGRAMS!")
        End If
        Console.ReadKey()

    End Sub

End Module
