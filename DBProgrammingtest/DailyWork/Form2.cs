using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DailyWork
{
    public partial class Form2 : Form
    {
        Form1 form1;

        public Form2()
        {
            InitializeComponent();
            InitVariables();
            this.buttonWorkRegSave.Click += buttonWorkRegSave_Click;
        }
        public Form2(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }

        public void InitVariables()
        {

        }
        private void buttonWorkRegSave_Click(object sender, EventArgs e)
        {
            AddWork();
            //AddListView();
        }
        public void AddWork()
        {
            var maincategory = comboBoxMainCate.Text;
            var middlecategory = comboBoxMiddleCate.Text;
            var subcategory = comboBoxSubCate.Text;
            string query = "INSERT INTO dailywork(MainCategory, MiddleCategory, SubCategory) " +
                "VALUES('" + maincategory + "', '" + middlecategory + "','" + subcategory + "')";
            if (maincategory == "대분류" || middlecategory == "중분류" || subcategory == "소분류")
            {
                MessageBox.Show("모든 항목을 선택하세요");
            }
            else
            {
                DBManager.GetInstace().Insert(query);
                this.Close();
            }
        }

        public List<WorkCategory> LoadWork()
        {
            List<WorkCategory> worklist = new List<WorkCategory>();

            string query = "SELECT * FROM dailywork";
            MySqlDataReader rdr = DBManager.GetInstace().Select(query);
            while (rdr.Read())
            {
                WorkCategory workcategory = new WorkCategory();
                workcategory.id = (int)rdr["id"];
                workcategory.MainCategory = (string)rdr["MainCategory"];
                workcategory.MiddleCategory = (string)rdr["MiddleCategory"];
                workcategory.SubCategory = (string)rdr["SubCategory"];

                worklist.Add(workcategory);
            }
            rdr.Close();
            return worklist;
        }

        public void AddListView()
        {
            List<WorkCategory> worklist = LoadWork();
            form1.listViewWorkList.BeginUpdate();
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

                form1.listViewWorkList.Items.Add(item);

                i++;
            }
            form1.listViewWorkList.EndUpdate();
        }
        
    }
}
