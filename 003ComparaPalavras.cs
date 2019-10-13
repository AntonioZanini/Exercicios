using System;
using System.Text.RegularExpressions;
using System.Linq;
public class Program
{
    public static void Main()
    {
        Console.Write("Digite algumas palavras (no mínimo duas): ");
        string palavras = Console.ReadLine();
        try
        {
            Console.Write("Maior Palavra: " + MaiorPalavra(palavras));
        }
        catch (Exception ex)
        {
            Console.Write(ex.Message);
        }
    }

    private static string MaiorPalavra(string palavras)
    {
        try
        {
            if (palavras.Contains(" ") == false) throw new Exception("Adicionar mais palavras");
            string pattern = @"^[a-zA-Z]+$";
            var regEx = new Regex(pattern);
            foreach (var pl in palavras.Split(' ').Where(p => regEx.IsMatch(p))) Console.WriteLine(pl + " - " + regEx.IsMatch(pl).ToString());
            return palavras.Split(' ').Where(p => regEx.IsMatch(p)).OrderByDescending(p => p.Length).FirstOrDefault();
        }
        catch
        {
            throw;
        }
    }
}