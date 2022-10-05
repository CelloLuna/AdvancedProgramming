package questions;
import java.util.Scanner;

public class Question3 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		System.out.print("Number of names to process: ");
		int num = input.nextInt();
		String[] names = new String[num];

		
		for (int i = 1; i <= num; i++) {
			
			System.out.print("Enter the name " + i + ": ");
			String name = input.next();
			names[i - 1] = name; 
			
		}
		
		System.out.println("\nNames stored in Array: ");
		for (int i = 0; i < num; i++) {
			System.out.println("Element at index " + i + ": " + names[i]);
		}
		input.close();

	}

}
