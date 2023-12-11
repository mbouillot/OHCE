using System;

class Program
{
    static void Main()
    {
        string salutation = GetSalutation();
        Console.WriteLine(salutation);

        while (true)
        {
            Console.Write("Saisissez quelque chose (ou tapez 'exit' pour quitter) : ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine("Au revoir !");
                break;
            }

            if (IsPalindrome(input))
            {
                Console.WriteLine("Bien dit !");
            }
            else
            {
                string reversedInput = ReverseString(input);
                Console.WriteLine($"En miroir : {reversedInput}");
            }
        }
    }

    static string GetSalutation()
    {
        DateTime now = DateTime.Now;
        int hour = now.Hour;

        if (hour >= 6 && hour < 12)
        {
            return "Bonjour !";
        }
        else if (hour >= 12 && hour < 18)
        {
            return "Bonjour !";
        }
        else
        {
            return "Bonsoir !";
        }
    }

    static bool IsPalindrome(string text)
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        string reversedText = new string(charArray);

        return text.ToLower() == reversedText.ToLower();
    }

    static string ReverseString(string text)
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
