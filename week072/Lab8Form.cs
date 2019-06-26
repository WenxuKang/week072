using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week072
{
    public partial class Lab8Form : Form
    {
        public string UserName{get; set;}
        public float UserAge { get; set; }

        public Lab8Form()
        {
            InitializeComponent();
        }

        private void Lab08_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void NameLabel_Click(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitButton.Enabled = (NameTextBox.Text.Length < 2) ? false : true;


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            UserName = NameTextBox.Text;


            UserAge = float.Parse(Agetextbox.Text);


            outputLabel.Text = NameTextBox.Text + " " + Agetextbox.Text;
            ClearForm();

        }

        private void ClearForm()
        {
            NameTextBox.Clear();
            Agetextbox.Clear();
            SubmitButton.Enabled = true;
        }

        private void Agetextbox_TextChanged(object sender, EventArgs e)
        {


            if(Agetextbox.Text.Length > 0)
            {
                try
                {
                    float.Parse(Agetextbox.Text);
                    SubmitButton.Enabled = true;
                }
                catch
                {
                    throw;
                }
            }
            else
            {
                SubmitButton.Enabled = false;
            }
                
        }

        private void Lab8Form_Load(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
