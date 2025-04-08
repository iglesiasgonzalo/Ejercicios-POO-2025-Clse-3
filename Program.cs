using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicios_POO_2025_Clase_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 1
             Autobus miAutobus = new Autobus(50, 2, 50);
             miAutobus.SubirPasajeros(24);
             miAutobus.BajarPasajeros(10);
             miAutobus.Encender();*/

            /*Ejercicio 2 
            
            Cuatriciclo miCuatriciclo = new Cuatriciclo { Marca = "Yamaha", Modelo = "Raptor", Año = 2023, NumeroSerie = "Q12345", TieneBarraDeSeguridad = true };
            miCuatriciclo.Arrancar();
            miCuatriciclo.ConducirTodoTerreno();
            miCuatriciclo.Frenar();

            Coche miCoche = new Coche { Marca = "Ford", Modelo = "Mustang Shelby GT500", Año = 2022, NumeroSerie = "C56789", NumeroPuertas = 2, Color= "azul con rayas blancas" };
            miCoche.Arrancar();
            miCoche.AbrirMaletero();
            miCoche.Frenar();

            Moto miMoto = new Moto { Marca = "Honda", Modelo = "CBR", Año = 2021, NumeroSerie = "M98765", TieneCasco = true };
            miMoto.Arrancar();
            miMoto.RealizarDerrape();
            miMoto.Frenar();

            Console.ReadKey();*/

            /*Ejercicio 3 
           
            Caballo miCaballo = new Caballo
            {
                Especie = "Caballo",
                Edad = 5,
                Genero = "Macho",
                Raza = "Árabe",
                EsDomestico = true
            };

            miCaballo.Alimentar();
            miCaballo.HacerSonido();
            miCaballo.Galopar();

            Cocodrilo miCocodrilo = new Cocodrilo
            {
                Especie = "Cocodrilo",
                Edad = 8,
                Genero = "Hembra",
                Longitud = 4.5,
                EsAcuatico = true
            };

            miCocodrilo.Alimentar();
            miCocodrilo.HacerSonido();
            miCocodrilo.Nadar();

            Console.ReadKey();*/

            /* Ejercicio 4 
             Libro miLibro = new Libro("Cien años de soledad", "Gabriel García Márquez", 1967, "Novela");

             miLibro.Leer();   
             miLibro.Abrir();   
             miLibro.Leer();    
             miLibro.Cerrar();  
             Console.ReadKey();*/

            //Ejercicio 5 
            
            Biblioteca miBiblioteca = new Biblioteca("Biblioteca Central", "Calle Principal 123", "9:00 AM - 6:00 PM", 5);

           
            miBiblioteca.AgregarLibro("Cien años de soledad", "Gabriel García Márquez");
            miBiblioteca.AgregarLibro("1984", "George Orwell");
            miBiblioteca.AgregarLibro("El principito", "Antoine de Saint-Exupéry");

            
            Console.WriteLine("\nBuscando libros por el autor 'Orwell':");
            miBiblioteca.BuscarLibro("Orwell");

           
            Console.WriteLine("\nPrestando el libro '1984':");
            miBiblioteca.PrestarLibro("1984");

           
            Console.WriteLine("\nIntentando prestar nuevamente '1984':");
            miBiblioteca.PrestarLibro("1984");

           
            Console.WriteLine("\nDevolviendo el libro '1984':");
            miBiblioteca.DevolverLibro("1984");

            
            Console.WriteLine("\nBuscando libros con '1984':");
            miBiblioteca.BuscarLibro("1984");

            Console.ReadKey();


            /* Ejercicio 6
             CajeroAutomatico miCajero = new CajeroAutomatico
             {
                 Ubicacion = "Centro Comercial",
                 NumeroSerie = "CA123456",
             };

             miCajero.EstablecerSaldo(5000.00m);
             miCajero.ConsultarSaldo();
             miCajero.DepositarDinero(1000.00m);
             miCajero.RetirarDinero(1500.00m);
             miCajero.RetirarDinero(7000.00m);
             miCajero.ConsultarSaldo();
             Console.ReadKey();*/

            /* Ejercicio 7

             Rol rolDesarrollador = new Rol("Desarrollador", 3000.00m);
             Rol rolGerente = new Rol("Gerente", 5000.00m);          

             Departamento departamentoTI = new Departamento("Tecnologías de la Información");
             Departamento departamentoHR = new Departamento("Recursos Humanos");

             Empleado empleado1 = new Empleado("Juan Pérez", 30);
             Empleado empleado2 = new Empleado("Ana López", 28);          

             empleado1.AsignarRol(rolDesarrollador);
             empleado2.AsignarRol(rolGerente);

             departamentoTI.AgregarEmpleado(empleado1);
             departamentoHR.AgregarEmpleado(empleado2);


             Console.WriteLine($"Salario de {empleado1.Nombre}: ${empleado1.CalcularSalario()}");
             Console.WriteLine($"Salario de {empleado2.Nombre}: ${empleado2.CalcularSalario()}");
             Console.ReadKey();*/

        }


    }
}

