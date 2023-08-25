//Ejercicio1 Practica2
public class EstrategiaPorDni: EstrategiaDeComparacion
	{
		public bool sosIgual(IAlumno a1, IAlumno a2)
		{
			return (a1.getDni().Equals(a2.getDni()));
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2)
		{
			return (a1.getDni() < a2.getDni());
		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2)
		{
			return (a1.getDni() > a2.getDni());
		}
	}
