//Ejercicio1 Practica2
	public class EstrategiaPorLegajo : EstrategiaDeComparacion
	{
		public bool sosIgual(IAlumno a1, IAlumno a2)
		{
			return (a1.getLegajo().Equals(a2.getLegajo()));
		}
		
		public bool sosMenor(IAlumno a1, IAlumno a2)
		{
			return (a1.getLegajo() < a2.getLegajo());
		}
		
		public bool sosMayor(IAlumno a1, IAlumno a2)
		{
			return (a1.getLegajo() > a2.getLegajo());
		}
	}