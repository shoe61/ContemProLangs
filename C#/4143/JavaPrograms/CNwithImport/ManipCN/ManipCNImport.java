import edu.mwsu.*;

public class ManipCNImport
{

/*  This program will add two complex numbers, storing the result in
    a third and print out the result  */


  public static void main (String[] args)
  {
    //construct complex numbers
	  ComplexNumber c1 = new ComplexNumber(5.1, 3.2);
	  ComplexNumber c2 = new ComplexNumber(1, 2);
	  ComplexNumber c3 = new ComplexNumber();
       
    //Add c1 and c2
    c3.AddComplexNumbers (c1, c2);
      
    //print result
    c3.PrintComplexNumber ( );

  }
}


