using System;
using System.Collections.Generic;

public class StringMirrorChecker
{
    public static void Main(string[] args) { }
    public static int StringMirrored(string str1, string str2)
    {
        // Testen, ob ein Eingabefeld Leer gelassen wurde
        if (str1==null || str2==null)
        {
            Console.WriteLine("Bitte für alle Argumente Werte eingeben");
            return -1; 
        }

        // Länge der Strings abgleichen
        if (str1.Length != str2.Length)
        {
            Console.WriteLine("Die Strings haben unterschiedliche Längen und können daher nicht gespiegelt sein.");
            return -1; 
        }

        Stack<char> stack = new Stack<char>();

        // Alle Zeichen des ersten Strings auf den Stack pushen
        foreach (char c in str1)
        {
            stack.Push(c);
        }

        // Vergleiche die Zeichen des zweiten Strings mit dem Stack
        for (int i = 0; i < str2.Length; i++)
        {
            if (str2[i] != stack.Pop())
            {
                Console.WriteLine("Die Strings sind nicht gespiegelt. Unterschied bei Position: " + i);
                return i;
            }
        }

        return 0; 
    }
}
