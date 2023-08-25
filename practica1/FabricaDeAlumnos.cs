using System;

	public class FabricaDeAlumnos: FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			return new Alumno(_NOMBRES_[rnd.Next(0,9)], rnd.Next(10000000, 99999999), rnd.Next(10000,99999), rnd.Next(0,10));
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

