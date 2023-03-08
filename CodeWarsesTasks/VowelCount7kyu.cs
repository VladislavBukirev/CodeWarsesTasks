using System;
using System.Linq;
using NUnit.Framework;

public static class Kata
{
    public static int GetVowelCount(string str)
    {
        return str.Count(c => "aeiou".Contains(c));
    }
}

[TestFixture]
public class KataTests
{
    [Test]
    public void TestCase1()
    {
        Assert.AreEqual(5, Kata.GetVowelCount("abracadabra"), "Nope!");
    }
}