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
    public partial class Form3 : Form
    {
        Form1 form1;
        public Form3()
        {
            InitializeComponent();
            InitVariables();
            this.buttonWorkModSave.Click += buttonWorkModSave_Click;
        }
        public Form3(Form1 form)
        {
            InitializeComponent();
            form1 = form;
        }
        public void InitVariables()
        {

        }

        private void buttonWorkModSave_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            ModWork();
            form2.AddListView();
        }
        
        public void ModWork()
        {
            int indexnum = form1.listViewWorkList.FocusedItem.Index + 1;
            string query = "SELECT * FROM dailywork";

            string maincategory = comboBoxMainCateMod.Text;
            string middlecategory = comboBoxMiddleCateMod.Text;
            string subcategory = comboBoxSubCateMod.Text;
            query = "UPDATE dailywork SET MainCategory = @maincategory, MiddleCategory = " +
                "@middlecategory, SubCategory = @subcategory WHERE id='"+indexnum+"'";

            if (maincategory == "대분류" || middlecategory == "중분류" || subcategory == "소분류")
            {
                MessageBox.Show("항목을 수정해 주세요");
            }
            else
            {
                DBManager.GetInstace().Update(query, maincategory, middlecategory, subcategory);
                this.Close();
            }
        }
    }
}
