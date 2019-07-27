package jedi.array;

/**
 * Give an example for for each loop.
 * @author Jedi Chou. skyzhx@163.com
 */
public class ForEachLoop {
    
    /**
     * Get a ForEach loop output.
     * @return ForEach loop result.
     */
    public String GetForEachOutput() {
        String[] strArr = {"Jedi", "Becky", "CiCi"};
        String str = "";
        for (String elt : strArr)
            str += elt + ", ";
        return str;
    }
    
}
