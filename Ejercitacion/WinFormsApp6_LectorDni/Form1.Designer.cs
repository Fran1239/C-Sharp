namespace WinFormsApp6_LectorDni
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label10 = new Label();
            textBoxDomicilio = new TextBox();
            textBoxVencimiento = new TextBox();
            textBoxEmision = new TextBox();
            textBoxNacimiento = new TextBox();
            buttonSave = new Button();
            domainUpDownSexo = new DomainUpDown();
            textBoxDocumento = new TextBox();
            textBoxNacionalidad = new TextBox();
            textBoxNombre = new TextBox();
            textBoxApellido = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tituloLBL = new Label();
            panel2 = new Panel();
            label13 = new Label();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            pictureBox2 = new PictureBox();
            label12 = new Label();
            pictureBox1 = new PictureBox();
            label11 = new Label();
            dateTimePicker1 = new DateTimePicker();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(322, 87);
            panel1.Name = "panel1";
            panel1.Size = new Size(720, 561);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonShadow;
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(textBoxDomicilio);
            groupBox1.Controls.Add(textBoxVencimiento);
            groupBox1.Controls.Add(textBoxEmision);
            groupBox1.Controls.Add(textBoxNacimiento);
            groupBox1.Controls.Add(buttonSave);
            groupBox1.Controls.Add(domainUpDownSexo);
            groupBox1.Controls.Add(textBoxDocumento);
            groupBox1.Controls.Add(textBoxNacionalidad);
            groupBox1.Controls.Add(textBoxNombre);
            groupBox1.Controls.Add(textBoxApellido);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tituloLBL);
            groupBox1.Location = new Point(50, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(648, 553);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(416, 318);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "  Tramite N / Of. ident.";
            textBox1.Size = new Size(177, 29);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.ControlLightLight;
            label10.Location = new Point(53, 438);
            label10.Name = "label10";
            label10.Size = new Size(0, 21);
            label10.TabIndex = 20;
            // 
            // textBoxDomicilio
            // 
            textBoxDomicilio.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDomicilio.Location = new Point(487, 250);
            textBoxDomicilio.Name = "textBoxDomicilio";
            textBoxDomicilio.PlaceholderText = "  Domicilio";
            textBoxDomicilio.Size = new Size(95, 29);
            textBoxDomicilio.TabIndex = 19;
            textBoxDomicilio.TextChanged += textBoxDomicilio_TextChanged;
            // 
            // textBoxVencimiento
            // 
            textBoxVencimiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxVencimiento.Location = new Point(63, 470);
            textBoxVencimiento.Name = "textBoxVencimiento";
            textBoxVencimiento.PlaceholderText = "  Fecha de Vencimiento / Date of Expiry";
            textBoxVencimiento.Size = new Size(287, 29);
            textBoxVencimiento.TabIndex = 18;
            textBoxVencimiento.TextChanged += textBoxVencimiento_TextChanged;
            // 
            // textBoxEmision
            // 
            textBoxEmision.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxEmision.Location = new Point(63, 387);
            textBoxEmision.Name = "textBoxEmision";
            textBoxEmision.PlaceholderText = "  Fecha de Emision / Date of Issue";
            textBoxEmision.Size = new Size(251, 29);
            textBoxEmision.TabIndex = 17;
            textBoxEmision.TextChanged += textBoxEmision_TextChanged;
            // 
            // textBoxNacimiento
            // 
            textBoxNacimiento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNacimiento.Location = new Point(63, 318);
            textBoxNacimiento.Name = "textBoxNacimiento";
            textBoxNacimiento.PlaceholderText = "  Fecha de Nacimiento / Date of Birth";
            textBoxNacimiento.Size = new Size(268, 29);
            textBoxNacimiento.TabIndex = 16;
            textBoxNacimiento.TextChanged += textBoxNacimiento_TextChanged;
            // 
            // buttonSave
            // 
            buttonSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(487, 402);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(106, 97);
            buttonSave.TabIndex = 15;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += button1_Click;
            // 
            // domainUpDownSexo
            // 
            domainUpDownSexo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            domainUpDownSexo.ForeColor = SystemColors.WindowFrame;
            domainUpDownSexo.Location = new Point(450, 116);
            domainUpDownSexo.Name = "domainUpDownSexo";
            domainUpDownSexo.Size = new Size(143, 29);
            domainUpDownSexo.TabIndex = 14;
            domainUpDownSexo.SelectedItemChanged += domainUpDownSexo_SelectedItemChanged;
            // 
            // textBoxDocumento
            // 
            textBoxDocumento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxDocumento.Location = new Point(400, 179);
            textBoxDocumento.Name = "textBoxDocumento";
            textBoxDocumento.PlaceholderText = "  Documento / Document";
            textBoxDocumento.Size = new Size(193, 29);
            textBoxDocumento.TabIndex = 13;
            textBoxDocumento.TextChanged += textBoxDocumento_TextChanged;
            // 
            // textBoxNacionalidad
            // 
            textBoxNacionalidad.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNacionalidad.Location = new Point(63, 245);
            textBoxNacionalidad.Name = "textBoxNacionalidad";
            textBoxNacionalidad.PlaceholderText = "  Nacionalidad / Nationality";
            textBoxNacionalidad.Size = new Size(213, 29);
            textBoxNacionalidad.TabIndex = 12;
            textBoxNacionalidad.TextChanged += textBoxNacionalidad_TextChanged;
            // 
            // textBoxNombre
            // 
            textBoxNombre.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxNombre.Location = new Point(63, 179);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "  Nombre / Name";
            textBoxNombre.Size = new Size(136, 29);
            textBoxNombre.TabIndex = 11;
            textBoxNombre.TextChanged += textBoxNombre_TextChanged;
            // 
            // textBoxApellido
            // 
            textBoxApellido.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxApellido.Location = new Point(63, 116);
            textBoxApellido.Name = "textBoxApellido";
            textBoxApellido.PlaceholderText = "  Apellido / Surname";
            textBoxApellido.Size = new Size(157, 29);
            textBoxApellido.TabIndex = 10;
            textBoxApellido.TextChanged += textBoxApellido_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ControlLightLight;
            label9.Location = new Point(337, 337);
            label9.Name = "label9";
            label9.Size = new Size(0, 21);
            label9.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlLightLight;
            label8.Location = new Point(53, 337);
            label8.Name = "label8";
            label8.Size = new Size(0, 21);
            label8.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ControlLightLight;
            label7.Location = new Point(337, 253);
            label7.Name = "label7";
            label7.Size = new Size(0, 21);
            label7.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ControlLightLight;
            label6.Location = new Point(53, 253);
            label6.Name = "label6";
            label6.Size = new Size(0, 21);
            label6.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ControlLightLight;
            label5.Location = new Point(337, 168);
            label5.Name = "label5";
            label5.Size = new Size(0, 21);
            label5.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlLightLight;
            label4.Location = new Point(53, 168);
            label4.Name = "label4";
            label4.Size = new Size(0, 21);
            label4.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ControlLightLight;
            label3.Location = new Point(386, 116);
            label3.Name = "label3";
            label3.Size = new Size(0, 21);
            label3.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ControlLightLight;
            label2.Location = new Point(276, 83);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(53, 83);
            label1.Name = "label1";
            label1.Size = new Size(0, 21);
            label1.TabIndex = 2;
            // 
            // tituloLBL
            // 
            tituloLBL.AutoSize = true;
            tituloLBL.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            tituloLBL.ForeColor = SystemColors.ControlLightLight;
            tituloLBL.Location = new Point(4, 19);
            tituloLBL.Name = "tituloLBL";
            tituloLBL.Size = new Size(639, 37);
            tituloLBL.TabIndex = 1;
            tituloLBL.Text = "Impresora De Documento Nacional de Identidad";
            tituloLBL.Click += tituloLBL_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(label13);
            panel2.Controls.Add(button8);
            panel2.Controls.Add(button7);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(226, 87);
            panel2.Name = "panel2";
            panel2.Size = new Size(909, 570);
            panel2.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = SystemColors.ActiveBorder;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(154, 441);
            label13.Name = "label13";
            label13.Size = new Size(77, 20);
            label13.TabIndex = 3;
            label13.Text = "Domicilio:";
            // 
            // button8
            // 
            button8.Location = new Point(154, 476);
            button8.Name = "button8";
            button8.Size = new Size(585, 23);
            button8.TabIndex = 3;
            button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(154, 367);
            button7.Name = "button7";
            button7.Size = new Size(174, 23);
            button7.TabIndex = 3;
            button7.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(396, 247);
            button6.Name = "button6";
            button6.Size = new Size(150, 23);
            button6.TabIndex = 4;
            button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(154, 326);
            button5.Name = "button5";
            button5.Size = new Size(174, 23);
            button5.TabIndex = 3;
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(154, 286);
            button4.Name = "button4";
            button4.Size = new Size(141, 23);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(154, 247);
            button3.Name = "button3";
            button3.Size = new Size(126, 23);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(153, 206);
            button2.Name = "button2";
            button2.Size = new Size(175, 23);
            button2.TabIndex = 3;
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(150, 164);
            button1.Name = "button1";
            button1.Size = new Size(247, 23);
            button1.TabIndex = 3;
            button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(552, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(220, 270);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(153, 167);
            label12.Name = "label12";
            label12.Size = new Size(0, 15);
            label12.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(835, 488);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(134, 245);
            label11.Name = "label11";
            label11.Size = new Size(0, 15);
            label11.TabIndex = 2;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(20, 321);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1272, 679);
            Controls.Add(dateTimePicker1);
            Controls.Add(label11);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label tituloLBL;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label8;
        private Label label7;
        private TextBox textBoxApellido;
        private Label label9;
        private TextBox textBoxDocumento;
        private TextBox textBoxNacionalidad;
        private TextBox textBoxNombre;
        private DomainUpDown domainUpDownSexo;
        private Button buttonSave;
        private TextBox textBoxNacimiento;
        private TextBox textBox1;
        private Label label10;
        private TextBox textBoxDomicilio;
        private TextBox textBoxVencimiento;
        private TextBox textBoxEmision;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox2;
        private Button button3;
        private Button button2;
        private Button button1;
        private Button button5;
        private Button button4;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label13;
        private DateTimePicker dateTimePicker1;
    }
}