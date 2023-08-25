//ejercicio2
	public class Numero: Comparable
	{
		private int valor;
		
		public Numero(int v)
		{
			this.valor = v;
		}
		public int getValor()
		{
			return valor;
		}
		
		public bool sosIgual(Comparable c)
		{
			return this.valor == ((Numero)c).getValor();
		}
		
		public bool sosMenor(Comparable c)
		{
			return this.valor < ((Numero)c).getValor();
		}
		
		public bool sosMayor(Comparable c)
		{
			return this.valor > ((Numero)c).getValor();
		}
		
		public override string ToString()
		{
			return (this.valor.ToString());
		}
	}