/*EJERCICIO 1  Diseño de clase para un autobús:
•Crea una clase llamada "Autobús" que herede de la clase "Vehículo". Agrega
atributos específicos como capacidad de pasajeros, número de puertas, número de
asientos, etc.Implementa métodos para carga y descarga de pasajeros.
public class Vehiculo
{
    public string Marca;
    public string Modelo;
    public int Año;

    public void Encender()
    {
        Console.WriteLine("El vehículo está encendido.");
    }

    public void Apagar()
    {
        Console.WriteLine("El vehículo está apagado.");
    }
}

public class Autobus : Vehiculo
{
    public int CapacidadPasajeros;
    public int NumeroPuertas;
    public int NumeroAsientos;
    public int PasajerosActuales;
    public Autobus(int capacidad, int puertas, int asientos)
    {
        CapacidadPasajeros = capacidad;
        NumeroPuertas = puertas;
        NumeroAsientos = asientos;
        PasajerosActuales = 0;
    }


    public void SubirPasajeros(int cantidad)
    {
        if (PasajerosActuales + cantidad <= CapacidadPasajeros)
        {
            PasajerosActuales += cantidad;
            Console.WriteLine($"{cantidad} pasajeros han subido. Pasajeros actuales: {PasajerosActuales}");
        }
        else
        {
            Console.WriteLine("No hay suficiente espacio en el autobús.");
        }
    }

    public void BajarPasajeros(int cantidad)
    {
        if (cantidad <= PasajerosActuales)
        {
            PasajerosActuales -= cantidad;
            Console.WriteLine($"{cantidad} pasajeros han bajado. Pasajeros restantes: {PasajerosActuales}");
        }
        else
        {
            Console.WriteLine("No hay suficientes pasajeros en el autobús para bajar.");
        }
    }
}*/

/*EJERCICIO 2: Diseño de clase para un vehículo:
 • Define una clase llamada "Vehículo" con atributos como modelo, marca, año, número de serie, etc.
 Incluye métodos para arrancar, detener, acelerar y frenar, que a su vez sea clase padre de 3 clases más.

public class Vehiculo
{
    public string Modelo;
    public string Marca;
    public int Año;
    public string NumeroSerie;


    public void Arrancar()
    {
        Console.WriteLine($"El vehículo {Marca} {Modelo} está arrancando.");
    }

    public void Detener()
    {
        Console.WriteLine($"El vehículo {Marca} {Modelo} se ha detenido.");
    }

    public void Acelerar()
    {
        Console.WriteLine($"El vehículo {Marca} {Modelo} está acelerando.");
    }

    public void Frenar()
    {
        Console.WriteLine($"El vehículo {Marca} {Modelo} está frenando.");
    }
}

public class Cuatriciclo : Vehiculo
{
public bool TieneBarraDeSeguridad;

    public void ConducirTodoTerreno()
    {
        Console.WriteLine($"El cuatriciclo {Marca} {Modelo} está siendo conducido en terreno difícil.");
    }
}


public class Coche : Vehiculo
{
    public int NumeroPuertas;
    public string Color;

    public void AbrirMaletero()
    {
        Console.WriteLine("El maletero del coche está abierto.");
    }
}

public class Moto : Vehiculo
{
public bool TieneCasco;

    public void RealizarDerrape()
    {
        Console.WriteLine($"La moto {Marca} {Modelo} está realizando un derrape.");
    }
}*/


