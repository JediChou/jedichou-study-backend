string method, expected;
double actual = 0.0;

if (method == "ArithmeticMean")
{
	actual = MathLib.Methods.ArithmeticMean(input);
	if (actual.ToString("F4") == expected
		Console.WriteLine("Pass");
	else
		Console.WriteLine("*FAIL*");
}
else
{
	Console.WriteLines("Method not recognized");
}
