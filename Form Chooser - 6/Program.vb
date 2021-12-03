'
' Created by SharpDevelop.
' User: 19ofoster
' Date: 11/10/2021
' Time: 10:20
' 
' To change this template use Tools | Options | Coding | Edit Standard Headers.
'
Module Program
	Sub Main()
		'define some variables
		Dim name As String = ""
		Dim form As String = ""
		Dim room As Int16 = 0
		
		'Asks the user for their name and form
		
		Console.WriteLine("Please enter your name . . . ")
		name = Console.ReadLine()
		Console.WriteLine("Please enter your form . . . ")
		form = Console.ReadLine()
		
		'processes the data
		If form = ("9K") Or form = ("9k") Then
			room = 37
		End If
		If form = ("9E") Or form = ("9e") Then 
			room = 5
		End If
		If form = ("9S") Or form = ("9s") Then
			room = 51
		End If
		
		'answers te user
		Console.WriteLine("Hello " & name & ", please go to room " & room)

		Console.Write("Press any key to continue . . . ")
		Console.ReadKey(True)
	End Sub
End Module
