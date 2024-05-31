package FirstJavaProject;

public class Menu 
{
    
    static public void display()
    {
        System.out.println("   _____      _            _       _             \r\n" + //
                        "  / ____|    | |          | |     | |            \r\n" + //
                        " | |     __ _| | ___ _   _| | __ _| |_ ___  _ __ \r\n" + //
                        " | |    / _` | |/ __| | | | |/ _` | __/ _ \\| '__|\r\n" + //
                        " | |___| (_| | | (__| |_| | | (_| | || (_) | |   \r\n" + //
                        "  \\_____\\__,_|_|\\___|\\__,_|_|\\__,_|\\__\\___/|_|   \r\n" + //
                        "                                                 \r\n" + //
                        "                                                 ");
        
        System.out.println("1. Addition\n2. Subraction\n3. Multiplication\n4. Division\n5. Modulus\n6. Exit\n\nChoose operator:");
    }
    /** Displays the sub meny for given math function*/
    public static void displaySubMenu(String mathFunction)
    {
        var print = "You've chosen " + mathFunction + ":";
        System.out.println(print);
        for (char ch : print.toCharArray())
        {
            System.out.print("-");
        }
    }

    public static void displayInputText()
    {
        System.out.println("\nChoose 2 numbers (press \"Enter\" after each number):");
    }

    public static void displayResult(int result)
    {
        System.out.println("Result of calculation: " + result);
    }

    public static void resetConsoleMenu()
    {
        for(int i = 0; i < 50 ; i++)
        {
            System.out.println("\b");
        }
    }

    public static void displayExitOptions()
    {
        System.out.println("Exit? (1 for yes, 0 for no.)");
    }
}
