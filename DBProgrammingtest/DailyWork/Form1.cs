using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DailyWork
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitListView();
        }
        public void InitListView()
        {
            listViewWorkList.View = View.Details;
            listViewWorkList.GridLines = true;

            listViewWorkList.Columns.Add("번호", 55);
            listViewWorkList.Columns.Add("대분류", 150);
            listViewWorkList.Columns.Add("중분류", 150);
            listViewWorkList.Columns.Add("소분류", 150);
        }

        private void buttonWorkReg_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
