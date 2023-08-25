//ejercicio11 practica3

using System;

	public class Gerente: IObservador
	{
		private Coleccionable mejores;
		
		public Gerente(Coleccionable mejores)
		{
			this.mejores = mejores;
		}
		
		public void cerrar()
		{
			Iterator it = ((Iterable)this.mejores).crearIterator();
			it.primero();
			
			Console.WriteLine("Los mejores vendedores son: ");
			while(! (it.fin()))
			{
				Console.WriteLine(((Vendedor)it.actual()).ToString());
				it.siguiente();
			}
		}
		
		public void venta(double monto, Vendedor vendedor)
		{
			if(monto > 5000)
			{
				if(!mejores.contiene(vendedor))
				{
					mejores.agregar(vendedor);
					vendedor.aumentaBonus();
				}
			}
			
		}
		
		public void actualizar(IObservado o)
		{
			this.venta(((Vendedor)o).getMonto(), ((Vendedor)o));
		}
		
	}

