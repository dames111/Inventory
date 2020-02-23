using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Inventory
{
    public partial class Form1 : Form
    {

        List<Person> people = new List<Person>();
        public Form1()
        {
            InitializeComponent();

            peopleFoundListBox.DataSource = people;
            peopleFoundListBox.DisplayMember = "FullInfo";

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

           people = db.GetPeople(LastNameText.Text);
        }


        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void PeopleFoundListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
