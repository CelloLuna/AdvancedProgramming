package hwOne;

import java.util.Scanner;

public class QuestionOne {
	//Create a Java program to accept Mile input from user and convert it to Kilometer.
	public static void main(String[] args) {
		
		Scanner userInput = new Scanner(System.in);
		System.out.println("Miles to Kilometers");
		
		System.out.print("Choose Miles: ");
		double mileNum = userInput.nextDouble();
		double calculation = (double)(mileNum * 1.60934);
		
		System.out.println(mileNum + " miles is " + calculation + " kilometers");
		
	}
	
}
