//Get user's name
Console.Write("Hi, what's your name? ");
string name = Console.ReadLine();
bool keepLooping = true;
while (keepLooping)
{
 //Get integer between 1-100
 Console.Write("\n" + name + ", enter a whole number between 1 and 100 (excluding the number 1 and 100). "); //exclude 1 and 100
 int num = int.Parse(Console.ReadLine());

 //validate number is a postive integer betweeen 1 and 100 and provide output.     
 if (num < 2 || num >= 100) { Console.WriteLine("\n" + name + ", you entered an invalid option.");}
 else if (num % 2 != 0 && num < 60) { Console.WriteLine("\n" + num + " is odd and less than 60."); }
 else if (num % 2 == 0 && num >= 2 && num <= 24) { Console.WriteLine("\n" + name + ", " + num + " is even and less than 25."); }
 else if (num % 2 == 0 && num >= 26 && num <= 60) { Console.WriteLine("\n" + name + ", " + num + " is even and between 26 and 60 inclusive."); }
 else if (num % 2 == 0 && num > 60) { Console.WriteLine("\n" + name + ", " + num + " is even and greater than 60."); }
 else if (num % 2 != 0 && num > 60) { Console.WriteLine("\n" + name + ", " + num + " is odd and greater than 60."); }

 //Give user option to leave/continue
 Console.WriteLine("\n" + name + ", would you like to start over? Y/N");
 string answer = Console.ReadLine();
 if (answer == "Y" || answer == "y") { keepLooping = true; continue; }
 if (answer == "N" || answer == "n") { keepLooping = false; Console.WriteLine("\n" + "Goodbye, " + name); break; }

    }


/* Excercise
What will the application do? 
1 Point: The application prompts the user to enter an integer between 1 and 100.
1.  1 Point: Use if/else statements to take different actions depending on user input.  
2.	Given an integer entered by a user, perform the following conditional actions:
.	1 Point: If the integer entered is odd and less than 60, print the number entered and “Odd and less than 60.”
a.	1 Point: If the integer entered is even and in the inclusive range of 2 to 24, print “Even and less than 25.”
b.	1 Point: If the integer entered is even and in the inclusive range of 26 to 60, print “Even and between 26 and 60 inclusive.”
c.	1 Point: If the integer entered is even and greater than 60, print the number entered and “Even and greater than 60.”
1 Point: If the integer entered is odd and greater than 60, print the number entered and “Odd and greater than 60.”

Additional Requirements:
1 Point: For answering the Lab Summary when submitting to the LMS
-2 Points: if there are any syntax errors or if the program does not run (for example, in a Main method). 

Hints:
Remember what “inclusive” and “exclusive” mean when referring to ranges of numbers. The range of numbers from 1 inclusive to 10 exclusive means the numbers 1, 2, 3, 4, 5, 6, 7, 8, 9 (but not 10; it’s excluded).

Extra Challenges(2 Points Maximum):
1 Point: Set up the program to continue running with a prompt at the end to see if they want to stop. (hint: Loops)
1 Point: Ask for user information (ex.name) at the beginning of the application, and use it to refer to the user throughout the application.
1 Point: Add validation to guarantee that a user enters a positive integer between 1 and 100.*/
