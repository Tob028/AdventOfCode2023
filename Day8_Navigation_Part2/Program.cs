var instructions = "";
var nodes = new Dictionary<string, (string, string)>();
var steps = 0;

var currentNodes = new List<string>();

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

            if (segments[0].EndsWith("A"))
            {
                currentNodes.Add(segments[0]);
            }
        }

        index++;
    }
}

var instructionsIndex = 0;


while (!currentNodes.All(node => node.EndsWith("Z")))
{
    var nextNodes = new List<string>();

    if (instructionsIndex + 1 > instructions.Length)
    {
        instructionsIndex = 0;
    }

    foreach (var nodeName in currentNodes)
    {
        var options = nodes.FirstOrDefault(n => n.Key == nodeName);

        switch (instructions[instructionsIndex])
        {
            case 'L':
                nextNodes.Add(options.Value.Item1);
                break;
            case 'R':
                nextNodes.Add(options.Value.Item2);
                break;
        }
    }

    Console.WriteLine($"Next nodes: {string.Join(", ", nextNodes)}");

    currentNodes.Clear();
    currentNodes.AddRange(nextNodes);

    nextNodes.Clear();

    instructionsIndex++;
    steps++;

    Console.WriteLine($"Steps: {steps}");
}

Console.WriteLine(steps);