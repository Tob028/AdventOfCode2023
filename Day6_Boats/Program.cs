var races = new Dictionary<int, int>();
var total = 1;

races.Add(40, 233);
races.Add(82, 1011);
races.Add(84, 1110);
races.Add(92, 1487);

foreach (var race in races)
{
    var higherSolutions = 0;

    for (int i = 1; i < race.Key; i++)
    {
        var remainingTime = race.Key - i;
        var distanceTraveled = remainingTime * i;

        if (distanceTraveled > race.Value)
        {
            higherSolutions++;
        }
    }

    total *= higherSolutions;
}

Console.WriteLine(total);