using System;
using System.IO;
using System.Text;
using NUnit.Framework;
using VerifyTests;
using VerifyNUnit;

namespace GildedRoseTests;


[TestFixture]
public class ApprovalTest
{
    [Test]
    public void ThirtyDays()
    {
        StringBuilder fakeOutput = new StringBuilder();
        Console.SetOut(new StringWriter(fakeOutput));
        Console.SetIn(new StringReader($"a{Environment.NewLine}"));

        TextTestFixture.Main(new string[] { });
        var output = fakeOutput.ToString();
        Verifier.Verify(output);
        //return Verify(output);
    }
}