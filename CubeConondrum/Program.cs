using System.Text.RegularExpressions;

var gameSum = 0;

using (var sr = new StreamReader("./Input.txt"))
{
    string line;

    while ((line = sr.ReadLine()) != null)
    {
        var gameNum = 0;
        var invalidLine = false;

        int totalRed, totalGreen, totalBlue;
        totalRed = totalGreen = totalBlue = 0;

        var inputSegments = line.Split(":");
        var setsSegments = inputSegments[1].Split(";");

        gameNum = Convert.ToInt16(Regex.Match(inputSegments[0], @"\d+").Value);

        foreach (var setSegment in setsSegments)
        {
            var thrownDiceSegments = setSegment.Split(",");

            foreach (var segment in thrownDiceSegments)
            {
                var diceCount = Convert.ToInt16(Regex.Match(segment, @"\d+").Value);

                if (segment.Contains("red") && (diceCount > 12))
                {
                    invalidLine = true;
                }
                else if (segment.Contains("green") && (diceCount > 13))
                {
                    invalidLine = true;
                }
                else if (segment.Contains("blue") && (diceCount > 14))
                {
                    invalidLine = true;
                }
            }
        }

        if (!invalidLine)
        {
            gameSum += gameNum;
        }
    }
}

Console.WriteLine(gameSum);