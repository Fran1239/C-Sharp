namespace WinFormsApp4_ecommerce
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
            groupBox1 = new GroupBox();
            vScrollBar1 = new VScrollBar();
            button4 = new Button();
            button3 = new Button();
            label1 = new Label();
            button1 = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.GradientInactiveCaption;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(vScrollBar1);
            groupBox1.Controls.Add(button4);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(14, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(779, 435);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // vScrollBar1
            // 
            vScrollBar1.Location = new Point(757, 49);
            vScrollBar1.Name = "vScrollBar1";
            vScrollBar1.Size = new Size(22, 386);
            vScrollBar1.TabIndex = 3;
            vScrollBar1.Scroll += vScrollBar1_Scroll;
            // 
            // button4
            // 
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(72, 104);
            button4.Name = "button4";
            button4.Size = new Size(276, 248);
            button4.TabIndex = 1;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(722, 0);
            button3.Name = "button3";
            button3.Size = new Size(57, 51);
            button3.TabIndex = 1;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ButtonHighlight;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(186, 19);
            label1.Name = "label1";
            label1.Size = new Size(441, 17);
            label1.TabIndex = 1;
            label1.Text = "Destacados         Hombre          Mujer       Nino/a       Accesorios      Sale";
            // 
            // button1
            // 
            button1.Location = new Point(0, 0);
            button1.Name = "button1";
            button1.Size = new Size(779, 51);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.GradientInactiveCaption;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(404, 128);
            label2.Name = "label2";
            label2.Size = new Size(284, 20);
            label2.TabIndex = 1;
            label2.Text = "Air Jordan 1 Retro High OG \"Lucky Green\"";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(404, 173);
            label3.Name = "label3";
            label3.Size = new Size(168, 15);
            label3.TabIndex = 4;
            label3.Text = "Zapatillas Jordan para Hombre";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(404, 221);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 1;
            label4.Text = "$299.999";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(68, 51);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(881, 492);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private Label label1;
        private Button button3;
        private Button button4;
        private VScrollBar vScrollBar1;
        private Button button1;
        private Label label2;
        private Label label4;
        private Label label3;
        private PictureBox pictureBox1;
    }
}