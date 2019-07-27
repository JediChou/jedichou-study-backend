/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Java7Study.Chapter02.S020401;

public class MultiDimensionArray {
    
    public int student;
    public int subject;
    public int[][] subjectList;
    
    public MultiDimensionArray(String option) {
        switch (option) {
            default:
                this.student = 2;
                this.subject = 3;
                break;
            case "First":
                this.student = 2;
                this.subject = 3;
                break;
            case "Second":
                this.student = 3;
                this.subject = 4;
                break;
        }
        
        subjectList = new int[student][subject];
    }
    
    public void FillSubjectList_First() {
        subjectList[0][0] = 20;
        subjectList[0][1] = 30;
        subjectList[0][2] = 40;
        subjectList[1][0] = 50;
        subjectList[1][1] = 60;
        subjectList[1][2] = 70;
    }
    
    public void FillSubjectList_Second() {
        subjectList[0][0] = 20;
        subjectList[0][1] = 30;
        subjectList[0][2] = 40;
        subjectList[0][3] = 50;
        subjectList[1][0] = 60;
        subjectList[1][1] = 70;
        subjectList[1][2] = 80;
        subjectList[1][3] = 90;
        subjectList[2][0] = 100;
        subjectList[2][1] = 110;
        subjectList[2][2] = 120;
        subjectList[2][3] = 130;
    }
    
    public int getTotal() {
        int sum = 0;
        for(int i = 0; i < student; i++)
            for(int j=0; j < subject; j++)
                sum += subjectList[student][subject];
        return sum;
    }
}
