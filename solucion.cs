using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_cesar
{
    class solucion
    {
        static usuarios plun = new usuarios();

        public string crik;
        public int c, user = 1, da = 1, a, s, d, f;

        public void ser()
        {
            char OP = 's';
            while (OP != 'n')
            {
                Console.WriteLine("Elija una de las opciones: \n 1. Crear usuario \n 2. Buscar usuario \n 3. Modificar usuario \n 4.Eliminar usuario \n 5.Salir");
                c = int.Parse(Console.ReadLine());

                if (c == 1)
                {
                    Console.WriteLine("Elija una de las opciones: \n 1. Administrador \n 2. Trabajador");
                    f = int.Parse(Console.ReadLine());
                    if (f == 1)
                    {
                        for (s = 0; s < da; s++)
                        {
                            for (d = 0; d < user; d++)
                            {
                                Console.WriteLine("Ingrese un nombre: ");
                                plun.plun = Console.ReadLine();

                                Console.WriteLine("Ingrese una contraseña: ");
                                plun.dar = Console.ReadLine();
                            }
                        }
                    }
                    if (f == 2)
                    {
                        for (s = 0; s < da; s++)
                        {
                            for (d = 0; d < user; d++)
                            {
                                Console.WriteLine("Ingrese un nombre: ");
                                plun.der = Console.ReadLine();

                                Console.WriteLine("Ingrese una contraseña: ");
                                plun.dir = Console.ReadLine();

                            }
                        }
                    }
                }
                if (c == 2)
                {
                    Console.WriteLine("Elija una de las opciones: \n 1. Administrador \n 2. trabajador");
                    f = int.Parse(Console.ReadLine());
                    if (f == 1)
                    {
                        Console.WriteLine("Ingrese el nombre del usuario: ");
                        crik = Console.ReadLine();

                        for (s = 0; s < da; s++)
                        {
                            for (d = 0; d < user; d++)
                            {
                                if (crik == plun.plun)
                                {
                                    Console.WriteLine("Nombre: " + plun.plun);

                                    Console.WriteLine("Contraseña: " + plun.dar);
                                }
                                else
                                {
                                    Console.WriteLine("Usuario no regitrado antes");
                                }
                            }
                        }
                    }
                    if (f == 2)
                    {
                        Console.WriteLine("Ingrese el nombre del usuario: ");
                        crik = Console.ReadLine();

                        for (s = 0; s < da; s++)
                        {
                            for (d = 0; d < user; d++)
                            {
                                if (crik == plun.der)
                                {
                                    Console.WriteLine("Nombre: " + plun.der);

                                    Console.WriteLine("Contraseña: " + plun.dir);
                                }
                                else
                                {
                                    Console.WriteLine("Usuaario no registrado antes");
                                }
                            }
                        }
                    }
                }
                if (c == 3)
                {
                    Console.WriteLine("Elija una de las opciones: \n 1. Administrador \n 2. Trabajador");
                    f = int.Parse(Console.ReadLine());
                    if (f == 1)
                    {
                        Console.WriteLine("Ingrese el nombre del usuario: ");
                        crik = Console.ReadLine();
                        for (s = 0; s < da; s++)
                        {
                            for (d = 0; d < user; d++)
                            {
                                if (crik == plun.plun)
                                {
                                    plun.plun = "";

                                    plun.dar = "";

                                    Console.WriteLine("ingrese un nombre:");
                                    plun.plun = Console.ReadLine();

                                    Console.WriteLine("ingrese una contraseña:");
                                    plun.dar = Console.ReadLine();
                                }
                            }
                        }
                    }
                    if (f == 2)
                    {
                        Console.WriteLine("Ingrese el nombre del usuario: ");
                        crik = Console.ReadLine();
                        for (s = 0; s < da; s++)
                        {
                            for (d = 0; d < user; d++)
                            {
                                if (crik == plun.der)
                                {
                                    plun.der = "";

                                    plun.dir = "";

                                    Console.WriteLine("Ingrese un nombre:");
                                    plun.der = Console.ReadLine();

                                    Console.WriteLine("Ingrese una contraseña:");
                                    plun.dir = Console.ReadLine();
                                }
                            }
                        }
                    }

                }
                if (c == 4)
                {
                    Console.WriteLine("Elija una de las opciones: \n 1. Administrador \n 2. Trabajador");
                    f = int.Parse(Console.ReadLine());
                    if (f == 1)
                    {
                        Console.WriteLine("Ingrese el nombre del usuario: ");
                        crik = Console.ReadLine();
                        for (s = 0; s < da; s++)
                        {
                            for (d = 0; d < user; d++)
                            {
                                if (crik == plun.plun)
                                {
                                    plun.plun = "";

                                    plun.dar = "";

                                }
                            }
                        }
                    }
                    if (f == 2)
                    {
                        Console.WriteLine("ingrese el nombre del usuario: ");
                        crik = Console.ReadLine();
                        for (s = 0; s < da; s++)
                        {
                            for (d = 0; d < user; d++)
                            {
                                if (crik == plun.der)
                                {
                                    plun.der = "";

                                    plun.dir = "";

                                }
                            }
                        }
                    }
                }
                if (c == 5)
                {
                    Console.WriteLine("Desea relizar otra transaccion? [s/n]");
                    OP = char.Parse(Console.ReadLine());
                    Console.WriteLine("Desea regresar al inicio? \n 1. Si \n 2. No");
                    a = int.Parse(Console.ReadLine());
                    if (a == 1)
                    {
                        plun.plu();
                    }
                    else
                    {
                        Console.WriteLine("feliz dia");
                        Console.ReadKey();
                    }
                }

            }
            Console.ReadKey();
        }
    }
}