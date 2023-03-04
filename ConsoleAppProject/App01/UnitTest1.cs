using Microsoft.TestTools.UnitTesting;
using ConsoleAppProject.App01;

namespace ConsoleAppUnitTest
{
    public class UnitTest1
}

{
    DistanceConverter converter = new DistanceConverter();
    int expectOutput;
}


public void Test FeetToMiles();
{
    converter.fromUnit = "feet";
    converter.toUnit = "miles";
    converter.fromDistance = 10560;

    converter.ConverterDistance();

    expectedOutput = 2;

    Assert.AreEqual(expectedOutput, converter.toDistance);
}
}