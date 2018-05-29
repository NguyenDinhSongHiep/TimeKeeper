using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimKeeper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_Event();
        }
        private void Load_Event()
        {
            TimeKeeperEntities db = new TimeKeeperEntities(); // create connection to your database
            this.dataList.DataSource = db.List_Event.ToList(); // get the list of students from database, then assign to DataSource of data grid view
            this.dataList.Columns["id"].Visible = false; // hide the id column
            

        }

        private void data1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_ClickAdd(object sender, EventArgs e)
        {
            
                FormAdd dlg2 = new FormAdd();
                dlg2.ShowDialog();
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_Event();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataList.SelectedRows.Count == 1)
            {
                var row = dataList.SelectedRows[0];
                var cell = row.Cells["Id"];
                int id = (int)cell.Value;
                TimeKeeperEntities db = new TimeKeeperEntities();
                List_Event ls = db.List_Event.Single(le => le.Id == id);
                db.List_Event.Remove(ls);
                db.SaveChanges();
                MessageBox.Show("Delete sucessfully");
                Load_Event();
            }
            else
            {
                MessageBox.Show("You should a row");
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataList.SelectedRows.Count == 1)
            {
                var row = dataList.SelectedRows[0];
                var cell = row.Cells["Id"];
                int id = (int)cell.Value;
                FormEdit dlg2 = new FormEdit(id);
                dlg2.ShowDialog();

            }
            else
            {
                MessageBox.Show("You should a row");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
