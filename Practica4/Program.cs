/*
 * Created by SharpDevelop.
 * User: andres
 * Date: 24/8/2022
 * Time: 11:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using MetodologíasDeProgramaciónI;
using System;
using System.Collections.Generic;

namespace practica1
{
	
	
			
	class Program
	{	
		public static EstrategiaDeComparacion elegirEstrategiaDeComparacion()
		{
			EstrategiaDeComparacion e = null;
			bool ok = false;
						
			while(!ok)
			{
				Console.Write(" 1) Comparar por dni \n" +
			    		      " 2) Comparar por legajo\n" +
			           	   	  " 3) Comparar por nombre \n" +
			                  " 4) Comparar por promedio \n" +
			                  "    Ingrese numero de opcion: " );
				try 
				{	
					int opcion = (int.Parse(Console.ReadLine()));
					

					switch(opcion)
					{
						case 1 : { e = new EstrategiaPorDni(); break;}
						case 2 : { e = new EstrategiaPorLegajo(); break;}
						case 3 : { e = new EstrategiaPorNombre(); break;}
						case 4 : { e = new EstrategiaPorPromedio(); break;}
						default: { throw  new Exception();}
					}
					ok = true;
					Console.WriteLine();
					
				}
				catch(Exception)
				{
					Console.WriteLine();
					Console.WriteLine(" Error: La opcion no es incorrecta");
					Console.WriteLine(" Presione cualquier tecla para intentar nuevamente");
					Console.ReadKey(true);
					Console.Clear();
					continue;
				}
			}
			
			return e;
		}
		
		//Ejercicio5 //Ejercicio12 llenarPersonas //Ejercicio16 llenarAlumnos 
		public static void llenar(Coleccionable c, Producto producto)
		{
					
			for(int i=0; i < 20; i++)
			{
				c.agregar(FabricaDeComparables.crearAleatorio(producto));
			}
			
		}
		
		public static void imprimirMinimoYMaximo(Comparable min, Comparable max)
		{
			
			Console.WriteLine(" El minimo es: {0}", min.ToString());
			Console.WriteLine(" El maximo es: {0}", max.ToString());
			
		}
		
		//Ejercicio6
		public static void informar(Coleccionable c, Producto producto)
		{
			
			Console.WriteLine(" Hay {0} elementos", c.cuantos());
					
			Comparable min = c.minimo();
			Comparable max = c.maximo();
			
			imprimirMinimoYMaximo(min, max);
			
			Console.WriteLine();
			Console.WriteLine(" Se buscara solo segun politica de comparacion elegida: ");
			Comparable buscado = FabricaDeComparables.crearPorTeclado(producto);
			
			if(c.contiene(buscado))
			{
				Console.WriteLine(" El elemento leido esta en la coleccion");
			}
			else
			{
				Console.WriteLine(" El elemento leido no esta en la coleccion");
			}
		}
		

		//Ejercicio7 Practica2
		public static void imprimirElementos(Iterable iterable)
		{
			Iterator it = iterable.crearIterator();
			it.primero();
			int i=0;
			
			while(! (it.fin()))
			{
				Console.WriteLine(" {0:00}) {1}", i, it.actual().ToString());
				it.siguiente();
				i++;
			}
			
		}
		
		//Ejercicio9 practica2
		public static void cambiarEstrategia(Coleccionable c, EstrategiaDeComparacion e)
		{
			Iterator it = ((Iterable)c).crearIterator();
			it.primero();
			
			while(! (it.fin()))
			{
				((Alumno)it.actual()).setEstrategia(e);
				it.siguiente();
			}
			
		}
		
		//Ejercicio13 practica3
		public static void jornadaDeVentas(Coleccionable vendedores)
		{
			Iterator it = ((Iterable)vendedores).crearIterator();
			Random rnd = new Random();
			double monto;
			int i = 0;
			
			it.primero();
			while(! (it.fin()))
			{
				Console.Write(" {0} ", i++);
				monto = rnd.Next(1, 7000);
				((Vendedor)it.actual()).venta(monto);
				it.siguiente();
			}
			
		}
		
		public static void HacerAlGerenteObservador(Coleccionable vendedores, Gerente gerente)
		{
			Iterator it = ((Iterable)vendedores).crearIterator();
			it.primero();
			
			while(! (it.fin()))
			{
				((Vendedor)it.actual()).agregarObservador(gerente);
				it.siguiente();
			}
		}
		
		
		//Ejercicio8 Practica2		//Ejercicio10
		public static void Main(string[] args)
		{	
			/*	//Ejercicio8		
			Pila pila = new Pila();
			Cola cola = new Cola();
			Conjunto conjunto = new Conjunto();
			Diccionario diccionario = new Diccionario();			
			
			Producto producto = new Producto("Alumno", elegirEstrategiaDeComparacion());
			
			llenar(pila, producto);
			llenar(cola, producto);
			llenar(conjunto, producto);
			llenar(diccionario, producto);
			
			Console.WriteLine(" Aca informa una pila: ");
			imprimirElementos(pila);
			Console.WriteLine();
			
			Console.WriteLine(" Aca informa una cola: ");
			imprimirElementos(cola);
			Console.WriteLine();
			
			Console.WriteLine(" Aca informa un conjunto: ");
			imprimirElementos(conjunto);
			Console.WriteLine();
			
			Console.WriteLine(" Aca informa un diccionario: ");
			imprimirElementos(diccionario);
			Console.WriteLine();
			
			Console.ReadKey(true);
			*/
			
			//Ejercicio10
			/*Pila pila = new Pila();
			Producto producto = new Producto("Alumno");
			llenar(pila, producto);
			
			cambiarEstrategia(pila, new EstrategiaPorNombre());
			Console.WriteLine(" Estrategia de comparación por nombre: ");
			imprimirMinimoYMaximo(pila.minimo(), pila.maximo(), producto.getTipo());
			Console.WriteLine();
			
			cambiarEstrategia(pila, new EstrategiaPorLegajo());
			Console.WriteLine(" Estrategia de comparación por legajo: ");
			imprimirMinimoYMaximo(pila.minimo(), pila.maximo(), producto.getTipo());
			Console.WriteLine();
			
			cambiarEstrategia(pila, new EstrategiaPorPromedio());
			Console.WriteLine(" Estrategia de comparación por promedio: ");
			imprimirMinimoYMaximo(pila.minimo(), pila.maximo(), producto.getTipo());
			Console.WriteLine();
			
			cambiarEstrategia(pila, new EstrategiaPorDni());
			Console.WriteLine(" Estrategia de comparación por DNI: ");
			imprimirMinimoYMaximo(pila.minimo(), pila.maximo(), producto.getTipo());
			Console.WriteLine();
			
			Console.ReadKey(true);*/
			//ejercicio 14 practica 3
			/*
			Coleccionable pila = new Pila();
			Producto producto = new Producto("Vendedor");
			llenar(pila, producto);
			
			Gerente gerente = new Gerente(new Pila());
			
			HacerAlGerenteObservador(pila, gerente);
			
			jornadaDeVentas(pila);
			Console.WriteLine();
			
			gerente.cerrar();
			
			Console.ReadKey(true);
			*/
			
			GeneradorDeDatosAleatorios dato = new GeneradorDeDatosAleatorios();
			Teacher teacher = new Teacher();
			Student student;
			
			for(int i = 0; i<10; i++)
			{			
				AlumnoMuyEstudioso alumno1 = new AlumnoMuyEstudioso(dato.stringAleatorio(6), dato.numeroAleatorio(99999999), dato.numeroAleatorio(99999), dato.numeroAleatorio(10));				
				Alumno alumno2 = new Alumno(dato.stringAleatorio(6), dato.numeroAleatorio(99999999), dato.numeroAleatorio(99999), dato.numeroAleatorio(10));
				
				student = new StudentFactory().crearAlumnoDecorado(alumno1);
				
				teacher.goToClass(student);

				student = new StudentFactory().crearAlumnoDecorado(alumno2);
				
				teacher.goToClass(student);
			}
			
			teacher.teachingAClass();
			
			Console.ReadKey(true);
			
		}
	}
}