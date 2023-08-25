//Ejercicio2 Practica3
using System;

	public class GeneradorDeDatosAleatorios
	{
		private static Random rnd = new Random();
		private const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
		
		public GeneradorDeDatosAleatorios()
		{
			
		}
		public int numeroAleatorio(int minimo, int maximo)
		{
			return ( rnd.Next(minimo, maximo));
		}
		
		public int numeroAleatorio(int maximo)
		{
			return ( rnd.Next(0, maximo));
		}
		
		public string stringAleatorio(int longitud)
		{
			string cadenaAleatoria = "";

        	for (int i = 0; i < longitud; i++)
        	{
            	int indice = rnd.Next(0, alfabeto.Length);
            	cadenaAleatoria = cadenaAleatoria + alfabeto[indice];
        	}
        	
        	return (cadenaAleatoria);
		}
		
	}

