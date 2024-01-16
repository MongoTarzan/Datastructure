using System;
using System.Collections.Generic;

public class PalindromStack
{
    static void Main()
    {
     
    }
    public static bool IsPalindrom(string str)
    {
        // Um Leerzeichen und Groß-/Kleinschreibung zu ignorieren, kann man den String vorher normalisieren
        str = str.Replace(" ", "").ToLower();

        Stack<char> charStack = new Stack<char>();

        for (int i = 0; i < str.Length; i++)
        {
            charStack.Push(str[i]);
        }
        for (int i = 0; i < str.Length; i++)
        {
            if (charStack.Pop() != str[i])
            {
                return false;
            }
        }
        return true;
    }
}
