//Ejercicio6 Practica2

using System.Collections.Generic;

	public class IteradorDeDiccionario: Iterator
	{
		private List<ClaveValor> lista;
		private int indice;
	
		public IteradorDeDiccionario(List<ClaveValor> lista)
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

