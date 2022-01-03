using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;

namespace Reto_Concurso_Preguntas_y_respuestas
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            BtnSiguientePregunta.Enabled = false;
        }
        public string total;
        public void BtnSiguientePregunta_Click(object sender, EventArgs e)
        {
            RandomWords RW = new RandomWords();
            ArrayList W = RW.RAWords();         
            Round round = new Round();
            round.NRound(LblDificulty, LblCount, LblTitle,LblQ1,LblCount1);
            Options AR = new Options();
            string R = AR.AnswerQ(LblDificulty.Text, LblTitle.Text);
            Random ra = new Random();
            int j = ra.Next(0, 3);
            if (j == 0)
            {
                BtnAR1.Text = R;
                RW.RanWords(LblDificulty.Text, LblTitle.Text, BtnAR4, BtnAR2, BtnAR3, W);
            }
            else if (j == 1)
            {
                RW.RanWords(LblDificulty.Text, LblTitle.Text, BtnAR4, BtnAR1, BtnAR3, W);
                BtnAR2.Text = R;
            }
            else if (j == 2)
            {
                RW.RanWords(LblDificulty.Text, LblTitle.Text, BtnAR4, BtnAR2, BtnAR1, W);
                BtnAR3.Text = R;
            }
            else if (j == 3)
            {
                RW.RanWords(LblDificulty.Text, LblTitle.Text, BtnAR1, BtnAR2, BtnAR3, W);
                BtnAR4.Text = R;
            }
            BtnSiguientePregunta.Enabled = false;
            if (round.Mensajito() != "")
            {
                this.LblA.Visible = false;
                this.LblB.Visible = false;
                this.LblC.Visible = false;
                this.LblD.Visible = false;
                this.LblCount.Visible = false;
                this.LblCount1.Visible = false;
                this.LblDificulty.Visible = false;
                this.LblStaticDificulty.Visible = false;
                this.LbltextAP.Visible = false;
                this.LblTitle.Visible = false;
                this.LblQ1.Visible = false;
                this.BtnAR1.Visible = false;
                this.BtnAR2.Visible = false;
                this.BtnAR3.Visible = false;
                this.BtnAR4.Visible = false;
                this.BtnSiguientePregunta.Visible = false;
                this.btnTabla.Visible = false;
                this.BtnRetirarme.Visible = false;
                MessageBox.Show(round.Mensajito());
                FrmRegistrar frmRegistrar = new FrmRegistrar();
                frmRegistrar.ShowDialog();
                Application.Exit();
            }
            
        }
        public void BtnAR1_Click(object sender, EventArgs e)
        {
            Options AR = new Options();
            string R = AR.AnswerQ(LblDificulty.Text, LblTitle.Text);
            if (BtnAR1.Text.Equals(R))
            {
                MessageBox.Show("The answer is correct");
                BtnSiguientePregunta.Enabled = true;                 
            }
            else
            {
                MessageBox.Show("The answer is incorrect, you lost all money");
                this.Close();
            }
        }

        public void BtnAR2_Click(object sender, EventArgs e)
        {
            Options AR = new Options();
            string R = AR.AnswerQ(LblDificulty.Text, LblTitle.Text);
            if (BtnAR2.Text.Equals(R))
            {
                MessageBox.Show("The answer is correct");
                BtnSiguientePregunta.Enabled = true;
            }
            else
            {
                MessageBox.Show("The answer is incorrect, you lost all money");
                this.Close();
            }
        }

        public void BtnAR3_Click(object sender, EventArgs e)
        {
            Options AR = new Options();
            string R = AR.AnswerQ(LblDificulty.Text, LblTitle.Text);           
            if (BtnAR3.Text.Equals(R))
            {
                MessageBox.Show("The answer is correct");
                BtnSiguientePregunta.Enabled = true;
            }
            else
            {
                MessageBox.Show("The answer is incorrect, you lost all money");
                this.Close();
            }
        }
        public void BtnAR4_Click(object sender, EventArgs e)
        {
            Options AR = new Options();
            string R = AR.AnswerQ(LblDificulty.Text, LblTitle.Text);
            if (BtnAR4.Text.Equals(R))
            {
                MessageBox.Show("The answer is correct");
                BtnSiguientePregunta.Enabled = true;
            }
            else
            {
                MessageBox.Show("The answer is incorrect, you lost all money");
                this.Close();
            }
        }

        public void btnTabla_Click(object sender, EventArgs e)
        {
            FrmTablaPosiciones frmtp = new FrmTablaPosiciones();
            frmtp.ShowDialog();

        }

        public void BtnRetirarme_Click(object sender, EventArgs e)
        {
            FrmRegistrar frmRegistrar = new FrmRegistrar();
            frmRegistrar.ShowDialog();
        }
        public string RetornarContador2()
        {
            Round rnd= new Round();
            return rnd.RetornarContador();
        }

    }
}
