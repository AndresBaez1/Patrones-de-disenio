using System;

	public class FabricaDeNumeros: FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new Numero(rnd.Next(100));
		}
		
		public override Comparable crearAleatorio(EstrategiaDeComparacion e)
		{
			return this.crearAleatorio(); //Debe setear estrategia de comparacion cuando lo requiera
		}
		
		public override Comparable crearPorTeclado()
		{
			Console.Write("Ingrese un numero: ");
			return (new Numero(int.Parse(Console.ReadLine())));
		}
		
		public override Comparable crearPorTeclado(EstrategiaDeComparacion e)
		{
			return this.crearPorTeclado(); //Debe setear estrategia de comparacion cuando lo requiera
		}
	}

