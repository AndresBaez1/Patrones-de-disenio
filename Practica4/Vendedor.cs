//ejercicio8 Practica3

using System;
using System.Collections.Generic;

	public class Vendedor: Persona, IObservado
	{
		private double sueldoBasico;
		private double bonus;
		private double montoActualDeVenta;
		private List<IObservador> observadores = new List<IObservador>();
		
		public Vendedor(string nombre, int dni, double sueldoBasico) :base(nombre, dni)
		{
			this.sueldoBasico = sueldoBasico;
			this.bonus = 1;
		}
		
		public void venta(double monto)
		{
			Console.WriteLine("El monto es: {0}", monto);
			this.montoActualDeVenta = monto;
			
			this.notificar();
		}
		
		public void aumentaBonus()
		{
			this.bonus = this.bonus + (0.1);
		}
		
		public double getBonus()
		{
			return (this.bonus);
		}
		
		public double getSueldoBasico()
		{
			return (this.sueldoBasico);
		}
		
		public void setSueldoBasico(double sueldoBasico)
		{
			this.sueldoBasico = sueldoBasico;
		}
		
		public double getMonto()
		{
			return (this.montoActualDeVenta);
		}
		
		public override bool sosIgual(Comparable c)
		{
			return (this.bonus.Equals(((Vendedor)c).bonus));
		}
		
		public override bool sosMenor(Comparable c)
		{
			return (this.bonus < ((Vendedor)c).bonus);
		}
		
		public override bool sosMayor(Comparable c)
		{
			return (this.bonus > ((Vendedor)c).bonus);
		}
		
		public override string ToString()
		{
			return (base.ToString()+string.Format("; Sueldo Basico: {0}; Bonus: {1}", this.sueldoBasico, this.bonus));
		}
		
		public void agregarObservador(IObservador o)
		{
			this.observadores.Add(o);
		}
		public void quitarObservador(IObservador o)
		{
			this.observadores.Remove(o);
		}
		public void notificar()
		{
			foreach(IObservador o in observadores)
			{
				o.actualizar(this);
			}
		}
	}

