// See https://aka.ms/new-console-template for more information
// using System.Globalization;
// Console.WriteLine("What is your name?");
// var str = Console.ReadLine();

// TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
// str = textInfo.ToTitleCase(str); 
// Console.WriteLine(" " + str); //Hello there, Tim Jamesdotnet run

/* this commented section could also carry out the job but doesnt take into 
account capitalized letters in the mnames per se. it however corrects the first names*/


Console.WriteLine("What is your name?"); //Asks user name
var input = Console.ReadLine();                 //takes input
var output = "";                    //declared output 
var thisChar = ' ';                     // char is a built-in value type that represents one character in a string
var shouldCapitalize = true;

for (int i = 0; i < input!.Length; i++) //! used here to avoid the null warning during compiling
{
    thisChar = input[i];

    if (char.IsWhiteSpace(thisChar))    //This method is used to check whether a specified Unicode character can be categorized as a whitespace character or not. If it can be categorized as whitespace then it returns True otherwise return False.
    {
        shouldCapitalize = true;
    }
    else
    {
        if (shouldCapitalize)
        {
            thisChar = char.ToUpper(thisChar);
            shouldCapitalize = false;
        }
        else
        {
            thisChar = char.ToLower(thisChar);
        }
    }

    output += thisChar;
}

Console.WriteLine("" + output);

    


