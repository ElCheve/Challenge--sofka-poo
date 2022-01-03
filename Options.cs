using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Concurso_Preguntas_y_respuestas
{
    class Options : Category
    {
        public string AnswerQ(string Dificulty, string question)
        {
            string A = "";
            switch (Dificulty)
            {
                case "Easy":
                    switch (question)
                    {
                        case "Question 1":
                            A= "86400";
                            break;
                        case "Question 2":
                            A = "8 legs";
                            break;
                        case "Question 3":
                            A = "Every month";
                            break;
                        case "Question 4":
                            A = "Mercury";
                            break;
                        case "Question 5":
                            A = "Paris France";
                            break;
                       
                    }
                    break;
                case "Medium":
                    switch (question)
                    {
                        case "Question 6":
                            A = "S";
                            break;
                        case "Question 7":
                            A = "4 apples";
                            break;
                        case "Question 8":
                            A = "Cat";
                            break;
                        case "Question 9":
                            A = "Both";
                            break;
                        case "Question 10":
                            A = "All days";
                            break;
                    }
                    break;
                case "Hard":
                    switch (question)
                    {
                        case "Question 11":
                            A = "Orange";
                            break;
                        case "Question 12":
                            A = "12";
                            break;
                        case "Question 13":
                            A = "One hour";
                            break;
                        case "Question 14":
                            A = "In the mouth";
                            break;
                        case "Question 15":
                            A = "There will be no smoke";
                            break;
                    }
                    break;
                case "Very hard":
                    switch (question)
                    {
                        case "Question 16":
                            A = "Alberto";
                            break;
                        case "Question 17":
                            A = "On november";
                            break;
                        case "Question 18":
                            A = "They owe their name to the dogs, in Latin called Canis.";
                            break;
                        case "Question 19":
                            A = "That is off";
                            break;
                        case "Question 20":
                            A = "In the dictionary";
                            break;
                    }
                    break;
                case "Expert":
                    switch (question)
                    {
                        case "Question 21":
                            A = "A linguistic curiosity that results in a paradox.";
                            break;
                        case "Question 22":
                            A = "A towel";
                            break;
                        case "Question 23":
                            A = "D";
                            break;
                        case "Question 24":
                            A = "A stair";
                            break;
                        case "Question 25":
                            A = "Air and / or light";
                            break;
                    }
                    break;
            }
            return A;

        }
    }
}
