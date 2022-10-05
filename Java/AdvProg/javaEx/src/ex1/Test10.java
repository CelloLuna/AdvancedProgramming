package ex1;

	//parameters and arguments

public class Test10 {
	static void bMethod(String fName, String lName, int age) {
		System.out.println(fName + "" + lName );
		System.out.println("Age is: " + age);
	}
	
	public static void main(String[] args) {
		bMethod("Marcello", " Luna", 19);
	}
}
