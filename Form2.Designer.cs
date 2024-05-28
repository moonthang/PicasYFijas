namespace Pica_Y_Fija
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            labelTitulo = new Label();
            labelNumeroAleatorio = new Label();
            label3 = new Label();
            labelMinR = new Label();
            labelInt = new Label();
            labelH = new Label();
            labelIntentos = new Label();
            buttonJugar = new Button();
            buttonComparar = new Button();
            buttonReglamento = new Button();
            buttonRegresar = new Button();
            ImgReglamento = new PictureBox();
            ImgRegresar = new PictureBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            listBox1 = new ListBox();
            label6 = new Label();
            labelSeg = new Label();
            timerTiempo = new System.Windows.Forms.Timer(components);
            pictureBox1 = new PictureBox();
            labelGP = new Label();
            ((System.ComponentModel.ISupportInitialize)ImgReglamento).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ImgRegresar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.BackColor = Color.Transparent;
            labelTitulo.Font = new Font("Kanit Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelTitulo.ForeColor = Color.White;
            labelTitulo.Location = new Point(655, 21);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(252, 56);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "PICAS Y FIJAS";
            // 
            // labelNumeroAleatorio
            // 
            labelNumeroAleatorio.AutoSize = true;
            labelNumeroAleatorio.BackColor = Color.Transparent;
            labelNumeroAleatorio.Font = new Font("Kanit Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumeroAleatorio.ForeColor = Color.White;
            labelNumeroAleatorio.Location = new Point(611, 88);
            labelNumeroAleatorio.Name = "labelNumeroAleatorio";
            labelNumeroAleatorio.Size = new Size(67, 56);
            labelNumeroAleatorio.TabIndex = 1;
            labelNumeroAleatorio.Text = "N°:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Kanit", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(671, 88);
            label3.Name = "label3";
            label3.Size = new Size(42, 56);
            label3.TabIndex = 2;
            label3.Text = "...";
            // 
            // labelMinR
            // 
            labelMinR.AutoSize = true;
            labelMinR.BackColor = Color.Transparent;
            labelMinR.Font = new Font("Kanit", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelMinR.ForeColor = Color.White;
            labelMinR.Location = new Point(41, 102);
            labelMinR.Name = "labelMinR";
            labelMinR.Size = new Size(94, 35);
            labelMinR.TabIndex = 3;
            labelMinR.Text = "FALTAN:";
            // 
            // labelInt
            // 
            labelInt.AutoSize = true;
            labelInt.BackColor = Color.Transparent;
            labelInt.Font = new Font("Kanit", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelInt.ForeColor = Color.White;
            labelInt.Location = new Point(351, 102);
            labelInt.Name = "labelInt";
            labelInt.Size = new Size(119, 35);
            labelInt.TabIndex = 4;
            labelInt.Text = "INTENTOS:";
            // 
            // labelH
            // 
            labelH.AutoSize = true;
            labelH.BackColor = Color.Transparent;
            labelH.Font = new Font("Kanit Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelH.ForeColor = Color.White;
            labelH.Location = new Point(141, 88);
            labelH.Name = "labelH";
            labelH.Size = new Size(31, 56);
            labelH.TabIndex = 5;
            labelH.Text = ".";
            // 
            // labelIntentos
            // 
            labelIntentos.AutoSize = true;
            labelIntentos.BackColor = Color.Transparent;
            labelIntentos.Font = new Font("Kanit Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelIntentos.ForeColor = Color.White;
            labelIntentos.Location = new Point(461, 88);
            labelIntentos.Name = "labelIntentos";
            labelIntentos.Size = new Size(72, 56);
            labelIntentos.TabIndex = 6;
            labelIntentos.Text = "00";
            // 
            // buttonJugar
            // 
            buttonJugar.BackColor = Color.Lime;
            buttonJugar.FlatStyle = FlatStyle.Popup;
            buttonJugar.Font = new Font("Product Sans", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonJugar.ForeColor = Color.White;
            buttonJugar.Location = new Point(54, 453);
            buttonJugar.Name = "buttonJugar";
            buttonJugar.Size = new Size(111, 33);
            buttonJugar.TabIndex = 7;
            buttonJugar.Text = "JUGAR";
            buttonJugar.UseVisualStyleBackColor = false;
            buttonJugar.Click += buttonJugar_Click;
            // 
            // buttonComparar
            // 
            buttonComparar.BackColor = Color.Orange;
            buttonComparar.FlatStyle = FlatStyle.Popup;
            buttonComparar.Font = new Font("Product Sans", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonComparar.ForeColor = Color.White;
            buttonComparar.Location = new Point(377, 453);
            buttonComparar.Name = "buttonComparar";
            buttonComparar.Size = new Size(126, 33);
            buttonComparar.TabIndex = 9;
            buttonComparar.Text = "Comparar";
            buttonComparar.UseVisualStyleBackColor = false;
            buttonComparar.Click += buttonComparar_Click;
            // 
            // buttonReglamento
            // 
            buttonReglamento.BackColor = Color.Transparent;
            buttonReglamento.FlatStyle = FlatStyle.Popup;
            buttonReglamento.Font = new Font("Product Sans", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonReglamento.ForeColor = Color.White;
            buttonReglamento.Location = new Point(726, 472);
            buttonReglamento.Name = "buttonReglamento";
            buttonReglamento.Size = new Size(160, 33);
            buttonReglamento.TabIndex = 12;
            buttonReglamento.Text = "Reglamento";
            buttonReglamento.UseVisualStyleBackColor = false;
            buttonReglamento.Click += buttonReglamento_Click;
            // 
            // buttonRegresar
            // 
            buttonRegresar.BackColor = Color.Transparent;
            buttonRegresar.FlatStyle = FlatStyle.Popup;
            buttonRegresar.Font = new Font("Product Sans", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonRegresar.ForeColor = Color.White;
            buttonRegresar.Location = new Point(726, 512);
            buttonRegresar.Name = "buttonRegresar";
            buttonRegresar.Size = new Size(160, 33);
            buttonRegresar.TabIndex = 13;
            buttonRegresar.Text = "Regresar";
            buttonRegresar.UseVisualStyleBackColor = false;
            buttonRegresar.Click += buttonRegresar_Click;
            // 
            // ImgReglamento
            // 
            ImgReglamento.BackColor = Color.Transparent;
            ImgReglamento.Image = Properties.Resources.reglamento;
            ImgReglamento.Location = new Point(891, 472);
            ImgReglamento.Name = "ImgReglamento";
            ImgReglamento.Size = new Size(71, 47);
            ImgReglamento.SizeMode = PictureBoxSizeMode.StretchImage;
            ImgReglamento.TabIndex = 14;
            ImgReglamento.TabStop = false;
            ImgReglamento.Click += ImgReglamento_Click;
            // 
            // ImgRegresar
            // 
            ImgRegresar.BackColor = Color.Transparent;
            ImgRegresar.Image = Properties.Resources.Out;
            ImgRegresar.Location = new Point(891, 512);
            ImgRegresar.Name = "ImgRegresar";
            ImgRegresar.Size = new Size(77, 38);
            ImgRegresar.SizeMode = PictureBoxSizeMode.StretchImage;
            ImgRegresar.TabIndex = 15;
            ImgRegresar.TabStop = false;
            ImgRegresar.Click += ImgRegresar_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(54, 147);
            textBox1.MaxLength = 1;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(73, 31);
            textBox1.TabIndex = 16;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(131, 147);
            textBox2.MaxLength = 1;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(73, 31);
            textBox2.TabIndex = 17;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(210, 147);
            textBox3.MaxLength = 1;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(73, 31);
            textBox3.TabIndex = 18;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(289, 147);
            textBox4.MaxLength = 1;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(73, 31);
            textBox4.TabIndex = 19;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(366, 147);
            textBox5.MaxLength = 1;
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(73, 31);
            textBox5.TabIndex = 20;
            textBox5.KeyPress += textBox5_KeyPress;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(444, 147);
            textBox6.MaxLength = 1;
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(73, 31);
            textBox6.TabIndex = 21;
            textBox6.KeyPress += textBox6_KeyPress;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(606, 192);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(301, 204);
            listBox1.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Kanit Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(191, 85);
            label6.Name = "label6";
            label6.Size = new Size(31, 56);
            label6.TabIndex = 23;
            label6.Text = ":";
            // 
            // labelSeg
            // 
            labelSeg.AutoSize = true;
            labelSeg.BackColor = Color.Transparent;
            labelSeg.Font = new Font("Kanit Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelSeg.ForeColor = Color.White;
            labelSeg.Location = new Point(229, 85);
            labelSeg.Name = "labelSeg";
            labelSeg.Size = new Size(31, 56);
            labelSeg.TabIndex = 24;
            labelSeg.Text = ".";
            // 
            // timerTiempo
            // 
            timerTiempo.Tick += timerTiempo_Tick;
            // 
            // pictureBox1
            // 
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(180, 217);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(211, 163);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Visible = false;
            pictureBox1.WaitOnLoad = true;
            // 
            // labelGP
            // 
            labelGP.AutoSize = true;
            labelGP.BackColor = Color.Transparent;
            labelGP.Font = new Font("Kanit Bold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelGP.ForeColor = Color.White;
            labelGP.Location = new Point(180, 392);
            labelGP.Name = "labelGP";
            labelGP.Size = new Size(122, 56);
            labelGP.TabIndex = 26;
            labelGP.Text = "..............";
            labelGP.Visible = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_mockup_20;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(963, 547);
            Controls.Add(labelGP);
            Controls.Add(pictureBox1);
            Controls.Add(labelSeg);
            Controls.Add(label6);
            Controls.Add(listBox1);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(ImgRegresar);
            Controls.Add(ImgReglamento);
            Controls.Add(buttonRegresar);
            Controls.Add(buttonReglamento);
            Controls.Add(buttonComparar);
            Controls.Add(buttonJugar);
            Controls.Add(labelIntentos);
            Controls.Add(labelH);
            Controls.Add(labelInt);
            Controls.Add(labelMinR);
            Controls.Add(label3);
            Controls.Add(labelNumeroAleatorio);
            Controls.Add(labelTitulo);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)ImgReglamento).EndInit();
            ((System.ComponentModel.ISupportInitialize)ImgRegresar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private Label labelNumeroAleatorio;
        private Label label3;
        private Label labelMinR;
        private Label labelInt;
        private Label labelH;
        private Label labelIntentos;
        private Button buttonJugar;
        private Button buttonComparar;
        private Button buttonReglamento;
        private Button buttonRegresar;
        private PictureBox ImgReglamento;
        private PictureBox ImgRegresar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private ListBox listBox1;
        private Label label6;
        private Label labelSeg;
        private System.Windows.Forms.Timer timerTiempo;
        private PictureBox pictureBox1;
        private Label labelGP;
    }
}