/* EJERCICIO 3 Diseño de clase para un animal:
 • Define una clase "Animal" con atributos como especie, edad, género, etc.Incluye métodos para alimentar, reproducir y 
hacer sonidos característicos, que a su vez sea clase padre de 2 clases más con sus métodos y atributos cada una. 

public class Animal
{
    public string Especie;
    public int Edad;
    public string Genero;

    // Métodos comunes
    public void Alimentar()
    {
        Console.WriteLine($"El {Especie} está siendo alimentado.");
    }

    public void Reproducir()
    {
        Console.WriteLine($"El {Especie} se está reproduciendo.");
    }

    public void HacerSonido()
    {
        Console.WriteLine($"El {Especie} emite un sonido característico.");
    }
}

public class Caballo : Animal
{
    public string Raza;
    public bool EsDomestico;

    public void Galopar()
    {
        Console.WriteLine($"El caballo de raza {Raza} está galopando.");
    }
}


public class Cocodrilo : Animal
{
    public double Longitud;
    public bool EsAcuatico;

    public void Nadar()
    {
        Console.WriteLine($"El cocodrilo de longitud {Longitud} metros está nadando.");
    }
}*/


/*EJERCICIO 4.Diseño de clase para un libro:
• Define una clase llamada "Libro" con atributos como título, autor, año de
 publicación, género, etc. Incluye métodos para abrir, cerrar y leer.

public class Libro
{

    public string Titulo;
    public string Autor;
    public int AñoPublicacion;
    public string Genero;
    public bool EstaAbierto;

   
    public Libro(string titulo, string autor, int añoPublicacion, string genero)
    {
        Titulo = titulo;
        Autor = autor;
        AñoPublicacion = añoPublicacion;
        Genero = genero;
        EstaAbierto = false;
    }

   
    public void Abrir()
    {
        if (!EstaAbierto)
        {
            EstaAbierto = true;
            Console.WriteLine($"El libro \"{Titulo}\" está abierto.");
        }
        else
        {
            Console.WriteLine($"El libro \"{Titulo}\" ya está abierto.");
        }
    }

    public void Cerrar()
    {
        if (EstaAbierto)
        {
            EstaAbierto = false;
            Console.WriteLine($"El libro \"{Titulo}\" está cerrado.");
        }
        else
        {
            Console.WriteLine($"El libro \"{Titulo}\" ya está cerrado.");
        }
    }
    public void Leer()
    {
        if (EstaAbierto)
        {
            Console.WriteLine($"Leyendo el libro \"{Titulo}\" de {Autor}.");
        }
        else
        {
            Console.WriteLine($"Debes abrir el libro \"{Titulo}\" antes de leerlo.");
        }
    }*/
/*5.Diseño de clase para una biblioteca:
• Crea una clase "Biblioteca" con atributos como nombre, ubicación, horario de  apertura, etc. 
Define métodos para agregar libros al inventario, prestar libros, devolver libros y buscar libros por título o autor.*/

public class Libro
{
    public string Titulo; 
    public string Autor;  
    public bool Disponible; 

    
    public Libro(string titulo, string autor)
    {
        Titulo = titulo;
        Autor = autor;
        Disponible = true; 
    }
}

public class Biblioteca
{
    public string Nombre;
    public string Ubicacion;
    public string HorarioApertura;
    public Libro[] Inventario;
    public int TotalLibros;


    public Biblioteca(string nombre, string ubicacion, string horario, int capacidadInventario)
    {
        Nombre = nombre;
        Ubicacion = ubicacion;
        HorarioApertura = horario;
        Inventario = new Libro[capacidadInventario];
        TotalLibros = 0;
    }


    public void AgregarLibro(string titulo, string autor)
    {
        if (TotalLibros < Inventario.Length)
        {
            Inventario[TotalLibros] = new Libro(titulo, autor);
            TotalLibros++;
            Console.WriteLine($"El libro \"{titulo}\" de {autor} ha sido agregado al inventario.");
        }
        else
        {
            Console.WriteLine("El inventario de la biblioteca está lleno. No se puede agregar más libros.");
        }
    }


    public void PrestarLibro(string titulo)
    {
        for (int i = 0; i < TotalLibros; i++)
        {
            if (Inventario[i] != null && Inventario[i].Titulo == titulo && Inventario[i].Disponible)
            {
                Inventario[i].Disponible = false;
                Console.WriteLine($"El libro \"{titulo}\" ha sido prestado.");
                return;
            }
        }
        Console.WriteLine($"El libro \"{titulo}\" no está disponible o no se encuentra en el inventario.");
    }


