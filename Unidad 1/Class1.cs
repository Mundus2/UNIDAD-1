using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unidad_1
{
    internal class Class1
    { 
    }


// Definición de la clase Empleado
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public double Salario { get; set; }

        // Constructor
        public Empleado(int id, string nombre, string puesto, double salario)
        {
            Id = id;
            Nombre = nombre;
            Puesto = puesto;
            Salario = salario;
        }

        // Método para imprimir la información del empleado
        public void MostrarInformacion()
        {
            Console.WriteLine($"ID: {Id}, Nombre: {Nombre}, Puesto: {Puesto}, Salario: {Salario:C}");
        }
    }

    // Clase principal del programa
    class main
    {
        // Lista para almacenar los empleados
        static List<Empleado> empleados = new List<Empleado>();

        // Método para agregar un nuevo empleado a la lista
        static void AgregarEmpleado()
        {
            Console.WriteLine("Ingrese el ID del empleado:");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el nombre del empleado:");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el puesto del empleado:");
            string puesto = Console.ReadLine();

            Console.WriteLine("Ingrese el salario del empleado:");
            double salario = Convert.ToDouble(Console.ReadLine());

            Empleado nuevoEmpleado = new Empleado(id, nombre, puesto, salario);
            empleados.Add(nuevoEmpleado);

            Console.WriteLine("Empleado agregado correctamente.");
        }

        // Método para listar todos los empleados
        static void ListarEmpleados()
        {
            Console.WriteLine("Lista de Empleados:");
            foreach (var empleado in empleados)
            {
                empleado.MostrarInformacion();
            }
        }

        // Método para calcular el salario total de la empresa
        static void CalcularSalarioTotal()
        {
            double salarioTotal = 0;
            foreach (var empleado in empleados)
            {
                salarioTotal += empleado.Salario;
            }
            Console.WriteLine($"El salario total de la empresa es: {salarioTotal:C}");
        }

        // Método principal (Main)
        static void Main()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("\nSistema de Gestión de Empleados");
                Console.WriteLine("1. Agregar Empleado");
                Console.WriteLine("2. Listar Empleados");
                Console.WriteLine("3. Calcular Salario Total");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opción:");

                string opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        AgregarEmpleado();
                        break;
                    case "2":
                        ListarEmpleados();
                        break;
                    case "3":
                        CalcularSalarioTotal();
                        break;
                    case "4":
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;
                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }
            }
        }
    }

}

