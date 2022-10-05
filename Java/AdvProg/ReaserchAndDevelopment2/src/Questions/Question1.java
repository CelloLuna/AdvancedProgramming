package Questions;
import java.util.Scanner;
public class Question1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.println("Question 1");
		
		Scanner input = new Scanner(System.in);
		
		System.out.print("Enter Initial Value: ");
		int num = input.nextInt();
		
		System.out.print("Enter Range: ");
		int range = input.nextInt();
		
		for (int i = 0; i <= range; i++) {
			System.out.println(num);
			num++;
		}
	}

}
