var totalValue = 0;

using (var sr = new StreamReader("./Input.txt"))
{
    string line;

    while ((line = sr.ReadLine()) != null)
    {
        var timesWon = 0;

        var separatorIndex = line.IndexOf(":");
        var remainingPart = line.Substring(separatorIndex + 1);

        var segments = remainingPart.Split("|");
        var winningNumbers = segments[0].Split(" ");
        var guessedNumbers = segments[1].Split(" ");

        foreach (var number in winningNumbers)
        {
            if (guessedNumbers.Contains(number))
            {
                timesWon++;
            }
        }

        if (timesWon > 1)
        {
            totalValue += (int)Math.Pow(2, timesWon - 1);
        }
    }
}

Console.WriteLine(totalValue);