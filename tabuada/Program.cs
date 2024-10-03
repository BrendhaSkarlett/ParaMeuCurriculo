﻿using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Informe um número: ");
		if (int.TryParse(Console.ReadLine(), out int n))
		{
			Console.Write("Escolha a operação a ser utilizada (+  -  *  /): ");
				string operador = Console.ReadLine();
				for (int i = 1; i <=10; i++)
			{
				switch(operador)
				{
					case"+":
						double resultado = n + i;
						Console.WriteLine(n + "+" + i + "=" + resultado);
						break;
					case"-":
						resultado = n - i;
						Console.WriteLine(n + "-" + i + "=" + resultado);
						break;
					case"*":
						resultado = n * i;
						Console.WriteLine(n + "*" + i + "=" + resultado);
						break;
					case"/":
						resultado = n / i;
						Console.WriteLine(n + "/" + i + "=" + resultado);
						break;
					default:
						Console.WriteLine("Operação Inválida");
						break;
				}
			}
		}
		else
		{
			Console.WriteLine("Número Inválido");
		}
	}
}


