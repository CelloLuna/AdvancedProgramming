package ex1;
import java.util.Date;
public class Test6 {

	public static void main(String[] args) {
		//Date Functions
		Date date = new Date();
		System.out.println(date.toString());
		System.out.printf("%1$s %2$tB %2$td, %2$tY", "Due date: ", date);
	}

}
