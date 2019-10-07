Module Module1

    Sub Main()
        Dim MainString As String = ""
        Dim Counter As Integer = "0"
        Dim IsItPangram As Boolean = False
        Dim NextChar As Char = ""
        Dim NoOfA As Integer = "0"
        Dim NoOfB As Integer = "0"
        Dim NoOfC As Integer = "0"
        Dim NoOfD As Integer = "0"
        Dim NoOfE As Integer = "0"
        Dim NoOfF As Integer = "0"
        Dim NoOfG As Integer = "0"
        Dim NoOfH As Integer = "0"
        Dim NoOfI As Integer = "0"
        Dim NoOfJ As Integer = "0"
        Dim NoOfK As Integer = "0"
        Dim NoOfL As Integer = "0"
        Dim NoOfM As Integer = "0"
        Dim NoOfN As Integer = "0"
        Dim NoOfO As Integer = "0"
        Dim NoOfP As Integer = "0"
        Dim NoOfQ As Integer = "0"
        Dim NoOfR As Integer = "0"
        Dim NoOfS As Integer = "0"
        Dim NoOfT As Integer = "0"
        Dim NoOfU As Integer = "0"
        Dim NoOfV As Integer = "0"
        Dim NoOfW As Integer = "0"
        Dim NoOfX As Integer = "0"
        Dim NoOfY As Integer = "0"
        Dim NoOfZ As Integer = "0"


        Console.Write("Enter Sentence To Be Checked: ")
        MainString = Console.ReadLine


        For Counter = 1 To Len(MainString)
            NextChar = UCase(Mid(MainString, Counter, 1))

            If NextChar = "A" Then
                NoOfA = NoOfA + 1
            End If

            If NextChar = "B" Then
                NoOfB = NoOfB + 1
            End If

            If NextChar = "C" Then
                NoOfC = NoOfC + 1
            End If

            If NextChar = "D" Then
                NoOfD = NoOfD + 1
            End If

            If NextChar = "E" Then
                NoOfE = NoOfE + 1
            End If

            If NextChar = "F" Then
                NoOfF = NoOfF + 1
            End If

            If NextChar = "G" Then
                NoOfG = NoOfG + 1
            End If

            If NextChar = "H" Then
                NoOfH = NoOfH + 1
            End If

            If NextChar = "I" Then
                NoOfI = NoOfI + 1
            End If

            If NextChar = "J" Then
                NoOfJ = NoOfJ + 1
            End If

            If NextChar = "K" Then
                NoOfK = NoOfK + 1
            End If

            If NextChar = "L" Then
                NoOfL = NoOfL + 1
            End If

            If NextChar = "M" Then
                NoOfM = NoOfM + 1
            End If

            If NextChar = "N" Then
                NoOfN = NoOfN + 1
            End If

            If NextChar = "O" Then
                NoOfO = NoOfO + 1
            End If

            If NextChar = "P" Then
                NoOfP = NoOfP + 1
            End If

            If NextChar = "Q" Then
                NoOfQ = NoOfQ + 1
            End If

            If NextChar = "R" Then
                NoOfR = NoOfR + 1
            End If

            If NextChar = "S" Then
                NoOfS = NoOfS + 1
            End If

            If NextChar = "T" Then
                NoOfT = NoOfT + 1
            End If

            If NextChar = "U" Then
                NoOfU = NoOfU + 1
            End If

            If NextChar = "V" Then
                NoOfV = NoOfV + 1
            End If

            If NextChar = "W" Then
                NoOfW = NoOfW + 1
            End If

            If NextChar = "X" Then
                NoOfX = NoOfX + 1
            End If

            If NextChar = "Y" Then
                NoOfY = NoOfY + 1
            End If

            If NextChar = "Z" Then
                NoOfZ = NoOfZ + 1
            End If

        Next

        If NoOfA >= 1 And
           NoOfB >= 1 And
           NoOfC >= 1 And
           NoOfD >= 1 And
           NoOfE >= 1 And
           NoOfF >= 1 And
           NoOfG >= 1 And
           NoOfH >= 1 And
           NoOfI >= 1 And
           NoOfJ >= 1 And
           NoOfK >= 1 And
           NoOfL >= 1 And
           NoOfM >= 1 And
           NoOfN >= 1 And
           NoOfO >= 1 And
           NoOfP >= 1 And
           NoOfQ >= 1 And
           NoOfR >= 1 And
           NoOfS >= 1 And
           NoOfT >= 1 And
           NoOfU >= 1 And
           NoOfV >= 1 And
           NoOfW >= 1 And
           NoOfX >= 1 And
           NoOfY >= 1 And
           NoOfZ >= 1 Then

            IsItPangram = True

        End If

        If IsItPangram = True Then
            Console.WriteLine("YES! THE SENTENCE IS A PANGRAM!")
            Console.ReadKey()
        Else : Console.WriteLine("NO! THE SENTENCE AIN'T A PANGRAM!")
            Console.ReadKey()


        End If





    End Sub

End Module
