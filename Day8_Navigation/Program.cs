var instructions = "";
var nodes = new Dictionary<string, (string, string)>();
var steps = 0;

using (var sr = new StreamReader("./Input.txt"))
{
    string line;
    var index = 0;

    while ((line = sr.ReadLine()) != null)
    {
        if (index == 0)
        {
            instructions = line;
        }
        else if (index >= 2)
        {
            var segments = line.Split(" = ");
            var directions = segments[1].Substring(1, segments[1].Length - 2);
            var directionsSegments = directions.Split(", ");
            nodes.Add(segments[0], (directionsSegments[0], directionsSegments[1]));
        }

        index++;
    }
}

var instructionsIndex = 0;
var currentNode = "AAA";

while (currentNode != "ZZZ")
{
    var options = nodes.FirstOrDefault(n => n.Key == currentNode);

    if (instructionsIndex + 1 > instructions.Length)
    {
        instructionsIndex = 0;
    }

    switch (instructions[instructionsIndex])
    {
        case 'L':
            currentNode = options.Value.Item1;
            break;
        case 'R':
            currentNode = options.Value.Item2;
            break;
    }

    instructionsIndex++;
    steps++;
}

Console.WriteLine(steps);