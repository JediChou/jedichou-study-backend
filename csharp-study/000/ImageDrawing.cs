/*
 * Created by SharpDevelop.
 * User: F3216338
 * Date: 2012/9/21
 * Time: 下午 04:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace ImageDrawing
{
	class Program
	{
		public static void Main(string[] args)
		{
			
			// image
			Image newImage = Image.FromFile("./SampleImage.jpg");
			Point ulCorner = new Point(100, 100);
						
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}