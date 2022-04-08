using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamiaclasse
{
    public class Rettangolo
    {
        public int baseRettangolo;
        public int altezzaRettangolo;
       



       public Rettangolo(int baseRettangolo, int altezzaRettangolo)
        {
            this.baseRettangolo = baseRettangolo;
            this.altezzaRettangolo = altezzaRettangolo;

        }
        public int CalcolaArea(int baseRettangolo, int altezzaRettangolo)
        {
            
           int Area =  baseRettangolo * altezzaRettangolo;
           
            return Area;

        }
        public int CalcolaPerimetro(int baseRettangolo, int alezzaRettangolo)
        {
            int Perimetro = baseRettangolo + alezzaRettangolo;
            
            return Perimetro;
        }
        public void StampaRettangolo(int perimetro, int area)
        {
            int perimetroRettangolo = perimetro;
            int areaRettangolo = area;



            Console.WriteLine("--Rettangolo--");

                Console.WriteLine("base: " + baseRettangolo + "cm");
                Console.WriteLine("altezza: " + altezzaRettangolo + "cm");
                Console.WriteLine("perimetro: " + perimetro);
                Console.WriteLine("area: " + area);
            
            
        }
        public void disegna()
        {
            Console.Write("|");
            for (int i = 0; i < baseRettangolo; i++)
            {
                Console.Write("--");
               
            }


            for (int i = 0; i < altezzaRettangolo; i++)
            {

                Console.WriteLine("|");
            }

            for (int i2 = 0; i2 < baseRettangolo; i2++)
            {
                Console.Write("  ");

            }
            for (int i = 0; i < altezzaRettangolo -1; i++)
            {

                Console.WriteLine("|");
                break;
            }
            
        }
        
        
    }
}
