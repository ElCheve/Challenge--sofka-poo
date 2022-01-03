using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Concurso_Preguntas_y_respuestas
{
    public class PrizePool
    {
        public int ConsultaJugador(string pNickName, string pNombre, string pApellido, string pPoolPrize)
        {
            int resultado = 0;

                SqlConnection conn = ConnectionDB.ConectarBD();
                SqlCommand comando = new SqlCommand(string.Format("select PLAYER.NickName,PLAYER.Nombres, PLAYER.Apellidos, PLAYER.Premio_Acumulado from PLAYER", pNickName, pNombre, pApellido, pPoolPrize), conn);
                resultado = comando.ExecuteNonQuery();
                conn.Close();
            return resultado;
        }
    }
}
