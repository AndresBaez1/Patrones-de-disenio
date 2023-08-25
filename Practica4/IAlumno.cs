//Ejercicio6 Practica4
using MetodologíasDeProgramaciónI;

public interface IAlumno
	{		
		int getDni();
		int getLegajo();
		double getPromedio();
		void setEstrategia(EstrategiaDeComparacion e);
		double getCalificacion();
		string getNombre();
		int responderPregunta(int pregunta);
		void setCalificacion(double calificacion);
		string mostrarCalificacion();
		bool sosIgual(Comparable c);
		bool sosMenor(Comparable c);
		bool sosMayor(Comparable c);
		
	}

