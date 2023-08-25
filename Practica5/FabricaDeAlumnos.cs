//Ejercicio5 practica3

using System;

	public class FabricaDeAlumnos: FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			GeneradorDeDatosAleatorios dato = new GeneradorDeDatosAleatorios();
			
			return new Alumno(dato.stringAleatorio(6), dato.numeroAleatorio(99999999), dato.numeroAleatorio(99999), dato.numeroAleatorio(10));
		}
		
		public override Comparable crearAleatorio(EstrategiaDeComparacion e)
		{
			Alumno a = (Alumno)this.crearAleatorio();
			a.setEstrategia(e);
			return a;
		}
		
		public override Comparable crearPorTeclado()
		{
			int dni;
			string nombre;
			int legajo;
			double promedio;
			
			Console.Write(" Ingrese un numero de dni: ");
			dni = int.Parse(Console.ReadLine());
			
			Console.Write(" Ingrese un nombre: ");
			nombre = Console.ReadLine();
			
			Console.Write(" Ingrese un legajo: ");
			legajo = int.Parse(Console.ReadLine());
			
			Console.Write(" Ingrese un promedio: ");
			promedio = double.Parse(Console.ReadLine());
			
			return (new Alumno(nombre, dni, legajo, promedio));			
		}
		
		public override Comparable crearPorTeclado(EstrategiaDeComparacion e)
		{		
			Alumno a = (Alumno)crearPorTeclado();
			a.setEstrategia(e);
			return (a);			
		}
	}

