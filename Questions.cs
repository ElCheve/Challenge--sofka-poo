using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reto_Concurso_Preguntas_y_respuestas
{
    public class Questions
    {
        public string QuestionsEAS(string question)
        {
            string Q = "";
            if(question.Equals("Question 1"))
            {
                Q = "How many seconds does a day have?";
                return Q;
            }
            else if (question.Equals("Question 2"))
            {
                Q = "How many legs does a spider have ?";
                return Q;
            }
            else if (question.Equals("Question 3"))
            {
                Q = "How many months have 28 days?";
                return Q;
            }
            else if (question.Equals("Question 4"))
            {
                Q = "Which planet is closest to the Sun?";
                return Q;
            }
            else if (question.Equals("Question 5"))
            {
                Q = "In which city and in which country is the Eiffel Tower located?";
                return Q;
            }
            return Q;
        }
        public string QuestionsMED(string question)
        {
            string Q = "";
            if (question.Equals("Question 6"))
            {
                Q = "Paris starts with p, and ends with...?";
                return Q;
            }
            else if (question.Equals("Question 7"))
            {
                Q = "If Pedro has six apples, he washes four to eat and his brother eats two.\nHow many apples does Pedro have?";
                return Q;
            }
            else if (question.Equals("Question 8"))
            {
                Q = "What is the animal that is twice an animal?";
                return Q;
            }
            else if (question.Equals("Question 9"))
            {
                Q = "What weighs more, a kilo of iron or a kilo of feathers?";
                return Q;
            }
            else if (question.Equals("Question 10"))
            {
                Q = "What is the longest day of the week?";
                return Q;
            }
            return Q;
        }
        public string QuestionsHAR(string question)
        {
            string Q = "";
            if (question.Equals("Question 11"))
            {
                Q = "What color are the 'black boxes' on airplanes?";
                return Q;
            }
            else if (question.Equals("Question 12"))
            {
                Q = "If there are 12 fish in a tank and 5 of them drown,\n how many fish are left?";
                return Q;
            }
            else if (question.Equals("Question 13"))
            {
                Q = "What happened yesterday in Paris from 6 to 7?";
                return Q;
            }
            else if (question.Equals("Question 14"))
            {
                Q = "If a baby is born in Colombia, but goes to Ecuador after two years,\nwhere do its teeth grow?";
                return Q;
            }
            else if (question.Equals("Question 15"))
            {
                Q = "If an electric train is moving north at 100 km / h\nand the wind is blowing west at 10 km / h,where will the smoke go?";
                return Q;
            }
            return Q;
        }
        public string QuestionsVERHAR(string question)
        {
            string Q = "";
            if (question.Equals("Question 16"))
            {
                Q = "What was the first name of King George VI?";
                return Q;
            }
            else if (question.Equals("Question 17"))
            {
                Q = "In what month do Russians celebrate the 'October Revolution'?";
                return Q;
            }
            else if (question.Equals("Question 18"))
            {
                Q = "What animal do the Canary Islands get their name from?";
                return Q;
            }
            else if (question.Equals("Question 19"))
            {
                Q = "What does it take to light a candle?";
                return Q;
            }
            else if (question.Equals("Question 20"))
            {
                Q = "Where is Thursday before Wednesday?";
                return Q;
            }
            return Q;
        }
        public string QuestionsEXP(string question)
        {
            string Q = "";
            if (question.Equals("Question 21"))
            {
                Q = "For what reason is 'separate' written all together and\n'all together'\nwritten separately?";
                return Q;
            }
            else if (question.Equals("Question 22"))
            {
                Q = "What gets wet while it dries?";
                return Q;
            }
            else if (question.Equals("Question 23"))
            {
                Q = "What is the end of it all?";
                return Q;
            }
            else if (question.Equals("Question 24"))
            {
                Q = "What goes up and down, but is still in the same place?";
                return Q;
            }
            else if (question.Equals("Question 25"))
            {
                Q = "What can fill a room, but does not take up space?";
                return Q;
            }
            return Q;
        }
    }
}
