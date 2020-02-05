namespace WindowsFormsApp9
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCos = new System.Windows.Forms.Button();
            this.tbCyfry = new System.Windows.Forms.TextBox();
            this.insert = new System.Windows.Forms.Button();
            this.select = new System.Windows.Forms.Button();
            this.count = new System.Windows.Forms.Button();
            this.cbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sbox = new System.Windows.Forms.TextBox();
            this.ibox = new System.Windows.Forms.TextBox();
            this.bbox = new System.Windows.Forms.TextBox();
            this.rndm = new System.Windows.Forms.Button();
            this.clr = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCos
            // 
            this.btnCos.BackColor = System.Drawing.SystemColors.Menu;
            this.btnCos.Location = new System.Drawing.Point(548, 115);
            this.btnCos.Margin = new System.Windows.Forms.Padding(4);
            this.btnCos.Name = "btnCos";
            this.btnCos.Size = new System.Drawing.Size(112, 28);
            this.btnCos.TabIndex = 0;
            this.btnCos.Text = "Bubble_sort";
            this.btnCos.UseVisualStyleBackColor = false;
            this.btnCos.Click += new System.EventHandler(this.btnCos_Click);
            this.btnCos.MouseEnter += new System.EventHandler(this.btnCos_MouseEnter);
            this.btnCos.MouseLeave += new System.EventHandler(this.btnCos_MouseLeave);
            // 
            // tbCyfry
            // 
            this.tbCyfry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCyfry.Location = new System.Drawing.Point(84, 13);
            this.tbCyfry.Margin = new System.Windows.Forms.Padding(4);
            this.tbCyfry.Name = "tbCyfry";
            this.tbCyfry.Size = new System.Drawing.Size(500, 22);
            this.tbCyfry.TabIndex = 1;
            this.tbCyfry.TextChanged += new System.EventHandler(this.tbCyfry_TextChanged);
            // 
            // insert
            // 
            this.insert.BackColor = System.Drawing.SystemColors.Menu;
            this.insert.Location = new System.Drawing.Point(428, 115);
            this.insert.Margin = new System.Windows.Forms.Padding(4);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(112, 28);
            this.insert.TabIndex = 2;
            this.insert.Text = "Insert_sort";
            this.insert.UseVisualStyleBackColor = false;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // select
            // 
            this.select.BackColor = System.Drawing.SystemColors.Menu;
            this.select.Location = new System.Drawing.Point(129, 115);
            this.select.Margin = new System.Windows.Forms.Padding(4);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(112, 28);
            this.select.TabIndex = 3;
            this.select.Text = "Select_sort";
            this.select.UseVisualStyleBackColor = false;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // count
            // 
            this.count.BackColor = System.Drawing.SystemColors.Menu;
            this.count.Location = new System.Drawing.Point(9, 115);
            this.count.Margin = new System.Windows.Forms.Padding(4);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(112, 28);
            this.count.TabIndex = 4;
            this.count.Text = "Counting_sort";
            this.count.UseVisualStyleBackColor = false;
            this.count.Click += new System.EventHandler(this.count_Click);
            // 
            // cbox
            // 
            this.cbox.Location = new System.Drawing.Point(12, 86);
            this.cbox.Name = "cbox";
            this.cbox.Size = new System.Drawing.Size(112, 22);
            this.cbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Time in Milliseconds";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // sbox
            // 
            this.sbox.Location = new System.Drawing.Point(130, 86);
            this.sbox.Name = "sbox";
            this.sbox.Size = new System.Drawing.Size(111, 22);
            this.sbox.TabIndex = 7;
            // 
            // ibox
            // 
            this.ibox.Location = new System.Drawing.Point(429, 86);
            this.ibox.Name = "ibox";
            this.ibox.Size = new System.Drawing.Size(111, 22);
            this.ibox.TabIndex = 7;
            this.ibox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // bbox
            // 
            this.bbox.Location = new System.Drawing.Point(548, 86);
            this.bbox.Name = "bbox";
            this.bbox.Size = new System.Drawing.Size(111, 22);
            this.bbox.TabIndex = 7;
            // 
            // rndm
            // 
            this.rndm.Location = new System.Drawing.Point(297, 42);
            this.rndm.Name = "rndm";
            this.rndm.Size = new System.Drawing.Size(75, 23);
            this.rndm.TabIndex = 8;
            this.rndm.Text = "Generate";
            this.rndm.UseVisualStyleBackColor = true;
            this.rndm.Click += new System.EventHandler(this.rndm_Click);
            // 
            // clr
            // 
            this.clr.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.clr.Location = new System.Drawing.Point(589, 13);
            this.clr.Name = "clr";
            this.clr.Size = new System.Drawing.Size(71, 23);
            this.clr.TabIndex = 9;
            this.clr.Text = "Clear";
            this.clr.UseVisualStyleBackColor = false;
            this.clr.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "10 k random numbers";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(288, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 153);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.clr);
            this.Controls.Add(this.rndm);
            this.Controls.Add(this.bbox);
            this.Controls.Add(this.ibox);
            this.Controls.Add(this.sbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbox);
            this.Controls.Add(this.count);
            this.Controls.Add(this.select);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.tbCyfry);
            this.Controls.Add(this.btnCos);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCos;
        private System.Windows.Forms.TextBox tbCyfry;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button count;
        private System.Windows.Forms.TextBox cbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sbox;
        private System.Windows.Forms.TextBox ibox;
        private System.Windows.Forms.TextBox bbox;
        private System.Windows.Forms.Button rndm;
        private System.Windows.Forms.Button clr;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

