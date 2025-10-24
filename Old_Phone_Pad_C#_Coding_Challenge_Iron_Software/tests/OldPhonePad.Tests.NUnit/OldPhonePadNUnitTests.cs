using NUnit.Framework;
using Old_Phone_Pad_C__Coding_Challenge_Iron_Software.src.Services;
using Old_Phone_Pad_C__Coding_Challenge_Iron_Software.src.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Old_Phone_Pad_C__Coding_Challenge_Iron_Software.tests.OldPhonePad.Tests.NUnit;

public class OldPhonePadNUnitTests
{
    [TestFixture]
    public class NUnitTest
    {
        [Test, TestCaseSource(typeof(NUnitTestData), nameof(NUnitTestData.PhonePadCasesNUnit))]
        public void NUintTesting(string input, string expected)
        {
            var result = OldPhonePadService.OldPhonePad(input);
            Assert.That(result, Is.EqualTo(expected.ToUpper()));
        }
    }
}
