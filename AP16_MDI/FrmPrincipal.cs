using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AP16_MDI
{
    public partial class FrmPrincipal : Form
    {
        //atributos
        private FrmContable formCont1;
        private FrmAdministrativa formAdmin1;
        private FrmRecursosH formRecH1;

        //propiedades
        //constructores
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //getters y setters
        //otros métodos de interface
        //métodos de implementación
        private void mnuContable_Click(object sender, EventArgs e)
        {
            if (formCont1 == null)
            {
                formCont1 = new FrmContable();
                formCont1.MdiParent = this;
                /* Para que al cerrar el formulario "formCont1", se elimine
                 * la referecia a memoria del formulario "formCont1 = null", 
                 * debe asignarse el evento que elimina la referencia del 
                 * formulario "EliminarREFformCont1", al contralador que
                 * detecta el cierre del formulario "formCont1.FormClosed", 
                 * mediante la agregación de la instanciación de un delegado 
                 * del evento "new FormClosedEventHandler()" al contralador
                 * "formCont1.FormClosed". 
                 * NOTA: El parámeto del delegado del evento 
                 * "FormClosedEventHandler(parametro)" 
                 * es el manejador del evento "EliminarREFformCont1". */

                formCont1.FormClosed += new FormClosedEventHandler(EliminarREFformCont1);
                formCont1.Show();
            }
            else
            {
                formCont1.Activate();
            }
            
        }

        private void mnuAdministrativa_Click(object sender, EventArgs e)
        {
            if (formAdmin1 == null)
            {
                formAdmin1 = new FrmAdministrativa();
                formAdmin1.MdiParent = this;
                /* Para que al cerrar el formulario "formAdmin1", se elimine
                 * la referecia a memoria del formulario "formAdmin1 = null", 
                 * debe asignarse el evento que elimina la referencia del 
                 * formulario "EliminarREFformAdmin1", al contralador que
                 * detecta el cierre del formulario "formAdmin1.FormClosed", 
                 * mediante la agregación de la instanciación de un delegado 
                 * del evento "new FormClosedEventHandler()" al contralador
                 * "formAdmin1.FormClosed". 
                 * NOTA: El parámeto del delegado del evento 
                 * "FormClosedEventHandler(parametro)" 
                 * es el manejador del evento "EliminarREFformAdmin1". */

                formAdmin1.FormClosed += new FormClosedEventHandler(EliminarREFformAdmin1);
                formAdmin1.Show();
            }
            else
            {
                formAdmin1.Activate();
            }
        }

        private void mnuRecursosH_Click(object sender, EventArgs e)
        {
            formRecH1 = new FrmRecursosH();
            formRecH1.MdiParent = this;
            formRecH1.Show();
        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EliminarREFformCont1(object sender, EventArgs e)
        {
            formCont1 = null;
        }

        private void EliminarREFformAdmin1(object sender, EventArgs e)
        {
            formAdmin1 = null;
        }


    }
}
