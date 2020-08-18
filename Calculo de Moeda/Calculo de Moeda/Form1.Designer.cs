namespace Calculo_de_Moeda
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btn_1 = new System.Windows.Forms.Button();
            this.rbtn_1 = new System.Windows.Forms.RadioButton();
            this.rbtn_5 = new System.Windows.Forms.RadioButton();
            this.rbtn_10 = new System.Windows.Forms.RadioButton();
            this.rbtn_25 = new System.Windows.Forms.RadioButton();
            this.rbtn_50 = new System.Windows.Forms.RadioButton();
            this.rbtn_1real = new System.Windows.Forms.RadioButton();
            this.btn_5 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_100 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_total = new System.Windows.Forms.Label();
            this.lbl_rstotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_rs1 = new System.Windows.Forms.Label();
            this.lbl_rs5 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_rs10 = new System.Windows.Forms.Label();
            this.lbl_10 = new System.Windows.Forms.Label();
            this.lbl_rs25 = new System.Windows.Forms.Label();
            this.lbl_25 = new System.Windows.Forms.Label();
            this.lbl_rs50 = new System.Windows.Forms.Label();
            this.lbl_50 = new System.Windows.Forms.Label();
            this.lbl_rs1real = new System.Windows.Forms.Label();
            this.lbl_1real = new System.Windows.Forms.Label();
            this.btn_sair = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.pbx_1real = new System.Windows.Forms.PictureBox();
            this.pbx_50cent = new System.Windows.Forms.PictureBox();
            this.pbx_25cent = new System.Windows.Forms.PictureBox();
            this.pbx_10cent = new System.Windows.Forms.PictureBox();
            this.pbx_5cent = new System.Windows.Forms.PictureBox();
            this.pbx_1cent = new System.Windows.Forms.PictureBox();
            this.rbtn_mais = new System.Windows.Forms.RadioButton();
            this.rbtn_menos = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_1percent = new System.Windows.Forms.Label();
            this.lbl_5percent = new System.Windows.Forms.Label();
            this.lbl_10percent = new System.Windows.Forms.Label();
            this.lbl_25percent = new System.Windows.Forms.Label();
            this.lbl_50percent = new System.Windows.Forms.Label();
            this.lbl_1realpercent = new System.Windows.Forms.Label();
            this.lbl_totalpercent = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_1real)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_50cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_25cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_10cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_5cent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_1cent)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(262, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contagem de Moedas";
            // 
            // btn_1
            // 
            this.btn_1.Location = new System.Drawing.Point(122, 31);
            this.btn_1.Name = "btn_1";
            this.btn_1.Size = new System.Drawing.Size(70, 51);
            this.btn_1.TabIndex = 1;
            this.btn_1.Text = "1";
            this.btn_1.UseVisualStyleBackColor = true;
            this.btn_1.Click += new System.EventHandler(this.btn_1_Click);
            // 
            // rbtn_1
            // 
            this.rbtn_1.AutoSize = true;
            this.rbtn_1.Checked = true;
            this.rbtn_1.Location = new System.Drawing.Point(133, 132);
            this.rbtn_1.Name = "rbtn_1";
            this.rbtn_1.Size = new System.Drawing.Size(14, 13);
            this.rbtn_1.TabIndex = 8;
            this.rbtn_1.TabStop = true;
            this.rbtn_1.UseVisualStyleBackColor = true;
            // 
            // rbtn_5
            // 
            this.rbtn_5.AutoSize = true;
            this.rbtn_5.Location = new System.Drawing.Point(228, 132);
            this.rbtn_5.Name = "rbtn_5";
            this.rbtn_5.Size = new System.Drawing.Size(14, 13);
            this.rbtn_5.TabIndex = 9;
            this.rbtn_5.UseVisualStyleBackColor = true;
            // 
            // rbtn_10
            // 
            this.rbtn_10.AutoSize = true;
            this.rbtn_10.Location = new System.Drawing.Point(320, 132);
            this.rbtn_10.Name = "rbtn_10";
            this.rbtn_10.Size = new System.Drawing.Size(14, 13);
            this.rbtn_10.TabIndex = 10;
            this.rbtn_10.UseVisualStyleBackColor = true;
            // 
            // rbtn_25
            // 
            this.rbtn_25.AutoSize = true;
            this.rbtn_25.Location = new System.Drawing.Point(423, 132);
            this.rbtn_25.Name = "rbtn_25";
            this.rbtn_25.Size = new System.Drawing.Size(14, 13);
            this.rbtn_25.TabIndex = 11;
            this.rbtn_25.UseVisualStyleBackColor = true;
            // 
            // rbtn_50
            // 
            this.rbtn_50.AutoSize = true;
            this.rbtn_50.Location = new System.Drawing.Point(515, 132);
            this.rbtn_50.Name = "rbtn_50";
            this.rbtn_50.Size = new System.Drawing.Size(14, 13);
            this.rbtn_50.TabIndex = 12;
            this.rbtn_50.UseVisualStyleBackColor = true;
            // 
            // rbtn_1real
            // 
            this.rbtn_1real.AutoSize = true;
            this.rbtn_1real.Location = new System.Drawing.Point(609, 132);
            this.rbtn_1real.Name = "rbtn_1real";
            this.rbtn_1real.Size = new System.Drawing.Size(14, 13);
            this.rbtn_1real.TabIndex = 13;
            this.rbtn_1real.UseVisualStyleBackColor = true;
            // 
            // btn_5
            // 
            this.btn_5.Location = new System.Drawing.Point(231, 31);
            this.btn_5.Name = "btn_5";
            this.btn_5.Size = new System.Drawing.Size(70, 51);
            this.btn_5.TabIndex = 14;
            this.btn_5.Text = "5";
            this.btn_5.UseVisualStyleBackColor = true;
            this.btn_5.Click += new System.EventHandler(this.btn_5_Click);
            // 
            // btn_10
            // 
            this.btn_10.Location = new System.Drawing.Point(339, 31);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(70, 51);
            this.btn_10.TabIndex = 15;
            this.btn_10.Text = "10";
            this.btn_10.UseVisualStyleBackColor = true;
            this.btn_10.Click += new System.EventHandler(this.btn_10_Click);
            // 
            // btn_50
            // 
            this.btn_50.Location = new System.Drawing.Point(450, 31);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(70, 51);
            this.btn_50.TabIndex = 16;
            this.btn_50.Text = "50";
            this.btn_50.UseVisualStyleBackColor = true;
            this.btn_50.Click += new System.EventHandler(this.btn_50_Click);
            // 
            // btn_100
            // 
            this.btn_100.Location = new System.Drawing.Point(560, 31);
            this.btn_100.Name = "btn_100";
            this.btn_100.Size = new System.Drawing.Size(70, 51);
            this.btn_100.TabIndex = 17;
            this.btn_100.Text = "100";
            this.btn_100.UseVisualStyleBackColor = true;
            this.btn_100.Click += new System.EventHandler(this.btn_100_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(679, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 23);
            this.label2.TabIndex = 18;
            this.label2.Text = "Total:";
            // 
            // lbl_total
            // 
            this.lbl_total.AutoSize = true;
            this.lbl_total.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total.Location = new System.Drawing.Point(695, 182);
            this.lbl_total.Name = "lbl_total";
            this.lbl_total.Size = new System.Drawing.Size(20, 23);
            this.lbl_total.TabIndex = 19;
            this.lbl_total.Text = "0";
            // 
            // lbl_rstotal
            // 
            this.lbl_rstotal.AutoSize = true;
            this.lbl_rstotal.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rstotal.Location = new System.Drawing.Point(695, 155);
            this.lbl_rstotal.Name = "lbl_rstotal";
            this.lbl_rstotal.Size = new System.Drawing.Size(20, 23);
            this.lbl_rstotal.TabIndex = 20;
            this.lbl_rstotal.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 23);
            this.label5.TabIndex = 21;
            this.label5.Text = "Total (R$):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 23);
            this.label6.TabIndex = 22;
            this.label6.Text = "Quantidade:";
            // 
            // lbl_1
            // 
            this.lbl_1.AutoSize = true;
            this.lbl_1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1.Location = new System.Drawing.Point(130, 182);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(20, 23);
            this.lbl_1.TabIndex = 23;
            this.lbl_1.Text = "0";
            // 
            // lbl_rs1
            // 
            this.lbl_rs1.AutoSize = true;
            this.lbl_rs1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rs1.Location = new System.Drawing.Point(130, 155);
            this.lbl_rs1.Name = "lbl_rs1";
            this.lbl_rs1.Size = new System.Drawing.Size(20, 23);
            this.lbl_rs1.TabIndex = 24;
            this.lbl_rs1.Text = "0";
            // 
            // lbl_rs5
            // 
            this.lbl_rs5.AutoSize = true;
            this.lbl_rs5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rs5.Location = new System.Drawing.Point(225, 157);
            this.lbl_rs5.Name = "lbl_rs5";
            this.lbl_rs5.Size = new System.Drawing.Size(20, 23);
            this.lbl_rs5.TabIndex = 25;
            this.lbl_rs5.Text = "0";
            // 
            // lbl_5
            // 
            this.lbl_5.AutoSize = true;
            this.lbl_5.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5.Location = new System.Drawing.Point(225, 182);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(20, 23);
            this.lbl_5.TabIndex = 26;
            this.lbl_5.Text = "0";
            // 
            // lbl_rs10
            // 
            this.lbl_rs10.AutoSize = true;
            this.lbl_rs10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rs10.Location = new System.Drawing.Point(317, 155);
            this.lbl_rs10.Name = "lbl_rs10";
            this.lbl_rs10.Size = new System.Drawing.Size(20, 23);
            this.lbl_rs10.TabIndex = 27;
            this.lbl_rs10.Text = "0";
            // 
            // lbl_10
            // 
            this.lbl_10.AutoSize = true;
            this.lbl_10.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_10.Location = new System.Drawing.Point(317, 182);
            this.lbl_10.Name = "lbl_10";
            this.lbl_10.Size = new System.Drawing.Size(20, 23);
            this.lbl_10.TabIndex = 28;
            this.lbl_10.Text = "0";
            // 
            // lbl_rs25
            // 
            this.lbl_rs25.AutoSize = true;
            this.lbl_rs25.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rs25.Location = new System.Drawing.Point(420, 155);
            this.lbl_rs25.Name = "lbl_rs25";
            this.lbl_rs25.Size = new System.Drawing.Size(20, 23);
            this.lbl_rs25.TabIndex = 29;
            this.lbl_rs25.Text = "0";
            // 
            // lbl_25
            // 
            this.lbl_25.AutoSize = true;
            this.lbl_25.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_25.Location = new System.Drawing.Point(420, 182);
            this.lbl_25.Name = "lbl_25";
            this.lbl_25.Size = new System.Drawing.Size(20, 23);
            this.lbl_25.TabIndex = 30;
            this.lbl_25.Text = "0";
            // 
            // lbl_rs50
            // 
            this.lbl_rs50.AutoSize = true;
            this.lbl_rs50.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rs50.Location = new System.Drawing.Point(512, 157);
            this.lbl_rs50.Name = "lbl_rs50";
            this.lbl_rs50.Size = new System.Drawing.Size(20, 23);
            this.lbl_rs50.TabIndex = 31;
            this.lbl_rs50.Text = "0";
            // 
            // lbl_50
            // 
            this.lbl_50.AutoSize = true;
            this.lbl_50.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_50.Location = new System.Drawing.Point(512, 182);
            this.lbl_50.Name = "lbl_50";
            this.lbl_50.Size = new System.Drawing.Size(20, 23);
            this.lbl_50.TabIndex = 32;
            this.lbl_50.Text = "0";
            // 
            // lbl_rs1real
            // 
            this.lbl_rs1real.AutoSize = true;
            this.lbl_rs1real.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_rs1real.Location = new System.Drawing.Point(606, 155);
            this.lbl_rs1real.Name = "lbl_rs1real";
            this.lbl_rs1real.Size = new System.Drawing.Size(20, 23);
            this.lbl_rs1real.TabIndex = 33;
            this.lbl_rs1real.Text = "0";
            // 
            // lbl_1real
            // 
            this.lbl_1real.AutoSize = true;
            this.lbl_1real.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1real.Location = new System.Drawing.Point(606, 182);
            this.lbl_1real.Name = "lbl_1real";
            this.lbl_1real.Size = new System.Drawing.Size(20, 23);
            this.lbl_1real.TabIndex = 34;
            this.lbl_1real.Text = "0";
            // 
            // btn_sair
            // 
            this.btn_sair.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sair.Location = new System.Drawing.Point(667, 306);
            this.btn_sair.Name = "btn_sair";
            this.btn_sair.Size = new System.Drawing.Size(75, 35);
            this.btn_sair.TabIndex = 35;
            this.btn_sair.Text = "Sair!";
            this.btn_sair.UseVisualStyleBackColor = true;
            this.btn_sair.Click += new System.EventHandler(this.btn_sair_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpar.Location = new System.Drawing.Point(667, 265);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(75, 35);
            this.btn_limpar.TabIndex = 36;
            this.btn_limpar.Text = "Limpar!";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // pbx_1real
            // 
            this.pbx_1real.Image = global::Calculo_de_Moeda.Properties.Resources._1real;
            this.pbx_1real.Location = new System.Drawing.Point(572, 40);
            this.pbx_1real.Name = "pbx_1real";
            this.pbx_1real.Size = new System.Drawing.Size(89, 86);
            this.pbx_1real.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_1real.TabIndex = 7;
            this.pbx_1real.TabStop = false;
            // 
            // pbx_50cent
            // 
            this.pbx_50cent.Image = global::Calculo_de_Moeda.Properties.Resources._50cent;
            this.pbx_50cent.Location = new System.Drawing.Point(477, 40);
            this.pbx_50cent.Name = "pbx_50cent";
            this.pbx_50cent.Size = new System.Drawing.Size(89, 86);
            this.pbx_50cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_50cent.TabIndex = 6;
            this.pbx_50cent.TabStop = false;
            // 
            // pbx_25cent
            // 
            this.pbx_25cent.Image = global::Calculo_de_Moeda.Properties.Resources._25cent;
            this.pbx_25cent.Location = new System.Drawing.Point(382, 40);
            this.pbx_25cent.Name = "pbx_25cent";
            this.pbx_25cent.Size = new System.Drawing.Size(89, 86);
            this.pbx_25cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_25cent.TabIndex = 5;
            this.pbx_25cent.TabStop = false;
            // 
            // pbx_10cent
            // 
            this.pbx_10cent.Image = global::Calculo_de_Moeda.Properties.Resources._10cent;
            this.pbx_10cent.Location = new System.Drawing.Point(287, 40);
            this.pbx_10cent.Name = "pbx_10cent";
            this.pbx_10cent.Size = new System.Drawing.Size(89, 86);
            this.pbx_10cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_10cent.TabIndex = 4;
            this.pbx_10cent.TabStop = false;
            // 
            // pbx_5cent
            // 
            this.pbx_5cent.Image = global::Calculo_de_Moeda.Properties.Resources._5cent;
            this.pbx_5cent.Location = new System.Drawing.Point(192, 40);
            this.pbx_5cent.Name = "pbx_5cent";
            this.pbx_5cent.Size = new System.Drawing.Size(89, 86);
            this.pbx_5cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_5cent.TabIndex = 3;
            this.pbx_5cent.TabStop = false;
            // 
            // pbx_1cent
            // 
            this.pbx_1cent.Image = global::Calculo_de_Moeda.Properties.Resources._1cent;
            this.pbx_1cent.Location = new System.Drawing.Point(97, 40);
            this.pbx_1cent.Name = "pbx_1cent";
            this.pbx_1cent.Size = new System.Drawing.Size(89, 86);
            this.pbx_1cent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_1cent.TabIndex = 2;
            this.pbx_1cent.TabStop = false;
            // 
            // rbtn_mais
            // 
            this.rbtn_mais.AutoSize = true;
            this.rbtn_mais.Checked = true;
            this.rbtn_mais.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_mais.Location = new System.Drawing.Point(21, 22);
            this.rbtn_mais.Name = "rbtn_mais";
            this.rbtn_mais.Size = new System.Drawing.Size(43, 33);
            this.rbtn_mais.TabIndex = 37;
            this.rbtn_mais.TabStop = true;
            this.rbtn_mais.Text = "+";
            this.rbtn_mais.UseVisualStyleBackColor = true;
            // 
            // rbtn_menos
            // 
            this.rbtn_menos.AutoSize = true;
            this.rbtn_menos.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtn_menos.Location = new System.Drawing.Point(21, 55);
            this.rbtn_menos.Name = "rbtn_menos";
            this.rbtn_menos.Size = new System.Drawing.Size(38, 33);
            this.rbtn_menos.TabIndex = 38;
            this.rbtn_menos.Text = "-";
            this.rbtn_menos.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtn_menos);
            this.groupBox1.Controls.Add(this.rbtn_mais);
            this.groupBox1.Controls.Add(this.btn_100);
            this.groupBox1.Controls.Add(this.btn_50);
            this.groupBox1.Controls.Add(this.btn_10);
            this.groupBox1.Controls.Add(this.btn_5);
            this.groupBox1.Controls.Add(this.btn_1);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 251);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(649, 90);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soma | Subtração";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 23);
            this.label4.TabIndex = 41;
            this.label4.Text = "%:";
            // 
            // lbl_1percent
            // 
            this.lbl_1percent.AutoSize = true;
            this.lbl_1percent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1percent.Location = new System.Drawing.Point(130, 216);
            this.lbl_1percent.Name = "lbl_1percent";
            this.lbl_1percent.Size = new System.Drawing.Size(34, 23);
            this.lbl_1percent.TabIndex = 42;
            this.lbl_1percent.Text = "0%";
            // 
            // lbl_5percent
            // 
            this.lbl_5percent.AutoSize = true;
            this.lbl_5percent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_5percent.Location = new System.Drawing.Point(225, 216);
            this.lbl_5percent.Name = "lbl_5percent";
            this.lbl_5percent.Size = new System.Drawing.Size(34, 23);
            this.lbl_5percent.TabIndex = 43;
            this.lbl_5percent.Text = "0%";
            // 
            // lbl_10percent
            // 
            this.lbl_10percent.AutoSize = true;
            this.lbl_10percent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_10percent.Location = new System.Drawing.Point(317, 216);
            this.lbl_10percent.Name = "lbl_10percent";
            this.lbl_10percent.Size = new System.Drawing.Size(34, 23);
            this.lbl_10percent.TabIndex = 44;
            this.lbl_10percent.Text = "0%";
            // 
            // lbl_25percent
            // 
            this.lbl_25percent.AutoSize = true;
            this.lbl_25percent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_25percent.Location = new System.Drawing.Point(420, 216);
            this.lbl_25percent.Name = "lbl_25percent";
            this.lbl_25percent.Size = new System.Drawing.Size(34, 23);
            this.lbl_25percent.TabIndex = 45;
            this.lbl_25percent.Text = "0%";
            // 
            // lbl_50percent
            // 
            this.lbl_50percent.AutoSize = true;
            this.lbl_50percent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_50percent.Location = new System.Drawing.Point(512, 216);
            this.lbl_50percent.Name = "lbl_50percent";
            this.lbl_50percent.Size = new System.Drawing.Size(34, 23);
            this.lbl_50percent.TabIndex = 46;
            this.lbl_50percent.Text = "0%";
            // 
            // lbl_1realpercent
            // 
            this.lbl_1realpercent.AutoSize = true;
            this.lbl_1realpercent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_1realpercent.Location = new System.Drawing.Point(605, 216);
            this.lbl_1realpercent.MaximumSize = new System.Drawing.Size(10, 10);
            this.lbl_1realpercent.Name = "lbl_1realpercent";
            this.lbl_1realpercent.Size = new System.Drawing.Size(10, 10);
            this.lbl_1realpercent.TabIndex = 47;
            this.lbl_1realpercent.Text = "0%";
            // 
            // lbl_totalpercent
            // 
            this.lbl_totalpercent.AutoSize = true;
            this.lbl_totalpercent.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalpercent.Location = new System.Drawing.Point(682, 216);
            this.lbl_totalpercent.Name = "lbl_totalpercent";
            this.lbl_totalpercent.Size = new System.Drawing.Size(0, 23);
            this.lbl_totalpercent.TabIndex = 48;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(746, 343);
            this.Controls.Add(this.lbl_totalpercent);
            this.Controls.Add(this.lbl_1realpercent);
            this.Controls.Add(this.lbl_50percent);
            this.Controls.Add(this.lbl_25percent);
            this.Controls.Add(this.lbl_10percent);
            this.Controls.Add(this.lbl_5percent);
            this.Controls.Add(this.lbl_1percent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_sair);
            this.Controls.Add(this.lbl_1real);
            this.Controls.Add(this.lbl_rs1real);
            this.Controls.Add(this.lbl_50);
            this.Controls.Add(this.lbl_rs50);
            this.Controls.Add(this.lbl_25);
            this.Controls.Add(this.lbl_rs25);
            this.Controls.Add(this.lbl_10);
            this.Controls.Add(this.lbl_rs10);
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.lbl_rs5);
            this.Controls.Add(this.lbl_rs1);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_rstotal);
            this.Controls.Add(this.lbl_total);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtn_1real);
            this.Controls.Add(this.rbtn_50);
            this.Controls.Add(this.rbtn_25);
            this.Controls.Add(this.rbtn_10);
            this.Controls.Add(this.rbtn_5);
            this.Controls.Add(this.rbtn_1);
            this.Controls.Add(this.pbx_1real);
            this.Controls.Add(this.pbx_50cent);
            this.Controls.Add(this.pbx_25cent);
            this.Controls.Add(this.pbx_10cent);
            this.Controls.Add(this.pbx_5cent);
            this.Controls.Add(this.pbx_1cent);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_1real)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_50cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_25cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_10cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_5cent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_1cent)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_1;
        private System.Windows.Forms.PictureBox pbx_1cent;
        private System.Windows.Forms.PictureBox pbx_5cent;
        private System.Windows.Forms.PictureBox pbx_10cent;
        private System.Windows.Forms.PictureBox pbx_25cent;
        private System.Windows.Forms.PictureBox pbx_50cent;
        private System.Windows.Forms.PictureBox pbx_1real;
        private System.Windows.Forms.RadioButton rbtn_1;
        private System.Windows.Forms.RadioButton rbtn_5;
        private System.Windows.Forms.RadioButton rbtn_10;
        private System.Windows.Forms.RadioButton rbtn_25;
        private System.Windows.Forms.RadioButton rbtn_50;
        private System.Windows.Forms.RadioButton rbtn_1real;
        private System.Windows.Forms.Button btn_5;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_100;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_total;
        private System.Windows.Forms.Label lbl_rstotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_rs1;
        private System.Windows.Forms.Label lbl_rs5;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Label lbl_rs10;
        private System.Windows.Forms.Label lbl_10;
        private System.Windows.Forms.Label lbl_rs25;
        private System.Windows.Forms.Label lbl_25;
        private System.Windows.Forms.Label lbl_rs50;
        private System.Windows.Forms.Label lbl_50;
        private System.Windows.Forms.Label lbl_rs1real;
        private System.Windows.Forms.Label lbl_1real;
        private System.Windows.Forms.Button btn_sair;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.RadioButton rbtn_mais;
        private System.Windows.Forms.RadioButton rbtn_menos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_1percent;
        private System.Windows.Forms.Label lbl_5percent;
        private System.Windows.Forms.Label lbl_10percent;
        private System.Windows.Forms.Label lbl_25percent;
        private System.Windows.Forms.Label lbl_50percent;
        private System.Windows.Forms.Label lbl_1realpercent;
        private System.Windows.Forms.Label lbl_totalpercent;
    }
}

