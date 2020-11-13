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
            if (listViewWorkList.SelectedIndices.Count > 0)
            {
                Form3 form3 = new Form3(this);
                form3.Show();
            }
            else
            {
                MessageBox.Show("항목을 선택해 주세요");
            }

        }

        private void buttonLoadWorkList_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            int i = 0;
            List<WorkCategory> worklist = form2.LoadWork();
            if (listViewWorkList.Items.Count > 0) {
                listViewWorkList.Items.Clear();
            }
            listViewWorkList.BeginUpdate();
            ListViewItem item;
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

        private void buttonWorkDel_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            int indexnum = listViewWorkList.FocusedItem.Index + 1;
            if (MessageBox.Show("선택하신 업무가 삭제됩니다", "업무 삭제", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string query = "DELETE FROM dailywork WHERE id = '"+indexnum+"'";
                DBManager.GetInstace().DBquery(query);
                query = "ALTER TABLE dailywork AUTO_INCREMENT = '" + indexnum + "'";
                //DBManager.GetInstace().DBquery(query);
            }
            else
            {
                MessageBox.Show("삭제를 취소하셨습니다.");
            }
        }
    }
}
