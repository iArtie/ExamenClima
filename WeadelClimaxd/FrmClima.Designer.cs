namespace WeadelClimaxd
{
    partial class FrmClima
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
            this.txtClima = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.labelCd = new System.Windows.Forms.Label();
            this.laberDt = new System.Windows.Forms.Label();
            this.labelSn = new System.Windows.Forms.Label();
            this.labelSun = new System.Windows.Forms.Label();
            this.labelWn = new System.Windows.Forms.Label();
            this.labelPress = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTemp = new System.Windows.Forms.Label();
            this.flpContent = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.picWeather = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).BeginInit();
            this.SuspendLayout();
            // 
            // txtClima
            // 
            this.txtClima.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtClima.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtClima.ForeColor = System.Drawing.SystemColors.Control;
            this.txtClima.Location = new System.Drawing.Point(141, 65);
            this.txtClima.Multiline = true;
            this.txtClima.Name = "txtClima";
            this.txtClima.Size = new System.Drawing.Size(320, 36);
            this.txtClima.TabIndex = 0;
            this.txtClima.Enter += new System.EventHandler(this.TxtClima_Enter);
            this.txtClima.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtClima_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(46, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ciudad";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnBuscar.Location = new System.Drawing.Point(492, 65);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 36);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // labelCd
            // 
            this.labelCd.AutoSize = true;
            this.labelCd.BackColor = System.Drawing.Color.Transparent;
            this.labelCd.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCd.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCd.Location = new System.Drawing.Point(153, 134);
            this.labelCd.Name = "labelCd";
            this.labelCd.Size = new System.Drawing.Size(0, 25);
            this.labelCd.TabIndex = 3;
            // 
            // laberDt
            // 
            this.laberDt.AutoSize = true;
            this.laberDt.BackColor = System.Drawing.Color.Transparent;
            this.laberDt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laberDt.ForeColor = System.Drawing.SystemColors.Control;
            this.laberDt.Location = new System.Drawing.Point(153, 192);
            this.laberDt.Name = "laberDt";
            this.laberDt.Size = new System.Drawing.Size(0, 25);
            this.laberDt.TabIndex = 4;
            // 
            // labelSn
            // 
            this.labelSn.AutoSize = true;
            this.labelSn.BackColor = System.Drawing.Color.Black;
            this.labelSn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSn.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSn.Location = new System.Drawing.Point(153, 245);
            this.labelSn.Name = "labelSn";
            this.labelSn.Size = new System.Drawing.Size(47, 25);
            this.labelSn.TabIndex = 5;
            this.labelSn.Text = "N/A";
            // 
            // labelSun
            // 
            this.labelSun.AutoSize = true;
            this.labelSun.BackColor = System.Drawing.Color.Black;
            this.labelSun.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSun.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSun.Location = new System.Drawing.Point(153, 302);
            this.labelSun.Name = "labelSun";
            this.labelSun.Size = new System.Drawing.Size(47, 25);
            this.labelSun.TabIndex = 6;
            this.labelSun.Text = "N/A";
            // 
            // labelWn
            // 
            this.labelWn.AutoSize = true;
            this.labelWn.BackColor = System.Drawing.Color.Transparent;
            this.labelWn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWn.ForeColor = System.Drawing.SystemColors.Control;
            this.labelWn.Location = new System.Drawing.Point(526, 136);
            this.labelWn.Name = "labelWn";
            this.labelWn.Size = new System.Drawing.Size(47, 25);
            this.labelWn.TabIndex = 9;
            this.labelWn.Text = "N/A";
            // 
            // labelPress
            // 
            this.labelPress.AutoSize = true;
            this.labelPress.BackColor = System.Drawing.Color.Transparent;
            this.labelPress.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPress.ForeColor = System.Drawing.SystemColors.Control;
            this.labelPress.Location = new System.Drawing.Point(525, 192);
            this.labelPress.Name = "labelPress";
            this.labelPress.Size = new System.Drawing.Size(47, 25);
            this.labelPress.TabIndex = 11;
            this.labelPress.Text = "N/A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(41, 302);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Sunset";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(41, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Sunrise";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(48, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 25);
            this.label4.TabIndex = 16;
            this.label4.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(23, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Condition";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(346, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Wind Speed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(363, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pressure";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(631, 37);
            this.panel1.TabIndex = 22;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.BackColor = System.Drawing.Color.Black;
            this.labelTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTemp.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTemp.Location = new System.Drawing.Point(461, 266);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(0, 42);
            this.labelTemp.TabIndex = 23;
            // 
            // flpContent
            // 
            this.flpContent.AutoScroll = true;
            this.flpContent.Location = new System.Drawing.Point(0, 367);
            this.flpContent.Name = "flpContent";
            this.flpContent.Size = new System.Drawing.Size(631, 203);
            this.flpContent.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WeadelClimaxd.Properties.Resources.boton_cerrar;
            this.pictureBox1.Location = new System.Drawing.Point(595, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // picWeather
            // 
            this.picWeather.BackColor = System.Drawing.Color.Transparent;
            this.picWeather.Location = new System.Drawing.Point(288, 251);
            this.picWeather.Name = "picWeather";
            this.picWeather.Size = new System.Drawing.Size(154, 90);
            this.picWeather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWeather.TabIndex = 13;
            this.picWeather.TabStop = false;
            // 
            // FrmClima
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(631, 570);
            this.Controls.Add(this.flpContent);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picWeather);
            this.Controls.Add(this.labelPress);
            this.Controls.Add(this.labelWn);
            this.Controls.Add(this.labelSun);
            this.Controls.Add(this.labelSn);
            this.Controls.Add(this.laberDt);
            this.Controls.Add(this.labelCd);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClima);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClima";
            this.Opacity = 0.95D;
            this.Text = "7";
            this.Load += new System.EventHandler(this.FrmClima_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FrmClima_KeyPress);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeather)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClima;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label labelCd;
        private System.Windows.Forms.Label laberDt;
        private System.Windows.Forms.Label labelSn;
        private System.Windows.Forms.Label labelSun;
        private System.Windows.Forms.Label labelWn;
        private System.Windows.Forms.Label labelPress;
        private System.Windows.Forms.PictureBox picWeather;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelTemp;
        private System.Windows.Forms.FlowLayoutPanel flpContent;
    }
}

