using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Concurso_Preguntas_y_respuestas
{
    public class Category
    {   
        public void CategoryQuestions(string Dificulty, string question, System.Windows.Forms.Label lblQ1)
        {
            Questions QS=new Questions();   
            switch (Dificulty)
            {
                case "Easy":
                    lblQ1.Text = QS.QuestionsEAS(question);
                    break;
                case "Medium":
                    lblQ1.Text = QS.QuestionsMED(question);
                    break;
                case "Hard":
                    lblQ1.Text = QS.QuestionsHAR(question);
                    break;
                case "Very hard":
                    lblQ1.Text = QS.QuestionsVERHAR(question);
                    break;
                case "Expert":
                    lblQ1.Text = QS.QuestionsEXP(question);
                    break;
            }

        }
    }
}
