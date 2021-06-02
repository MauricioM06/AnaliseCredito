using System;

namespace Credito
{

    public class Program 
    {
        public static void Main(string [] args)
        {
			double Valor;
			double Meses;
			double Renda;
			double Parcelas;
			double Porcentagem;
			
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("Análise de crédito");
			Console.ResetColor();
			Console.WriteLine();
			
			Console.Write("Insira o empréstimo desejado em R$: ");
			Valor = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Insira sua renda mensal comprovada em R$: ");
			Renda = Convert.ToDouble(Console.ReadLine());
			
			Console.Write("Insira a quantidade de parcelas desejadas: ");
			Meses = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine();
			
			Parcelas = Valor / Meses;
			Porcentagem = Renda * 30 / 100;
			Console.WriteLine();
			
			Console.WriteLine($"O valor das parcelas é de R${Parcelas:N2}");
			Console.WriteLine();
			Console.WriteLine($"30% de sua renda mensal corresponde a R${Porcentagem:N2}");
			Console.WriteLine();
			Console.WriteLine("Nossa empresa somente autoriza empréstimos cujas parcelas não ultrapassem 30% de sua renda mensal comprovada, portanto...");
			Console.WriteLine();
			
			if (Porcentagem >= Parcelas)
			{
				Console.ForegroundColor = ConsoleColor.Green;
				Console.WriteLine("Seu empréstimo foi autorizado.");
				Console.ResetColor();
			}
			else if (Porcentagem < Parcelas)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Seu empréstimo foi negado.");
				Console.ResetColor();
			}
        }
    }
}