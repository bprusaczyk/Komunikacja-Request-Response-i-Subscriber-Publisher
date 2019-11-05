namespace SubscriberPublisherSerwer
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.start = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.interwal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.czas = new System.Windows.Forms.CheckBox();
            this.date = new System.Windows.Forms.CheckBox();
            this.logi = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.start);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.interwal);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.czas);
            this.groupBox1.Controls.Add(this.date);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 150);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Publikuj";
            // 
            // start
            // 
            this.start.Location = new System.Drawing.Point(7, 103);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(378, 23);
            this.start.TabIndex = 5;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "sekund";
            // 
            // interwal
            // 
            this.interwal.Location = new System.Drawing.Point(32, 65);
            this.interwal.Name = "interwal";
            this.interwal.Size = new System.Drawing.Size(40, 20);
            this.interwal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "co";
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
            // logi
            // 
            this.logi.FormattingEnabled = true;
            this.logi.Location = new System.Drawing.Point(13, 170);
            this.logi.Name = "logi";
            this.logi.Size = new System.Drawing.Size(391, 264);
            this.logi.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 441);
            this.Controls.Add(this.logi);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox interwal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox czas;
        private System.Windows.Forms.CheckBox date;
        private System.Windows.Forms.ListBox logi;
    }
}

