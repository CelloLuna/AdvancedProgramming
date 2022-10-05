package hwOne;

import java.util.Scanner;

public class QuestionFour {

	public static void main(String[] args) {
		//Create a Java program to accept Megabyte as input from user and convert it to Kilobyte.
		Scanner userInput = new Scanner(System.in);
		System.out.println("Megabytes to Kilobytes");
		
		System.out.print("Enter the MB: ");
		int mbNum = userInput.nextInt();
		int calculation = mbNum * 1000;
		
		System.out.println(mbNum + " mb is " + calculation + " kb");
	}

}
