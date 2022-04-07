// See https://aka.ms/new-console-template for more information


namespace ConsoleApp
{
        class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            
            var input = Console.ReadLine();
            
            // if input is empty, print the error
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Empty Name, Rerun Program!");
            }
            else //do everything else if the input is not empty 
            {

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
            }
        }

        
    }
}


    


