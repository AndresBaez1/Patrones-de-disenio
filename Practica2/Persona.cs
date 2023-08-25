
//Ejercicio11

public class Persona: Comparable
{
	private string nombre;
	private int dni;
	
	public Persona(string nombre, int dni)
	{
		this.nombre = nombre;
		this.dni = dni;
	}
	
	public string getNombre()
	{
		return this. nombre;
	}
	
	public int getDni()
	{
		return this.dni;
	}
	
	public virtual bool sosIgual(Comparable c)
	{
		return (this.dni == ((Persona)(c)).getDni());
	}
	
	public	virtual bool sosMenor(Comparable c)
	{
		return (this.dni < ((Persona)(c)).getDni());
	}
	
	public virtual	bool sosMayor(Comparable c)
	{
		return (this.dni > ((Persona)(c)).getDni());
	}
	
	public override string ToString()
	{
		return (string.Format("Nombre: {0}; DNI: {1}", nombre, dni));
	}
 
	
}

