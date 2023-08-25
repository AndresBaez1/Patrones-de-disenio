using System;

	public class FabricaDeProxysAlumno: FabricaDeComparables
	{
		private string tipoDeAlumno;
		
		public FabricaDeProxysAlumno(string tipoDeAlumno)
		{
			this.tipoDeAlumno = tipoDeAlumno;
		}
				
		public override Comparable crearAleatorio()
		{
			GeneradorDeDatosAleatorios dato = new GeneradorDeDatosAleatorios();
			
			return new ProxyAlumno(dato.stringAleatorio(6),this.tipoDeAlumno);
		}
		
		public override Comparable crearAleatorio(EstrategiaDeComparacion e)
		{
			Alumno a = (Alumno)this.crearAleatorio();
			//a.setEstrategia(e);
			return a;
		}
		
		public override Comparable crearPorTeclado()
		{
			string nombre;
			
			Console.Write(" Ingrese un nombre: ");
			nombre = Console.ReadLine();
			
			return (new ProxyAlumno(nombre, this.tipoDeAlumno));			
		}
		
		public override Comparable crearPorTeclado(EstrategiaDeComparacion e)
		{		
			AlumnoMuyEstudioso a = (AlumnoMuyEstudioso)crearPorTeclado();
			a.setEstrategia(e);
			return (a);			
		}
	}

