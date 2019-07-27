package ch05.JavaAlgorithms.example0502;

public class LinkList2App {
	
	/*
	 * Add two methods. The one is find methods, the
	 * other one is delete method. 
	 */
	public static void main(String[] args) {

		// Define a link-list and insert some items
		LinkList theList = new LinkList();
		theList.insertFirst(22, 2.99);
		theList.insertFirst(44, 4.99);
		theList.insertFirst(66, 6.99);
		theList.insertFirst(88, 8.99);

		theList.displayList();

		// Find item
		Link f = theList.find(44);
		if (f != null)
			System.out.println("Found link with key " + f.iData);
		else
			System.out.println("Can't find link");

		// Delete item
		Link d = theList.delete(66);
		if (d != null)
			System.out.println("Delete link with key " + d.iData);
		else
			System.out.println("Can't delete link");

		// Output link-list after delete action
		theList.displayList();
	}
}
