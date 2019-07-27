package Java7Study.Chapter02.S020101;

/**
 * 2.1.2 如何创建数组
 * @author jedi
 */
public class DefineArray {
    
    final int DASize = 20;
    
    /**
     * 获取一个整数数组
     * @return 整数数组
     */
    public int[] getIntNumberArray() {
        int[] numbers = new int[10];
        return numbers;
    }
    
    /**
     * 获取一个浮点数数组
     * @return 浮点数数组
     */
    public float[] getFloatNumberArray() {
        float[] numbers = new float[10];
        return numbers;
    }
    
    /**
     * 使用final字段初始化数组
     * @return 
     */
    public float[] getDasizeFloatArray() {
        float[] numbers = new float[DASize];
        return numbers;
    }
    
    /**
     * 获取数组元素的Sum值
     * @return 
     */
    public float getSumOfFloatArray() {
        float[] numbers = new float[DASize];
        float sum = 0.0f;
        
        // initialize elements
        for (int i=0; i < DASize; i++) {
            numbers[i] = (float) i+1;
        }
        
        // get sum
        for (int i=0; i < DASize; i++) {
            sum += numbers[i];
        }
        
        return sum;
    }
}
