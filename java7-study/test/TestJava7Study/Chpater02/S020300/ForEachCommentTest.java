package TestJava7Study.Chpater02.S020300;

import org.junit.Test;
import static org.junit.Assert.*;
import Java7Study.Chapter02.S020300.*;

public class ForEachCommentTest {

    ForEachComment _instance;
    
    public ForEachCommentTest() {
        _instance = new ForEachComment();
    }
    
    @Test
    public void TestForEechComment() {
        int[] first = _instance.getIntArray_First(10);
        int[] second = _instance.getIntArray_Second(10);
        assertEquals(first.length, second.length);
    }
    
    @Test
    public void TestForEachComment_Concat() {
        int[] first = _instance.getIntArray_First(10);
        int[] second = _instance.getIntArray_Second(10);
        String strFirst = "";
        String strSecond = "";
        for(int elt: first) strFirst += "" + elt;
        for(int elt: second) strSecond += "" + elt;
        assertEquals(strFirst, strSecond);
    }
}