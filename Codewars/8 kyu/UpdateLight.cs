public class Kata
{
    public static string UpdateLight(string current)
    {
        if(current == "green") return "yellow";
        if(current == "yellow") return "red";
        if(current == "red") return "green";
        return "";
    }
}