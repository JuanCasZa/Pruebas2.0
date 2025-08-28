// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hola, mundo!");

Entrenadores entrenador = new Personas();
entrenador.nombre = "Juan";
entrenador.cedula = "1000194984";

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
    public String titulo;
}

public class Clientes : Personas
{
    public bool estadoMembresia;
    public char tipoDeMembresia;

}

