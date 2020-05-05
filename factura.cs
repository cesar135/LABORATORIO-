using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABORATORIO_cesar
{
    class factura
    {
        static string area = "Factura.txt";
        static double ñ, l, k;
        static StreamWriter CLE;

        static string da(string f)
        {
            Console.WriteLine("Ingrese " + f + ":");
            return (Console.ReadLine());
        }
        static double val(double f)
        {
            try
            {
                Console.WriteLine("Ingrese precio" + f + ":");
                return double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("¡Ingrese valores numericos!");
                return double.Parse(Console.ReadLine());
            }
        }
        static double can(double f)
        {
            try
            {
                Console.WriteLine("Ingrese cantidad" + f + ":");
                return double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("¡Ingrese valores numericos!");
                return double.Parse(Console.ReadLine());
            }
        }
        static void cliente(string corre, string nom, string NIT, string fecha)
        {
            CLE = File.AppendText(area);
            CLE.WriteLine("Correlativo: " + corre + "\nCliente: " + nom + "\nNIT: " + NIT + "\nFecha: " + fecha);
            CLE.Close();
        }
        static void venta(string PRO)
        {
            CLE = File.AppendText(area);
            CLE.WriteLine("Producto:" + PRO);
            CLE.Close();
        }

        static double resultado(double s, double d)
        {
            double g;
            g = s * d;
            return g;
        }
        public void fa()
        {
            char OP = 's';
            cliente(da("Correlativo"), da("Nombre"), da("NIT"), da("Fecha"));
            double sop = 0;

            while (OP != 'n')
            {
                venta(da("Producto"));

                k = resultado(val(l), can(ñ));
                CLE = File.AppendText(area);
                CLE.WriteLine("Subtotal:" + k);
                CLE.Close();
                Console.WriteLine("Suntotal:" + k);
                Console.WriteLine("Desea realisar otra compra? [s/n]:");

                OP = char.Parse(Console.ReadLine());

                sop = sop + k;
            }
            CLE = File.AppendText(area);
            CLE.WriteLine("Total:" + sop);
            CLE.WriteLine("---------------------------");
            CLE.Close();

            Console.WriteLine("Total:" + sop);
            Console.WriteLine("feliz dia");
            Console.ReadLine();
        }
        public void fak()
        {
            TextReader lar;
            lar = new StreamReader("Factura.txt");
            Console.WriteLine(lar.ReadToEnd());
        }
    }
}