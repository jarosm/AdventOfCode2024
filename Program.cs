
Part1();

Part2();

Console.WriteLine("end");
Console.ReadLine();


string[] ParseInput()
{
	var input = File.ReadAllLines("input.txt");

	return input;
}


void Part1()
{
	var input = ParseInput();

	Console.WriteLine($"Part 1: ");
}


void Part2()
{
	var input = ParseInput();

	Console.WriteLine($"Part 2: ");
}