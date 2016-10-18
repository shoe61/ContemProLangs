public class prog3Test {

public static void main (String [] args) {
  
  int score;
  Person [] people = new Person[3];
  
  //database of potential dates  
  people[0] = new Date ("Sarah", 65);
  people[1] = new Date ("Mary", 66);
  people[2] = new Date ("Patty", 62);
  
  //desired characteristic in date
  Person dateTarget = new Date ("", 66);
  
  //see how close person 1 matches date target
  score = people[1].getMatchScore (dateTarget);
  System.out.println ("Score is " + score);
  
  //database of potential buddies 
  people[0] = new Buddy ("Sarah", "golf");
  people[1] = new Buddy ("Mary", "cooking");
  people[2] = new Buddy ("Patty", "movies");
  
  //user wants to find a buddy  instead with desired common interest
  Person buddyTarget = new Buddy ("", "movies");  
  
  //see how close person 1 matches buddy target
  score = people[1].getMatchScore (buddyTarget);
  System.out.println ("Score is " + score);
  
}

}