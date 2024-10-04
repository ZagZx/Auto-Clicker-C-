namespace Teste
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_click = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.sec_click = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ms_click = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.min_click = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.hours_click = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.clicker_check = new System.Windows.Forms.CheckBox();
            this.shut_check = new System.Windows.Forms.CheckBox();
            this.label_shut = new System.Windows.Forms.Label();
            this.start_btn = new System.Windows.Forms.Button();
            this.stop_btn = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.hours_shut = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.min_shut = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.sec_shut = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ms_shut = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.key_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label_click
            // 
            this.label_click.AutoSize = true;
            this.label_click.Location = new System.Drawing.Point(167, 12);
            this.label_click.Name = "label_click";
            this.label_click.Size = new System.Drawing.Size(60, 13);
            this.label_click.TabIndex = 0;
            this.label_click.Text = "Click Delay";
            this.label_click.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Miliseconds";
            // 
            // sec_click
            // 
            this.sec_click.Location = new System.Drawing.Point(221, 24);
            this.sec_click.MaxLength = 3;
            this.sec_click.Name = "sec_click";
            this.sec_click.Size = new System.Drawing.Size(30, 20);
            this.sec_click.TabIndex = 15;
            this.sec_click.TabStop = false;
            this.sec_click.Tag = "sec";
            this.sec_click.Text = "0";
            this.sec_click.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sec_click.TextChanged += new System.EventHandler(this.textBox4_TextChanged_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(212, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Seconds";
            // 
            // ms_click
            // 
            this.ms_click.Location = new System.Drawing.Point(316, 24);
            this.ms_click.MaxLength = 3;
            this.ms_click.Name = "ms_click";
            this.ms_click.Size = new System.Drawing.Size(30, 20);
            this.ms_click.TabIndex = 13;
            this.ms_click.TabStop = false;
            this.ms_click.Tag = "milisec";
            this.ms_click.Text = "0";
            this.ms_click.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ms_click.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Minutes";
            // 
            // min_click
            // 
            this.min_click.Location = new System.Drawing.Point(121, 24);
            this.min_click.MaxLength = 3;
            this.min_click.Name = "min_click";
            this.min_click.Size = new System.Drawing.Size(30, 20);
            this.min_click.TabIndex = 11;
            this.min_click.TabStop = false;
            this.min_click.Tag = "min";
            this.min_click.Text = "0";
            this.min_click.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.min_click.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hours";
            // 
            // hours_click
            // 
            this.hours_click.Location = new System.Drawing.Point(20, 24);
            this.hours_click.MaxLength = 3;
            this.hours_click.Name = "hours_click";
            this.hours_click.Size = new System.Drawing.Size(30, 20);
            this.hours_click.TabIndex = 9;
            this.hours_click.TabStop = false;
            this.hours_click.Tag = "hour";
            this.hours_click.Text = "0";
            this.hours_click.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.hours_click.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.hours_click);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.min_click);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.sec_click);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ms_click);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(12, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(370, 63);
            this.panel1.TabIndex = 17;
            // 
            // clicker_check
            // 
            this.clicker_check.AutoSize = true;
            this.clicker_check.Checked = true;
            this.clicker_check.CheckState = System.Windows.Forms.CheckState.Checked;
            this.clicker_check.Location = new System.Drawing.Point(302, 8);
            this.clicker_check.Name = "clicker_check";
            this.clicker_check.Size = new System.Drawing.Size(80, 17);
            this.clicker_check.TabIndex = 18;
            this.clicker_check.TabStop = false;
            this.clicker_check.Text = "AutoClicker";
            this.clicker_check.UseVisualStyleBackColor = true;
            this.clicker_check.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // shut_check
            // 
            this.shut_check.AutoSize = true;
            this.shut_check.Location = new System.Drawing.Point(302, 119);
            this.shut_check.Name = "shut_check";
            this.shut_check.Size = new System.Drawing.Size(91, 17);
            this.shut_check.TabIndex = 29;
            this.shut_check.TabStop = false;
            this.shut_check.Text = "Shutdown PC";
            this.shut_check.UseVisualStyleBackColor = true;
            // 
            // label_shut
            // 
            this.label_shut.AutoSize = true;
            this.label_shut.Location = new System.Drawing.Point(155, 123);
            this.label_shut.Name = "label_shut";
            this.label_shut.Size = new System.Drawing.Size(85, 13);
            this.label_shut.TabIndex = 19;
            this.label_shut.Text = "Shutdown Delay";
            this.label_shut.Click += new System.EventHandler(this.label10_Click);
            // 
            // start_btn
            // 
            this.start_btn.ForeColor = System.Drawing.Color.Black;
            this.start_btn.Location = new System.Drawing.Point(24, 233);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(155, 43);
            this.start_btn.TabIndex = 30;
            this.start_btn.TabStop = false;
            this.start_btn.Text = "Start";
            this.start_btn.UseVisualStyleBackColor = true;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // stop_btn
            // 
            this.stop_btn.Enabled = false;
            this.stop_btn.ForeColor = System.Drawing.Color.Black;
            this.stop_btn.Location = new System.Drawing.Point(214, 233);
            this.stop_btn.Name = "stop_btn";
            this.stop_btn.Size = new System.Drawing.Size(155, 43);
            this.stop_btn.TabIndex = 31;
            this.stop_btn.TabStop = false;
            this.stop_btn.Text = "Stop";
            this.stop_btn.UseVisualStyleBackColor = true;
            this.stop_btn.Click += new System.EventHandler(this.stop_btn_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.hours_shut);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.min_shut);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.sec_shut);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.ms_shut);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Location = new System.Drawing.Point(12, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(370, 63);
            this.panel3.TabIndex = 32;
            // 
            // hours_shut
            // 
            this.hours_shut.Location = new System.Drawing.Point(20, 24);
            this.hours_shut.MaxLength = 3;
            this.hours_shut.Name = "hours_shut";
            this.hours_shut.Size = new System.Drawing.Size(30, 20);
            this.hours_shut.TabIndex = 9;
            this.hours_shut.TabStop = false;
            this.hours_shut.Tag = "hour";
            this.hours_shut.Text = "0";
            this.hours_shut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 8);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Hours";
            // 
            // min_shut
            // 
            this.min_shut.Location = new System.Drawing.Point(121, 24);
            this.min_shut.MaxLength = 3;
            this.min_shut.Name = "min_shut";
            this.min_shut.Size = new System.Drawing.Size(30, 20);
            this.min_shut.TabIndex = 11;
            this.min_shut.TabStop = false;
            this.min_shut.Tag = "min";
            this.min_shut.Text = "0";
            this.min_shut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(114, 8);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "Minutes";
            // 
            // sec_shut
            // 
            this.sec_shut.Location = new System.Drawing.Point(221, 24);
            this.sec_shut.MaxLength = 3;
            this.sec_shut.Name = "sec_shut";
            this.sec_shut.Size = new System.Drawing.Size(30, 20);
            this.sec_shut.TabIndex = 15;
            this.sec_shut.TabStop = false;
            this.sec_shut.Tag = "sec";
            this.sec_shut.Text = "0";
            this.sec_shut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(212, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "Seconds";
            // 
            // ms_shut
            // 
            this.ms_shut.Location = new System.Drawing.Point(316, 24);
            this.ms_shut.MaxLength = 3;
            this.ms_shut.Name = "ms_shut";
            this.ms_shut.Size = new System.Drawing.Size(30, 20);
            this.ms_shut.TabIndex = 13;
            this.ms_shut.TabStop = false;
            this.ms_shut.Tag = "milisec";
            this.ms_shut.Text = "0";
            this.ms_shut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(300, 8);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 16;
            this.label14.Text = "Miliseconds";
            // 
            // key_btn
            // 
            this.key_btn.ForeColor = System.Drawing.Color.Black;
            this.key_btn.Location = new System.Drawing.Point(24, 293);
            this.key_btn.Name = "key_btn";
            this.key_btn.Size = new System.Drawing.Size(345, 43);
            this.key_btn.TabIndex = 33;
            this.key_btn.TabStop = false;
            this.key_btn.Text = "Key";
            this.key_btn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(394, 361);
            this.Controls.Add(this.key_btn);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.stop_btn);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.shut_check);
            this.Controls.Add(this.label_shut);
            this.Controls.Add(this.clicker_check);
            this.Controls.Add(this.label_click);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Zleeping Auto Clicker";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_click;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox clicker_check;
        private System.Windows.Forms.TextBox sec_click;
        private System.Windows.Forms.TextBox ms_click;
        private System.Windows.Forms.TextBox min_click;
        private System.Windows.Forms.TextBox hours_click;
        private System.Windows.Forms.CheckBox shut_check;
        private System.Windows.Forms.Label label_shut;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button stop_btn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox hours_shut;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox min_shut;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox sec_shut;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ms_shut;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button key_btn;
    }
}

