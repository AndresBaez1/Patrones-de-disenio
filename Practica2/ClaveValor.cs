
public class ClaveValor: Comparable
	{
		private Comparable clave;
		private Comparable valor;
			
		public ClaveValor(Comparable clave, Comparable valor)
		{
			this.clave = clave;
			this.valor = valor;
		}
		
		public Comparable getValor()
		{
			return this.valor;
		}
		
		public Comparable getClave()
		{
			return this.clave;
		}
		
		public void setValor(Comparable valor)
		{
			this.valor = valor;
		}
		
		public void setClave(Comparable clave)
		{
			this.clave = clave;
		}
		
		public bool sosIgual(Comparable c)
		{
			return (this.clave.sosIgual(((ClaveValor)c).getClave()));
		}
		
		public bool sosMenor(Comparable c)
		{
			return (this.clave.sosMenor(((ClaveValor)c).getClave()));
		}
		
		public bool sosMayor(Comparable c)
		{
			return (this.clave.sosMayor(((ClaveValor)c).getClave()));
		}
		
		public override string ToString()
		{
			return string.Format("[Clave: {0}; Valor: {1}]", clave.ToString(), valor.ToString());
		}

	}

