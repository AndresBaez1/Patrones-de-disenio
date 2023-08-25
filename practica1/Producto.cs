
	public class Producto
	{
		private string tipo;
		private EstrategiaDeComparacion estrategia;
		
		public Producto(string t)
		{
			this.tipo = t;
			this.estrategia = null;
		}
		
		public Producto(string t, EstrategiaDeComparacion e)
		{
			this.tipo = t;
			this.estrategia = e;
		}
		
		public string getTipo()
		{
			return (this.tipo);
		}
		
		public bool hayEstrategia()
		{
			return (this.estrategia != null);
		}
		
		public EstrategiaDeComparacion getEstrategia()
		{
			return (this.estrategia);
		}
		
		public void setTipo(string t)
		{
			this.tipo = t;
		}
		
		public void setEstrategia(EstrategiaDeComparacion e)
		{
			this.estrategia = e;
		}
	}

