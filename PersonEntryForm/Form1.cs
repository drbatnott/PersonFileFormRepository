using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PersonEntryForm
{
    public partial class PersonDataEntryForm : Form
    {
        PersonClass person;
        List<PersonClass> persons;
        public PersonDataEntryForm()
        {
            InitializeComponent();
        }

        private void PersonDataEntryForm_Load(object sender, EventArgs e)
        {
            persons = new List<PersonClass>();
        }

        private void addDataButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            float massInKg = (float)Double.Parse(massKgTextBox.Text);
            person = new PersonClass(name, massInKg);
            persons.Add(person);
            if(dataListBox.Items.Count > 0)
            {
                dataListBox.Items.Clear();
            }
            foreach(PersonClass p in persons)
            {
                dataListBox.Items.Add("Name, " + p.Name);
                dataListBox.Items.Add("Mass in kg, " + p.Mass);
            }
            saveToolStripMenuItem.Enabled = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Csv Files (*.csv)|*.csv|Text Files(*.txt)|*.txt";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                TextWriter tw = new StreamWriter(saveFileDialog.FileName);
                tw.WriteLine("Person Name,Person Mass Kg");
                foreach(PersonClass p in persons)
                {
                    tw.WriteLine(p.Name + "," + p.Mass);
                }
                tw.Close();

            }
        }
    }
}
