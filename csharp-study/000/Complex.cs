/*
 * File name : Complex.cs
 * Description : A complex class.
 */

namespace CSharpAlgorithm.Algorithm
{
	using System;
	
	/// <summary>
	/// A complex class
	/// @auther ChangFa Chou
	/// @version 1.0
	/// </summary>
	public class Complex
	{
		private double real = 0.0;			// real part
		private double imaginary = 0.0;		// imaginary part
		private double eps = 0.0;			// default EPS
		
		/// <summary>
		/// Property : real part
		/// </summary>
		public double Real
		{
			get { return real;}
			set { real = value; }
		}
		
		/// <summary>
		/// Property : imaginary part
		/// </summary>
		public double Imaginary
		{
			get { return imaginary; }
			set { imaginary = value; }
		}
		
		/// <summary>
		/// Property : eps
		/// </summary>
		public double Eps
		{
			get { return eps; }
			set { eps = value; }
		}
		
		/// <summary>
		/// Basic Constructor
		/// </summary>
		public Complex() {}
		
		/// <summary>
		/// Constructor with two parameters.
		/// </summary>
		/// <param name="dblX">Real part</param>
		/// <param name="dblY">Imaginary part</param>
		public Complex(double dblX, double dblY)
		{
			real = dblX;
			imaginary = dblY;
		}
		
		/// <summary>
		/// Construct with other complex object.
		/// </summary>
		/// <param name="other">Source complex</param>
		public Complex(Complex other)
		{
			real = other.real;
			imaginary = other.imaginary;
		}
		
		/// <summary>
		/// Create a complex object follow pattern like "a,b".
		/// And a is real part, and b is imaginary part.
		/// </summary>
		/// <param name="s">string</param>
		/// <param name="sDelim">split character</param>
		public Complex(string s, string sDelim)	{ SetValue(s, sDelim); }
		
		/// <summary>
		/// Config eps for complex calculate.
		/// </summary>
		/// <param name="newEps">new eps value</param>
		public void SetEps(double newEps) { eps = newEps; }
		
		/// <summary>
		/// Get eps value
		/// </summary>
		/// <returns>current eps value</returns>
		public double GetEps() { return eps; }
		
		/// <summary>
		/// Config real part
		/// </summary>
		/// <param name="dblX">new real part</param>
		public void SetReal(double dblX) { real = dblX; }
		
		/// <summary>
		/// Set imaginary prt
		/// </summary>
		/// <param name="dblY">new imaginary part</param>
		public void SetImag(double dblY) { imaginary = dblY; }
		
		
	}
}
