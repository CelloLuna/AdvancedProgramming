package questions;
import java.util.Scanner;
import java.util.Arrays;

public class Question2 {

	public static void main(String[] args) {
		Scanner input = new Scanner(System.in);
		
		System.out.print("Number of words to build: ");
		int num = input.nextInt();
		String[] words = new String[num];

		
		for (int i = 1; i <= num; i++) {
			
			System.out.print("Enter word " + i + ": ");
			String word = input.next();
			words[i - 1] = word; 
			
		}
			
		System.out.print("Word Builder Result = ");
		for (int i = 0; i < num; i++) {
			System.out.print(words[i] + " ");
		}
		System.out.println("\nDONE!!");
		input.close();
	}
}
