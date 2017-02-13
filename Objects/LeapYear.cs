namespace LeapYear
{
  public  class LeapYear
  {
    public bool IsLeapYear(int number)
    {
      if(number % 400 == 0)
      {
        return true;
      }
      else if (number % 100 == 0)
      {
        return false;
      }
      else
      {
        return number % 4 == 0;
      }
      
    }
  }
}
