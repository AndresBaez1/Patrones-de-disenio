//Ejercicio1 Practica2
public class EstrategiaPorNombre: EstrategiaDeComparacion
	{
		
		public bool sosIgual(Alumno a1, Alumno a2)
		{
			return (a1.getNombre().ToUpper().Equals(a2.getNombre().ToUpper()));
		}
		
		public bool sosMenor(Alumno a1, Alumno a2)
		{
			return ((a1.getNombre().ToUpper().CompareTo(a2.getNombre().ToUpper())) < 0);
		}
		
		public bool sosMayor(Alumno a1, Alumno a2)
		{
			return ((a1.getNombre().ToUpper().CompareTo(a2.getNombre().ToUpper())) > 0);
		}
	}

