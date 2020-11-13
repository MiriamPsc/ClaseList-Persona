using System;

namespace EstructuraClaseLista
{
    class Program
    {
        static void Main(string[] args)
        {
            int OpcionMenu = 0;
            ListaPersonas P = new ListaPersonas();
            string b;

            do
            {
                Console.WriteLine("\n                LISTA                ");
                Console.WriteLine("\n 1. AGREGAR       | 6. GUARDAR       ");
                Console.WriteLine("\n 2. BUSCAR        | 7. ABRIR         ");
                Console.WriteLine("\n 3. ELIMINAR      | 8. ELIMINAR LISTA");
                Console.WriteLine("\n 4. MOSTRAR       | 9. SALIR         ");
                Console.WriteLine("\n 5. CONTAR        |                  ");
                Console.WriteLine("\n           ELIJA UNA OPCIÓN:         ");
                OpcionMenu = Convert.ToInt32(Console.ReadLine());

                switch (OpcionMenu)
                {
                    case 1:
                        Console.WriteLine("\n AGREGAR ELEMENTO EN LA LISTA \n");
                        Console.WriteLine("\n AGREGAR NUEVOS DATOS \n");
                        Console.WriteLine("AGREGAR NOMBRE:");
                        b = Console.ReadLine();
                        if (P.BuscarAgregar(b)==false)
                        {
                            Persona n = new Persona();
                            n.Nombre = b;
                            Console.WriteLine("AGREGAR TELEFONO:");
                            n.Telefono = (Console.ReadLine());
                            P.Agregar(n);
                        }
                        else
                        {
                            Console.WriteLine("EL NOMBRE YA ESTÁ EN LA LISTA");
                        }
                        break;
                    case 2:
                        Console.WriteLine("\n BUSCAR UN ELEMENTO EN LA LISTA \n");
                        P.Buscar();
                        break;
                    case 3:
                        Console.WriteLine("\n ELIMINAR UN ELEMENTO DE LA LISTA \n");
                        P.Eliminar();
                        break;
                    case 4:
                        Console.WriteLine("\n MOSTRAR ELEMENTOS \n");
                        P.Mostrar();
                        break;
                    case 5:
                        Console.WriteLine("\n CONTAR ELEMENTOS \n");
                        P.Contar();
                        break;
                    case 6:
                        Console.WriteLine("\n GUARDAR LISTA \n");
                        P.GuardarLista();
                        break;
                    case 7:
                        Console.WriteLine("\n ABRIR LISTA \n");
                        P.AbrirLista();
                        break;
                    case 8:
                        Console.WriteLine("\n ELIMINAR LISTA \n");
                        P.EliminarLista();
                        break;
                    case 9:
                        Environment.Exit(-1);
                        break;
                }
            } while (OpcionMenu != 9);
        }

    }
}
