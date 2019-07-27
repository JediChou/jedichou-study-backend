import java.awt.List;
import java.util.LinkedList;
import org.junit.Assert;
import org.junit.Test;
import static org.mockito.Mockito.*;

public class testFirst {

	/* Sample 1: Let's verify some behavior! */
	@Test
	public void sample01() {
		// 1. mock creation
		// 2. using mock object
		// 3. verification
		List mockedList = mock(List.class);
		mockedList.add("one");
		verify(mockedList).add("one");
	}
	
	/* Sample 2: How about some stubbing */
	@Test(expected=RuntimeException.class)
	public void sample02() {
		// You can mock concrete classes, not only interfaces
		@SuppressWarnings("unchecked")
		LinkedList<String> mockedList = mock(LinkedList.class);
		
		// stubbing
		when(mockedList.get(0)).thenReturn("first");
		when(mockedList.get(1)).thenThrow(new RuntimeException());
		
		// following prints "first"
		Assert.assertEquals("first", mockedList.get(0));
		Assert.assertEquals(null, mockedList.get(999));
		mockedList.get(1);
	}
	
	/* Sample 3. Argument matchers */
	@Test
	public void sample03() {
		// TODO sample03 is not complete
		// create a mock object
		// stubbing using built-in anyInt() argument matcher
		@SuppressWarnings("unchecked")
		LinkedList<String> mockedList = mock(LinkedList.class);
		when(mockedList.get(anyInt())).thenReturn("element");

		Assert.assertEquals("element", mockedList.get(0));
		Assert.assertEquals("element", mockedList.get(1));
	}
	
	/* Sample 4. Verifying exact number of invocations /at least/never */
	@Test
	public void sample04() {
		@SuppressWarnings("unchecked")
		LinkedList<String> mockedList = mock(LinkedList.class);
		mockedList.add("once");
		mockedList.add("twice");
		mockedList.add("twice");
		mockedList.add("three times");
		mockedList.add("three times");
		mockedList.add("three times");
		
		// following two verifications work exactly the same - time(1) is used by default
		verify(mockedList).add("once");
		verify(mockedList, times(1)).add("once");
		
		// exact number of invocations verification
		verify(mockedList, times(2)).add("twice");
		verify(mockedList, times(3)).add("three times");
		
		// verification using never(). never() is an alias to times(0)
		verify(mockedList, never()).add("never happened");
		
		// verification using atLeast()/atMost()
		verify(mockedList, atLeastOnce()).add("three times");
		verify(mockedList, atLeast(2)).add("twice");
		verify(mockedList, atMost(5)).add("three times");
	}
	
}
