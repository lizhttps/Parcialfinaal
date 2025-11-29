using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;

/// clases bases. 

class Cliente
{
    public string Nombre { get; set; }
    public DateTime HoraLlegada { get; set; }
}

class Tecnico
{
    public string Nombre { get; set; }
    public int atendidos { get; set; }
    public bool Disponible { get; set; }
}


class Problema
{
    public string Nombre { get; set; }
    public Cliente cliente { get; set; }
}

///  MENU PRINCIPAL
///  
class menu
{
    Queue<Cliente> ColaClientes = new Queue<Cliente>(); // cola de clientes
    Stack<Problema> pilaProblemas = new Stack<Problema>(); // Pila para problemas
    List<Tecnico> listaTecnicos = new List<Tecnico>(); // Lista de tecnicos disponibles
    List<Cliente> clientesAtendidos = new List<Cliente>(); // Historial de clientes atendidos
    List<Problema> problemasResueltos = new List<Problema>(); // Historial de problemas Resueltos

public menu()
    {
        listaTecnicos.Add(new Tecnico { Nombre = "Lizmary", Disponible = true });
        listaTecnicos.Add(new Tecnico { Nombre = "Josue", Disponible = true });
        listaTecnicos.Add(new Tecnico { Nombre = "Wilmer", Disponible = true });
    }

    // Metodo para mostrar el menu prinicpal y captura la opcion seleccionada
    public void Mostrar()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---- CENTRO DE SOPORTE TECNICO ---");
            Console.WriteLine("1. Registrar Cliente");
            Console.WriteLine("2. Atender Cliente");
            Console.WriteLine("3. Ver Clientes en espera");
            Console.WriteLine("4. Registrar problema.");
            Console.WriteLine("5. Resolver problema.");
            Console.WriteLine("6. Ver problemas pendientes");
            Console.WriteLine("7. Ver reportes");
            Console.WriteLine("0. Salir");

            string opcion = Console.ReadLine(); /// Lee la opcion ingresada

            switch (opcion)
            {
                case "1":
                    RegistrarCliente();
                    break;

                case "2":
                    AtenderCliente();
                    break;

                case "3":
                    VerClientesEnEspera();
                    break;

                case "4":
                    RegistrarProblema();
                    break;

                case "5":
                    ResolverProblema();
                    break;

                case "6":
                    VerProblemasPendientes();
                    break;

                case "7":
                    VerReportes();
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Opcion INVALIDA, vuela a intentarlo");
                    Console.ReadKey();
                    break;
            }

        }
    }
 
    // CREAR METODOS DEL MENU 


