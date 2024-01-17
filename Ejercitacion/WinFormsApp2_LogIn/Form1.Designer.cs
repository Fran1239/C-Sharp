namespace WinFormsApp2_LogIn
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            groupBox1 = new GroupBox();
            button4 = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            checkBox1 = new CheckBox();
            button2 = new Button();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            errorProvider1 = new ErrorProvider(components);
            panel3 = new Panel();
            groupBox2 = new GroupBox();
            label8 = new Label();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            button6 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            panel3.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 72F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(8, 29);
            label1.Name = "label1";
            label1.Size = new Size(473, 128);
            label1.TabIndex = 0;
            label1.Text = "facebook";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(34, 157);
            label2.Name = "label2";
            label2.Size = new Size(520, 45);
            label2.TabIndex = 1;
            label2.Text = "Facebook te ayuda a comunicarte y";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(34, 202);
            label3.Name = "label3";
            label3.Size = new Size(577, 45);
            label3.TabIndex = 2;
            label3.Text = "compartir con las personas que forman";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(34, 244);
            label4.Name = "label4";
            label4.Size = new Size(251, 45);
            label4.TabIndex = 3;
            label4.Text = "parte de tu vida.";
            label4.Click += label4_Click;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox1.BackColor = SystemColors.ControlLightLight;
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(checkBox1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.FlatStyle = FlatStyle.Popup;
            groupBox1.Location = new Point(6, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(471, 488);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button4
            // 
            button4.ForeColor = Color.DodgerBlue;
            button4.Location = new Point(129, 303);
            button4.Name = "button4";
            button4.Size = new Size(202, 23);
            button4.TabIndex = 8;
            button4.Text = "¿Olvidaste tu contraseña?";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Location = new Point(205, 452);
            label7.Name = "label7";
            label7.Size = new Size(53, 15);
            label7.TabIndex = 7;
            label7.Text = "negocio.";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Location = new Point(186, 437);
            label6.Name = "label6";
            label6.Size = new Size(200, 15);
            label6.TabIndex = 6;
            label6.Text = "para una celebridad, una marca o un";
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(95, 437);
            label5.Name = "label5";
            label5.Size = new Size(94, 15);
            label5.TabIndex = 5;
            label5.Text = "Crea una página";
            label5.Click += label5_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Checked = true;
            checkBox1.CheckState = CheckState.Checked;
            checkBox1.Location = new Point(371, 151);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(15, 14);
            checkBox1.TabIndex = 6;
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.LimeGreen;
            button2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(119, 360);
            button2.Name = "button2";
            button2.Size = new Size(226, 64);
            button2.TabIndex = 5;
            button2.Text = "Crear cuenta nueva";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(58, 212);
            button1.Name = "button1";
            button1.Size = new Size(350, 74);
            button1.TabIndex = 2;
            button1.Text = "Iniciar Sesion";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.ForeColor = SystemColors.ScrollBar;
            textBox2.Location = new Point(71, 143);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "  Contraseña";
            textBox2.Size = new Size(317, 29);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.ForeColor = SystemColors.ScrollBar;
            textBox1.Location = new Point(71, 79);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "  Correo electrónico o número de teléfono";
            textBox1.Size = new Size(317, 29);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(82, 148);
            panel1.Name = "panel1";
            panel1.Size = new Size(545, 365);
            panel1.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBox1);
            panel2.Location = new Point(763, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(480, 548);
            panel2.TabIndex = 9;
            panel2.Paint += panel2_Paint;
            // 
            // errorProvider1
            // 
            errorProvider1.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            errorProvider1.ContainerControl = this;
            // 
            // panel3
            // 
            panel3.Controls.Add(groupBox2);
            panel3.Location = new Point(744, 68);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 520);
            panel3.TabIndex = 10;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            groupBox2.BackColor = SystemColors.ControlLightLight;
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(checkBox3);
            groupBox2.Controls.Add(checkBox2);
            groupBox2.Controls.Add(button6);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.FlatStyle = FlatStyle.Popup;
            groupBox2.Location = new Point(27, 16);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(471, 488);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(60, 56);
            label8.Name = "label8";
            label8.Size = new Size(333, 37);
            label8.TabIndex = 8;
            label8.Text = "Reestablecer tu contraseña";
            label8.Click += label8_Click;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Checked = true;
            checkBox3.CheckState = CheckState.Checked;
            checkBox3.Location = new Point(365, 264);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(15, 14);
            checkBox3.TabIndex = 7;
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.CheckedChanged += checkBox3_CheckedChanged;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Checked = true;
            checkBox2.CheckState = CheckState.Checked;
            checkBox2.Location = new Point(365, 187);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(15, 14);
            checkBox2.TabIndex = 6;
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.MenuHighlight;
            button6.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            button6.ForeColor = SystemColors.ControlLightLight;
            button6.Location = new Point(56, 327);
            button6.Name = "button6";
            button6.Size = new Size(350, 74);
            button6.TabIndex = 2;
            button6.Text = "Reestablecer";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.ForeColor = SystemColors.ScrollBar;
            textBox3.Location = new Point(71, 179);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "  Contraseña";
            textBox3.Size = new Size(317, 29);
            textBox3.TabIndex = 1;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.ForeColor = SystemColors.ScrollBar;
            textBox4.Location = new Point(71, 256);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "  Confirmar Contraseña";
            textBox4.Size = new Size(317, 29);
            textBox4.TabIndex = 0;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1271, 662);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            panel3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckBox checkBox1;
        private Panel panel1;
        private Panel panel2;
        private ErrorProvider errorProvider1;
        private Panel panel3;
        private GroupBox groupBox2;
        private CheckBox checkBox2;
        private Button button6;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label8;
        private CheckBox checkBox3;
        private Button button4;
        private Panel panel4;
    }
}