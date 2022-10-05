package ex1;

//Method overloading
public class Test14 {
	static int calc(int num1, int num2) {
		return num1 + num2;
	}
	
	static double calc(double num1, double num2) {
		return num1 - num2;
	}
	
	public static void main(String[] args) {
		int ans = calc(10, 20);
		double ans2 = calc(10.00, 20.00);
		System.out.println(ans);
		System.out.println(ans2);
	}
}
