public static class TwoFer
{
    // In order to get the tests running, first you need to make sure the Speak method 
    // can be called both without any arguments and also by passing one string argument.
    public static string Speak()
    {
         return $"One for you, one for me.";
        throw new NotImplementedException("You need to implement this method.");
    }
    public static string Speak(string str)
    {
       string s= $"One for {str}, one for me.";
        return s;
        throw new NotImplementedException("You need to implement this method.");
    }
}
