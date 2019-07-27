import org.junit.Assert;
import org.junit.Test;
import static org.mockito.Mockito.*;

public class test_meihe {
	
	@Test
	public void testMeiHeWorkStatus() {
		Meihe meihe = mock(Meihe.class);
		
		when(meihe.work("进度怎么样呀")).thenReturn("好烦呀");
		when(meihe.work("给块饼干你")).thenReturn("不行, 要全部");
		
		System.out.println(meihe.work("进度怎么样呀"));
		System.out.println(meihe.work("给块饼干你"));
	}
	
	@Test (expected = RuntimeException.class)
	public void testMeiYaliShanDa() {
		Meihe meihe = mock(Meihe.class);
		when(meihe.accept("200job")).thenReturn("崩溃了");
		meihe.accept("200job");
	}
}
