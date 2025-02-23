Module Roll_Of_The_Dice

    Sub Main()

    End Sub

    Function diceTracker(dieRoll As Integer, die As Integer) As Boolean(,)
        Static _diceTracker(14, 4) As Boolean
        'actual code here
        Return _diceTracker

    End Function

    Sub randoDice()
        Dim temp As String = "X |"
        Dim heading() As String = {"Roll of the dice"}
        For Each letter In heading
            Console.Write(letter.PadLeft(2).PadRight(4))
        Next
        Console.WriteLine()
        Console.WriteLine(StrDup(20, "_"))
        For i = 1 To 15
            For j = 1 To 5
                temp = temp.PadLeft(4)
                Console.Write(temp)
            Next
            Console.WriteLine()
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
