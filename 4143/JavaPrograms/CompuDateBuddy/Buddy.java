public  class Buddy extends Person{

public Buddy () {
   super();
   activity = "golf" ; 
   score = 0;
}

public Buddy (String newName,  String newActivity) {
   super(newName);
   activity = newActivity;  
   score = 0;
}

public String getActivity () {return activity;}
public void setActivity (String newActivity) { activity = newActivity;}

public  int getMatchScore (Person target) {
  if (activity.equals(((Buddy) target).activity))
     score ++;
	 return score;
}

private String activity;
private int score;

}