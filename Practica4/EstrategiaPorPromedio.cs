//Ejercicio1 Practica2
public class EstrategiaPorPromedio: EstrategiaDeComparacion
{
	public bool sosIgual(IAlumno a1, IAlumno a2)
	{
		return (a1.getPromedio().Equals(a2.getPromedio()));
	}
	public bool sosMenor(IAlumno a1, IAlumno a2)
	{
		return (a1.getPromedio() < a2.getPromedio());
	}
		
	public bool sosMayor(IAlumno a1, IAlumno a2)
	{
		return (a1.getPromedio() > a2.getPromedio());
	}
}
	

