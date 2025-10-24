using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Phone_Pad_C__Coding_Challenge_Iron_Software.src.Data;

public class xUnitTestData
{
    public static IEnumerable<object[]> PhonePadCasesXunit =>
         new List<object[]>
         {
                    new object[] { "8 88777444666*664#", "turing" },
                    new object[] { "227*##", "b" },
                    new object[] { "22#", "b" },
                    new object[] { "4433555 555666#", "hello" },
                    new object[] { "777733#", "se" },
         };
}
