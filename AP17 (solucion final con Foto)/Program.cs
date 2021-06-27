using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP17
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Cambio la configuración regional (. signo decimal y , signo de millares)
            // o
            // Incluyo para que cambie la configuración regional a US (Inglesa/americana) con el 
            // objetivo de trabajar con el . como signo decimal (igual que MySql)
            // System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmUsuarios());
        }
    }
}
