import org.junit.Assert;
import org.junit.Test;
import static org.mockito.Mockito.*;

public class sampleforging {
	
	@Test
	public void testsample() {
		IEproxy ieproxy = mock(IEproxy.class);
		when(ieproxy.filter("http://baidu.com")).thenReturn("pass");
		when(ieproxy.filter("http://blogbus.com")).thenReturn("no pass");
		
//		IEproxy ieproxy = new IEproxy();
		
		Assert.assertEquals("pass", ieproxy.filter("http://baidu.com"));
		Assert.assertEquals("no pass", ieproxy.filter("http://blogbus.com"));
		Assert.assertEquals(null, ieproxy.filter("other string"));
	}
	
	@Test ( expected = RuntimeException.class)
	public void testexception() {
		IEproxy ieproxy = mock(IEproxy.class);
		when(ieproxy.getname()).thenThrow(new RuntimeException());
		ieproxy.getname();
	}
	
}
