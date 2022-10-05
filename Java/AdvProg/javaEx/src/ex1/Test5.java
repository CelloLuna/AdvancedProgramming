package ex1;

public class Test5 {

	public static void main(String[] args) {
		// multidimensional array is an array of arrays
		
		String [] [] name = {{"A", "B", "C", "D"},{"A1", "B1", "C1", "D1"}};
		
		/*
		 * String n1 = name[1][2]; String n2 = name[0][1]; System.out.println(n1);
		 * System.out.println(n2);
		 */
		
		
		for(int i = 0; i < name.length; i++) 
		{
			for (int x = 0; x < name[i].length; ++x) 
			
			{
				System.out.println(name[i][x]);
			}
		}
	}

}
