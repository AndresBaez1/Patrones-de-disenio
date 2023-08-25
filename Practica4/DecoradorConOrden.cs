
	public class DecoradorConOrden: DecoradorAlumno
	{
		private static int orden = 1;
			
		public DecoradorConOrden(IAlumno alumno):base(alumno)
		{

		}
		
		public void OrdenComenzar()
		{
			orden = 1;
		}
		
		public override string mostrarCalificacion()
		{
			string resultado = base.mostrarCalificacion();
			resultado = (" "+orden+")"+resultado);
			orden++;
								
			return (resultado);
		}
	}

