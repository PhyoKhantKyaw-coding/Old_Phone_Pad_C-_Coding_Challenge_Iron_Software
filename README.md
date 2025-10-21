Old Phone Pad
Console application
Input String of numbers '0'-'9', space ' ', backspace '*', ends with '#'.
Output Converted text string based on keypad mapping.



Folder
MockData --> KeypadData.cs
Service  --> OldPhonePadService.cs
Test     --> NUnitTest.cs
		 --> xUnitTest.cs
Program.cs



Install Package for testing
dotnet add package xunit 
dotnet add package xunit.runner.visualstudio
dotnet add package NUnit
dotnet add package NUnit3TestAdapter
dotnet add package Microsoft.NET.Test.Sdk


MockData 
KeypadData -->IEnumerable<TestCaseData> PhonePadCasesNUnit
	   -->IEnumerable<object[]> PhonePadCasesXunit
	   -->Dictionary<string, char> KeyPadMapping 


Service
OldPhonePadService -->OldPhonePad(string input)
		   -->Main()


OldPhonePad method flow

keypad → load mock keypad dictionary.

inputs → char array of input string.

same number → char list storing repeated key presses.

final Output → char list storing final converted letters.

1. change input string to char inputs array to check the each element

2. input validation return "Invalid input" if empty or  "not #".

3. Loop each character c in inputs with for each loop

4. check the condition
if (c = # )
	process remaining same number, append to final Output, return result.
else if(c <= '9' && c >= '0' || c == ' ' || c == '*')
	check these conditions 
	1.same number of count equal 0 or same as previous, add to same number
	2.if different and not '*' and not ' ', process previous sequence, clear, add new.
	3.if * clean the same number
	4.if ' ' space process same number, append to final Output, clear same number
else
return "Invalid input"

Notes:
same number handles repeated key presses.

* works as backspace.

Space ' ' allows separating letters from same key.

# signals end of input.

Main Method flow
1. Title
2. Message for how to stop program to enter space of exit.
3. While loop for stop program with condition of step 2 with using keyword break
4. Request message to OldPhonePad for User input
5. Show Output to User


Test Case
NUnitTest
1.[TestFixture] --> to mark a class that have unit tests in Nunit.
2.[TestCaseSource]--> provide multiple test cases from an external source (array, list, method, or class) with typeof(testdata) and nameof (method returns test cases) 
xUnitTest
1.[Theory] --> Marks a parameterized test in xUnit
2.[MemberData] -->Provides external test data for a [Theory] with name of nameof (method returns test cases) and MemberType (the class containing the member)


can test with dotnet test
program.cs have call main method.





