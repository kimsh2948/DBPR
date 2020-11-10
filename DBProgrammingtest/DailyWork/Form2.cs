using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace DailyWork
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            InitVariables();
        }

        public void InitVariables()
        {

        }
        private void buttonWorkRegSave_Click(object sender, EventArgs e)
        {
            string maincategory = comboBoxMainCate.Text;
            string middlecategory = comboBoxMiddleCate.Text;
            string subcategory = comboBoxSubCate.Text;
            string query = "INSERT INTO dailywork(MainCategory, MiddleCategory, SubCategory) " +
                "VALUES('"+ maincategory + "', '" + middlecategory + "','" + subcategory + "')";
            if(maincategory == "대분류" || middlecategory == "중분류" || subcategory == "소분류")
            {
                MessageBox.Show("모든 항목을 선택하세요");
            }
            else
            {
                DBManager.GetInstace().Insert(query);

                /*
                Form1 form1 = new Form1();
                query = "SELECT * FROM dailywork";
                MySqlDataReader rdr = DBManager.GetInstace().Select(query);
                string str = string.Format("{0} : {1}", rdr["MainCategory"], rdr["MiddleCategory"]);
                */

                Form2 form2 = new Form2();
                form2.Close();
            }


        }
    }
}
