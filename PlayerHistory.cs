using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Reto_Concurso_Preguntas_y_respuestas
{
    public class PlayerHistory
    {
        SqlConnection conn = ConnectionDB.ConectarBD();
        public void Player(System.Windows.Forms.DataGridView Dtg)
        {
            string consulta = "select PLAYER.NickName,PLAYER.Nombres, PLAYER.Apellidos, PLAYER.Premio_Acumulado from PLAYER order by PLAYER.Premio_Acumulado desc";
            SqlDataAdapter adp = new SqlDataAdapter(consulta, conn);
            DataTable dataTable = new DataTable();
            adp.Fill(dataTable);
            Dtg.DataSource = dataTable;
        }
    }
}
