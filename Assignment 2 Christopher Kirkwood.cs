using System;
using System.Collections.Generic;
class Encryption
{
    static void Main(string[] args)
    {
        int choice = 0;
        do
        {
            Console.WriteLine("1: Encrypt Message");
            Console.WriteLine("2: Decrypt Message");
            Console.WriteLine("3: Quit");
            Console.WriteLine("Enter Choice: ");
            choice =  int.Parse(Console.ReadLine());
            if(choice == 1)
            {
                Console.WriteLine("Enter the plain text message: ");
                string str = Console.ReadLine();
                string encrypted = encrypt_message(str);
                Console.WriteLine("Encrypted message: " + encrypted);

            }
            else if(choice == 2)
            {
                Console.WriteLine("Enter Encypted Message: ");
                string str = Console.ReadLine();
                string decrypted = decrypt_message(str);
                Console.WriteLine("Decrypted Message: " + decrypted);
            }
        }
        while(choice != 3);
    }
 List<char> symbols = new List<char>();
 List<char> alphabets = new List<char>();
 public Encryption() {
    symbols.Add('!');
    symbols.Add('@');
    symbols.Add('#');
    symbols.Add('$');
    symbols.Add('^');
    symbols.Add('&');
    symbols.Add('*');
    symbols.Add('(');
    symbols.Add(')');
    symbols.Add('_');
    symbols.Add('-');
    symbols.Add('+');
    symbols.Add('=');
    symbols.Add('?');
    symbols.Add(',');
    symbols.Add('{');
    symbols.Add('}');
    symbols.Add('[');
    symbols.Add(']');
    symbols.Add('/');
    symbols.Add('|');
    symbols.Add(';');
    symbols.Add(':');
    symbols.Add('.');
    symbols.Add('<');
    symbols.Add('>');
    for(char letter='a';letter<='z';letter++)
    {
        alphabets.Add(letter);
    }
    return_alphabet(3);
 }

    private static char return_alphabet(int i)
    {
        return alphabets[i];
    }
    private static int return_alphabet_index(char a)
    {
        int i = 0;
        
        foreach (char c in alphabets)
        {
            if (c == a)
            {
                return i;
            }
            else
            {
                i++;
            }
        }
        return -1;
    }
    private static char return_symbol(int i)
    {
        return symbols[i];   
    }
    private static int return_symbol_index(char a)
    {
        foreach (char c in symbols)
        {
            if (c == a)
            {
                return i;
            }
            else
            {
                i++;
            }
        }
        return -1;
    }
    private static string encrypt_message(string str)
    {
        str = str.ToLower();
        char [] array = str.ToCharArray();
        string encrypted = "";
        for (int i = 0; i < array.Length; i++)
        {
            int index = return_alphabet_index(array[i]);
            encrypted += return_symbol(index);
        }
        return encrypted;
    }
    private static string decrypt_message(string str)
    {
        str = str.ToLower();
        char [] array = str.ToCharArray();
        string decrypted = "";
        for(int i = 0; i < array.Length; i++)
        {
            int index = return_symbols_index(array[i]);
            decrypted += return_alphabet(index);
        }
        return decrypted;
    }
}