package questions;

public class Question1 {

	public static void main(String[] args) {
		String [] devices = {"Keyboard", "Monitor", "Printer", "Server"};
		
		for(int i = 0; i < devices.length; i++) {
			System.out.println("Element at index " + i + ":" + devices[i] + " | " + devices[i].length() +  "chars");
		}
	}

}
