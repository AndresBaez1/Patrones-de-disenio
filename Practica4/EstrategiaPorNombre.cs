//Ejercicio1 Practica2
public class EstrategiaPorNombre: EstrategiaDeComparacion
	{
		
		public bool sosIgual(IAlumno a1, IAlumno a2)
		{
			return (a1.getNombre().ToUpper().Equals(a2.getNombre().ToUpper()));
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2)
		{
			return ((a1.getNombre().ToUpper().CompareTo(a2.getNombre().ToUpper())) < 0);
		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2)
		{
			return ((a1.getNombre().ToUpper().CompareTo(a2.getNombre().ToUpper())) > 0);
		}
	}

