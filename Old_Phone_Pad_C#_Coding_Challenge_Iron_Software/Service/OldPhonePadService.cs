using Old_Phone_Pad_C__Coding_Challenge_Iron_Software.MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Old_Phone_Pad_C__Coding_Challenge_Iron_Software.Service
{
    public class OldPhonePadService
    {
        public static string OldPhonePad(string input)
        {
            var keypad = KeyPadData.KeyPadMapping;
            char[] inputs = input.ToCharArray();
            var sameNumber = new List<char>();
            var finalOutput = new List<char>();
            if (string.IsNullOrEmpty(input) || input[^1] != '#')
            {
                return "Invalid Input";
            }
            else
            {
                foreach (char c in inputs)
                {
                    if (c == '#')
                    {
                        if (keypad.ContainsKey(new string(sameNumber.ToArray())))
                        {
                            finalOutput.Add(keypad[new string(sameNumber.ToArray())]);
                            sameNumber.Clear();
                        }
                        string result = new string(finalOutput.ToArray()).ToUpper();
                        return result;
                    }
                    else if (c <= '9' && c >= '0' || c == ' ' || c == '*')
                    {
                        if (sameNumber.Count == 0 || sameNumber.Contains(c))
                        {
                            sameNumber.Add(c);
                        }
                        else if (!sameNumber.Contains(c) && c != ' ' && c != '*')
                        {
                            if (keypad.ContainsKey(new string(sameNumber.ToArray())))
                            {
                                finalOutput.Add(keypad[new string(sameNumber.ToArray())]);
                                sameNumber.Clear();
                                sameNumber.Add(c);
                            }
                            else
                            {
                                return "Invalid Input";
                            }
                        }
                        else if (sameNumber.Count > 0 && c == '*')
                        {
                            //samenumber.RemoveAt(samenumber.Count - 1);
                            sameNumber.Clear();
                            //if (keypad.ContainsKey(new string(samenumber.ToArray())))
                            //{
                            //    finaloutput.Add(keypad[new string(samenumber.ToArray())]);
                            //    samenumber.Clear();
                            //}
                            continue;
                        }
                        else
                        {
                            if (keypad.ContainsKey(new string(sameNumber.ToArray())))
                            {
                                finalOutput.Add(keypad[new string(sameNumber.ToArray())]);
                                sameNumber.Clear();
                            }
                            else
                            {
                                return "Invalid Input";
                            }
                        }
                    }
                    else
                    {
                        return "Invalid Input";
                    }
                }
                return finalOutput.ToString()!;
            }
        }
        public static void Main()
        {
            Console.WriteLine("OldPhonePad");
            Console.WriteLine("Type your keypad input (end with #). Type 'exit' to quit.\n");
            while (true)
            {
                Console.Write("Enter keypad input: ");
                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || input.ToLower() == "exit")
                {
                    Console.WriteLine("Exiting the simulator... Goodbye!");
                    break;
                }

                string output = OldPhonePad(input);
                Console.WriteLine("Keypad Output: " + output + "\n");
            }
        }
    }
}
