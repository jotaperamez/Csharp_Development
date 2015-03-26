
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// La interfaz animal da un par de caracteristicas a las clases.
/// Todo animal va a tener un nombre, una raza y un sexo.
/// </summary>
#region INTERFAZ ANIMAL
public interface Animal {

    string nombre { get; set; }
    string raza { get; set; }
    string sexo { get; set;  }
    string descripcion { get; }
}
#endregion

/// <summary>
/// Declaramos los metodos y variables de Perro
/// </summary>
#region PERRO
public class Perro : Animal
{
    private string p1;
    private string p2;
    private string p3;

  
    public Perro(string p1, string p2, string p3)
    {
        // TODO: Complete member initialization
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
    }


    public string nombre
    {
        get
        {
            return p1;
        }
        set
        {
            p1 = value;
        }
    }

    public string raza
    {
        get
        {
            return p2;
        }
        set
        {
            p2 = value;
        }
    }

    public string sexo
    {
        get
        {
            return p3;
        }
        set
        {
            p3 = value;
        }
    }

    public string descripcion
    {
        get
        {
            return p1+" "+p2+" "+p3;
        }
    }
}
#endregion

/// <summary>
/// Hacemos lo mismo con los metodos y las variables de Gato
/// </summary>
#region GATO
public class Gato : Animal
{

    private string p1;
    private string p2;
    private string p3;

    public Gato(string p1, string p2, string p3)
    {
        this.p1 = p1;
        this.p2 = p2;
        this.p3 = p3;
    }
    public string nombre
    {
        get
        {
            return p1;
        }
        set
        {
            p1 = value;
        }
    }

    public string raza
    {
        get
        {
            return p2;
        }
        set
        {
            p2 = value;
        }
    }

    public string sexo
    {
        get
        {
            return p3;
        }
        set
        {
            p3 = value;
        }
    }
    public string descripcion
    {
        get { return p1 + " " + p2 + " " + p3; }
    }
}
#endregion 

/// <summary>
/// Región donde probamos el codigo de clas clases y la interfaz
/// </summary>
#region to-do
public class Program
{

    static void Main(string[] args)
    {

        Perro perro = new Perro("tobi", "Pincher", "Macho");
        Gato gato = new Gato("Miel", "Siames", "Hembra");

        Console.WriteLine(perro.nombre);
        Console.WriteLine(perro.descripcion);
        Console.ReadKey();

        perro.nombre = "Charlie";

        Console.WriteLine(perro.descripcion);
        Console.WriteLine(perro is Gato);
        Console.WriteLine(perro is Animal);
        Console.ReadKey();
    }

#endregion
}