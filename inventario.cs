using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_cesar
{
    class inventario
    {
        static usuarios plun = new usuarios();
        static inventario RES = new inventario();

        public string crik;
        public int k, pro = 1, da = 1, m, n, b;

        public int[,] ingresar;
        public string[,] nombre, cantidad, precio;

        public void INA()
        {
            Console.WriteLine("Inventario de administrador");
            char OP = 's';
            ingresar = new int[pro, da];
            nombre = new string[pro, da];
            cantidad = new string[pro, da];
            precio = new string[pro, da];

            while (OP != 'n')
            {

                Console.WriteLine("Elija una de las opciones: \n 1. Agregar producto \n 2. Buscar producto \n 3. Actualizar producto \n 4. eliminar producto \n 5. Salir");
                k = int.Parse(Console.ReadLine());

                if (k == 1)
                {
                    for (n = 0; n < da; n++)
                    {
                        for (b = 0; b < pro; b++)
                        {
                            Console.WriteLine("Ingrese nombre:");
                            nombre[n, b] = Console.ReadLine();

                            Console.WriteLine("Ingrese cantidad:");
                            cantidad[n, b] = Console.ReadLine();

                            Console.WriteLine("Ingrese precio:");
                            precio[n, b] = Console.ReadLine();
                        }
                    }
                }
                if (k == 2)
                {
                    Console.WriteLine("Ingrese nombre del producto: ");
                    crik = Console.ReadLine();

                    for (n = 0; n < da; n++)
                    {
                        for (b = 0; b < pro; b++)
                        {
                            if (crik == nombre[n, b])
                            {
                                Console.WriteLine("Nombre: " + nombre[n, b]);

                                Console.WriteLine("Unidades: " + cantidad[n, b]);

                                Console.WriteLine("Precio: " + precio[n, b]);
                            }
                            else
                            {
                                Console.WriteLine("Producto no registrado ");
                            }
                        }
                    }
                }
                if (k == 3)
                {
                    Console.WriteLine("Ingrese nombre de producto: ");
                    crik = Console.ReadLine();
                    for (n = 0; n < da; n++)
                    {
                        for (b = 0; b < pro; b++)
                        {
                            if (crik == nombre[n, b])
                            {
                                nombre[n, b] = "";

                                cantidad[n, b] = "";

                                precio[n, b] = "";

                                Console.WriteLine("Ingrese nombre :");
                                nombre[n, b] = Console.ReadLine();

                                Console.WriteLine("Ingrese cantidad:");
                                cantidad[n, b] = Console.ReadLine();

                                Console.WriteLine("Ingrese precio:");
                                precio[n, b] = Console.ReadLine();
                            }
                        }
                    }
                }
                if (k == 4)
                {
                    Console.WriteLine("Ingrese el nombre del producto: ");
                    crik = Console.ReadLine();
                    for (n = 0; n < da; n++)
                    {
                        for (b = 0; b < pro; b++)
                        {
                            if (crik == nombre[n, b])
                            {
                                nombre[n, b] = "";

                                cantidad[n, b] = "";

                                precio[n, b] = "";

                            }
                        }
                    }
                }
                if (k == 5)
                {
                    Console.WriteLine("Desea hacer otra transaccion? [s/n]");
                    OP = char.Parse(Console.ReadLine());

                    Console.WriteLine("Desea ir al inicio? \n 1. Si \n 2. No");
                    m = int.Parse(Console.ReadLine());
                    if (m == 1)
                    {
                        plun.plu();
                    }
                    else
                    {
                        Console.ReadKey();
                    }
                }
            }
            Console.ReadKey();
        }
        public void INT()
        {
            Console.WriteLine("Inventario de trabajadores");
            char OP = 's';

            while (OP != 'n')
            {
                Console.WriteLine("Elija una de las opciones: \n 1. Agregar producto \n 2. Buscar producto \n 3. Salir");

                k = int.Parse(Console.ReadLine());

                if (k == 1)
                {
                    for (n = 0; n < da; n++)
                    {
                        for (b = 0; b < pro; b++)
                        {
                            Console.WriteLine("Ingrese nombre:");
                            nombre[n, b] = Console.ReadLine();

                            Console.WriteLine("Ingrese cantidad:");
                            cantidad[n, b] = Console.ReadLine();

                            Console.WriteLine("Ingrese precio:");
                            precio[n, b] = Console.ReadLine();
                        }
                    }
                }
                if (k == 2)
                {
                    Console.WriteLine("Ingrese nombre del producto: ");
                    crik = Console.ReadLine();

                    for (n = 0; n < da; n++)
                    {
                        for (b = 0; b < pro; b++)
                        {
                            if (crik == nombre[n, b])
                            {
                                Console.WriteLine("Nombre: " + nombre[n, b]);

                                Console.WriteLine("Unidades: " + cantidad[n, b]);

                                Console.WriteLine("Precio: " + precio[n, b]);
                            }
                            else
                            {
                                Console.WriteLine("producto no registrado antes");
                            }
                        }
                    }
                }
                if (k == 3)
                {
                    Console.WriteLine("desea hacer otra transaccion? [s/n]");
                    OP = char.Parse(Console.ReadLine());
                    Console.WriteLine("DESEA IR AL INICIO? \n 1. Si \n 2. No");
                    m = int.Parse(Console.ReadLine());
                    if (m == 1)
                    {
                        plun.plu();
                    }
                    else
                    {
                        Console.ReadKey();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}