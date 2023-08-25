//Ejercicio4.2 practica1 //Ejercicio6 Practica2
using System.Collections.Generic;

	public class Cola: Coleccionable, Iterable, Ordenable
	{
		private List<Comparable> elementos;
		
		private OrdenEnAula1 ordenInicio;
		private OrdenEnAula1 ordenFin;
		private OrdenEnAula2 ordenAlumno;
		
		public void setOrdenInicio(OrdenEnAula1 orden)
		{
			this.ordenInicio = orden;
		}
		public void setOrdenLlegaAlumno(OrdenEnAula2 orden)
		{
			this.ordenAlumno = orden;
		}
		public void setOrdenAulaLlena(OrdenEnAula1 orden)
		{
			this.ordenFin = orden;
		}
		
		public Cola()
		{
			elementos = new List<Comparable>();
		}
		
		public void enqueue(Comparable elemento)
		{
			this.elementos.Add(elemento);
			
			if(this.elementos.Count == 1 && this.ordenInicio != null)
			{
				this.ordenInicio.ejecutar();
			}
			
			if(this.ordenAlumno != null)
			{
				this.ordenAlumno.ejecutar(elemento);
			}
			
			
			if(this.elementos.Count == 40 && this.ordenFin != null)
			{
				this.ordenFin.ejecutar();
			}
		}
		
		public Comparable dequeue()
		{
			Comparable desencolado = this.elementos[0];
			this.elementos.RemoveAt(0);
			return desencolado;
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
		
		public void agregar(Comparable elemento)
		{
			this.enqueue(elemento);
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
		
		public Iterator crearIterator()
		{
			return (new IteradorDeCola(this.elementos) );
		}
	}