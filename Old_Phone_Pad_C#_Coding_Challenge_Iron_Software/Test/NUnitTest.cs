using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Assert = NUnit.Framework.Assert;
namespace Old_Phone_Pad_C__Coding_Challenge_Iron_Software.Test
{
    [TestFixture]
    public class NUnitTest
    {
        [Test, TestCaseSource(typeof(MockData.KeyPadData), nameof(MockData.KeyPadData.PhonePadCasesNUnit))]
        public void NUintTesting(string input, string expected)
        {
            var result = Service.OldPhonePadService.OldPhonePad(input);
            Assert.That(result, Is.EqualTo(expected.ToUpper()));
        }
    }
}
