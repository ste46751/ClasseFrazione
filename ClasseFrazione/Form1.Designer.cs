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
            this.txt_decimale = new System.Windows.Forms.TextBox();
            this.lbl_decimale = new System.Windows.Forms.Label();
            this.bttn_convers = new System.Windows.Forms.Button();
            this.txt_decins = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bttn_elev = new System.Windows.Forms.Button();
            this.txt_ele = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(313, 103);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(26, 20);
            this.textBox1.TabIndex = 0;
            // 
            // bttn_somma
            // 
            this.bttn_somma.Location = new System.Drawing.Point(382, 100);
            this.bttn_somma.Name = "bttn_somma";
            this.bttn_somma.Size = new System.Drawing.Size(75, 23);
            this.bttn_somma.TabIndex = 1;
            this.bttn_somma.Text = "SOMMA";
            this.bttn_somma.UseVisualStyleBackColor = true;
            this.bttn_somma.Click += new System.EventHandler(this.bttn_somma_Click);
            // 
            // bttn_sottr
            // 
            this.bttn_sottr.Location = new System.Drawing.Point(485, 100);
            this.bttn_sottr.Name = "bttn_sottr";
            this.bttn_sottr.Size = new System.Drawing.Size(75, 23);
            this.bttn_sottr.TabIndex = 2;
            this.bttn_sottr.Text = "SOTTRAZ.";
            this.bttn_sottr.UseVisualStyleBackColor = true;
            this.bttn_sottr.Click += new System.EventHandler(this.bttn_sottr_Click);
            // 
            // bttn_moltip
            // 
            this.bttn_moltip.Location = new System.Drawing.Point(382, 138);
            this.bttn_moltip.Name = "bttn_moltip";
            this.bttn_moltip.Size = new System.Drawing.Size(75, 23);
            this.bttn_moltip.TabIndex = 3;
            this.bttn_moltip.Text = "MOLTIPL.";
            this.bttn_moltip.UseVisualStyleBackColor = true;
            this.bttn_moltip.Click += new System.EventHandler(this.bttn_moltip_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(485, 138);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "DIVISIONE";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(313, 138);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(26, 20);
            this.textBox2.TabIndex = 5;
            // 
            // bttn_sempl
            // 
            this.bttn_sempl.Location = new System.Drawing.Point(382, 179);
            this.bttn_sempl.Name = "bttn_sempl";
            this.bttn_sempl.Size = new System.Drawing.Size(124, 23);
            this.bttn_sempl.TabIndex = 6;
            this.bttn_sempl.Text = "SEMPLIFICA";
            this.bttn_sempl.UseVisualStyleBackColor = true;
            this.bttn_sempl.Click += new System.EventHandler(this.bttn_sempl_Click);
            // 
            // txt_decimale
            // 
            this.txt_decimale.Location = new System.Drawing.Point(313, 195);
            this.txt_decimale.Name = "txt_decimale";
            this.txt_decimale.Size = new System.Drawing.Size(26, 20);
            this.txt_decimale.TabIndex = 7;
            // 
            // lbl_decimale
            // 
            this.lbl_decimale.AutoSize = true;
            this.lbl_decimale.Location = new System.Drawing.Point(284, 179);
            this.lbl_decimale.Name = "lbl_decimale";
            this.lbl_decimale.Size = new System.Drawing.Size(92, 13);
            this.lbl_decimale.TabIndex = 8;
            this.lbl_decimale.Text = "Numero decimale:";
            // 
            // bttn_convers
            // 
            this.bttn_convers.Location = new System.Drawing.Point(123, 138);
            this.bttn_convers.Name = "bttn_convers";
            this.bttn_convers.Size = new System.Drawing.Size(124, 38);
            this.bttn_convers.TabIndex = 9;
            this.bttn_convers.Text = "CONVERTI IN FRAZIONE";
            this.bttn_convers.UseVisualStyleBackColor = true;
            this.bttn_convers.Click += new System.EventHandler(this.bttn_convers_Click);
            // 
            // txt_decins
            // 
            this.txt_decins.Location = new System.Drawing.Point(153, 103);
            this.txt_decins.Name = "txt_decins";
            this.txt_decins.Size = new System.Drawing.Size(60, 20);
            this.txt_decins.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Inserisci numero decimale";
            // 
            // bttn_elev
            // 
            this.bttn_elev.Location = new System.Drawing.Point(578, 101);
            this.bttn_elev.Name = "bttn_elev";
            this.bttn_elev.Size = new System.Drawing.Size(75, 23);
            this.bttn_elev.TabIndex = 12;
            this.bttn_elev.Text = "ELEVAZ";
            this.bttn_elev.UseVisualStyleBackColor = true;
            this.bttn_elev.Click += new System.EventHandler(this.bttn_elev_Click);
            // 
            // txt_ele
            // 
            this.txt_ele.Location = new System.Drawing.Point(598, 141);
            this.txt_ele.Name = "txt_ele";
            this.txt_ele.Size = new System.Drawing.Size(26, 20);
            this.txt_ele.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_ele);
            this.Controls.Add(this.bttn_elev);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_decins);
            this.Controls.Add(this.bttn_convers);
            this.Controls.Add(this.lbl_decimale);
            this.Controls.Add(this.txt_decimale);
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
        private System.Windows.Forms.TextBox txt_decimale;
        private System.Windows.Forms.Label lbl_decimale;
        private System.Windows.Forms.Button bttn_convers;
        private System.Windows.Forms.TextBox txt_decins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttn_elev;
        private System.Windows.Forms.TextBox txt_ele;
    }
}

