namespace ProgrammingCSharp4 {
	public delegate void DoProcess(string msg);
	class DelegateSample {
		void Process(string msg) {
			System.Console.WriteLine("Process flow: {0}", msg);
		}
		public static void Main() {
			DelegateSample sample = new DelegateSample();
			// DoProcess process = new DoProcess(sample.Process)
			DoProcess process = sample.Process;
			process("Test data");
		}
	}
}
