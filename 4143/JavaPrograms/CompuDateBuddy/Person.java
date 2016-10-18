public  abstract class Person implements IPerson {

public Person () {
   name = "Jane";
}

public Person (String newName) {
  name = newName;
}

public String getName() {return name;}
public void setName(String newName)  {name = newName;}

public abstract int getMatchScore (Person target);

private String name;
}