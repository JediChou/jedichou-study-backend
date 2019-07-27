package TestJava7Study.Chapter02.S020101;

import org.junit.Test;
import org.junit.Assert;
import Java7Study.Chapter02.S020101.*;

/**
 * DefineArray的测试类
 * @author jedi
 */
public class DefineArrayTest {
    
    /**
     * 测试方法公用的实例
     */
    public DefineArray inst;
    
    /**
     * DefineArrayTest的构造函数
     */
    public DefineArrayTest() {
        inst = new DefineArray();
    }
    
    @Test
    public void TestGetIntNumberArray_Length() {
        int expected = 10;
        int fact = this.inst.getIntNumberArray().length;
        Assert.assertEquals("Check array length", expected, fact);
    }
    
    @Test
    public void TestGetIntNumberArray_Element() {
        int[] expected = new int[10];
        int[] fact = this.inst.getIntNumberArray();
        Assert.assertArrayEquals(expected, fact);
    }
    
    @Test
    public void TestGetFloatNumberArray_Length() {
        int expected = 10;
        int fact = this.inst.getFloatNumberArray().length;
        Assert.assertEquals("Check float array length", expected, fact);
    }
    
    @Test
    public void TestGetFloatNumberArray_Element() {
        float[] expected = new float[10];
        float[] fact = this.inst.getFloatNumberArray();
        Assert.assertArrayEquals(expected, fact, 0);
    }
    
    @Test
    public void TestGetDasizeFloatArray() {
        float[] expect = new float[20];
        float[] fact = this.inst.getDasizeFloatArray();
        Assert.assertEquals(20, fact.length);
        Assert.assertArrayEquals(expect, fact, 0);
    }
    
    @Test
    public void TestGetSumOfFloatArray() {
        float expect = 210.0f;
        float fact = inst.getSumOfFloatArray();
        Assert.assertEquals(expect, fact, 0);
    }
}
