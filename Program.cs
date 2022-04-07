// See https://aka.ms/new-console-template for more information
// using System.Globalization;
// Console.WriteLine("What is your name?");
// var str = Console.ReadLine();

// TextInfo textInfo = new CultureInfo("en-US", false).TextInfo;
// str = textInfo.ToTitleCase(str); 
// Console.WriteLine(" " + str); //Hello there, Tim Jamesdotnet run

/* this commented section could also carry out the job but doesnt take into 
account capitalized letters in the names per se. it however corrects the first letter of  names*/

//Below is another example, here The idea is to only capitalize characters that are preceded by whitespace. pretty simple way but fun to tinker with


Console.WriteLine("What is your name?"); //Asks user name
var input = Console.ReadLine();                 //takes input
var output = "";                    //declared output 
var thisChar = ' ';                     // char is a built-in value type that represents one character in a string
var shouldCapitalize = true;

 bool IsMcName(string output, int index, char currentChar) => index > 0 && // for names like Mc 
        char.ToLower(currentChar) == 'c' &&
        output[index - 1] == 'M';



for (int i = 0; i < input!.Length; i++) //! used here to avoid the null warning during compiling, executes a block of statement
{       
    thisChar = input[i];

    if (char.IsWhiteSpace(thisChar) || !char.IsLetter(thisChar))  //This method checks whitespace 
    //and sees if its characters are not letters eg -,' so can apply to Irish names like O'brien = O'Brien 
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
    if (IsMcName(output, i, thisChar))
    {
        shouldCapitalize = true;
    }

    thisChar = char.ToLower(thisChar);
}
    
    }
    
 
    

    output += thisChar;
}




Console.WriteLine("" + output); //output of the sorted name goes here 

    


