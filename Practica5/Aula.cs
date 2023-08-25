using System;
using MetodologíasDeProgramaciónI;

	public class Aula
	{
		private Teacher teacher;
		
		public Aula()
		{
		}
		
		public void comenzar()
		{
			Console.WriteLine("Buenos días");
			teacher = new Teacher();
		}
		
		public void nuevoAlumno(IAlumno alumno)
		{
			teacher.goToClass(new AlumnoAdapter(alumno));
		}
		
		public void claseLista()
		{
			teacher.teachingAClass();
		}
	}

