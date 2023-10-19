namespace Paint2
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
            this.panel_shapes = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_shapes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pic_color = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.panel_shapes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_shapes
            // 
            this.panel_shapes.Controls.Add(this.button4);
            this.panel_shapes.Controls.Add(this.button3);
            this.panel_shapes.Controls.Add(this.button2);
            this.panel_shapes.Controls.Add(this.btn_shapes);
            this.panel_shapes.Location = new System.Drawing.Point(12, 12);
            this.panel_shapes.Name = "panel_shapes";
            this.panel_shapes.Size = new System.Drawing.Size(94, 100);
            this.panel_shapes.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.Image = global::Paint2.Properties.Resources.line;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(3, 239);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(88, 62);
            this.button4.TabIndex = 3;
            this.button4.Text = "Line";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Image = global::Paint2.Properties.Resources.circle;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.Location = new System.Drawing.Point(3, 106);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 62);
            this.button3.TabIndex = 2;
            this.button3.Text = "Ellipse";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Image = global::Paint2.Properties.Resources.rectangle;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(3, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(88, 62);
            this.button2.TabIndex = 1;
            this.button2.Text = "Rectangle";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btn_shapes
            // 
            this.btn_shapes.Image = global::Paint2.Properties.Resources.shapes1;
            this.btn_shapes.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_shapes.Location = new System.Drawing.Point(3, 3);
            this.btn_shapes.Name = "btn_shapes";
            this.btn_shapes.Size = new System.Drawing.Size(88, 97);
            this.btn_shapes.TabIndex = 0;
            this.btn_shapes.Text = "Shapes";
            this.btn_shapes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_shapes.UseVisualStyleBackColor = true;
            this.btn_shapes.Click += new System.EventHandler(this.btn_shapes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1182, 753);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(121, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 100);
            this.panel1.TabIndex = 2;
            // 
            // button6
            // 
            this.button6.Image = global::Paint2.Properties.Resources.eraser;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button6.Location = new System.Drawing.Point(127, 3);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 70);
            this.button6.TabIndex = 3;
            this.button6.Text = "Erase";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Image = global::Paint2.Properties.Resources.bucket;
            this.button5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button5.Location = new System.Drawing.Point(65, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(56, 70);
            this.button5.TabIndex = 2;
            this.button5.Text = "Fill";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Paint2.Properties.Resources.pencil;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(3, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 70);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pencil";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tools";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.LightGray;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "3",
            "5",
            "8",
            "12",
            "15"});
            this.comboBox1.Location = new System.Drawing.Point(3, 4);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(57, 28);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Text = "1px";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Location = new System.Drawing.Point(324, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(64, 100);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Size";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::Paint2.Properties.Resources.color2;
            this.pictureBox2.Location = new System.Drawing.Point(480, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(313, 100);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(614, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Color";
            // 
            // pic_color
            // 
            this.pic_color.BackColor = System.Drawing.Color.White;
            this.pic_color.Location = new System.Drawing.Point(406, 31);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(53, 55);
            this.pic_color.TabIndex = 6;
            this.pic_color.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.Image = global::Paint2.Properties.Resources.more_color;
            this.button7.Location = new System.Drawing.Point(808, 31);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(53, 55);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 753);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pic_color);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_shapes);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_shapes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panel_shapes;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button btn_shapes;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button1;
        private Label label1;
        private ComboBox comboBox1;
        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox2;
        private Label label3;
        private Button pic_color;
        private Button button7;
    }
}