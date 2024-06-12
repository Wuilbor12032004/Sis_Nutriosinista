namespace Sis_Nutriosinista
{
    partial class Form_Expediente
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
            label2 = new Label();
            dateTimePicker_Fechadeapertura = new DateTimePicker();
            groupBoxDatos_Usuarios = new GroupBox();
            button_GuardarExpediente = new Button();
            checkedListBoxSintomas = new CheckedListBox();
            comboBoxMedico = new ComboBox();
            label8 = new Label();
            label7 = new Label();
            textBoxDomicilio = new TextBox();
            label6 = new Label();
            textBoxN_C_D_U = new TextBox();
            label3 = new Label();
            groupBoxDatos_Usuarios.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Stencil", 12F);
            label1.ForeColor = Color.MediumBlue;
            label1.Location = new Point(20, 9);
            label1.Name = "label1";
            label1.Size = new Size(0, 19);
            label1.TabIndex = 0;
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(231, 80);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 2;
            label2.Text = "Fecha de apertura:";
            // 
            // dateTimePicker_Fechadeapertura
            // 
            dateTimePicker_Fechadeapertura.Format = DateTimePickerFormat.Short;
            dateTimePicker_Fechadeapertura.Location = new Point(341, 80);
            dateTimePicker_Fechadeapertura.Name = "dateTimePicker_Fechadeapertura";
            dateTimePicker_Fechadeapertura.Size = new Size(79, 23);
            dateTimePicker_Fechadeapertura.TabIndex = 4;
            // 
            // groupBoxDatos_Usuarios
            // 
            groupBoxDatos_Usuarios.Controls.Add(button_GuardarExpediente);
            groupBoxDatos_Usuarios.Controls.Add(dateTimePicker_Fechadeapertura);
            groupBoxDatos_Usuarios.Controls.Add(checkedListBoxSintomas);
            groupBoxDatos_Usuarios.Controls.Add(label2);
            groupBoxDatos_Usuarios.Controls.Add(comboBoxMedico);
            groupBoxDatos_Usuarios.Controls.Add(label8);
            groupBoxDatos_Usuarios.Controls.Add(label7);
            groupBoxDatos_Usuarios.Controls.Add(textBoxDomicilio);
            groupBoxDatos_Usuarios.Controls.Add(label6);
            groupBoxDatos_Usuarios.Controls.Add(textBoxN_C_D_U);
            groupBoxDatos_Usuarios.Controls.Add(label3);
            groupBoxDatos_Usuarios.Location = new Point(6, 9);
            groupBoxDatos_Usuarios.Name = "groupBoxDatos_Usuarios";
            groupBoxDatos_Usuarios.Size = new Size(466, 290);
            groupBoxDatos_Usuarios.TabIndex = 5;
            groupBoxDatos_Usuarios.TabStop = false;
            groupBoxDatos_Usuarios.Text = "Datos de Usuario";
            // 
            // button_GuardarExpediente
            // 
            button_GuardarExpediente.BackColor = Color.MistyRose;
            button_GuardarExpediente.Location = new Point(250, 181);
            button_GuardarExpediente.Name = "button_GuardarExpediente";
            button_GuardarExpediente.Size = new Size(133, 25);
            button_GuardarExpediente.TabIndex = 17;
            button_GuardarExpediente.Text = "Guardar Expediente";
            button_GuardarExpediente.UseVisualStyleBackColor = false;
            button_GuardarExpediente.Click += button_GuardarExpediente_Click;
            // 
            // checkedListBoxSintomas
            // 
            checkedListBoxSintomas.FormattingEnabled = true;
            checkedListBoxSintomas.Items.AddRange(new object[] { "Pérdida de peso", "Aumento de peso o masa muscular", "Problemas digestivos", "Condiciones crónicas", "Alergias e intolerancias alimentarias", "Nutrición deportiva", "Salud infantil", "Nutrición durante el embarazo ", "Trastornos alimentarios", "Bienestar general" });
            checkedListBoxSintomas.Location = new Point(6, 68);
            checkedListBoxSintomas.Name = "checkedListBoxSintomas";
            checkedListBoxSintomas.Size = new Size(219, 184);
            checkedListBoxSintomas.TabIndex = 16;
            // 
            // comboBoxMedico
            // 
            comboBoxMedico.FormattingEnabled = true;
            comboBoxMedico.Items.AddRange(new object[] { "Doc. Pedro Ruiz", "Doc. Juan Morales", "Doc. Patricia Lopez" });
            comboBoxMedico.Location = new Point(299, 122);
            comboBoxMedico.Name = "comboBoxMedico";
            comboBoxMedico.Size = new Size(121, 23);
            comboBoxMedico.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(231, 125);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 14;
            label8.Text = "Medico:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(11, 50);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 12;
            label7.Text = "Sintomas:";
            // 
            // textBoxDomicilio
            // 
            textBoxDomicilio.Location = new Point(312, 19);
            textBoxDomicilio.Name = "textBoxDomicilio";
            textBoxDomicilio.Size = new Size(130, 23);
            textBoxDomicilio.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(250, 22);
            label6.Name = "label6";
            label6.Size = new Size(61, 15);
            label6.TabIndex = 10;
            label6.Text = "Domicilio:";
            // 
            // textBoxN_C_D_U
            // 
            textBoxN_C_D_U.Location = new Point(95, 19);
            textBoxN_C_D_U.Name = "textBoxN_C_D_U";
            textBoxN_C_D_U.Size = new Size(130, 23);
            textBoxN_C_D_U.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(11, 19);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 0;
            label3.Text = "Nombre :";
            label3.Click += label3_Click;
            // 
            // Form_Expediente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(484, 311);
            Controls.Add(groupBoxDatos_Usuarios);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "Form_Expediente";
            Text = "Expediente";
            groupBoxDatos_Usuarios.ResumeLayout(false);
            groupBoxDatos_Usuarios.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private DateTimePicker dateTimePicker_Fechadeapertura;
        private GroupBox groupBoxDatos_Usuarios;
        private TextBox textBoxN_C_D_U;
        private Label label3;
        private ComboBox comboBoxMedico;
        private Label label8;
        private Label label7;
        private TextBox textBoxDomicilio;
        private Label label6;
        private CheckedListBox checkedListBoxSintomas;
        private Button button_GuardarExpediente;
    }
}