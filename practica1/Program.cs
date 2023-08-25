/*
 * Created by SharpDevelop.
 * User: andres
 * Date: 24/8/2022
 * Time: 11:14
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
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
				Console.Write(" 1) Comparar por legajo\n" +
			              	  " 2) Comparar por promedio \n" +
			                  "    Ingrese numero de opcion: " );
				try 
				{	
					int opcion = (int.Parse(Console.ReadLine()));
					

					switch(opcion)
					{
						case 1 : { e = new EstrategiaPorLegajo(); break;}
						case 2 : { e = new EstrategiaPorPromedio(); break;}
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
		
		public static void imprimirMinimoYMaximo(Comparable min, Comparable max, string tipo)
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
			
			imprimirMinimoYMaximo(min, max, producto.getTipo());
			
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
		
		
		/*public static void imprimirPila(Pila pila)
		{
			Pila auxP = new Pila();
			int cant = pila.cuantos();
			for(int i=0; i<cant; i++)
			{
				Alumno n = (Alumno)(pila.pop());
				Console.Write(n.getDni()+ " - ");
				auxP.agregar(n);
			}
			cant = auxP.cuantos();
			for(int i=0; i<cant; i++)
			{
				
				pila.agregar(auxP.pop());
			}
		}
		
		/*public static void imprimirCola(Cola cola)
		{
			Cola auxC = new Cola();
			int cant = cola.cuantos();
			for(int i=0; i<cant; i++)
			{
				Numero n = (Numero)(cola.dequeue());
				Console.Write(n.getValor()+ " - ");
				auxC.agregar(n);
			}
			cant = auxC.cuantos();
			for(int i=0; i<cant; i++)
			{
				
				cola.agregar(auxC.dequeue());
			}
		}*/
		
		public static void Main(string[] args)
		{			
			Pila pila = new Pila();
			Cola cola = new Cola();
			ColeccionableMultiple multiple = new ColeccionableMultiple(pila, cola);
			
			
			Producto producto = new Producto("Alumno", elegirEstrategiaDeComparacion());
			
			llenar(pila, producto);
			llenar(cola, producto);
			
			/*imprimirPila(pila);
			Console.WriteLine();*/
			
			Console.WriteLine(" Aca informa una pila: ");
			informar(pila, producto);
			Console.WriteLine();
			
			/*imprimirCola(cola);
			Console.WriteLine();*/
			
			Console.WriteLine(" Aca informa una cola: ");
			informar(cola, producto);
			Console.WriteLine();
			
			Console.WriteLine(" Aca informa multiple: ");
			informar(multiple, producto);			
			Console.ReadKey(true);
		}
	}
}