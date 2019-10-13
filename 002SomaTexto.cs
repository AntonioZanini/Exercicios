using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main(string[] args)
    {
        if (args.Length == 0) {
            Console.WriteLine("Parâmetro ausente.");
            return;
        }
        string fileName = args[0];
        var numerosLidos = ColetaNumerosArquivo(fileName); 
        if (numerosLidos.Count() > 0) {
            Console.WriteLine("Soma = " + numerosLidos.Sum());
        }
        else {
            Console.WriteLine("Sem números válidos.");
        }
    }

    public static IEnumerable<Int32> ColetaNumerosArquivo(string path)
    {
        List<Int32> listaNumeros = new List<Int32>();
        try
        {
            using (StreamReader file = new StreamReader(path)) {
                Int32 numLido;
                string line;
                do {
                    line = file.ReadLine();
                    if (Int32.TryParse(line, out numLido)) listaNumeros.Add(numLido);
                } while (line != null);
            }
        }
        catch (Exception e) 
        {
            Console.WriteLine("Erro na leitura do arquivo!");
            Console.WriteLine(e.Message);
        }
        return listaNumeros;
    }
}