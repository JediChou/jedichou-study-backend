package TestJava7Study.Hello;

import org.junit.Test;
import static org.junit.Assert.*;
import Java7Study.Hello.*;

/**
 * 测试最基本的函数返回值
 * @author jedi
 */
public class HelloWorldTest {
    @Test
    public void testHelloWorld() {
        HelloWorld inst = new HelloWorld();
        assertEquals("Compare failed", "Hello World", inst.getHelloStr());
    }
}
