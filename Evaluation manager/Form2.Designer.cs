﻿namespace Evaluation_manager {
    partial class Form2 {
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
            this.dgvstudents = new System.Windows.Forms.DataGridView();
            this.EvaluateStudent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudents)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvstudents
            // 
            this.dgvstudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvstudents.Location = new System.Drawing.Point(12, 12);
            this.dgvstudents.Name = "dgvstudents";
            this.dgvstudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvstudents.Size = new System.Drawing.Size(776, 426);
            this.dgvstudents.TabIndex = 0;
            this.dgvstudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvstudents_CellContentClick);
            // 
            // EvaluateStudent
            // 
            this.EvaluateStudent.Location = new System.Drawing.Point(648, 444);
            this.EvaluateStudent.Name = "EvaluateStudent";
            this.EvaluateStudent.Size = new System.Drawing.Size(140, 23);
            this.EvaluateStudent.TabIndex = 1;
            this.EvaluateStudent.Text = "Evaluiraj studenta";
            this.EvaluateStudent.UseVisualStyleBackColor = true;
            this.EvaluateStudent.Click += new System.EventHandler(this.EvaluateStudent_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 476);
            this.Controls.Add(this.EvaluateStudent);
            this.Controls.Add(this.dgvstudents);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvstudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvstudents;
        private System.Windows.Forms.Button EvaluateStudent;
    }
}