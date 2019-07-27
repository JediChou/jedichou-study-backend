package com.wrox.algorithms.iteration;

import java.io.File;

/**
 * @author F3216338
 * @version 0.0.1
 */
public final class RecursiveDirectoryTreePrinter {

    private static final String SPACES = "  ";

    public static void main(String[] args) {
        assert args != null : "args can't be null";

        if (args.length != 1) {
            System.out.println("Usage: RecurisiveDirectoryTreePrinter <dir>");
            System.exit(4);
        }
    }

    public static void print(File file, String indent) {
        assert file != null : "file can't be null";
        assert indent != null : "indent can't be null";

        System.out.print(indent);
        System.out.println(file.getName());

        if (file.isDirectory()) {
            print(file.listFiles(), indent + SPACES);
        }
    }

    public static void print(File[] files, String indent) {
        assert files != null : "file can't be null";

        for (int i = 0; i < files.length; ++i) {
            print(files[i], indent);
        }
    }
}