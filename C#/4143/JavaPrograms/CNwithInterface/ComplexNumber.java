public class ComplexNumber implements CNInterface
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


  private double realPart;
  private double imagPart;
}