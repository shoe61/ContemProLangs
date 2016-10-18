public class ManipCN
{

/*  This program will add two complex numbers, storing the result in
    a third and print out the result  */


  public static void main (String[] args)
  {
    //construct complex numbers
    ComplexNumber  c1 = new ComplexNumber (5.1, 3.2);
    ComplexNumber  c2 = new ComplexNumber (1, 2);
    ComplexNumber  c3 = new ComplexNumber();
       
    //Add c1 and c2
    c3.AddComplexNumbers (c1, c2);
      
    //print result
    c3.PrintComplexNumber ( );

  }
}


//CLASS declaration
class ComplexNumber
{
  public ComplexNumber ( )
  {  realPart = 0;
     imagPart = 0;  
  }

  public ComplexNumber (double r, double i)
  {
     realPart = r;
     imagPart = i;
  }

  public double GetRealPart ( )
  {  return realPart;
  }

  public double GetImagPart ( )
  {  return imagPart;
  }

  public void SetRealPart (double r)
  {
     realPart = r;
  }

  public void SetImagPart (double i)
  {
     imagPart = i;
  }

  public void PrintComplexNumber ( )
  {
    System.out.println (realPart + " + "+ imagPart+ "i");
  }

  public void AddComplexNumbers (ComplexNumber c1, ComplexNumber c2)
  {
     realPart = c1.GetRealPart() + c2.GetRealPart();
     imagPart = c1.GetImagPart() + c2.GetImagPart();
  }


  private double realPart;
  private double imagPart;
}
