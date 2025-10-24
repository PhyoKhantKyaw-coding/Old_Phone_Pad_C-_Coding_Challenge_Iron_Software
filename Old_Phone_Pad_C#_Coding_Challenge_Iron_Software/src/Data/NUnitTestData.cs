using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Phone_Pad_C__Coding_Challenge_Iron_Software.src.Data;

public class NUnitTestData
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
}
