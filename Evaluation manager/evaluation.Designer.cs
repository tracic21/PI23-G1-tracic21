namespace Evaluation_manager {
    partial class evaluation {
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
            this.txtActivity = new System.Windows.Forms.ComboBox();
            this.txtPotpis = new System.Windows.Forms.TextBox();
            this.txtUvjetocj = new System.Windows.Forms.TextBox();
            this.txtBig = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtEvalDate = new System.Windows.Forms.TextBox();
            this.numBod = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numBod)).BeginInit();
            this.SuspendLayout();
            // 
            // txtActivity
            // 
            this.txtActivity.FormattingEnabled = true;
            this.txtActivity.Location = new System.Drawing.Point(29, 30);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.Size = new System.Drawing.Size(195, 21);
            this.txtActivity.TabIndex = 0;
            // 
            // txtPotpis
            // 
            this.txtPotpis.Location = new System.Drawing.Point(428, 31);
            this.txtPotpis.Name = "txtPotpis";
            this.txtPotpis.Size = new System.Drawing.Size(147, 20);
            this.txtPotpis.TabIndex = 1;
            // 
            // txtUvjetocj
            // 
            this.txtUvjetocj.Location = new System.Drawing.Point(624, 30);
            this.txtUvjetocj.Name = "txtUvjetocj";
            this.txtUvjetocj.Size = new System.Drawing.Size(148, 20);
            this.txtUvjetocj.TabIndex = 2;
            // 
            // txtBig
            // 
            this.txtBig.Location = new System.Drawing.Point(29, 66);
            this.txtBig.Multiline = true;
            this.txtBig.Name = "txtBig";
            this.txtBig.Size = new System.Drawing.Size(743, 301);
            this.txtBig.TabIndex = 3;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(440, 388);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(100, 20);
            this.txtTeacher.TabIndex = 4;
            // 
            // txtEvalDate
            // 
            this.txtEvalDate.Location = new System.Drawing.Point(546, 388);
            this.txtEvalDate.Name = "txtEvalDate";
            this.txtEvalDate.ReadOnly = true;
            this.txtEvalDate.Size = new System.Drawing.Size(100, 20);
            this.txtEvalDate.TabIndex = 5;
            // 
            // numBod
            // 
            this.numBod.Location = new System.Drawing.Point(652, 389);
            this.numBod.Name = "numBod";
            this.numBod.ReadOnly = true;
            this.numBod.Size = new System.Drawing.Size(120, 20);
            this.numBod.TabIndex = 6;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(614, 415);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(697, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Aktivnost:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(425, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Uvjet za potpis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(621, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Uvjet za oocjenu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(437, 373);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Ocjenivač";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(543, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Datum evauacije";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(649, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bodovi";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.numBod);
            this.Controls.Add(this.txtEvalDate);
            this.Controls.Add(this.txtTeacher);
            this.Controls.Add(this.txtBig);
            this.Controls.Add(this.txtUvjetocj);
            this.Controls.Add(this.txtPotpis);
            this.Controls.Add(this.txtActivity);
            this.Name = "evaluation";
            this.Text = "evaluation";
            ((System.ComponentModel.ISupportInitialize)(this.numBod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox txtActivity;
        private System.Windows.Forms.TextBox txtPotpis;
        private System.Windows.Forms.TextBox txtUvjetocj;
        private System.Windows.Forms.TextBox txtBig;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtEvalDate;
        private System.Windows.Forms.NumericUpDown numBod;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}