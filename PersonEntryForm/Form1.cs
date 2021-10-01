using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonEntryForm
{
    public partial class PersonDataEntryForm : Form
    {
        public PersonDataEntryForm()
        {
            InitializeComponent();
        }

        private void PersonDataEntryForm_Load(object sender, EventArgs e)
        {

        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            float massInKg = (float)Double.Parse(massKgTextBox.Text);
            dataListBox.Items.Add("Name, " + name);
            dataListBox.Items.Add("Mass in kg, " + massInKg);
        }
    }
}
