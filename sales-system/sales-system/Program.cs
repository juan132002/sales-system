using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_system
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Name = "camisas";
            p1.Price = 4000;

            Product p2 = new Product();
            p2.Name = "tenis";
            p2.Price = 6000;


            Product p3 = new Product();
            p3.Name = "pijamas";
            p3.Price = 2000;

            Product p4 = new Product();
            p4.Name = "celulares";
            p4.Price = 1500;



            Seller s1 = new Seller();
            s1.Name = "Diego";
            s1.Age = 22;
            s1.AddProduct(p1);
            s1.AddProduct(p4);



            Seller s2 = new Seller();
            s2.Name = "Juana";
            s2.Age = 20;
            s2.AddProduct(p2);
            s2.AddProduct(p1);



            Seller s3 = new Seller();
            s3.Name = "Jose";
            s3.Age = 35;
            s3.AddProduct(p3);
            s3.AddProduct(p2);

            Seller s4 = new Seller();
            s4.Name = "David";
            s4.Age = 35;
            s4.AddProduct(p4);
            s4.AddProduct(p1);

            Ventas ventas = new Ventas();
            ventas.AddSeller(s1);
            ventas.AddSeller(s2);
            ventas.AddSeller(s3);
            ventas.AddSeller(s4);


            double totalVentas = ventas.TotalVentas();
            Console.WriteLine("total ventas: " + totalVentas);

            Seller ventaBarata = ventas.VentaBarata();
            Console.WriteLine("nombre :" + ventaBarata.Name);

            Product ProductoMasCaro = ventas.ProductoCaro();
            Console.WriteLine("Producto mas caro :" + ProductoMasCaro.Name);

            Console.ReadKey();



        }
    }
}
