using Old_Phone_Pad_C__Coding_Challenge_Iron_Software.src.Services;
using Old_Phone_Pad_C__Coding_Challenge_Iron_Software.src.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Old_Phone_Pad_C__Coding_Challenge_Iron_Software.tests.OldPhonePad.Tests.xUnit;

public class OldPhonePadXUnitTests
{
    public class xUintTest
    {
        [Theory]
        [MemberData(nameof(xUnitTestData.PhonePadCasesXunit), MemberType = typeof(xUnitTestData))]
        public void xUintTesting(string input, string expected)
        {
            var result = OldPhonePadService.OldPhonePad(input);
            Assert.Equal(expected.ToUpper(), result);
        }
    }
}
