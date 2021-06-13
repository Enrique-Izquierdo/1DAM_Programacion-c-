using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_03
{
    class Program
    {
        static void Main(string[] args)
        {
            ProdFresco fresco1 = new ProdFresco(598, "28 marzo 2030", "abril 2021", "Francia");
            fresco1.VerInfo();
            fresco1.setFechaCad("abril 2029");
            fresco1.VerInfo();
            
            ProdFresco fresco2 = new ProdFresco(345, "23 marzo 2025", "abril 2019", "Noruega");
            fresco2.VerInfo();
            fresco2.setFechaCad("abril 2030");
            fresco2.VerInfo();
            Console.ReadKey();

            ProdRefrigerado refri1 = new ProdRefrigerado(8964, "12-2036", "10-2021", "Portugal", 4.5, "cvk-863");
            ProdRefrigerado refri2 = new ProdRefrigerado(41683, "10-2026", "1-2021", "Mexico", 4, "dask-863");
            ProdRefrigerado refri3 = new ProdRefrigerado(54, "12-2023", "9-2021", "España", 3, "cvk-863");
            refri1.VerInfo();
            refri2.VerInfo();
            refri3.VerInfo();
            Console.ReadKey();

            ProdCongAgua cAgua1 = new ProdCongAgua(789, "marzo 2025", "mayo 2018", "Marruecos", -20, 15.5);
            cAgua1.VerInfo();
            cAgua1.NumLote = 675;
            cAgua1.VerInfo();

            ProdCongAgua cAgua2 = new ProdCongAgua(598, "marzo 2035", "mayo 2020", "Mauritania", -30, 20.2);
            cAgua2.VerInfo();
            cAgua2.NumLote = 55;
            cAgua2.VerInfo();
            Console.ReadKey();

            ProdCongAire cAire1 = new ProdCongAire(5698, "diciembre 2028","enero 2020","EEUU",-15.5,
                3.2,4.3,30.1,60.32);
            cAire1.VerInfo();
            cAire1.setPorO2(2.3);
            cAire1.VerInfo();

            ProdCongAire cAire2 = new ProdCongAire(5698, "diciembre 2038", "enero 2021", "Rusia", -10.5,
                1.2, 6.3, 28.1, 50.32);
            cAire2.VerInfo();
            cAire2.setPorO2(7.3);
            cAire2.VerInfo();
            Console.ReadKey();

            ProdCongNitro congNitro1 = new ProdCongNitro(459, "enero 2025", "febrero 2015", "Estonia",
                -30.25, "inmersion", 3);
            congNitro1.VerInfo();
            Console.ReadKey();

        }
    }
}
