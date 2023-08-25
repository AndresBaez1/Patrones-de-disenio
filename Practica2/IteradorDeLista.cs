//Ejercicio6
using System.Collections.Generic;

	public class IteradorDeLista: Iterator
	{
		private List<Comparable> lista;
		private int indice;
			
		public IteradorDeLista(List<Comparable> lista)
		{
			this.lista = lista;
			this.indice = 0;
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

