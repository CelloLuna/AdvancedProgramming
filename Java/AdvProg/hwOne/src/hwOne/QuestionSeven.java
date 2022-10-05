package hwOne;

import java.util.Scanner;

public class QuestionSeven {

	public static void main(String[] args) {
		//Create a Java program to count the number of characters in your name.
		Scanner userInput = new Scanner(System.in);
		System.out.println("Count the Characters in your name");
		
		System.out.print("Enter your first name: ");
		String fName = userInput.nextLine();
		
		System.out.print("Enter your middle name: ");
		String mName = userInput.nextLine();
		
		System.out.print("Enter your last name: ");
		String lName = userInput.nextLine();
		
		int fLength = fName.length();
		int mLength = mName.length();
		int lLength = lName.length();
		
		System.out.println("Your first name is " + fLength + " characters long");
		System.out.println("Your middle name is " + mLength + " characters long");
		System.out.println("Your last name is " + lLength + " characters long");
	}

}
