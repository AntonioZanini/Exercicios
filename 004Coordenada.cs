using System;
using System.Linq;
public class Program
{
    public static void Main()
    {
        int[,] tabuleiro = new int[8,8];
        string titulo = "Coordenadas";
        char continuar;
        for (int x=0; x<8; x++){
            for (int y=0; y<8; y++) tabuleiro[x,y] = (y + (8 * x) + 1);
        }
        do
        {
            try
            {
                Console.Clear();
                Console.WriteLine(new String(' ', 5) + string.Join(" ", titulo.ToUpper().ToCharArray())+Environment.NewLine);
                Console.Write(new String(' ', 5) + String.Join(" ", Enumerable.Range(1,8).Select(n => n.ToString("D2"))));
                Console.WriteLine(Environment.NewLine + new String(' ', 5) + new String('-', 23));
                for (int x=0; x<8; x++){
                    Console.Write(String.Format(" {0} | ", Convert.ToChar(x+65)));
                    for (int y=0; y<8; y++) 
                    {
                        tabuleiro[x,y] = (y + (8 * x) + 1);
                        Console.Write(tabuleiro[x,y].ToString("D2") + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                Console.WriteLine("Insira suas Coordenadas");
                Console.Write("Letra da Linha: ");
                int coordX = Convert.ToInt32(Char.ToUpper(Console.ReadKey().KeyChar))- 65;
                Console.Write(Environment.NewLine + "Número da Coluna: ");
                int coordY = Convert.ToInt32(Char.ToUpper(Console.ReadKey().KeyChar)) - 49;
                Console.Write(Environment.NewLine + "O número desta posição é: " + tabuleiro[coordX,coordY].ToString("D2"));                
            }
            catch (IndexOutOfRangeException)
            {
                Console.Write(Environment.NewLine + "Coordenadas Inválidas!");
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }
            finally {
                Console.Write(Environment.NewLine + "Continuar(S/N)? ");
                continuar = Char.ToUpper(Console.ReadKey().KeyChar);
            }
        } while (continuar == 'S');
    }
}