package ch02.algorithm;

public class Person {

    private String lastName;
    private String firstName;
    private int age;

    public Person(String last, String first, int a) {
        lastName = last;
        firstName = first;
        age = a;
    }

    public void displayPerson() {
        System.out.println(getPersonInfo());
    }

    public String getLast() {
        return lastName;
    }
    
    /*
     * help method 1 - get Person information
     */
    public String getPersonInfo() {
        return "Last name: " + lastName + 
                ", First name: " + firstName +
                ", Age: " + age;
    }
    
    /* 
     * help method 2 - get firstname
     */
    public String getFirst() {
        return firstName;
    }
    
    /*
     * help method 3 - get age
     */
    public int getAge() {
        return age;
    }
}
