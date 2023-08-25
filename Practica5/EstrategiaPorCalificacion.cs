
	public class EstrategiaPorCalificacion: EstrategiaDeComparacion
	{
		public bool sosIgual(IAlumno a1, IAlumno a2)
		{
			return (a1.getCalificacion().Equals(a2.getCalificacion()));
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2)
		{
			return (a1.getCalificacion() < a2.getCalificacion());
		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2)
		{
			return (a1.getCalificacion() > a2.getCalificacion());
		}
	}

