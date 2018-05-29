using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimKeeper
{
    public partial class FormAdd : Form
    {
        public FormAdd()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt =
    DateTime.ParseExact(this.textBoxDate2.Text, "dd/MM/yyyy hh:mm tt", CultureInfo.InvariantCulture);
            
            TimeKeeperEntities db = new TimeKeeperEntities();
            List_Event ls = new List_Event();
            ls.Name = this.textBoxName.Text;
            ls.Time = dt;

            ls.Place = this.textBoxPlace.Text;
            ls.Description = this.textBoxDes.Text;
            db.List_Event.Add(ls);
            db.SaveChanges();
            this.Close();
            MessageBox.Show("Add successfully");
        }

        private void btn_ClickCancel(object sender, EventArgs e)
        {
            
                
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;
            dateTimePicker1.Value = DateTime.ParseExact(textBoxdate1.Text, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);
            this.textBoxDate2.Text = date.ToString("dd/MM/yyyy hh:mm tt");
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormAdd_Load(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            textBoxdate1.Text = d.ToString("hh:mm tt");
            textBoxDate2.Text = d.ToString("dd/MM/yyyy hh:mm tt");
        }

        private void textBoxdate1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string str = this.textBoxDate2.Text;
                string[] arrListStr = str.Split(' ');
                string s0 = arrListStr[1] + " " + arrListStr[2];
                s0 = this.textBoxdate1.Text;
                string s = arrListStr[0] + " " + s0;
                this.textBoxDate2.Text = s;
                textBoxdate1.SelectionStart = 0;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
