class ProgramP100
{
	static void Main()
	{
		// Basic type
		sbyte a = new System.SByte();
		byte b = new System.Byte();
		ushort c = new System.UInt16();
		int d = new System.Int32();
		uint e = new System.UInt32();
		long f = new System.Int64();
		ulong g = new System.UInt64();
		char h = new System.Char();
		float i = new System.Single();
		double j = new System.Double();
		bool k = new System.Boolean();
		decimal l = new System.Decimal();
		// string m = new System.String();  // Notice: ����ֱ�ӳ�ʼ����Ҫ�в���
		string m = "";
		object n = new System.Object();
		dynamic o = new System.Object();  // Notice: ����ط��ķ��������Ƚ��ر�

		// Output
		P(a); P(b); P(c); P(d); P(e);
		P(f); P(g); P(h); P(i); P(j);
		P(k); P(l); P(m); P(n); P(o);
	}

	private static void P(object o) {
		System.Console.WriteLine(o is object);
	}
}
