//ejercicio3 practica3
using System;

	public class LectorDeDatos
	{
		public LectorDeDatos()
		{
		}
		
		public int numeroPorTeclado()
		{
			Console.Write("Ingrese un numero: ");
			
			return (int.Parse(Console.ReadLine()));
		}
		
		public string stringPorTeclado()
		{
			Console.Write("Ingrese una palabra: ");
			
			return (Console.ReadLine());
		}
	}

