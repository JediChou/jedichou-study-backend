import java.awt.List;
import java.util.LinkedList;
import org.junit.Test;
import static org.junit.Assert.*;
import static org.mockito.Mockito.*;

public class secondFirst {

	@Test
	public void testSomething() {
		List mockedList = mock(List.class);
		mockedList.add("One");
		verify(mockedList).add("One");
	}

	@Test
	public void useToStub() {
		@SuppressWarnings("unchecked")
		LinkedList<String> mockedList = mock(LinkedList.class);
		when(mockedList.get(0)).thenReturn("first");
		assertEquals("first", mockedList.get(0));
		assertEquals(null, mockedList.get(999));
	}
	
}
