package FirstJavaProject;

import java.util.Scanner;

public class Controller implements IController {
    private int input;
    private final InputScanner _scanner;

    public Controller(Scanner scanner) {
        _scanner = new InputScanner(scanner);
    }

    @Override
    public void displayMainMenu() {
        Menu.display();
    }

    @Override
    public void displaySubMenu() {
        // Get input
        input = _scanner.scanIntInput();

        // Determin chosen math function
        String chosenMathFunctionName = determinMathfunction(input);

        // Display math function sub menu with found function
        Menu.displaySubMenu(chosenMathFunctionName);
    }

    @Override
    public void startCalculation() {
        switch (input) {
            case 1:
                startAddition();
                break;
            case 2:
                startSubtraction();
                break;
            case 3:
                startMultiplication();
                break;
            case 4:
                startDivision();
                break;
            case 5:
                startModulus();
                break;
            case 6:
                toCloseOrNotToClose();
            default:
                break;
        }

    }

    private void startAddition() {
        Menu.displayInputText();

        var inputs = _scanner.multipleInputScan();
        var result = MathFunctions.addition(inputs[0], inputs[1]);

        Menu.displayResult(result);
    }

    private void startSubtraction() {
        Menu.displayInputText();

        var inputs = _scanner.multipleInputScan();
        var result = MathFunctions.subraction(inputs[0], inputs[1]);

        Menu.displayResult(result);
    }

    private void startMultiplication() {
        Menu.displayInputText();

        var inputs = _scanner.multipleInputScan();
        var result = MathFunctions.multiplication(inputs[0], inputs[1]);

        Menu.displayResult(result);
    }

    private void startDivision() {
        Menu.displayInputText();
        var inputs = _scanner.multipleInputScan();
        var result = MathFunctions.division(inputs[0], inputs[1]);

        Menu.displayResult(result);
    }

    private void startModulus() {
        Menu.displayInputText();

        var inputs = _scanner.multipleInputScan();
        var result = MathFunctions.modulus(inputs[0], inputs[1]);

        Menu.displayResult(result);
    }

    private String determinMathfunction(int input) {
        switch (input) {
            case 1:
                return String.valueOf(MathFunction.Addition);
            case 2:
                return String.valueOf(MathFunction.Subraction);
            case 3:
                return String.valueOf(MathFunction.Mulitplication);
            case 4:
                return String.valueOf(MathFunction.Division);
            case 5:
                return String.valueOf(MathFunction.Modulus);
            default:
                return "No match";
        }
    }

    @Override
    public void restart() {
        Menu.resetConsoleMenu();
    }

    @Override
    public boolean toCloseOrNotToClose() {

        if (_scanner.scanIntInput() == 1) {
            return true;
        } else {
            return false;
        }
    }

}

enum MathFunction {
    Addition,
    Subraction,
    Mulitplication,
    Division,
    Modulus
}
