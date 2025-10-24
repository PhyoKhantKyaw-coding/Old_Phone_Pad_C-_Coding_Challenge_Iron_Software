using Old_Phone_Pad_C__Coding_Challenge_Iron_Software.src.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Phone_Pad_C__Coding_Challenge_Iron_Software.src.Main;

public class Main
{
    public static void main()
    {
        Console.WriteLine("===== Old Phone Pad App =====");
        Console.WriteLine("\nType your keypad sequence (or type 'exit' to quit):");
        Console.WriteLine("Example: 4433555 555666# -> HELLO");
        while (true)
        {
            Console.Write("\nEnter keypad input: ");
            string userInput = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(userInput) || userInput.ToLower() == "exit")
            {
                Console.WriteLine("Exiting the simulator... Goodbye!");
                break;
            }

            string message = OldPhonePadService.OldPhonePad(userInput);
            Console.WriteLine("Keypad Output: " + message + "\n");
        }
    }
}
