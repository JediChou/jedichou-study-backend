class Program { static void Main() {
	int n = 100;
	object s = n;    // boxing value -> reference object
	int m = (int) s; // unboxing
}}
