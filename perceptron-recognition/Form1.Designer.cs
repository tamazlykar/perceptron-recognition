namespace perceptron_recognition
{
    partial class Form1
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
            this.canvas = new System.Windows.Forms.PictureBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.tb_number_type = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_learn = new System.Windows.Forms.Button();
            this.btn_learn_by_data = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_0 = new System.Windows.Forms.Label();
            this.lbl_1 = new System.Windows.Forms.Label();
            this.lbl_2 = new System.Windows.Forms.Label();
            this.lbl_3 = new System.Windows.Forms.Label();
            this.lbl_4 = new System.Windows.Forms.Label();
            this.lbl_5 = new System.Windows.Forms.Label();
            this.lbl_6 = new System.Windows.Forms.Label();
            this.lbl_7 = new System.Windows.Forms.Label();
            this.lbl_8 = new System.Windows.Forms.Label();
            this.lbl_9 = new System.Windows.Forms.Label();
            this.btn_recognize = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.BackColor = System.Drawing.Color.White;
            this.canvas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(260, 360);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            this.canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseDown);
            this.canvas.MouseLeave += new System.EventHandler(this.canvas_MouseLeave);
            this.canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseMove);
            this.canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canvas_MouseUp);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(297, 349);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 1;
            this.btn_clear.Text = "Очистить";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // tb_number_type
            // 
            this.tb_number_type.Location = new System.Drawing.Point(297, 285);
            this.tb_number_type.MaxLength = 1;
            this.tb_number_type.Name = "tb_number_type";
            this.tb_number_type.Size = new System.Drawing.Size(100, 20);
            this.tb_number_type.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(413, 282);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_learn
            // 
            this.btn_learn.Location = new System.Drawing.Point(297, 320);
            this.btn_learn.Name = "btn_learn";
            this.btn_learn.Size = new System.Drawing.Size(75, 23);
            this.btn_learn.TabIndex = 4;
            this.btn_learn.Text = "Обучить";
            this.btn_learn.UseVisualStyleBackColor = true;
            this.btn_learn.Click += new System.EventHandler(this.btn_learn_Click);
            // 
            // btn_learn_by_data
            // 
            this.btn_learn_by_data.Location = new System.Drawing.Point(413, 352);
            this.btn_learn_by_data.Name = "btn_learn_by_data";
            this.btn_learn_by_data.Size = new System.Drawing.Size(121, 23);
            this.btn_learn_by_data.TabIndex = 5;
            this.btn_learn_by_data.Text = "Обучить набором";
            this.btn_learn_by_data.UseVisualStyleBackColor = true;
            this.btn_learn_by_data.Click += new System.EventHandler(this.btn_learn_by_data_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(475, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(475, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(475, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "6";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(475, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "5";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(475, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "9";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(475, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "7";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(475, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "8";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(475, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(13, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "3";
            // 
            // lbl_0
            // 
            this.lbl_0.Location = new System.Drawing.Point(494, 25);
            this.lbl_0.Name = "lbl_0";
            this.lbl_0.Size = new System.Drawing.Size(50, 13);
            this.lbl_0.TabIndex = 16;
            this.lbl_0.Text = "0.0";
            // 
            // lbl_1
            // 
            this.lbl_1.Location = new System.Drawing.Point(494, 38);
            this.lbl_1.Name = "lbl_1";
            this.lbl_1.Size = new System.Drawing.Size(50, 13);
            this.lbl_1.TabIndex = 17;
            this.lbl_1.Text = "0.0";
            // 
            // lbl_2
            // 
            this.lbl_2.Location = new System.Drawing.Point(494, 51);
            this.lbl_2.Name = "lbl_2";
            this.lbl_2.Size = new System.Drawing.Size(50, 13);
            this.lbl_2.TabIndex = 18;
            this.lbl_2.Text = "0.0";
            // 
            // lbl_3
            // 
            this.lbl_3.Location = new System.Drawing.Point(494, 64);
            this.lbl_3.Name = "lbl_3";
            this.lbl_3.Size = new System.Drawing.Size(50, 13);
            this.lbl_3.TabIndex = 19;
            this.lbl_3.Text = "0.0";
            // 
            // lbl_4
            // 
            this.lbl_4.Location = new System.Drawing.Point(494, 77);
            this.lbl_4.Name = "lbl_4";
            this.lbl_4.Size = new System.Drawing.Size(50, 13);
            this.lbl_4.TabIndex = 20;
            this.lbl_4.Text = "0.0";
            // 
            // lbl_5
            // 
            this.lbl_5.Location = new System.Drawing.Point(494, 90);
            this.lbl_5.Name = "lbl_5";
            this.lbl_5.Size = new System.Drawing.Size(50, 13);
            this.lbl_5.TabIndex = 21;
            this.lbl_5.Text = "0.0";
            // 
            // lbl_6
            // 
            this.lbl_6.Location = new System.Drawing.Point(494, 103);
            this.lbl_6.Name = "lbl_6";
            this.lbl_6.Size = new System.Drawing.Size(50, 13);
            this.lbl_6.TabIndex = 22;
            this.lbl_6.Text = "0.0";
            // 
            // lbl_7
            // 
            this.lbl_7.Location = new System.Drawing.Point(494, 117);
            this.lbl_7.Name = "lbl_7";
            this.lbl_7.Size = new System.Drawing.Size(50, 13);
            this.lbl_7.TabIndex = 23;
            this.lbl_7.Text = "0.0";
            // 
            // lbl_8
            // 
            this.lbl_8.Location = new System.Drawing.Point(494, 130);
            this.lbl_8.Name = "lbl_8";
            this.lbl_8.Size = new System.Drawing.Size(50, 13);
            this.lbl_8.TabIndex = 24;
            this.lbl_8.Text = "0.0";
            // 
            // lbl_9
            // 
            this.lbl_9.Location = new System.Drawing.Point(494, 143);
            this.lbl_9.Name = "lbl_9";
            this.lbl_9.Size = new System.Drawing.Size(50, 13);
            this.lbl_9.TabIndex = 25;
            this.lbl_9.Text = "0.0";
            // 
            // btn_recognize
            // 
            this.btn_recognize.Location = new System.Drawing.Point(413, 320);
            this.btn_recognize.Name = "btn_recognize";
            this.btn_recognize.Size = new System.Drawing.Size(75, 23);
            this.btn_recognize.TabIndex = 26;
            this.btn_recognize.Text = "Распознать";
            this.btn_recognize.UseVisualStyleBackColor = true;
            this.btn_recognize.Click += new System.EventHandler(this.btn_recognize_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(297, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 72);
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(278, 90);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(191, 186);
            this.textBox1.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 387);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_recognize);
            this.Controls.Add(this.lbl_9);
            this.Controls.Add(this.lbl_8);
            this.Controls.Add(this.lbl_7);
            this.Controls.Add(this.lbl_6);
            this.Controls.Add(this.lbl_5);
            this.Controls.Add(this.lbl_4);
            this.Controls.Add(this.lbl_3);
            this.Controls.Add(this.lbl_2);
            this.Controls.Add(this.lbl_1);
            this.Controls.Add(this.lbl_0);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_learn_by_data);
            this.Controls.Add(this.btn_learn);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.tb_number_type);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Pereceptron Recognition";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.TextBox tb_number_type;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_learn;
        private System.Windows.Forms.Button btn_learn_by_data;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_0;
        private System.Windows.Forms.Label lbl_1;
        private System.Windows.Forms.Label lbl_2;
        private System.Windows.Forms.Label lbl_3;
        private System.Windows.Forms.Label lbl_4;
        private System.Windows.Forms.Label lbl_5;
        private System.Windows.Forms.Label lbl_6;
        private System.Windows.Forms.Label lbl_7;
        private System.Windows.Forms.Label lbl_8;
        private System.Windows.Forms.Label lbl_9;
        private System.Windows.Forms.Button btn_recognize;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}

