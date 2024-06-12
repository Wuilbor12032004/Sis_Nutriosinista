namespace Sis_Nutriosinista
{
    partial class Form_Registro_Usuario
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
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label4 = new Label();
            textBoxnombre = new TextBox();
            buttonregistrodeusuario = new Button();
            label5 = new Label();
            textBoxcontraseña = new TextBox();
            textBoxcorreo = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.DarkBlue;
            label1.Location = new Point(139, 9);
            label1.Name = "label1";
            label1.Size = new Size(161, 19);
            label1.TabIndex = 1;
            label1.Text = "SIS_NUTRISIONISTA";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.uii;
            pictureBox1.Location = new Point(139, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.DarkBlue;
            label2.Location = new Point(110, 142);
            label2.Name = "label2";
            label2.Size = new Size(59, 14);
            label2.TabIndex = 9;
            label2.Text = "Nombre:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(112, 187);
            label4.Name = "label4";
            label4.Size = new Size(57, 14);
            label4.TabIndex = 11;
            label4.Text = "Correo:";
            // 
            // textBoxnombre
            // 
            textBoxnombre.Location = new Point(234, 138);
            textBoxnombre.Name = "textBoxnombre";
            textBoxnombre.Size = new Size(83, 23);
            textBoxnombre.TabIndex = 12;
            textBoxnombre.TextChanged += textBoxnombre_TextChanged;
            // 
            // buttonregistrodeusuario
            // 
            buttonregistrodeusuario.FlatStyle = FlatStyle.Flat;
            buttonregistrodeusuario.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonregistrodeusuario.ForeColor = Color.MediumBlue;
            buttonregistrodeusuario.Location = new Point(159, 257);
            buttonregistrodeusuario.Name = "buttonregistrodeusuario";
            buttonregistrodeusuario.Size = new Size(101, 24);
            buttonregistrodeusuario.TabIndex = 15;
            buttonregistrodeusuario.Text = "Registrar";
            buttonregistrodeusuario.UseVisualStyleBackColor = true;
            buttonregistrodeusuario.Click += buttonregistrodeusuario_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Stencil", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(84, 230);
            label5.Name = "label5";
            label5.Size = new Size(85, 14);
            label5.TabIndex = 16;
            label5.Text = "Contraseña:";
            // 
            // textBoxcontraseña
            // 
            textBoxcontraseña.Location = new Point(234, 221);
            textBoxcontraseña.Name = "textBoxcontraseña";
            textBoxcontraseña.Size = new Size(132, 23);
            textBoxcontraseña.TabIndex = 17;
            // 
            // textBoxcorreo
            // 
            textBoxcorreo.Location = new Point(234, 178);
            textBoxcorreo.Name = "textBoxcorreo";
            textBoxcorreo.Size = new Size(132, 23);
            textBoxcorreo.TabIndex = 14;
            textBoxcorreo.TextChanged += textBoxcorreo_TextChanged;
            // 
            // Form_Registro_Usuario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(429, 293);
            Controls.Add(textBoxcontraseña);
            Controls.Add(label5);
            Controls.Add(buttonregistrodeusuario);
            Controls.Add(textBoxcorreo);
            Controls.Add(textBoxnombre);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form_Registro_Usuario";
            Text = "Reguistro de usuario";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label4;
        private TextBox textBoxnombre;
        private Button buttonregistrodeusuario;
        private Label label5;
        private TextBox textBoxcontraseña;
        private TextBox textBoxcorreo;
    }
}