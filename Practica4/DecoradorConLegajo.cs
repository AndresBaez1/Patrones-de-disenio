
	public class DecoradorConLegajo: DecoradorAlumno
	{
	
		public DecoradorConLegajo(IAlumno alumno):base(alumno)
		{
		
		}
		
		public override string mostrarCalificacion()
		{
			string resultado = base.mostrarCalificacion();
			
			string[] palabras = resultado.Split(new char[]{' '});
			
			return (" "+palabras[1]+" ("+this.getLegajo()+") "+palabras[2]);
		}
	}

