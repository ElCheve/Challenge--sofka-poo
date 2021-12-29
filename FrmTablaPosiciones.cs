using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reto_Concurso_Preguntas_y_respuestas
{
    public partial class FrmTablaPosiciones : Form
    {
        public FrmTablaPosiciones()
        {
            InitializeComponent();

        }
        PlayerHistory history = new PlayerHistory();
        private void FrmTablaPosiciones_Load(object sender, EventArgs e)
        {
            history.Player(DtGrid);
        }
    }
}
