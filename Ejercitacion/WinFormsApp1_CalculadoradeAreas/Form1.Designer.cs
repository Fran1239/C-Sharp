namespace WinFormsApp1
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
            lbl_txt = new Label();
            groupBox1 = new GroupBox();
            rb_triangulo = new RadioButton();
            rb_cuadrilatero = new RadioButton();
            groupBox2 = new GroupBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            lbl_altura = new Label();
            lbl_base = new Label();
            gb_rta = new GroupBox();
            label1 = new Label();
            button1 = new Button();
            groupBox3 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            gb_rta.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_txt
            // 
            lbl_txt.BackColor = SystemColors.ControlDarkDark;
            lbl_txt.Font = new Font("Century Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_txt.ForeColor = SystemColors.ButtonHighlight;
            lbl_txt.Location = new Point(15, 20);
            lbl_txt.Name = "lbl_txt";
            lbl_txt.Size = new Size(398, 42);
            lbl_txt.TabIndex = 0;
            lbl_txt.Text = "Calculadora De Areas";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ControlDarkDark;
            groupBox1.Controls.Add(rb_triangulo);
            groupBox1.Controls.Add(rb_cuadrilatero);
            groupBox1.Font = new Font("Century Gothic", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.ButtonHighlight;
            groupBox1.Location = new Point(15, 58);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(398, 74);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "FIguara";
            // 
            // rb_triangulo
            // 
            rb_triangulo.AutoSize = true;
            rb_triangulo.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rb_triangulo.Location = new Point(240, 30);
            rb_triangulo.Name = "rb_triangulo";
            rb_triangulo.Size = new Size(91, 24);
            rb_triangulo.TabIndex = 1;
            rb_triangulo.TabStop = true;
            rb_triangulo.Text = "Triangulo";
            rb_triangulo.UseVisualStyleBackColor = true;
            rb_triangulo.CheckedChanged += rb_triangulo_CheckedChanged;
            // 
            // rb_cuadrilatero
            // 
            rb_cuadrilatero.AutoSize = true;
            rb_cuadrilatero.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            rb_cuadrilatero.Location = new Point(72, 30);
            rb_cuadrilatero.Name = "rb_cuadrilatero";
            rb_cuadrilatero.Size = new Size(119, 24);
            rb_cuadrilatero.TabIndex = 0;
            rb_cuadrilatero.TabStop = true;
            rb_cuadrilatero.Text = "Cuadrilatero";
            rb_cuadrilatero.UseVisualStyleBackColor = true;
            rb_cuadrilatero.CheckedChanged += rb_cuadrilatero_CheckedChanged;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ControlDarkDark;
            groupBox2.Controls.Add(textBox2);
            groupBox2.Controls.Add(textBox1);
            groupBox2.Controls.Add(lbl_altura);
            groupBox2.Controls.Add(lbl_base);
            groupBox2.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonHighlight;
            groupBox2.Location = new Point(15, 131);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(398, 145);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ingrese";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 86);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 22);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(197, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 22);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // lbl_altura
            // 
            lbl_altura.AutoSize = true;
            lbl_altura.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_altura.Location = new Point(106, 87);
            lbl_altura.Name = "lbl_altura";
            lbl_altura.Size = new Size(63, 21);
            lbl_altura.TabIndex = 1;
            lbl_altura.Text = "Altura:";
            // 
            // lbl_base
            // 
            lbl_base.AutoSize = true;
            lbl_base.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_base.Location = new Point(106, 45);
            lbl_base.Name = "lbl_base";
            lbl_base.Size = new Size(54, 21);
            lbl_base.TabIndex = 0;
            lbl_base.Text = "Base: ";
            lbl_base.Click += lbl_base_Click;
            // 
            // gb_rta
            // 
            gb_rta.BackColor = SystemColors.ControlDarkDark;
            gb_rta.Controls.Add(label1);
            gb_rta.Controls.Add(button1);
            gb_rta.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point);
            gb_rta.ForeColor = SystemColors.ButtonHighlight;
            gb_rta.Location = new Point(15, 276);
            gb_rta.Name = "gb_rta";
            gb_rta.Size = new Size(399, 203);
            gb_rta.TabIndex = 2;
            gb_rta.TabStop = false;
            gb_rta.Text = "Respuesta";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ActiveCaptionText;
            label1.Location = new Point(240, 88);
            label1.Name = "label1";
            label1.Size = new Size(68, 36);
            label1.TabIndex = 1;
            label1.Text = "  ...  ";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Font = new Font("Century Gothic", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(54, 60);
            button1.Name = "button1";
            button1.Size = new Size(156, 93);
            button1.TabIndex = 0;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(gb_rta);
            groupBox3.Controls.Add(groupBox2);
            groupBox3.Controls.Add(groupBox1);
            groupBox3.Controls.Add(lbl_txt);
            groupBox3.Location = new Point(343, 38);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(445, 510);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1518, 924);
            Controls.Add(groupBox3);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gb_rta.ResumeLayout(false);
            gb_rta.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lbl_txt;
        private GroupBox groupBox1;
        private RadioButton rb_triangulo;
        private RadioButton rb_cuadrilatero;
        private GroupBox groupBox2;
        private TextBox textBox1;
        private Label lbl_altura;
        private Label lbl_base;
        private TextBox textBox2;
        private GroupBox gb_rta;
        private Label label1;
        private Button button1;
        private GroupBox groupBox3;
    }
}