package FirstJavaProject;

import java.util.Scanner;

public class InputScanner {

    private Scanner scanner;

    public Scanner getScanner()
    {
        return scanner;
    }
    public Scanner setScanner(Scanner scanner)
    {
        return this.scanner = scanner;
    }

    // Scuffed dependency injection
    public InputScanner(Scanner scanner) 
    {
        this.scanner = scanner;
    }
    
    /**Scans for user input and returns as integer*/
    public int scanIntInput()
    {
        var result = scanner.nextLine();
        return Integer.parseInt(result);
    }

    /**Scans for 2 inputs and returns result as integer */
    public int[] multipleInputScan()
    {   
        int x = scanIntInput();

        int y = scanIntInput();

        int[] result = {x,y};

        return result;
    }

}
