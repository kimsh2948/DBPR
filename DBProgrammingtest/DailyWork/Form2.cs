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
            this.dateTimePickerInsertWork.Format = DateTimePickerFormat.Custom;
            this.dateTimePickerInsertWork.CustomFormat = "yyyy-MM-dd";

            this.dateTimePickerStartTime.ShowUpDown = true;
            this.dateTimePickerStartTime.Format = DateTimePickerFormat.Time;
            this.dateTimePickerStartTime.CustomFormat = "hh:mm";

            this.dateTimePickerEndTime.ShowUpDown = true;
            this.dateTimePickerEndTime.Format = DateTimePickerFormat.Time;
            this.dateTimePickerEndTime.CustomFormat = "hh:mm";

        }
        private void buttonWorkRegSave_Click(object sender, EventArgs e)
        {
            AddWork();
            AddListView();
        }
        public void AddWork()
        {
            WorkCategory workcategory = new WorkCategory();
            var day = dateTimePickerInsertWork.Text;
            var start_time = dateTimePickerStartTime.Text;
            var end_time = dateTimePickerEndTime.Text;
            var maincategory = comboBoxMainCate.Text;
            var middlecategory = comboBoxMiddleCate.Text;
            var subcategory = comboBoxSubCate.Text;
            string query = "INSERT INTO dailywork(id, Day, StartTime, EndTime, MainCategory, MiddleCategory, SubCategory) " +
                "VALUES('"+workcategory.id+ "','" + day + "','" + start_time + "','" + end_time + "','" + maincategory + "', '" + middlecategory + "','" + subcategory + "')";
            if (maincategory == "대분류" || middlecategory == "중분류" || subcategory == "소분류")//세가지 모두 선택해야 저장
            {
                MessageBox.Show("모든 항목을 선택하세요");
            }
            else
            {
                DBManager.GetInstace().DBquery(query);
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
                workcategory.day = (string)rdr["Day"];
                workcategory.start_time = (string)rdr["StartTime"];
                workcategory.end_time = (string)rdr["EndTime"];
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
            if (form1.listViewWorkList.Items.Count > 0)//listview에 아이템 있으면 지우고 로드
            {
                form1.listViewWorkList.Items.Clear();
            }
            List<WorkCategory> worklist = LoadWork();
            form1.listViewWorkList.BeginUpdate();
            ListViewItem item;
            int i = 0;
            while (i < worklist.Count)//listview에 삽입
            {
                WorkCategory workcategory = new WorkCategory();
                workcategory = worklist[i];
                item = new ListViewItem(Convert.ToString(workcategory.id));
                item.SubItems.Add(workcategory.day);
                item.SubItems.Add(workcategory.start_time);
                item.SubItems.Add(workcategory.end_time);
                item.SubItems.Add(workcategory.MainCategory);
                item.SubItems.Add(workcategory.MiddleCategory);
                item.SubItems.Add(workcategory.SubCategory);

                form1.listViewWorkList.Items.Add(item);

                i++;
            }
            form1.listViewWorkList.EndUpdate();
        }
        public void TimeOverlap()
        {
            //dateTimePickerStartTime.Value
        }

    }
}
