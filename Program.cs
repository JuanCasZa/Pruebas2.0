// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, mundo!");

Entrenadores entrenador = new Entrenadores();
entrenador.nombre = "Juan";
entrenador.cedula = "1000194984";
entrenador.telefono = "3104207950";
entrenador.titulos = new List<Profesiones>();
entrenador.titulos.Add(new Profesiones() { titulo = "a" });
entrenador.titulos.Add(new Profesiones() { titulo = "b" });
entrenador.titulos.Add(new Profesiones() { titulo = "c" });

Console.WriteLine(entrenador.nombre);
Console.WriteLine(entrenador.cedula);

foreach (var elemento in entrenador.titulos)
{
    Console.WriteLine(elemento.titulo);
}

public class Personas
{
    public String nombre;
    public String cedula;
    public String telefono;
    public String correo;
    public int edad;
}

public class Entrenadores : Personas
{
    public List<Profesiones> titulos;
    public decimal salario;
    public int experiencia;
}

public class Profesiones
{
    public string titulo;
}


public class Clientes : Personas
{
    public bool estadoMembresia;
    public char tipoDeMembresia;

}

