using System;

//Ejercicio8
namespace practica1
{

	public class ColeccionableMultiple: Coleccionable
	{
		private Pila pila;
		private Cola cola;
		
		public ColeccionableMultiple(Pila pila, Cola cola)
		{
			this.pila = pila;
			this.cola = cola;
		}
		public int cuantos()
		{
			return (this.pila.cuantos() + this.cola.cuantos());
		}
		
		public Comparable minimo()
		{
			Comparable minP = this.pila.minimo();
			Comparable minC = this.cola.minimo();
			Comparable min;
			
			if(minP.sosMenor(minC))
			{
				min = minP;
			}
			else 
			{
				min = minC;
			}
			
			return min;
		}
		public Comparable maximo()
		{
			Comparable maxP = this.pila.maximo();
			Comparable maxC = this.cola.maximo();
			Comparable max;
			
			if(maxP.sosMayor(maxC))
			{
				max = maxP;
			}
			else 
			{
				max = maxC;
			}
			
			return max;	
		}
		
		public void agregar(Comparable c)
		{
			//No hace nada.
		}
		
		public bool contiene(Comparable c)
		{
			return ((this.pila.contiene(c))||(this.cola.contiene(c)));
		}
	}
}
