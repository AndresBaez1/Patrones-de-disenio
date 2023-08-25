using System;

	public abstract class FabricaDeComparables
	{		
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
				case "VENDEDOR":
					{
						fabrica = new FabricaDeVendedores();
						break;
					}
				case "ALUMNOMUYESTUDIOSO":
					{
						fabrica = new FabricaDeAlumnosMuyEstudiosos();
						break;
					}
				case "PROXYALUMNO":
					{
						fabrica = new FabricaDeProxysAlumno("Alumno");
						break;
					}
				case "PROXYALUMNOMUYESTUDIOSO":
					{
						fabrica = new FabricaDeProxysAlumno("AlumnoMuyEstudioso");
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
				case "VENDEDOR":
					{
						fabrica = new FabricaDeVendedores();
						break;
					}
				case "ALUMNOMUYESTUDIOSO":
					{
						fabrica = new FabricaDeAlumnosMuyEstudiosos();
						break;
					}
				case "PROXYALUMNO":
					{
						fabrica = new FabricaDeProxysAlumno("Alumno");
						break;
					}
				case "PROXYALUMNOMUYESTUDIOSO":
					{
						fabrica = new FabricaDeProxysAlumno("AlumnoMuyEstudioso");
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
