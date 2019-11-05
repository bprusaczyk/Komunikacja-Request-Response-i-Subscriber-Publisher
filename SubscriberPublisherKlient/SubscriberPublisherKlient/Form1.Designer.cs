namespace SubscriberPublisherKlient
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
            this.subskrybujGrupa = new System.Windows.Forms.GroupBox();
            this.logi = new System.Windows.Forms.ListBox();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            this.tematWybor = new System.Windows.Forms.ComboBox();
            this.ipSerweraGrupa = new System.Windows.Forms.GroupBox();
            this.ok = new System.Windows.Forms.Button();
            this.ipSerwera = new System.Windows.Forms.TextBox();
            this.subskrybujGrupa.SuspendLayout();
            this.ipSerweraGrupa.SuspendLayout();
            this.SuspendLayout();
            // 
            // subskrybujGrupa
            // 
            this.subskrybujGrupa.Controls.Add(this.logi);
            this.subskrybujGrupa.Controls.Add(this.stop);
            this.subskrybujGrupa.Controls.Add(this.start);
            this.subskrybujGrupa.Controls.Add(this.tematWybor);
            this.subskrybujGrupa.Enabled = false;
            this.subskrybujGrupa.Location = new System.Drawing.Point(12, 100);
            this.subskrybujGrupa.Name = "subskrybujGrupa";
            this.subskrybujGrupa.Size = new System.Drawing.Size(468, 238);
            this.subskrybujGrupa.TabIndex = 0;
            this.subskrybujGrupa.TabStop = false;
            this.subskrybujGrupa.Text = "Subskrybuj";
            // 
            // logi
            // 
            this.logi.FormattingEnabled = true;
            this.logi.Location = new System.Drawing.Point(7, 77);
            this.logi.Name = "logi";
            this.logi.Size = new System.Drawing.Size(455, 160);
            this.logi.TabIndex = 3;
            // 
            // stop
            // 
            this.stop.Enabled = false;
            this.stop.Location = new System.Drawing.Point(356, 48);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(106, 23);
            this.stop.TabIndex = 2;
            this.stop.Text = "Stop";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(7, 47);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(106, 23);
            this.start.TabIndex = 1;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // tematWybor
            // 
            this.tematWybor.FormattingEnabled = true;
            this.tematWybor.Items.AddRange(new object[] {
            "datę",
            "czas",
            "datę i czas"});
            this.tematWybor.Location = new System.Drawing.Point(6, 19);
            this.tematWybor.Name = "tematWybor";
            this.tematWybor.Size = new System.Drawing.Size(456, 21);
            this.tematWybor.TabIndex = 0;
            // 
            // ipSerweraGrupa
            // 
            this.ipSerweraGrupa.Controls.Add(this.ok);
            this.ipSerweraGrupa.Controls.Add(this.ipSerwera);
            this.ipSerweraGrupa.Location = new System.Drawing.Point(13, 13);
            this.ipSerweraGrupa.Name = "ipSerweraGrupa";
            this.ipSerweraGrupa.Size = new System.Drawing.Size(461, 81);
            this.ipSerweraGrupa.TabIndex = 1;
            this.ipSerweraGrupa.TabStop = false;
            this.ipSerweraGrupa.Text = "IP serwera";
            // 
            // ok
            // 
            this.ok.Location = new System.Drawing.Point(7, 47);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(448, 23);
            this.ok.TabIndex = 1;
            this.ok.Text = "OK";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // ipSerwera
            // 
            this.ipSerwera.Location = new System.Drawing.Point(7, 20);
            this.ipSerwera.Name = "ipSerwera";
            this.ipSerwera.Size = new System.Drawing.Size(448, 20);
            this.ipSerwera.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 348);
            this.Controls.Add(this.ipSerweraGrupa);
            this.Controls.Add(this.subskrybujGrupa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.subskrybujGrupa.ResumeLayout(false);
            this.ipSerweraGrupa.ResumeLayout(false);
            this.ipSerweraGrupa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox subskrybujGrupa;
        private System.Windows.Forms.ListBox logi;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.ComboBox tematWybor;
        private System.Windows.Forms.GroupBox ipSerweraGrupa;
        private System.Windows.Forms.Button ok;
        private System.Windows.Forms.TextBox ipSerwera;
    }
}

