package bdayCalculation;

import java.util.Scanner;
import java.time.LocalDate;

public class calculation {

	public static void main(String[] args) {
		
		Scanner input = new Scanner(System.in);
		System.out.println("What is your first name: ");
		String fName = input.nextLine();
		
		System.out.println("What is your last name: ");
		String lName = input.nextLine();
		
		System.out.println("What year were you born");
		int year = input.nextInt();
		
		System.out.println("Hello, " + fName + " " + lName + "!");
		
		LocalDate date = LocalDate.now();
		int currentYear = date.getYear();
		
		int age = currentYear - year;
		
		System.out.println("This year you will be " + age);
		
		int fAge = age + 5;
		
		System.out.println("In 5 years you will be " + fAge);

	}

}
