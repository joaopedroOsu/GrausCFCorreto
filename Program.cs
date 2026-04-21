Console.Write("Digite a temperatura em Celsius...:");
double temperaturac = Convert.ToDouble(Console.ReadLine());

double temperaturaf = temperaturac * 1.8 + 32;

Console.WriteLine($"{temperaturac}°C equivalem a {temperaturaf}°F ");