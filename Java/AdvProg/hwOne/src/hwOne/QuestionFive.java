package hwOne;

import java.util.Scanner;

public class QuestionFive {

	public static void main(String[] args) {
		//Create a Java program to accept Mile per hour as input from user and convert it to Meter per second.
		Scanner userInput = new Scanner(System.in);
		System.out.println("Mile per hour to Meter per second");
		
		System.out.print("Enter the Speed in mile per hour: ");
		double mph = userInput.nextDouble();
		double calculation = mph * 0.44704;
		
		System.out.println(mph + " Miles per hour is " + calculation + " meters per second");

	}

}
