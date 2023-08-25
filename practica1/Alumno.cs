//Ejercicio15

	public class Alumno: Persona
	{
		private int legajo;
		private double promedio;
		
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
		
		public override bool sosIgual(Comparable c)
		{
			return estrategia.sosIgual(this, (Alumno)c);
		}
		public override bool sosMenor(Comparable c)
		{
			return estrategia.sosMenor(this, (Alumno)c);
		}
		public override bool sosMayor(Comparable c)
		{
			return estrategia.sosMayor(this, (Alumno)c);
		}
		
		public override string ToString()
		{
			return (base.ToString()+string.Format("; Legajo: {0}; Promedio: {1}", legajo, promedio));
		}
		
	}

