using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Phone_Pad_C__Coding_Challenge_Iron_Software.MockData
{
    public class KeyPadData
    {
        public static IEnumerable<TestCaseData> PhonePadCasesNUnit
        {
            get
            {
                yield return new TestCaseData("8 88777444666*664#", "turing");
                yield return new TestCaseData("4433555 555666#", "hello");
                yield return new TestCaseData("227*#", "b");
                yield return new TestCaseData("22#", "b");
                yield return new TestCaseData("777733#", "se");
            }
        }
        public static IEnumerable<object[]> PhonePadCasesXunit =>
             new List<object[]>
             {
                        new object[] { "8 88777444666*664#", "turing" },
                        new object[] { "227*##", "b" },
                        new object[] { "22#", "b" },
                        new object[] { "4433555 555666#", "hello" },
                        new object[] { "777733#", "se" },
             };
        public static Dictionary<string, char> KeyPadMapping => 
            new Dictionary<string, char>
            {
                        { "1", '&' }, { "11", '\'' }, { "111", '(' }, { "1111", ')' },
                        { "2", 'a'}, {"22", 'b'}, {"222", 'c'},
                        { "3", 'd'}, {"33", 'e'}, {"333", 'f'},
                        { "4", 'g'}, {"44", 'h'}, {"444", 'i'},
                        { "5", 'j'}, {"55", 'k'}, {"555", 'l'},
                        { "6", 'm'}, {"66", 'n'}, {"666", 'o'},
                        { "7", 'p'}, {"77", 'q'}, {"777", 'r'}, {"7777", 's'},
                        { "8", 't'}, {"88", 'u'}, {"888", 'v'},
                        { "9", 'w'}, {"99", 'x'}, {"999", 'y'}, {"9999", 'z'},
                        {"0", ' '}
            };
    }
}
