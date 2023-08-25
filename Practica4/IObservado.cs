//ejercicio12 practica3

	public interface IObservado
	{
		void agregarObservador(IObservador o);
		void quitarObservador(IObservador o);
		void notificar();
	}

