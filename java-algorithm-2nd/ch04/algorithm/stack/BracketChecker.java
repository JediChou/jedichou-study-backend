package ch04.algorithm.stack;

public class BracketChecker {

    private String input;

    public BracketChecker(String in) {
        input = in;
    }

    public String check() {
        int stackSize = input.length();
        StackX2 theStack = new StackX2(stackSize);
        String result = "";

        for (int j = 0; j < input.length(); j++) {
            char ch = input.charAt(j);
            switch (ch) {
                case '{':
                case '[':
                case '(':
                    theStack.push(ch);
                    break;
                case '}':
                case ']':
                case ')':
                    if (!theStack.isEmpty()) {
                        char chx = theStack.pop();
                        if ((ch == '}' && chx != '{')
                                || (ch == ']' && chx != '[')
                                || (ch == ')' && chx != '(')) {
                            result = "Error1: " + ch + " at " + j;
                        }
                    } else {
                        result = "Error2: " + ch + " at " + j;
                    }
                    break;
                default:
                    // no action on other charactes
                    break;
            }
        }

        // at this point, all character have been processed
        if (!theStack.isEmpty())
            result = "Error3: missing right delimiter.";

        return result;
    }
}
