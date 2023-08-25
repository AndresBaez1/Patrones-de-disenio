	public class DecoradorConPromocionONo: DecoradorAlumno
	{
	
		public DecoradorConPromocionONo(IAlumno alumno):base(alumno)
		{
		
		}
		
		public override string mostrarCalificacion()
		{
			string resultado = base.mostrarCalificacion();
					
			double nota = this.getCalificacion();
			
			
			if(nota >= 7) resultado = resultado + " (PROMOCION)";
			else if (nota >=4 && nota<=7) resultado = resultado + " (APROBADO)";
			else resultado = resultado + " (DESAPROBADO)";
					
			return (resultado);
		}
	}
