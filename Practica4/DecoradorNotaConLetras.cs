using System;

	public class DecoradorNotaConLetras: DecoradorAlumno
	{
	
		public DecoradorNotaConLetras(IAlumno alumno):base(alumno)
		{
		
		}
		
		public override string mostrarCalificacion()
		{
			string resultado = base.mostrarCalificacion();
			string[] numero  = {"CERO", "UNO", "DOS", "TRES", "CUATRO", "CINCO", "SEIS", "SIETE", "OCHO", "NUEVE", "DIEZ"};
			double nota = this.getCalificacion();
			string decimales = "";
			
			if(nota % 1 == 50)
			{
				decimales = " CON CINCUENTA";
			}
			else if (nota % 1 != 0)
			{
				decimales = " CON DECIMALES";
			}
			
			return (resultado+" ("+numero[(int)Math.Truncate(this.getCalificacion())]+decimales+")");
		}
	}
