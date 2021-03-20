using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sales_system
{
    public class Ventas
    {
        public Seller[] Sellers = new Seller[15];
        int sellerCount = 0;


        public void AddSeller(Seller newSeller)
        {
            Sellers[sellerCount] = newSeller;
            sellerCount++;
        }

        public double TotalVentas()
        {
            double totalventas = 0;
            for (int i = 0; i < sellerCount; i++)
            {
                totalventas = totalventas + Sellers[i].VentasTotales();
            }
            return totalventas;
        }

        public Seller VentaBarata()
        {
            Seller seller = Sellers[0];

            for (int p = 1; p < sellerCount; p++)
            {
                if (Sellers[p].VentaBarata().totalVentas() < seller.VentasTotales())
                {
                    seller = Sellers[p];
                }
            }

            return seller;
        }
        public Product ProductoCaro()
        {
            Product producto = Sellers[0].ProductoCaro();
            string Nombreproducto = Sellers[0].Name;

            for (int i = 0; i < sellerCount; i++)
            {
                if (Sellers[i].ProductoCaro().totalVentas() > producto.totalVentas())
                {
                    producto = Sellers[i].ProductoCaro();
                    Nombreproducto = Sellers[i].Name;
                }
            }
            return producto;

        }

    }

}
