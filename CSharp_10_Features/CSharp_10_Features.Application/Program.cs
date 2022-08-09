

// See https://aka.ms/new-console-template for more information
Console.WriteLine("Testing Global ussing Dircetive");

Console.ReadKey();
Console.WriteLine("Set MIN value");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Set MAX value");
int max = Convert.ToInt32(Console.ReadLine());

jens_Testing _testing = new() { testingIntMin = min, testingString = $"{min} & {max}", testingIntMax = max };
Console.WriteLine(_testing.testingString);

Console.ReadKey();
Console.WriteLine("Using Global statis method in a non-statis class");
Console.WriteLine(_testing.GetMin(_testing.testingIntMin, _testing.testingIntMax));

Console.ReadKey();
Console.WriteLine("Namespace alias testing");
AllHailSimon allHailSimon = new();
Console.WriteLine(allHailSimon.SquareRoot(_testing.testingIntMin, _testing.testingIntMax));

Console.ReadKey();
Console.WriteLine("global Color");
Console.Write($"The color of {white} is: ");
Console.WriteLine(white);
Console.Write($"The color of {blue} is: ");
Console.WriteLine(blue);
Console.Write($"The color of {green} is: ");
Console.WriteLine(green);

Console.WriteLine("Lanbda with Att");

//Func<string, int> parse = [Lambda_Improvements(1)] (s) => int.Parse(s);
//var choose = [Lambda_Improvements(2)] [Lambda_Improvements(3)] object (bool b) => b ? 1 : "two";

//var sum2 = ([Lambda_Improvements(1)] int a, [Lambda_Improvements(2), Lambda_Improvements(3)] int b) => a + b;
//var inc2 = [return: Lambda_Improvements(1)] (int s) => s++;

Console.ReadLine();