public  class Date extends Person{

public Date () {
   super();
   score = 0;
   height = 66;
}

public Date (String newName,  int newHt) {
   super(newName);
   score = 0;
   height = newHt;
}

public int getHeight () {return height;}
public void setHeight (int newHt) {height = newHt;}

public int getMatchScore (Person target) {
  if (height == ((Date)target).getHeight())
     score ++;
  return score;
}

private int score;
private int height;

}