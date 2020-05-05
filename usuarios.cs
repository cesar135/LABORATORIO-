using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_cesar
{
    class usuarios
    {
        static inventario sar = new inventario();
        static solucion ser = new solucion();
        static factura sir = new factura();

        public int q, w, e;
        public string plun = "Cesar", dar = "987", der = "Pablo", dir = "654", p, o, i, u;
        public void plu()
        {
            Console.WriteLine("Empresa El Oriente");
            Console.WriteLine("Inicie secion: \n 1. Administrador \n 2. Trabajador \n 3.Salir");
            q = int.Parse(Console.ReadLine());

            if (q == 1)
            {
                Console.Write("Ingrese su nombre:");
                p = Console.ReadLine();

                if (plun == p)
                {
                    Console.Write("Ingrese su contraseña: ");
                    o = Console.ReadLine();

                    if (dar == o)
                    {
                        Console.WriteLine("Bienvenido \n Elija una opcion: \n 1. Inventario \n 2. Usuarios \n 3. Facturas \n 4. Salir");
                        w = int.Parse(Console.ReadLine());
                        if (w == 1)
                        {
                            sar.INA();
                        }
                        if (w == 2)
                        {
                            ser.ser();
                        }
                        if (w == 3)
                        {
                            sir.fak();
                        }
                        if (w == 4)
                        {
                            Console.WriteLine("Feliz dia");
                        }
                    }
                }
            }
            if (q == 2)
            {
                Console.Write("Ingrese su nombre: ");
                i = Console.ReadLine();

                if (der == i)
                {
                    Console.Write("Ingrese su contraseña: ");
                    u = Console.ReadLine();

                    if (dir == u)
                    {
                        Console.WriteLine("Bienveniddo, elija una de las opciones: \n 1.  Cargar inventario \n 2. Facturar \n 3. Salir ");
                        e = int.Parse(Console.ReadLine());
                        if (e == 1)
                        {
                            sar.INT();
                        }
                        if (e == 2)
                        {
                            sir.fa();
                        }
                        if (e == 3)
                        {
                            Console.WriteLine("Feliz dia");
                        }
                    }
                }
            }

            if (q == 3)
            {
                Console.WriteLine("feliz dia");
            }
            Console.ReadKey();
        }
    }
}
