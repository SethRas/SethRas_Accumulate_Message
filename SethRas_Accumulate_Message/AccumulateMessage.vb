'Seth Rasmussen
'RCET 0265
'Spring 2022
'AccumulateMessage function and test
'https://github.com/SethRas/SethRas_Accumulate_Message.git

Option Explicit On
Option Strict On
Option Compare Text



Module AccumulateMessage

    Sub Main()
        Dim menu As String
        Dim message As String
        Dim clear As Boolean = False
        Dim quit As Boolean
        Dim memory As String

        menu = "C: Clear" & vbNewLine & "M: Show saved Messages" & vbNewLine & "Q: Quit"

        Console.WriteLine("Enter a Message you wish to save for later")
        Console.WriteLine(menu)
        Console.ReadLine()


        'Write a test to show the function of the function
        'Clear quit show messages
        'Run in a while loop till you want to quit
        Do While quit = False
            Console.WriteLine("Please enter a message")
            message = Console.ReadLine()
            If message = "^Show" Then
                Console.WriteLine(UserMessages(message, clear, memory)) 'Don't remove memory. code doesn't work
            ElseIf message = "c" Then
                Console.WriteLine("Messages deleted")
                memory = UserMessages(message, clear, memory)
                quit = False
            ElseIf message = "Q" Then
                quit = True
            Else
                UserMessages(message, clear, memory)
                memory = UserMessages(message, clear, memory)
            End If
        Loop
    End Sub


    'Develop a function that will store the values you put into it 
    'These will be displayed upon request
    Function UserMessages(ByVal message As String, ByVal clear As Boolean, ByVal memory As String) As String

        Dim functionmemory As String = message + vbNewLine + memory
        If message = "C" Then
            functionmemory = ""
        ElseIf message = "^show" Then
            functionmemory = memory
        End If
        Return functionmemory
    End Function
End Module
