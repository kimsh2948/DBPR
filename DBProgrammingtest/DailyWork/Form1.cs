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
            listViewWorkList.FullRowSelect = true;

            listViewWorkList.Columns.Add("번호", 55);
            listViewWorkList.Columns.Add("대분류", 150);
            listViewWorkList.Columns.Add("중분류", 150);
            listViewWorkList.Columns.Add("소분류", 150);
        }

        private void buttonWorkReg_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
        private void buttonWorkMod_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(this);
            form3.Show();
        }

        private void buttonLoadWorkList_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            List<WorkCategory> worklist = form2.LoadWork();
            listViewWorkList.BeginUpdate();
            ListViewItem item;
            int i = 0;
            while (i < worklist.Count)
            {
                WorkCategory workcategory = new WorkCategory();
                workcategory = worklist[i];
                item = new ListViewItem(Convert.ToString(workcategory.id));
                item.SubItems.Add(workcategory.MainCategory);
                item.SubItems.Add(workcategory.MiddleCategory);
                item.SubItems.Add(workcategory.SubCategory);

                listViewWorkList.Items.Add(item);

                i++;
            }
            listViewWorkList.EndUpdate();
        }


    }
}
