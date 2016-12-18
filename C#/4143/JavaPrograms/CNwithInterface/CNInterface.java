public interface CNInterface 
{

  /** Returns the real part of this complex number.
   *  @return real part */
  public double GetRealPart ( );

   /** Returns the imaginary part of this complex number.
   *  @return imaginary part */
   public double GetImagPart ( );

  /** Set the real number part of a complex number
   *  @param  r  a double that is the desired real number part */
  public void SetRealPart (double r);

  /** Set the imaginary number part of a complex number
   *  @param  i a double that is the desired imaginary number part */
  public void SetImagPart (double i);

}