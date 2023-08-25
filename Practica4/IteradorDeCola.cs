
using System.Collections.Generic;

	public class IteradorDeCola: Iterator
	{
		private List<Comparable> lista;
		private int indice;
		
		public IteradorDeCola(List<Comparable> lista)
		{
			this.lista = lista;
			this.indice = lista.Count-1;
		}
		
		public void primero()
		{
			this.indice = this.lista.Count-1;
		}
		
		public void siguiente()
		{
			this.indice--;
		}
		public bool fin()
		{
			return (this.indice == -1);
		}
		public Comparable actual()
		{
			return (this.lista[this.indice]);
		}
	}

