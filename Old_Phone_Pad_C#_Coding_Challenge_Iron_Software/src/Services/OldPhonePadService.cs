using Old_Phone_Pad_C__Coding_Challenge_Iron_Software.src.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Phone_Pad_C__Coding_Challenge_Iron_Software.src.Services;

internal class OldPhonePadService 
{
    public static string OldPhonePad(string userInput)
    {
        char[] userInputCharArray = userInput.ToCharArray();

        if (string.IsNullOrEmpty(userInput) || userInput[^1] != '#')
        {
            return "Invalid Input";
        }
        else
        {
            var message = ProcessSameNumber(userInputCharArray);
            return message;
        }
    }

    private static string ProcessSameNumber (char[] inputSequence)
    {
        var keypad = KeyPadData.KeyPadMapping;
        string temp = "";
        var storeMessage = new List<char>();
        foreach (char c in inputSequence)
        {
            if (c == '#' )
            {
                if (keypad.ContainsKey(temp))
                {
                    storeMessage.Add(keypad[temp]);
                    temp = "";
                }
                break;
            }
            else if (c <= '9' && c >= '0')
            {
                if (temp.Length == 0 || temp.Contains(c))
                {
                    temp += c;
                    continue;
                }
                else 
                {
                    if (keypad.ContainsKey(temp))
                    {
                        storeMessage.Add(keypad[temp]);
                        temp = "";
                        temp += c;
                        continue;
                    }
                }
            }
            else if (c == ' ')
            {
                if (keypad.ContainsKey(temp))
                {
                    storeMessage.Add(keypad[temp]);
                    temp ="";
                }
                continue;
            }
            else if (c=='*')
            {
                temp = "";
                //samenumber.RemoveAt(samenumber.Count - 1);
                //temp.Clear();
                //if (keypad.ContainsKey(new string(samenumber.ToArray())))
                //{
                //    finaloutput.Add(keypad[new string(samenumber.ToArray())]);
                //    samenumber.Clear();
                //}
                continue;
            }        
            else
            {
                return "Invalid Input";
            }
        }
        var message = new string(storeMessage.ToArray()).ToUpper();
        return  message;
    }
}
