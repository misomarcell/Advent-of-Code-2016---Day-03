Module Module1

    Dim input_file_name As String = "input.txt"

    Sub Main()
        Dim input_lines As New ArrayList
        input_lines = readFile()

        Dim total As Integer = 0
        For i As Integer = 0 To input_lines.Count - 1
            Dim a As Integer = input_lines(i).Substring(2, 3)
            Dim b As Integer = input_lines(i).Substring(7, 3)
            Dim c As Integer = input_lines(i).Substring(12, 3)

            If (a + b) > c And (a + c) > b And (b + c) > a Then
                total = total + 1
                Console.WriteLine(a & "; " & b & "; " & c & " VALID")
            Else
                Console.WriteLine(a & "; " & b & "; " & c)
            End If
        Next
        Console.WriteLine("> SOLUTION: " & total)


        Dim asd As String = Console.ReadLine()
    End Sub

    Function readFile()
        Dim input_lines As New ArrayList
        Dim objReader As New System.IO.StreamReader("./" & input_file_name)

        Do While objReader.Peek() <> -1
            input_lines.Add(objReader.ReadLine() & vbNewLine)
        Loop

        Return input_lines
    End Function

End Module
