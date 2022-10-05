package hwOne;

import java.util.Scanner;

public class QuestionSix {

	public static void main(String[] args) {
		//Create a Java program that accepts an integer from user. Output its previous and next value.
		Scanner userInput = new Scanner(System.in);
		System.out.println("Next and Previous Integer");
		
		System.out.print("Enter a Number: ");
		int num = userInput.nextInt();
		int greater = num + 1;
		int less = num - 1;
		
		System.out.println("Previous Value = " + less);
		System.out.println("Next Value = " + greater);

	}

}
