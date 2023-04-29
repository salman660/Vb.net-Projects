Module Module1

    Sub Main()
        Dim ClassSize As Integer
        Dim SubjectNo As Integer


        Console.WriteLine("< Welcome to class grading program! >")
        Console.WriteLine()
        Console.Write("Enter class size: ")
        ClassSize = Console.ReadLine()

        Console.Write("Enter number of subjects: ")
        SubjectNo = Console.ReadLine()

        Dim SubjectNames(SubjectNo) As String
        Dim Counter As Integer
        Dim ColumnCounter As Integer
        Dim TotalMarks(ClassSize) As Integer
        Dim AverageMarks(ClassSize) As Decimal
        Dim StudentName(ClassSize) As String
        Dim StudentMark(ClassSize, SubjectNo) As Integer
        Dim NumDistinctions, NumMerit, NumPass, NumFail As Integer
        Dim TotalMarksSubject As Integer

        TotalMarksSubject = SubjectNo * 100

        For Counter = 1 To SubjectNo
            Console.Write("Enter name of subject " & Counter & ": ")
            SubjectNames(Counter) = Console.ReadLine()
        Next
        For Counter = 1 To ClassSize
            Console.Write("Enter name of student number " & Counter & ": ")
            StudentName(Counter) = Console.ReadLine()
            For ColumnCounter = 1 To SubjectNo
                Console.Write("Enter marks of " & StudentName(Counter) & ", for " & SubjectNames(ColumnCounter) & ": ")
                StudentMark(Counter, ColumnCounter) = Console.ReadLine()
            Next
        Next

        For Counter = 1 To ClassSize
            TotalMarks(Counter) = 0
        Next

        For Counter = 1 To ClassSize
            For ColumnCounter = 1 To SubjectNo
                TotalMarks(Counter) = StudentMark(Counter, ColumnCounter) + TotalMarks(Counter)
            Next
        Next


        Console.WriteLine()
        Console.WriteLine("<Result>")

        For Counter = 1 To ClassSize
            AverageMarks(Counter) = (TotalMarks(Counter) / TotalMarksSubject) * 100
            If AverageMarks(Counter) >= 70 Then
                Console.WriteLine("Name: " & StudentName(Counter))
                Console.WriteLine("Total marks: " & TotalMarks(Counter))
                Console.WriteLine("Average Marks: " & AverageMarks(Counter))
                Console.WriteLine("Grade: Distinction")
                NumDistinctions = NumDistinctions + 1
            End If
            Console.WriteLine()
            If AverageMarks(Counter) >= 55 And AverageMarks(Counter) < 70 Then
                Console.WriteLine("Name: " & StudentName(Counter))
                Console.WriteLine("Total marks: " & TotalMarks(Counter))
                Console.WriteLine("Average Marks: " & AverageMarks(Counter))
                Console.WriteLine(("Grade: Merit"))
                NumMerit = NumMerit + 1
            End If
            Console.WriteLine()
            If AverageMarks(Counter) >= 40 And AverageMarks(Counter) <= 55 Then
                Console.WriteLine("Name: " & StudentName(Counter))
                Console.WriteLine("Total marks: " & TotalMarks(Counter))
                Console.WriteLine("Average Marks: " & AverageMarks(Counter))
                Console.WriteLine(("Grade: Pass"))
                NumPass = NumPass + 1
            End If
            If AverageMarks(Counter) <= 40 Then
                Console.WriteLine("Name: " & StudentName(Counter))
                Console.WriteLine("Total marks: " & TotalMarks(Counter))
                Console.WriteLine("Average Marks: " & AverageMarks(Counter))
                Console.WriteLine(("Grade: Fail"))
                NumFail = NumFail + 1
            End If
        Next


        Console.WriteLine()
        Console.WriteLine("< Class Stats >")
        Console.WriteLine("Number of Distincions in the class: " & NumDistinctions)
        Console.WriteLine("Number of with the grade merits in the class: " & NumMerit)
        Console.WriteLine("Number of students who passed in the class: " & NumPass)
        Console.WriteLine("Number of students who failed in class: " & NumFail)

        Console.ReadKey()

    End Sub

End Module
