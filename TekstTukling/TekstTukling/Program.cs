// See https://aka.ms/new-console-template for more information
namespace System;

public class program
{
    public static void Main()
    {
        run();
    }

    public static void run()
    {
        Console.WriteLine("Write something you want converted");
        string str = Console.ReadLine();
        Console.WriteLine("do u want to reverse the text(1) or change the e's with a's(2)");
        int choose = Convert.ToInt32(Console.ReadLine());

        switch (choose)
        {
            case 1:
                txtReverse(str);
                break;
            case 2:
                eTxtReplace(str);
                break;
            default:
                Console.WriteLine("invalid! try something else");
                break;
        }
        
    }

    public static void txtReverse(string str)
    {
        char[] strArray = str.ToCharArray();
        Array.Reverse(strArray);
        string reversedTxt = new string(strArray);
        Console.WriteLine($"Your txt \"{str}\"");
        Console.WriteLine($"Reversed txt \"{reversedTxt}\"");
    }

    public static void eTxtReplace(string str)
    {
        string eToA = str.Replace("e", "a").Replace("E", "A");
        
        Console.WriteLine($"{eToA}");
    }
    
}