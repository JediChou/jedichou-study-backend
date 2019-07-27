using System; class Class1{}; class Class2{}; class TypeConvert { static void Main() {
	var array = new object[6];
	array[0]=new Class1(); array[1]=new Class2();
	array[2]="hello"; array[3]=123;
	array[4]=123.4; array[5]=null;

	foreach(var t in array) {
		string s = t as string;	Console.Write("{0}:", s);
		if(s!=null)	Console.WriteLine(" is string type, value is: " + s);else Console.WriteLine(" is not string type");
	}
}}
