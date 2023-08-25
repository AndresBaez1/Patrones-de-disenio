//Ejercicio9 practica3

using System;

	public class FabricaDeVendedores: FabricaDeComparables
	{
		double _SUELDO_BASICO_ = 150000;
		
		public override Comparable crearAleatorio()
		{
			GeneradorDeDatosAleatorios dato = new GeneradorDeDatosAleatorios();
			
			return new Vendedor(dato.stringAleatorio(6), dato.numeroAleatorio(99999999), _SUELDO_BASICO_ );
		}
		
		public override Comparable crearAleatorio(EstrategiaDeComparacion e)
		{
			return this.crearAleatorio();	//Debe setear estrategia de comparacion cuando lo requiera
		}
		
		public override Comparable crearPorTeclado()
		{
			int dni;
			string nombre;
			
			Console.Write("Ingrese un numero de dni: ");
			dni = int.Parse(Console.ReadLine());
			
			Console.Write("Ingrese un nombre: ");
			nombre = Console.ReadLine();
			return (new Vendedor(nombre, dni, _SUELDO_BASICO_ ));
		}
		
		public override Comparable crearPorTeclado(EstrategiaDeComparacion e)
		{
			return this.crearPorTeclado(); //debe setear estrategia de comparacion cuando lo requiera
		}
		
	}

