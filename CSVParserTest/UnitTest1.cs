using NUnit.Framework;
//using FluentAssertions;
using CSVParserApp.Models;

namespace CSVParserTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void CheckReadFileMethod()
    {
        //Arange
        string fileName = "test";
        string filePath = "path";

        //Act
        ReadFile readFile = new ReadFile(fileName, filePath);

        //Assert
        Assert.That(readFile.ReadFileFromPath(), Is.EqualTo("Success"));
    }
}
