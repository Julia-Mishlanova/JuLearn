namespace Solution 
{
  public static class SpacesRemover
  {
    public static string NoSpace(string input)
    {
            var strWithoutSpaces = input.Replace(" ", "");
            return strWithoutSpaces;
    }  
  }
}