namespace Sis_Nutriosinista;

    
    partial class FrmMenu
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
        panel1 = new Panel();
        Menuvertical = new Panel();
        button5 = new Button();
        button4 = new Button();
        button3 = new Button();
        button2 = new Button();
        button1 = new Button();
        label1 = new Label();
        panel2 = new Panel();
        IconoMinimizar = new PictureBox();
        Iconocerrar = new PictureBox();
        panelContenedor = new Panel();
        Menuvertical.SuspendLayout();
        panel2.SuspendLayout();
        ((System.ComponentModel.ISupportInitialize)IconoMinimizar).BeginInit();
        ((System.ComponentModel.ISupportInitialize)Iconocerrar).BeginInit();
        SuspendLayout();
        // 
        // panel1
        // 
        panel1.Location = new Point(31, 37);
        panel1.Name = "panel1";
        panel1.Size = new Size(0, 0);
        panel1.TabIndex = 0;
        // 
        // Menuvertical
        // 
        Menuvertical.BackColor = Color.DodgerBlue;
        Menuvertical.Controls.Add(button5);
        Menuvertical.Controls.Add(button4);
        Menuvertical.Controls.Add(button3);
        Menuvertical.Controls.Add(button2);
        Menuvertical.Controls.Add(button1);
        Menuvertical.Controls.Add(label1);
        Menuvertical.Dock = DockStyle.Left;
        Menuvertical.Location = new Point(0, 0);
        Menuvertical.Name = "Menuvertical";
        Menuvertical.Size = new Size(145, 350);
        Menuvertical.TabIndex = 1;
        Menuvertical.Paint += Menuvertical_Paint;
        // 
        // button5
        // 
        button5.FlatStyle = FlatStyle.Flat;
        button5.Location = new Point(12, 151);
        button5.Name = "button5";
        button5.Size = new Size(84, 24);
        button5.TabIndex = 5;
        button5.Text = "Expediente";
        button5.UseVisualStyleBackColor = true;
        button5.Click += button5_Click;
        // 
        // button4
        // 
        button4.FlatStyle = FlatStyle.Flat;
        button4.Location = new Point(12, 237);
        button4.Name = "button4";
        button4.Size = new Size(75, 23);
        button4.TabIndex = 4;
        button4.Text = "Consulta";
        button4.UseVisualStyleBackColor = true;
        button4.Click += button4_Click;
        // 
        // button3
        // 
        button3.FlatStyle = FlatStyle.Flat;
        button3.Location = new Point(12, 194);
        button3.Name = "button3";
        button3.Size = new Size(75, 23);
        button3.TabIndex = 3;
        button3.Text = "Citas";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // button2
        // 
        button2.FlatStyle = FlatStyle.Flat;
        button2.Location = new Point(12, 68);
        button2.Name = "button2";
        button2.Size = new Size(114, 24);
        button2.TabIndex = 2;
        button2.Text = "Registro usuario";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button1
        // 
        button1.FlatStyle = FlatStyle.Flat;
        button1.Location = new Point(12, 113);
        button1.Name = "button1";
        button1.Size = new Size(114, 23);
        button1.TabIndex = 1;
        button1.Text = "Inicio de seccion";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.BackColor = Color.Azure;
        label1.Font = new Font("Tahoma", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
        label1.Location = new Point(12, 15);
        label1.Name = "label1";
        label1.Size = new Size(126, 19);
        label1.TabIndex = 0;
        label1.Text = "Sis_Nutricionista";
        // 
        // panel2
        // 
        panel2.BackColor = Color.DodgerBlue;
        panel2.Controls.Add(IconoMinimizar);
        panel2.Controls.Add(Iconocerrar);
        panel2.Dock = DockStyle.Top;
        panel2.Location = new Point(145, 0);
        panel2.Name = "panel2";
        panel2.Size = new Size(455, 30);
        panel2.TabIndex = 2;
        panel2.Paint += panel2_Paint;
        panel2.MouseDown += panel2_MouseDown;
        // 
        // IconoMinimizar
        // 
        IconoMinimizar.BackColor = Color.Azure;
        IconoMinimizar.Cursor = Cursors.Hand;
        IconoMinimizar.ErrorImage = (Image)resources.GetObject("IconoMinimizar.ErrorImage");
        IconoMinimizar.Image = (Image)resources.GetObject("IconoMinimizar.Image");
        IconoMinimizar.Location = new Point(402, 3);
        IconoMinimizar.Name = "IconoMinimizar";
        IconoMinimizar.Size = new Size(22, 19);
        IconoMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
        IconoMinimizar.TabIndex = 1;
        IconoMinimizar.TabStop = false;
        IconoMinimizar.Click += IconoMinimizar_Click;
        // 
        // Iconocerrar
        // 
        Iconocerrar.BackColor = Color.Azure;
        Iconocerrar.Cursor = Cursors.Hand;
        Iconocerrar.ErrorImage = (Image)resources.GetObject("Iconocerrar.ErrorImage");
        Iconocerrar.Image = Properties.Resources.icon_cerrar2;
        Iconocerrar.Location = new Point(430, 3);
        Iconocerrar.Name = "Iconocerrar";
        Iconocerrar.Size = new Size(22, 19);
        Iconocerrar.SizeMode = PictureBoxSizeMode.Zoom;
        Iconocerrar.TabIndex = 0;
        Iconocerrar.TabStop = false;
        Iconocerrar.Click += Iconocerrar_Click;
        // 
        // panelContenedor
        // 
        panelContenedor.Dock = DockStyle.Bottom;
        panelContenedor.Location = new Point(145, 113);
        panelContenedor.Name = "panelContenedor";
        panelContenedor.Size = new Size(455, 237);
        panelContenedor.TabIndex = 3;
        panelContenedor.Paint += panelContenedor_Paint_1;
        // 
        // FrmMenu
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(600, 350);
        Controls.Add(panelContenedor);
        Controls.Add(panel2);
        Controls.Add(Menuvertical);
        Controls.Add(panel1);
        FormBorderStyle = FormBorderStyle.None;
        Name = "FrmMenu";
        Text = "Menu";
        Menuvertical.ResumeLayout(false);
        Menuvertical.PerformLayout();
        panel2.ResumeLayout(false);
        ((System.ComponentModel.ISupportInitialize)IconoMinimizar).EndInit();
        ((System.ComponentModel.ISupportInitialize)Iconocerrar).EndInit();
        ResumeLayout(false);
    }

    #endregion

    private Panel panel1;
        private Panel Menuvertical;
        private Label label1;
        private Panel panel2;
        private Panel panelContenedor;
        private PictureBox IconoMinimizar;
        private PictureBox Iconocerrar;
    private Button button1;
    private Button button4;
    private Button button3;
    private Button button2;
    private Button button5;
}
