import java.util.Scanner;

public class GrussGottWelt 
{

	public static void main(String[] args) 
	{
		// Make a string for comparison and turn it to an array
		String template = new String("TRANQUILLO");
		int[] standard = template.codePoints().toArray();
		
		
		// Prompt user for action
		System.out.println("Gruss Gott Y'all. Please enter a word in Spanish.");
				
		// Get the user's input:
		Scanner palabra = new Scanner(System.in);
		String theWord = palabra.next();
		
		// Make all the letters uppercase if the user didn't
		String workWord = new String(theWord.toUpperCase());
		
		// Use the input:
		System.out.println("Thanks. You entered " + workWord + ".");		
		System.out.println(workWord + " has " + workWord.length() + " letters.");
		
		// Count the code points to determine the length:
		int l = workWord.codePointCount(0, workWord.length());
		System.out.println(workWord + " has " + l + " code points.");
		
		// Determine the third  and last letters in the word
		char third = workWord.charAt(2);
		char last = workWord.charAt(workWord.length() - 1);
		System.out.println("The third letter in " + workWord + " is " + third + ". The last letter"
				+ " is " + last + ".");
		
		// Access by code point index; determine the UTF-16 decimal representation of the character
		int i = 4; // gets the fifth letter
		int idx = workWord.offsetByCodePoints(0, i);
		int copo = workWord.codePointAt(idx);
		System.out.println("The UTF-16 decimal representation of the character in the "
				 + (idx + 1) + " position is: " + copo);
		
		// Turn workWord, a String, into an array of code points, ints
		int[] codePoints = workWord.codePoints().toArray();
		
		// Experiment, see if can insert according to program requirements
		//codePoints[3] = 43;
		
		// print it for inspection:
		System.out.println("The contents of codePoints:");
		
		for(int k = 0; k < codePoints.length; k++)
		{
			if(standard[k] == codePoints[k])
			{
				codePoints[k] = 43;
			}
			
		}
		
		// Change it back to a string
		String newWord = new String(codePoints, 0, codePoints.length);
		
		// And print the mutated string
		System.out.println("The word after insertion of symbols is: " + newWord);
		
		// close the Scanner to keep java happy
		palabra.close();
	}

}
