using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Concurso_Preguntas_y_respuestas
{
    public class Round
    {
        public int count;

        public int count1;

        public string message;
        public int Count { get; set; }
        public int Count1 { get; set; }
        public void NRound(System.Windows.Forms.Label lblDif, System.Windows.Forms.Label lblCont, System.Windows.Forms.Label lblTitle, System.Windows.Forms.Label lblQ1, System.Windows.Forms.Label lblCont1)
        {
            count = int.Parse(lblCont.Text);
            count1 = int.Parse(lblCont1.Text);
            count1 = count1 + 50;
            count++;
            lblCont1.Text = count1.ToString();
            lblCont.Text = count.ToString();
            if (count == 5)
            {
                lblDif.Text = "Medium";
            }
            else if (count == 10)
            {
                lblDif.Text = "Hard";
            }
            else if (count == 15)
            {
                lblDif.Text = "Very hard";
            }
            else if (count == 20)
            {
                lblDif.Text = "Expert";
            }
            
            Category AQ = new Category();
            lblTitle.Text = "Question " + (count + 1);
            AQ.CategoryQuestions(lblDif.Text, lblTitle.Text, lblQ1);

        }
        public string Mensajito()
        {
            if (count == 25)
            {
                message = "Thanks for playing, you won: $ " + count1 + " USD";
                return message;
            }
            return "";
        }
        public string RetornarContador()
        {
            return count1.ToString();
        }
    }
}
