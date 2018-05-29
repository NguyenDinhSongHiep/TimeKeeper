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
    public partial class FormEdit : Form
    {
        public FormEdit(int id)
        {
            InitializeComponent();
            db = new TimeKeeperEntities();
            le = db.List_Event.Single(ls => ls.Id == id);


        }
        TimeKeeperEntities db;
        private List_Event le;

        private void lbName2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormEdit_Load(object sender, EventArgs e)
        {
            DateTime d = new DateTime();
            d = DateTime.Now;
            textBoxDate.Text = d.ToString("hh:mm tt");
            this.textboxName.Text = le.Name;
            this.textBoxPlace.Text = le.Place;
            this.textBoxDes.Text = le.Description;
            this.textBox1.Text = le.Time.ToString("MM/dd/yyyy hh:mm tt");
        }

        private void btnSave2_Click(object sender, EventArgs e)
        {
            DateTime dt =
    DateTime.ParseExact(this.textBox1.Text.ToString(), "MM/dd/yyyy hh:mm tt", CultureInfo.InvariantCulture);
            le.Name = this.textboxName.Text;
            le.Time = dt;
            le.Place = this.textBoxPlace.Text;
            le.Description = this.textBoxDes.Text;
            db.Entry(le).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            this.Close();
            MessageBox.Show("Edit successfully");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;
            dateTimePicker1.Value = DateTime.ParseExact(textBoxDate.Text, "hh:mm tt", System.Globalization.CultureInfo.CurrentCulture);
            this.textBox1.Text = date.ToString("MM/dd/yyyy hh:mm tt");
        }

        private void textBoxDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                string str = this.textBox1.Text;
                string[] arrListStr = str.Split(' ');
                string s0 = arrListStr[1] + " " + arrListStr[2];
                s0 = this.textBoxDate.Text;
                string s = arrListStr[0] + " " + s0;
                this.textBox1.Text = s;
                textBoxDate.SelectionStart = 0;
            }
        }
    }
}
