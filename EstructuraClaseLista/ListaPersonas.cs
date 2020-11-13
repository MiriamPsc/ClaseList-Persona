using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace EstructuraClaseLista
{
    class ListaPersonas
    {
        public int index = 0;

        List<Persona> listPersona = new List<Persona>();
        Persona n = new Persona();

        public void Agregar(Persona n)
        {
            n.Id = index;
            listPersona.Add(n);
            index++;
        }
        public bool BuscarAgregar(string b)
        {
            Persona result = listPersona.Find(delegate(Persona nd)
            {
                return nd.Nombre == b;
            });
            if (result != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Mostrar()
        {
            foreach (Persona p in listPersona)
            {
                Console.WriteLine("ID:  " + p.Id);
                Console.WriteLine("NOMBRE:  " + p.Nombre);
                Console.WriteLine("TELÉFONO:  " + p.Telefono + "\n");
            }
        }
        public void Contar()
        {
            Console.WriteLine((from Id in listPersona where Id != null select Id).Count());
        }
        public void Buscar()
        {
            int busquedaMenu;
            int busquedaID;
            string busquedaNombre;
            string busquedaTelefono;
            Console.WriteLine("DATO A BUSCAR");
            Console.WriteLine("1:ID     2:NOMBRE     3:TELÉFONO");
            busquedaMenu = Convert.ToInt32(Console.ReadLine());

            switch (busquedaMenu)
            {
                case 1:
                    Console.WriteLine("BÚSQUEDA POR ID");
                    Console.WriteLine("ID A BUSCAR:");
                    busquedaID = Convert.ToInt32(Console.ReadLine());
                    foreach (Persona p in listPersona)
                    {
                        if (p.Id == busquedaID)
                        {
                            Console.WriteLine("ID:  " + p.Id);
                            Console.WriteLine("NOMBRE:  " + p.Nombre);
                            Console.WriteLine("TELEFONO:" + p.Telefono + "\n");
                        }
                    }
                    Console.WriteLine("NO SE ENCONTRÓ.");
                    break;
                case 2:
                    Console.WriteLine("BÚSQUEDA POR NOMBRE");
                    Console.WriteLine("NOMBRE A BUSCAR:");
                    busquedaNombre = (Console.ReadLine());
                    foreach (Persona p in listPersona)
                    {
                        if (p.Nombre == busquedaNombre)
                        {
                            Console.WriteLine("ID:  " + p.Id);
                            Console.WriteLine("NOMBRE:  " + p.Nombre);
                            Console.WriteLine("TELEFONO:" + p.Telefono + "\n");
                        }
                    }
                    Console.WriteLine("NO SE ENCONTRÓ.");
                    break;
                case 3:
                    Console.WriteLine("BÚSQUEDA POR TELÉFONO");
                    Console.WriteLine("TELÉFONO A BUSCAR:");
                    busquedaTelefono = (Console.ReadLine());
                    foreach (Persona p in listPersona)
                    {
                        if (p.Nombre == busquedaTelefono)
                        {
                            Console.WriteLine("ID:  " + p.Id);
                            Console.WriteLine("NOMBRE:  " + p.Nombre);
                            Console.WriteLine("TELEFONO:" + p.Telefono + "\n");
                        }
                    }
                    Console.WriteLine("NO SE ENCONTRÓ");
                    break;
                default:
                    Console.WriteLine("OPCIÓN INVÁLIDA");
                    break;
            }
        }
        public void Eliminar()
        {
            int eliminarMenu;
            int eliminarID;
            string eliminarNombre;
            string eliminarTelefono;
            Console.WriteLine("DATO A ELIMINAR / BUSCAR POR:");
            Console.WriteLine("1:ID     2:NOMBRE     3:TELÉFONO");
            eliminarMenu = Convert.ToInt32(Console.ReadLine());

            switch (eliminarMenu)
            {
                case 1:
                    Console.WriteLine("BÚSQUEDA POR ID");
                    Console.WriteLine("ID A BUSCAR:");
                    eliminarID = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < listPersona.Count(); i++)
                    {
                        if (listPersona[i].Id == eliminarID)
                        {
                            listPersona.Remove(listPersona[i]);
                            Console.WriteLine("ELEMENTOS ELIMINADOS");
                            return;
                        }
                    }
                    Console.WriteLine("NO SE ENCONTRÓ.");
                    break;
                   case 2:
                    Console.WriteLine("BÚSQUEDA POR NOMBRE");
                    Console.WriteLine("NOMBRE A BUSCAR:");
                    eliminarNombre = (Console.ReadLine());
                    for (int i = 0; i < listPersona.Count(); i++)
                    {
                        if (listPersona[i].Nombre == eliminarNombre)
                        {
                            listPersona.Remove(listPersona[i]);
                            Console.WriteLine("ELEMENTOS ELIMINADOS");
                            return;
                        }
                    }
                    Console.WriteLine("NO SE ENCONTRÓ.");
                    break;
                case 3:
                    Console.WriteLine("BÚSQUEDA POR TELÉFONO");
                    Console.WriteLine("NOMBRE A BUSCAR:");
                    eliminarTelefono = (Console.ReadLine());
                    for (int i = 0; i < listPersona.Count(); i++)
                    {
                        if (listPersona[i].Telefono == eliminarTelefono)
                        {
                            listPersona.Remove(listPersona[i]);
                            Console.WriteLine("ELEMENTOS ELIMINADOS");
                            return;
                        }
                    }
                    Console.WriteLine("NO SE ENCONTRÓ.");
                    break;
                default:
                    Console.WriteLine("OPCIÓN INVÁLIDA");
                    break;
            }

        }
        public void EliminarLista()
        {
            listPersona.Clear();
        }
        public void GuardarLista()
        {
            string ruta = @"C:\Users\miria\Desktop\Persona.txt";
            using (StreamWriter writer = new StreamWriter(ruta))
            {
                for (int i = 0; i < listPersona.Count(); i++)
                {
                    writer.WriteLine("ID: " + listPersona[i].Id.ToString());
                    writer.WriteLine("Nombre: " + listPersona[i].Nombre.ToString());
                    writer.WriteLine("Teléfono: " + listPersona[i].Telefono.ToString());
                }

            }

        }
        public void AbrirLista()
        {
            string ruta = @"C:\Users\miria\Desktop\Persona.txt";
            EliminarLista();
            string[] lineas = File.ReadAllLines(ruta);
            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].StartsWith("ID: "))
                {
                    lineas[i] = lineas[i].Replace("ID: ", "");
                    n.Id = Convert.ToInt32(lineas[i]);

                    if (lineas[i + 1].StartsWith("Nombre: "))
                    {
                        lineas[i + 1] = lineas[i+1].Replace("Nombre: ", "");
                        n.Nombre = lineas[i + 1];
                        if (lineas[i + 2].StartsWith("Teléfono: "))
                        {
                            lineas[i + 2] = lineas[i+2].Replace("Teléfono: ", "");
                            n.Telefono = lineas[i + 2];
                            Agregar(n);
                        }
                    }

                }
            }

        }
    }
}