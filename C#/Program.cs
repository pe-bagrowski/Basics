/*The point is to check if the user(string) is:
1.The username is between 4 and 25 characters. ++ check
2.It must start with a letter. ++ check
3. It can only contain letters, numbers, and the underscore character.
4. It cannot end with an underscore character. ++ check */ 

using System;
using System.Linq;

class MainClass
{

    public static bool StringValidation(string str)
    {
        if (((str.Length) > 4 && str.Length < 25)
            && char.IsLetter(str[0])
            && (!str.EndsWith('_'))
            && str.All(c => char.IsLetterOrDigit(c) || c == '_'))
         { 
            return true;
        }
        else
        {
            return false;
        }
    }

        static void Main()
        {
            Console.WriteLine(StringValidation(Console.ReadLine()));
        }

    }