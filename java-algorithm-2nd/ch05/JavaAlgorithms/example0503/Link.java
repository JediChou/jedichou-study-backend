package ch05.JavaAlgorithms.example0503;

class Link {
	
	public long dData;
	public Link next;

	public Link(long d) {
		dData = d;
	}

	public void displayLink() {
		System.out.print(dData + " ");
	}
}
