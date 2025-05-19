// See https://aka.ms/new-console-template for more information

using Interview_Prepartion_All_basic_Coding;

Console.WriteLine("Select a Program:");
Console.WriteLine("1. Reverse String");


Console.Write("Enter a choice: ");
int choice = Convert.ToInt32(Console.ReadLine());


switch (choice)
{
    case 1:
        Console.Write("Enter a string to reverse: ");
        string input = Console.ReadLine();
        var reverseString = new ReverseString();
        string reversed = reverseString.Reverse(input);
        Console.WriteLine($"Reversed string: {reversed}");
        break;

    default:
        Console.WriteLine("Invalid choice.");
        break;
}


