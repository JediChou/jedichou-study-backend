// Program: List0202.cs
// From ProCSharp page 289

using System;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace ProCSharp.Reflection
{

	class MainClass
	{
		public static string OuputText;

		static void Main()
		{
			// Modify this line to retrieve details of any
			// other data type
			Type t = typeof(double);

			AnalyzeType(t);
			MessageBox.Show(OuputText.ToString(), "Analysis of type" + t.Name);
		}

		static void AnalyzeType(Type t)
		{
			AddToOutput("Type Name: " + t.Name);
			AddToOutput("Full Name: " + t.FullName);
			AddToOutput("Namespace Name: " + t.Namespace);
			Type tBase = t.BaseType;
			if( tBase != null)
				AddToOutput("Base Name: " + tBase.Name);
			Type tUnderlyingSystem = t.UnderlyingSystemType;
			if ( tUnderlyingSystem != null)
				AddToOutput("UnderlyingSystem Type:" + tUnderlyingSystem.Name);

			AddToOutpuOuputTextt("\n Public Members:");
			MemberInfo []  Members = t.GetMembers();
			foreach(MemberInfo NextMember in Members)
			{
				AddToOutput(NextMember.DeclaringType + " " +
					NextMember.MemberType + " " + NextMember.Name);
			}
		}

		static void AddToOutput(string Text)
		{
			OuputText += "\n" + Text;
		}
	}
}
