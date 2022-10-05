package ex1;

	//parameters and arguments

public class Test12 {
	static int add(int num1, int num2) {
		return num1 + num2;
	}
	
	static int sub(int num1, int num2) {
		return num1 - num2;
	}
	
	public static void main(String[] args) {
		int ans = add(10, 20);
		int ans2 = sub(10, 20);
		System.out.println(ans);
		System.out.println(ans2);
	}
}
