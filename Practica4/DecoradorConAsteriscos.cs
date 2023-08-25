
	public class DecoradorConAsteriscos: DecoradorAlumno
	{
	
		public DecoradorConAsteriscos(IAlumno alumno):base(alumno)
		{
		
		}
		
		public override string mostrarCalificacion()
		{
			string resultado = base.mostrarCalificacion();
			
			string tira = " ***";
			
			for (int i=0; i < resultado.Length; i++)
			{
				tira += "*";
			}
			
			resultado = (tira+"\n *"+resultado+" *\n"+tira);
			
			return (resultado);
		}
	}

