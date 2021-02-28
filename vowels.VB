Module Module1

    Sub Main()
        Dim userinput, myChar As String
        Dim Counter, vCount As Integer
        Const vowels = "Aa, Ee, Ii, Oo, Uu"


        userinput = ""
        myChar = ""
        vCount = 0
        Counter = 0
        Console.WriteLine("The purpose of this algorithm is to determine the number of vowels in an added string.")
        Console.Write("Please enter a string of characters: ")
        userinput = Console.ReadLine

        For Counter = 1 To Len(userinput)
            myChar = Mid(userinput, Counter, 1)
            If InStr(vowels, myChar) > 0 Then
                vCount = vCount + 1
            End If
        Next

        Console.WriteLine("Number of vowels in the given string = " & vCount)
        Console.ReadKey()
    End Sub

End Module
