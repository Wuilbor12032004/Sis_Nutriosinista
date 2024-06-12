namespace Sis_Nutriosinista
{
    partial class Form_Iniciodeseccion
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
            label1 = new Label();
            labelUsuario = new Label();
            label2 = new Label();
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            buttoninicio = new Button();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(147, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 19);
            label1.TabIndex = 0;
            label1.Text = "SIS_NUTRISIONISTA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUsuario.ForeColor = Color.DarkBlue;
            labelUsuario.Location = new Point(120, 118);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(66, 16);
            labelUsuario.TabIndex = 1;
            labelUsuario.Text = "Usuario:";
            labelUsuario.Click += label2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(93, 174);
            label2.Name = "label2";
            label2.Size = new Size(93, 16);
            label2.TabIndex = 2;
            label2.Text = "Contraseña:";
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(215, 111);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(135, 23);
            textBoxUsuario.TabIndex = 3;
            textBoxUsuario.TextChanged += textBoxUsuario_TextChanged;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(215, 167);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(135, 23);
            textBoxContraseña.TabIndex = 4;
            textBoxContraseña.TextChanged += textBoxContraseña_TextChanged;
            // 
            // buttoninicio
            // 
            buttoninicio.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttoninicio.ForeColor = Color.DarkBlue;
            buttoninicio.Location = new Point(171, 223);
            buttoninicio.Name = "buttoninicio";
            buttoninicio.Size = new Size(112, 26);
            buttoninicio.TabIndex = 6;
            buttoninicio.Text = "Inicio";
            buttoninicio.UseVisualStyleBackColor = true;
            buttoninicio.Click += buttoninicio_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.uii;
            pictureBox1.Location = new Point(147, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(161, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FloralWhite;
            label3.Font = new Font("Sitka Banner", 9.749999F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(93, 265);
            label3.Name = "label3";
            label3.Size = new Size(277, 19);
            label3.TabIndex = 8;
            label3.Text = "\"Una buena nutrición es clave para el bienestar total.\"";
            label3.Click += label3_Click;
            // 
            // Form_Iniciodeseccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(429, 293);
            Controls.Add(label3);
            Controls.Add(pictureBox1);
            Controls.Add(buttoninicio);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxUsuario);
            Controls.Add(label2);
            Controls.Add(labelUsuario);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form_Iniciodeseccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicio";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label labelUsuario;
        private Label label2;
        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private Button buttoninicio;
        private PictureBox pictureBox1;
        private Label label3;
    }
}
