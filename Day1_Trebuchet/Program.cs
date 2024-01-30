public static class Program
{
    static void Main()
    {
        var sum = 0;

        using (var sr = new StreamReader("./Input.txt"))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                var num = ComputeLine(line);
                sum += num;
            }
        }

        Console.WriteLine(sum);
    }

    public static int ComputeLine(string line)
    {
        var characters = line.ToCharArray();
        var numbers = new char[9] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        var foundNumbers = new List<int>();

        foreach (char character in characters)
        {
            if (numbers.Contains(character))
            {
                foundNumbers.Add(Convert.ToInt16(character.ToString()));
            }
        }

        if (foundNumbers.Count == 0)
        {
            return 0;
        }

        return Convert.ToInt16(foundNumbers.First().ToString() + foundNumbers.Last().ToString());
    }
}