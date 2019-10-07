Module Module1

    Sub Main()

        Dim FullName As String = ""
        Dim MiddleName As String = ""
        Dim SpacePoint1 As Integer = 0
        Dim SpacePoint2 As Integer = 0

        Console.Write("Enter Name Composed Of Three Words: ")
        FullName = Console.ReadLine

        SpacePoint1 = InStr(FullName, " ")
        SpacePoint2 = InStr(SpacePoint1, FullName, " ")

        MiddleName = Mid(FullName, SpacePoint1 + 1, SpacePoint2 - 1)

        Console.WriteLine("Middle Name Is " & MiddleName)
        Console.ReadKey()


    End Sub

End Module
