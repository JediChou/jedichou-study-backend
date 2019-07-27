interface A { void method1(); } interface B { void method2(); }
class M:A,B { public void method1() {} public void method2() {} }
class P { public static void Main() {
	A a = new M(); B b = new M();
	a.method1(); b.method2();
}}
