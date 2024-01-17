namespace WinFormsApp3_calculadora
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
            groupBox1 = new GroupBox();
            buttonMultiplicacion = new Button();
            buttonDivision = new Button();
            buttonMenos = new Button();
            buttonMas = new Button();
            buttonIgual = new Button();
            buttonOnOff = new Button();
            button0 = new Button();
            button9 = new Button();
            button8 = new Button();
            button7 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            btRta = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GrayText;
            groupBox1.Controls.Add(buttonMultiplicacion);
            groupBox1.Controls.Add(buttonDivision);
            groupBox1.Controls.Add(buttonMenos);
            groupBox1.Controls.Add(buttonMas);
            groupBox1.Controls.Add(buttonIgual);
            groupBox1.Controls.Add(buttonOnOff);
            groupBox1.Controls.Add(button0);
            groupBox1.Controls.Add(button9);
            groupBox1.Controls.Add(button8);
            groupBox1.Controls.Add(button7);
            groupBox1.Controls.Add(button6);
            groupBox1.Controls.Add(button5);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(btRta);
            groupBox1.Location = new Point(225, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(445, 523);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // buttonMultiplicacion
            // 
            buttonMultiplicacion.BackColor = SystemColors.ControlLight;
            buttonMultiplicacion.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiplicacion.Location = new Point(304, 436);
            buttonMultiplicacion.Name = "buttonMultiplicacion";
            buttonMultiplicacion.Size = new Size(116, 62);
            buttonMultiplicacion.TabIndex = 13;
            buttonMultiplicacion.Text = "x";
            buttonMultiplicacion.UseVisualStyleBackColor = false;
            buttonMultiplicacion.Click += buttonMultiplicacion_Click;
            // 
            // buttonDivision
            // 
            buttonDivision.BackColor = SystemColors.ControlLight;
            buttonDivision.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivision.Location = new Point(304, 354);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(116, 62);
            buttonDivision.TabIndex = 12;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = false;
            buttonDivision.Click += buttonDivision_Click;
            // 
            // buttonMenos
            // 
            buttonMenos.BackColor = SystemColors.ControlLight;
            buttonMenos.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMenos.Location = new Point(304, 267);
            buttonMenos.Name = "buttonMenos";
            buttonMenos.Size = new Size(116, 62);
            buttonMenos.TabIndex = 11;
            buttonMenos.Text = "-";
            buttonMenos.UseVisualStyleBackColor = false;
            buttonMenos.Click += buttonMenos_Click;
            // 
            // buttonMas
            // 
            buttonMas.BackColor = SystemColors.ControlLight;
            buttonMas.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMas.Location = new Point(304, 178);
            buttonMas.Name = "buttonMas";
            buttonMas.Size = new Size(116, 62);
            buttonMas.TabIndex = 10;
            buttonMas.Text = "+";
            buttonMas.UseVisualStyleBackColor = false;
            buttonMas.Click += buttonMas_Click;
            // 
            // buttonIgual
            // 
            buttonIgual.BackColor = SystemColors.ControlLight;
            buttonIgual.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonIgual.Location = new Point(210, 436);
            buttonIgual.Name = "buttonIgual";
            buttonIgual.Size = new Size(68, 62);
            buttonIgual.TabIndex = 9;
            buttonIgual.Text = "=";
            buttonIgual.UseVisualStyleBackColor = false;
            buttonIgual.Click += buttonIgual_Click;
            // 
            // buttonOnOff
            // 
            buttonOnOff.BackColor = SystemColors.ControlLight;
            buttonOnOff.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOnOff.Location = new Point(23, 436);
            buttonOnOff.Name = "buttonOnOff";
            buttonOnOff.Size = new Size(68, 62);
            buttonOnOff.TabIndex = 8;
            buttonOnOff.Text = "Ans";
            buttonOnOff.UseVisualStyleBackColor = false;
            // 
            // button0
            // 
            button0.BackColor = SystemColors.ControlLight;
            button0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(117, 436);
            button0.Name = "button0";
            button0.Size = new Size(68, 62);
            button0.TabIndex = 4;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += button0_Click;
            // 
            // button9
            // 
            button9.BackColor = SystemColors.ControlLight;
            button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(210, 354);
            button9.Name = "button9";
            button9.Size = new Size(68, 62);
            button9.TabIndex = 4;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.BackColor = SystemColors.ControlLight;
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(117, 354);
            button8.Name = "button8";
            button8.Size = new Size(68, 62);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button7
            // 
            button7.BackColor = SystemColors.ControlLight;
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(23, 354);
            button7.Name = "button7";
            button7.Size = new Size(68, 62);
            button7.TabIndex = 4;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.ControlLight;
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(210, 267);
            button6.Name = "button6";
            button6.Size = new Size(68, 62);
            button6.TabIndex = 6;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.ControlLight;
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(117, 267);
            button5.Name = "button5";
            button5.Size = new Size(68, 62);
            button5.TabIndex = 5;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlLight;
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(23, 267);
            button4.Name = "button4";
            button4.Size = new Size(68, 62);
            button4.TabIndex = 4;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlLight;
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(210, 178);
            button3.Name = "button3";
            button3.Size = new Size(68, 62);
            button3.TabIndex = 3;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlLight;
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(117, 178);
            button2.Name = "button2";
            button2.Size = new Size(68, 62);
            button2.TabIndex = 2;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlLight;
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(23, 178);
            button1.Name = "button1";
            button1.Size = new Size(68, 62);
            button1.TabIndex = 1;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btRta
            // 
            btRta.BackColor = SystemColors.ControlLight;
            btRta.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btRta.Location = new Point(23, 20);
            btRta.Name = "btRta";
            btRta.Size = new Size(397, 117);
            btRta.TabIndex = 0;
            btRta.UseVisualStyleBackColor = false;
            btRta.Click += btRta_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 547);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private Button button1;
        private Button btRta;
        private Button buttonIgual;
        private Button buttonOnOff;
        private Button button0;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button buttonMultiplicacion;
        private Button buttonDivision;
        private Button buttonMenos;
        private Button buttonMas;
    }
}