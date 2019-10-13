using System;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		Console.WriteLine("Digite a senha: ");
		string Senha = Console.ReadLine();
		//string Senha = @"6dD#a";
		if (SenhaValida(Senha))
		{
			Console.Write("Senha correta!");
		}
		else
		{
			Console.Write("Senha inválida!");
		}
	}
	
	private static bool SenhaValida(string Senha)
	{
		string Pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&#])[A-Za-z\d@$!%*?&#]{5,10}$";
		/*
			O padrão de expressão regular que especifica:
			(?=.*[a-z]) 		- Deve conter ao menos um caracter entre 'a' e 'z' (letras minusculas);
			(?=.*[A-Z]) 		- Deve conter ao menos um caracter entre 'A' e 'Z' (LETRAS MAIUSCULAS);
			(?=.*\d)    		- Deve conter ao menos um dígito (caractere numérico);
			(?=.*[@$!%*?&#]) 	- Deve conter ao menos um entre os caracteres '[@$!%*?&' (caracteres especiais);
			[A-Za-z\d@$!%*?&#]	- Lista de todos os caracteres permitidos na senha: letras maiúsculas e minúsculas,
								dígitos, e caracteres espeicais. (sem espaço);
			{5,10}				- Definição de tamanho para o padrão, mínimo 5 caracteres, máximo 10 caracteres.
		*/
		var RegExSenha = new Regex(Pattern);
		return RegExSenha.IsMatch(Senha); // Retorna se a senha atende ou não ao padrão definido.
	}
}