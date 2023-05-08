using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_manager {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e) {
            ShowStudents();
        }
        private void ShowStudents() {
            StudentRepository repository = new StudentRepository();
            List<student> students = repository.GetStudents();
            dgvstudents.DataSource = students;
        }

        private void dgvstudents_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }



        private void EvaluateStudent_Click(object sender, EventArgs e) {
            student selectedStudent = dgvstudents.CurrentRow.DataBoundItem as student;
            if (selectedStudent != null) {
                evaluation frmEvaluation = new evaluation(selectedStudent);
                frmEvaluation.ShowDialog();
            }
        }
    }
}
