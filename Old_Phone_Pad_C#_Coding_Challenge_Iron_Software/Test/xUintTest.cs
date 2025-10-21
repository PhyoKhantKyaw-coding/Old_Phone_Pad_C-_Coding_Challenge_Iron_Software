using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Old_Phone_Pad_C__Coding_Challenge_Iron_Software.Test
{
    public class xUintTest
    {
        [Theory]
        [MemberData(nameof(MockData.KeyPadData.PhonePadCasesXunit), MemberType = typeof(MockData.KeyPadData))]
        public void xUintTesting(string input, string expected)
        {
            var result = Service.OldPhonePadService.OldPhonePad(input);
            Assert.Equal(expected.ToUpper(), result);
        }
    }
}
