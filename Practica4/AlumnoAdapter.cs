
//Ejercicio3 Practica4

using MetodologíasDeProgramaciónI;

	public class AlumnoAdapter: Student
	{
		private IAlumno alumno;
		
		public AlumnoAdapter(IAlumno alumno)
		{
			EstrategiaDeComparacion estrategia = new EstrategiaPorCalificacion();
			alumno.setEstrategia(estrategia);
			this.alumno = alumno;
			
		}
		
		public string getName()
		{
			return (this.alumno.getNombre());
		}
		
		public int yourAnswerIs(int question)
		{
			return (this.alumno.responderPregunta(question));
		}
		
		public void setScore(int score)
		{
			this.alumno.setCalificacion(score);
		}
		
		public string showResult()
		{
			return (this.alumno.mostrarCalificacion());
		}
		
		public IAlumno getAlumno()
		{
			return this.alumno;
		}
		
		public bool equals(Student student)
		{	
			IAlumno alumnoAux = ((AlumnoAdapter)student).getAlumno();
			return (this.alumno.sosIgual(((Comparable)(alumnoAux))));
		}
		public bool lessThan(Student student)
		{
			IAlumno alumnoAux = ((AlumnoAdapter)student).getAlumno();
			return (this.alumno.sosMenor(((Comparable)(alumnoAux))));
		}
		
		public bool greaterThan(Student student)
		{
			IAlumno alumnoAux = ((AlumnoAdapter)student).getAlumno();
			return (this.alumno.sosMayor(((Comparable)(alumnoAux))));
		}
	}

