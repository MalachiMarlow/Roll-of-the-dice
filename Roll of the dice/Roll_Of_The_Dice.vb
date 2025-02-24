'Malachi Marlow
'Spring 2025
'RCET2265
'Roll the Dice 
'https://github.com/MalachiMarlow/Roll-of-the-dice.git
Module Roll_Of_The_Dice

    Sub Main()
        Console.WriteLine("Roll the dice".PadLeft(30))
        Console.Write(StrDup(50, "_"))
        Console.WriteLine()
        Console.WriteLine("2 | 3 | 4 | 5 | 6 | 7 | 8 | 9 | 10 | 11 | 12 |")

        randoDice()
    End Sub

    Sub randoDice()
        For i = 0 To 11
            Console.Write()
        Next
    End Sub

    Function randomNumberBetween(max As Integer, min As Integer) As Integer
        Dim temp As Single
        Randomize()
        temp = Rnd()
        'establish range
        temp *= (max + 1) - min 'makes range bigger by 1 to fix inclusivity max/min
        temp += min - 1 'shifts range down so math.ceiling works
        'Return CInt(temp) 'bad randomness
        'Return CInt(Int(temp)) 'randomness ok but max is not included
        Return CInt(Math.Floor(temp)) 'randomness ok but max is not included
        'Return CInt(Math.Ceiling(temp)) 'randomness ok but min is not included
    End Function

End Module
