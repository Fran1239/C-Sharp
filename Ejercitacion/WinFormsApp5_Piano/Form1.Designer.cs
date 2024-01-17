namespace WinFormsApp5_Piano
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
            gb_Piano = new GroupBox();
            groupBox1 = new GroupBox();
            trackBar1 = new TrackBar();
            buttonOnOff = new Button();
            buttonDO1 = new Button();
            buttonRE1 = new Button();
            buttonMI1 = new Button();
            buttonFA1 = new Button();
            buttonSOL1 = new Button();
            buttonLA1 = new Button();
            buttonSI1 = new Button();
            buttonDo11 = new Button();
            buttonDO2 = new Button();
            buttonRE2 = new Button();
            buttonMI2 = new Button();
            buttonFA2 = new Button();
            buttonSOL2 = new Button();
            buttonLA2 = new Button();
            button1 = new Button();
            button2 = new Button();
            gb_Piano.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // gb_Piano
            // 
            gb_Piano.BackColor = SystemColors.ControlDark;
            gb_Piano.Controls.Add(buttonOnOff);
            gb_Piano.Controls.Add(trackBar1);
            gb_Piano.Controls.Add(groupBox1);
            gb_Piano.Location = new Point(12, 12);
            gb_Piano.Name = "gb_Piano";
            gb_Piano.Size = new Size(1161, 420);
            gb_Piano.TabIndex = 0;
            gb_Piano.TabStop = false;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonHighlight;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(buttonLA2);
            groupBox1.Controls.Add(buttonSOL2);
            groupBox1.Controls.Add(buttonFA2);
            groupBox1.Controls.Add(buttonMI2);
            groupBox1.Controls.Add(buttonDO2);
            groupBox1.Controls.Add(buttonDo11);
            groupBox1.Controls.Add(buttonSI1);
            groupBox1.Controls.Add(buttonLA1);
            groupBox1.Controls.Add(buttonSOL1);
            groupBox1.Controls.Add(buttonFA1);
            groupBox1.Controls.Add(buttonDO1);
            groupBox1.Controls.Add(buttonMI1);
            groupBox1.Controls.Add(buttonRE1);
            groupBox1.Location = new Point(26, 56);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1129, 364);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(643, 9);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(366, 45);
            trackBar1.TabIndex = 1;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // buttonOnOff
            // 
            buttonOnOff.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buttonOnOff.Location = new Point(26, 10);
            buttonOnOff.Name = "buttonOnOff";
            buttonOnOff.Size = new Size(119, 40);
            buttonOnOff.TabIndex = 2;
            buttonOnOff.Text = "ON";
            buttonOnOff.UseVisualStyleBackColor = true;
            // 
            // buttonDO1
            // 
            buttonDO1.Location = new Point(0, 9);
            buttonDO1.Name = "buttonDO1";
            buttonDO1.Size = new Size(72, 351);
            buttonDO1.TabIndex = 0;
            buttonDO1.UseVisualStyleBackColor = true;
            // 
            // buttonRE1
            // 
            buttonRE1.Location = new Point(70, 8);
            buttonRE1.Name = "buttonRE1";
            buttonRE1.Size = new Size(72, 351);
            buttonRE1.TabIndex = 3;
            buttonRE1.UseVisualStyleBackColor = true;
            // 
            // buttonMI1
            // 
            buttonMI1.Location = new Point(140, 9);
            buttonMI1.Name = "buttonMI1";
            buttonMI1.Size = new Size(72, 351);
            buttonMI1.TabIndex = 1;
            buttonMI1.UseVisualStyleBackColor = true;
            // 
            // buttonFA1
            // 
            buttonFA1.Location = new Point(210, 8);
            buttonFA1.Name = "buttonFA1";
            buttonFA1.Size = new Size(72, 351);
            buttonFA1.TabIndex = 4;
            buttonFA1.UseVisualStyleBackColor = true;
            // 
            // buttonSOL1
            // 
            buttonSOL1.Location = new Point(280, 9);
            buttonSOL1.Name = "buttonSOL1";
            buttonSOL1.Size = new Size(72, 351);
            buttonSOL1.TabIndex = 1;
            buttonSOL1.UseVisualStyleBackColor = true;
            // 
            // buttonLA1
            // 
            buttonLA1.Location = new Point(350, 9);
            buttonLA1.Name = "buttonLA1";
            buttonLA1.Size = new Size(72, 351);
            buttonLA1.TabIndex = 1;
            buttonLA1.UseVisualStyleBackColor = true;
            // 
            // buttonSI1
            // 
            buttonSI1.Location = new Point(420, 8);
            buttonSI1.Name = "buttonSI1";
            buttonSI1.Size = new Size(72, 351);
            buttonSI1.TabIndex = 1;
            buttonSI1.UseVisualStyleBackColor = true;
            // 
            // buttonDo11
            // 
            buttonDo11.Location = new Point(490, 8);
            buttonDo11.Name = "buttonDo11";
            buttonDo11.Size = new Size(72, 351);
            buttonDo11.TabIndex = 1;
            buttonDo11.UseVisualStyleBackColor = true;
            // 
            // buttonDO2
            // 
            buttonDO2.Location = new Point(560, 9);
            buttonDO2.Name = "buttonDO2";
            buttonDO2.Size = new Size(72, 351);
            buttonDO2.TabIndex = 1;
            buttonDO2.UseVisualStyleBackColor = true;
            // 
            // buttonRE2
            // 
            buttonRE2.Location = new Point(606, 150);
            buttonRE2.Name = "buttonRE2";
            buttonRE2.Size = new Size(76, 351);
            buttonRE2.TabIndex = 1;
            buttonRE2.UseVisualStyleBackColor = true;
            buttonRE2.Click += buttonRE2_Click;
            // 
            // buttonMI2
            // 
            buttonMI2.Location = new Point(702, 8);
            buttonMI2.Name = "buttonMI2";
            buttonMI2.Size = new Size(72, 356);
            buttonMI2.TabIndex = 1;
            buttonMI2.UseVisualStyleBackColor = true;
            // 
            // buttonFA2
            // 
            buttonFA2.Location = new Point(772, 9);
            buttonFA2.Name = "buttonFA2";
            buttonFA2.Size = new Size(71, 355);
            buttonFA2.TabIndex = 1;
            buttonFA2.UseVisualStyleBackColor = true;
            // 
            // buttonSOL2
            // 
            buttonSOL2.Location = new Point(841, 7);
            buttonSOL2.Name = "buttonSOL2";
            buttonSOL2.Size = new Size(72, 357);
            buttonSOL2.TabIndex = 1;
            buttonSOL2.UseVisualStyleBackColor = true;
            // 
            // buttonLA2
            // 
            buttonLA2.Location = new Point(911, 8);
            buttonLA2.Name = "buttonLA2";
            buttonLA2.Size = new Size(73, 356);
            buttonLA2.TabIndex = 1;
            buttonLA2.UseVisualStyleBackColor = true;
            buttonLA2.Click += buttonLA2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(982, 9);
            button1.Name = "button1";
            button1.Size = new Size(77, 355);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(1057, 7);
            button2.Name = "button2";
            button2.Size = new Size(72, 357);
            button2.TabIndex = 6;
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1185, 522);
            Controls.Add(gb_Piano);
            Controls.Add(buttonRE2);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "Form1";
            gb_Piano.ResumeLayout(false);
            gb_Piano.PerformLayout();
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb_Piano;
        private GroupBox groupBox1;
        private Button buttonOnOff;
        private TrackBar trackBar1;
        private Button buttonLA2;
        private Button buttonSOL2;
        private Button buttonFA2;
        private Button buttonMI2;
        private Button buttonRE2;
        private Button buttonDO2;
        private Button buttonDo11;
        private Button buttonSI1;
        private Button buttonLA1;
        private Button buttonSOL1;
        private Button buttonFA1;
        private Button buttonDO1;
        private Button buttonMI1;
        private Button buttonRE1;
        private Button button2;
        private Button button1;
    }
}