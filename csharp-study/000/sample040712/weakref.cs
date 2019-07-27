class Program
{
	public static void Main() {
		// 'obj' is a strong reference on the object
		// created by this line.
		object obj = new object();

		// 'wobj' is a week reference on our object.
		System.WeakReference wobj = new System.WeakReference(obj);

		obj = null;  // Discard the strong reference 'obj'
		// ...
		// Here, our object might potentially be deallocated by the GC.
		// ...
		obj = wobj.Target;
		if (obj == null) {
			// If the thread pass here, it means that the object
			// has been dealloacted by the GC!
		}
		else {
			// If the thread pass here, it means that tht object
			// hasn't been deallocated by the GC. We cant thus use it.
		}
	}
}
