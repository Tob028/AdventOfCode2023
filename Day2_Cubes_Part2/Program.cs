using System.Text.RegularExpressions;

var cubePowerSum = 0;

using (var sr = new StreamReader("./Input.txt"))
{
    string line;

    while ((line = sr.ReadLine()) != null)
    {
        var cubePower = 0;
        int minRed, minGreen, minBlue;
        minRed = minGreen = minBlue = 0;

        var inputSegments = line.Split(":");
        var setsSegments = inputSegments[1].Split(";");

        foreach (var setSegment in setsSegments)
        {
            var thrownDiceSegments = setSegment.Split(",");

            foreach (var segment in thrownDiceSegments)
            {
                var diceCount = Convert.ToInt16(Regex.Match(segment, @"\d+").Value);

                if (segment.Contains("red") && (diceCount > minRed))
                {
                    minRed = diceCount;
                }
                else if (segment.Contains("green") && (diceCount > minGreen))
                {
                    minGreen = diceCount;
                }
                else if (segment.Contains("blue") && (diceCount > minBlue))
                {
                    minBlue = diceCount;
                }
            }
        }

        cubePower = minRed * minGreen * minBlue;
        cubePowerSum += cubePower;
    }
}

Console.WriteLine(cubePowerSum);
Console.ReadKey();