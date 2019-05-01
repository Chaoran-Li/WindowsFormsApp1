using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        Form2 newForm;
        public Form1()
        {
            InitializeComponent();
        }

        string FName, LName, DOB, Gender, Country;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        DialogResult result;
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("First Name: " + FName + "\n" + "DOB" + DOB + "\n" 
                + "Gender" + Gender + "\n" + "Country" + Country, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            result = MessageBox.Show("Do you want to enter more information?", "More info", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Question);

            if (DialogResult.Yes == result)
            {
                newForm = new Form2();
                newForm.Show();
            }
            else if (DialogResult.No == result)
            {
                Close();
            }
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            FName = textBox1.Text.ToUpper();
            LName = textBox2.Text.ToUpper();
            DOB = dateTimePicker1.Text;
            
            if (radioButton1.Checked == true)
            {
                Gender = "Male";
            }
            else if (radioButton2.Checked == true)
            {
                Gender = "Female";
            }

            Country = comboBox1.Text.ToUpper();
        }
    }
}
