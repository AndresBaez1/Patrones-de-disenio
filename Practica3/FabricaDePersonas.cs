﻿using System;

	public class FabricaDePersonas: FabricaDeComparables
	{
		public override Comparable crearAleatorio()
		{
			GeneradorDeDatosAleatorios dato = new GeneradorDeDatosAleatorios();
			
			return new Persona(dato.stringAleatorio(6), dato.numeroAleatorio(99999999));
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
			return (new Persona(nombre, dni));
		}
		
		public override Comparable crearPorTeclado(EstrategiaDeComparacion e)
		{
			return this.crearPorTeclado(); //debe setear estrategia de comparacion cuando lo requiera
		}
		
	}

