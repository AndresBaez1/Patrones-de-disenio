
	abstract public class DecoradorAlumno: IAlumno, Comparable
	{
		private IAlumno adicional;
		
		public DecoradorAlumno(IAlumno adicional)
		{
			this.adicional = adicional;
		}
		
		public void setEstrategia(EstrategiaDeComparacion estrategia)
		{
			this.adicional.setEstrategia(estrategia);
		}
		
		public int getDni()
		{
			return(this.adicional.getDni());
		}
		
		public int getLegajo()
		{
			return (this.adicional.getLegajo());
		}
		
		public double getPromedio()
		{
			return( this.adicional.getPromedio());
		}
		
		public double getCalificacion()
		{
			return (this.adicional.getCalificacion());
		}
		
		
		public string getNombre()
		{
			return (this.adicional.getNombre());
		}
		
		public void setNombre(string nombre)
		{
			this.adicional.setNombre(nombre);
		}
		
		public int responderPregunta(int pregunta)
		{
			return (this.adicional.responderPregunta(pregunta));
		}
		
		public void setCalificacion(double calificacion)
		{
			this.adicional.setCalificacion(calificacion);
		}
		
		public virtual string mostrarCalificacion()
		{
			return (this.adicional.mostrarCalificacion());
		}
		
		public bool sosIgual(Comparable c)
		{
			return (this.adicional.sosIgual(c));
		}
		
		public bool sosMenor(Comparable c)
		{
			return (this.adicional.sosMenor(c));
		}
		public bool sosMayor(Comparable c)
		{
			return (this.adicional.sosMayor(c));
		}
	}

