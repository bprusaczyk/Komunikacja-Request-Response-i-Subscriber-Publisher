namespace RequestResponseKlient
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
            this.components = new System.ComponentModel.Container();
            this.ipSerweraGrupa = new System.Windows.Forms.GroupBox();
            this.ipSerwera = new System.Windows.Forms.TextBox();
            this.pobierzGrupa = new System.Windows.Forms.GroupBox();
            this.date = new System.Windows.Forms.CheckBox();
            this.czas = new System.Windows.Forms.CheckBox();
            this.pobierajCo = new System.Windows.Forms.CheckBox();
            this.coIle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pobierzTeraz = new System.Windows.Forms.Button();
            this.logi = new System.Windows.Forms.ListBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.ok = new System.Windows.Forms.Button();
            this.ipSerweraGrupa.SuspendLayout();
            this.pobierzGrupa.SuspendLayout();
            this.SuspendLayout();
            // 
            // ipSerweraGrupa
            // 
            this.ipSerweraGrupa.Controls.Add(this.ok);
            this.ipSerweraGrupa.Controls.Add(this.ipSerwera);
            this.ipSerweraGrupa.Location = new System.Drawing.Point(12, 12);
            this.ipSerweraGrupa.Name = "ipSerweraGrupa";
            this.ipSerweraGrupa.Size = new System.Drawing.Size(561, 82);
            this.ipSerweraGrupa.TabIndex = 0;
            this.ipSerweraGrupa.TabStop = false;
            this.ipSerweraGrupa.Text = "IP serwera";
            // 
            // ipSerwera
            // 
            this.ipSerwera.Location = new System.Drawing.Point(7, 20);
            this.ipSerwera.Name = "ipSerwera";
            this.ipSerwera.Size = new System.Drawing.Size(548, 20);
            this.ipSerwera.TabIndex = 0;
            // 
            // pobierzGrupa
            // 
            this.pobierzGrupa.Controls.Add(this.pobierzTeraz);
            this.pobierzGrupa.Controls.Add(this.label1);
            this.pobierzGrupa.Controls.Add(this.coIle);
            this.pobierzGrupa.Controls.Add(this.pobierajCo);
            this.pobierzGrupa.Controls.Add(this.czas);
            this.pobierzGrupa.Controls.Add(this.date);
            this.pobierzGrupa.Enabled = false;
            this.pobierzGrupa.Location = new System.Drawing.Point(12, 100);
            this.pobierzGrupa.Name = "pobierzGrupa";
            this.pobierzGrupa.Size = new System.Drawing.Size(561, 111);
            this.pobierzGrupa.TabIndex = 1;
            this.pobierzGrupa.TabStop = false;
            this.pobierzGrupa.Text = "Pobierz";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Location = new System.Drawing.Point(7, 20);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(47, 17);
            this.date.TabIndex = 0;
            this.date.Text = "datę";
            this.date.UseVisualStyleBackColor = true;
            // 
            // czas
            // 
            this.czas.AutoSize = true;
            this.czas.Location = new System.Drawing.Point(7, 44);
            this.czas.Name = "czas";
            this.czas.Size = new System.Drawing.Size(48, 17);
            this.czas.TabIndex = 1;
            this.czas.Text = "czas";
            this.czas.UseVisualStyleBackColor = true;
            // 
            // pobierajCo
            // 
            this.pobierajCo.AutoSize = true;
            this.pobierajCo.Location = new System.Drawing.Point(141, 20);
            this.pobierajCo.Name = "pobierajCo";
            this.pobierajCo.Size = new System.Drawing.Size(79, 17);
            this.pobierajCo.TabIndex = 2;
            this.pobierajCo.Text = "Pobieraj co";
            this.pobierajCo.UseVisualStyleBackColor = true;
            this.pobierajCo.CheckedChanged += new System.EventHandler(this.pobierajCo_CheckedChanged);
            // 
            // coIle
            // 
            this.coIle.Location = new System.Drawing.Point(214, 20);
            this.coIle.Name = "coIle";
            this.coIle.Size = new System.Drawing.Size(32, 20);
            this.coIle.TabIndex = 3;
            this.coIle.TextChanged += new System.EventHandler(this.coIle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "sekund";
            // 
            // pobierzTeraz
            // 
            this.pobierzTeraz.Location = new System.Drawing.Point(9, 68);
            this.pobierzTeraz.Name = "pobierzTeraz";
            this.pobierzTeraz.Size = new System.Drawing.Size(546, 33);
            this.pobierzTeraz.TabIndex = 5;
            this.pobierzTeraz.Text = "Pobierz teraz";
            this.pobierzTeraz.UseVisualStyleBackColor = true;
            this.pobierzTeraz.Click += new System.EventHandler(this.pobierzTeraz_Click);
            // 
            // logi
            // 
            this.logi.FormattingEnabled = true;
            this.logi.Location = new System.Drawing.Point(13, 226);
            this.logi.Name = "logi";
            this.logi.Size = new System.Drawing.Size(560, 238);
            this.logi.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(7, 47);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(548, 23);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 473);
            this.Controls.Add(this.logi);
            this.Controls.Add(this.pobierzGrupa);
            this.Controls.Add(this.ipSerweraGrupa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ipSerweraGrupa.ResumeLayout(false);
            this.ipSerweraGrupa.PerformLayout();
            this.pobierzGrupa.ResumeLayout(false);
            this.pobierzGrupa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ipSerweraGrupa;
        private System.Windows.Forms.TextBox ipSerwera;
        private System.Windows.Forms.GroupBox pobierzGrupa;
        private System.Windows.Forms.Button pobierzTeraz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox coIle;
        private System.Windows.Forms.CheckBox pobierajCo;
        private System.Windows.Forms.CheckBox czas;
        private System.Windows.Forms.CheckBox date;
        private System.Windows.Forms.ListBox logi;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button ok;
    }
}

