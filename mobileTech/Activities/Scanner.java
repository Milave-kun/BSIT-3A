import java.util.scanner;

public class InputScanner {
    public static void main (String[] args){
      Scanner scan = new Scanner(System.in)

      // user input name
      System.out.print("Enter your Name: ");
      // Read line of text and store it in a variable
      String name = scan.nextLine();
      
      // user input age
      System.out.print("Enter your Age: ");
      // Read an integer and store it in a variable
      int age = scan.nextInt();

      // Display the user Input
      System.out.println("Hello, " + name + "!\nYou are " + age + "years old.");

      // close the scanner
      scan.close();
    }
}
