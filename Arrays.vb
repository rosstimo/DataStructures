Option Explicit On
Option Strict On

Module Arrays

    Sub Main()
        'ArrayExample()
        'ArrayMultiDimesional()
        ArrayItteration()
        Console.Read()
    End Sub

    Sub ArrayExample()
        Dim names(5) As String

        names(3) = "Bob"
        names(1) = "Mary"
        names(5) = "Jimmy"

        Console.WriteLine(names(2))
    End Sub

    Sub ArrayMultiDimesional()
        Dim people(5, 1) As String

        people(0, 0) = "Billy"
        people(0, 1) = "Jean"

        people(1, 0) = "Emily"
        people(1, 1) = "Harris"

        Console.WriteLine(people(0, 0) & " " & people(0, 1))
    End Sub

    Sub ArrayItteration()
        Dim people(5, 1) As String
        Dim firstName As Integer = 0
        Dim lastName As Integer = 1

        people(0, firstName) = "Billy"
        people(0, lastName) = "Jean"

        people(1, firstName) = "Emily"
        people(1, lastName) = "Harris"

        people(3, firstName) = "Jimmy"
        people(3, lastName) = "Walker"

        For row = 0 To 5
            'Console.WriteLine(people(row, firstName) & " " & people(row, lastName))
        Next

        'Or try this

        For i = LBound(people) To UBound(people)

            Console.WriteLine($"{people(i, 0)} {people(i, 1)}")

        Next

        'addressing element outside of array crashes program
        'Console.WriteLine(people(0, 6))


    End Sub


End Module
