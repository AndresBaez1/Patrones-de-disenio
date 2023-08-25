//Ejercicio3 Practica2 //Ejercicio5 Practica2

using System.Collections.Generic;
	
	public class Conjunto: Coleccionable, Iterable
	{
		private List<Comparable> elementos;
	
		public Conjunto()
		{
			this.elementos = new List<Comparable>();
		}

		public bool pertenece(Comparable buscado)
		{
			bool encontrado = false;
			int i = 0;
			
			while((i<this.elementos.Count) && (!(encontrado = (this.elementos[i].sosIgual(buscado)))))
			{
			      	i++;
			}
			
			return (encontrado);
		}
		
		public void agregar(Comparable c)
		{
			if(!(this.pertenece(c)))
			{
				this.elementos.Add(c);
			}
		}
		
		public int cuantos()
		{
			return (this.elementos.Count);
		}
		
		public Comparable minimo()
		{
			Comparable min = elementos[0];
			
			for(int i=1; i<elementos.Count; i++)
			{
				if(elementos[i].sosMenor(min))
				{
					min = elementos[i];
				}
			}
			
			return min;
		}
		
		public Comparable maximo()
		{
			Comparable max = elementos[0];
			
			for(int i=1; i<elementos.Count; i++)
			{
				if(elementos[i].sosMayor(max))
				{
					max = elementos[i];
				}
			}
			
			return max;
		}	
		
		public bool contiene(Comparable buscado)
		{
			return (this.pertenece(buscado));
		}

		public Iterator crearIterator()
		{
			return (new IteradorDeLista(this.elementos));
		}
		
	}

