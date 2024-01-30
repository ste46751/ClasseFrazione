namespace ClasseFrazione
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.bttn_somma = new System.Windows.Forms.Button();
            this.bttn_sottr = new System.Windows.Forms.Button();
            this.bttn_moltip = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.bttn_sempl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 0;
            // 
            // bttn_somma
            // 
            this.bttn_somma.Location = new System.Drawing.Point(214, 84);
            this.bttn_somma.Name = "bttn_somma";
            this.bttn_somma.Size = new System.Drawing.Size(75, 23);
            this.bttn_somma.TabIndex = 1;
            this.bttn_somma.Text = "SOMMA";
            this.bttn_somma.UseVisualStyleBackColor = true;
            this.bttn_somma.Click += new System.EventHandler(this.bttn_somma_Click);
            // 
            // bttn_sottr
            // 
            this.bttn_sottr.Location = new System.Drawing.Point(317, 84);
            this.bttn_sottr.Name = "bttn_sottr";
            this.bttn_sottr.Size = new System.Drawing.Size(75, 23);
            this.bttn_sottr.TabIndex = 2;
            this.bttn_sottr.Text = "SOTTRAZ.";
            this.bttn_sottr.UseVisualStyleBackColor = true;
            this.bttn_sottr.Click += new System.EventHandler(this.bttn_sottr_Click);
            // 
            // bttn_moltip
            // 
            this.bttn_moltip.Location = new System.Drawing.Point(214, 122);
            this.bttn_moltip.Name = "bttn_moltip";
            this.bttn_moltip.Size = new System.Drawing.Size(75, 23);
            this.bttn_moltip.TabIndex = 3;
            this.bttn_moltip.Text = "MOLTIPL.";
            this.bttn_moltip.UseVisualStyleBackColor = true;
            this.bttn_moltip.Click += new System.EventHandler(this.bttn_moltip_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(317, 122);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "DIVISIONE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(145, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 20);
            this.textBox2.TabIndex = 5;
            // 
            // bttn_sempl
            // 
            this.bttn_sempl.Location = new System.Drawing.Point(214, 163);
            this.bttn_sempl.Name = "bttn_sempl";
            this.bttn_sempl.Size = new System.Drawing.Size(124, 23);
            this.bttn_sempl.TabIndex = 6;
            this.bttn_sempl.Text = "SEMPLIFICA";
            this.bttn_sempl.UseVisualStyleBackColor = true;
            this.bttn_sempl.Click += new System.EventHandler(this.bttn_sempl_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttn_sempl);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.bttn_moltip);
            this.Controls.Add(this.bttn_sottr);
            this.Controls.Add(this.bttn_somma);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button bttn_somma;
        private System.Windows.Forms.Button bttn_sottr;
        private System.Windows.Forms.Button bttn_moltip;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button bttn_sempl;
    }
}

