using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Reto_Concurso_Preguntas_y_respuestas
{
    public class RandomWords 
    {
        public ArrayList RAWords()
        {
            ArrayList ArrayWords = new ArrayList();
            ArrayWords.Add("Not use");
            ArrayWords.Add("Not use");
            ArrayWords.Add("Not use");
            ArrayWords.Add("6 legs");
            ArrayWords.Add("4 legs");
            ArrayWords.Add("5 legs");
            ArrayWords.Add("3 months");
            ArrayWords.Add("2 months");
            ArrayWords.Add("3 months");
            ArrayWords.Add("Earth");
            ArrayWords.Add("Neptune");
            ArrayWords.Add("Jupiter");
            ArrayWords.Add("Alemania");
            ArrayWords.Add("Colombia");
            ArrayWords.Add("France Aisne");
            ArrayWords.Add("J");
            ArrayWords.Add("P");
            ArrayWords.Add("F");
            ArrayWords.Add("3 apples");
            ArrayWords.Add("1 apple");
            ArrayWords.Add("5 apples");
            ArrayWords.Add("Tiger");
            ArrayWords.Add("Spider");
            ArrayWords.Add("Dog");
            ArrayWords.Add("Iron");
            ArrayWords.Add("Feathers");
            ArrayWords.Add("None");
            ArrayWords.Add("Monday");
            ArrayWords.Add("Sunday");
            ArrayWords.Add("Tuersday");
            ArrayWords.Add("Black");
            ArrayWords.Add("White");
            ArrayWords.Add("Blue");
            ArrayWords.Add("11");
            ArrayWords.Add("3");
            ArrayWords.Add("6");
            ArrayWords.Add("A murder");
            ArrayWords.Add("Any");
            ArrayWords.Add("A car");
            ArrayWords.Add("In the nose");
            ArrayWords.Add("On the foot");
            ArrayWords.Add("In the ear");
            ArrayWords.Add("40 km");
            ArrayWords.Add("30 km/h");
            ArrayWords.Add("60 jm/h");
            ArrayWords.Add("Juan ll");
            ArrayWords.Add("Daniel XV");
            ArrayWords.Add("Jorge VI");
            ArrayWords.Add("October");
            ArrayWords.Add("December");
            ArrayWords.Add("July");
            ArrayWords.Add("For the canaries");
            ArrayWords.Add("Fot the birds");
            ArrayWords.Add("For parrots");
            ArrayWords.Add("A lighter");
            ArrayWords.Add("A match");
            ArrayWords.Add("A candle");
            ArrayWords.Add("In the middle");
            ArrayWords.Add("Aside");
            ArrayWords.Add("Behind");
            ArrayWords.Add("This is how the creator of language wanted it");
            ArrayWords.Add("Because if");
            ArrayWords.Add("The reason is not known");
            ArrayWords.Add("A car");
            ArrayWords.Add("A top");
            ArrayWords.Add("A pirinola");
            ArrayWords.Add("The end");
            ArrayWords.Add("The new start");
            ArrayWords.Add("The end of the road");
            ArrayWords.Add("A computer");
            ArrayWords.Add("A jump");
            ArrayWords.Add("One friend");
            ArrayWords.Add("One pair");
            ArrayWords.Add("Transparency");
            ArrayWords.Add("The matter");
            ArrayWords.Add("The vacuum");
            ArrayWords.Add("F");
            return ArrayWords;
        }

        public void RanWords(string Dificulty, string question, System.Windows.Forms.Button FM1, System.Windows.Forms.Button FM2, System.Windows.Forms.Button FM3, ArrayList Words)
        {
            
            switch (Dificulty)
            {
                case "Easy":
                    switch (question)
                            
                    {
                        case "Question 1":
                            FM1.Text = Words[0].ToString();
                            FM2.Text = Words[1].ToString();
                            FM3.Text = Words[2].ToString();
                            break;
                        case "Question 2":
                            FM1.Text = Words[3].ToString();
                            FM2.Text = Words[4].ToString();
                            FM3.Text = Words[5].ToString();
                            break;
                        case "Question 3":
                            FM1.Text = Words[6].ToString();
                            FM2.Text = Words[7].ToString();
                            FM3.Text = Words[8].ToString();
                            break;
                        case "Question 4":
                            FM1.Text = Words[9].ToString();
                            FM2.Text = Words[10].ToString();
                            FM3.Text = Words[11].ToString();
                            break;
                        case "Question 5":
                            FM1.Text = Words[12].ToString();
                            FM2.Text = Words[13].ToString();
                            FM3.Text = Words[14].ToString();
                            break;
                    }
                    break;
                case "Medium":
                    switch (question)
                    {
                        case "Question 6":
                            FM1.Text = Words[15].ToString();
                            FM2.Text = Words[16].ToString();
                            FM3.Text = Words[17].ToString();
                            break;
                        case "Question 7":
                            FM1.Text = Words[18].ToString();
                            FM2.Text = Words[19].ToString();
                            FM3.Text = Words[20].ToString();
                            break;
                        case "Question 8":
                            FM1.Text = Words[21].ToString();
                            FM2.Text = Words[22].ToString();
                            FM3.Text = Words[23].ToString();
                            break;
                        case "Question 9":
                            FM1.Text = Words[24].ToString();
                            FM2.Text = Words[25].ToString();
                            FM3.Text = Words[26].ToString();
                            break;
                        case "Question 10":
                            FM1.Text = Words[27].ToString();
                            FM2.Text = Words[28].ToString();
                            FM3.Text = Words[29].ToString();
                            break;
                    }
                    break;
                case "Hard":
                    switch (question)
                    {
                        case "Question 11":
                            FM1.Text = Words[30].ToString();
                            FM2.Text = Words[31].ToString();
                            FM3.Text = Words[32].ToString();
                            break;
                        case "Question 12":
                            FM1.Text = Words[33].ToString();
                            FM2.Text = Words[34].ToString();
                            FM3.Text = Words[35].ToString();
                            break;
                        case "Question 13":
                            FM1.Text = Words[36].ToString();
                            FM2.Text = Words[37].ToString();
                            FM3.Text = Words[38].ToString();
                            break;
                        case "Question 14":
                            FM1.Text = Words[39].ToString();
                            FM2.Text = Words[40].ToString();
                            FM3.Text = Words[41].ToString();
                            break;
                        case "Question 15":
                            FM1.Text = Words[42].ToString();
                            FM2.Text = Words[43].ToString();
                            FM3.Text = Words[44].ToString();
                            break;
                    }
                    break;
                case "Very hard":
                    switch (question)
                    {
                        case "Question 16":
                            FM1.Text = Words[45].ToString();
                            FM2.Text = Words[46].ToString();
                            FM3.Text = Words[47].ToString();
                            break;
                        case "Question 17":
                            FM1.Text = Words[48].ToString();
                            FM2.Text = Words[49].ToString();
                            FM3.Text = Words[50].ToString();
                            break;
                        case "Question 18":
                            FM1.Text = Words[51].ToString();
                            FM2.Text = Words[52].ToString();
                            FM3.Text = Words[53].ToString();
                            break;
                        case "Question 19":
                            FM1.Text = Words[54].ToString();
                            FM2.Text = Words[55].ToString();
                            FM3.Text = Words[56].ToString();
                            break;
                        case "Question 20":
                            FM1.Text = Words[57].ToString();
                            FM2.Text = Words[58].ToString();
                            FM3.Text = Words[59].ToString();
                            break;
                    }
                    break;
                case "Expert":
                    switch (question)
                    {
                        case "Question 21":
                            FM1.Text = Words[60].ToString();
                            FM2.Text = Words[61].ToString();
                            FM3.Text = Words[62].ToString();
                            break;
                        case "Question 22":
                            FM1.Text = Words[63].ToString();
                            FM2.Text = Words[64].ToString();
                            FM3.Text = Words[65].ToString();
                            break;
                        case "Question 23":
                            FM1.Text = Words[66].ToString();
                            FM2.Text = Words[67].ToString();
                            FM3.Text = Words[68].ToString();
                            break;
                        case "Question 24":
                            FM1.Text = Words[69].ToString();
                            FM2.Text = Words[70].ToString();
                            FM3.Text = Words[71].ToString();
                            break;
                        case "Question 25":
                            FM1.Text = Words[72].ToString();
                            FM2.Text = Words[73].ToString();
                            FM3.Text = Words[74].ToString();
                            break;
                    }
                    break;
            }
            

        }
    
}
}
