package org.academiadecodigo.stringrays.missing_char;

public class MissingChar {
    public static void main(String[] args) {

        missingChar("Robocop", 5);




    }

    private static void missingChar(String string, int n) {

        //Robocop
        //0123456

        //Select all the chars till the chosen one, excluding it
        String firstHalf = string.substring(0, n);

        //Select all chars from the first after the chosen one
        // "cop"
        String lastHalf = string.substring(n + 2);

        System.out.println(firstHalf + lastHalf);
    }

}
