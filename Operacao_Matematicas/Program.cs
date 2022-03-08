using System;

namespace Operacao_Matematicas
{
	internal class Program
	{
		static void Main(string[] args)
		{
			
			float numero1, numero2 , operacao , resultado;

			Console.WriteLine("Informe o primeiro : ");

			
			numero1 = Convert.ToInt32(Console.ReadLine());

			
			Console.WriteLine("Informe o segundo numero : ");

			
			numero2 = Convert.ToInt32(Console.ReadLine());

				
			Console.WriteLine("Informe a operação desejada  , soma - 1 ,  substracao - 2 , multiplicacao - 3 ,  divisao - 4 : ");

			
			operacao = Convert.ToInt32(Console.ReadLine());

			if (operacao <= 0 || operacao > 4)
			{

				Console.WriteLine("Por favor na opercao informe um numero de 1 a 4, reinicie o processo");
			}
			else
			{
				if (operacao == 1)
				{
					resultado = numero1 + numero2;
					Console.WriteLine("A soma dos numeros eh {0} ", resultado);
				}
				else
				{
					if (operacao == 2)
					{
						resultado = numero1 - numero2;
						Console.WriteLine("A substracao dos numeros eh {0} ", resultado);
					}

					else
					{
						if (operacao == 3)
						{
							resultado = numero1 * numero2;
							Console.WriteLine("A multiplicacao dos numeros eh {0} ", resultado);
						}

						if (operacao == 4 && numero2 > 0)
						{
							resultado = numero1 / numero2;
							Console.WriteLine("A divisao dos numeros eh {0} ", resultado);
						}
						else
						{
							Console.WriteLine(" O segundo numero na divisao não pode ser 0 ou negativo");
						}
					}
				}
			} 
			Console.ReadLine();
		}


	}
}


