//Ejercicio2 Practica4
	public class AlumnoMuyEstudioso: Alumno
	{
		public AlumnoMuyEstudioso(string nombre, int dni): base(nombre, dni)
		{
			
		}
		
		public AlumnoMuyEstudioso(string nombre, int dni, int legajo, double promedio): base(nombre, dni, legajo, promedio)
		{
			
		}
		
		public override int responderPregunta(int pregunta)
		{
			return (pregunta % 3);
		}
	}

