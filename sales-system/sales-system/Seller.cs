using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_system
{
    public class Seller
    {
        public string Name;
        public int Age;

        public Product[] Products = new Product[15];
        int productCount = 0;

        public void AddProduct(Product newProduct)
        {
            Products[productCount] = newProduct;
            productCount++;
        }

        public double VentasTotales()
        {
            double Ventastotales = 0;
            {
                for (int s = 0; s < productCount; s++)
                {
                    double Resultadototal = Products[s].totalVentas();
                    Ventastotales = Ventastotales + Resultadototal;

                }
            }
            return Ventastotales;

        }

        public Product VentaBarata()
        {
            Product venta = Products[0];

            for (int i = 1; i < productCount; i++)
            {
                venta = Products[i];

            }
            return venta;

        }

        public Product ProductoCaro()
        {
            Product venta = Products[0];

            for (int t = 1; t < productCount; t++)
            {
                venta = Products[t];

            }
            return venta;
        }

    }
}
