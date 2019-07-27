// Filename: Ch11Ex03.cs
// From 238 page of Beginning C# 2005 Chinese edtion.
// Date: 2011-4-4

using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

public class Primes
{
	private long min;
	private long max;
	
	public Primes() : this(2, 100)
	{
	}
	
	public Primes(long minimum, long maximum)
	{
		if (min < 2)
			min = 2;
		
		min = minimum;
		max = maximum;
	}
	
	// A useable iterator design example.
	public IEnumerator GetEnumerator()
	{
		for(long possiblePrime = min; possiblePrime <= max; possiblePrime++)
		{
			bool isPrime = true;
			for(long possibleFactor = 2;
				possibleFactor <= (long)Math.Floor(Math.Sqrt(possiblePrime));
				possibleFactor++)
			{
				long remainderAfterDivision = possiblePrime % possibleFactor;
				if (remainderAfterDivision == 0)
				{
					isPrime = false;
					break;
				}
			}
			
			if(isPrime)
				yield return possiblePrime;
		}
	}
}

public class Program
{
	public static void Main(string[] args)
	{
		Primes primesFrom2To1000 = new Primes(2,1000);
		foreach(long i in primesFrom2To1000)
			Console.Write("{0} ", i);
		
		Console.ReadKey();
	}
}
