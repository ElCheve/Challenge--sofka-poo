using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Concurso_Preguntas_y_respuestas
{
    public class ConnectionUser
    {
        public int CrearCuenta(string pNickName, string pNombre, string pApellido, string pPrizePool)
        {
            int resultado = 0;
            try
            {
                SqlConnection conn = ConnectionDB.ConectarBD();
                SqlCommand comando = new SqlCommand(string.Format("Insert Into PLAYER (NickName, Nombres, Apellidos, Premio_Acumulado) values ('{0}','{1}', '{2}', '{3}')", pNickName, pNombre, pApellido, pPrizePool), conn);
                resultado = comando.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                SqlError err = ex.Errors[0];
                string mensajee;
                switch (err.Number)
                {
                    case 2627:
                        mensajee = "No se pudieron guardar los datos";
                        break;
                    default:
                        mensajee = err.ToString();
                        break;
                }
                Console.WriteLine("Error con BBDD: {0}", mensajee);
            }
            return resultado;
        }
    }
}
