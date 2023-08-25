using MetodologíasDeProgramaciónI;

	public class StudentFactory: FabricaDeAlumnos
	{
		public Student crearAlumnoDecorado(Alumno alumno)
		{
			IAlumno decorador1 = new DecoradorConLegajo(alumno);
			IAlumno decorador2 = new DecoradorConOrden(decorador1);
			IAlumno decorador3 = new DecoradorNotaConLetras(decorador2);
			IAlumno decorador4 = new DecoradorConPromocionONo(decorador3);
			IAlumno decorador5 = new DecoradorConAsteriscos(decorador4);
			;

			return (new AlumnoAdapter(decorador5));
		}
		
	}

