'Malachi Marlow
'Spring 2025
'RCET2265
'Roll the Dice 
'https://github.com/MalachiMarlow/Roll-of-the-dice.git
Module Roll_Of_The_Dice

    Sub Main()
        Dim diceRolls(12) As Integer

        Console.WriteLine("Roll the dice".PadLeft(30))
        Console.Write(StrDup(68, "_"))
        Console.WriteLine()
        Console.WriteLine("  2 |   3 |   4 |   5 |   6 |   7 |   8 |   9 |   10 |   11 |   12 |")

        For i = 1 To 1000
            diceRolls(randomNumberBetween(1, 12)) += 1
        Next
        Console.Write(StrDup(68, "_"))
        Console.WriteLine()

        For i = 2 To UBound(diceRolls)
            Console.Write($"{CStr(diceRolls(i)),4} |")
        Next
    End Sub

    Function randomNumberBetween(max As Integer, min As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        temp *= max - min
        temp += min
        Return CInt(temp)
    End Function

End Module
