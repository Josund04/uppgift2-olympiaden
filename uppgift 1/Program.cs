using System;

namnspace uppgift_2
{
    class Program
{
    Console.Writeline("Antal ord?");
    Console.ReadLine();                                                                                 
public string Reverse(string text)
{
    char[] cArray = text.ToCharArray();
    string reverse = String.Empty;
    for (int i = cArray.Length - 1; i > -1; i--)
    {
        reverse += cArray[i];
    }
    return reverse;
}
}
}