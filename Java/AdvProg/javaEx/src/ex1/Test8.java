package ex1;
import java.time.LocalDateTime;
import java.time.format.DateTimeFormatter;
public class Test8 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		LocalDateTime aObj = LocalDateTime.now();
		System.out.println(aObj);
		
		DateTimeFormatter bObj = DateTimeFormatter.ofPattern("dd/MM/yyyy hh:mm:ss");
		String fdate = aObj.format(bObj);
		System.out.println(fdate);
		
	}

}
