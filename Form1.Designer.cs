namespace Pica_Y_Fija
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TituloF1 = new Label();
            labelUsuario = new Label();
            labelContraseña = new Label();
            labelTieJue = new Label();
            labelIntentos = new Label();
            buttonJugar = new Button();
            buttonCerrar = new Button();
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            textBoxTiempo = new TextBox();
            textBoxIntentos = new TextBox();
            SuspendLayout();
            // 
            // TituloF1
            // 
            TituloF1.AutoSize = true;
            TituloF1.BackColor = Color.Transparent;
            TituloF1.Font = new Font("Kanit ExtraBold", 40F, FontStyle.Bold, GraphicsUnit.Point);
            TituloF1.ForeColor = Color.White;
            TituloF1.Location = new Point(177, -5);
            TituloF1.Name = "TituloF1";
            TituloF1.Size = new Size(572, 126);
            TituloF1.TabIndex = 0;
            TituloF1.Text = "PICAS Y FIJAS";
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.BackColor = Color.Transparent;
            labelUsuario.Font = new Font("Product Sans", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            labelUsuario.ForeColor = Color.White;
            labelUsuario.Location = new Point(412, 121);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(137, 36);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "USUARIO";
            labelUsuario.UseMnemonic = false;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.BackColor = Color.Transparent;
            labelContraseña.Font = new Font("Product Sans", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            labelContraseña.ForeColor = Color.White;
            labelContraseña.Location = new Point(371, 203);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(204, 36);
            labelContraseña.TabIndex = 2;
            labelContraseña.Text = "CONTRASEÑA";
            // 
            // labelTieJue
            // 
            labelTieJue.AutoSize = true;
            labelTieJue.BackColor = Color.Transparent;
            labelTieJue.Font = new Font("Product Sans", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            labelTieJue.ForeColor = Color.White;
            labelTieJue.Location = new Point(346, 277);
            labelTieJue.Name = "labelTieJue";
            labelTieJue.Size = new Size(261, 36);
            labelTieJue.TabIndex = 3;
            labelTieJue.Text = "TIEMPO DE JUEGO";
            // 
            // labelIntentos
            // 
            labelIntentos.AutoSize = true;
            labelIntentos.BackColor = Color.Transparent;
            labelIntentos.Font = new Font("Product Sans", 13.9999981F, FontStyle.Bold, GraphicsUnit.Point);
            labelIntentos.ForeColor = Color.White;
            labelIntentos.Location = new Point(400, 361);
            labelIntentos.Name = "labelIntentos";
            labelIntentos.Size = new Size(149, 36);
            labelIntentos.TabIndex = 4;
            labelIntentos.Text = "INTENTOS";
            // 
            // buttonJugar
            // 
            buttonJugar.BackColor = Color.Lime;
            buttonJugar.FlatStyle = FlatStyle.Popup;
            buttonJugar.Font = new Font("Product Sans", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonJugar.ForeColor = Color.White;
            buttonJugar.Location = new Point(293, 459);
            buttonJugar.Name = "buttonJugar";
            buttonJugar.Size = new Size(112, 34);
            buttonJugar.TabIndex = 5;
            buttonJugar.Text = "JUGAR";
            buttonJugar.UseVisualStyleBackColor = false;
            buttonJugar.Click += buttonJugar_Click;
            // 
            // buttonCerrar
            // 
            buttonCerrar.BackColor = Color.Red;
            buttonCerrar.FlatStyle = FlatStyle.Popup;
            buttonCerrar.Font = new Font("Product Sans", 10.999999F, FontStyle.Bold, GraphicsUnit.Point);
            buttonCerrar.ForeColor = Color.White;
            buttonCerrar.Location = new Point(558, 459);
            buttonCerrar.Name = "buttonCerrar";
            buttonCerrar.Size = new Size(112, 34);
            buttonCerrar.TabIndex = 6;
            buttonCerrar.Text = "CERRAR";
            buttonCerrar.UseVisualStyleBackColor = false;
            buttonCerrar.Click += buttonCerrar_Click;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.BackColor = SystemColors.ButtonFace;
            textBoxUsuario.Cursor = Cursors.IBeam;
            textBoxUsuario.Location = new Point(346, 160);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(261, 31);
            textBoxUsuario.TabIndex = 7;
            textBoxUsuario.KeyPress += textBoxUsuario_KeyPress;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.BackColor = SystemColors.ButtonFace;
            textBoxContraseña.Location = new Point(346, 242);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(261, 31);
            textBoxContraseña.TabIndex = 8;
            textBoxContraseña.KeyPress += textBoxContraseña_KeyPress;
            // 
            // textBoxTiempo
            // 
            textBoxTiempo.BackColor = SystemColors.ButtonFace;
            textBoxTiempo.Location = new Point(346, 316);
            textBoxTiempo.MaxLength = 2;
            textBoxTiempo.Name = "textBoxTiempo";
            textBoxTiempo.Size = new Size(261, 31);
            textBoxTiempo.TabIndex = 9;
            textBoxTiempo.KeyPress += textBoxTiempo_KeyPress;
            // 
            // textBoxIntentos
            // 
            textBoxIntentos.BackColor = SystemColors.ButtonFace;
            textBoxIntentos.Location = new Point(346, 400);
            textBoxIntentos.MaxLength = 2;
            textBoxIntentos.Name = "textBoxIntentos";
            textBoxIntentos.Size = new Size(261, 31);
            textBoxIntentos.TabIndex = 10;
            textBoxIntentos.KeyPress += textBoxIntentos_KeyPress;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuHighlight;
            BackgroundImage = Properties.Resources.fondo_mockup_12;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(952, 558);
            Controls.Add(textBoxIntentos);
            Controls.Add(textBoxTiempo);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxUsuario);
            Controls.Add(buttonCerrar);
            Controls.Add(buttonJugar);
            Controls.Add(labelIntentos);
            Controls.Add(labelTieJue);
            Controls.Add(labelContraseña);
            Controls.Add(labelUsuario);
            Controls.Add(TituloF1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label TituloF1;
        private Label labelUsuario;
        private Label labelContraseña;
        private Label labelTieJue;
        private Label labelIntentos;
        private Button buttonJugar;
        private Button buttonCerrar;
        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private TextBox textBoxTiempo;
        private TextBox textBoxIntentos;
    }
}