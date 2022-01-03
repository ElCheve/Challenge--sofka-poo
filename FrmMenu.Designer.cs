
namespace Reto_Concurso_Preguntas_y_respuestas
{
    partial class FrmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.BtnSiguientePregunta = new System.Windows.Forms.Button();
            this.LblQ1 = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.LblDificulty = new System.Windows.Forms.Label();
            this.BtnAR1 = new System.Windows.Forms.Button();
            this.BtnAR2 = new System.Windows.Forms.Button();
            this.BtnAR3 = new System.Windows.Forms.Button();
            this.BtnAR4 = new System.Windows.Forms.Button();
            this.LblCount = new System.Windows.Forms.Label();
            this.LblStaticDificulty = new System.Windows.Forms.Label();
            this.LblA = new System.Windows.Forms.Label();
            this.LblB = new System.Windows.Forms.Label();
            this.LblC = new System.Windows.Forms.Label();
            this.LblD = new System.Windows.Forms.Label();
            this.LbltextAP = new System.Windows.Forms.Label();
            this.LblCount1 = new System.Windows.Forms.Label();
            this.btnTabla = new System.Windows.Forms.Button();
            this.BtnRetirarme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnSiguientePregunta
            // 
            this.BtnSiguientePregunta.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSiguientePregunta.Location = new System.Drawing.Point(474, 498);
            this.BtnSiguientePregunta.Name = "BtnSiguientePregunta";
            this.BtnSiguientePregunta.Size = new System.Drawing.Size(285, 58);
            this.BtnSiguientePregunta.TabIndex = 0;
            this.BtnSiguientePregunta.Text = "Siguiente pregunta";
            this.BtnSiguientePregunta.UseVisualStyleBackColor = true;
            this.BtnSiguientePregunta.Click += new System.EventHandler(this.BtnSiguientePregunta_Click);
            // 
            // LblQ1
            // 
            this.LblQ1.AccessibleName = "";
            this.LblQ1.AutoSize = true;
            this.LblQ1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQ1.ForeColor = System.Drawing.Color.Black;
            this.LblQ1.Location = new System.Drawing.Point(393, 218);
            this.LblQ1.Name = "LblQ1";
            this.LblQ1.Size = new System.Drawing.Size(319, 27);
            this.LblQ1.TabIndex = 1;
            this.LblQ1.Text = "How many seconds does a day have?";
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.Location = new System.Drawing.Point(975, 99);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(100, 27);
            this.LblTitle.TabIndex = 7;
            this.LblTitle.Text = "Question 1";
            // 
            // LblDificulty
            // 
            this.LblDificulty.AutoSize = true;
            this.LblDificulty.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDificulty.Location = new System.Drawing.Point(220, 99);
            this.LblDificulty.Name = "LblDificulty";
            this.LblDificulty.Size = new System.Drawing.Size(53, 27);
            this.LblDificulty.TabIndex = 6;
            this.LblDificulty.Text = "Easy";
            // 
            // BtnAR1
            // 
            this.BtnAR1.FlatAppearance.BorderSize = 0;
            this.BtnAR1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BtnAR1.Location = new System.Drawing.Point(97, 401);
            this.BtnAR1.Name = "BtnAR1";
            this.BtnAR1.Size = new System.Drawing.Size(216, 42);
            this.BtnAR1.TabIndex = 2;
            this.BtnAR1.Text = "86400";
            this.BtnAR1.UseVisualStyleBackColor = true;
            this.BtnAR1.Click += new System.EventHandler(this.BtnAR1_Click);
            // 
            // BtnAR2
            // 
            this.BtnAR2.Location = new System.Drawing.Point(372, 401);
            this.BtnAR2.Name = "BtnAR2";
            this.BtnAR2.Size = new System.Drawing.Size(217, 42);
            this.BtnAR2.TabIndex = 3;
            this.BtnAR2.Text = "12000";
            this.BtnAR2.UseVisualStyleBackColor = true;
            this.BtnAR2.Click += new System.EventHandler(this.BtnAR2_Click);
            // 
            // BtnAR3
            // 
            this.BtnAR3.Location = new System.Drawing.Point(644, 401);
            this.BtnAR3.Name = "BtnAR3";
            this.BtnAR3.Size = new System.Drawing.Size(223, 42);
            this.BtnAR3.TabIndex = 4;
            this.BtnAR3.Text = "64000";
            this.BtnAR3.UseVisualStyleBackColor = true;
            this.BtnAR3.Click += new System.EventHandler(this.BtnAR3_Click);
            // 
            // BtnAR4
            // 
            this.BtnAR4.Location = new System.Drawing.Point(923, 401);
            this.BtnAR4.Name = "BtnAR4";
            this.BtnAR4.Size = new System.Drawing.Size(234, 42);
            this.BtnAR4.TabIndex = 5;
            this.BtnAR4.Text = "24000";
            this.BtnAR4.UseVisualStyleBackColor = true;
            this.BtnAR4.Click += new System.EventHandler(this.BtnAR4_Click);
            // 
            // LblCount
            // 
            this.LblCount.AutoSize = true;
            this.LblCount.Location = new System.Drawing.Point(12, 506);
            this.LblCount.Name = "LblCount";
            this.LblCount.Size = new System.Drawing.Size(14, 16);
            this.LblCount.TabIndex = 8;
            this.LblCount.Text = "0";
            this.LblCount.Visible = false;
            // 
            // LblStaticDificulty
            // 
            this.LblStaticDificulty.AutoSize = true;
            this.LblStaticDificulty.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblStaticDificulty.Location = new System.Drawing.Point(133, 99);
            this.LblStaticDificulty.Name = "LblStaticDificulty";
            this.LblStaticDificulty.Size = new System.Drawing.Size(86, 27);
            this.LblStaticDificulty.TabIndex = 9;
            this.LblStaticDificulty.Text = "Difficulty:";
            // 
            // LblA
            // 
            this.LblA.AutoSize = true;
            this.LblA.Location = new System.Drawing.Point(180, 372);
            this.LblA.Name = "LblA";
            this.LblA.Size = new System.Drawing.Size(20, 16);
            this.LblA.TabIndex = 10;
            this.LblA.Text = "A)";
            // 
            // LblB
            // 
            this.LblB.AutoSize = true;
            this.LblB.Location = new System.Drawing.Point(463, 372);
            this.LblB.Name = "LblB";
            this.LblB.Size = new System.Drawing.Size(20, 16);
            this.LblB.TabIndex = 11;
            this.LblB.Text = "B)";
            // 
            // LblC
            // 
            this.LblC.AutoSize = true;
            this.LblC.Location = new System.Drawing.Point(737, 372);
            this.LblC.Name = "LblC";
            this.LblC.Size = new System.Drawing.Size(20, 16);
            this.LblC.TabIndex = 12;
            this.LblC.Text = "C)";
            // 
            // LblD
            // 
            this.LblD.AutoSize = true;
            this.LblD.Location = new System.Drawing.Point(1016, 372);
            this.LblD.Name = "LblD";
            this.LblD.Size = new System.Drawing.Size(21, 16);
            this.LblD.TabIndex = 13;
            this.LblD.Text = "D)";
            // 
            // LbltextAP
            // 
            this.LbltextAP.AutoSize = true;
            this.LbltextAP.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbltextAP.Location = new System.Drawing.Point(510, 99);
            this.LbltextAP.Name = "LbltextAP";
            this.LbltextAP.Size = new System.Drawing.Size(182, 27);
            this.LbltextAP.TabIndex = 14;
            this.LbltextAP.Text = "Accumulated prize: $";
            // 
            // LblCount1
            // 
            this.LblCount1.AutoSize = true;
            this.LblCount1.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCount1.Location = new System.Drawing.Point(711, 99);
            this.LblCount1.Name = "LblCount1";
            this.LblCount1.Size = new System.Drawing.Size(22, 27);
            this.LblCount1.TabIndex = 15;
            this.LblCount1.Text = "0";
            // 
            // btnTabla
            // 
            this.btnTabla.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTabla.Location = new System.Drawing.Point(107, 498);
            this.btnTabla.Name = "btnTabla";
            this.btnTabla.Size = new System.Drawing.Size(285, 58);
            this.btnTabla.TabIndex = 17;
            this.btnTabla.Text = "Consulltar tabla de posiciones";
            this.btnTabla.UseVisualStyleBackColor = true;
            this.btnTabla.Click += new System.EventHandler(this.btnTabla_Click);
            // 
            // BtnRetirarme
            // 
            this.BtnRetirarme.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRetirarme.Location = new System.Drawing.Point(941, 497);
            this.BtnRetirarme.Name = "BtnRetirarme";
            this.BtnRetirarme.Size = new System.Drawing.Size(234, 58);
            this.BtnRetirarme.TabIndex = 18;
            this.BtnRetirarme.Text = "Retirarme";
            this.BtnRetirarme.UseVisualStyleBackColor = true;
            this.BtnRetirarme.Click += new System.EventHandler(this.BtnRetirarme_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.BtnRetirarme);
            this.Controls.Add(this.btnTabla);
            this.Controls.Add(this.LblCount1);
            this.Controls.Add(this.LbltextAP);
            this.Controls.Add(this.LblD);
            this.Controls.Add(this.LblC);
            this.Controls.Add(this.LblB);
            this.Controls.Add(this.LblA);
            this.Controls.Add(this.LblStaticDificulty);
            this.Controls.Add(this.LblCount);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.LblDificulty);
            this.Controls.Add(this.BtnAR4);
            this.Controls.Add(this.BtnAR3);
            this.Controls.Add(this.BtnAR2);
            this.Controls.Add(this.BtnAR1);
            this.Controls.Add(this.LblQ1);
            this.Controls.Add(this.BtnSiguientePregunta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TheQuestion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSiguientePregunta;
        private System.Windows.Forms.Label LblQ1;
        private System.Windows.Forms.Button BtnAR2;
        private System.Windows.Forms.Button BtnAR3;
        private System.Windows.Forms.Button BtnAR4;
        private System.Windows.Forms.Label LblDificulty;
        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblCount;
        private System.Windows.Forms.Label LblStaticDificulty;
        private System.Windows.Forms.Button BtnAR1;
        private System.Windows.Forms.Label LblA;
        private System.Windows.Forms.Label LblB;
        private System.Windows.Forms.Label LblC;
        private System.Windows.Forms.Label LblD;
        private System.Windows.Forms.Label LbltextAP;
        private System.Windows.Forms.Label LblCount1;
        private System.Windows.Forms.Button btnTabla;
        private System.Windows.Forms.Button BtnRetirarme;
    }
}

