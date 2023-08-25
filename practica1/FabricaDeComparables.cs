using System;

	public abstract class FabricaDeComparables
	{
		protected static Random rnd = new Random();
		protected static string[] _NOMBRES_ = {"Juan   ", "Pablo  ", "Pedro  ", "Jose   ", "Alberto", "Maria  " , "Ana    ", "Carla  ", "Marta  ", "Laura  " };
		
		public abstract Comparable crearAleatorio();
		public abstract Comparable crearAleatorio(EstrategiaDeComparacion e);
		
		public static Comparable crearAleatorio(Producto producto)
		{
			FabricaDeComparables fabrica = null;
			
			switch(producto.getTipo().ToUpper())
			{
				case "NUMERO":
					{
						fabrica = new FabricaDeNumeros();
						break;
					}
				case "PERSONA":
					{
						fabrica = new FabricaDePersonas();
						break;
					}
				case "ALUMNO":
					{
						fabrica = new FabricaDeAlumnos();
						break;
					}
			}
			
			if(producto.hayEstrategia())
			{
				return fabrica.crearAleatorio(producto.getEstrategia());
			}
			else 
			{
				return fabrica.crearAleatorio();
			}
		}
		
		public abstract Comparable crearPorTeclado();
		public abstract Comparable crearPorTeclado(EstrategiaDeComparacion e);
		
		public static Comparable crearPorTeclado(Producto producto)
		{
			FabricaDeComparables fabrica = null;
			
			switch(producto.getTipo().ToUpper())
			{
				case "NUMERO":
					{
						fabrica = new FabricaDeNumeros();
						break;
					}
				case "PERSONA":
					{
						fabrica = new FabricaDePersonas();
						break;
					}
				case "ALUMNO":
					{
						fabrica = new FabricaDeAlumnos();
						break;
					}
					
			}
			
			if(producto.hayEstrategia())
			{
				return fabrica.crearPorTeclado(producto.getEstrategia());
			}
			else 
			{
				return fabrica.crearPorTeclado();
			}
		}
		
	}
