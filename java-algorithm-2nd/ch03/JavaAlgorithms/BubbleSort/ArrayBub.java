package ch03.JavaAlgorithms.BubbleSort;

class ArrayBub {
	private long[] a; // reference to array a
	private int nElems; // number of data items

	/*
	 * Put element into array
	 */
	public ArrayBub(int max) {
		a = new long[max]; // create the array
		nElems = 0;
	}

	public void insert(long value) {
		a[nElems] = value;
		nElems++;
	}

	/*
	 * Displays array contents
	 */
	public void display() {
		for (int j = 0; j < nElems; j++)
			System.out.print(a[j] + " ");
		System.out.println();
	}

	/*
	 * Run bubble sort
	 */
	public void bubbleSort() {
		int out, in;
		for (out = nElems - 1; out > 1; out--) {
			for (in = 0; in < out; in++)
				if (a[in] > a[in + 1])
					swap(in, in + 1);
		}
		// TODO, 若數組長度為2時，該算法會出錯。
	}

	/*
	 * swap function
	 */
	private void swap(int one, int two) {
		long temp = a[one];
		a[one] = a[two];
		a[two] = temp;
	}
}
