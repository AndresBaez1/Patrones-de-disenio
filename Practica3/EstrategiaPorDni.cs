//Ejercicio1 Practica2
public class EstrategiaPorDni: EstrategiaDeComparacion
	{
		public bool sosIgual(Alumno a1, Alumno a2)
		{
			return (a1.getDni() == a2.getDni());
		}
		
		public bool sosMenor(Alumno a1, Alumno a2)
		{
			return (a1.getDni() < a2.getDni());
		}
		
		public bool sosMayor(Alumno a1, Alumno a2)
		{
			return (a1.getDni() > a2.getDni());
		}
	}
