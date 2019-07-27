package ch03.JavaAlgorithms.BubbleSort;

public class BubbleSortApp {
	public static void main(String[] args) {
		
		// Define array size and create a ArrayBub object.
		int maxSize = 100;
		ArrayBub arr = new ArrayBub(maxSize);
		
		// Insert 10 elements
		arr.insert(77);
		arr.insert(99);
		arr.insert(44);
		arr.insert(55);
		arr.insert(22);
		arr.insert(88);
		arr.insert(00);
		arr.insert(66);
		arr.insert(33);
		
		// Before sort
		arr.display();
		
		// After sort
		arr.bubbleSort();
		arr.display();
	}
}
