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
        string username = "tracic21";
        string password = "sifra";

        private void label1_Click(object sender, EventArgs e) {

        }

        private void Form1_Load(object sender, EventArgs e) {
            
        }

        public void txt_ime_TextChanged(object sender, EventArgs e) {

        }

        public void txt_lozinka_TextChanged(object sender, EventArgs e) {

        }

        private void button1_Click(object sender, EventArgs e) {
            if (txt_ime.Text == "") {
                MessageBox.Show("Korisničko ime nije uneseno!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else if (txt_lozinka.Text == "") {
                MessageBox.Show("Lozinka nije unesena!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            } else {
                if (txt_ime.Text == username && txt_lozinka.Text == password) {
                    Form2 frmStudents = new Form2();
                    frmStudents.ShowDialog();
                } else {
                    MessageBox.Show("Krivi podaci!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }
        }

        
    }
}
