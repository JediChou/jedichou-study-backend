package ch05.JavaAlgorithms.example0501;

public class LinkListApp {
	public static void main(String[] args) {

		// 演示了一个单向链表
		// make new list
		LinkList theList = new LinkList();

		// insert four items
		theList.insertFirst(22, 2.99);
		theList.insertFirst(44, 4.99);
		theList.insertFirst(66, 6.99);
		theList.insertFirst(88, 8.99);

		// display list
		theList.displayList();

		// until it's empty,
		while (!theList.isEmpty()) {
			Link aLink = theList.deleteFirst();
			System.out.print("Deleted");
			aLink.displayLink();
			System.out.println("");
		}

		theList.displayList();
	}
}
