package edu.mwsu;

/** A Complex Number is a number that consists of a two parts, a 
real number part and an imaginary part.
*/

public class ComplexNumber
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

  /**  Sets the real part of a complex number.
  @param r the real number by which to set the real number part of the 
           complex number
  @ return nothing
  */
  public void SetRealPart (double r)
  {
     realPart = r;
  }

  public void SetImagPart (double i)
  {
     imagPart = i;
  }

  public void PrintComplexNumber()
  {
	  System.out.println(realPart + " + " + imagPart + "i");
  }

  public void AddComplexNumbers(ComplexNumber c1, ComplexNumber c2)
  {
	  realPart = c1.GetRealPart() + c2.GetRealPart();
	  imagPart = c1.GetImagPart() + c2.GetImagPart();
  }


  private double realPart;
  private double imagPart;
}