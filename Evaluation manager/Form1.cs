using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Evaluation_manager {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            if (txtUsername.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txtPassword.Text == "") {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else {
                if (txtUsername.Text == username && txtPassword.Text == password) {
                    MessageBox.Show("Dobrodošli!", "Prijavljeni ste",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            MessageBox.Show("Pritisnut sam!");
        }

        private void txt_ime_TextChanged(object sender, EventArgs e) {
            
        }

        private void txt_lozinka_TextChanged(object sender, EventArgs e) {

        }
    }
}
