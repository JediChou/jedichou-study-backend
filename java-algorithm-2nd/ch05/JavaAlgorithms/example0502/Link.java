package ch05.JavaAlgorithms.example0502;

class Link {
	public int iData;
	public double dData;
	public Link next;

	public Link(int id, double dd) {
		iData = id;
		dData = dd;
	}

	public void displayLink() {
		System.out.print("{" + iData + ", " + dData + "} ");
	}
}
