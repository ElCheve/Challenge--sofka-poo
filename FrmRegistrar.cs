using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto_Concurso_Preguntas_y_respuestas
{
    public partial class FrmRegistrar : Form
    {
        public FrmRegistrar()
        {
            InitializeComponent();
        }
        public bool confirmar=false;
        private void btn_Create_Account_Click(object sender, EventArgs e)
        {
            confirmar = true;
            Round round = new Round();
            string contador= round.RetornarContador();
            FrmMenu frmMenu = new FrmMenu();
            ConnectionUser cnu = new ConnectionUser();
            FrmTablaPosiciones tablaPosiciones= new FrmTablaPosiciones();
            string vacio = "";
            MessageBox.Show(round.count1.ToString());
            if (txtNickName.Text == vacio || txtNombres.Text == vacio || txtApellidos.Text == vacio)
                {
                    MessageBox.Show("Debe llenar todos los campos");
                }
                else if (cnu.CrearCuenta(txtNickName.Text, txtNombres.Text, txtApellidos.Text, round.count1.ToString()) > 0)
                {
                MessageBox.Show("¡Datos guardados exitosamente!");
                this.Hide();
                tablaPosiciones.ShowDialog();
                Application.Exit();
                }
                else
                {
                    MessageBox.Show("Este usuario ya existe");
                }
        }
    }
}

