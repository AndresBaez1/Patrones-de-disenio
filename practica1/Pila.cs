using System.Collections.Generic;
//ejercicio4.1
	public class Pila: Coleccionable
	{
		private List<Comparable> elementos;
		
		public Pila()
		{
			elementos = new List<Comparable>();
		}
		
		public void push(Comparable elemento)
		{
			this.elementos.Add(elemento);
		}
		
		public Comparable pop()
		{
			Comparable desapilado = this.elementos[elementos.Count - 1];
			this.elementos.RemoveAt(elementos.Count - 1);
			return desapilado;
		}
		
		public int cuantos()
		{
			return this.elementos.Count;
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
			
			return (min);
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
			
			return (max);
		}
		
		public void agregar(Comparable elemento)
		{
			this.push(elemento);
		}
		
		public bool contiene(Comparable buscado)
		{
			bool encontrado= false;
			int i = 0;
			
			while((i<this.elementos.Count) && (!(encontrado = (this.elementos[i].sosIgual(buscado)))))
			{
			      	i++;
			}
			
			return (encontrado);
		}
	}