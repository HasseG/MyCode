package FirstJavaProject;

import java.util.Scanner;

class Main {

    public static void main(String[] args) {

        // Setting up variables for scanner and inputs
        boolean running = true;
        Scanner scanner = new Scanner(System.in);
        Controller controller = new Controller(scanner);

        while (running) 
        {
            controller.displayMainMenu();
            controller.displaySubMenu();
            controller.startCalculation();
            
        }

    }
}