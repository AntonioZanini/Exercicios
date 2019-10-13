using System;
using System.Linq;
using System.Text.RegularExpressions;
public class Program
{
    public static void Main()
    {
        const string pattern = @"^[a-zA-Z]+$";
        var regEx = new Regex(pattern);
        Console.WriteLine("Cifra de César");
        Console.Write("Insira a frase: ");
        string frase = Console.ReadLine();
        Console.Write("Insira a chave: ");
        Int32 chave = 0;
        Int32.TryParse(Console.ReadLine(), out chave);
        if (chave >= 26) chave = chave % 26;
        var arrayFrase = frase.ToCharArray();
        for(int i=0; i<arrayFrase.Length; i++)
        {
            if (regEx.IsMatch(arrayFrase[i].ToString())) 
            {
                int valChar = Convert.ToInt32(arrayFrase[i]);
                int retorno = 0;
                if (!regEx.IsMatch(Convert.ToChar(valChar + chave).ToString())) retorno = -26;
                arrayFrase[i] = Convert.ToChar(valChar + chave + retorno);
            }
        }
        string codigo = new string(arrayFrase);
        Console.WriteLine(Environment.NewLine + "Codigo: " + codigo);
    }
}