using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Concurso_Preguntas_y_respuestas
{
    public class ConnectionDB
    {
        public static SqlConnection ConectarBD()
        {
            SqlConnection connectionn = new SqlConnection("Data Source=DESKTOP-NHR73AG; Initial Catalog =ANSWERS_AND_QUESTIONS; Integrated Security = True");
            connectionn.Open();
            return connectionn;
        }
    }
}
