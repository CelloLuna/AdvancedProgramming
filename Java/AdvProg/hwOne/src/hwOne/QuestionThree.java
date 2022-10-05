package hwOne;

import java.util.Scanner;

public class QuestionThree {

	public static void main(String[] args) {
		//Create a Java program to accept Pound as input from user and convert it to Ounce.
		Scanner userInput = new Scanner(System.in);
		System.out.println("Pounds to Ounces");
		
		System.out.print("Enter Pounds: ");
		int lbNum = userInput.nextInt();
		int calculation = lbNum * 16;
		
		System.out.println(lbNum + " pounds is " + calculation + " ounces");
	}

}
