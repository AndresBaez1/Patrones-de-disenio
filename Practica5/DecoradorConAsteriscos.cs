
	public class DecoradorConAsteriscos: DecoradorAlumno
	{
	
		public DecoradorConAsteriscos(IAlumno alumno):base(alumno)
		{
		
		}
		
		public override string mostrarCalificacion()
		{
			string resultado = base.mostrarCalificacion();
			
			string linea = " ***";
			
			for (int i=0; i < resultado.Length; i++)
			{
				linea += "*";
			}
			
			resultado = (linea+"\n *"+resultado+" *\n"+linea);
			
			return (resultado);
		}
	}

