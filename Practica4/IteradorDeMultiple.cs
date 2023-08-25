//Ejercicio6

using System.Collections.Generic;

public class IteradorDeMultiple: Iterator
	{
		private List<Comparable> lista;
		private int indice;
		
		public IteradorDeMultiple(Pila pila, Cola cola)
		{
			this.indice = 0;
			this.lista = new List<Comparable>();
			
			Pila pilaAux = new Pila();
			Cola colaAux = new Cola();
			int cantPila = pila.cuantos();
			int cantCola = cola.cuantos();
			
			//Desapilo todos los elementos de la pila y los agrego a la lista
			for(int i=0; i<cantPila; i++)
			{
				this.lista.Add(pila.pop());
				pilaAux.push(this.lista[i]);
			}
			
			//Vuelvo a armar la pila para dejarla como al principio
			for(int i=0; i<cantPila; i++)
			{
				pila.push(pilaAux.pop());
			}
			
			//Desencolo todos los elementos de la cola y los agrego a partir del final de la lista			
			for(int i=0; i<cantCola; i++)
			{
				this.lista.Add(cola.dequeue());
				colaAux.enqueue(this.lista[i+cantPila]); 
			}
			
			//Vuelvo a armar la cola para dejarla como al principio		
			for(int i=0; i<cantCola; i++)
			{
				cola.enqueue(colaAux.dequeue());
			}
						
		}
		
		public void primero()
		{
			this.indice = 0;
		}
		
		public void siguiente()
		{
			this.indice++;
		}
		
		public bool fin()
		{
			return (this.indice == this.lista.Count);
		}
		
		public Comparable actual()
		{
			return (this.lista[this.indice]);
		}
	}

