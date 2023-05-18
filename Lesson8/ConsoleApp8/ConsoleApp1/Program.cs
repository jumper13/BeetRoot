// See https://aka.ms/new-console-template for more information
using System.Collections.Immutable;
using System.Reflection.Metadata.Ecma335;

Console.WriteLine("Hello, World!");




string a = Console.ReadLine();

//Console.WriteLine( a );

//string s = "BBBB+FFFF";
//bool b = s.Equals("+");
//Console.WriteLine(s);
//Console.WriteLine(b);






// Compare that will return true if 2 strings are equal, otherwise false, but do not use build-in method

string str10 = Console.ReadLine();
string str20 = Console.ReadLine();


bool Compare(string str1, string str2)
{

    char[] char1 = str1.ToCharArray();
    char[] char2 = str2.ToCharArray();
    if (char1.Length == char2.Length)
    {
        for (int i = 0; i < char1.Length - 1; i++)
        {
            bool isEqual = (char1[i] == char2[i]);
            if (!isEqual)
            {
                return false;
            }
        }
        return true;
    }
    return false;
}


bool result = Compare(str10, str20);

Console.WriteLine("The result of comparing the strings is: {0}", result);








// Analyze that will return number of alphabetic chars in string, digits and another special characters

string str30 = Console.ReadLine();


void ChAnalyz(string str3)
{

    int alphabeticCount = 0;
    int digitCount = 0;
    int specialCharCount = 0;

    foreach (char c in str3)
    {
        if (char.IsLetter(c))
        {
            alphabeticCount++;
        }
        else if (char.IsDigit(c))
        {
            digitCount++;
        }
        else
        {
            specialCharCount++;
        }
    }

    Console.WriteLine("Alphabetic characters: " + alphabeticCount);
    Console.WriteLine("Digits: " + digitCount);
    Console.WriteLine("Special characters: " + specialCharCount);

}


ChAnalyz(str30);


// Sort that will return string that contains all characters from input string sorted in alphabetical order (e.g. 'Hello' -> 'ehllo')

string str4 = Console.ReadLine();

void sortstring(string str4) {

    string sortedString = string.Concat(str4.OrderBy(c => c));
    Console.WriteLine(sortedString);

}


sortstring(str4);






