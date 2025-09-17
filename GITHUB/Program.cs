Console.WriteLine("ange ett heltal:");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("talet {0} är {1}" , number, number % 2 == 0 ? "jämnt" : "udda");

a