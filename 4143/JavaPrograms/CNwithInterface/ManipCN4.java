public class ManipCN4
{

/*  This program will add two complex numbers, storing the result in
    a third and print out the result  */


  public static void main (String[] args)
  {
    //construct complex numbers
    ComplexNumber  c1 = new ComplexNumber(5.1, 3.2);
    ComplexNumber  c2 = new ComplexNumber (1, 2);
    ComplexNumber  c3 = new ComplexNumber ();
       
    //Add c1 and c2
    c3 = AddComplexNumbers (c1, c2);
      
    //print result
    PrintComplexNumber (c3 );

  }


  public static ComplexNumber AddComplexNumbers (ComplexNumber c1, ComplexNumber c2)
  {  ComplexNumber  c3 = new ComplexNumber();
     c3.SetRealPart (c1.GetRealPart() + c2.GetRealPart());
     c3.SetImagPart (c1.GetImagPart() + c2.GetImagPart());
     return c3;
  }

  public static void PrintComplexNumber (ComplexNumber c3 )
  {
    System.out.println (c3.GetRealPart() + " + "+ c3.GetImagPart()+ "i");
  }
}
