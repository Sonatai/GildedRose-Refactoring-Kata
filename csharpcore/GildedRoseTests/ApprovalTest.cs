using NUnit.Framework;
using System;
using System.IO;
using System.Text;
using VerifyNUnit;

namespace GildedRoseTests;


[TestFixture]
public class ApprovalTest
{
    [Test]
    public void ThirtyDays()
    {
        StringBuilder fakeOutput = new();
        Console.SetOut(new StringWriter(fakeOutput));
        Console.SetIn(new StringReader($"a{Environment.NewLine}"));

        TextTestFixture.Main(new string[] { });
        string output = fakeOutput.ToString();
        Verifier.Verify(output);
    }
}