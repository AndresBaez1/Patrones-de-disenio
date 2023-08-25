﻿//Ejercicio4 practica2 //Ejercicio5 practica2

using System.Collections.Generic;

	public class Diccionario: Coleccionable, Iterable, Ordenable
	{
		private List<ClaveValor> elementos;
		private const int _CLAVE_UNICA_ = 369;
		private int contador;
		
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
		
		public Diccionario()
		{
			this.elementos = new List<ClaveValor>();
			contador = 0;
		}
		
		private ClaveValor buscarYRetornarBuscado(Comparable claveBuscada)
		{  //Busca la clave que recibe y retorna una referencia al objeto correspondiente en la lista
		   //Si no lo encuentra retorna null.
			
			bool encontrado= false;
			ClaveValor retorno = null;
			int i = 0;
			
			while((i<this.elementos.Count)&&(!(encontrado = ((this.elementos[i]).getClave().sosIgual(claveBuscada)))))
			{
			      	i++;
			}
			
			if(encontrado)
			{
				retorno = this.elementos[i];
			}
			
			return (retorno);
		}
		
		public void agregar(Comparable clave, Comparable valor)
		{
						
			ClaveValor encontrado = this.buscarYRetornarBuscado(clave); //recibe una referencia
			
			if(encontrado != null)
			{
				encontrado.setValor(valor);
			}
			else
			{
				ClaveValor nuevo = new ClaveValor(clave, valor);
				this.elementos.Add(nuevo);
				
				if(this.elementos.Count == 1 && this.ordenInicio != null)
				{
					this.ordenInicio.ejecutar();
				}
			}
			
			if(this.ordenAlumno != null)
			{
				this.ordenAlumno.ejecutar(valor);
			}
			
			
			if(this.elementos.Count == 40 && this.ordenFin != null)
			{
				this.ordenFin.ejecutar();
			}
		}
		
		public Comparable valorDe(Comparable clave)
		{
			Comparable retorno = null;
			
			ClaveValor encontrado = this.buscarYRetornarBuscado(clave);
			
			if(encontrado != null)
			{
				retorno = encontrado.getValor();
			}
			
			return (retorno);
		}
		
		public int cuantos()
		{
			return (this.elementos.Count);
		}
		
		public Comparable minimo()
		{
			Comparable min = elementos[0].getValor();
			
			for(int i=1; i<elementos.Count; i++)
			{
				if(elementos[i].getValor().sosMenor(min))
				{
					min = elementos[i].getValor();
				}
			}
			
			return (min);
		}
		public Comparable maximo()
		{
			Comparable max = elementos[0].getValor();
			
			for(int i=1; i<elementos.Count; i++)
			{
				if(elementos[i].getValor().sosMayor(max))
				{
					max = elementos[i].getValor();
				}
			}
			
			return (max);
		}
		
		public bool contiene(Comparable buscado)
		{
			bool encontrado= false;
			int i = 0;
			
			while(((i<this.elementos.Count) && (!(encontrado = (this.elementos[i].sosIgual(buscado))))))
			{
			      	i++;
			}
			
			return (encontrado);
		}
		
		public void agregar(Comparable valor)
		{
			ClaveValor nuevo = new ClaveValor((new Numero(_CLAVE_UNICA_+contador)), valor);
			contador++;
			this.elementos.Add(nuevo);
			
			if(this.elementos.Count == 1 && this.ordenInicio != null)
			{
				this.ordenInicio.ejecutar();
			}
			
			if(this.ordenAlumno != null)
			{
				this.ordenAlumno.ejecutar(valor);
			}
			
			if(this.elementos.Count == 40 && this.ordenFin != null)
			{
				this.ordenFin.ejecutar();
			}
		}
		
		public Iterator crearIterator()
		{
			return (new IteradorDeDiccionario(this.elementos));
		}
	}

