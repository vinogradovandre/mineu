using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine(GetPrettyDate(DateTime.Now.AddMinutes(-45)));
    }

    public static string GetPrettyDate(DateTime dt)
    {
        // Assuming 'GetPrettyDate' returns a date in the format "March 22, 2024, at 5:00 PM"
        return dt.ToString("MMMM dd, yyyy, 'at' h:mm tt");
    }
}
