Module Module1
    Sub Main()
        Console.WriteLine("Welcome to the Town Guild Membership Application")

        ' Ask for user input
        Console.WriteLine("Please enter your age:")
        Dim age As Integer = Console.ReadLine()

        Console.WriteLine("Please enter the number of years you have lived in the town:")
        Dim yearsInTown As Integer = Console.ReadLine()

        Console.WriteLine("Do both your parents still live in the town? (yes or no)")
        Dim bothParentsInTown As String = Console.ReadLine()

        Console.WriteLine("Has one of your parents died and the other still lives in the town? (yes or no)")
        Dim oneParentInTown As String = Console.ReadLine()

        Console.WriteLine("Have you and a brother or sister lived in the town for 10 years? (yes or no)")
        Dim siblingsInTown As String = Console.ReadLine()

        Console.WriteLine("Please enter the amount of money in your bank account:")
        Dim bankBalance As Double = Console.ReadLine()

        Console.WriteLine("Have you ever been to prison? (yes or no)")
        Dim beenToPrison As String = Console.ReadLine()

        Console.WriteLine("Please enter the number of guild members who support your application:")
        Dim numGuildMembers As Integer = Console.ReadLine()

        ' Check if the user meets the requirements
        If age >= 18 And age <= 65 And (yearsInTown >= 20 Or (yearsInTown >= 5 And bothParentsInTown = "yes") Or (yearsInTown >= 10 And siblingsInTown = "yes") Or (yearsInTown >= 5 And oneParentInTown = "yes")) And bankBalance >= 500000 And beenToPrison = "no" And numGuildMembers >= 2 Then
            ' Issue a unique membership number
            Dim membershipNumber As String = "TG-" + Guid.NewGuid().ToString().Substring(0, 6)
            Console.WriteLine("Congratulations! You have been accepted as a member of the Town Guild.")
            Console.WriteLine("Your membership number is: " + membershipNumber)
        Else
            ' Explain reasons for failure
            Console.WriteLine("We're sorry, you do not meet the requirements for membership in the Town Guild.")
            Console.WriteLine("Reasons for failure: ")
            If age < 18 Or age > 65 Then Console.WriteLine("- Age requirement not met.")
            If yearsInTown < 20 And (yearsInTown < 5 Or bothParentsInTown = "no") And (yearsInTown < 10 Or siblingsInTown = "no") And (yearsInTown < 5 Or oneParentInTown = "no") Then Console.WriteLine("- Years in town requirement not met.")
            If bankBalance < 500000 Then Console.WriteLine("- Bank balance requirement not met.")
            If beenToPrison = "yes" Then Console.WriteLine("- Prison record disqualifies applicant.")
            If numGuildMembers < 2 Then Console.WriteLine("- Insufficient number of guild members to support application.")
        End If

        Console.WriteLine("Thank you for your interest in the Town Guild.")
        Console.ReadLine()
    End Sub
End Module
