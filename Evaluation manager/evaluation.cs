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
    public partial class evaluation : Form {

        private student student;
        public evaluation(student selectedStudent) {
            InitializeComponent();
            student = selectedStudent;
        }
        private student selectedStudent = null;

        private void evaluation_Load(object sender, EventArgs e) {
            SetFormText();
            var activities = ActivityRepository.GetActivities();
            cboActivities.DataSource = activities;
        }
        private void SetFormText() {
            Text = student.FirstName + " " + student.LastName;
        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e) {
            var currentActivity = cboActivities.SelectedItem as Activity;
            txtAktivnost.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.MinPointsForGrade + "/" +
           currentActivity.MaxPoints;
            txtMinForSignature.Text = currentActivity.MinPointsForSignature + "/" +
           currentActivity.MaxPoints;
            numBod.Minimum = 0;
            numBod.Maximum = currentActivity.MaxPoints;
        }


        private void label4_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void txtBig_TextChanged(object sender, EventArgs e) {

        }


        private void btnSave_Click(object sender, EventArgs e) {

        }

        private void btnCancel_Click_1(object sender, EventArgs e) {
            Close();
        }
    }
}
