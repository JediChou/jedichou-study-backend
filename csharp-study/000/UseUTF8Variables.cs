class Program {
	static void Main() {
		var testobj = new Labo();
		testobj.���� = "ţB";
		System.Console.WriteLine(testobj.����);
	}

	class Labo {
		public string ���� {get; set;}
	}
}
