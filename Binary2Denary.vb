Module Module1

    Sub Main()
        Dim BinaryNumber As String = ""
        Dim NextChar As Char = ""
        Dim Counter As Integer = 0
        Dim ValidBinaryString As Boolean = False
        Dim DenaryOutput As Integer = 0
        Dim WorthValue As Integer = 0
        Dim SingleDenaryDigit As Integer = 0



        Console.Write("ENTER BINARY NUMBER: ")
        BinaryNumber = Console.ReadLine()

        If Len(BinaryNumber) >= 1 And Len(BinaryNumber) <= 8 Then
            For Counter = 1 To Len(BinaryNumber)
                NextChar = Mid(BinaryNumber, Counter, 1)
                If NextChar = "1" Or NextChar = "0" Then
                    ValidBinaryString = True
                Else
                    ValidBinaryString = False
                End If
            Next

        If ValidBinaryString = False Then
            Console.WriteLine("INVALID BINARY NUMBER!")
        End If

        If ValidBinaryString = True Then
            For Counter = Len(BinaryNumber) To 1 Step -1
                SingleDenaryDigit = Mid(BinaryNumber, Counter, 1)
                DenaryOutput = DenaryOutput + SingleDenaryDigit * (2 ^ (Len(BinaryNumber) - Counter))
            Next
                Console.WriteLine(BinaryNumber & "=" & DenaryOutput)
            End If

        Console.ReadKey()

    End Sub

End Module
