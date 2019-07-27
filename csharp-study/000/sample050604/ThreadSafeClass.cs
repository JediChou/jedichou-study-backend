// ThreadSafeClass.cs
class Foo {
	private class FooSynchronized : Foo {
		private object syncRoot = new object();
		private Foo m_Foo;
		public FooSynchronized(Foo foo) { m_Foo = foo; }
		public override bool IsSynchronized { get {return true;} }
		public override void Fct1() { lock(syncRoot) { m_Foo.Fct1();} }
		public override void Fct2() { lock(syncRoot) { m_Foo.Fct2();} }
	}

	public virtual bool IsSynchronized { get {return false;} }
	public static Foo Synchronized(Foo foo){
		if( !foo.IsSynchronized )
			return new FooSynchronized(foo);
		return foo;
	}
	public virtual void Fct1() { /* .. */ }
	public virtual void Fct2() { /* .. */ }
}