    public void DevolverLibro(string titulo)
    {
        for (int i = 0; i < TotalLibros; i++)
        {
            if (Inventario[i] != null && Inventario[i].Titulo == titulo && !Inventario[i].Disponible)
            {
                Inventario[i].Disponible = true;
                Console.WriteLine($"El libro \"{titulo}\" ha sido devuelto.");
                return;
            }
        }
        Console.WriteLine($"El libro \"{titulo}\" no se encuentra prestado o no existe en el inventario.");
    }

    public void BuscarLibro(string criterio)
    {
        bool encontrado = false;

        for (int i = 0; i < TotalLibros; i++) 
        {
            if (Inventario[i] != null && (Inventario[i].Titulo.Contains(criterio) || Inventario[i].Autor.Contains(criterio)))
            {
               
                Console.WriteLine($"- {Inventario[i].Titulo} de {Inventario[i].Autor} - Disponible: {Inventario[i].Disponible}");
                encontrado = true;
            }
        }

        
        if (!encontrado)
        {
            Console.WriteLine($"No se encontraron libros que coincidan con \"{criterio}\".");
        }
    }
}

/*6. Diseño de clase para un cajero automático:
• Crea una clase "CajeroAutomático" con atributos como ubicación, número de serie,saldo disponible, etc.
 Implementa métodos para retirar dinero, depositar dinero y consultar saldo.
 
 

public class CajeroAutomatico
{
    
    public string Ubicacion;
    public string NumeroSerie;
    public decimal SaldoDisponible;


    public void EstablecerSaldo(decimal saldoInicial)
    {
        if (saldoInicial >= 0)
        {
            SaldoDisponible = saldoInicial;
            Console.WriteLine($"El saldo inicial del cajero se ha establecido en: ${SaldoDisponible}");
        }
        else
        {
            Console.WriteLine("El saldo inicial no puede ser negativo.");
        }
    }

    public void ConsultarSaldo()
    {
        Console.WriteLine($"El saldo disponible en el cajero es: ${SaldoDisponible}");
    }


    public void RetirarDinero(decimal monto)
    {
        if (monto > 0 && monto <= SaldoDisponible)
        {
            SaldoDisponible -= monto;
            Console.WriteLine($"Has retirado ${monto}. Saldo disponible: ${SaldoDisponible}");
        }
        else if (monto <= 0)
        {
            Console.WriteLine("El monto a retirar debe ser mayor que cero.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar esta operación.");
        }
    }


    public void DepositarDinero(decimal monto)
    {
        if (monto > 0)
        {
            SaldoDisponible += monto;
            Console.WriteLine($"Has depositado ${monto}. Saldo disponible: ${SaldoDisponible}");
        }
        else
        {
            Console.WriteLine("El monto a depositar debe ser mayor que cero.");
        }
    }
}*/
/*EJERCICIO 7 Diseño de clase para un sistema de gestión de empleados:
 • Define clases para representar empleados, departamentos, roles, etc. Incluye métodos
 para agregar empleados, asignar roles, calcular salarios, etc

public class Rol
{
    public string Nombre { get; set; }
    public decimal SalarioBase { get; set; }

    public Rol(string nombre, decimal salarioBase)
    {
        Nombre = nombre;
        SalarioBase = salarioBase;
    }
}

public class Departamento
{
    public string Nombre { get; set; }
    public List<Empleado> Empleados { get; set; }

    public Departamento(string nombre)
    {
        Nombre = nombre;
        Empleados = new List<Empleado>();
    }

    public void AgregarEmpleado(Empleado empleado)
    {
        Empleados.Add(empleado);
        Console.WriteLine($"El empleado {empleado.Nombre} ha sido agregado al departamento {Nombre}.");
    }
}

public class Empleado
{
    public string Nombre;
    public int Edad;
    public Rol Rol;

    public Empleado(string nombre, int edad)
    {
        Nombre = nombre;
        Edad = edad;
    }

    public void AsignarRol(Rol rol)
    {
        Rol = rol;
        Console.WriteLine($"El empleado {Nombre} ahora tiene el rol de {Rol.Nombre}.");
    }

    public decimal CalcularSalario()
    {
        if (Rol != null)
        {
            return Rol.SalarioBase;
        }
        else
        {
            Console.WriteLine("El empleado no tiene un rol asignado, por lo tanto no se puede calcular el salario.");
            return 0;
        }
    }
}*/








