package hwOne;

import java.util.Scanner;

public class QuestionTwo {

	public static void main(String[] args) {
		//Create a Java program to accept Hour as input from user and convert it to Seconds.
		Scanner userInput = new Scanner(System.in);
		System.out.println("Hours To Seconds");
		
		System.out.print("Enter Hours: ");
		int hourNum = userInput.nextInt();
		int calculation = hourNum * 3600;
		
		System.out.println(hourNum + " hours is " + calculation + " seconds.");
	}

}
