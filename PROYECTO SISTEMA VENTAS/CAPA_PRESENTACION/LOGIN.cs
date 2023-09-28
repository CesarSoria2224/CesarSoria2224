using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;
using CAPA_ENTIDAD;
 namespace CAPA_PRESENTACION {
    public partial class LOGIN : Form {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void btn_INGRESAR_Click(object sender, EventArgs e)
        {
            List<USUARIO> TEST = new CN_USUARIO().listar();
            USUARIO ousuario = new CN_USUARIO().listar().Where(u => u.NOMBRE_COMPLETO == txt_USUARIO.Text && u.CLAVE == txt_CONTRASENIA.Text).FirstOrDefault();

            if (ousuario != null)
            {
                INICIO form = new INICIO(); // nos enlaza al formulario de inicio
                form.Show(); // muestra el formulario enlazado
                this.Hide(); // oculta el formulario de login
                form.FormClosing += Mostrar_menu;
            }
            else
            {
                MessageBox.Show("usuario incorrecto", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        // muestra el formulario de logeo que se oculto con el this.hide
        private void Mostrar_menu(object sender, FormClosingEventArgs e)
        {

            txt_USUARIO.Text = "";
            txt_CONTRASENIA.Text = "";
            this.Show();

        }

        private void btn_CANCELAR_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
