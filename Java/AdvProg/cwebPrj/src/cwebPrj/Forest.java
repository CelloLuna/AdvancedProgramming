package cwebPrj;

import java.util.Scanner;

public class Forest {

	public static void main(String[] args) {
		/*
		JavaOperators a = new JavaOperators();
		System.out.println(a.num);
		
		JavaVariables b = new JavaVariables();
		System.out.println(b.myFloat);
		System.out.println(b.myNum);
		System.out.println(b.myChar);
		System.out.println(b.myBool);
		System.out.println(b.myStr);
		
		HelloWorld c = new HelloWorld();
		System.out.println(c.helloWorld);
		
		Casting d = new Casting();
		System.out.println(d.myDouble1);
		System.out.println(d.myInt3);
		
		 //create scanner object 
		Scanner myInput = new Scanner(System.in);
		 System.out.println("Enter a Name"); //read user input 
		 String fName = myInput.nextLine();
		 System.out.println("Name is " + fName);
		
		System.out.println("Operators testing");
		
		System.out.println(a.Division);
		
		System.out.println("String Testing");
		JavaStrings s1 = new JavaStrings();
		
		System.out.println(s1.name.length());
		System.out.println(s1.name.toUpperCase());
		System.out.println(s1.name.toLowerCase());
		System.out.println(s1.name.indexOf('l'));
		System.out.println(s1.fName.concat(s1.lName));
		
		System.out.println(s1.a + s1.b);
		System.out.println(c);
		System.out.println(s1.vikings);
		System.out.println(s1.vikings1);
		
		System.out.println(s1.txt);
		System.out.println(s1.txt2);
		System.out.println(s1.txt3);
		System.out.println(s1.txt4);
		
		System.out.println("\nMath Testing");
		MathTest m1 = new MathTest();
		System.out.println(m1.sq);
		
		System.out.println(m1.random1);
		
		*/
		
		//boolean operators
		System.out.println("Boolean Values");
		boolean isJava = true;
		boolean isHtml = false;
		System.out.println(isJava);
		System.out.println(isHtml);
		
		int x = 100;
		int y = 150;
		System.out.println(x > y);
		System.out.println(x < y);
		System.out.println(x == y);
		System.out.println(x != y);
		
		if (x > y) {
			System.out.println("x is bigger than y");
		} else {
			System.out.println("x is not bigger than y");
		}
		
		x = 10;
		y = 10;
		
		if (x > y) {
			System.out.println("x is bigger than y");
		} else if (x == y) {
			System.out.println("x is equal to y");
		} else {
			System.out.println("x is not bigger than y");
		}
		
		//short hand if else
		int num1 = 100;
		String r = (num1 > 200) ? "num1 is greater than 200"  : "num 1 is not greater than 200";
		System.out.println(r);
		
		//switch statement
		
		int month = 8;
		String monthString;
		
		switch (month) {
		case 1:
			monthString = "January";
			break;
		case 2:
			monthString = "February";
			break;
		case 3:
			monthString = "March";
			break;
		case 4:
			monthString = "April";
			break;
		case 5:
			monthString = "May";
			break;
		case 6:
			monthString = "June";
			break;
		case 7:
			monthString = "July";
			break;
		case 8:
			monthString = "August";
			break;
		case 9:
			monthString = "September";
			break;
		case 10:
			monthString = "October";
			break;
		case 11:
			monthString = "Novemeber";
			break;
		case 12:
			monthString = "December";
			break;
			
		default : 
			monthString = "Invalid Month";
			break;
		}
		System.out.println(monthString);
		
		//while loop
		
		int i = 0;
		while (i < 10){
			System.out.println(i);
			i++;
		}
		i = 10;
		
		do {
			System.out.println(i);
			i++;
		} while (i < 100);
		
		//for loop
		
		for(i = 0; i <10; i++) {
			System.out.println(i);
		}
		
		//for each loop
		String name[] = {"amalan1", "amalan2", "amalan3"};
		
		for(String input :name) {
			System.out.println(input);
		}
	}

}
