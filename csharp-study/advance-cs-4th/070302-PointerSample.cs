namespace Wrox.ProCSharp.PointerSample
{
	using System;

	class Program
	{
		public static void Main(string[] args)
		{
			unsafe
			{
				// Define
				int x = 10;
				short y = -1;
				byte y2 = 4;
				double z = 1.5;
				int* pX = &x;
				short* pY = &y;
				double* pZ = &z;

				// output normal define
				Console.WriteLine("Address of x is 0x{0:X}, size is {1}, value is {2}",	(uint)&x, sizeof(int), x);
				Console.WriteLine("Address of y is 0x{0:X}, size is {1}, value is {2}",	(uint)&y, sizeof(short), y2);
				Console.WriteLine("Address of y2 is 0x{0:X}, size is {1}, value is {2}",(uint)&y2, sizeof(byte), y);
				Console.WriteLine("Address of z is 0x{0:X}, size is {1}, value is {2}",(uint)&z, sizeof(double), z);

				// output pointer define
				Console.WriteLine("Address of pX is 0x{0:X}, size is {1}, value is {2}", (uint)&pX, sizeof(int*), (uint)pX);
				Console.WriteLine("Address of pY is 0x{0:X}, size is {1}, value is {2}", (uint)&pY, sizeof(short*), (uint)pY);
				Console.WriteLine("Address of pZ is 0x{0:X}, size is {1}, value is {2}", (uint)&pZ, sizeof(double*), (uint)pZ);

				// other operate
				*pX = 20;
				Console.WriteLine("\nAfter setting *pX, x={0}", x);
				Console.WriteLine("*pX={0}", *pX);

				pZ=(double*)pX;
				Console.WriteLine("x treated as a double = {0}", *pZ);

			}
		}
	}
}
