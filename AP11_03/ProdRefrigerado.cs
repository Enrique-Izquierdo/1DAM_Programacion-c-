using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP11_03
{
    class ProdRefrigerado:ProdTratFrio
    {
        //atributos
        protected string codOrgSup;

        //propiedades
        public string CodOrgSup { get { return codOrgSup; } set { codOrgSup = value; } }

        //constructores
        public ProdRefrigerado(int numLote, string fechaCad, string fechaEnv, string paisOrigen, 
            double tempManto, string codOrgSup) : base(numLote, fechaCad, fechaEnv, paisOrigen, tempManto)
        {
            this.codOrgSup = codOrgSup;
        }

        //getters y setters
        public string getCodOrgSup() { return codOrgSup; }
        public void setCodOrgSup(string codOrgSup) { this.codOrgSup = codOrgSup; }

        //otros métodos interface
        public override void VerInfo()
        {
            base.VerInfo();
            Console.WriteLine(" -código organismo supervisor: {0}", codOrgSup);
        }

        //métodos implementación
    }
}
