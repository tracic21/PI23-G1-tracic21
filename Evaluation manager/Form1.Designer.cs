namespace Evaluation_manager {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.lbl_korisnickoime = new System.Windows.Forms.Label();
            this.lbl_lozinka = new System.Windows.Forms.Label();
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_lozinka = new System.Windows.Forms.TextBox();
            this.bttn_prijava = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_korisnickoime
            // 
            this.lbl_korisnickoime.AutoSize = true;
            this.lbl_korisnickoime.Location = new System.Drawing.Point(28, 30);
            this.lbl_korisnickoime.Name = "lbl_korisnickoime";
            this.lbl_korisnickoime.Size = new System.Drawing.Size(75, 13);
            this.lbl_korisnickoime.TabIndex = 0;
            this.lbl_korisnickoime.Text = "Korisničko ime";
            this.lbl_korisnickoime.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_lozinka
            // 
            this.lbl_lozinka.AutoSize = true;
            this.lbl_lozinka.Location = new System.Drawing.Point(28, 116);
            this.lbl_lozinka.Name = "lbl_lozinka";
            this.lbl_lozinka.Size = new System.Drawing.Size(44, 13);
            this.lbl_lozinka.TabIndex = 1;
            this.lbl_lozinka.Text = "Lozinka";
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(143, 22);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(100, 20);
            this.txt_ime.TabIndex = 2;
            // 
            // txt_lozinka
            // 
            this.txt_lozinka.Location = new System.Drawing.Point(143, 116);
            this.txt_lozinka.Name = "txt_lozinka";
            this.txt_lozinka.Size = new System.Drawing.Size(100, 20);
            this.txt_lozinka.TabIndex = 3;
            // 
            // bttn_prijava
            // 
            this.bttn_prijava.Location = new System.Drawing.Point(167, 217);
            this.bttn_prijava.Name = "bttn_prijava";
            this.bttn_prijava.Size = new System.Drawing.Size(75, 23);
            this.bttn_prijava.TabIndex = 4;
            this.bttn_prijava.Text = "Prijava";
            this.bttn_prijava.UseVisualStyleBackColor = true;
            this.bttn_prijava.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bttn_prijava);
            this.Controls.Add(this.txt_lozinka);
            this.Controls.Add(this.txt_ime);
            this.Controls.Add(this.lbl_lozinka);
            this.Controls.Add(this.lbl_korisnickoime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_korisnickoime;
        private System.Windows.Forms.Label lbl_lozinka;
        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_lozinka;
        private System.Windows.Forms.Button bttn_prijava;
    }
}

