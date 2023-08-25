//Ejercicio15

	public class Alumno: Persona, IAlumno
	{
		private int legajo;
		private double promedio;
		private double calificacion;
		
		private EstrategiaDeComparacion  estrategia;
		
		public Alumno(string nombre, int dni): base(nombre, dni)
		{
			this.estrategia = new EstrategiaPorLegajo();
		}
		
		public Alumno(string nombre, int dni, int legajo, double promedio): base(nombre, dni)
		{
			this.estrategia = new EstrategiaPorLegajo();
			this.legajo = legajo;
			this.promedio = promedio;
		}
		
		public void setEstrategia(EstrategiaDeComparacion e)
		{
			this.estrategia = e;
		}
		
		public int getLegajo()
		{
			return this.legajo;
		}
		
		public double getPromedio()
		{
			return this.promedio;
		}
		
		//Ejercicio1 Practica4
		public double getCalificacion()
		{
			return (this.calificacion);
		}
		
		public void setCalificacion(double calificacion)
		{
			this.calificacion = calificacion;
		}
		
		public override bool sosIgual(Comparable c)
		{
			return estrategia.sosIgual(this, (IAlumno)c);
		}
		
		public override bool sosMenor(Comparable c)
		{
			return estrategia.sosMenor(this, (IAlumno)c);
		}
		
		public override bool sosMayor(Comparable c)
		{
			return estrategia.sosMayor(this, (IAlumno)c);
		}
		
		public virtual int responderPregunta(int pregunta)
		{
			GeneradorDeDatosAleatorios dato = new GeneradorDeDatosAleatorios();
			
			return (dato.numeroAleatorio(1, 3));
		}
		
		public string mostrarCalificacion()
		{
			return (string.Format(" {0} {1}", this.getNombre(), this.calificacion));
		}
		
		public override string ToString()
		{
			return (base.ToString()+string.Format("; Legajo: {0}; Promedio: {1}", legajo, promedio));
		}
		
		

		
	}

